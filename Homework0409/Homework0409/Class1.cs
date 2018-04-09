using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework0409
{
    // 改成建構子
    public class CCalculator
    {
        private int _coin10;
        private int _coin5;
        private int _coin1;

        public CCalculator(int titleCoin10, int titleCoin5, int titleCoin1)
        {
            this._coin10 = titleCoin10;
            this._coin5 = titleCoin5;
            this._coin1 = titleCoin1;
        }

        static public string Get1()
        {
            Console.Write("1元硬幣個數：");
            return Console.ReadLine();
        }

        static public string Get5()
        {
            Console.Write("5元硬幣個數：");
            return Console.ReadLine();
        }

        static public string Get10()
        {
            Console.Write("10元硬幣個數：");
            return Console.ReadLine();
        }


        public void printOut(int[] coins)
        {
            Console.WriteLine("");
        }
        
    }
}
