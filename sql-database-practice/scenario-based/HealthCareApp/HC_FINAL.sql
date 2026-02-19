USE HealthCare;
GO

--PATIENT
CREATE TABLE Patient(
	p_id INT IDENTITY(1,1) PRIMARY KEY,
	p_name VARCHAR(200) NOT NULL,
	p_dob DATE,
	p_contact VARCHAR(200) UNIQUE,
	p_address VARCHAR(255),
	p_bloodgroup VARCHAR(30),
	Created_At DATETIME2 NOT NULL DEFAULT SYSDATETIME()
);

--DOCTOR
CREATE TABLE Speciality(
	speciality_id INT IDENTITY(1,1) PRIMARY KEY,
	speciality_name VARCHAR(200) NOT NULL,
	description VARCHAR(300)
);

CREATE TABLE Doctor(
	d_id INT IDENTITY(1,1) PRIMARY KEY,
	d_name VARCHAR(200) NOT NULL,
	speciality_id INT,
	d_contact VARCHAR(30),
	d_consultationFee DECIMAL(10,2),
	d_isAvailable BIT,
	created_At DATETIME2 NOT NULL DEFAULT SYSDATETIME(),

	CONSTRAINT FK_Doctor_Speciality FOREIGN KEY(speciality_id) REFERENCES Speciality(speciality_id),
);

--APPOINTMENT SCCHEDULING
CREATE TABLE Appointment(
	appointment_id INT IDENTITY(1,1) PRIMARY KEY,
	p_id INT NOT NULL,
	d_id INT NOT NULL,
	appointmentDate DATE NOT NULL,
	appointmentTime TIME NOT NULL,
	appointmentStatus VARCHAR(30) NOT NULL,
	created_At DATETIME2 NOT NULL DEFAULT SYSDATETIME(),

	CONSTRAINT FK_Patient_Appointment FOREIGN KEY (p_id) REFERENCES Patient(p_id),
	CONSTRAINT FK_Doctor_Appointment FOREIGN KEY (d_id) REFERENCES Doctor(d_id),

	CONSTRAINT CK_Appointment_Status
        CHECK (appointmentStatus IN (
            'SCHEDULED',
            'COMPLETED',
            'CANCELLED'
        )),

    CONSTRAINT UQ_Doctor_AppointmentTime
        UNIQUE (d_id, appointmentDate, appointmentTime)
);

CREATE TABLE AppointmentAudit(
	audit_id INT IDENTITY(1,1) PRIMARY KEY,
	appointment_id INT NOT NULL,
	action VARCHAR(100) NOT NULL,
	audit_date DATETIME2 NOT NULL DEFAULT SYSDATETIME(),
	performedBy VARCHAR(200) NOT NULL,

	CONSTRAINT FK_Appointment_AppointmentAudit FOREIGN KEY (appointment_id) REFERENCES Appointment(appointment_id),
	CONSTRAINT CK_AppointmentAudit_Action
        CHECK (action IN (
            'CANCELLED',
            'RESCHEDULED'
        ))
);

--Records
CREATE TABLE Records(
	record_id INT IDENTITY(1,1) PRIMARY KEY,
	p_id INT NOT NULL,
	appointment_id INT NOT NULL,
	d_id INT NOT NULL,
	r_dataTime DATETIME2 NOT NULL DEFAULT SYSDATETIME(),
	diagnosis VARCHAR(256) NOT NULL,
	notes VARCHAR(256),

	CONSTRAINT FK_Patient_Records FOREIGN KEY (p_id) REFERENCES Patient(p_id),
	CONSTRAINT FK_Appointment_Records FOREIGN KEY (appointment_id) REFERENCES Appointment(appointment_id),
	CONSTRAINT FK_Doctor_Records FOREIGN KEY (d_id) REFERENCES Doctor(d_id)
);

