namespace Model;

/// <summary>
/// A collection of cages in the shelter.
/// </summary>
public class Shelter
{
    public List<Cage> Cages { get; set; }
        
    /// <summary>
    /// Returns all animals in the shelter.
    /// </summary>
    /// <returns></returns>
    public List<Animal> GetAllAnimals()
    {
        return Cages.SelectMany(c => c.Animals).ToList();
    }
}