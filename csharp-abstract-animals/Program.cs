namespace csharp_abstract_animals
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Animale> animals = new List<Animale>();

            animals.Add(new Cane());
            animals.Add(new Passerotto());
            animals.Add(new Aquila());
            animals.Add(new Delfino());

            

            foreach (Animale animale in animals)
            {
                animale.Dormi();
                animale.Verso();
                animale.Mangia();
                
            }
        }
    }
}
