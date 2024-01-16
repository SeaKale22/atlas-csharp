using System;

/// <summary> represents a shape </summary>
class Shape
{
    /// <summary> area method not implemented </summary>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}

/// <summary> represents a rectangle </summary>
class Rectangle : Shape
{
    private int width;
    private int height;

    /// <summary> width property </summary>
    public int Width
    {
        get {return this.width;}
        set 
        {
            if (value < 0)
            {
                throw new ArgumentException("Width must be greater than or equal to 0");
            }
            else
            {
                this.width = value;
            }
        }
    }

    /// <summary> height propety </summary>
    public int Height
    {
        get {return this.height;}
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Height must be greater than or equal to 0");
            }
            else
            {
                this.height = value;
            }
        }
    }
}