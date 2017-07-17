using System;

namespace CodeJam
{
    class ACGT
    {
       // private static string consoleInput = "1999|ACGTCCCTTCCCTTCAGAGAGGAGAGAGAGTTCATATATATAATATGGCC,ACCCCGCGCGCGCCTCTCTCTCTCTCTCTCTCCCCCACCCACCACACCAC,ACCCCTCTCTCTCTCTCCGAGAGAGAGGAGAGAGAGGAGGAGCGCGCGCG,CGCGCGCGCGCGCGCGCGCGCGGGGGGGAGGGAGGAGGAGGAGGAGGGTG,TGCGCGCGCGCGCGCGCGCCGGAGAGAGAGAGAGAGAGAGAGGAGAGAGG,TCTCTCTCTCTCGGGAGAGAGGAGGAGGAGGAGGAGGAGAGTCTTGTGTG,TGCGCGGGAGGAGGAGGAGGAGGAGGGGGCGGGGCGGCGCGCGCGCGCGG,AAAATATATATATTATATATATTATATGTGTGTTGGCGCGCGCGCGCGGC,TGTTCGCTCTGCTCGCTCGCTCGCTCGCTCGCTCGCTGCTCTCTCTCTCT,AGAGAGAGAGAGAGAGAGAGAGAGAGAGAGATGGAGAGAGAGAGAGGAGA,TGCGCGCGCGCGCGCGGGGGGAGGAGAGGGTTTTTTTTTTTTTTTTTTTT,GGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGCCCCCCCCCCC,GGGGGGGGGGGGGGGGGGGGGGGGGGGGCCCCCCCCCCAAAAAAAAAAAA,TTTTTTTTTTTTTTTTTTTTTTTTTTGGGGGGGGGGGGGGGGAAAAAAAA,GGGTTTTTTTTTTATTATATATATATATATTATATTATATATATATTATT,TGGGGGGGGGCGCGCGCGCGCGCGCGCGCGCGCGCGCGCGCGCGCGCGCG,TGCGCTGCTGCTGCTGCTGCTGCTGCTGCTGGGGGGGGGGGGGGGGGGGG,ACGTCCCTTCCCTTCAGAGAGGAGAGAGAGTTCATATATATAATATGGCC,ACCCCGCGCGCGCCTCTCTCTCTCTCTCTCTCCCCCACCCACCACACCAC,ACCCCTCTCTCTCTCTCCGAGAGAGAGGAGAGAGAGGAGGAGCGCGCGCG,CGCGCGCGCGCGCGCGCGCGCGGGGGGGAGGGAGGAGGAGGAGGAGGGTG,TGCGCGCGCGCGCGCGCGCCGGAGAGAGAGAGAGAGAGAGAGGAGAGAGG,TCTCTCTCTCTCGGGAGAGAGGAGGAGGAGGAGGAGGAGAGTCTTGTGTG,TGCGCGGGAGGAGGAGGAGGAGGAGGGGGCGGGGCGGCGCGCGCGCGCGG,AAAATATATATATTATATATATTATATGTGTGTTGGCGCGCGCGCGCGGC,TGTTCGCTCTGCTCGCTCGCTCGCTCGCTCGCTCGCTGCTCTCTCTCTCT,AGAGAGAGAGAGAGAGAGAGAGAGAGAGAGATGGAGAGAGAGAGAGGAGA,TGCGCGCGCGCGCGCGGGGGGAGGAGAGGGTTTTTTTTTTTTTTTTTTTT,GGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGCCCCCCCCCCC,GGGGGGGGGGGGGGGGGGGGGGGGGGGGCCCCCCCCCCAAAAAAAAAAAA,TTTTTTTTTTTTTTTTTTTTTTTTTTGGGGGGGGGGGGGGGGAAAAAAAA,GGGTTTTTTTTTTATTATATATATATATATTATATTATATATATATTATT,TGGGGGGGGGCGCGCGCGCGCGCGCGCGCGCGCGCGCGCGCGCGCGCGCG,TGCGCTGCTGCTGCTGCTGCTGCTGCTGCTGGGGGGGGGGGGGGGGGGGG,ACGTCCCTTCCCTTCAGAGAGGAGAGAGAGTTCATATATATAATATGGCC,ACCCCGCGCGCGCCTCTCTCTCTCTCTCTCTCCCCCACCCACCACACCAC,ACCCCTCTCTCTCTCTCCGAGAGAGAGGAGAGAGAGGAGGAGCGCGCGCG,CGCGCGCGCGCGCGCGCGCGCGGGGGGGAGGGAGGAGGAGGAGGAGGGTG,TGCGCGCGCGCGCGCGCGCCGGAGAGAGAGAGAGAGAGAGAGGAGAGAGG,TCTCTCTCTCTCGGGAGAGAGGAGGAGGAGGAGGAGGAGAGTCTTGTGTG,TGCGCGGGAGGAGGAGGAGGAGGAGGGGGCGGGGCGGCGCGCGCGCGCGG,AAAATATATATATTATATATATTATATGTGTGTTGGCGCGCGCGCGCGGC,TGTTCGCTCTGCTCGCTCGCTCGCTCGCTCGCTCGCTGCTCTCTCTCTCT,AGAGAGAGAGAGAGAGAGAGAGAGAGAGAGATGGAGAGAGAGAGAGGAGA,TGCGCGCGCGCGCGCGGGGGGAGGAGAGGGTTTTTTTTTTTTTTTTTTTT,GGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGCCCCCCCCCCC,GGGGGGGGGGGGGGGGGGGGGGGGGGGGCCCCCCCCCCAAAAAAAAAAAA,TTTTTTTTTTTTTTTTTTTTTTTTTTGGGGGGGGGGGGGGGGAAAAAAAA,GGGTTTTTTTTTTATTATATATATATATATTATATTATATATATATTATT,TGGGGGGGGGCGCGCGCGCGCGCGCGCGCGCGCGCGCGCGCGCGCGCGCG";

