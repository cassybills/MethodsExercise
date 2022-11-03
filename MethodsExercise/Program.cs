using System.Security.Cryptography.X509Certificates;

namespace MethodsExercise
{
    public class Program
    {
        private static void Main(string[] args)
        {
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

        }
            
    }        

            
}            

           
                       

    

            

        
    




