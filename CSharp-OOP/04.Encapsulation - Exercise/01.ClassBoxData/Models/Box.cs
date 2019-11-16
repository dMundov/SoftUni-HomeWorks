namespace ClassBoxData.Models
{
    using System;
    using System.Text;

    using ClassBoxData.Exceptions;
    public class Box
    {
        private double length;
        private double width;
        private double height;
        

        public Box(double length, double width, double height)
        {

            Length = length;
            Width = width;
            Height = height;
        }

        public double Length
        {
            get
            {
                return length;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(ExceptionsMsgs.LenghtZeroOrNegativeException);
                }
                length = value;
            }

        }

        public double Width
        {
            get
            {
                return width;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(ExceptionsMsgs.WidthZeroOrNegativeException);
                }
                width = value;
            }
        }
        public double Height
        {
            get
            {
                return height;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(ExceptionsMsgs.HeightZeroOrNegativeException);
                }
                height = value;
            }
        }

        public double LateralSurfaceArea()
        {
            double lateralSurfaceArea = (2 * Length * Height) + (2 * Width * Height);

            return lateralSurfaceArea;
        }
        public double SurfaceArea()
        {
            double surfaceArea = (2 * Length * Width)+
                (2*Length*Height)+(2*Width*Height);

            return surfaceArea;
        }
        public double Volume()
        {
            double volume = Length * Width * Height;

            return volume;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result
                .AppendLine($"Surface Area - {SurfaceArea():F2}")
                .AppendLine($"Lateral Surface Area - {LateralSurfaceArea():F2}")
                .AppendLine($"Volume - {Volume():F2}");

            return result.ToString().TrimEnd();
        }
    }
}
