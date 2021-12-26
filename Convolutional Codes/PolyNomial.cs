using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Convolutional_Codes
{
    class PolyNomial
    {
        List<int> pl;

        public PolyNomial()
        {
            pl = new List<int>();
        }

        public PolyNomial(int degree)
        {
            pl = new List<int>();
            for (int i = 0; i < degree; i++)
            {
                pl.Add(0);
            }
        }

        public PolyNomial(string m)
        {
            if (m.Contains("+") || m.Contains("X"))
            {
                List<int> temp = new List<int>();
                string[] p = m.Replace(" ", "").Replace("1+", "0+").Replace("X+", "1+").Replace("X", "").Split(new char[] { '+' });

                if (p.Count() == 1 && p[0] == "")
                {
                    pl = new List<int>();
                    pl.Add(0);
                    pl.Add(1);
                    return;
                }

                foreach (string s in p)
                {
                    temp.Add(Convert.ToInt32(s));
                }

                pl = new List<int>();

                for (int i = 0; i < temp.Max() + 1; i++)
                {
                    pl.Add(0);
                }

                foreach (int i in temp)
                {
                    pl[i] = 1;
                }
            }
            else
            {
                pl = new List<int>();
                string p = m.Replace(" ", "");
                foreach (char c in p)
                {
                    pl.Add(c == '1' ? 1 : 0);
                }
            }
        }

        public int this[int r]
        {
            get
            {
                return pl[r];
            }
            set
            {
                pl[r] = value;
            }
        }

        public PolyNomial Remainder(PolyNomial gX)
        {
            if (this.Length < gX.Length)
            {
                return this;
            }
            else
            {
                return this.AddWithoutCarry(gX.RightShift(this.Length - gX.Length)).Remainder(gX);
            }
        }

        public PolyNomial RightShift(int shiftBy)
        {
            PolyNomial temp = new PolyNomial();
            temp.pl = new List<int>(pl.ToArray());
            temp.pl.InsertRange(0, new PolyNomial(shiftBy).pl);
            return temp;
        }

        public PolyNomial LeftShift(int shiftBy)
        {
            PolyNomial temp = new PolyNomial();
            temp.pl = new List<int>(pl.ToArray());
            temp.pl.InsertRange(temp.pl.Count, new PolyNomial(shiftBy).pl);
            return temp;
        }

        public PolyNomial Join(PolyNomial p)
        {
            PolyNomial temp = new PolyNomial(this.pl.Count + p.pl.Count);

            for (int i = 0; i < pl.Count; i++)
            {
                temp.pl[i] = this.pl[i];
            }
            for (int i = pl.Count; i < temp.pl.Count; i++)
            {
                temp.pl[i] = p.pl[i];
            }

            return temp;
        }

        public bool IsAllZero
        {
            get
            {
                foreach (int i in pl)
                {
                    if (i != 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        public string ToBinaryString()
        {
            string bs = "";
            foreach (int i in pl)
            {
                bs = bs + i.ToString();
            }
            return bs;
        }

        public string ToPolynomialString()
        {
            string ps = "";
            for (int i = 0; i < pl.Count; i++)
            {
                if (pl[i] == 1)
                {
                    if (i == 0)
                    {
                        ps = "1";
                    }
                    else if (i == 1)
                    {
                        ps = ps + "+X";
                    }
                    else
                    {
                        ps = ps + "+X" + i.ToString();
                    }
                }
            }
            return ps.Trim(new char[] { '+' });
        }

        public int Length
        {
            get
            {
                return pl.Count;
            }
        }

        public PolyNomial AddWithoutCarry(PolyNomial p)
        {
            PolyNomial temp = new PolyNomial(pl.Count);
            for (int i = 0; i < pl.Count; i++)
            {
                temp.pl[i] = pl[i] + p.pl[i];
                if (temp.pl[i] == 2)
                {
                    temp.pl[i] = 0;
                }
            }

        reStart:
            for (int i = temp.pl.Count - 1; i >= 0; i--)
            {
                if (temp.pl[i] == 0)
                {
                    temp.pl.RemoveAt(i);
                    goto reStart;
                }
                else
                {
                    break;
                }
            }
            return temp;
        }

        public PolyNomial Multiply(PolyNomial p)
        {
            PolyNomial temp = new PolyNomial(p.pl.Count);

            for (int i = 0; i < pl.Count; i++)
            {
                if (pl[i] == 1)
                {
                    PolyNomial tmp = p.RightShift(i);
                    if (temp.Length > tmp.Length)
                    {
                        tmp = tmp.LeftShift(temp.Length - tmp.Length);
                    }
                    else if (tmp.Length > temp.Length)
                    {
                        temp = temp.LeftShift(tmp.Length - temp.Length);
                    }

                    temp = temp.AddWithoutCarry(tmp);
                   // temp = temp.LeftShift(i).AddWithoutCarry(p.RightShift(i));
                }
            }
            return temp;
        }

    }
}
