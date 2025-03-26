using System;

class Shape
{
    private int? NumOfSide;

    // เปลี่ยน constructor จาก private เป็น protected เพื่อให้สามารถเข้าถึงจาก subclass
    protected Shape()
    {
        System.Console.WriteLine("This is some shape with unknown sides");
    }

    // Constructor ที่รับจำนวน sides
    public Shape(int NumOfSide)
    {
        this.NumOfSide = NumOfSide;
        System.Console.WriteLine($"This is some shape with {NumOfSide} sides");
    }
}

class Circle : Shape
{
    public Circle() : base()  // เรียก constructor ของ Shape ที่ไม่มี parameter
    {
        System.Console.WriteLine("This is a circle");
    }
}

class Rectangle : Shape
{
    public Rectangle() : base(4)  // เรียก constructor ของ Shape ที่มี parameter 4
    {
        System.Console.WriteLine("This is a rectangle");
    }
}

class Triangle : Shape
{
    public Triangle() : base(3)  // เรียก constructor ของ Shape ที่มี parameter 3
    {
        System.Console.WriteLine("This is a triangle");
    }
}

class Program
{
    static void Main()
    {
        var circle = new Circle();        // This is a shape with unknown sides, This is a circle
        var rectangle = new Rectangle();  // This is a shape with 4 sides, This is a rectangle
        var triangle = new Triangle();    // This is a shape with 3 sides, This is a triangle
    }
}