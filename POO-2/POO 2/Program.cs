using System.Collections;

class Game
{
    public static void Main(string[] args)
    {
        Wizzard wizzard1 = new Wizzard();
        Warrior warrior1 = new Warrior();

        wizzard1.name = "Gandalf";
        wizzard1.Strenght = 50;
        wizzard1.spells.Add("Lanzar bola de fuego");
        wizzard1.spells.Add("Lanzar chorro de agua");
        Console.WriteLine("{0} con una fuerza de ataque {1} posee las siguientes habilidades: ", 
            wizzard1.name, wizzard1.Strenght);
        foreach(var spell in wizzard1.spells)
        {
            Console.WriteLine(spell);
        }
        wizzard1.Attack();

        warrior1.name = "Leonidas";
        warrior1.Strenght = 50;
        warrior1.skills.Add("Tirar lanza");
        warrior1.skills.Add("Golpear con espada");
        warrior1.skills.Add("Cubrirse con escudo");
        Console.WriteLine("{0} con una fuerza de ataque {1} posee las siguientes habilidades: ",
            warrior1.name, warrior1.Strenght);
        foreach (var skill in warrior1.skills)
        {
            Console.WriteLine(skill);
        }
        warrior1.Attack();

        Console.ReadKey();
    }
}

class Character
{
    public string name;
    private int attackStrenght;
    protected int lifeCuantity;
    public virtual void Attack()
    {
        Console.WriteLine("Ataca");
    }
    public int Strenght
    {
        get
        {
            return attackStrenght;
        }
        set 
        { 
            attackStrenght = value; 
        }
    }
}

class Wizzard : Character
{
    public ArrayList spells = new ArrayList();
    public override void Attack()
    {
        lifeCuantity = 300;
        Console.WriteLine("Cantidad de vida: {0}", lifeCuantity);
        Console.WriteLine("Lanzar hechizo. \n");
    }
}

class Warrior : Character
{
    public ArrayList skills = new ArrayList();
    public override void Attack()
    {
        lifeCuantity = 400;
        Console.WriteLine("Cantidad de vida: {0}", lifeCuantity);
        Console.WriteLine("Defenderse. \n");
    }
}
