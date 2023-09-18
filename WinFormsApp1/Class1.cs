using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class CashierClass {
        private int x;
        public static string getNumberInQueue = "";
        public static Queue<string> CashierQueue;

        public CashierClass() {

            x = 10000;
            CashierQueue = new Queue<string>();
        }

        public string CashiergeneratedNumber(string CashierNumbre)

        {
            x++;
            CashierNumbre += x.ToString();
            return CashierNumbre;
        }

    }

    

   

}
