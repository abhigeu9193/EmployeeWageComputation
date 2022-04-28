// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Employee Wage Computation Program");
UC-1
  int IS_FULL_TIME = 1;
  int empCheck = random.Next(0, 2);
 if (empCheck == IS_FULL_TIME)

    Console.WriteLine("Employee is persent");

else

    Console.WriteLine("Employee is not persent");
    Console.ReadKey();

UC-2
int EMP_RATE_PER_HOUR = 60;
int empHrs = 0;
int empWage = 0;

if (empCheck == IS_FULL_TIME)

    empHrs = 8;

else

    empHrs = 0;

empWage = empHrs * EMP_RATE_PER_HOUR;
Console.WriteLine("Emp Wage :" + empWage);
Console.ReadKey();


<----UC-3-------->

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
if (empCheck == IS_PART_TIME)

    empHrs = 4;

else if (empCheck == IS_FULL_TIME)

    empHrs = 8;

else

    empHrs = 0;


empWage = empHrs * EMP_RATE_PER_HOUR;
Console.WriteLine("Emp Wage :" + empWage);
Console.ReadKey();*/
  
    <------UC-4------>

/*public const* int IS_PART_TIME = 1;
/*public const int IS_FULL_NUMBER = 2;
/*public const nt EMP_RATE_PER_HOUR = 60;
//Random random = new Random();
//int empCheck = random.Next(0, 5);
/*static void Main(string[] args)*/

using System;
class program6
{
    public const int IS_PART_TIME = 1;
    public const int IS_FULL_NUMBER = 2;
    public const int EMP_RATE_PER_HOUR = 60;
    public const int NUM_OF_WORKING_DAYS = 2;
    public const int MAX_HRS_IN_MONTH = 10;
    static void Main(string[] args)
    {
        int empHrs = 0, totalEmpHrs = 0, empWage = 0, totalWorkingDays = 0;
        while (totalEmpHrs <= MAX_HRS_IN_MONTH && totalWorkingDays < NUM_OF_WORKING_DAYS)
        {
            totalWorkingDays++;
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
            totalEmpHrs += empHrs;
            Console.WriteLine("Days:" + totalWorkingDays + "Emp Hrs :" + empWage);
        }
        int totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOUR;
        Console.WriteLine("Total Emp Wage :" + totalEmpWage);
        Console.ReadKey();
    }
}
