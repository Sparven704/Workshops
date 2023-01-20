public class Cat : Animal
{
    public Cat(typeofTale tale, animalClass animalType, float maxSpeed, string color, eatingType eatingType) : base(animalType, maxSpeed, color, eatingType)
    {
        this.maxSpeed = maxSpeed;
        this.color = color;
        this.eatingType = eatingType;
        this.animalType = animalType;
        this.tale = tale;

        sound = "meow";
    }
    public typeofTale tale { get; set; }

    public void Purr()
    {
        Console.WriteLine("prrrr prrrr prrrr");
    }

    
}

