using System.Reflection.Metadata;

namespace HelloToDotnetFandamental
{
    //Class -> Container For Method + Property
    internal class Program
    {

        /// <summary>
        /// Show a wellcom message and if user pass name we will customize message
        /// </summary>
        /// <param name="name">it is string for message</param>
        public static void Wellcome(string name = "")
        {
            Console.WriteLine("*********************************************");
            Console.WriteLine($"Hello wellcome {name} to our app!");
            Console.WriteLine("This is our firts version");
            Console.WriteLine("*********************************************");
            //code
        }

        //Method Overloads
        public static int Add(int input1,int input2)
        {
            //Validation
            int result = input1 + input2;
            Console.WriteLine($"Result is : {result}");
            return result;
        }

        public static int Add(int num1, int num2, int num3)
        {
            //Validation
            int result = num1 + num2 + num3;
            Console.WriteLine($"Result is : {result}");
            return result;
        }

        static void Main(string[] args)
        {
            Wellcome();

            int num1 = 5;
            int num2 = 3;
            int result = Add(num1,num2);

            int num3 = 8;
            int num4 = 9;
            int result2 = Add(input1: num3, input2: num4);

            string applicationName = "HelloToCSharp";
            var str = "Parham";
            string subStr = str.Substring(1,1);
            var strChars = str.ToCharArray();
            Console.WriteLine("please enter your birth month?");
            string birthMonth = Console.ReadLine() ?? "";
            birthMonth = birthMonth.Trim().ToLower();
            //birthMonth = birthMonth.ToLower();

            Console.WriteLine("please enter your name?");
            string name = Console.ReadLine() ?? "";
            name.Trim().ToLower(); //parham poya
            Wellcome(name);
            if (name.StartsWith("p"))
            {
                //
            }
            //Mehr
            Console.WriteLine("please enter your mobile?");
            string mobileNumber = Console.ReadLine() ?? "";

            //09129564205
            //9129564205 -> Format , start without 0 -> 09129564205 OK
            //+989129564205 -> 09129564205 -> OK
            //0912956420 -> Format

            if (string.IsNullOrEmpty(mobileNumber))
            {
                Console.WriteLine($"Please enter valid mobile number {applicationName}");
                return;
            }
            mobileNumber = mobileNumber.Trim().Replace("+98", "0");
            //if (mobileNumber.StartsWith("+98"))
            //{
            //    mobileNumber = mobileNumber.Replace("+98", "0");
            //}
            
            if (mobileNumber.Length == 10 && !mobileNumber.StartsWith("0"))
            {
                //mobileNumber = "0" + mobileNumber;
                mobileNumber = $"0{mobileNumber}";
            }
            else
            {
                Console.WriteLine("Please enter valid mobile number");
            }


            //Console.WriteLine("please enter your age?");
            //int age = int.Parse(Console.ReadLine());
            //bool flag = true;
            //if (age < 18 && flag)
            //{
            //    Console.WriteLine("You are not valid to register!");
            //    return;
            //}


            //Add Data to Database!

            //code
            //string name = Console.ReadLine();

            ////از یک جنس
            //int smallerNumber = 15; //32 bit
            //long biggerNumber = 45; //64 bit
            //biggerNumber = smallerNumber;

            //int smallerNumber2 = 15; //32 bit
            //long biggerNumber2 = 45; //64 bit
            //smallerNumber2 = (int)biggerNumber2;

            ////از یه جنس نیست
            //string ageStr = "15";
            //int ageInt = int.Parse(ageStr);
            //long ageLong = long.Parse(ageStr);

            ////تبدیل به رشته
            //string descriptionAge = ageInt.ToString();

            //bool isMale = false; //true false
            //if (isMale)
            //{
            //    Console.WriteLine("You are male");
            //}
            //else
            //{
            //    Console.WriteLine("you are female");
            //}

            //Console.WriteLine("Please enter your name?");
            //string Name = Console.ReadLine();

            //Console.WriteLine("Please Enter Your Age?");
            //ageStr = Console.ReadLine();
        }
    }
}
