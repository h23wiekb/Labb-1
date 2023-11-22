namespace Labb_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Deklarerar variabler för åldern
            double ageOne,AgeTwo,AgeThree,AgeFour;

            Console.WriteLine("Skriv namnet på person 1: "); 
            string nameOne = Console.ReadLine();
            Console.WriteLine("Skriv åldern på person 1: ");
            ageOne = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Skriv namnet på person 2: ");
            string nameTwo = Console.ReadLine();
            Console.WriteLine("Skriv åldern på person 2: ");
            AgeTwo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Skriv namnet på person 3: ");
            string nameThree = Console.ReadLine();
            Console.WriteLine("Skriv åldern på person 3: ");
            AgeThree = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Skriv namnet på person 4: ");
            string nameFour = Console.ReadLine();
            Console.WriteLine("Skriv åldern på person 4: ");
            AgeFour = Convert.ToDouble(Console.ReadLine());
            Console.Clear(); // Rensar konsolen

            // Skriver ut information om personerna
            Console.WriteLine(nameOne + " " + "är " + ageOne + " " + "år gammal" + 
                "\n" + nameTwo + " " + "är " + AgeTwo + " " + "år gammal" +
                "\n" + nameThree + " " + "är " + AgeThree + " " + "år gammal" +
                "\n" + nameFour + " "+ "är " + AgeFour + " " + "år gammal"
                 );
            // beräkning och utskrift av sammanlagd ålder för alla personern
            double wholeage = ageOne + AgeTwo + AgeThree + AgeFour;
            Console.WriteLine("Sammanlagd ålder är: " + wholeage);
     
            // beräkning och utskrift av medelåldern med två decimaler
            double average = (ageOne + AgeTwo + AgeThree + AgeFour) / 4;
            Console.WriteLine(average.ToString("Medelåldern är: ##.00"));
            
        }
    }
}