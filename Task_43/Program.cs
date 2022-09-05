double x, y;
Console.WriteLine("Введите значения значения b1, k1, b2 и k2 через пробел: ");
string[] a = Console.ReadLine().Split(new Char[] { ' ' });
double b1 = double.Parse(a[0]);
double k1 = double.Parse(a[1]);
double b2 = double.Parse(a[2]);
double k2 = double.Parse(a[3]);
Console.WriteLine(Intersection());

string Intersection()
{
    string result = string.Empty;
    if (k1 == k2 && b1 == b2)
    {
        result = "Прямые совпадают";
    }
    else if(k1 == k2)
    {
        result = "Прямые параллельны";
    }
    else
    {
        x = (b1-b2)/(k2-k1);
        y = (k2 * b1 - k1 * b2) / (k2 - k1);
        result = $"точка пересечения : x = {x}, y = {y}";
    }    
    return result;
}
