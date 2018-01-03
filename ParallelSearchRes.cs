using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4.csh
{
    class ParallelSearchRes // для хранения информации о найденных словах
    {
        public string word { get; set; } // найденное слово
        public int dist { get; set; } // расстояние Дамерау-Левенштейна
        public int ThreadNum { get; set; } // номер потока
    }
}
