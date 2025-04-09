namespace Funcation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.Clear();
                Console.WriteLine("\nChoose  Exercise:");
                Console.WriteLine("1. find Even or Odd number");
                Console.WriteLine("2. Find Largest of Three Numbers ");
                Console.WriteLine("3. Temperatuer Converter");
                Console.WriteLine("4. Simple Discount Calculaot");
                Console.WriteLine("5. Grading System");
                Console.WriteLine("6. Swap Two Number");
                Console.WriteLine("7. Daya to Weeks and days Converter");
                Console.WriteLine("8. Electricity Bill Calculato");
                Console.WriteLine("9. Simple Caluclator");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter a number: ");
                        double number = double.Parse(Console.ReadLine());

                        string resulet = oddOrEven(number);

                        prite(resulet);
                        break;


                    case 2:

                        Console.Write("Enter first number: ");
                        int num1 = int.Parse(Console.ReadLine());
                        Console.Write("Enter second number: ");
                        int num2 = int.Parse(Console.ReadLine());
                        Console.Write("Enter third number: ");
                        int num3 = int.Parse(Console.ReadLine());
                       
                        Console.Write(" largest number: ");

                        double name = LargestOfThreeNumbers(num1,num2,num3);
                        prite(name.ToString());
                        break;



                    case 3:


                        Console.Write("Enter temperature in Celsius: ");
                        double celsius = double.Parse(Console.ReadLine());


                        Console.Write("Temperature in Fahrenheit: " );

                        double temp = temperatuerConverter(celsius);
                       
                        prite(temp.ToString());
                        break;



                    case 4:
                        Console.Write("Enter the price of the item: ");
                        double price = double.Parse(Console.ReadLine());

                        Console.Write("Final price is:");

                   double price1=  simpleDiscountCalculator(price);

                        prite(price1.ToString());
                        
                        break;


                    case 5:
                        Console.Write("Enter student score: ");
                        double score = double.Parse(Console.ReadLine());
                        Console.Write("The student's grade is: " );


                       char mark= gradingSytem(score);

                        prite(mark.ToString());
                        break;
                    case 6:

                        Console.Write("Enter first number: ");
                        double a = int.Parse(Console.ReadLine());

                        Console.Write("Enter second number: ");
                        double b = int.Parse(Console.ReadLine());
                       
                        (a, b) = SwapTwoNumbers(a, b);

                        prite((a, b).ToString());

                        break;

                    case 7:

                        Console.Write("Enter number of days: ");
                        int days = int.Parse(Console.ReadLine());
                       
                        DaysToWeeksDaysConverter();
                        
                        
                        
                        break;
                    case 8: ElecticityBillCalculator(); break;
                    case 9: SimpleCalculator(); break;
                    case 0: return;
                    default: Console.WriteLine("Invalid choice! Try again."); break;
                }

                Console.ReadLine();
            }

           





        }

        public static string oddOrEven(double number)
        {

            if (number % 2 == 0)
              return  "The number is Even.";
            else
               return "The number is Odd.";
        }








        public static double LargestOfThreeNumbers(double num1, double num2, double num3)
        {
            double largest = num1;

            if (largest > num2)
            {
                if (largest > num3)
                {
                    return largest;
                }
                else
                {
                    return num3;
                }
            }
            else
            {
                largest = num2;

                if (largest > num3)
                {
                    return largest;
                }
                else
                {
                    return num3;
                }
            }
        }




        public static double temperatuerConverter(double celsius)
        {

            double fahrenheit = (celsius * 9 / 5) + 32;

            return fahrenheit;





        }
        public static double simpleDiscountCalculator(double price)
        {
            double discount = 0;

            double finalPrice;

            if (price > 100)
            {
                discount = (price / 100) * 10;
                finalPrice = price - discount;
                return finalPrice;

            }
            else
            {
               return price;

            }



        }

        public static char gradingSytem(double score)
        {
            char grade;

            if (score >= 90)
                grade = 'A';
            else if (score >= 80)
                grade = 'B';
            else if (score >= 70)
                grade = 'C';
            else if (score >= 60)
                grade = 'D';
            else
                grade = 'F';

            return grade;

        }

        public static  (double,double) SwapTwoNumbers(double a,double b)
        {

            return (b, a);


        }





        public static string DaysToWeeksDaysConverter(int days)
        {

            int weeks = days / 7;
            int remainingDays = days % 7;

            return days + " days = " + weeks + " week(s) and " + remainingDays + " day(s)";


        }

        public static void ElecticityBillCalculator()
        {

        }

        public static void SimpleCalculator()
        {

        }

        public static void prite(string name)
        {
            Console.WriteLine(" Result is  "+name );
        }





    }
}
