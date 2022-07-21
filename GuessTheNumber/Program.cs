namespace GuessTheNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess the number!");
            GuessNumber guessNumber=new GuessNumber();
            guessNumber.Guess();
        }
    }
}