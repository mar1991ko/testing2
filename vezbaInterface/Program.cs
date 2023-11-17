namespace vezbaInterface
{
    public interface IPerson
    {
        void Greet();
        int SetAge(int age);
    }
    public class Student : IPerson
    {
        int studentAge;
        public void Greet()
        {
            Console.WriteLine("Hello, I'm a student");
        }
        public int SetAge(int age)
        {
            Console.WriteLine("How old are you?");
            return int.Parse(Console.ReadLine());
        }
        public void Study()
        {
            Console.WriteLine("I'm studying");
        }
        public void ShowAge(int age)
        {
            Console.WriteLine("The student is " + age);
        }
    }
    public class Teacher : IPerson
    {
        int teacherAge;
        public void Greet()
        {
            Console.WriteLine("Hello, I'm a teacher");
        }
        public int SetAge(int age)
        {
            Console.WriteLine("How old are you?");
            return int.Parse(Console.ReadLine());
        }
        public void Explain()
        {
            Console.WriteLine("I'm teaching");
        }
    }
    public class StudentProfessorTest
    {
        
        public static void Main(string[] args)
        {
            IPerson person = new Student();
            person.Greet();
            Student student = new Student();
            int age = person.SetAge(20);
            student.ShowAge(age);
            Teacher teacher = new Teacher();
            teacher.Greet();
            int ageTeacher = teacher.SetAge(20);
            teacher.Explain();
        }
    }
}