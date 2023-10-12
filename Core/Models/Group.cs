using System;

namespace Core.Models
{
    public class Group
    {   
        public Student[] Students = Array.Empty<Student>(); 
        public string No 
        { 
            get; 
            set; 
        }


        public int StudentLimit 
        { 
            get;
            set;
        }

        public Group AddStudent(Student newStudent) {

            if (this.Students.Length < this.StudentLimit)
            {
                Array.Resize(ref this.Students, this.Students.Length + 1);
                this.Students[^1] = newStudent;
                Console.WriteLine($"New student is added to group - {newStudent.FullName}");
            }
            else
            {
                Console.WriteLine("Sorry the student limit is exceed system cannot process further.");
            }
            return this;
        }


        public static bool ValidateStudentLimitField(int limit) 
        { 
            return limit < 21 && limit > -1 ? true : false;
        }

        public static bool ValidateNoField(ref string no) 
        {
            no = no.Trim();
            if (no.Length == 5 && char.IsUpper(no[0]) && char.IsUpper(no[1]) && char.IsDigit(no[2]) && char.IsDigit(no[3]) && char.IsDigit(no[4]))
            {
                return true;
            }

            return false;
        }
    }
}
