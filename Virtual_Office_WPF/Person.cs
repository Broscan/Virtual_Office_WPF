namespace Virtual_Office_WPF
{
    public class Person
    {

        public static string FirstName { get; set; }
        public static string LastName { get; set; }

        public string FullName { get; set; } = FirstName + " " + LastName;

        public int Age { get; set; }

        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public virtual string ShowBio()
        {
            return $"Hi, I haven't added any bio yet!";
        }


    }

    public class Employee : Person
    {
        public decimal Salary { get; set; }
        public string Bio { get; set; }
        public override string ShowBio()
        {
            if (Bio != null)
            {
                return Bio;
            }
            else
            {
                return base.ShowBio();

            }

        }


        public Employee(string firstName, string lastName, int age, decimal salary, string bio) : base(firstName, lastName, age)
        {
            Salary = salary;
            Bio = bio;
        }
    }

}
