using System;
using System.Collections.Generic;
using System.Text;

namespace Codejam
{
    class RGB
    {
        int GetLeast(string[] picture)
        {
            //char[][] rgb = new char[picture.Length][];
            int horizontal = 0, vertical = 0, b = 0, g = 0, r = 0, flag = 0;
            for (int i = 0; i < picture.Length; i++)
            {

                flag = 0;
                for (int j = 0; j < picture[i].Length; j++)
                {
                    if (picture[i][j] == 'B')

                    {

                       // b++;

                        flag = 0;
                        if (i != 0)
                        {
                            for (int k = i - 1; k >= 0; k--)
                            {
                                if (picture[k][j] == 'B')

                                {
                                    b++;
                                    flag++;
                                    break;
                                }
                            }
                            for (int k = i + 1; k < picture.Length; k++)
                            {
                                if (picture[k][j] == 'B')
                                {
                                    b++;
                                    flag++;
                                    break;
                                }
                            }
                            if (flag != 0)
                            {
                                vertical++;
                            }

                        }
                        else
                        {

                            for (int k = i + 1; k < picture.Length; k++)
                            {
                                if (picture[k][j] == 'B')
                                {
                                    b++;
                                    flag++;
                                    break;
                                }
                            }
                            if (flag != 0)
                            {
                                vertical++;
                            }
                        }
                    }
                    else if (picture[i][j] == 'R')
                    {
                        flag = 0;
                          //  r++;
                        
                        for (int k = j - 1; k >= 0; k--)
                        {

                            if (picture[i][k] == 'R')
                            {
                                r++;
                                flag++;
                                break;
                            }
                        }
                        for (int k = j + 1; k < picture[i].Length; k++)
                        {
                            if (picture[i][k] == 'R')
                            {
                                r++;
                                flag++;
                                break;
                            }
                        }
                        if (flag != 0)
                        {
                            horizontal++;
                        }
                    }
                    else if (picture[i][j] == 'G')
                    {
                        int flagb = 0;
                        g++;
                        for (int k = i - 1; k >= 0; k--)
                        {
                            if (picture[k][j] == 'B')

                            {

                                flagb++;
                                break;
                            }
                        }
                        for (int k = i + 1; k < picture.Length; k++)
                        {
                            if (picture[k][j] == 'B')
                            {
                                flagb++;
                                break;
                            }
                        }
                        if (flagb > 0)
                        {
                                //r++;
                            

                            for (int k = j - 1; k >= 0; k--)
                            {

                                if (picture[i][k] == 'R')
                                {
                                    r++;
                                    flag++;
                                    break;
                                }
                            }
                            for (int k = j + 1; k < picture[i].Length; k++)
                            {
                                if (picture[i][k] == 'R')
                                {
                                    r++;
                                    flag++;
                                    break;
                                }
                            }
                            if (flag != 0)
                            {
                                horizontal++;
                            }
                        }
                        else
                        {
                            for (int k = i - 1; k >= 0; k--)
                            {
                                if (picture[k][j] == 'B')

                                {
                                    b++;
                                    flag++;
                                    break;
                                }
                            }
                            for (int k = i + 1; k < picture.Length; k++)
                            {
                                if (picture[k][j] == 'B')
                                {
                                    b++;
                                    flag++;
                                    break;
                                }
                            }
                            if (flag != 0)
                            {
                                vertical++;
                            }
                        }

                    }

                }
            }
            int min = 0;
            if (vertical != 0)
            {
                b = b / vertical;
            }
            if (horizontal != 0)
            {
                r = r / horizontal;

            }
           
                min = b + r;
            return min;
        }
        
        #region Testing code Do not change
        public static void Main(String[] args)
        {
            String input = Console.ReadLine();
            RGB rgbSolver = new RGB();
            do
            {
                string[] picture = input.Split(',');
                Console.WriteLine(rgbSolver.GetLeast(picture));
                input = Console.ReadLine();
            } while (input != "-1");
        }
        #endregion
    }
}

