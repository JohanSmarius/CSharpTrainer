namespace Model;

public class Cage
{
    int capacity;

    public int Number { get; set; }

    public Volunteer Volunteer { get; set; }
        
    public List<Animal> Animals { get; set; }

    public override string ToString()
    {
        return base.ToString();
    }
}