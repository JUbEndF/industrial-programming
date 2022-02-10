using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using промышленное_програмирование_LUB1.model;

namespace промышленное_програмирование_LUB1
{
    public class Menu
    {
        private List<Figure> Figures; 

        public void Add(int index, Figure obj)
        {
            Figures.Insert(index, obj);
        }

        public void Remuve(int index)
        {
            Figures.RemoveAt(index);
        }

        public void Remuve()
        {
            Figures.Clear();
        }

        public void Print()
        {
            for (int i = 0; i < Figures.Count && i < 11; i++)
            {
                Console.WriteLine($"{i + 1}) {Figures[i]}");
            }
            if(Figures.Count >= 11)
                Console.WriteLine(". . .");
        }
    }
}
