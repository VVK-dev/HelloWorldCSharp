namespace Exceptions
{
    public class ExceptionHandling
    {

        //Errors vs Exceptions: 

        //An Error is a serious problem that a reasonable application should not and generally cannot
        //to catch/solve (eg: OutofMemoryError, hardware failure/defects).
        //Recovery from an error is generally not possible.

        //An exception is a condition or issue that a reasonable application can catch to
        //enhance user experience or overall performance. Recovery from an exception is
        //generally possible and encouraged.

        //Generally errors and exceptions are used interchangebly when it comes to code.

        private static void Main(string[] args)
        {
            //The try statement allows you to define a block of code to be tested for
            //exceptions while it is being executed.

            //The catch statement allows you to define a block of code to be executed
            //if an error occurs in the try block.

            try
            {
                int[] myNumbers = { 1, 2, 3 };
                Console.WriteLine(myNumbers[10]);
                //this will raise an error as the array's max index is 2
            }
            catch (Exception e) //we save the caught exception as a variable e
            {
                Console.WriteLine(e.Message);
                //Exception.Message is a property that contains the exception message 
                //If we don't want to display the error message we can display anything
                //else too, this isn't a requirement
            }

            //We can use the finally keyword to execute code regardless of whether an
            //exception was encountered or handled or not in the try and catch clauses.

            finally
            {
                Console.WriteLine("Try-Catch Complete.");
            }


            //The throw statement allows you to voluntarily raise an exception.
            //The throw statement is used together with an exception class,
            //eg:ArithmeticException, FileNotFoundException,
            //IndexOutOfRangeException, TimeOutException, etc.

            int age = 18;

            if (age < 24)
            {
                throw new ArithmeticException("Access denied - You must be at " +
                "least 24 years old.");
                
                //Here we can just use throw new Exception() instead of ArithemticException
                //if we wanted to (see below).

                //NOTE: THROWN EXCEPTIONS WILL STOP THE EXECUTION OF THE PROGRAM AND ARE
                //CONSIDERED UNHANDLED. WE HAVE TO USE A TRY-CATCH BLOCK TO HANDLE THEM.
            }
            else
            {
                Console.WriteLine("Access granted - You are old enough!");
            }

            //CREATING A CUSTOM EXCEPTION

            //Exceptions are objects of the Exception class in C#.
            //We can create our own exceptions by creating objects of the exception class.

            //There are 2 paramters used to create an exception object, both of which are
            //optional:

            //1)String message - The message displayed when the exception is enountered
            //or thrown.
            //2)Inner Exception - The exception that is the cause of the current
            //exception.

            Exception ex1 = new();
            Exception ex2 = new("Exception ex2 has occured.");
            ArithmeticException aex = new(); //The paramters for this are the same as above.
            Exception ex3 = new("Exception ex3 has occured.", aex);

        }
    }
}