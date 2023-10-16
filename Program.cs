namespace OOPArv
{           //wille persson - .NET23 -Labb 6
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal kängru = new Animal("Kängrun koko", "orange", 2, 35, 12);
            Elephant elefant = new Elephant();
            Lion lejon = new Lion();
            Zebra zebra = new Zebra();
            AfricanSavannahElephant savanaElefanten = new AfricanSavannahElephant();
            AfricanForestElephant skogsElefanten = new AfricanForestElephant();

            Console.WriteLine(kängru._name);
            kängru.tryEscape();
            kängru.makeSound();

            Console.WriteLine();

            Console.WriteLine(elefant._name);
            Console.WriteLine(elefant._horns);
            elefant.waveTrunk();
            elefant.makeSound();

            Console.WriteLine();

            Console.WriteLine(lejon._name);
            Console.WriteLine(lejon._teeth);
            Console.WriteLine(lejon._weight);
            lejon.Hungry();
            lejon.makeSound();

            Console.WriteLine();

            Console.WriteLine(zebra._name);
            zebra.hide();
            Console.WriteLine(zebra._blackStripes);
            Console.WriteLine(zebra._legs);
            zebra.makeSound();

            Console.WriteLine();

            savanaElefanten.waveTrunk();
            Console.WriteLine(savanaElefanten._lenghtofTrunk);
            savanaElefanten.makeSound();

            Console.WriteLine();

            skogsElefanten.waveTrunk();
            Console.WriteLine(skogsElefanten._lenght);
            skogsElefanten.makeSound();
        }
    }
}