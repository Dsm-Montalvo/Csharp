using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Persona persona1 = new Persona("Bob1", 30, "Ally", null, new DateTime(1993,1,1));
            Persona persona2 = new Persona("Bob2", 31, "Ally", null, new DateTime(1993, 1, 1));
            Persona persona3 = new Persona("Bob3", 32, "Ally", null, new DateTime(1993, 1, 1));

            persona1.Introduce();
            persona2.Introduce();
            persona3.Introduce();
            */

            Employee employee1 = new Employee("Eve",52, "Teporochito", 0, new DateTime(1995,5,15), "software Developer", 1500);
            employee1.Introduce();

        }
    }


    public class  Persona
    {
        //Auto-implemented properties
        public string Name { get; set; } = string.Empty;

        //Full property with backing field and validation
        private int _age;
        public int Age
        {
            get { return _age; }
            
            set
            {
                if (value < 0)
                    throw new ArgumentException("Age cannot be negative.");
                _age = value;
            }
        }

        //property with default value
        public string nickname { get; set; } = "No nickname";

        //Nullable property
        public int? Couple { get; set; }= null;

        //Read-only property
        public readonly DateTime BirthDate = DateTime.Now;

        

        //static property
        public static int Population { get; private set; } = 0;


        public Persona()
        {
            if(this.Name.Length == 0)
                this.Name = "Unknown";
            
            Population++;
        }

        public Persona(string name, int age, string nickname, int? couple, DateTime birthDate): this()
        {
            Name = name;
            Age = age;
            this.nickname = nickname;
            Couple = couple;
            BirthDate = birthDate;
        }

        public virtual void Introduce()
        {
            Console.WriteLine($"Hello, my name is {Name}, I am {Age} years old.");
        }

    }

    public class Employee : Persona
    {
        public string Position { get; set; } = "Unemployed";
        //Realizar validacion para que el salario no sea menor al minimo
        private decimal _salary;

        public decimal Salary
        {
            get { return _salary; }
            set
            {
                if (value < 300)
                    throw new ArgumentException("Su salario no puede ser menos del salario minimo(300$).");
                _salary = value;
            }
        }

       
        // *************************************************************************************

        public Employee(string name, int age, string nickname, int? couple, DateTime birthDate, string position, decimal salary)
            : base(name, age, nickname, couple, birthDate)
        {
            Position = position;
            Salary = salary;
        }
        public override void Introduce()
        {
            base.Introduce();
            Console.WriteLine($"I work as a {Position} and my salary is {Salary:C}.");
        }

    }
}
