public class Animal
{
    public Animal(animalClass animalType, float maxSpeed, string color, eatingType eatingType)
    {
        this.animalType = animalType;
        this.maxSpeed = maxSpeed;
        this.color = color;
        this.eatingType = eatingType;
        this.animalType = animalType;
    }
    public animalClass animalType { get; set; }
    public float maxSpeed { get; set; }
    public string color { get; set; }
    public eatingType eatingType { get; set; }
    public string sound { get; set; }

    public void goToSleep()
    {
        Console.WriteLine("You go to sleep zZz");
    }
    public void makeSound()
    {
        Console.WriteLine();
        Console.WriteLine(sound);
        Console.WriteLine();
    }

    public void Feed()
    {
        Console.WriteLine("omnomnom");
    }
}

