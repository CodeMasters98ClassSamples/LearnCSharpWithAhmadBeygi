namespace HelloToDotnetFandamental
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("please enter your name?");
            string name = Console.ReadLine();

            Console.WriteLine("please enter your age?");
            int age = int.Parse(Console.ReadLine());
            bool flag = true;
            if (age < 18 && flag)
            {
                Console.WriteLine("You are not valid to register!");
                return;
            }

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
