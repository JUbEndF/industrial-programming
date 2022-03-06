using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using промышленное_програмирование_LUB1.model;

namespace промышленное_програмирование_LUB1
{
    public interface IMenu
    {
        Point create_point();

        List<Figure> GetAll();

        int get_index(int left, int right);

        public int Count();

        void Add(int index, Figure obj);

        void Remuve_element(int index);

        void Remuve();

        Rectangle get_framing_rectangle(int index);

        void Comparison(int index_1, int index_2);

        void Print_Squere();

        double Squere(int index);

        double perimeter(int index);

        void PrintElement(int index);

        void Print();

        void Serialize();

        void Deserialize();
    }
}
