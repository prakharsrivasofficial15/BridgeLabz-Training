// =========================
// BASE CLASS
// =========================
// This is the base (parent) class.
// All access modifiers are demonstrated here.

public class BaseClass{
	public int publicVar = 1;                           // PUBLIC
														// Accessible from:
														// - Same class
														// - Derived classes
														// - Any other class
														// - Any assembly
   
	private int privateVar = 2;                         // PRIVATE
														// Accessible ONLY inside this class (BaseClass)
														// NOT accessible in derived classes or other classes
    
	protected int protectedVar = 3;                     // PROTECTED
														// Accessible inside:
														// - This class
														// - Derived classes
														// NOT accessible from non-derived classes
    
	internal int internalVar = 4;                       // INTERNAL
														// Accessible anywhere within the SAME ASSEMBLY (project)
														// NOT accessible from another assembly
    
    protected internal int protectedInternalVar = 5;    // PROTECTED INTERNAL
														// Accessible if EITHER condition is true:
														// - Same assembly (internal)
														// - OR derived class (protected)
    
    private protected int privateProtectedVar = 6;      // PRIVATE PROTECTED
														// Most restrictive (introduced in C# 7.2)
														// Accessible ONLY if BOTH conditions are true:
														// - Same assembly
														// - AND derived class

    // Method inside the SAME class
    public void ShowInsideBase(){

        Console.WriteLine(publicVar);                   // ✅ Allowed: public member

        Console.WriteLine(privateVar);                  // ✅ Allowed: private members are accessible inside the same class
        
        Console.WriteLine(protectedVar);                // ✅ Allowed: protected members accessible inside the class
        
        Console.WriteLine(internalVar);                 // ✅ Allowed: internal members accessible inside the assembly
        
        Console.WriteLine(protectedInternalVar);        // ✅ Allowed: protected internal accessible here
        
        Console.WriteLine(privateProtectedVar);         // ✅ Allowed: private protected accessible inside the same class
    }
}

// =========================
// DERIVED CLASS (SAME ASSEMBLY)
// =========================
// This class INHERITS BaseClass
// It is in the SAME assembly

public class DerivedClass : BaseClass{
    public void ShowInsideDerived(){
        
        Console.WriteLine(publicVar);                   // ✅ Allowed: public members are accessible everywhere
        
        // Console.WriteLine(privateVar);               // ❌ NOT allowed: private members are NOT inherited
        
        Console.WriteLine(protectedVar);                // ✅ Allowed: protected members ARE accessible in derived classes
        
        Console.WriteLine(internalVar);                 // ✅ Allowed: internal members accessible within same assembly
        
        Console.WriteLine(protectedInternalVar);        // ✅ Allowed:
														// - Derived class ✔
														// - Same assembly ✔
        
        Console.WriteLine(privateProtectedVar);         // ✅ Allowed:
														// - Derived class ✔
														// - Same assembly ✔
    }
}

// =========================
// NON-DERIVED CLASS (SAME ASSEMBLY)
// =========================
// This class does NOT inherit from BaseClass
// But it is in the SAME assembly

public class OtherClass{
    public void ShowFromOtherClass(){
        
        BaseClass obj = new BaseClass();                   // Creating an instance of BaseClass
        
        Console.WriteLine(obj.publicVar);                  // ✅ Allowed: public members accessible everywhere
        
        // Console.WriteLine(obj.privateVar);              // ❌ NOT allowed: private members accessible only inside BaseClass
        
        // Console.WriteLine(obj.protectedVar);            // ❌ NOT allowed:
														   // protected members are NOT accessible via object reference
														   // unless inside a derived class
        
        Console.WriteLine(obj.internalVar);                // ✅ Allowed: internal members accessible in same assembly
        
        Console.WriteLine(obj.protectedInternalVar);       // ✅ Allowed:
														   // protected internal allows access because:
														   // - Same assembly ✔
        
        // Console.WriteLine(obj.privateProtectedVar);     // ❌ NOT allowed:
														   // private protected requires:
														   // - Derived class ❌
														   // - Same assembly ✔
														   // Both conditions are NOT met
    }
}