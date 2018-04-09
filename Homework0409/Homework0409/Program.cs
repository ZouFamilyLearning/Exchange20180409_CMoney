﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework0409
{
    class Program
    {
        static void Main(string[] args)
        {
            //CCalculator calculator = new CCalculator();
            int[] Change = new int[3];
            bool haha = true;
            int amount = 0, input;

            int coin1 = Get1();
            int coin5 = Get5();
            int coin10 = Get10();

            do
            {
                Console.Write("換零錢 1)是 2)否? ");
                int x = int.Parse(Console.ReadLine());
                if (x == 2)
                {
                    end(haha);
                    break;
                }
                do
                {
                    Console.Write("請投入現金： 1) 50元 2) 100元 3) 500元4) 1000元 5)結束 -1)取消: ");
                    input = int.Parse(Console.ReadLine());
                    switch (input)
                    {
                        case 1:
                            amount += 50;
                            break;
                        case 2:
                            amount += 100;
                            break;
                        case 3:
                            amount += 500;
                            break;
                        case 4:
                            amount += 1000;
                            break;
                        default:
                            break;
                    }
                } while (input != 5 && input != -1);

                if (input == 5)
                {
                    Console.WriteLine($"兌換{amount}元");
                    exchange(amount, Change, coin10, coin5, coin1);
                    if (Change[0] != 0)
                    {
                        Console.Write($"退回10元硬幣{Change[0]}個");
                    }
                    if (Change[1] != 0)
                    {
                        Console.Write($"，5元硬幣{Change[1]}個");
                    }
                    if (Change[2] != 0)
                    {
                        Console.Write($"，1元硬幣{Change[2]}個");
                    }
                    if (Change[0] == 0 && Change[1] == 0 && Change[2] == 0)
                    {
                        end(haha);
                        break;
                    }
                    Console.WriteLine();
                    Console.WriteLine("---------------------------------------------------------------------------------");

                }
                if (input == -1)
                {
                    end(haha);
                    break;
                }

            } while (haha == true);
            Console.ReadKey();
        }

        public static void end(bool haha)
        {
            Console.WriteLine("程式終止");
            haha = false;
        }

        public static int[] exchange(int amount, int[] Change, int coin10, int coin5, int coin1)
        {
            int i = amount / 10;
            if (i <= coin10)
            {
                Change[0] = i;
                // Console.WriteLine($"退回10元硬幣{i}個");
            }
            else
            {
                int j = 0;
                j = i - coin10;
                j *= 2;

                if (j <= coin5)
                {
                    Change[0] = coin10;
                    Change[1] = j;
                    //Console.WriteLine($"退回10元硬幣5個，5元硬幣{j}個");
                }
                else
                {
                    int k = 0;
                    k = j - coin5;
                    k *= 10;
                    if (k <= coin1)
                    {
                        Change[0] = coin10;
                        Change[1] = coin5;
                        Change[2] = k;
                        // Console.WriteLine($"退回10元硬幣5個，5元硬幣30個，1元硬幣{k}個");
                    }
                    else
                    {
                        Console.WriteLine("現金不足，無法找零");

                    }
                }
            }
            return Change;
        }

        static public int Get1()
        {
            Console.Write("1元硬幣個數：");
            return int.Parse(Console.ReadLine());
        }

        static public int Get5()
        {
            Console.Write("5元硬幣個數：");
            return int.Parse(Console.ReadLine());

        }

        static public int Get10()
        {
            Console.Write("10元硬幣個數：");
            return int.Parse(Console.ReadLine());

        }
    }
}
