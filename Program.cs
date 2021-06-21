using System;
using System.Collections.Generic;

namespace CSharp
{

   class CSharp
    {

            private static void Main()
            {
                /*CSharp.ex1();
                CSharp.ex2();
                CSharp.ex3();
                CSharp.ex4();
                CSharp.ex5();
                CSharp.ex6();
                CSharp.ex7();
                CSharp.ex8(); 
                CSharp.ex9(); 
                CSharp.ex10();
                CSharp.ex11();  
                CSharp.ex12(); 
                CSharp.ex13(); */
                CSharp.ex14();
                CSharp.ex15();
            }


            private static void  ex1()
            {
                System.Console.WriteLine("\nHello World");
            }

            private static void ex2()
            {
                int number1;
                int number2;

                number1=10;
                number2=20;
                System.Console.WriteLine("Ex2, write the sum of two numbers");
                System.Console.WriteLine(number1+number2);
                System.Console.ReadLine();
            }


            private  static void ex3()
            {
                int number1;
                int number2;

                number1=10;
                number2=5;
                System.Console.WriteLine("Exercise 3");
                System.Console.WriteLine(number1 / number2);
                System.Console.ReadLine();
            }
            

            private static void ex4()
            {
                System.Console.WriteLine("Exercise 4");
                System.Console.WriteLine(-1+(4*6));
                System.Console.WriteLine((35+5) % 7);
                System.Console.WriteLine(14+-1 * 6/11);
                System.Console.WriteLine(2+15/6*1-7%2);
            }


            private static void ex5()
            {
               int number1;

               int number2;
               int number3;

                System.Console.WriteLine("Input Number1");
                number1=Convert.ToInt32 (System.Console.ReadLine());
                System.Console.WriteLine("Enter Number 2");
                number2=Convert.ToInt32 (System.Console.ReadLine());
                number3=number1;
                number1=number2;
                number2=number3;
                System.Console.WriteLine("Exercise 5");
                System.Console.WriteLine("Numbers input are {0} and {1}, numbers swapped are {1} and {0}",number1,number2);

            }


            private static void ex6()
            {

            int number1;
            int number2;
            int number3;

            System.Console.WriteLine("Exercise 6");

            System.Console.WriteLine("Enter the first number");
            number1=Convert.ToInt32(System.Console.ReadLine());

            System.Console.WriteLine("Please enter the Second Number");
            number2=Convert.ToInt32(System.Console.ReadLine());

            System.Console.WriteLine("Please Enter the Third Number");
            number3=Convert.ToInt32(System.Console.ReadLine());

            System.Console.WriteLine(number1*number2*number3);

            }

            private static void ex7()
            {
                int number1;
                int number2;

                System.Console.WriteLine("Exercise 7");
                
                System.Console.WriteLine("Please enter the first number");
                number1=Convert.ToInt32(System.Console.ReadLine());

                System.Console.WriteLine("Please enter the Second Number");
                number2=Convert.ToInt32(System.Console.ReadLine());

                System.Console.WriteLine("{0} + {1} = {2}", number1,number2, number1+number2);
                System.Console.WriteLine("{0} - {1} = {2}", number1, number2, number1-number2);
                System.Console.WriteLine("{0} * {1} = {2}",number1, number2, number1 * number2);
                System.Console.WriteLine("{0} / {1} = {2}", number1, number2, number1 / number2);
            }


            private static void ex8()
            {
                int number1;

                System.Console.WriteLine("Exercise 8");
                System.Console.WriteLine("Please enter a number to get the multiplication table");
                number1= System.Convert.ToInt32(System.Console.ReadLine());
    
                System.Console.WriteLine("1 * {0} = {1}",number1, number1 * 1);
                System.Console.WriteLine("2 * {0} = {1}",number1, number1 * 2);
                System.Console.WriteLine("3 * {0} = {1}",number1, number1 * 3);
                System.Console.WriteLine("4 * {0} = {1}",number1, number1 * 4);
                System.Console.WriteLine("5 * {0} = {1}",number1, number1 * 5);
                System.Console.WriteLine("6 * {0} = {1}",number1, number1 * 6);
                System.Console.WriteLine("7 * {0} = {1}",number1, number1 * 7);
                System.Console.WriteLine("8 * {0} = {1}",number1, number1 * 8);
                System.Console.WriteLine("9 * {0} = {1}",number1, number1 * 9);
                System.Console.WriteLine("10 * {0} = {1}",number1, number1 * 10);
                System.Console.WriteLine("11 * {0} = {1}",number1, number1 * 11);
                System.Console.WriteLine("12 * {0} = {1}",number1, number1 * 12);
            }


