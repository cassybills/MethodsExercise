using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace MethodsExercise
{
    public class Program
    {
    
        public static int Sum(int num1, int num2)
        {
          
            var answer = num1 + num2;
            return answer; 

        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;

        }

        public static int Subtract(int num1, int num2)
        { 
            return num1 - num2;

        

        }    

        public static int Divide(int num1, int num2)
        { 
            return num1 / num2;

        

        }    


        static void Main(string[] args)
        {
            var amountOfPens = Sum(2, 6); 
            var apples = Multiply(75, 3);
            var pencils = Subtract(124, 72);
            var markers = Divide(80, 4);
            

            
            //-------------MethodsExercise 1------------------------
                //Name: Cassy
                //Favorite color: Green
                //Favorite Animal: Dog
                //Favorite Band: the Used

            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();

            Console.WriteLine("What is your favorite color?");
            string color = Console.ReadLine();

            Console.WriteLine("What is your favorite animal?");
            string userAnimalName = Console.ReadLine();

           
            Console.WriteLine("What is your favorite band?");
            string userBandName = Console.ReadLine();

            Console.WriteLine($"There is a woman named {userName},her favorite color is {color}.");       
            Console.WriteLine($"Her favorite animal is her {userAnimalName} that she loves more than anything in the universe.");
            Console.WriteLine($"The only thing she loves almost as much as her dog is her favorite band {userBandName}.");

            //-------------MethodsExercise 2------------------------

        }
            
    }        

            
}            

           
                       

    

            

        
    