CREATE TABLE Prescription (
    prescription_id INT IDENTITY(1,1) PRIMARY KEY,
    record_id INT NOT NULL,
    d_id INT NOT NULL,
    prescribed_date DATETIME2 NOT NULL DEFAULT SYSDATETIME(),

    CONSTRAINT FK_MedicalRecords_Prescription FOREIGN KEY (record_id) REFERENCES Records(record_id),
    CONSTRAINT FK_Doctor_Prescription FOREIGN KEY (d_id) REFERENCES Doctor(d_id)
);

CREATE TABLE PrescriptionDetails (
    prescription_detail_id INT IDENTITY(1,1) PRIMARY KEY,
    prescription_id INT NOT NULL,
    medicineName VARCHAR(250) NOT NULL,
    dosage VARCHAR(100) NOT NULL,
    duration VARCHAR(100) NOT NULL,
    instructions VARCHAR(255),

    CONSTRAINT FK_Prescription_PrescriptionDetails FOREIGN KEY (prescription_id) REFERENCES Prescription(prescription_id)
);

--Billing & Payments
CREATE TABLE Billing(
	bill_id INT IDENTITY(1,1) PRIMARY KEY,
	p_id INT NOT NULL,
	d_id INT NOT NULL,
	record_id INT NOT NULL,
	d_consultationFee DECIMAL(10,2) NOT NULL,
	additionalCharge DECIMAL(10,2) DEFAULT 0,
	totalAmt DECIMAL(10,2) NOT NULL,
	paymentStatus VARCHAR(200) NOT NULL,
	bill_dateTime DATETIME2 NOT NULL DEFAULT SYSDATETIME(),

	CONSTRAINT FK_Patient_Billing FOREIGN KEY (p_id) REFERENCES Patient(p_id),

	CONSTRAINT FK_Doctor_Billing FOREIGN KEY (d_id) REFERENCES Doctor(d_id),

	CONSTRAINT FK_Records_Billing FOREIGN KEY (record_id) REFERENCES Records(record_id),

	CONSTRAINT CK_Billing_Status
		CHECK(paymentStatus IN ('PAID',	'UNPAID'))
);

CREATE TABLE Transactions(
	transaction_id INT IDENTITY(1,1) PRIMARY KEY,
	bill_id INT NOT NULL,
	t_dateTime DATETIME2 NOT NULL DEFAULT SYSDATETIME(),
	t_mode VARCHAR(100) NOT NULL,
	amount_Paid DECIMAL(10,2) NOT NULL,

	CONSTRAINT FK_Billing_Transactions FOREIGN KEY(bill_id) REFERENCES Billing(bill_id),

	CONSTRAINT CK_Transactions_Mode
		CHECK(t_mode IN('CARD',	'ONLINE', 'CASH'))
);

--Audit table
CREATE TABLE Users (
    user_id INT IDENTITY(1,1) PRIMARY KEY,
    username VARCHAR(100) NOT NULL UNIQUE,
    user_role VARCHAR(30) NOT NULL,
    is_active BIT NOT NULL DEFAULT 1,
    created_at DATETIME2 NOT NULL DEFAULT SYSDATETIME(),

    CONSTRAINT CK_User_Role
        CHECK (user_role IN (
            'ADMIN',
            'RECEPTIONIST',
            'DOCTOR',
            'SYSTEM'
        ))
);

CREATE TABLE Audit_Log (
    log_id INT IDENTITY(1,1) PRIMARY KEY,
    user_id INT NOT NULL,
    action_type VARCHAR(10) NOT NULL,
    table_name VARCHAR(128) NOT NULL,
    record_id INT NOT NULL,
    action_timestamp DATETIME2 NOT NULL DEFAULT SYSDATETIME(),

    CONSTRAINT FK_AuditLog_User
        FOREIGN KEY (user_id) REFERENCES Users(user_id),

    CONSTRAINT CK_AuditLog_ActionType
        CHECK (action_type IN ('INSERT', 'UPDATE', 'DELETE'))
);


ALTER TABLE Doctor
ADD user_id INT;
GO

ALTER TABLE Doctor
ADD CONSTRAINT FK_Doctor_User
    FOREIGN KEY (user_id) REFERENCES Users(user_id),
    CONSTRAINT UQ_Doctor_User
    UNIQUE (user_id);
GO


