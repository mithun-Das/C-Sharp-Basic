using System;

namespace Myexception
{
    class Program
    {
        public int Method1()
        {
            try
            {
                throw new NullReferenceException("Soory !!! You got null reference exception");
            }
            catch
            {
                throw new NullReferenceException("Soory !!! You got null reference exception");
            }

            return 0;
        }




        static void Main(string[] args)
        {
            Program p = new Program();


            try
            {
                p.Method1();
            }
            catch(Exception ex)
            {
               // Console.WriteLine(ex);
            }


            for(int i = 0;i < 0; ++i)
            {
                try
                {
                    int x = int.Parse(Console.ReadLine());
                    int y = int.Parse(Console.ReadLine());

                    int res = (x / y);

                    Console.WriteLine(res);

                    try
                    {
                         x = int.Parse(Console.ReadLine());
                         y = int.Parse(Console.ReadLine());

                         res = (x / y);

                    }
                    catch (DivideByZeroException error)
                    {
                        Console.WriteLine("Again Divide by Zero : " + error);
                    }

                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("Divide by Zero : " + ex);

                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Format Exception :" + ex);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                finally
                {
                    Console.WriteLine("You have to print again!!!");
                }
            }


            try
            {
                int x = int.Parse(Console.ReadLine());
                int y = int.Parse(Console.ReadLine());

                int res = (x + y);

                Console.WriteLine(res);
            }
            finally
            {
                Console.WriteLine("Finally Got it");
                Console.ReadKey();
            }


        }
    }
}
