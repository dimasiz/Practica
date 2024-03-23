namespace TriangleAndSqere
{
    public class Triangle
    {
        private int sideA;
        private int sideB;
        private int sideC;

        public void SetSides(int a, int b, int c)
        {
            sideA = a;
            sideB = b;
            sideC = c;
        }

        public bool IsTriangleValid()
        {
            return sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA;
        }

        public int GetPerimeter()
        {
            return sideA + sideB + sideC;
        }

        public double GetArea()
        {
            double semiPerimeter = GetPerimeter() / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - sideA) * (semiPerimeter - sideB) * (semiPerimeter - sideC));
        }

        public string GetTriangleType()
        {
            if (sideA == sideB && sideB == sideC)
            {
                return "Равносторонний";
            }
            else if (sideA == sideB || sideB == sideC || sideA == sideC)
            {
                return "Равнобедренный";
            }
            else
            {
                return "Разносторонний";
            }
        }
    }

    public class Rectangle
    {
        private int length;
        private int width;

        public void SetDimensions(int l, int w)
        {
            length = l;
            width = w;
        }

        public int GetPerimeter()
        {
            return 2 * (length + width);
        }

        public int GetArea()
        {
            return length * width;
        }
    }
}
