using System;

namespace The_Nim
{
    class Program
    {
        static void Main(string[] args)
        {
            int bucket1, bucket2, bucket3;
            Console.Write("Input the number of boxes in the bucket 1 : ");
            bucket1 = int.Parse(Console.ReadLine());
            Console.Write("Input the number of boxes in the bucket 2 : ");
            bucket2 = int.Parse(Console.ReadLine());
            Console.Write("Input the number of boxes in the bucket 3 : ");
            bucket3 = int.Parse(Console.ReadLine());
            int num, remove;

            do
            {
                Console.WriteLine("");
                Console.Write("Player A chooses the number of buckets : ");
                num = int.Parse(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        Console.Write("Player A removes : ");
                        remove = int.Parse(Console.ReadLine());
                        Console.WriteLine("");
                        if ((remove >= 1 && remove < 3))
                        { bucket1 = bucket1 - remove; }
                        break;

                    case 2:
                        Console.Write("Player A removes : ");
                        remove = int.Parse(Console.ReadLine());
                        Console.WriteLine("");
                        if ((remove >= 1 && remove < 3))
                        { bucket2 = bucket2 - remove; }
                        break;

                    case 3:
                        Console.Write("Player A removes : ");
                        remove = int.Parse(Console.ReadLine());
                        Console.WriteLine("");
                        if ((remove >= 1 && remove < 3))
                        { bucket3 = bucket3 - remove; }
                        break;
                }
                if (bucket1 == 0 && bucket2 == 0 && bucket3 == 0)
                {
                    Console.WriteLine("Player B wins because Player A removes the last box.");
                }
                else
                {
                    Console.Write("Player B chooses the number of buckets : ");
                    num = int.Parse(Console.ReadLine());
                    switch (num)
                    {
                        case 1:
                            Console.Write("Player B removes : ");
                            remove = int.Parse(Console.ReadLine());
                            Console.WriteLine("");
                            if ((remove >= 1 && remove < 3))
                            { bucket1 = bucket1 - remove; }
                            break;

                        case 2:
                            Console.Write("Player B removes : ");
                            remove = int.Parse(Console.ReadLine());
                            Console.WriteLine("");
                            if ((remove >= 1 && remove < 3))
                            { bucket2 = bucket2 - remove; }
                            break;

                        case 3:
                            Console.Write("Player B removes : ");
                            remove = int.Parse(Console.ReadLine());
                            Console.WriteLine("");
                            if ((remove >= 1 && remove < 3))
                            { bucket3 = bucket3 - remove; }
                            break;
                    }
                    if (bucket1 == 0 && bucket2 == 0 && bucket3 == 0)
                    {
                        Console.WriteLine("Player A wins because Player B removes the last box.");
                    }
                }
            } while (bucket1 != 0 || bucket2 != 0 || bucket3 != 0);
            Console.ReadLine();
        }
    }
}
