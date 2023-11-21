using CSsample;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triangle3D
{
    private Vector3[] points = new Vector3[3];

    public Triangle3D(Vector3[] points)
    {
        this.points = points;
    }
    public Triangle3D(Vector3 p0, Vector3 p1, Vector3 p2)
    {
        this.points = new Vector3[3];
        this.points[0] = p0;
        this.points[1] = p1;
        this.points[2] = p2;
    }
    public static float GetSurface(Vector3 p0, Vector3 p1, Vector3 p2)
    {
        var l0 = Vector3.Distance(p0,p1);
        var l1 = Vector3.Distance(p1,p2);
        var l2 = Vector3.Distance(p2,p0);
        return Triangle.GetSurface(l0, l1, l2);
    }
    public float GetSurface()
    {
        return GetSurface(points[0], points[1], points[2]);
    }
}
