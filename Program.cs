namespace _9._5._nummers;
class Program
{
    static void Main(string[] args)
    {
        Nummers paar1 = new Nummers();
        paar1.Getal1 = Input.AskInteger("Geef een eerste getal op: ");
        paar1.Getal2 = Input.AskInteger("Geef een tweede getal op: ");
        Console.WriteLine($"Paar: {paar1.Getal1}, {paar1.Getal2}");
        Console.WriteLine($"Som = {paar1.Som()}");
        Console.WriteLine($"Verschil = {paar1.Verschil()}");
        Console.WriteLine($"Product = {paar1.Product()}");
        Console.WriteLine($"Quotient = {paar1.Quotient()}");

    }

    // Methods

    // Classes
    public class Nummers
    {
        public int Getal1 { get; set; }
        private int getal2;
        
        public int Getal2
        {
            get
            {
             return getal2; 
            }
            set
            {
                if (value > 0)
                {
                    getal2 = value;
                }
                else
                {
                    Console.WriteLine("Wrong input");

                }
                    
            }
        }

        public int Som()
        {
            return Getal1 + Getal2;
        }

        public int Verschil()
        {
            return Getal1 - Getal2;
        }

        public int Product()
        {
            return Getal1 * Getal2;
        }

         public double Quotient()
        {
           
            return (double) Getal1 / (double) Getal2;
        }

    }

    public static class Input
    {
        public static string AskString(string question)
        {
            Console.Write($"{question}");
            return Console.ReadLine() ?? string.Empty;
        }
        public static int AskInteger(string question)
        {
            while (true)
            {
                Console.Write($"{question}");
                if (int.TryParse(Console.ReadLine(), out int r))
                    return r;

            }
        }
    }
}
