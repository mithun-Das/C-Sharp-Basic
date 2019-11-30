using System;
using System.Threading;
using System.Net.Http;
using System.Threading.Tasks;

namespace AsynchronousTest
{
    class Program
    {
        public string  x = "Init" ;
        public static string responseString = "response";
        public static HttpClient client = new HttpClient();

        public static async Task<int> CommonMethod(string msg)
        {
            int i = 0;

            await Task.Run(() => {

                for (i = 0; i <= 100; ++i)
                {
                    Console.WriteLine(msg + i);
                }
            }); 

            return i;
        }

        public static int CommonMethod1(string msg)
        {
            int i = 0;

             Task.Run(() => {

                for (i = 0; i <= 100; ++i)
                {
                    Console.WriteLine(msg + i);
                }
            });

            return i;
        }


        public static async Task<int>  Method1()
        {
           int i = 0;

            await Task.Run( () => {

                for (i = 0; i <= 100; ++i)
                {
                    Console.WriteLine("Method 1 : ###  " + i);
                };
            });

            var j = await CommonMethod("Intermediate Method 1 ");

            return i + j;
        }

        public static async void Method2()
        {

           int x = await Method1();
           Console.WriteLine(x);

           int i = 0;

           for(i = 0;i <= 100; ++i)
           {
                Console.WriteLine("Method 2 : ### " + i);
           }
        }

        public static  void Method3()
        {
            for (int i = 0; i <= 100; ++i)
            {
                Console.WriteLine("Method 3 : " + i);
            }
        }

        public static async void Method4()
        {
            await CommonMethod("Method 4 ");
            await CommonMethod("Method 5 ");
        }

        /****************  Task Test *******************/

        public static void Method5()
        {
            Task<string> testTask = Task.Run( () => {

                for (int i = 0; i <= 100; ++i)
                {
                    Console.WriteLine("Method 5 loop");
                }

                Console.WriteLine("Method 5 processing");
                return "Method 5";
            });



            Console.WriteLine(testTask.Result);
        }

        public static string Method6()
        {
            Task<string> testTask = Task.Run(() => {

                for (int i = 0; i <= 500000000; ++i)
                {
                    //Console.WriteLine("Method 6 loop");
                }

                Console.WriteLine("Method 6 processing");
                return "Method 6";
            });

            return testTask.Result;
        }

        public static void Method7()
        {
            string result = Method6();
            Console.WriteLine("Inside Method 7");
            Console.WriteLine(result);
        }

        public static async Task<string> Method8()
        {
            Task<string> testTask = Task.Run(() => {

                for (int i = 0; i <= 500000000; ++i)
                {
                    //Console.WriteLine("Method 6 loop");
                }

                Console.WriteLine("Method 8 processing");
                return "Method 8";
            });

            return testTask.Result;
        }

        public static async Task<string> Method9()
        {
            await Task.Run( () => {
                for (int i = 0; i <= 100; ++i)
                {
                    Console.WriteLine("Method 9 loop");
                }
            });

            return "Method 9";
        }

        public static async Task<string> Test1()
        {
            await Task.Run( () => {
                for (int i = 0; i <= 100; ++i)
                {
                    Console.WriteLine("Test 1 : " + i);
                }
            });

            return "Test 1";
        }


        public static void Method10()
        {
            //Task<string> result = Method8();
            //.WriteLine("Inside Method 10");
            //Console.WriteLine(result.Result);

            //string result = Method9();
            Method9();
            Method3();
            //Console.WriteLine(result);
            Console.WriteLine("Inside Method 10");

        }

        public static async Task<string> Method11(Program p)
        {
            

            await Task.Run( () => {

                for (int i = 0; i <= 900000000; ++i)
                {
                    if (i == 900000000)
                    {
                        p.x = "second";
                    }
                }

            });

            return "Method 11";
        }

        public static  void Method12()
        {
            
            var reponse =  client.GetStringAsync("https://stackoverflow.com/questions/4015324/how-to-make-http-post-web-request");
            Console.WriteLine(responseString);
            responseString = reponse.ToString();
            Console.WriteLine(responseString);
        }

        static void  Main(string[] args)
        {
            //int x = await Method1();
            //Console.WriteLine(x);

            //Method3();
            // Method2();
            //Method3();
            // Method4();

            //Method5();
            // Method7();

            //Method10();
            //Method9();
            //Method3();
            // Method9();
            // Test1();

            // Program p = new Program();

            //string res = Method11(p).GetAwaiter().GetResult();
            //  Method11(p);
            // Console.WriteLine(p.x);
            //  Thread.Sleep(9000);
            // Console.WriteLine(p.x);
            // Console.WriteLine("Test 11");
            // Console.WriteLine(res);

            //  Method12();
            CommonMethod1("Test 1  ");
            CommonMethod1("Test 2  ");

            Console.ReadKey();

           
        }
    }
}
