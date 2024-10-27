using HelloToDotnetFandamental.Models;

namespace HelloToDotnetFandamental;

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
    public static int Add(int input1, int input2)
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

    public static int Multiple(int number)
    {
        return number * 2;
    }

    static void Main(string[] args)
    {
        int[,] matrix = new int[2, 2];
        {
            matrix[0, 0] = 1;
            matrix[0, 1] = 2;
            matrix[1, 0] = 3;
            matrix[1, 1] = 4;
        };
        Console.WriteLine(matrix);
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.WriteLine(matrix[i, j] + "");
            }
            Console.WriteLine();
        }




        User user = new User();
        user.ShowDetail();



        //bool isMale = false;
        //string userInput = Console.ReadLine();
        //if (userInput == "M")
        //    isMale = true;
        //else
        //    isMale= false;

        //string userInput = Console.ReadLine();
        //bool isMale = userInput == "M" ? true : false;
        //string numStr = Console.ReadLine();
        //int num = int.Parse(numStr);

        int num = int.Parse(Console.ReadLine());
        int[] ints = { 1, 2, 3, 4 };
        int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };
        int[,] numbers2 = { { 1, 4, 2 }, { 3, 6, 8 } };
        user.Gender = Console.ReadLine() == "M" ? true : false;

        //موبایل کاربر را دریافت نمایید، تا زمانی که موبایل کاربر
        //تعداد آن 11 تا نباشد و همچنین با 0 شروع نشده بود اجازه ادامه ندارد
        //کاربر حتما باید موبایل را وارد نمایید.
        //اگر موبایل وارد نشده بود باید پیام مناسب داده شود و مجدد از کاربر درخواست وارد کردن موبایل را بدهیم
        //اگر کاربر در موبایل به جای شماره همراه کاراکتر وارد کرده بود آنگاه مجدد پیام مناسب دهیم و دوباره از وی شماره همراه را بگیریم
        //for (; ;)
        //{
        //    Console.WriteLine("Please Enter Your Mobile?");
        //    string userMobile = Console.ReadLine() ?? string.Empty;
        //    if (userMobile.Length == 11 && userMobile.StartsWith("0"))
        //    {
        //        try
        //        {
        //            long mobile_num = long.Parse(userMobile);
        //            Console.WriteLine("correct mobile number.");
        //            break;
        //        }
        //        catch
        //        {
        //            Console.WriteLine("invalid mobile number.");
        //        }
        //    }
        //}


        //for (int i = 0; i < 5; i++)
        //{
        //    Console.WriteLine(i);
        //}

        //int l = 0;
        //while (l < 5)
        //{
        //    Console.WriteLine(l);
        //    l++;
        //    //i = i + 1;
        //}

        //while (true)
        //{
        //    Console.WriteLine("Please Enter Your Mobile?");
        //    string userMobile = Console.ReadLine() ?? string.Empty;
        //    if (userMobile.Length == 11 && userMobile.StartsWith("0"))
        //    {
        //        try
        //        {
        //            long mobile_num = long.Parse(userMobile);
        //            Console.WriteLine("correct mobile number.");
        //            break;
        //        }
        //        catch
        //        {
        //            Console.WriteLine("invalid mobile number.");
        //        }
        //    }
        //}

        do
        {
            Console.WriteLine("Please Enter Your Mobile?");
            string userMobile = Console.ReadLine() ?? string.Empty;
            if (userMobile.Length == 11 && userMobile.StartsWith("0"))
            {
                try
                {
                    long mobileNum = long.Parse(userMobile);
                    Console.WriteLine("correct mobile number.");
                    break;
                }
                catch
                {
                    Console.WriteLine("invalid mobile number.");
                }
            }
        } while (true);

        //while (true)
        //{
        //    Console.Write("Hi");
        //}

        try
        {
            string str2 = "kjhasdk";
            str2.Substring(10, 3);
        }
        catch (Exception ex)
        {
            //Log,Alert,....
            throw;
        }

        Multiple(0);



        for (int i = 0; i < 10; i++)
            Console.WriteLine($"Result is : {Multiple(i)}");

        for (int i = 10; i < 0; i = i - 1)
        {
            Console.WriteLine($"For Loop: {i}");
        }

        //2 way => continue, break
        for (int i = 1; i < 10; i = i + 1)
        {
            if (i == 5)
                continue;
            Console.WriteLine($"For Loop: {i}");
        }

        //i++ => i = i + 1
        for (int i = 1; i < 10; i = i + 1)
        {
            Console.WriteLine($"For Loop: {i}");
            if (i == 5)
                break;
        }

        int dayNumber = 0;
        //Style 1
        if (dayNumber == 0)
        {
            Console.WriteLine("Shanbe");
        }
        else if (dayNumber == 1)
        {
            Console.WriteLine("1shanbe");
        }
        else if (dayNumber == 2)
        {
            Console.WriteLine("2shanbe");
        }
        else if (dayNumber == 3)
        {
            Console.WriteLine("3shanbe");
        }
        else if (dayNumber == 4)
        {
            Console.WriteLine("4shanbe");
        }
        else if (dayNumber == 5)
        {
            Console.WriteLine("5shanbe");
        }
        else if (dayNumber == 6)
        {
            Console.WriteLine("jome");
        }
        else
        {
            Console.WriteLine("please enter valid number");
        }

        //Style 2
        if (dayNumber == 0)
            Console.WriteLine("Shanbe");
        else if (dayNumber == 1)
            Console.WriteLine("1shanbe");
        else if (dayNumber == 2)
            Console.WriteLine("2shanbe");
        else if (dayNumber == 3)
            Console.WriteLine("3shanbe");
        else if (dayNumber == 4)
            Console.WriteLine("4shanbe");
        else if (dayNumber == 5)
            Console.WriteLine("5shanbe");
        else if (dayNumber == 6)
            Console.WriteLine("jome");
        else
            Console.WriteLine("please enter valid number");

        //Style 3
        switch (dayNumber)
        {
            case 0:
                Console.WriteLine("Shanbe");
                break;
            case 1:
                Console.WriteLine("1shanbe");
                break;
            case 2:
                Console.WriteLine("2shanbe");
                break;
            case 3:
                Console.WriteLine("3shanbe");
                break;
            case 4:
                Console.WriteLine("4shanbe");
                break;
            case 5:
                Console.WriteLine("5shanbe");
                break;
            case 6:
                Console.WriteLine("jome");
                break;
            default:
                Console.WriteLine("please enter valid number");
                break;
        }






        int age = 54;
        if (age > 0 && age <= 10)
            Console.WriteLine("Child");
        else if (age > 10 && age <= 19)
            Console.WriteLine("Teenage");
        else if (age > 19 && age <= 29)
            Console.WriteLine("Old");
        else
            Console.WriteLine("Very Old");

        //if (age > 0 && age <= 10)
        //{
        //    Console.WriteLine("Child");
        //}
        //else if (age > 10 && age <= 19)
        //{
        //    Console.WriteLine("Teenage");
        //}
        //else if(age > 19 && age <= 29)
        //{
        //    Console.WriteLine("Old");
        //}
        //else
        //{
        //    Console.WriteLine("Very Old");
        //}

        Wellcome();

        int num1 = 5;
        int num2 = 3;
        int result = Add(num1, num2);

        int num3 = 8;
        int num4 = 9;
        int result2 = Add(input1: num3, input2: num4);

        string applicationName = "HelloToCSharp";
        var str = "Parham";
        string subStr = str.Substring(1, 1);
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
        user.MobileNumber = Console.ReadLine() ?? "";

        //09129564205
        //9129564205 -> Format , start without 0 -> 09129564205 OK
        //+989129564205 -> 09129564205 -> OK
        //0912956420 -> Format

        if (string.IsNullOrEmpty(user.MobileNumber))
        {
            Console.WriteLine($"Please enter valid mobile number {applicationName}");
            return;
        }
        user.MobileNumber = user.MobileNumber.Trim().Replace("+98", "0");
        //if (mobileNumber.StartsWith("+98"))
        //{
        //    mobileNumber = mobileNumber.Replace("+98", "0");
        //}

        if (user.MobileNumber.Length == 10 && !user.MobileNumber.StartsWith("0"))
        {
            //mobileNumber = "0" + mobileNumber;
            user.MobileNumber = $"0{user.MobileNumber}";
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
