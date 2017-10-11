using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleOneAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Do you wannt to enter student information (Y/N)?");
                string student = Console.ReadLine();
                Console.WriteLine();

                if (student.ToUpper() == "Y" || student.ToUpper() == "YES")
                {
                    GetStudentInformation();
                }

                Console.WriteLine("Do you want to enter teacher information (Y/N)?");
                string teacher = Console.ReadLine();
                Console.WriteLine();

                if (teacher.ToUpper() == "Y" || teacher.ToUpper() == "YES")
                {
                    GetTeacherInformation();
                }

                Console.WriteLine("Do you want to enter course information (Y/N)?");
                string course = Console.ReadLine();
                Console.WriteLine();

                if (course.ToUpper() == "Y" || course.ToUpper() == "YES")
                {
                    GetCourseInformation();
                }

                Console.WriteLine("Do you want to enter UProgram information (Y/N)?");
                string program = Console.ReadLine();
                Console.WriteLine();

                if (program.ToUpper() == "Y" || program.ToUpper() == "YES")
                {
                    GetUprogramformation();
                }

                Console.WriteLine("Do you want to enter degree information (Y/N)?");
                string degree = Console.ReadLine();
                Console.WriteLine();

                if (degree.ToUpper() == "Y" || degree.ToUpper() == "YES")
                {
                    GetDegreeformation();
                }

                //no longer calling this method because catch below will throw error for invalid dates
                //validateBirthday();
            }

            catch (Exception e)
            {
                Console.WriteLine("The following error occurred: " + e);
            }
        }

        static void GetStudentInformation()
        {
            Console.WriteLine("Press any key to enter student information... ");
            Console.ReadLine();

            Console.WriteLine("First Name");
            string studentFirstName = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Last Name");
            string studentLastName = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Birth Date");
            string studentBirthDate = Console.ReadLine();

            DateTime studentBD = DateTime.Parse(studentBirthDate);

            Console.WriteLine();

            Console.WriteLine("Address Line 1");
            string studentAddressLine1 = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Suite or Apartment Number (Enter for none)");
            string studentAddressLine2 = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("City");
            string studentCity = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("State");
            string studentState = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Zip Code");
            int studentZip = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Country");
            string studentCountry = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Press Any Key to Output Student Information Captured");
            Console.WriteLine();
            Console.ReadKey();

            PrintStudentDetails(studentFirstName, studentLastName, studentBD, studentAddressLine1, studentAddressLine2, studentCity, studentState, studentZip, studentCountry);
        }

        static void PrintStudentDetails(string first, string last, DateTime birthday, string address1, string suiteApt, string city, string state, int zipcode, string country)
        {
            Console.WriteLine("{0} {1} was born on {2} and lives on {3} {4}" + System.Environment.NewLine + "{5}, {6} {7}" + System.Environment.NewLine + "{8}", first, last, birthday.ToString("MM/dd/yyyy"), address1, suiteApt, city, state, zipcode, country);

            Console.WriteLine();
            Console.WriteLine("Press any key to proceed");
            Console.ReadKey();
        }

        static void GetTeacherInformation()
        {
            Console.WriteLine("Enter teacher information... ");
            Console.WriteLine();

            Console.WriteLine("First Name");
            string teacherFirstName = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Last Name");
            string teacherLastName = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Birth Date");
            string teacherBirthDate = Console.ReadLine();

            DateTime teacherBD = DateTime.Parse(teacherBirthDate);

            Console.WriteLine();

            Console.WriteLine("Courses Taught");
            string teacherCourses = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Press Any Key to Output Teacher Information");
            Console.WriteLine();
            Console.ReadKey();

            PrintTeacherDetails(teacherFirstName, teacherLastName, teacherBD, teacherCourses);
        }

        static void PrintTeacherDetails(string first, string last, DateTime birthday, string courses)
        {
            Console.WriteLine("{0} {1} was born on {2} and teaches {3}", first, last, birthday.ToString("MM/dd/yyyy"), courses);

            Console.WriteLine();
            Console.WriteLine("Press any key to proceed");
            Console.ReadKey();
        }

        static void GetCourseInformation()
        {
            Console.WriteLine("Enter course information... ");
            Console.WriteLine();

            Console.WriteLine("Course Name");
            string courseName = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Number of Credits");
            int credit = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Course Start Date");
            string courseDate = Console.ReadLine();

            DateTime courseStart = DateTime.Parse(courseDate);

            Console.WriteLine();
            Console.WriteLine("Press Any Key to Output Course Information");
            Console.WriteLine();
            Console.ReadKey();

            PrintCourseInformation(courseName, credit, courseStart);
        }

        static void PrintCourseInformation(string course, int credit, DateTime start)
        {
            Console.WriteLine("{0} is worth {1} credit(s) and starts on {2}", course, credit, start.ToString("MM/dd/yyyy"));
            Console.WriteLine();
            Console.WriteLine("Press any key to proceed");
            Console.ReadKey();
        }

        static void GetUprogramformation()
        {
            Console.WriteLine("Enter UProgram information... ");
            Console.WriteLine();

            Console.WriteLine("Program Name");
            string progName = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Program duration in months");
            int length = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Prerequisites (Enter for none)");
            string preReq = Console.ReadLine();

            string preReqRequired = "requires the completion of: ";

            if (preReq == "")
            {
                preReqRequired = "no prerequisites are required";
            }

            Console.WriteLine();
            Console.WriteLine("Press Any Key to Output UProgram Information");
            Console.WriteLine();
            Console.ReadKey();

            PrintUprogramInformation(progName, length, preReqRequired, preReq);
        }

        static void PrintUprogramInformation(string name, int length, string preReqWording, string preRequisites)
        {
            Console.WriteLine("{0} lasts {1} month(s) and {2} {3}", name, length, preReqWording, preRequisites);

            Console.WriteLine();
            Console.WriteLine("Press any key to proceed");
            Console.ReadKey();
        }

        static void GetDegreeformation()
        {
            Console.WriteLine("Enter Degree information... ");
            Console.WriteLine();

            Console.WriteLine("Degree Name");
            string degreeName = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Degree type (BA, BS, MS, etc.)");
            string type = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Number of credits required to graduate");
            int gradCredits = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Press Any Key to Output Degree Information");
            Console.WriteLine();
            Console.ReadKey();

            PrintDegreeInformation(degreeName, type, gradCredits);
        }

        static void PrintDegreeInformation(string name, string type, int credits)
        {
            Console.WriteLine("The {0} of {1} degree requires {2} credits to graduate", type, name, credits);

        }

        static void validateBirthday()
        {
            throw new NotImplementedException();
        }
    }
}