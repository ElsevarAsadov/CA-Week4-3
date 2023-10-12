namespace Core.Models
{
    public class Student
    {
        public string FullName { get; set; }
        public int GroupNo {  get; set; }  
        public int AvgPoint { get; set; }

        public Student(string fullName) {
            this.FullName = fullName;
        }    
    }
}