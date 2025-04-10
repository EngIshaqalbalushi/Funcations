using System;
using System.Text;

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
                Console.WriteLine("10. Simple Calculator");
                Console.WriteLine("11. Basic ATM System");
                Console.WriteLine("12. Geometry Calculator");
                Console.WriteLine("13. Factorial of a Number");
                Console.WriteLine("14. Sum of Even and Odd Numbers");
                Console.WriteLine("15. Scientific Calculator");
                Console.WriteLine("16. Print Triangle Pattern");
                Console.WriteLine("17. Print Pyramid Pattern");
                Console.WriteLine("18. Print Diamond Pattern");
                Console.WriteLine("19. Guess the Number Game");




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
                       
                      string weeks=  DaysToWeeksDaysConverter(days);

                        prite(weeks);
                        
                        break;
                    case 8:

                         Console.WriteLine("Enter Number of Unit ");
                      double  NUnit = double.Parse(Console.ReadLine());


                     prite(ElecticityBillCalculator(NUnit))  ;
                        
                        
                        break;
                    case 9:
                        Console.Write("Enter first number: ");
                        double num4 = double.Parse(Console.ReadLine());
                        Console.Write("Enter operator (+, -, *, /): ");
                        char op = Console.ReadKey().KeyChar;
                        Console.Write("\nEnter second number: ");
                        double num5 = double.Parse(Console.ReadLine());




                      prite(SimpleCalculator(num4, num5, op))  ;

                        
                        
                        break;

                    case 10:

                        Console.WriteLine("Enter number of operator \n" +
                    "1: + \n" +
                    "2: - \n" +
                    "3: * \n" +
                    "4: / \n");
                       int op1 = int.Parse(Console.ReadLine());


                        Console.WriteLine("Enter First Number");
                        double number12 = double.Parse(Console.ReadLine());


                        Console.WriteLine("Enter Secound Number");
                        double number13 = double.Parse(Console.ReadLine());

                        prite(SimpleCalculatorWithSwitchCase(op1,number12,number13));


                        break;

                    case 11:

                        prite(BasicATM());

                        break;
                    case 12:
                        prite(GeometryCalculator());

                        break;
                    case 13:
                        Console.WriteLine("Enter A number");
                       double number16 = double.Parse(Console.ReadLine());

                        prite(Factorial(number16));

                        break;

                    case 14:
                        Console.WriteLine("Enter Number");
                     double   number17 = double.Parse(Console.ReadLine());

                        prite(PrintTriangle(number17));

                        break;
                    case 15:
                        Console.WriteLine("Enter Number");
                        int number18= int.Parse(Console.ReadLine());
                        prite(PrintDiamond(number18));
                        break;
                    case 16:
                        Console.WriteLine("Enter Number");
                      int  number19= int.Parse(Console.ReadLine());
                        prite(PrintDiamond(number19));
                        break;


                    case 17:
                        Console.WriteLine("Enter number from 1 to 100");

                       int InputNum = int.Parse(Console.ReadLine());
                        prite(GuessGame(InputNum));

                        break;
                    case 18:

                        prite(SumEvenOdd());

                        break;
                    case 19:


                        break;
                    case 20:


                        break;
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

        public static string ElecticityBillCalculator(double NUnit)
        {



            double result;

            if (NUnit < 0)
            {
                return ("Enter Number of Unit correctly 1 or more");
            }
            else if (1 <= NUnit && NUnit <= 100)
            {
                result = NUnit * 0.5;
                return ("The price is: $" + result);
            }
            else if (101 <= NUnit && NUnit <= 300)
            {
                result = NUnit * 0.75;
                return ("The price is: $" + result);
            }
            else
            {
                result = NUnit * 1;
                return("The price is: $" + result);





            }
        }

        public static string SimpleCalculator(double num1,double num2 ,char op)
        {

            switch (op)
            {
                case '+': return($"Result: {num1 + num2}"); break;
                case '-': return ($"Result: {num1 - num2}"); break;
                case '*': return ($"Result: {num1 * num2}"); break;
                case '/': return (num2 != 0 ? $"Result: {num1 / num2}" : "Error: Division by zero!"); break;
                default: return ("Invalid operator!"); break;
            }





        }

        public static string SimpleCalculatorWithSwitchCase(int op,double num1,double num2)
        {

            double  result;
          

            do
            {

                switch (op)
                {
                    case 1:
                        result = num1 + num2;
                        return ("The Result: " + num1 + " + " + num2 + " = " + result);
                        break;

                    case 2:
                        result = num1 - num2;
                        Console.WriteLine("The Result: " + num1 + " - " + num2 + " = " + result);
                        break;

                    case 3:
                        result = num1 * num2;
                        return("The Result: " + num1 + " * " + num2 + " = " + result);

                        break;

                    case 4:
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                           return("The Result: " + num1 + " / " + num2 + " = " + result);
                        }
                        else
                        {
                            return("Cannot divide by 0");
                        }
                        break;

                    default:
                        return("Enter Correct Operator!!!!!!!");
                        break;

                }
                return("Use again");
            }
            while (op != 4);

        }

        public static string BasicATM()
        {

            double balance = 1000, newBalance = 0, withdraw = 0, deposit = 0;
            int op;

            do
            {


                Console.WriteLine("Enter number of opreation \n" +
                    "1: Withdraw Money \n" +
                    "2: Deposit Money \n" +
                    "3: Check Balance \n" +
                    "4: Exit \n");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {



                    case 1:
                        Console.WriteLine("Enter amount of money you want to withdraw");
                        withdraw = double.Parse(Console.ReadLine());

                        if (withdraw < balance)
                        {
                            newBalance = balance - withdraw;
                            return("New balance= " + newBalance);
                        }
                        else
                        {
                            return("You are brooooock ");

                        }

                        break;

                    case 2:
                        Console.WriteLine("Enter amount of money you want to Deposit");
                        deposit = double.Parse(Console.ReadLine());

                        newBalance = balance + deposit;
                        return("New balance= " + newBalance);

                        break;

                    case 3:
                        return("Your balance= " + newBalance);
                        break;

                    case 4:
                        return("Thank you");

                        break;


                    default:
                        return("Enter Correct number!!!!!!!");
                        break;

                }
                return("\nAnother opreation? \n");


            }
            while (op != 4);







        }



















        public static string GeometryCalculator()
        {
            //Declartion for Circle 
            double circumference, areaC, radiusC;

            //Declartion for Square
            double sideS, areaS, perimeterS;

            //Declartion for Triangle
            double baseT, heightT, areaT;

            int op;

            do
            {


                Console.WriteLine("Enter number of shape you want \n" +
                    "1: Circle (Calculate Area & Circumference) \n" +
                    "2: Square (Calculate Area & Perimeter) \n" +
                    "3: Triangle (Calculate Area) \n" +
                    "4: Exit \n");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {

                    case 1:
                        Console.WriteLine("Enter Radius");
                        radiusC = double.Parse(Console.ReadLine());

                        areaC = 3.14 * Math.Pow(radiusC, 2);
                        Console.WriteLine("Area of Circle is " + areaC);

                        circumference = 2 * 3.14 * radiusC;
                       return("Circumference of Circle is " + circumference);

                        break;

                    case 2:
                        Console.WriteLine("Enter Side");
                        sideS = double.Parse(Console.ReadLine());

                        areaS = Math.Pow(sideS, 2);
                        ;

                        perimeterS = 4 * sideS;
                        return  ("Area of Square is " + areaS+"Perimeter of Square is " + perimeterS);

                        break;

                    case 3:
                        Console.WriteLine("Enter Base");
                        baseT = double.Parse(Console.ReadLine());


                        Console.WriteLine("Enter Height");
                        heightT = double.Parse(Console.ReadLine());


                        areaT = 0.5 * baseT * heightT;
                        return("Area of Triangle is " + areaT);


                        break;

                    case 4:
                        return("Thank you");

                        break;


                    default:
                        return("Enter Correct number!!!!!!!");
                        break;

                }
                return("\nAnother opreation? \n");


            }
            while (op != 4);
        }
        public static string Factorial(double number)
        {
            int  i;
            double f = 1;


            for (i = 1; i <= number; i++)
            {
                f = f * i;
            }



            return ("Factorial of " + number + " is " + f);


        }
        public static string SumEvenOdd()
        {

            double num, evenSum = 0, oddSum = 0;
            int i = 1;
            string a, b;
            Console.WriteLine("Enter number");
            num = double.Parse(Console.ReadLine());

            do
            {
                if (i % 2 == 0)
                {
                    evenSum += i;
                }
                else
                {
                    oddSum += i;
                }
                i++;
            }
            while (i <= num);

         

            return "The sum of Even is " + evenSum+ "\nThe sum of Odd is " + oddSum;
        }

        public static string ScientificCalculator()
        {
            double num1, num2, result = 0;
            int op;
            string choicee;

            do
            {


                Console.WriteLine("Enter number of operator \n" +
                    "1: sin \n" +
                    "2: cos \n" +
                    "3: tan \n" +
                    "4: sqrt \n" +
                    "5: log \n" +
                    "6: pow \n");
                op = int.Parse(Console.ReadLine());


                Console.WriteLine("Enter Number");
                num1 = double.Parse(Console.ReadLine());





                switch (op)
                {
                    case 1:
                        result = Math.Sin(num1);
                        return("The Result: " + result);
                        break;

                    case 2:
                        result = Math.Cos(num1);
                        return("The Result: " + result);
                        break;

                    case 3:
                        result = Math.Tan(num1);
                        return("The Result: " + result);
                        break;

                    case 4:
                        result = Math.Sqrt(num1);
                        return("The Result: " + result);

                        break;

                    case 5:
                        result = Math.Log(num1);
                        return("The Result: " + result);

                        break;

                    case 6:

                        Console.WriteLine("Enter Power");
                        num2 = double.Parse(Console.ReadLine());

                        result = Math.Pow(num1, num2);
                        return("The Result: " + result);

                        break;

                    default:
                        return("Enter Correct Operator!!!!!!!");
                        break;

                }
                Console.WriteLine("Use again? (y/n)");
                choicee = Console.ReadLine();

                if (choicee == "y")
                {
                    Console.Clear();
                }
                else
                {
                    break;
                }



            }
            while (op != 6);

        }

        public static string PrintTriangle(double number)
        {

            int rows = (int)number;
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < rows; i++)
            {
                for (int s = 0; s <= i; s++)
                {
                    sb.Append('*');
                }
                sb.AppendLine();
            }
            return sb.ToString();

        }
        public static string PrintPyramid(int number)
        {
            StringBuilder result = new StringBuilder();

            // Upper half
            for (int i = 1; i <= number; i++)
            {
                result.Append(new string(' ', number - i));
                result.Append(new string('*', 2 * i - 1));
                result.AppendLine();
            }

            // Lower half
            for (int i = number - 1; i >= 1; i--)
            {
                result.Append(new string(' ', number - i));
                result.Append(new string('*', 2 * i - 1));
                result.AppendLine();
            }

            return result.ToString();
        }
        public static string PrintDiamond(int number)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 1; i <= number; i++)
            {
                sb.Append(new string(' ', number - i));
                sb.Append(new string('*', 2 * i - 1));
                sb.AppendLine();
            }

            for (int i = number - 1; i >= 1; i--)
            {
                sb.Append(new string(' ', number - i));
                sb.Append(new string('*', 2 * i - 1));
                sb.AppendLine();
            }

            return sb.ToString();
        }

        public static string GuessGame(int number)
        {

            int RandomNum;
            number = 0;

            Random rn = new Random();
            RandomNum = rn.Next(1, 100);


            while (RandomNum != number)
            {
               

                if (number > RandomNum)
                {
                    return"Try Lower!";
                }
                else if (number < RandomNum)
                {
                    return"Try Higher!";
                }
                else
                {
                    return"You win!";
                }
            }
            return "";

        }































        public static void prite(string name)
        {
            Console.WriteLine(" Result is  "+name );
        }





    }
}
