namespace PropertiesDemo_Oct_281124
{
    class Employee
    {
        public int empID { set; get; }
        public string empName { set; get; }
        private int salary;
        private int pf;
        public int PF { get { return pf; } }
        public int Salary 
        { get
            { return salary; }

            set {
                salary = value;
                pf = salary * 12 / 100;
                
            } }
        
    }
    class xyz
    {

    }
    class student
    {
        private int roll;
        private string name;
        private float per;
        private xyz obj1;
        private int sub1, sub2, sub3, sub4, sub5;
        private string result;//pass or fail
        public string Result
        {
            get
            {
                return result;
            }
        }

        private int minMarks;//write only property

        public int MinMarks
        {
            set
            {
                minMarks = value;
            }
        }
        public void ShowResult()
        {

        }
        public void setMarks(int s1, int s2, int s3, int s4, int s5)
        {
            sub1 = s1; sub2 = s2; sub3 = s3; sub4 = s4;
            sub5 = s5;
            int total = sub1 + sub2 + sub3 + sub4 + sub5;
            per = total / 5.0f;

            if (minMarks <= sub1 && minMarks <= sub2 && minMarks <= sub3 && minMarks <= sub4 && minMarks <= sub5)
            {
                result = "PASS";
            }
            else
            {
                result = "FAIL";
            }

        }
        public xyz Obj1
        {
            set
            {
                obj1 = value;
            }
            get
            {
                return obj1;
            }
        }

        public float Per
        {

            get
            {
                return per;
            }
        }
        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }

        public int _roll
        {
            set
            {
                if (value > 0)
                {
                    roll = value;
                }
                else
                {
                    Console.WriteLine("Roll number must be +ve!!");
                }

            }
            get
            {
                return roll;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student s1 = new student();

            s1._roll = 3;//set

            int x = s1._roll;//get

            Console.WriteLine("student roll =" + x);
            s1.MinMarks = 40;
            s1.setMarks(50, 51, 52, 23, 54);
            // s1.Per = 500;
            Console.WriteLine(s1.Per);

            string s11 = "india";

            // s11.Length = 10;
            int len = s11.Length;


            Console.WriteLine("result =" + s1.Result);
            Employee e1 = new Employee();
            e1.empID = 100;
            e1.empName = "rajesh";
            e1.Salary = 45000;
            //e1.PF = 2300;
            int pfAmount = e1.PF;
            Console.WriteLine("Id:"+e1.empID);
            Console.WriteLine("Name:" + e1.empName);
            Console.WriteLine("Salary:" + e1.Salary);
            Console.WriteLine("PF:" + pfAmount);
        }
    }
}
