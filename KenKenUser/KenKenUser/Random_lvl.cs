using System;

namespace KenKenUser
{
    class Random_lvl
    {
        static string[] tabl;// базовая таблица
        static string[] rows;
        static string col;
        static Random rnd = new Random();
        static bool correct = false;
        static public string[] problems;

        static public void GetProblem()
        {
            Generate_table();
            while (true)
            {
                Generate_problem();
                if (correct)
                    break;
            }
            
        }

        static void Generate_problem()
        {
            bool[] tb = new bool[16];
            problems = new string[1] { "" };
            string coll_arthm = "+-*/";// collection arithmetic expression
            int ccell;// count cell
            string arthm;// arithmetic expression
            int[] coor = new int[1];// cell coordinates
            double rez = 0;
            int[] coll_znach, coll_coor;
            int count_cell = 16, start_point = -1, sch = 1, kol_es = 0;
            string item;

            while (count_cell != 0)
                if (!tb[coor[0] = rnd.Next(16)])
                {
                    tb[coor[0]] = true;
                    coll_znach = new int[] { -4, -1, 1, 4 };
                    while (true)
                    {
                        if ((ccell = rnd.Next(2, 5)) <= count_cell)
                            break;
                        else
                        {
                            ccell = count_cell;
                            break;
                        }
                    }

                    Array.Resize(ref coor, ccell);
                    coll_coor = coor;
                    if (ccell != 1)
                        for (int p = 1; p < ccell; p++)
                        {
                            int pogreshnost = 0;
                            while (true)
                            {
                                coll_znach = new int[] { -4, -1, 1, 4 };
                                start_point = coor[rnd.Next(p)];
                                
                                if (pogreshnost == 100)
                                {
                                    Array.Resize(ref coor, p);
                                    ccell = p;
                                    break;
                                }
                                //
                                if (start_point % 4 == 0)
                                {
                                    coll_znach = new int[] { -4, 1, 4 };
                                    if (start_point == 0)
                                        coll_znach = new int[] { 1, 4 };
                                }
                                else if ((start_point + 1) % 4 == 0)
                                {
                                    coll_znach = new int[] { -4, -1, 4 };
                                    if (start_point == 15)
                                        coll_znach = new int[] { -4, -1 };
                                }
                                else if (start_point / 4 == 0)
                                    coll_znach = new int[] { -1, 1, 4 };
                                else if (start_point / 4 == 3)
                                    coll_znach = new int[] { -4, 1 };
                                //
                                pogreshnost++;
                                int ind_znach = rnd.Next(coll_znach.Length);
                                coor[p] = start_point + coll_znach[ind_znach];
                                if (coor[p] > 0 && coor[p] < 16 && tb[coor[p]] == false)
                                {
                                    tb[coor[p]] = true;
                                    break;
                                }
                            }
                        }

                    if (ccell == 1)
                        kol_es++;
                    if (kol_es == 3)
                    {
                        correct = false;
                        return;
                    }
                    count_cell -= ccell;

                    // arithmetic expression
                    if (ccell == 1)
                    {
                        arthm = coll_arthm[0].ToString();
                        rez = int.Parse(tabl[coor[0]]);
                    }
                    else
                        while (true)
                        {
                            rez = 0;
                            arthm = coll_arthm[rnd.Next(4)].ToString();
                            if (arthm == "+")
                            {
                                for (int p = 0; p < ccell; p++)
                                    rez += int.Parse(tabl[coor[p]]);
                                break;
                            }
                            else if (arthm == "*")
                            {
                                rez = 1;
                                for (int p = 0; p < ccell; p++)
                                    rez *= int.Parse(tabl[coor[p]]);
                                break;
                            }
                            else
                            {
                                int max = 0;
                                int ind_mx = -1;
                                for (int p = 0; p < ccell; p++)
                                    if (int.Parse(tabl[coor[p]]) > max)
                                    {
                                        max = int.Parse(tabl[coor[p]]);
                                        ind_mx = p;
                                    }

                                rez = max;
                                if (arthm == "-")
                                {
                                    for (int p = 0; p < ccell; p++)
                                        if (p != ind_mx)
                                            rez -= int.Parse(tabl[coor[p]]);

                                    if (rez > 0)
                                        break;
                                }
                                else
                                {
                                    for (int p = 0; p < ccell; p++)
                                        if (p != ind_mx)
                                            rez /= double.Parse(tabl[coor[p]]);

                                    if (rez % 1 == 0)
                                        break;
                                }
                            }
                        }

                    item = arthm + " " + rez;
                    for (int p = 0; p < ccell; p++)
                        item += " " + coor[p];
                    Array.Resize(ref problems, problems.Length + 1);
                    problems[sch] = item;
                    if (sch > 10)
                    {
                        correct = false;
                        return;
                    }
                    sch++;
                }

            if (sch < 7)
            {
                correct = false;
                return;
            }

            correct = true;
        }

        // Генерация таблицы
        static void Generate_table()
        {
            tabl = new string[] { "1", "2", "3", "4", "4", "3", "2", "1",
                "3", "1", "4", "2", "2", "4", "1", "3" };// базовая таблица;
            int n = rnd.Next(0, 21);
            while (n > 0)
            {
                switch ( rnd.Next(3) )
                {
                    case 0:
                        transposing();
                        break;
                    case 1:
                        swap_rows();
                        break;
                    case 2:
                        swap_columns();
                        break;
                }
                n--;
            }
        }

        static void WriteRows()
        {
            rows = new string[4];
            for (int i = 0; i < tabl.Length; i++)
                rows[i / 4] += tabl[i];
        }

        static void transposing()
        {
            WriteRows();
            for (int i = 0; i < 4; i++)
            {
                int str = i - i / 4 * 4;
                tabl[i] = rows[str][0].ToString();
                tabl[i + 4] = rows[str][1].ToString();
                tabl[i + 8] = rows[str][2].ToString();
                tabl[i + 12] = rows[str][3].ToString();
            }
        }

        static void swap_rows()
        {
            col = "0123";
            int frst = int.Parse(col[rnd.Next(col.Length)].ToString());
            col = col.Replace(frst.ToString(), "");
            int scnd = int.Parse(col[rnd.Next(col.Length)].ToString());
            WriteRows();
            for (int i = 0; i < 4; i++)
            {
                tabl[frst * 4 + i] = rows[scnd][i].ToString();
                tabl[scnd * 4 + i] = rows[frst][i].ToString();
            }
        }

        static void swap_columns()
        {
            col = "0123";
            int frst = int.Parse(col[rnd.Next(col.Length)].ToString());
            col = col.Replace(frst.ToString(), "");
            int scnd = int.Parse(col[rnd.Next(col.Length)].ToString());
            WriteRows();
            for (int i = 0; i < 16; i += 4)
            {
                tabl[frst + i] = rows[i / 4][scnd].ToString();
                tabl[scnd + i] = rows[i / 4][frst].ToString();
            }
        }
        //
    }
}
