using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4.csh
{
    class ParallelSearchThreadParam // парамаетры которые передаются в поток для параллельного поиска
    {
        public List<string> tempList { get; set; } // массив для поиска
        public string wordPattern { get; set; } // слово для поиска
        public int maxDist { get; set; } // максимальное расстояние для нечеткого поиска
        public int ThreadNum { get; set; } // номер потока
    }
}