/*Stored Procedures
usp_Patient_Insert
usp_Patient_Update
usp_Patient_Delete (soft delete recommended)

Trigger
Audit trigger (INSERT, UPDATE, DELETE → Audit_Log)*/

CREATE PROCEDURE usp_Patient_Insert
	@p_name VARCHAR(200),
	@p_dob DATE,
	@p_contact VARCHAR(200),
	@p_address VARCHAR(255),
	@p_bloodgroup VARCHAR(30)
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO Patient
	(p_name, p_dob, p_contact, p_address, p_bloodgroup)
	VALUES
	(@p_name, @p_dob, @p_contact, @p_address, @p_bloodgroup);
END;
GO

CREATE PROCEDURE usp_Patient_Update
	@p_id INT,
	@p_name VARCHAR(200),
	@p_dob DATE,
	@p_contact VARCHAR(200),
	@p_address VARCHAR(255),
	@p_bloodgroup VARCHAR(30)
AS 
BEGIN
	SET NOCOUNT ON;

	UPDATE Patient
	SET
		p_name = @p_name,
		p_dob = @p_dob,
		p_contact = @p_contact,
		p_address = @p_address,
		p_bloodgroup = @p_bloodgroup
	WHERE p_id = @p_id;
END;
GO

ALTER TABLE Patient
ADD is_active BIT NOT NULL DEFAULT 1;

CREATE PROCEDURE usp_Patient_Delete
	@p_id INT
AS 
BEGIN
	SET NOCOUNT ON;
	
	UPDATE Patient
	SET is_active = 0
	WHERE p_id = @p_id;
END;
GO

EXEC sp_set_session_context @key = 'user_id', @value = 5;

CREATE OR ALTER TRIGGER trg_Patient_Audit
ON Patient
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @user_id INT = ISNULL(CAST(SESSION_CONTEXT(N'user_id') AS INT), 0);


	--INSERT 
	INSERT INTO Audit_Log (user_id, action_type, table_name, record_id)
	SELECT @user_id, 'INSERT', 'Patient', i.p_id
	FROM inserted i
	WHERE NOT EXISTS (
		SELECT 1 FROM deleted d WHERE d.p_id = i.p_id
	);

	--UPDATE
	INSERT INTO Audit_Log (user_id, action_type, table_name, record_id)
	SELECT @user_id, 'UPDATE', 'Patient', i.p_id
	FROM inserted i
	INNER JOIN deleted d ON i.p_id = d.p_id;

	--DELETE
	INSERT INTO Audit_Log (user_id, action_type, table_name, record_id)
	SELECT @user_id, 'DELETE', 'Patient', d.p_id
	FROM deleted d
	WHERE NOT EXISTS (
		SELECT 1 FROM inserted i WHERE i.p_id = d.p_id
	);

END;
GO


/*DOCTOR
Stored Procedures:
usp_Doctor_Insert
usp_Doctor_Update
usp_Doctor_Deactivate (NOT hard delete)

Trigger
Audit trigger*/

CREATE PROCEDURE usp_Doctor_Insert
	@d_name VARCHAR(200),
	@speciality_id INT,
	@d_contact VARCHAR(30),
	@d_consultationFee DECIMAL(10,2),
	@d_isAvailable BIT
AS BEGIN
	SET NOCOUNT ON

	INSERT INTO Doctor
	(d_name, speciality_id, d_contact, d_consultationFee, d_isAvailable)
	VALUES
	(@d_name, @speciality_id, @d_contact, @d_consultationFee, @d_isAvailable);
END;
GO

CREATE PROCEDURE usp_Doctor_Update
	@d_id INT,
	@d_name VARCHAR(200),
	@speciality_id INT,
	@d_contact VARCHAR(30),
	@d_consultationFee DECIMAL(10,2),
	@d_isAvailable BIT
AS BEGIN
	SET NOCOUNT ON

	UPDATE Doctor
	SET
		d_name = @d_name,
		speciality_id = @speciality_id,
		d_contact = @d_contact,
		d_consultationFee = @d_consultationFee,
		d_isAvailable = @d_isAvailable
	WHERE d_id = @d_id
