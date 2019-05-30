using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPatternExample
{
    public class SaveFolder : ICaretaker
    {
        public List<Save> SaveList { get; set; }

        public SaveFolder()
        {
            SaveList = new List<Save>();
        }

        public Save GetLastSave()
        {
            return SaveList.Last();
        }
    }
}