namespace Assignment_3._1_Question_2
{
    internal class Program
    {
        /*
        If year is leap, given a year as integer
        write a method that checks if year is leap  
        */
        //div by 4
        //div by 100
        //div by 400
        //then leap year

        //if else statements, return leap year if true
        //=IF(OR(MOD(A1,400)=0,AND(MOD(A1,4)=0,MOD(A1,100)<>0)),"Leap Year", "NOT a Leap Year")  

        //int input;

        static bool leapYear(int year)
        {
            //div 400
            if (year % 400 == 0)
            {
                return true;
            }
            //easily divisible?
            //div 100 (Edge Case?)
            else if (year % 100 == 0)
            {
                return false;
            }
            //div 4
            else if (year % 4 == 0)
            {
                return true;
            }
            //and?
            else
            {
                return false;
            }

            //doing it with different code
            //if ((year % 100 == 0 && (year % 400 == 0))
            //{
            //return true;
            //}
            //if (year % 4 == 0)
            //{
            //return = true;
            //}
            //return false;
        }
        //it's clean and easy to understand but super redundant
        //would use || to do on one line for some good and/or action
        static void Main()
        {
            Console.WriteLine("Please enter a year to check if it is a Leap Year:");

            string input = Console.ReadLine();
            if (int.TryParse(input, out int year))
                //have to keep looking up new ways to do things
            { 
                bool weapwear = leapYear(year);
                if (weapwear)
                {
                    Console.WriteLine($"{year} is a Leap Year.");
                }
                else
                {
                    Console.WriteLine($"{year} is not a Leap Year.");
                }
            }
                else
                {
                Console.WriteLine("Your numbers don't make sense.");
                }
        }
            //loop to continue

    }    
}