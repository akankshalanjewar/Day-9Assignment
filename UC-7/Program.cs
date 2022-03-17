using System;

namespace UC_7
{
    public class Program
    {
            public const int IS_FULL_TIME = 2;
            public const int IS_PART_TIME = 1;
            public const int EMP_RATE_PER_HR = 20;
            public const int MAX_HRS_IN_MONTH = 10;
            public const int NUM_OF_WORKING_DAYS = 2;

       public static int computeWages()
        {
            int empHrs = 0;
            int totalEmpWages = 0;
            int totalWorkingDays = 0;
            int totalEmpHrs = 0;

            while (totalWorkingDays <= MAX_HRS_IN_MONTH && totalEmpWages < NUM_OF_WORKING_DAYS)
            {

                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);


                switch (empCheck)
                {
                    case 1:
                        empHrs = 4;
                        break;

                    case 2:
                        empHrs = 8;
                        break;

                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpWages += empHrs;
                Console.WriteLine("Day:" + totalWorkingDays + " empHrs:" + empHrs);

            }

           totalEmpWages = totalEmpHrs * EMP_RATE_PER_HR;
           Console.WriteLine("totalEmpWages:" + totalEmpWages);
           return totalEmpWages;


        }
        public static void Main(string[] args)
        {
            computeWages();
            Console.ReadLine();

        }
    }

       
}
