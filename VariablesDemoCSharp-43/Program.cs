namespace VariablesDemoCSharp_43
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables

            //Number types
            //Declaring a variable (creation)
            int wholeNumber;

            //Initialize a variable (give it a value)
            wholeNumber = 100;

            //Or do both
            //Declaring and initializing
            int otherNumber = 15;

            double avg;
            avg = 98.7;

            decimal myWallet = 500.00m;

            //Word types
            string myName = "Seth Bowman";

            char key = '1';

            //Logic type
            bool isCoding = true;

            //String interpolation
            string mySentence = $"My name is {myName}.";

            Console.WriteLine($"{mySentence} The numbers {wholeNumber} + {avg} = {wholeNumber + avg}");            

        }
    }
}