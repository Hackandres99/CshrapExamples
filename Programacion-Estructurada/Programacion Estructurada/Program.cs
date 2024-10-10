const int totalGrams = 600;
const int bigPillGrams = 40;
const int smallPillGrams = 30;

List<int> ypoints = new List<int>();
List<int> xpoints = new List<int>();
List<int> benefits = new List<int>();

for(int x = 0;x <= 20; x++)
{
    for(int y =0; y <=20; y++)
    {
        if(x>= 3 && 2 * x >= y && bigPillGrams * x + smallPillGrams * y <= totalGrams)
        {
            ypoints.Add(y);
            if(y == ypoints.Max())
            {
                xpoints.Add(x);
                benefits.Add(2 * x + y);
            }
        }
    }
}

Console.WriteLine("El valor de x = {0} y el valor de y = {1} ofrecen el máximo beneficio de {2}",
    xpoints.Max(), ypoints.Max(), benefits.Max());

Console.ReadLine();