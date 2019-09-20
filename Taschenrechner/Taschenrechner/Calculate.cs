using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class Calculate
    {
        public Calculate()
        {

        }

        static public string Solve (string calcString)
        {
            string[] splittCalcString = SplitCalcString(calcString);
            if (CheckCalcArray(ref splittCalcString))
            {
                //Variablen Deklarieren
                string solString = "Error";
                string[] currEx;

                //Aktuelle Teilaufgabe
                


                //Punkt vor Strich



                return solString;
            }
            else
                return "Error";
        }

        private static bool CheckCalcArray(ref string[] arr)
        {
            //wenn nicht alle elemente zahlen der operatoren sind, wird false zurück gegeben
            if (!arr.Any(x => IsNumber(x) || IsOperator(x)))
                return false;

            List<string> l = new List<string>(arr);

            if (l.First() == "-")
            {
                l.RemoveAt(0);
                l[0] = "-" + l[0];
            }

            if (IsOperator(l.Last()))
                return false;

            //doppelte Minus und plus Entfernen oder austauschen
            for (int i = 0; i < l.Count; i++)
            {
                if (l[i] == "-")
                {
                    if (i < l.Count - 1)
                    {
                        if (l[i + 1] == "-")
                        {
                            if (IsOperator(l[i - 1]))
                            {
                                l.RemoveAt(i);
                                l.RemoveAt(i);
                            }
                            else
                            {
                                l.RemoveAt(i);
                                l[i] = "+";
                            }
                        }
                        else if (IsOperator(l[i - 1]))
                        {
                            if (IsNumber(l[i + 1]))
                            {
                                l.RemoveAt(i);
                                l[i] = "-" + l[i];
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                }

                if (l[i] == "+" && i > 0)
                {
                    if (IsOperator(l[i - 1]))
                    {
                        if (i < l.Count - 1)
                        {
                            l.RemoveAt(i);

                            if (i >= l.Count || (i < l.Count && (l[i] != "+" || l[i] != "-")))
                                return false;
                        }
                        else
                        {
                            return false;
                        }

                    }
                }
            }



            //wenn nicht alle elemente zahlen der operatoren sind, wird false zurück gegeben
            if (!arr.Any(x => IsNumber(x) || IsOperator(x)))
                return false;

            for (int i = 1; i < l.Count; i++)
            {
                if (IsOperator(l[i - 1]))
                {
                    if (IsOperator(l[i]))
                    {
                        if (l[i] != "-")
                        {
                            return false;
                        }
                        else
                        {
                            l.RemoveAt(i);

                            if (i < l.Count)
                                l[i] = "-" + l[i];
                            else
                                return false;
                        }

                    }
                }
            }


            arr = l.ToArray();
            return true;
        }

        private static string[] SplitCalcString(string calcString)
        {
            string[] calcArray = new string[calcString.Length];
            int counter = 0;
            bool lastCharNmbr = false;
            foreach (char c in calcString)
            {

                if (c == '+' || c == '*' || c == '-' || c == '/')
                {
                    counter++;
                    calcArray[counter] = c.ToString();
                    counter++;
                    lastCharNmbr = false;
                }
                else
                {
                    calcArray[counter] += c.ToString();
                    lastCharNmbr = true;
                }
            }

            return calcArray;
        }

        private bool IsOperator(string s)
        {
            string[] ops = new string[] { "+", "-", "*", "/" };
            return ops.Contains(s);
        }

        private bool IsNumber(string s)
        {
            return double.TryParse(s, out double d);
        }
    }
}
