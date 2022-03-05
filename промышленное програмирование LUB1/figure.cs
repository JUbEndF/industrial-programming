using System.Xml.Serialization;
namespace промышленное_програмирование_LUB1.model
{
    [XmlInclude(typeof(Circle))]
    [XmlInclude(typeof(Rectangle))]
    [XmlInclude(typeof(Triangle))]
    public abstract class Figure
    {
        public abstract Rectangle framing_rectangle();
        public abstract double perimeter();
        public abstract double square();
        public abstract override string ToString();
        public abstract override bool Equals(object obj);
        public abstract override int GetHashCode();
    }
}
