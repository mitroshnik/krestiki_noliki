using System;

namespace X_0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Кто ходит первым? [1][2]");
            var id = int.TryParse(Console.ReadLine(), out int ID);
            var vibor = ID;
            int win=ID;
            if (id)
            {
                char[] mas = new char[9] { '1','2','3','4','5','6','7','8','9' };
                while (!proverka(mas))
                {
                    win = ID;
                    for (int i=0; i<9; i++)
                    {
                        Console.Write($"|{mas[i]}| ");
                        if ( i == 2 || i==5 || i==8 )
                        {
                            Console.WriteLine("\n");
                        }
                    }
                    Console.WriteLine($"ход игрока {ID}:");
                    var try_hod = int.TryParse(Console.ReadLine(), out int hod);
                    if (try_hod)
                    {
                        for (int i = 0; i < 9; i++)
                        {
                            if(mas[i]!='X' && mas[i] != '0')
                            {
                                if (ID == vibor)
                                {
                                    mas[hod - 1] = 'X';
                                }
                                else
                                {
                                    mas[hod - 1] = '0';
                                }
                            }
                            else
                            {
                                Console.WriteLine("ошибка");
                                return;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("ошибка");
                        return;
                    }
                    if (ID == 1)
                    {
                        ID = 2;
                    }
                    else
                    {
                        ID = 1;
                    }
                }
                for (int i = 0; i < 9; i++)
                {
                    Console.Write($"|{mas[i]}| ");
                    if (i == 2 || i == 5 || i == 8)
                    {
                        Console.WriteLine("\n");
                    }
                }
                Console.WriteLine($"Победил игрок {win}");
            }
            else
            {
                Console.WriteLine("ошибка");
                return;
            }
        }
        static bool proverka(char[] m)
        {
            for(int i=0; i<7; i++)
            {
                if(m[i]==m[i+1] && m[i + 1] == m[i + 2])
                {
                    return true;
                }
            }
            if (m[0] == m[4] && m[4] == m[8])
            {
                return true;
            }
            if (m[2] == m[4] && m[4] == m[6])
            {
                return true;
            }
            for(int i=0; i<3; i++)
            {
                if (m[i] == m[i + 3] && m[i + 3] == m[i + 6])
                {
                    return true;
                }
            }
            return false;
        }
    }
}
//привет
