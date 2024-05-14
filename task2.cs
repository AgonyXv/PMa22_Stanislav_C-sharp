namespace task2
{
    public class Employee
    {
        internal string Name;
        private DateTime HiringDate;

        public Employee(string name, DateTime hiringDate)
        {
            Name = name;
            HiringDate = hiringDate;
        }

        public int Experience()
        {
            DateTime currentDate = DateTime.Now;
            int years = currentDate.Year - HiringDate.Year;
            if (currentDate.Month < HiringDate.Month ||
                (currentDate.Month == HiringDate.Month && currentDate.Day < HiringDate.Day))
            {
                years--;
            }
            return years;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"{Name} has {Experience()} years of experience");
        }
    }

    public class Developer : Employee
    {
        private string ProgrammingLanguage;

        public Developer(string name, DateTime hiringDate, string programmingLanguage) : base(name, hiringDate)
        {
            ProgrammingLanguage = programmingLanguage;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"{Name} is a {ProgrammingLanguage} programmer");
        }
    }

    public class Tester : Employee
    {
        private bool IsAutomation;

        public Tester(string name, DateTime hiringDate, bool isAutomation) : base(name, hiringDate)
        {
            IsAutomation = isAutomation;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            string testerType = IsAutomation ? "automated" : "manual";
            Console.WriteLine($"{Name} is a {testerType} tester");
        }
    }
}
