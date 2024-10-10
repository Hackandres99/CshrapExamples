internal class Program
{
    static void Main(string[] args)
    {
        Farmacia farmacia = new Farmacia();
        farmacia.totalGrams = 600;
        farmacia.bigPillGrams = 40;
        farmacia.smallPillGrams = 30;
        farmacia.smallPillMinCuantity = 3;
        farmacia.bigPillExpCuantity = 2;
        farmacia.calcMaxBenefit();

        Console.ReadKey();
    }
}
class Farmacia
{
    public int totalGrams;
    public int bigPillGrams;
    public int smallPillGrams;
    public int smallPillMinCuantity;
    public int bigPillExpCuantity;

    public void calcMaxBenefit()
    {
        List<int> ypoints = new List<int>();
        List<int> xpoints = new List<int>();
        List<int> benefits = new List<int>();

        for(int x= 0; x<= 20; x++)
        {
            for (int y = 0; y <= 20; y++)
            {
                if(x >= this.smallPillMinCuantity &&
                    this.bigPillExpCuantity * x >= y &&
                    this.bigPillGrams * x + this.smallPillGrams * y <= this.totalGrams)
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
    }
}