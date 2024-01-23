using System;



public class A
{
    int num1;
    int num2;
    string str;

    public void show()
    {
        Console.WriteLine("A");
    }

    public static void show(int num1, int num2 , string str)
    {
        Console.WriteLine("num1 = {0} num2 = {1} string = {2}",num1,num2,str);
    }
}

class B : A
{
    public void show()
    {
        Console.WriteLine("B");
        
    }
    public void show(int x)
    {
        Console.WriteLine("welcom to overloading {0}",x );
       // base.show();
    }

}

public class Program 
{
    public static void Main(string[] args)
    {
        A a1 = new A();
        B b1 = new B();
        B b2 = new B();
        a1.show();
        b1.show();
        b2.show(2);

    }
}








//class Program
//{
//    public static void Main(string[] args)
//        {
//        stars.seq1();

//      // skills.test();

//        //FullName.UserName();

//        //AgeUser ageUser1 = new AgeUser();
//        //ageUser1.Age(0);
//        }
//}

//class stars
//{
//    public static void seq1()
//    {
//        Console.WriteLine("enter any number");
//        int width = int.Parse(Console.ReadLine());

//        for (int i = 0; i <= width; i++)
//        {
//            for (int j = 0; j < i; j++)
//            {
//                Console.Write("*");
//            }
//            Console.WriteLine();
//        }
//    }
//}

//class skills
//{
//    public static void test()
//        {
//        start: 
//        Console.WriteLine("enter your order 1- array 2- if  3- for");
//        int choice =int.Parse( Console.ReadLine());
//        if (choice == 1)
//        {
//            // Get the user's array choice.
//            Console.WriteLine("Enter number between 0 to 3");
//            int arrayChoice = int.Parse(Console.ReadLine());

//            // Declare and initialize the user array.
//            int[] userArray = new int[4];
//            userArray[0] = 0;
//            userArray[1] = 100;
//            userArray[2] = 200;
//            userArray[3] = 300;

//            // Return the array element at the specified index.
//            int arrayElement = userArray[arrayChoice];

//            // Display the array element.
//            Console.WriteLine("The array element at index {0} is: {1}", arrayChoice, arrayElement);
//        }
//        else if (choice == 2)
//                {
//            Console.WriteLine("do you want to test the if cloase");

//                }
//        else if (choice == 3)
//        {
//            Console.WriteLine("here is for loop if you want to restart Enter YES or NO");
//            string again = Console.ReadLine();
//            switch (again.ToUpper())
//            {
//                case "YSE": goto start;
//                case "NO": break;
//            }

//        }

//    }
//}


//class FullName
//{
//    public static void UserName()
//    {
//        Console.WriteLine("Hello EvryOne Please Enter your full Name");
//        string Name1 = Console.ReadLine();
//        Console.WriteLine("wellcom, {0}",Name1);
//    }
//}

//class AgeUser
//{


//    public void Age(int birthyear)
//    {
//        Console.WriteLine("Enter your birth year:");
//        int birthYear = int.Parse(Console.ReadLine());

//        int age = 2023 - birthYear;
//        Console.WriteLine("your age is {0}", age);
//    }

//}