END;
GO

IF COL_LENGTH('Doctor','is_Active') IS NULL
BEGIN
    ALTER TABLE Doctor
    ADD is_Active BIT NOT NULL DEFAULT 1;
END
GO

CREATE PROCEDURE usp_Doctor_Delete
	@d_id INT	
AS BEGIN
	SET NOCOUNT ON

	Update Doctor
	SET is_Active = 0
	WHERE d_id = @d_id;
END;
GO
	
CREATE OR ALTER TRIGGER trg_Doctor_Audit
ON Doctor
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @user_id INT = ISNULL(CAST(SESSION_CONTEXT(N'user_id') AS INT), 0);

	--INSERT 
	INSERT INTO Audit_Log (user_id, action_type, table_name, record_id)
	SELECT @user_id, 'INSERT', 'Doctor', i.d_id
	FROM inserted i
	WHERE NOT EXISTS (
		SELECT 1 FROM deleted d WHERE d.d_id = i.d_id
	);

	--UPDATE
	INSERT INTO Audit_Log (user_id, action_type, table_name, record_id)
	SELECT @user_id, 'UPDATE', 'Doctor', i.d_id
	FROM inserted i
	INNER JOIN deleted d ON i.d_id = d.d_id;

	--DELETE
	INSERT INTO Audit_Log (user_id, action_type, table_name, record_id)
	SELECT @user_id, 'DELETE', 'Doctor', d.d_id
	FROM deleted d
	WHERE NOT EXISTS (
		SELECT 1 FROM inserted i WHERE i.d_id = d.d_id
	);

END;
GO



/*APPOINTMENT
Stored Procedures:
usp_Appointment_Insert
usp_Appointment_Update
usp_Appointment_Cancel
usp_Appointment_Delete (usually not allowed)

Trigger:
Insert into AppointmentAudit
Audit_Log trigger*/

--INSERT
CREATE PROCEDURE usp_Appointment_Insert
    @p_id INT,
    @d_id INT,
    @appointmentDate DATE,
    @appointmentTime TIME,
    @appointmentStatus VARCHAR(30)
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Appointment
    (p_id, d_id, appointmentDate, appointmentTime, appointmentStatus)
    VALUES
    (@p_id, @d_id, @appointmentDate, @appointmentTime, @appointmentStatus);
END;
GO

--UPDATE
CREATE PROCEDURE usp_Appointment_Update
    @appointment_id INT,
    @appointmentDate DATE,
    @appointmentTime TIME,
    @appointmentStatus VARCHAR(30)
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE Appointment
    SET
        appointmentDate = @appointmentDate,
        appointmentTime = @appointmentTime,
        appointmentStatus = @appointmentStatus
    WHERE appointment_id = @appointment_id;
END;
GO

--CANCEL
CREATE PROCEDURE usp_Appointment_Cancel
    @appointment_id INT
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE Appointment
    SET appointmentStatus = 'CANCELLED'
	WHERE appointment_id = @appointment_id
	AND appointmentStatus <> 'CANCELLED';

END;
GO


--TRIGGERS
CREATE OR ALTER TRIGGER trg_Appointment_Audit
ON Appointment
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @user_id INT =
        ISNULL(CAST(SESSION_CONTEXT(N'user_id') AS INT), 0);

    -- INSERT
    INSERT INTO AppointmentAudit
        (appointment_id, action, audit_date, performedBy)
    SELECT i.appointment_id, 'INSERT', SYSDATETIME(), @user_id
    FROM inserted i
    WHERE NOT EXISTS (
        SELECT 1
        FROM deleted d
        WHERE d.appointment_id = i.appointment_id
    );

    -- UPDATE
    INSERT INTO AppointmentAudit
        (appointment_id, action, audit_date, performedBy)
    SELECT i.appointment_id, 'UPDATE', SYSDATETIME(), @user_id
    FROM inserted i
    INNER JOIN deleted d
        ON i.appointment_id = d.appointment_id;

    -- DELETE
    INSERT INTO AppointmentAudit
        (appointment_id, action, audit_date, performedBy)
    SELECT d.appointment_id, 'DELETE', SYSDATETIME(), @user_id
    FROM deleted d
    WHERE NOT EXISTS (
        SELECT 1
        FROM inserted i
        WHERE i.appointment_id = d.appointment_id
    );
