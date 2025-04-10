using System;

class Program
{
    static void Main(string[] args)
    {
        const int genislik = 15;
        const int yukseklik = 15;
        const int hedefSayisi = 3;

        int karakter_x = 0;
        int karakter_y = 0;
        int cursor_x = karakter_x * 2; 
        int cursor_y = karakter_y;
        int hedefIndex = 0;
        int hedefSayi = 0;
        
        Random rnd = new Random();
        int[] hedef_x = new int[hedefSayisi];
        int[] hedef_y = new int[hedefSayisi];
        for (int i = 0; i < hedefSayisi; i++)
        {
            hedef_x[i] = rnd.Next(0, genislik);
            hedef_y[i] = rnd.Next(0, yukseklik);
        }

        while (true)
        {
            Console.Clear();

            for (int y = 0; y < yukseklik; y++)
            {
                for (int x = 0; x < genislik; x++)
                {
                    if (x == karakter_x && y == karakter_y)
                    {
                        Console.Write("A ");
                    }
                    else if (x == hedef_x[hedefIndex] && y == hedef_y[hedefIndex])
                    {
                        Console.Write("X ");
                    }
                    else
                    {
                        Console.Write("- ");
                    }
                }
                Console.WriteLine();
            }

            Console.SetCursorPosition(cursor_x, cursor_y);

            if (hedefSayi == hedefSayisi)
            {
                Console.WriteLine("Tebrikler! Kazandınız!");
                Console.WriteLine("Tekrar başlamak için 'Enter' tuşuna basın.");
                Console.ReadLine();

                karakter_x = 0;
                karakter_y = 0;
                hedefSayi = 0;
                hedefIndex = 0;
                cursor_x = karakter_x * 2;
                cursor_y = karakter_y;

                for (int i = 0; i < hedefSayisi; i++)
                {
                    hedef_x[i] = rnd.Next(0, genislik);
                    hedef_y[i] = rnd.Next(0, yukseklik);
                }

                continue;
            }

            ConsoleKeyInfo tusbilgi = Console.ReadKey();//m to n
            switch (tusbilgi.Key)
            {
                case ConsoleKey.UpArrow:
                    if (karakter_y > 0)
                    {
                        karakter_y--;
                        cursor_y = karakter_y;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (karakter_y < yukseklik - 1)
                    {
                        karakter_y++;
                        cursor_y = karakter_y;
                    }
                    break;
                case ConsoleKey.LeftArrow:
                    if (karakter_x > 0)
                    {
                        karakter_x--;
                        cursor_x = karakter_x * 2; 
                    }
                    break;
                case ConsoleKey.RightArrow:
                    if (karakter_x < genislik - 1)
                    {
                        karakter_x++;
                        cursor_x = karakter_x * 2; 
                    }
                    break;
            }

            if (karakter_x == hedef_x[hedefIndex] && karakter_y == hedef_y[hedefIndex])
            {
                hedefSayi++;
                hedefIndex = rnd.Next(0, hedefSayisi);
            }
        }
    }
}

