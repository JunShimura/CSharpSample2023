using System.Linq;
using System;

namespace CSsample {
class Triangle
{
    private float side1;
    private float side2;
    private float side3;
    public Triangle(float side1, float side2, float side3)
    {
        float[] t = new float[3];
        t[0] = this.side1 = side1;
        t[1] = this.side2 = side2;
        t[2] = this.side3 = side3;
        float[] t2 = t.OrderBy(x => x).ToArray<float>();
        if (t2[2] >= (t2[0] + t2[1]))
        {
            throw new ArgumentException("Invalid Parameter");
        }
    }
    public Triangle(float side1, float side2)
    {
        this.side1 = side1;
        this.side2 = side2;
        this.side3 = (float)(Math.Sqrt((side1 * side1) + (side2 * side2)));
    }


    //–ÊÏ‚ğæ“¾
    static public float GetSurface(float side1, float side2, float side3)
    {
        double s = (double)((side1 + side2 + side3) / 2);
        double t = s * (s - side1) * (s - side2) * (s - side3);
        t = Math.Sqrt(t);
        return (float)t;
    }
    public float GetSurface()
    {
        return GetSurface(this.side1, this.side2, this.side3);
    }
    //üˆÍ‚Ì’·‚³‚ğæ“¾
    static public float GetPerimeter(float side1, float side2, float side3)
    {
        return side1 + side2 + side3;
    }
    public float GetPerimeter()
    {
        return GetPerimeter(side1, side2, side3);
    }
}

}

