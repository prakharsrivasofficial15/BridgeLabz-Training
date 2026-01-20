using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.ResumeScreeningSystem
{
    class ResumeController
    {
        Resume<SoftwareEngineer> seResumes = new Resume<SoftwareEngineer>();
        Resume<DataScientist> dsResumes = new Resume<DataScientist>();

        public void Run()
        {
            while (true)
            {
                Console.WriteLine("\nResume Screening System");
                Console.WriteLine("1. Add Software Engineer Resume");
                Console.WriteLine("2. Add Data Scientist Resume");
                Console.WriteLine("3. Screen All Resumes");
                Console.WriteLine("4. Exit");

                Console.Write("Choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Name: ");
                        string seName = Console.ReadLine();

                        Console.Write("Experience (years): ");
                        int seExp = int.Parse(Console.ReadLine());

                        Console.Write("Coding Score: ");
                        int codeScore = int.Parse(Console.ReadLine());

                        seResumes.AddResume(new SoftwareEngineer(seName, seExp, codeScore));
                        Console.WriteLine("Resume added!");
                        break;

                    case 2:
                        Console.Write("Name: ");
                        string dsName = Console.ReadLine();

                        Console.Write("Experience (years): ");
                        int dsExp = int.Parse(Console.ReadLine());

                        Console.Write("ML Score: ");
                        int mlScore = int.Parse(Console.ReadLine());

                        dsResumes.AddResume(new DataScientist(dsName, dsExp, mlScore));
                        Console.WriteLine("Resume added!");
                        break;

                    case 3:
                        seResumes.ScreenResumes();
                        dsResumes.ScreenResumes();
                        break;

                    case 4:
                        return;

                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }
        }
    }
}
