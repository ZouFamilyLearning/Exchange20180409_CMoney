using System;
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
            // Reference 參考 ------> // Instance/Object/Value 實例/物件/實值
            CCalculator calculator = new CCalculator(Get1(), Get5(), Get10());

            bool haha = true;
            int amount = 0, input;

            do
            {
                Console.WriteLine("--------------------------------------------------------");
                Console.Write("換零錢 1)是 2)否? ");
                int x = int.Parse(Console.ReadLine());
                if (x == 2)
                {
                    end(haha);
                    break;
                }
                do
                {
                    Console.Write("請投入現金： 1) 50元 2) 100元 3) 500元 4) 1000元 5)結束 -1)取消: ");
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

                    int[] Change = calculator.change(amount);
                    calculator.printOut(Change);
                    if (Change[0] == 0 && Change[1] == 0 && Change[2] == 0)
                    {
                        end(haha);
                        break;
                    }
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