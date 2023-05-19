using AreaCalculator;
using System.Linq;
using System.Threading.Tasks.Sources;


var values = InputParams();

Figure fgr = new Circle(3);
switch (values.Count)
{
    case 1: 
        fgr = new Circle(values.First()); 
        break;
    case 3:
        fgr = new Triangle(values[0], values[1], values[2]);
        break;
    default: 
        Console.WriteLine("Нет фигуры, задаваемой таким количеством параметров"); 
        break;
}

double area = fgr.CalculateArea();
Console.WriteLine(area);
Console.ReadLine();


List<double> InputParams()
{
    Console.WriteLine("Введите входные параметры, отделяя их через Enter:");
    string data = "0";
    List<double> values = new List<double>();
    while (data != "")
    {
        data = Console.ReadLine();
        if (data != "")
        {
            try
            {
                values.Add(Convert.ToDouble(data));
            }
            catch
            {
                throw new Exception("Введен недопустимый символ");
            }
        }
    }
    return values;
}