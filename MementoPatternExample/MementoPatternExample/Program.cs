using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Gameboard gameboard = new Gameboard();

            gameboard.Fields[1][1] = 'X';
            gameboard.Fields[0][1] = 'O';
            gameboard.Fields[1][0] = 'X';

            SaveFolder saveFolder = new SaveFolder();

            saveFolder.SaveList.Add(gameboard.CreateMemento());

            gameboard.Fields[0][2] = 'O';
            gameboard.Fields[1][2] = 'X';


            gameboard.Fields = saveFolder.GetLastSave().Fields;
        }
    }
}