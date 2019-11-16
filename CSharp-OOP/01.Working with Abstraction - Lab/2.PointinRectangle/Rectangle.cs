namespace _2.PointinRectangle
{
    public class Rectangle
    {
        public Rectangle(Point topLeft, Point bottomRight)
        {
            TopLeft = topLeft;
            BottomRight = bottomRight;
        }
        public Point TopLeft { get; private set; }
        public Point BottomRight { get; private set; }

        public bool Contains(Point point)
        {
            bool isInHorizontal =
                point.X >= TopLeft.X 
                && point.X <= BottomRight.X;

            bool isInVertical =
                point.Y >= TopLeft.Y &&
                point.Y <= BottomRight.Y;

            bool isInRectangle = isInHorizontal 
                && isInVertical;

            return isInRectangle;
        }
    }
}