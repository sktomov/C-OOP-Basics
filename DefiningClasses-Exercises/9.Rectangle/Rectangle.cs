
public class Rectangle
{
	public string ID { get; set; }

	public double Width { get; set; }

	public double Height { get; set; }

	public double TopLeftX { get; set; }

	public double TopLeftY { get; set; }

	public bool Intersect(Rectangle rectangle)
	{
		return rectangle.TopLeftX + rectangle.Width >= this.TopLeftX &&
		       rectangle.TopLeftX <= this.TopLeftX + this.Width &&
		       rectangle.TopLeftY >= this.TopLeftY - this.Height &&
		       rectangle.TopLeftY - rectangle.Height <= this.TopLeftY;
	}
}

