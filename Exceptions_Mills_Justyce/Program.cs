
internal class Program
{
    static void Main(string[] args)
    {
        float myFloat = 65.4f;
        float myOtherFloat = 0.0f;
        float result = 0f;

        Random rand = new Random();//Initializes an int with a random range from 2 to 30
        int myInt = rand.Next(2, 30);

        try//Try assigning result to the Divide method and passing in the two variables as arguments
        {
            result = Divide(myFloat, myOtherFloat);
        }
        catch (Exception e)//Catch any exceptions and print the error message to console using the built-in Message property
        {
            Console.WriteLine(e.Message);
            Console.WriteLine("Please enter a number other than zero");//asks the user to TRY to input a floating point number other than zero

            try//TRY assigning result to the Divide method again, then print result to console
            {
                myOtherFloat = (float)Convert.ToDouble(Console.ReadLine());
                result = Divide(myFloat, myOtherFloat);
            }
            catch (Exception e2)//Catch any exceptions and print the error message to console using the built-in Message property
            {
                Console.WriteLine(e2.Message);
            }
        }
        finally//finally block that prints, "Calculations completed, with result of <result>"
        {
            Console.WriteLine("Calculations completed with a result of " + result);
        }

        try//Try calling CheckAge and passing through the int variable
        {
            CheckAge(myInt);
        }
        catch//catch block that prints own custom error message
        {
            Console.WriteLine($"You are {myInt}, you are not old enough");
        }
    }

        static float Divide(float a, float b)//a method that returns a float and takes two parameters
    {
            if (b == 0)//If the second parameter is equal to zero then it throws a DivideByZeroException
            {
                throw new DivideByZeroException();
            }
            else//Else, return first parameter divided by the second parameter
            {
                return a / b;
            }
        }

        static void CheckAge(int age)//method that has one int parameter
    {
            if (age >= 17)//If the parameter is greater than or equal to 17 then print to console, "You are <age>, you can play mature games"
            {
                Console.WriteLine($"You are {age}, you can play mature games");
            }
            else//Else, throw an ArgumentException
            {
                throw new ArgumentException();
            }
        }
}