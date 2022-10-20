using System;

namespace Lab_7
{
    class Program
    {
        //Main method.
        static void Main(string[] args)
        {
            //Passes object by refereces between parent-class and child-classes.
            Rectangle rectangle= new Rectangle();
            Console.WriteLine("Arean av rektangeln är: " + rectangle.Area());
            Square square = new Square();
            Console.WriteLine("Arean av fyrkanten är: " + square.Area());
            Circle circle = new Circle();
            Console.WriteLine("Arean av cirkeln är: " + circle.Area());

            Teckning[] teckning = { rectangle, square, circle };

            foreach (Teckning tecknings in teckning) { tecknings.Area(); }

            //Makes the program wait for a keypress.
            Console.ReadKey();
        }
    }
}
