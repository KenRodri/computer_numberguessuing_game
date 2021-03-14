using System;

namespace csharp_learning
{
    class Program
    {
        static void Main(string[] args)
        {
            Program obj = new Program();
            Console.WriteLine("Think of a number between 1 and 1000.");
            obj.guessNumGame(1000);
            Console.ReadLine();
        }
        public void guessNumGame(int x){
            int low = 1;
            int high = x;
            int feedback = 0;
            Random rndm = new Random();
            int guess = 0;
            while(feedback != 1){
                if(low != high){
                    guess = rndm.Next(low,high);
                }
                else{
                    guess = low;
                }
                Console.WriteLine("Is the number "+guess+"?");
                Console.WriteLine("Type '1' for correct, '2' for too high or '3' for too low.");
                feedback = Convert.ToInt32(Console.ReadLine());
                if (feedback == 2){
                    high = guess - 1;
                }
                else if(feedback == 3)
                {
                    low = guess + 1;
                }

            }
            Console.WriteLine("The computer guessed your number - "+guess+"!");
        }
    }
}
