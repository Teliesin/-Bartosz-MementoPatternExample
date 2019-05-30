using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPatternExample
{
    public class Gameboard
    {
        public char[][] Fields { get; set; }

        public Gameboard()
        {
            GenerateEmptyGameBoard3x3();
        }

        public Save CreateMemento()
        {
            Save save = new Save();

            save.Fields = Fields.Select(field => new char[] { field[0], field[1], field[2] }).ToArray();

            return save;
        }

        private void GenerateEmptyGameBoard3x3()
        {
            Fields = new char[3][];

            for (int i = 0; i < 3; i++)
            {
                Fields[i] = new char[3];
                for (int j = 0; j < 3; j++)
                {
                    Fields[i][j] = ' ';
                }
            }
        }
    }
}
