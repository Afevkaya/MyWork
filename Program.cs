using System;

namespace Odev1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.ÖDEV
            
            // 1.soru
            /*
            int diziUzunlugu;

            Console.WriteLine("Lutfen bir sayi giriniz");
            diziUzunlugu = int.Parse(Console.ReadLine());

            int[] dizi = new int[diziUzunlugu];

            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.WriteLine("Dizi elemanlarını giriniz");
                dizi[i] = int.Parse(Console.ReadLine());
                
            }

            foreach (var elaman in dizi)
            {
                if (elaman % 2 == 0)
                {
                    Console.WriteLine(elaman);
                }
            }
            */

            
            // 2.soru
            /*
            int numberOne,numberTwo;
            Console.WriteLine("Lutfen birinci sayi giriniz");
            numberOne = int.Parse(Console.ReadLine());
            Console.WriteLine("Lutfen ikinci sayi giriniz");
            numberTwo = int.Parse(Console.ReadLine());

            int[] arrayNumber = new int[numberOne];
            for (int i = 0; i < numberOne; i++)
            {
                Console.WriteLine("Lutfen " + i + ". sayiyi giriniz");
                arrayNumber[i] = int.Parse(Console.ReadLine());
            }

            foreach (var number in arrayNumber)
            {
                if (numberTwo == number || numberTwo % number == 0)
                {
                    Console.WriteLine(number);
                }
            }
            */

            // 3.soru
            /*
            int number;
            Console.WriteLine("Lutfen bir sayi giriniz");
            number = int.Parse(Console.ReadLine());
            string[] myWord = new string[number];

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("Lutfen kelime giriniz");
                myWord[i] = Console.ReadLine();
            }

            for (int i = number-1; i >= 0; i--)
            {
                Console.WriteLine(myWord[i] + " ");
            }
            */

            // 4.soru
            /*
            string sentence;
            Console.WriteLine("Lutfen bir cümle giriniz");
            sentence = Console.ReadLine();
            string[] word = sentence.Split(' ');


            int wordCount = 0;
            wordCount = word.Length;
            Console.WriteLine(wordCount);

            int characterCount = 0;
            characterCount = sentence.Length;
            Console.WriteLine(characterCount);
            */



        }
    }
}