            private static void ex9()
            {
                int Number1;
                int Number2;
                int Number3;
                int Number4;

                System.Console.WriteLine("Exercise 9");
                System.Console.WriteLine("Please enter the 1st number");
                Number1=System.Convert.ToInt32(System.Console.ReadLine());
                System.Console.WriteLine("Please enter the 2nd Number");
                Number2=System.Convert.ToInt32(System.Console.ReadLine());
                System.Console.WriteLine("Please enter the 3rd Number");
                Number3=System.Convert.ToInt32(System.Console.ReadLine());
                System.Console.WriteLine("Please enter the 4th Number");
                Number4=System.Convert.ToInt32(System.Console.ReadLine());

                System.Console.WriteLine("The Average of {0},{1},{2},{3} is {4}",Number1, Number2, Number3, Number4, (Number1+Number2+Number3+Number4)/4);

            }



            private static void ex10()
            {

            int Number1;
            int Number2;
            int Number3;

            System.Console.WriteLine("Exercise 10");
            System.Console.WriteLine("output of (x+y).z and x.y + y.z.");
            System.Console.WriteLine("Please Enter the 1st Number");
            Number1=System.Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine("Please Enter the 2nd Number");
            Number2=System.Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine("Please Enter the 3rd Number");
            Number3=System.Convert.ToInt32(System.Console.ReadLine());

            System.Console.WriteLine("(x+y).z = ({0}+{1}*{2})={3}",Number1, Number2, Number3, (Number1+Number2)*Number3);
            System.Console.WriteLine("x.y + y.z = {0} * {1} + {1} * {2} = {3}",Number1, Number2, Number3, (Number1 * Number2)+(Number2 * Number3));


            }


            private static void ex11()
            {
              int age;

              System.Console.WriteLine("Exercese 11");
              System.Console.WriteLine("Please Enter your Age");
              age=System.Convert.ToInt32(System.Console.ReadLine());

            System.Console.WriteLine("You look younger then {0}",age);
            }



            private static void ex12()
            {
                int number;
                System.Console.WriteLine("Exercise 12");

                System.Console.WriteLine("Please Enter a Number");
                number=System.Convert.ToInt32(System.Console.ReadLine());

                System.Console.WriteLine("{0} {0} {0} {0}",number);
                System.Console.WriteLine("{0}{0}{0}{0}",number);
                System.Console.WriteLine("{0} {0} {0} {0}",number);
                System.Console.WriteLine("{0}{0}{0}{0}",number);

            }


            private static void ex13()
            {
                int number;

                System.Console.WriteLine("Exercise 13");
                System.Console.WriteLine("Please Enter A Number");
                number=System.Convert.ToInt32(System.Console.ReadLine());

                System.Console.WriteLine("{0}{0}{0}",number);

                System.Console.WriteLine("{0} {0}",number);
                System.Console.WriteLine("{0} {0}",number);
                System.Console.WriteLine("{0} {0}",number);

                System.Console.WriteLine("{0}{0}{0}",number);

            }

            
            private static void ex14()
            {
                int celsius;
                System.Console.WriteLine("Exercise 14");
                System.Console.WriteLine("Please enter a temperature in Celsius");
                celsius=System.Convert.ToInt32(System.Console.ReadLine());

                /* convertions are near enough, rounding due to using integers */
                System.Console.WriteLine("{0} celsius = {1} Farenheight",celsius,celsius * (9/5)+32);
                System.Console.WriteLine("{0} celsius = {1} Kelvin",celsius,celsius+273);

            }


            private static void ex15()
            {
                string TheString;
                TheString="I am the walrus";
                TheString=TheString.Replace("rus","");
                System.Console.WriteLine(TheString);

            }


        }
    }
