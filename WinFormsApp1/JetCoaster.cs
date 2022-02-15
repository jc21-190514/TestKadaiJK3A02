using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    public class JetCoaster
    {
        public static int ride(int k, int[] g, int r)
        {
            int[] jet = new int[g.Length];
            Array.Copy(g, jet, g.Length);
            int goukei = 0;
            int hozon;
            int aa = k;

            for(int n = 0; r >n; n++)
            {
                k = aa;
                int count = 0;
                for(int i = 0; i < g.Length; i++)
                {
                    if (k >= g[i])
                    {
                        k = k - g[i];
                        goukei = goukei + g[i];
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }
                for (int c = 0; count > c; c++)
                {
                    hozon = g[0];
                    for (int s = 0; g.Length > s; s++)
                    {
                        if (s == g.Length - 1)
                        {
                            g[s] = hozon;
                        }
                        else
                        {
                            g[s] = g[s + 1];
                        }
                    }
                }
            }
            Array.Copy(jet, g, jet.Length);
            return goukei;
        }
    }
}
