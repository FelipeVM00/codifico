// See https://aka.ms/new-console-template for more information
using AreaCalculator.Models;

bool showMenu = true;

while (showMenu)
{
    showMenu = MainMenu();
    Console.ReadLine();
}


static Boolean MainMenu()
{
    Console.Clear();
    Console.WriteLine("------ CALCULADORA DE AREA ------");
    char option = ChooseShape().KeyChar;
    try
    {
        switch (option)
        {
            case '1':
                CircleArea();
                return true;
            case '2':
                RectangleArea();
                return true;
            case '3':
                return false;
            default:
                return true;
        }
    }catch(Exception e)
    {
        Console.WriteLine("Ocurrio un error al intentar calcular el area.\n - Detalles: " + e.Message);
        return true;
    }
    
}


static ConsoleKeyInfo ChooseShape()
{
    Console.WriteLine("Elige la figura para calcular su area");
    Console.WriteLine("1) Círculo");
    Console.WriteLine("2) Rectángulo");
    Console.WriteLine("3) Salir");
    Console.WriteLine("Presiona el número de la opción");
    return Console.ReadKey();
}

static void RectangleArea()
{
    string widthInput = "";
    string heightInput = "";
    Console.Clear();
    Console.WriteLine("Ingresa la base del rectángulo: ");
    widthInput = Console.ReadLine();
    double cleanWidth = 0;
    while (!double.TryParse(widthInput, out cleanWidth))
    {
        Console.WriteLine("Valor no valido. Por favor ingresa la base nuevamente: ");
        widthInput = Console.ReadLine();
    }
    Console.WriteLine("Ingresa la altura del rectángulo: ");
    heightInput = Console.ReadLine();
    double cleanHeight = 0;
    while (!double.TryParse(heightInput, out cleanHeight))
    {
        Console.WriteLine("Valor no valido. Por favor ingresa la altura nuevamente: ");
        heightInput = Console.ReadLine();
    }
    Rectangle rectangle = new Rectangle(cleanWidth, cleanHeight);
    rectangle.PrintArea();
}

static void CircleArea()
{
    string radiusInput = "";
    Console.Clear();
    Console.WriteLine("Ingresa el radio del círculo: ");
    radiusInput = Console.ReadLine();
    double cleanRadius = 0;
    while (!double.TryParse(radiusInput, out cleanRadius))
    {
        Console.WriteLine("Valor no valido. Por favor ingresa el radio nuevamente: ");
        radiusInput = Console.ReadLine();
    }
    Circle circle = new Circle(cleanRadius);
    circle.PrintArea();
}