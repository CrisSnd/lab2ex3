using System;


namespace MyApp
{
    internal class Program
    {

        static void Main(string[] args)
        {
            /*Să se scrie un program care citeşte de la tastatură un şir de n numere naturale şi determină media aritmetică a celor pare, n fiind citit de la tastatura*/

            Console.WriteLine("Introduceti numerele sirului:");

            int suma = 0;
            int n;
            int z = 0;
            //int mediaAritmetica;

            List<int> sirNumere = new List<int>();


            while (int.TryParse(Console.ReadLine(), out n))
            {
                sirNumere.Add(n);
                Console.WriteLine("Pentru finalizarea sirului de numere si calcului mediei aritmetice a numerelor pare, apasa de doua ori tasta Enter:");
            }


            foreach (int i in sirNumere)
            {
                if (i % 2 == 0)
                {
                    suma = suma + i;
                    z = z + 1;
                }
                
            }

            int mediaAritmetica = suma / z;
            Console.WriteLine("Media aritmetica a numerelor pare este:" + mediaAritmetica);
        }
    }
}

