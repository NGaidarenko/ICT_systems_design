using System;

abstract class HaircutProcess
{
    public string Clippers;
    public string BlowDryer;

    public HaircutProcess(string clippers, string blowDryer)
    {
        Clippers = clippers;
        BlowDryer = blowDryer;
    }

    public void PerformHaircut()
    {
        ShampooHair();
        CutHair(Clippers);
        StyleHair(BlowDryer);
    }

    private void ShampooHair()
    {
        Console.WriteLine("Мытье волос");
    }

    private void StyleHair(string blowDryer)
    {
        Console.WriteLine($"{blowDryer} используется для укладки волос");
    }

    public abstract void CutHair(string clippers);
}

class SimpleTrim : HaircutProcess
{
    public SimpleTrim(string c, string b) : base(c, b) { }

    public override void CutHair(string c)
    {
        Console.WriteLine($"Использование {c} для простой стрижки");
    }
}

class BuzzCut : HaircutProcess
{
    public BuzzCut(string c, string b) : base(c, b) { }

    public override void CutHair(string c)
    {
        Console.WriteLine($"Использование {c} для стрижки под машинку");
    }
}

class Template_Method
{
    static void Main()
    {
        HaircutProcess trim = new SimpleTrim("Ножницы", "Фен");
        trim.PerformHaircut();
        Console.WriteLine();

        HaircutProcess buzzCut = new BuzzCut("Машинка", "Фен");
        buzzCut.PerformHaircut();
    }
}