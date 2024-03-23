﻿namespace OverloadSample;

public class Point
{
    private double x;
    private double y;

    public Point() : this(0, 0)
    {
    }

    public Point(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    public override string ToString()
    {
        return "(" + this.x + "," + this.y + ")";
    }
}
