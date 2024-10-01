using System;
using System.Reflection.Metadata.Ecma335;

namespace EnkelKalkylator // Deklarerar ett nytt namnrum som innehåller programmet
{
    class Program // Definierar huvudklassen för programmet
    {
        static void Main(string[] args) // Huvudmetoden där programmet startar
        {
            // Skriver ut instruktioner för att välja en operation (addition, subtraktion, multiplikation, division)
            Console.WriteLine("Ange operation (+, -, *, /): ");

            // Läsar användarens inmatade operationstangent och lagrar den i variabeln 'operation'
            char operation = Console.ReadKey().KeyChar;

            // Be användaren att ange det första talet
            Console.WriteLine("\nAnge första talet: ");

            // Konverterar användarens inmatade sträng till ett flyttal (double) och lagrar det i 'num1'
            double num1 = Convert.ToDouble(Console.ReadLine());

            // Be användaren att ange det andra talet
            Console.WriteLine("Ange andra talet: ");

            // Konverterar det andra talet på samma sätt och lagrar det i 'num2'
            double num2 = Convert.ToDouble(Console.ReadLine());

            // Deklarerar variabeln 'result' och initierar den till 0 för att lagra resultatet av beräkningen
            double result = 0;

            // Switch-sats för att kontrollera vilken operation användaren har valt
            switch (operation)
            {
                // Om användaren valt '+', adderas de två talen
                case '+':
                    result = num1 + num2;
                    break;
                // Om användaren valt '-', subtraheras det andra talet från det första
                case '-':
                    result = num1 - num2;
                    break;
                // Om användaren valt '*', multipliceras de två talen
                case '*':
                    result = num1 * num2;
                    break;
                // Om användaren valt '/', utför division, men endast om det andra talet inte är noll
                case '/':
                    if (num2 != 0) // Kontroll för att undvika division med noll
                    {
                        result = num1 / num2; // Utför division om talet inte är noll
                    }

                    else // Om det andra talet är noll, skriv ut ett felmeddelande
                    {
                        Console.WriteLine("Du kan inte dividera med noll");
                    }
                    break;
                // Om användaren har valt en ogiltig operation, skriv ut ett felmeddelande och avsluta programmet
                default:
                    Console.WriteLine("Ogiltig operation.");
                    return; // Avslutar programmet om en ogiltig operation angavs
            }
            // Skriver ut resultatet av beräkningen om en giltig operation valdes
            Console.WriteLine($"Resultat: {result}");
            // Väntar på att användaren trycker på en tangent innan programmet avslutas
            Console.ReadKey();
        }
    }
}