END;
GO

CREATE OR ALTER TRIGGER trg_Appointment_Log
ON Appointment
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @user_id INT =
        ISNULL(CAST(SESSION_CONTEXT(N'user_id') AS INT), 0);

    -- INSERT
    INSERT INTO Audit_Log
        (user_id, action_type, table_name, record_id)
    SELECT @user_id, 'INSERT', 'Appointment', i.appointment_id
    FROM inserted i
    WHERE NOT EXISTS (
        SELECT 1
        FROM deleted d
        WHERE d.appointment_id = i.appointment_id
    );

    -- UPDATE
    INSERT INTO Audit_Log
        (user_id, action_type, table_name, record_id)
    SELECT @user_id, 'UPDATE', 'Appointment', i.appointment_id
    FROM inserted i
    INNER JOIN deleted d
        ON i.appointment_id = d.appointment_id;

    -- DELETE
    INSERT INTO Audit_Log
        (user_id, action_type, table_name, record_id)
    SELECT @user_id, 'DELETE', 'Appointment', d.appointment_id
    FROM deleted d
    WHERE NOT EXISTS (
        SELECT 1
        FROM inserted i
        WHERE i.appointment_id = d.appointment_id
    );
END;
GO



/*RECORDS
Stored Procedures:
usp_Record_Insert
usp_Record_Update
Delete NOT allowed (medical compliance)

Trigger:
Update appointment status to COMPLETED
Audit_Log trigger*/

CREATE OR ALTER PROCEDURE usp_Record_Insert
    @p_id INT,
    @appointment_id INT,
    @d_id INT,
    @diagnosis VARCHAR(256),
    @notes VARCHAR(256) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Records
        (p_id, appointment_id, d_id, diagnosis, notes)
    VALUES
        (@p_id, @appointment_id, @d_id, @diagnosis, @notes);
END;
GO

CREATE OR ALTER PROCEDURE usp_Record_Update
    @record_id INT,
    @diagnosis VARCHAR(256),
    @notes VARCHAR(256)
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE Records
    SET
        diagnosis = @diagnosis,
        notes = @notes
    WHERE record_id = @record_id;
END;
GO

--TRIGGER
CREATE OR ALTER TRIGGER trg_Record_CompleteAppointment
ON Records
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE a
    SET appointmentStatus = 'COMPLETED'
    FROM Appointment a
    INNER JOIN inserted i
        ON a.appointment_id = i.appointment_id;
END;
GO

CREATE OR ALTER TRIGGER trg_Record_Audit
ON Records
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @user_id INT =
        ISNULL(CAST(SESSION_CONTEXT(N'user_id') AS INT), 0);

    -- INSERT
    INSERT INTO Audit_Log
        (user_id, action_type, table_name, record_id)
    SELECT @user_id, 'INSERT', 'Record', i.record_id
    FROM inserted i
    WHERE NOT EXISTS (
        SELECT 1
        FROM deleted d
        WHERE d.record_id = i.record_id
    );

    -- UPDATE
    INSERT INTO Audit_Log
        (user_id, action_type, table_name, record_id)
    SELECT @user_id, 'UPDATE', 'Record', i.record_id
    FROM inserted i
    INNER JOIN deleted d
        ON i.record_id = d.record_id;
END;
GO


/*PRESCRIPTION / DETAILS
Stored Procedures
usp_Prescription_Insert
usp_Prescription_Update

Triggers usually not required unless auditing mandatory.*/

CREATE OR ALTER PROCEDURE usp_Prescription_Insert
    @record_id INT,
    @d_id INT
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Prescription
        (record_id, d_id)
    VALUES
        (@record_id, @d_id);
END;
GO

CREATE OR ALTER PROCEDURE usp_Prescription_Update
    @prescription_id INT,
    @d_id INT
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE Prescription
    SET d_id = @d_id
    WHERE prescription_id = @prescription_id;
