using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    public class Kuriage
    {
        public static int Kuriage10(int i)
        {
            decimal a = i;
            int b;
            if(a >= 0)
            {
                b = (int)((Math.Ceiling(a / 10)) * 10);
            }
            else
            {
                b = (int)((Math.Floor(a / 10)) * 10);
            }
            return b;
        }
    }
}
