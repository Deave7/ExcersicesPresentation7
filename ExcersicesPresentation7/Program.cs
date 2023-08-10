namespace ExcersicesPresentation7
{
    internal class Program
    {
        static void Exempel1() //Övning 1 
        {
            Console.WriteLine("Please input a number: "); //Ber om ett nummer
            int number = Convert.ToInt32 (Console.ReadLine()); //Sparar nummer i variabel

            if (number % 2 == 0) //Om resten av värdet i variablen number är likamed 0 så är talet jämnt
            {
                Console.WriteLine($"The number {number} is even"); 
            }
            else //Annars är det udda
            {
                Console.WriteLine($"The number {number} is uneven");
            }
        }

        static void Exempel2() //Övning 2
        {
            Console.WriteLine("Please input a number: "); //Ber om ett nummer
            int number = Convert.ToInt32(Console.ReadLine()); //Sparar nummer i variabel

            if (number % 5 == 0 && number % 7 == 0) //om numrets rest är noll när man delar det med 5 OCH 7
            {
                Console.WriteLine("The number is even and divisible by 5 and 7");
            }
            else //annars 
            {
                Console.WriteLine("The number is not even and not divisible by 5 and 7");
            }
        }

        static void Exempel3() //Övning 3
        {
            //initierar och sätter värden på variabler 
            Console.WriteLine("Please enter the width of your rectangle:"); 
            int width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the height of your rectangle:");
            int height = Convert.ToInt32(Console.ReadLine());

            //räknar ut arean och skriver ut den 
            int result = width * height;
            Console.WriteLine($"The area of your rectangle is: {result} ");
        }

        static void Exempel4() //Övning 4
        {
            Console.WriteLine("Please input a number >99: "); //Ber om ett nummer
            int number = Convert.ToInt32(Console.ReadLine()); //Sparar nummer i variabel

            bool thirdFigure = (number / 100) % 10 == 7; //Kollar om tredje siffran från höger är likamed 7 

            Console.WriteLine(thirdFigure); //Skriver ut true eller false 
        }

        static void Exempel6() //Övning 6
        {
            //Matte igen.. 
            double x = 3;
            double y = 2;
            double distance = Math.Sqrt(x * x + y * y);
            bool result = distance <= 5;

            Console.WriteLine(result);
        }

        static void Exempel7() //Övning 7
        {
            Console.Write("Please input a number to check if it's a prime number: ");
            int primeNumber = Convert.ToInt32(Console.ReadLine());

            bool isPrime = true;
            
            //Primtal är endast jämt delbara med sig själva och 1 

            for (int i = 2; i <= Math.Sqrt(primeNumber); i++) //loopen får så länge i är mindre än eller likamed roten ut variablen primeNumber
            {
                if (primeNumber % i == 0) //Om resten av primenumber / i == 0 så är det inte ett primtal 
                {
                    isPrime = false;
                    break;
                }
            }

            Console.WriteLine($"Is {primeNumber} a primenumber? {isPrime}");

        }

        static void Exempel8() //Övning 8
        {
            Console.WriteLine("Var god mata in sidorna a, b och höjden h för paralleltrapetsen");
            Console.Write("A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("B: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("H: ");
            int h = Convert.ToInt32(Console.ReadLine());

            int area = ((a + b) / 2) * h;
            Console.WriteLine("Paralleltrapetsens area är: " + area);
        }

       
        static void Main(string[] args)
        {
            Exempel8();
        }
    }
}