        int MinChanges(int maxPeriod, string[] acgt)
        {
            String s = "";
            for (int i = 0; i < acgt.Length; i++)
            {
                s += acgt[i];
            }
           // Console.WriteLine(s.Length);
            
            int replacement = 0;
           
            int []res = new int[maxPeriod];
            
                for (int i = 1; i <= maxPeriod; i++)
                {
                    replacement = 0;
                    for (int j = 0; j < i; j++)
                    {
                    int[] a = new int[4];
                   
                    int max = 1;
                        for (int k = j; k < s.Length; k += i)
                        {
                            if (s[k] == 'A')
                            {
                                a[0]++;
                            }
                            else if (s[k] == 'C')
                            {
                                a[1]++;
                            }
                            else if (s[k] == 'G')
                            {
                                a[2]++;
                            }
                            else
                            {
                                a[3]++;
                            }
                        }
                    max = a[0];
                        for (int m = 1; m < a.Length; m++)
                        {
                                
                                max = Math.Max(max, a[m]);
                            
                        }
                        int temp= (a[0] + a[1] + a[2] + a[3]) - max;
                    replacement = (replacement + temp);


                    }
                    res[i-1] = replacement;
                }
               
               
            
            int resPeriod = res[0];
            for (int i = 1; i < res.Length; i++)
            {
               
                    resPeriod = Math.Min(resPeriod, res[i]);
                
            }
            return resPeriod;
        }

        #region Testing code Do not change
        public static void Main(String[] args)
        {
            ACGT aCGT = new ACGT();
            String input =Console.ReadLine();
            do
            {
                var inputParts = input.Split('|');
                int maxPeriod = int.Parse(inputParts[0]);
                string[] acgt = inputParts[1].Split(',');
                Console.WriteLine(aCGT.MinChanges(maxPeriod, acgt));
                input = Console.ReadLine();
            } while (input != "-1");
        }
        #endregion
    }
}