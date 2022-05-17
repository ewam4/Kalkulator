using System;


namespace kalkulator2
{
    class Program
    {
        static void Main(string[] args)
        {
            double liczbapierwsza = 0; double liczbadruga = 0; int ktoraliczba; 
            Console.WriteLine("Podaj proszę pierwszą liczbę:");
            liczbapierwsza = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Jaką operację chcesz wykonać? Wciśnij: +, -, *, /,%,^,p");
            var dzialanie = Console.ReadLine();
            Console.WriteLine("Podaj proszę drugą liczbę:");
            liczbadruga = Convert.ToDouble(Console.ReadLine());


            var wynik = 0.00;
            switch (dzialanie)
            {
                case "+":
                    Console.WriteLine($"Wynik:  " + (liczbapierwsza + liczbadruga));
                    break;
                case "-":
                    Console.WriteLine($"Wynik:  " + (liczbapierwsza - liczbadruga));
                    break;
                case "*":
                    Console.WriteLine($"Wynik:  " + (liczbapierwsza * liczbadruga));
                    break;
                case "/":
                    Console.WriteLine($"Wynik:  " + (liczbapierwsza / liczbadruga));
                    break;
                case "^":
                    Console.WriteLine("którą liczbę: wybierz 1 aby wybrać liczbę pierwszą lub 2 aby wybrać liczbę drugą");
                    ktoraliczba = Convert.ToInt32(Console.ReadLine());
                    {
                        if (ktoraliczba == 1)
                            Console.WriteLine($"Wynik: " + ((liczbapierwsza * liczbapierwsza)));
                        

                        else
                            Console.WriteLine($"Wynik: " + ((liczbadruga * liczbadruga)));
                    }
                 
                    break;
                case "p":
                    Console.WriteLine("którą liczbę: wybierz 1 aby wybrać liczbę pierwszą lub 2 aby wybrać liczbę drugą");
                    ktoraliczba = Convert.ToInt32(Console.ReadLine());
                    {
                        if (ktoraliczba == 1)

                       Console.WriteLine($"Wynik: " + (Math.Sqrt(liczbapierwsza))); 

                   else
                            Console.WriteLine($"Wynik: " + (Math.Sqrt(liczbadruga)));
                   }
                   break;
                case "%":
                    Console.WriteLine($"Wynik:  " + ((liczbapierwsza / liczbadruga)*100));
                    break;
              



            }
        }
    }
}
