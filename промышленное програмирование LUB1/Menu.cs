using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using промышленное_програмирование_LUB1.model;

namespace промышленное_програмирование_LUB1
{
    public class Menu<T> where T: Figure
    {
        private List<T> Figures = new List<T>();

        public void Add(int index, T obj)
        {
            if (index >= 0 && index < Figures.Count)
                Figures.Insert(index, obj);
        }

        public void Add(T obj)
        {
            Figures.Add(obj);
        }

        public void Remuve(int index)
        {
            if(index >= 0 && index < Figures.Count)
                Figures.RemoveAt(index);
        }

        public void Remuve()
        {
            Figures.Clear();
        }

        public void Comparison(int index_1, int index_2)
        {
            if (index_1 < 0 || index_2 < 0 || index_1 > Figures.Count || index_2 > Figures.Count)
                Console.WriteLine("Wrong index");
            Console.WriteLine($"{Figures[index_1]} == {Figures[index_2]}? {Figures[index_1].Equals(Figures[index_2])}");
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
