namespace kursova;
class Program
{
    static void Main(string[] args)
    {
        double biggestCylinder = 0;

        Cylinder[] cylinders = {
            new Cylinder(),
            new Cylinder(3,2),
            new Cylinder(1.5, 4),
            new Cylinder(3.3, 2),
            new Cylinder(1.2, 2),
            new Cylinder(1.9, 4.2),
            new Cylinder(0.4, 1),
            new Cylinder(5.1, 2),
            new Cylinder(2.44, 3),
            new Cylinder(2.1, 1.55),
        };

        foreach (var item in cylinders)
        {
            double cylinderVolume = Cylinder.getVolume(item);

            if(cylinderVolume > biggestCylinder){
                biggestCylinder = cylinderVolume;
            }
        }
        Console.WriteLine("The biggest Cylinder has a volume of {0}", biggestCylinder );

        Cylinder randomCylinder = new Cylinder(2, 1.5);
        randomCylinder.printVolume();
    }

    interface ThreeDimensionFigure{
        void printVolume();
    }

    class Cylinder : ThreeDimensionFigure {
        double radius, height;

        public Cylinder(){ // Инициализираме полетата със стойност 1 за да сме сигурни, че ще получим фигура.
            radius = 1;
            height = 1;
        }
        public Cylinder(double newRadius, double newHeight){
            radius = newRadius;
            height = newHeight;
        }

        public double Radius{
            set {radius = value;}
            get {return radius;}
        }
        public double Height{
            set {height = value;}
            get {return height;}
        }

        public void printVolume(){
            double volume = radius * 2 * Math.PI * height;
            Console.WriteLine("The volume of the cylinder is {0}", Math.Round(volume, 3));
        }

        public static double getVolume(Cylinder a){
            double volume = a.radius * 2 * Math.PI * a.height;
            return Math.Round(volume, 3);
        }
    }
}
