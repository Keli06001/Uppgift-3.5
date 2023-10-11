using System;
 namespace uppgift3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv två tal");
            int två=int.Parse(Console.ReadLine());
            Console.WriteLine("");
            int ett=int.Parse(Console.ReadLine());
            Console.WriteLine("Välj ett räknesätt\r\n1. Addition\r\n2. Subtraktion\r\n3. Multiplikation\r\n4. Division");
            string räka=Console.ReadLine();
            switch (räka)
            {
                case "1":
                    Console.WriteLine(två + "+" + ett + "=");
                    Console.WriteLine(två + ett);
                    break;
                case "2":
                    Console.WriteLine(två + "-" + ett + "=");
                    Console.WriteLine(två - ett);
                    break;
                case "3":
                    Console.WriteLine(två + "*" + ett + "=");
                    Console.WriteLine(två * ett);
                    break;
                case "4":
                    Console.WriteLine(två + "/" + ett + "=");
                    Console.WriteLine(två / ett);
                    break;
            }
        }
    }
}