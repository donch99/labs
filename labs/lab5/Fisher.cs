using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    public class Fisher
    {
        public static int Levinstain(string source, string destination) {
            int l1 = source.Length;
            int l2 = destination.Length;

            if (source == destination) return 0;
            if (l1 == 0 && l2 != 0) return l2;
            if (l2 == 0 && l1 != 0) return l1;

            string s1 = source.ToUpper();
            string s2 = destination.ToUpper();

            l1 += 1;
            l2 += 1;

            int[,] matrix = new int[l1, l2];

            for (int j = 0; j < l2; j++) matrix[0, j] = j;
            for (int i = 0; i < l1; i++) matrix[i, 0] = i;
            int d = 0;
            for (int i = 1; i < l1; i++) {
                for (int j = 1; j < l2; j++) {
                    if (s1[i - 1] == s2[j - 1]) d = 0;
                    else d = 1;

                    matrix[i, j] = Math.Min(Math.Min(matrix[i - 1, j] + 1, matrix[i, j - 1] + 1), matrix[i - 1, j - 1] + d);
                }
            }

            return matrix[l1-1,l2-1];
        }

        public static int DemLevinstain(string source, string destination) {
            int l1 = source.Length;
            int l2 = destination.Length;

            if (source == destination) return 0;
            if (l1 == 0 && l2 != 0) return l2;
            if (l2 == 0 && l1 != 0) return l1;

            string s1 = source.ToUpper();
            string s2 = destination.ToUpper();

            l1 += 1;
            l2 += 1;

            int[,] matrix = new int[l1, l2];

            for (int j = 0; j < l2; j++) matrix[0, j] = j;
            for (int i = 0; i < l1; i++) matrix[i, 0] = i;
            int d = 0;
            for (int i = 1; i < l1; i++) {
                for (int j = 1; j < l2; j++) {
                    if (s1[i - 1] == s2[j - 1]) d = 0;
                    else d = 1;

                    matrix[i, j] = Math.Min(Math.Min(matrix[i - 1, j] + 1, matrix[i, j - 1] + 1), matrix[i - 1, j - 1] + d);

                    if(i>1 && j>1 && s1[i - 1] == s2[j - 2] && s1[i - 2] == s2[j - 1]) {
                        matrix[i, j] = Math.Min(matrix[i, j], matrix[i - 2, j - 2] + d);
                    }

                }
            }

            return matrix[l1-1, l2-1];
        }
    }
}
