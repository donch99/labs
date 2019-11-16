using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3 {
    class SparseMatrix<T> {
        int countX,countY;
        Dictionary<string, T> elements = new Dictionary<string, T>();

        public SparseMatrix(int x, int y) {
            this.countX = x;
            this.countY = y;
        }

        public T this[int x,int y] {
            get {
                if (!checkEmpty(x, y) && countX > x && countY > y)
                    return elements[KeyGen(x, y)];
                else return default(T);
            }
            set {
                if (checkEmpty(x, y) && countX > x && countY > y)
                    elements.Add(KeyGen(x, y), value);
                else throw new ArgumentOutOfRangeException(
                    "Границы матрицы x= " + countX +" y= " + countY, 
                    "Выходит за границы матрицы!");
            }
        }

        private bool checkEmpty(int x, int y) {
            bool b = true;
            foreach (string s in this.elements.Keys) {
                if (s == KeyGen(x, y)) {
                    b = false;
                    break;
                }
            }
            return b;
        }

        private string KeyGen(int x,int y) {
            return x.ToString() + "-" + y.ToString();
        }

        public override string ToString() {
            StringBuilder str = new StringBuilder();

            for(int i = 0; i < countX; i++) {
                for (int j = 0; j < countY; j++) {
                    if (!checkEmpty(i, j))
                        str.Append(" " + KeyGen(i, j) + " ");
                    else str.Append(" ... ");
                }
                str.Append("\n");
            }

            return str.ToString();
        }
    }
}
