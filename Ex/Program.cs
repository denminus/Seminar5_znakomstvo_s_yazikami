// Условие существования треугольника
// АС<AB+BC , BC< AB+AC, AB< BC+AC

Console.WriteLine("Введите длинну стороны АВ");
int AB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длинну стороны ВС");
int BC = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длинну стороны CA");
int CA = Convert.ToInt32(Console.ReadLine());

if ((CA<AB+BC) && (BC< AB+CA) && (AB< BC+CA))
{
    Console.WriteLine("Это треугольник"); }

else {
    Console.WriteLine("Это не треугольник");
        }