END;
GO

--TRIGGER
CREATE OR ALTER TRIGGER trg_Prescription_Audit
ON Prescription
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @user_id INT =
        ISNULL(CAST(SESSION_CONTEXT(N'user_id') AS INT), 0);

    -- INSERT
    INSERT INTO Audit_Log
        (user_id, action_type, table_name, record_id)
    SELECT @user_id, 'INSERT', 'Prescription', i.prescription_id
    FROM inserted i
    WHERE NOT EXISTS (
        SELECT 1 FROM deleted d
        WHERE d.prescription_id = i.prescription_id
    );

    -- UPDATE
    INSERT INTO Audit_Log
        (user_id, action_type, table_name, record_id)
    SELECT @user_id, 'UPDATE', 'Prescription', i.prescription_id
    FROM inserted i
    INNER JOIN deleted d
        ON i.prescription_id = d.prescription_id;
END;
GO


/*BILLING
Stored Procedures
usp_Bill_Generate
usp_Bill_Update
usp_Bill_Delete (rarely allowed)

Trigger
Auto-calc total
Audit_Log trigger*/

CREATE OR ALTER PROCEDURE usp_Bill_Generate
    @p_id INT,
    @d_id INT,
    @record_id INT,
    @d_consultationFee DECIMAL(10,2),
    @additionalCharge DECIMAL(10,2) = 0,
    @paymentStatus VARCHAR(200)
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Billing
        (p_id, d_id, record_id,
         d_consultationFee, additionalCharge,
         totalAmt, paymentStatus)
    VALUES
        (@p_id, @d_id, @record_id,
         @d_consultationFee, @additionalCharge,
         0,                -- will be auto-calculated
         @paymentStatus);
END;
GO

CREATE OR ALTER PROCEDURE usp_Bill_Update
    @bill_id INT,
    @additionalCharge DECIMAL(10,2),
    @paymentStatus VARCHAR(200)
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE Billing
    SET
        additionalCharge = @additionalCharge,
        paymentStatus = @paymentStatus
    WHERE bill_id = @bill_id;
END;
GO

--TRIGGER
CREATE OR ALTER TRIGGER trg_Bill_AutoTotal
ON Billing
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE b
    SET totalAmt =
        b.d_consultationFee +
        ISNULL(b.additionalCharge, 0)
    FROM Billing b
    INNER JOIN inserted i
        ON b.bill_id = i.bill_id;
END;
GO

CREATE OR ALTER TRIGGER trg_Bill_Audit
ON Billing
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @user_id INT =
        ISNULL(CAST(SESSION_CONTEXT(N'user_id') AS INT), 0);

    -- INSERT
    INSERT INTO Audit_Log
        (user_id, action_type, table_name, record_id)
    SELECT @user_id, 'INSERT', 'Bill', i.bill_id
    FROM inserted i
    WHERE NOT EXISTS (
        SELECT 1
        FROM deleted d
        WHERE d.bill_id = i.bill_id
    );

    -- UPDATE
    INSERT INTO Audit_Log
        (user_id, action_type, table_name, record_id)
    SELECT @user_id, 'UPDATE', 'Bill', i.bill_id
    FROM inserted i
    INNER JOIN deleted d
        ON i.bill_id = d.bill_id;
END;
GO


/*TRANSACTIONS
Stored Procedures
usp_Transaction_Insert
usp_Transaction_Update
usp_Transaction_Delete

Trigger
Auto-update Billing.paymentStatus when fully paid
Audit_Log trigger*/

CREATE OR ALTER PROCEDURE usp_Transaction_Insert
    @bill_id INT,
    @t_mode VARCHAR(100),
    @amount_Paid DECIMAL(10,2)
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Transactions
        (bill_id, t_mode, amount_Paid)
    VALUES
        (@bill_id, @t_mode, @amount_Paid);
END;
GO

CREATE OR ALTER PROCEDURE usp_Transaction_Update
    @transaction_id INT,
    @t_mode VARCHAR(100),
    @amount_Paid DECIMAL(10,2)
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE Transactions
    SET
        t_mode = @t_mode,
        amount_Paid = @amount_Paid
    WHERE transaction_id = @transaction_id;
