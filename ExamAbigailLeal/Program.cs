using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamAbigailLeal
{
    class Program
    {
        static void Main(string[] args)
        {
            
            SolutionProblem1("Abigail Leal Perez");

            Console.ReadLine();

            SolutionProblem2("This is an example");
            SolutionProblem3(255);
            SolutionProblem4();
            SolutionProblem5(20, 5);
            SolutionProblem6();
            SolutionProblem7(69);
            SolutionProblem8();
            SolutionProblem9();
            SolutionProblem10();



            Console.ReadKey();
        }

        static void SolutionProblem1(string myName)
        {
            

            try
            {
            
                Console.WriteLine(myName, " ", DateTime.Now);


            }

            catch (Exception ex)
            {
                Console.WriteLine("An error ocurred!");
            }
        }

        static void SolutionProblem2(string myNumbers)
        {
            try
            {
                Console.WriteLine(myNumbers.Length);

            }

            catch (Exception ex)
            {
                Console.WriteLine("An error ocurred!");
            }


        }
        static void SolutionProblem3(int val1)
        {
            try
            {
                if (val1 % 2 == 0)
                {
                    Console.WriteLine("Even");
                }

                else
                {
                    Console.WriteLine("Odd");
                }
                    
            }

            catch (Exception ex)
            {
                Console.WriteLine("An error ocurred!");
            }

            Console.ReadKey();

        }
        static void SolutionProblem4()
        {
            try
            {
                int i;

                for (i = 1; i <= 10; i++)
                {
                    Console.Write("{0} ", i);
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine("An error ocurred!");
            }

        }

        static void SolutionProblem5(int num1, int num2)
        {
            try
            {

                Console.WriteLine(num1 * num2);

            }

            catch (Exception ex)
            {
                Console.WriteLine("An error ocurred!");
            }

        }

        static void SolutionProblem6()
        {
            try
            {

            }

            catch (Exception ex)
            {
                Console.WriteLine("An error ocurred!");
            }

        }

        static void SolutionProblem7(int value)
        {
            try
            {
                if ( value > 0)
                {
                    Console.WriteLine("Number is Positive");
                }
                
                else
                {
                    Console.WriteLine("Number is Negative");
                }

            }

            catch (Exception ex)
            {
                Console.WriteLine("An error ocurred!");
            }

        }
        static void SolutionProblem8()
        {
            try
            {
                string[] arr = { "Today", "is", "the", "last", "day" };

                foreach (string n in arr)
                {
                    Console.Write(n.ToUpper() + " ");

                }
            }

            catch (Exception ex)
            {
                Console.WriteLine("An error ocurred!");
            }

        }
        static void SolutionProblem9()
        {
            try
            {
                int[] array1 = { 1, 3, 6 };
                int[] array2 = { 2, 5, 4 };
                Console.WriteLine();

            }

            catch (Exception ex)
            {
                Console.WriteLine("An error ocurred!");
            }

        }

        static void SolutionProblem10()
        {
            try
            {
                int 
                Console.WriteLine();
            }

            catch (Exception ex)
            {
                Console.WriteLine("An error ocurred!");
            }

        }
    }
}
