using System;

namespace ExceptionDemo001
{
    class Program
    {
        static void Main(string[] args)
        {




            Console.WriteLine("Exception Demonstration");
            int[] number = new int[2];
            try
            {
                number[0] = 0;
                number[1] = 1;
                number[2] = 2;
                foreach(int i in number)
                {
                    Console.WriteLine(i);
                }
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine("An IndexOutOfRangeException was thrown");
                Console.WriteLine(ex.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Finished process, exception thrown, have closed all issues");
            }
            Divide(6, 3, "answer");
            try
            {
                Divide(6, 0, "answer");
            }
            catch (DivideByZeroException dbze)
            {
                Console.WriteLine(dbze.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Finished process, exception thrown, have closed all issues");
            }

            try
            {
                Show(null, 60);
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            } 

            

            Console.ReadKey();
        }
        private static void Divide(int a, int b, string s)
        {
            int result = a / b;
            Console.WriteLine($"{s.ToUpper()} : {result}");
        }

        private static void Show(string fname, int age)
        {
            if(fname is null)
            {
                throw new ArgumentException("Parameter could not be null", "fname");
            }

            Console.WriteLine($"{fname} is {age} years old");
        }

    }
    
}
