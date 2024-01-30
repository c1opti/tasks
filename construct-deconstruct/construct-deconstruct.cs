namespace constructor_deconstruct
{
    public class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("Alice", 20, new int[] { 90, 80, 70 });
            s.Print();
            
        }
    }
    public class Student
    {
        public string name;
        public int age;
        public int[] grades;

        public Student(string name, int age, int[] grades)
        {
            this.name = name;
            this.age = age;
            this.grades = grades;
        }
        public void Deconstruct(out string dename, out int deage, out int[] degrades)
        {
            dename = name + " JUSTIN";
            deage = age + 10;
            degrades = grades; // crazy shit.
        }
        public void Print()
        {
            Console.WriteLine($"Name: {name}, Age: {age}, Grades: {string.Join(", ", grades)}");
            (string dename, int deage, int[] degrades) = this;
            Console.WriteLine($"Name: {dename}, Age: {deage}, Grades: {string.Join(", ", degrades)}");

        }
        
    }
}