END;
GO

CREATE OR ALTER PROCEDURE usp_Transaction_Delete
    @transaction_id INT
AS
BEGIN
    SET NOCOUNT ON;

    DELETE FROM Transactions
    WHERE transaction_id = @transaction_id;
END;
GO

--TRIGGER

CREATE OR ALTER TRIGGER trg_Transaction_UpdateBillStatus
ON Transactions
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;

    ;WITH ChangedBills AS
    (
        SELECT bill_id FROM inserted
        UNION
        SELECT bill_id FROM deleted
    )
    UPDATE b
    SET paymentStatus =
        CASE
            WHEN ISNULL(t.total_paid, 0) >= b.totalAmt
                THEN 'PAID'
            ELSE 'PENDING'
        END
    FROM Billing b
    INNER JOIN ChangedBills cb
        ON b.bill_id = cb.bill_id
    OUTER APPLY
    (
        SELECT SUM(amount_Paid) AS total_paid
        FROM Transactions t
        WHERE t.bill_id = b.bill_id
    ) t;
END;
GO

CREATE OR ALTER TRIGGER trg_Transaction_Audit
ON Transactions
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @user_id INT =
        ISNULL(CAST(SESSION_CONTEXT(N'user_id') AS INT), 0);

    -- INSERT
    INSERT INTO Audit_Log
        (user_id, action_type, table_name, record_id)
    SELECT @user_id, 'INSERT', 'Transactions', i.transaction_id
    FROM inserted i
    WHERE NOT EXISTS (
        SELECT 1
        FROM deleted d
        WHERE d.transaction_id = i.transaction_id
    );

    -- UPDATE
    INSERT INTO Audit_Log
        (user_id, action_type, table_name, record_id)
    SELECT @user_id, 'UPDATE', 'Transactions', i.transaction_id
    FROM inserted i
    INNER JOIN deleted d
        ON i.transaction_id = d.transaction_id;

    -- DELETE
    INSERT INTO Audit_Log
        (user_id, action_type, table_name, record_id)
    SELECT @user_id, 'DELETE', 'Transactions', d.transaction_id
    FROM deleted d
    WHERE NOT EXISTS (
        SELECT 1
        FROM inserted i
        WHERE i.transaction_id = d.transaction_id
    );
END;
GO


/*USERS
Stored Procedures
usp_User_Insert
usp_User_Update
usp_User_Deactivate

Trigger*/

CREATE OR ALTER PROCEDURE usp_User_Insert
    @username VARCHAR(100),
    @user_role VARCHAR(30)
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Users
        (username, user_role)
    VALUES
        (@username, @user_role);
END;
GO

CREATE OR ALTER PROCEDURE usp_User_Update
    @user_id INT,
    @username VARCHAR(100),
    @user_role VARCHAR(30)
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE Users
    SET
        username = @username,
        user_role = @user_role
    WHERE user_id = @user_id;
END;
GO

CREATE OR ALTER PROCEDURE usp_User_Deactivate
    @user_id INT
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE Users
    SET is_active = 0
    WHERE user_id = @user_id;
END;
GO

--TRIGGER
CREATE OR ALTER TRIGGER trg_User_Audit
ON Users
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @user_id INT =
        ISNULL(CAST(SESSION_CONTEXT(N'user_id') AS INT), 0);

    -- INSERT
    INSERT INTO Audit_Log
        (user_id, action_type, table_name, record_id)
    SELECT @user_id, 'INSERT', 'Users', i.user_id
    FROM inserted i
    WHERE NOT EXISTS (
        SELECT 1
        FROM deleted d
        WHERE d.user_id = i.user_id
    );

    -- UPDATE
    INSERT INTO Audit_Log
        (user_id, action_type, table_name, record_id)
    SELECT @user_id, 'UPDATE', 'Users', i.user_id
    FROM inserted i
    INNER JOIN deleted d
        ON i.user_id = d.user_id;
END;
GO
