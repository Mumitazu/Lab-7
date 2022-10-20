namespace Lab_7
{
                                //Mumtaz Mohamud[NET22]

    //Parent class + method that can be overriden.
    class Teckning
    {
        public virtual double Area() => Area();
    }
    //Child class 1
    class Rectangle : Teckning
    {
        //Properties.
        public int _Length1 { get; set; }
        public int _Width1 { get; set; }
        //ctor the defines the properties.
        public Rectangle()
        {
            _Length1 = 4;
            _Width1 = 6;
        }
        //Method that override parent method.
        public override double Area()
        {
            double Area = _Length1 * _Width1;
            return Area;
           
        }
    }
    //Child class 2
    class Square : Teckning
    {
        //Properties.
        public int _Lenght2 { get; set; }
        //ctor the defines the properties.
        public Square()
        {
            _Lenght2 = 5;
        }
        //Method that override parent method.
        public override double Area()
        {
            double Area = _Lenght2 * _Lenght2;
            return Area;
        }
    }
    //Child class 3
    class Circle : Teckning
    {
        //Properties.
        public double _Radius { get; set; }
        public double _pi { get; set; }
        //ctor the defines the properties.
        public Circle()
        {
            _Radius = 2;
            _pi = 3.141f;
        }
        //Method that override parent method.
        public override double Area()
        {
            double Area = _Radius * _Radius * _pi;
            return Area;
        }
    }
}
