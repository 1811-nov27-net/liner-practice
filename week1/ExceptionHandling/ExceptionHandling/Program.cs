using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            //exceptions are runetime errors that we can potentially handle
            //exceptions are objects and defined by classes like anything else
            try
            {
                //try goes around code that is expected to throw an exception
                var x = 4;
                var y = x / 0;

                Console.WriteLine("never prints because an exception is thrown first");
            }
            catch (DivideByZeroException e)
            {
                //handle the exception in catch block
                Console.WriteLine("divided by zero, moving on");
                //at the end of catch, we move on with business
            }

            BadCode();
            Console.WriteLine("the program continues");
            
        }

        static void BadCode()
        {

            try
            {
                object o = true;
                string s = (string)o;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("won't print because this isn't a div by zero!");
            }

            //we're not handling the specific exception, so it will propogate up...
        }
    }
}
