namespace MehmetArdaTepeciOdev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a, b, c;
            Console.WriteLine("Bir dil seçiniz/Select a language(E/T)");
            string cev = Console.ReadLine().ToUpper();
            Random rnd = new Random();
            if (cev == "E")
            {
                a = "Enter the starting number:";
                b = "Enter the ending number:";
                c = "Enter the count of numbers:";

            }
            else
            {
                a = "Başlangıç sayısını giriniz:";
                b = "Bitiş sayısı giriniz:";
                c = "Sayı adeti gir:";
            }

            Console.WriteLine(a);
            byte start = byte.Parse(Console.ReadLine());
            Console.WriteLine(b);
            byte end = byte.Parse(Console.ReadLine());

            Console.WriteLine(c);
            byte count = byte.Parse(Console.ReadLine());


            int[] numbers = new int[count];
            int num;
            for (int i = 0; i < numbers.Length; i++)
            {
                num = rnd.Next(start, end);
                if (i == 0)
                {
                    numbers[i] = num;
                }
                for (int j = 0; j < i; j++)
                {
                    if (numbers[j] == num)
                    {
                        i--;
                        break;
                    }
                    else
                    {
                        numbers[i] = num;
                    }
                }
            }
            Array.Sort(numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }




        }
    }
}