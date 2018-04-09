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
        // properties/attribute 特性/屬性
        private int _coin10;
        private int _coin5;
        private int _coin1;

        // function/method 函式/方法
        public CCalculator(int titleCoin1, int titleCoin5, int titleCoin10)
        {
            this._coin10 = titleCoin10;
            this._coin5 = titleCoin5;
            this._coin1 = titleCoin1;
        }

        public int[] change(int amount)
        {
            int[] Change = new int[3];

            int i = amount / 10; // 得到i個10元
            if (i <= _coin10) // i小於使用者輸入的10元個數，代表10元夠用
            {
                Change[0] = i; // 設定陣列第一個int為i
            }
            else
            {
                int j = i - _coin10; // 使用者輸入的10元個數用完後，剩下的10元個數
                j *= 2; // 一個10=2個5元，代表剩下j個5元個數

                if (j <= _coin5)// j小於使用者輸入的5元個數，代表5元夠用
                {
                    Change[0] = _coin10; // 10元個數都用完，全部存入陣列[0]
                    Change[1] = j;// 設定陣列第二個int為j
                }
                else
                {
                    int k = j - _coin5;// 使用者輸入的10元、5元個數用完後，剩下的5元個數
                    k *= 5;// 一個5元=5個1元，代表剩下k個1元個數

                    if (k <= _coin1)// k小於使用者輸入的1元個數，代表1元夠用
                    {
                        Change[0] = _coin10;// 10元個數都用完，全部存入陣列[0]
                        Change[1] = _coin5;// 5元個數都用完，全部存入陣列[1]
                        Change[2] = k;// 設定陣列第三個int為k
                    }
                    else
                    {
                        Console.WriteLine("現金不足，無法找零");
                    }
                }
            }
            return Change;
        }

        public void printOut(int[] coins)
        {
            string str = "";
            if (coins[0] != 0)
            {
                str += $"退回10元硬幣{coins[0]}個，";
            }
            if (coins[1] != 0)
            {
                str += $"5元硬幣{coins[1]}個，";
            }
            if (coins[2] != 0)
            {
                str += $"1元硬幣{coins[2]}個，";
            }
            str = str.Substring(0, str.Length - 1);
            Console.WriteLine(str);
        }

    }
}
