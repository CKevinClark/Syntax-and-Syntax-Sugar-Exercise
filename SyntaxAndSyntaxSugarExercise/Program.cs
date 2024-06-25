using System.ComponentModel;

namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

             var randomNumber = random.Next();

            var answer = 965674; //var inferred typing 

            var response = (answer < randomNumber) ? $" less than {randomNumber}" : $" greater than or equal to {randomNumber}"; //ternary operator and inferred typing with Interpolated String true and false scopes
            
            Console.WriteLine($" You have failed, Duckman! For the answer is indeed {response}"); //interpolated string 
            
        }
    }
}
