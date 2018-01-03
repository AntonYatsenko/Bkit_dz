using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace lab4.csh
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static List<ParallelSearchRes> ArrayThreadTask(object paramObj) // выполняется в параллельном потоке для поиска строк
        {
            ParallelSearchThreadParam param = (ParallelSearchThreadParam)paramObj;
            string wordUpper = param.wordPattern.Trim().ToUpper(); // слово для поиска в верхнем регистре
            List<ParallelSearchRes> Result = new List<ParallelSearchRes>(); // результаты поиска в одном потоке
            foreach (string str in param.tempList) // перебор всех слов во временном списке данного потока
            {
                int dist = ab5library.EditDistanse.Distance(str.ToUpper(), wordUpper); // вычисление расстояния Дамерау-Левенштейна
                if (dist <= param.maxDist) // условие добавления слова в результат
                {
                    ParallelSearchRes temp = new ParallelSearchRes() { word = str, dist = dist, ThreadNum = param.ThreadNum };
                    Result.Add(temp);
                }
            }
            return Result;
        }
    }
}
