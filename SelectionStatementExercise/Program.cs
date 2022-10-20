namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine(new String('-', 28));
            Console.WriteLine("GUESS THE SECRET NUMBER GAME");
            Console.WriteLine(new String('-', 28));
            Console.WriteLine();
            var r = new Random();
            var favNumber = r.Next(1, 10);

            MyGuess(favNumber);
         }

        public static void MyGuess(int favNumber)
        {
        repeat:
  
            Console.WriteLine("Enter your guess at the Secret Number...");
            int userInput = int.Parse(Console.ReadLine());


            if (userInput < favNumber)
            {
                Console.WriteLine("Your guess was TOO LOW.");
                Console.WriteLine();
                goto repeat;
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine("Your guess was TOO HIGH.");
                Console.WriteLine();
                goto repeat;
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("CONGRATULATIONS!!");
                Console.WriteLine();
                Console.WriteLine($"The Number you guessed was:  {userInput}");
                Console.WriteLine($"The Secret Number was:       {favNumber}");    
            }


  
            //EXERCISE 2

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(new String('*', 28));
            Console.WriteLine("SCHOOL SUBJECT ADVICE");
            Console.WriteLine(new String('*', 28));
            Console.WriteLine();
            Console.WriteLine("Enter your favorite school subject...");
            string favSubject = (Console.ReadLine());
            Console.WriteLine();


            switch (favSubject.ToLower())
            {  
             case "history":
                Console.WriteLine("I was never a fan of History.");
                break;
            
             case "math":
                Console.WriteLine("Math graduates typically earn more.");
                break;

             case "coding":
                Console.WriteLine("The great thing about coding is Jeremy's class.");
                break;

             case "literature":
                Console.WriteLine("Plan on reading a lot of books.");
                break;

             default:
                Console.WriteLine("Subject not found.  Advice not available.");
                break;


            }






        }
    }
}


