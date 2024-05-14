namespace task1
{
    public class MyAccessModifiers
    {
        private int birthYear;
        protected string personalInfo;
        protected internal string idNumber;
        public int Age => 2024 - birthYear;
        public static byte averageMiddleAge = 50;

        
        public MyAccessModifiers(int birthYear, string idNumber, string personalInfo)
        {
            this.birthYear = birthYear;
            this.idNumber = idNumber;
            this.personalInfo = personalInfo;
        }

        public string Name { get; set; }

        public string NickNname { get; internal set; }

        protected internal bool HasLivedHalfOfLife()
        {
            return Age >= averageMiddleAge;
        }

        public static bool operator ==(MyAccessModifiers obj1, MyAccessModifiers obj2)
        {
            return obj1.Name == obj2.Name && obj1.Age == obj2.Age && obj1.personalInfo == obj2.personalInfo;
        }

        public static bool operator !=(MyAccessModifiers obj1, MyAccessModifiers obj2)
        {
            return !(obj1 == obj2);
        }
    }
}