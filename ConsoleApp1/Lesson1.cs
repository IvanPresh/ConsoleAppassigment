using System;

namespace ConsoleApp1
{
    class Lesson1
    {
        public static void Main()  
        {
            
            
            Console.WriteLine("Hello, Nature!");
            Main1();
           
            

        }
        public static void Main1()
        {


            Console.WriteLine("Hello, Life!");



        }
        public static void Main2()
        {


            Console.WriteLine("Please enter your first name!");

            string username = Console.ReadLine();

            Console.WriteLine("Hello  " + username); //using conccatenation +

            Console.WriteLine("please enter your mainden Name?");

            string maindenname = Console.ReadLine();

            Console.WriteLine("welcome {0}", maindenname); // using place holder syntax



        }
        public static void Main3()
        {


            Console.WriteLine("please enter your lastname and  firstName");
            

            string lastname=Console.ReadLine();

            string firstname=Console.ReadLine();

            Console.WriteLine("hello (0),(1)   ", lastname, firstname);


        }
    }





    class Lesson2 
    {
    
        public static void force() 
        {

            int i = 0;

            Console.WriteLine("min = [0] ", int.MinValue);

            Console.WriteLine("min = {0} ", int.MinValue);


            // writing and reading to the console window.

            //Console.WriteLine("please whats is your mainden name");

            //string mainden = Console.ReadLine();

            //Console.WriteLine("hello " + mainden);

        }
        public static void main()
        {
            int[] D = { 1, 2, 3, 4 };
            Console.WriteLine(D);





        }
    
    
    
    
    
    
    
    
    }


}
