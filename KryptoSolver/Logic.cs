using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KryptoSolver
{
    public class Logic
    {
        static List<string[]> getPerms()
        {
            string[] perms = new string[]
            {
                "A,B,C,D,E",

                "B,A,C,D,E",

                "C,A,B,D,E",

                "A,C,B,D,E",

                "B,C,A,D,E",

                "C,B,A,D,E",

                "C,B,D,A,E",

                "B,C,D,A,E",

                "D,C,B,A,E",

                "C,D,B,A,E",

                "B,D,C,A,E",

                "D,B,C,A,E",

                "D,A,C,B,E",

                "A,D,C,B,E",

                "C,D,A,B,E",

                "D,C,A,B,E",

                "A,C,D,B,E",

                "C,A,D,B,E",

                "B,A,D,C,E",

                "A,B,D,C,E",

                "D,B,A,C,E",

                "B,D,A,C,E",

                "A,D,B,C,E",

                "D,A,B,C,E",

                "E,A,B,C,D",

                "A,E,B,C,D",

                "B,E,A,C,D",

                "E,B,A,C,D",

                "A,B,E,C,D",

                "B,A,E,C,D",

                "B,A,C,E,D",

                "A,B,C,E,D",

                "C,B,A,E,D",

                "B,C,A,E,D",

                "A,C,B,E,D",

                "C,A,B,E,D",

                "C,E,B,A,D",

                "E,C,B,A,D",

                "B,C,E,A,D",

                "C,B,E,A,D",

                "E,B,C,A,D",

                "B,E,C,A,D",

                "A,E,C,B,D",

                "E,A,C,B,D",

                "C,A,E,B,D",

                "A,C,E,B,D",

                "E,C,A,B,D",

                "C,E,A,B,D",

                "D,E,A,B,C",

                "E,D,A,B,C",

                "A,D,E,B,C",

                "D,A,E,B,C",

                "E,A,D,B,C",

                "A,E,D,B,C",

                "A,E,B,D,C",

                "E,A,B,D,C",

                "B,A,E,D,C",

                "A,B,E,D,C",

                "E,B,A,D,C",

                "B,E,A,D,C",

                "B,D,A,E,C",

                "D,B,A,E,C",

                "A,B,D,E,C",

                "B,A,D,E,C",

                "D,A,B,E,C",

                "A,D,B,E,C",

                "E,D,B,A,C",

                "D,E,B,A,C",

                "B,E,D,A,C",

                "E,B,D,A,C",

                "D,B,E,A,C",

                "B,D,E,A,C",

                "C,D,E,A,B",

                "D,C,E,A,B",

                "E,C,D,A,B",

                "C,E,D,A,B",

                "D,E,C,A,B",

                "E,D,C,A,B",

                "E,D,A,C,B",

                "D,E,A,C,B",

                "A,E,D,C,B",

                "E,A,D,C,B",

                "D,A,E,C,B",

                "A,D,E,C,B",

                "A,C,E,D,B",

                "C,A,E,D,B",

                "E,A,C,D,B",

                "A,E,C,D,B",

                "C,E,A,D,B",

                "E,C,A,D,B",

                "D,C,A,E,B",

                "C,D,A,E,B",

                "A,D,C,E,B",

                "D,A,C,E,B",

                "C,A,D,E,B",

                "A,C,D,E,B",

                "B,C,D,E,A",

                "C,B,D,E,A",

                "D,B,C,E,A",

                "B,D,C,E,A",

                "C,D,B,E,A",

                "D,C,B,E,A",

                "D,C,E,B,A",

                "C,D,E,B,A",

                "E,D,C,B,A",

                "D,E,C,B,A",

                "C,E,D,B,A",

                "E,C,D,B,A",

                "E,B,D,C,A",

                "B,E,D,C,A",

                "D,E,B,C,A",

                "E,D,B,C,A",

                "B,D,E,C,A",

                "D,B,E,C,A",

                "C,B,E,D,A",

                "B,C,E,D,A",

                "E,C,B,D,A",

                "C,E,B,D,A",

                "B,E,C,D,A",

                "E,B,C,D,A"

            };

            List<string[]> toReturn = new List<string[]>();

            for (int i = 0; i < perms.Length; i++)
            {
                toReturn.Add(perms[i].Split(','));
            }
            return toReturn;
        }

        static List<string> result(float[] nums)
        {
            float aa = nums[0];

            float bb = nums[1];

            float cc = nums[2];

            float dd = nums[3];

            float ee = nums[4];

            float f = nums[5];

            float a = 0;

            float b = 0;

            float c = 0;

            float d = 0;

            float e = 0;

            float combined1;

            float combined2;

            float combined3;

            float combined4 = 0;

            string[] ops = new string[4];

            string[] numsToSolve = new string[5];

            List<string[]> perms = getPerms();
            
            List<string> solutions = new List<string>();

            for (int z = 0; z < perms.Count; z++)
            {
                if (perms[z][0] == "A")
                {
                    a = aa;
                }
                else if (perms[z][0] == "B")
                {
                    a = bb;
                }
                else if (perms[z][0] == "C")
                {
                    a = cc;
                }
                else if (perms[z][0] == "D")
                {
                    a = dd;
                }
                else if (perms[z][0] == "E")
                {
                    a = ee;
                }
                //-----
                if (perms[z][1] == "A")
                {
                    b = aa;
                }
                else if (perms[z][1] == "B")
                {
                    b = bb;
                }
                else if (perms[z][1] == "C")
                {
                    b = cc;
                }
                else if (perms[z][1] == "D")
                {
                    b = dd;
                }
                else if (perms[z][1] == "E")
                {
                    b = ee;
                }
                //-----
                if (perms[z][2] == "A")
                {
                    c = aa;
                }
                else if (perms[z][2] == "B")
                {
                    c = bb;
                }
                else if (perms[z][2] == "C")
                {
                    c = cc;
                }
                else if (perms[z][2] == "D")
                {
                    c = dd;
                }
                else if (perms[z][2] == "E")
                {
                    c = ee;
                }
                //-----
                if (perms[z][3] == "A")
                {
                    d = aa;
                }
                else if (perms[z][3] == "B")
                {
                    d = bb;
                }
                else if (perms[z][3] == "C")
                {
                    d = cc;
                }
                else if (perms[z][3] == "D")
                {
                    d = dd;
                }
                else if (perms[z][3] == "E")
                {
                    d = ee;
                }
                //-----
                if (perms[z][4] == "A")
                {
                    e = aa;
                }
                else if (perms[z][4] == "B")
                {
                    e = bb;
                }
                else if (perms[z][4] == "C")
                {
                    e = cc;
                }
                else if (perms[z][4] == "D")
                {
                    e = dd;
                }
                else if (perms[z][4] == "E")
                {
                    e = ee;
                }
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        for (int k = 0; k < 4; k++)
                        {
                            for (int l = 0; l < 4; l++)
                            {
                                if (i == 0)
                                {
                                    ops[0] = "+";
                                    combined1 = a + b;
                                }
                                else if (i == 1)
                                {
                                    ops[0] = "-";
                                    combined1 = a - b;
                                }
                                else if (i == 2)
                                {
                                    ops[0] = "*";
                                    combined1 = a * b;
                                }
                                else
                                {
                                    ops[0] = "/";
                                    combined1 = a / b;
                                }
                                numsToSolve[0] = a.ToString();
                                if (j == 0)
                                {
                                    ops[1] = "+";
                                    combined2 = combined1 + c;
                                }
                                else if (j == 1)
                                {
                                    ops[1] = "-";
                                    combined2 = combined1 - c;
                                }
                                else if (j == 2)
                                {
                                    ops[1] = "*";
                                    combined2 = combined1 * c;
                                }
                                else
                                {
                                    ops[1] = "/";
                                    combined2 = combined1 / c;
                                }
                                numsToSolve[1] = b.ToString();
                                if (k == 0)
                                {
                                    ops[2] = "+";
                                    combined3 = combined2 + d;
                                }
                                else if (k == 1)
                                {
                                    ops[2] = "-";
                                    combined3 = combined2 - d;
                                }
                                else if (k == 2)
                                {
                                    ops[2] = "*";
                                    combined3 = combined2 * d;
                                }
                                else
                                {
                                    ops[2] = "/";
                                    combined3 = combined2 / d;
                                }
                                numsToSolve[2] = c.ToString();
                                if (l == 0)
                                {
                                    ops[3] = "+";
                                    combined4 = combined3 + e;
                                }
                                else if (l == 1)
                                {
                                    ops[3] = "-";
                                    combined4 = combined3 - e;
                                }
                                else if (l == 2)
                                {
                                    ops[3] = "*";
                                    combined4 = combined3 * e;
                                }
                                else
                                {
                                    ops[3] = "/";
                                    combined4 = combined3 / e;
                                }
                                numsToSolve[3] = d.ToString();
                                numsToSolve[4] = e.ToString();
                                if (combined4 == f)
                                {
                                    solutions.Add("(((" + numsToSolve[0] + ops[0] + numsToSolve[1] + ")" + ops[1] + numsToSolve[2] + ")" + ops[2] + numsToSolve[3] + ")" + ops[3] + numsToSolve[4] + " = " + f);
                                }
                            }
                        }
                    }
                }
            }
            if (solutions.Count < 1)
            {
                solutions.Add("No Solutions Found");
            }
            return solutions.Distinct().ToList();
        }
        public static string[] Solver(float[] nums)
        {
            List<string> results = result(nums);
            return results.ToArray();
        }
    }
}
