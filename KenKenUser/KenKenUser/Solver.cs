using System.Windows.Forms;

namespace KenKenUser
{
    class Solver
    {
        public static string horiz = "", vertic = "", errors = "";

        public static void GetMiss(TextBox[] tb, string[] problem)
        {
            horiz = ""; vertic = ""; errors = "";
            string[] line;
            for (int i = 1; i < problem.Length; i++)
            {
                line = problem[i].Split(' ');// [0] - " +-*/ ", [1] - " result ", [2:4] - " coordinates "
                ///// SOLVER //////
                int chk = 0, max = 0, ind_max = -1;
                // problems //
                if (line[0].ToString() == "+") // summa
                    for (int p = 2; p < line.Length; p++)
                        chk += int.Parse(tb[int.Parse(line[p])].Text);
                else if (line[0].ToString() == "*")
                {
                    chk = 1;
                    for (int p = 2; p < line.Length; p++)
                        chk *= int.Parse(tb[int.Parse(line[p])].Text);
                }
                else
                {
                    for (int p = 2; p < line.Length; p++)// find max
                        if (int.Parse(tb[int.Parse(line[p])].Text) > max)
                        {
                            ind_max = p;
                            max = int.Parse(tb[int.Parse(line[p])].Text);
                        }
                    chk = max;

                    if (line[0] == "-")
                    {// 
                        for (int p = 2; p < line.Length; p++)
                            if (p != ind_max)
                                chk -= int.Parse(tb[int.Parse(line[p])].Text);
                    }
                    else
                    {
                        for (int p = 2; p < line.Length; p++)
                            if (p != ind_max)
                                chk /= int.Parse(tb[int.Parse(line[p])].Text);
                    }
                }

                // ERRORs //
                if (chk != int.Parse(line[1]))
                    for (int p = 2; p < line.Length; p++)
                        errors += " " + line[p];
            }
            int chek = 0;

            for (int p = 0; p < 16; p += 4)
            {
                chek = 0;
                for (int i = p; i < p + 4; i++)
                    chek += int.Parse(tb[i].Text);

                if (chek != 10)
                    vertic += " " + p;
            }

            for (int p = 0; p < 4; p++)
            {
                chek = 0;
                for (int i = p; i <= p + 12; i += 4)
                    chek += int.Parse(tb[i].Text);

                if (chek != 10)
                    horiz += " " + p;
            }

            if (errors.Length != 0)
                errors = errors.Substring(1);
            if (vertic.Length != 0)
                vertic = vertic.Substring(1);
            if (horiz.Length != 0)
                horiz = horiz.Substring(1);
        }
    }
}
