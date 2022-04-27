// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Employee Wage Computation Program");
//int IS_FULL_TIME = 1;
//int empCheck = random.Next(0, 2);
/*if (empCheck == IS_FULL_TIME)

    Console.WriteLine("Employee is persent");

else

    Console.WriteLine("Employee is not persent");
    Console.ReadKey();
*/
/*
int EMP_RATE_PER_HOUR = 60;
int empHrs = 0;
int empWage = 0;

if (empCheck == IS_FULL_TIME)

    empHrs = 8;

else

    empHrs = 0;

empWage = empHrs * EMP_RATE_PER_HOUR;
Console.WriteLine("Emp Wage :" + empWage);
Console.ReadKey();*/
/*
int IS_PART_TIME = 1;
int IS_FULL_TIME = 5; ;
int EMP_RATE_PER_HOUR = 20;
//here we take variable and initialize value with 0;
int empHrs = 0;
int empWage = 0;
//here we take random variable to take any random value between
Random random = new Random();
int empCheck = random.Next(0, 5);
Console.WriteLine(value: empCheck);
// here we check condition*/
/*if (empCheck == IS_PART_TIME)

    empHrs = 4;

else if (empCheck == IS_FULL_TIME)

    empHrs = 8;

else

    empHrs = 0;


empWage = empHrs * EMP_RATE_PER_HOUR;
Console.WriteLine("Emp Wage :" + empWage);
Console.ReadKey();*/

/*public const* int IS_PART_TIME = 1;
/*public const int IS_FULL_NUMBER = 2;
/*public const nt EMP_RATE_PER_HOUR = 60;
//Random random = new Random();
//int empCheck = random.Next(0, 5);
/*static void Main(string[] args)*/

using System;
class program5
{
    public const int IS_PART_TIME = 1;
    public const int IS_FULL_NUMBER = 2;
    public const int EMP_RATE_PER_TIME = 60;
    public const int NUM_OF_WORKING_DAYS = 5;
    static void Main(string[] args)
    {
        int empHrs = 0, empWage = 0, totalEmpWage = 0;
        for (int day = 0; day < NUM_OF_WORKING_DAYS; day++)
        {
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            switch (empCheck)
            {
                case IS_PART_TIME:
                    empHrs = 4;
                    break;
                case IS_FULL_NUMBER:
                    empHrs = 8;
                    break;
                default:
                    empHrs = 0;
                    break;
            }
            empWage = empHrs * EMP_RATE_PER_TIME;
            totalEmpWage += empWage;
            Console.WriteLine("Emp wage :" + empWage);
        }
        Console.WriteLine("Total Emp Wage :" + totalEmpWage);
        Console.ReadKey();
    }
}