// See https://aka.ms/new-console-template for more information
using ConsoleApp2.Models;

Console.WriteLine("What is your name?");
string result = Console.ReadLine() ?? "";


//data -> proccess -> information
//Declare Varibale

//DataType Name = value;

// User Define Data Type
//x => instance, object, شی و نمونه
Product x = new();
x.Name = "بستنی";
x.BrandName = "مهین";
x.Count = 5;
x.Price = 1000;

Product x2 = new Product();
x.Name = "شیر کاکائو";
x.BrandName = "ماهشام";
x.Count = 10;
x.Price = 2000;

Product x3 = new Product()
{
    Name = "ماست سون",
    Price = 3000,
    Count = 10,
    Description = "",
    BrandName = "کاله"
};

int number = 5;

number = 6;


string str = "jsdbhasb";//hard code
string? FirstName = null;
FirstName = str;
Console.WriteLine(FirstName);

bool isMale = false;
short age = 15;
DateTime birthDate;
decimal wallet;

int st;