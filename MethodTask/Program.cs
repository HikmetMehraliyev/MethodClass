

#region(Task 1)
//Console.WriteLine("enter number");
//int num = Convert.ToInt32(Console.ReadLine());
//static int number(int num)
//{
//    return num;
//    Console.WriteLine("enter number");
//    int num = Convert.ToInt32(Console.ReadLine());
//}


//if (number(num) % 2 == 0)
//{
//    Console.WriteLine("eded cutdur");
//}
//else

//{
//    Console.WriteLine("Eded Tekdir");

//}
#endregion

#region(Task 2)

//Console.WriteLine("Enter Number");
//int num = Convert.ToInt32(Console.ReadLine());
//int new = 0;
//int number(int num)
//{
//    Console.WriteLine("Enter Number");
//    int num = Convert.ToInt32(Console.ReadLine());
//}

//do
//{
//    if (number(num) % 2 == 0)
//    {
//        num / 2 = new;
//        Console.WriteLine(new);
//    }
//    else if (number(num) % 1 == 0)
//    {
//        num / 1 = new;
//        Console.WriteLine(new);
//    }
//    else if (number(num) / num == 0)
//    {
//        new = num;
//        Console.WriteLine(new);
//    }

//} while (true);

#endregion

#region(Task 3)
//int num1 = 5;
//int num2 = 6;
//int Totalsum=num1 + num2;
//int TotalSubtraction=num1 - num2;
//int TotalMultiplication = num1 * num2;
//int TotalDivision=num1/num2;

//int Sum(int num1,int num2)
//{
//    Totalsum=num1+num2;
//    Print();
//}
//int Subtraction(int num1,int num2)
//{
//    TotalSubtraction = num1-num2;
//    Print();
//}
//int Multiplication(int num1,int num2)
//{
//    TotalMultiplication = num1*num2;
//    Print();
//}
//int Division(int num1,int num2)
//{
//    TotalDivision = num1/num2;
//    Print();
//}


//void Print()
//{
//    Console.WriteLine(total);
//}
#endregion

#region(Class Task)
//Task 2
//Console.WriteLine("eded daxil edin");
//int num=Convert.ToInt32(Console.ReadLine());
//for(int i=0; i<num; i++)
//{
//	while (num%1 == 0)
//	{
//		num /= i;
//		Console.WriteLine(i);
//	}
//}
#endregion

#region(InClassTask)
Console.WriteLine("Ad Daxil Et");
string name = Convert.ToString(Console.ReadLine());
string GetName(string name)
{
    return name;
}

Console.WriteLine("Soyad Daxil Et");
string surname = Convert.ToString(Console.ReadLine());
string GetSurname(string surname)
{
    return surname;
}

string GetFullName()
{
    return $"{GetName} {GetSurname}";
}

Console.WriteLine("Yas Daxil Et");
int age = Convert.ToInt32(Console.ReadLine());
int GetAge(int age)
{
    return age;
}

Console.WriteLine("Seher Daxil Et");
string city = Convert.ToString(Console.ReadLine());
string GetCity(string city)
{
    return city;
}

Console.WriteLine("Olke Daxil Et");
string country = Convert.ToString(Console.ReadLine());
string GetCountry(string country)
{
    return country;
}

string GetAllInfo(int age,string city,string country)
{
    string fullname = GetFullName();
    if (fullname == "nerkin")
    {
        return "eligible";
    }
    if (age > 25 || city == "Baku" || city == "Istanbul")
    {
        Console.WriteLine("Eligible");
    }
    else
    {
        Console.WriteLine("NotEligible");
    }

    return $"{GetFullName} {GetAge} {GetCity} {GetCountry}";
}
//Console.WriteLine(GetAllInfo());
//string Request()
//{
//    if (age > 25 && city == "Baku" && city == "Istanbul")
//    {
//        return "Eligible";
//    }
//    else
//    {
//        return "Not Eligible";
//    }
//}
#endregion