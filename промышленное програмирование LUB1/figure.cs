namespace промышленное_програмирование_LUB1.model
{
    abstract class Figure
    {
        public abstract Rectangle framing_rectangle();
        public abstract double perimeter { get; }
        public abstract double square();
        public abstract override string ToString();
        public abstract override bool Equals(object obj);
        public abstract override int GetHashCode();
    }
}
