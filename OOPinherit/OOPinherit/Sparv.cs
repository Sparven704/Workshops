public class Sparv : Animal
{
    public Sparv(int eggsLayed, animalClass animalType, float maxSpeed, string color, eatingType eatingType) : base(animalType, maxSpeed, color, eatingType)
    {
        this.maxSpeed = maxSpeed;
        this.color = color;
        this.eatingType = eatingType;
        this.animalType = animalType;
        this.eggsLayed = eggsLayed;

        sound = "chirp chirp";
    }

    public int eggsLayed { get; set; }
    public void startFlying()
    {
        Console.WriteLine("The bird flies away.");
    }
}

