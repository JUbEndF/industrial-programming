namespace промышленное_програмирование_LUB1.model
{
    abstract class Figure
    {
        public abstract Rectangle framing_rectangle();
        public abstract double perimeter { get; }
        public abstract double square();
    }
}
