namespace OOPArv
{           //wille persson - .NET23 - Labb 6
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            Animal kängru = new Animal("Kängrun koko", "orange", 2, 35, 12);
            animals.Add(kängru);
           
            Elephant elefant = new Elephant();
            animals.Add(elefant);
           
            Lion lejon = new Lion();
            animals.Add(lejon);
           
            Zebra zebra = new Zebra();
            animals.Add(zebra);
           
            AfricanSavannahElephant savanaElefanten = new AfricanSavannahElephant();
            animals.Add(savanaElefanten);
           
            AfricanForestElephant skogsElefanten = new AfricanForestElephant();
            animals.Add(skogsElefanten);


            foreach (Animal animal in animals)
            {
                animal.AddInfo();
                Console.WriteLine();
            }
            kängru.tryEscape();
            kängru.makeSound();

            Console.WriteLine();

            elefant.waveTrunk();
            elefant.makeSound();

            Console.WriteLine();

            lejon.Hungry();
            lejon.makeSound();

            Console.WriteLine();

            zebra.hide();
            zebra.makeSound();

            Console.WriteLine();

            savanaElefanten.waveTrunk();
            savanaElefanten.makeSound();

            Console.WriteLine();

            skogsElefanten.waveTrunk();
            skogsElefanten.makeSound();
        }
    }
}