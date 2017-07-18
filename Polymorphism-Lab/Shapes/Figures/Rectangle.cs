public class Rectangle : Shape
{
    private double width;
    private double height;

    public Rectangle(double width, double height)
    {
        this.Height = height;
        this.Width = width;
    }

    public double Height
    {
        get { return height; }
        set { height = value; }
    }


    public double Width
    {
        get { return width; }
        set { width = value; }
    }

    public override double CalculatePerimeter()
    {
        return 2 * (this.Height + this.Width);
    }

    public override double CalculateArea()
    {
        return this.Width * this.Height;
    }

    public override string Draw()
    {
        return base.Draw() + "Rectangle";
    }
}

