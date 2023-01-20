public class Dog : Animal
{
    public Dog(lengthofLeg lenghtofLeg, animalClass animalType, float maxSpeed, string color, eatingType eatingType) : base(animalType, maxSpeed, color, eatingType)
    {
        this.maxSpeed = maxSpeed;
        this.color = color;
        this.eatingType = eatingType;
        this.animalType = animalType;
        this.lenghtofLeg = lenghtofLeg;

        sound = "Woof Woof";
    }
    public lengthofLeg lenghtofLeg { get; set; }
    public void bark()
    {
        Console.WriteLine("BARK! BARK! grrrr");
    }
}

public class Bulldog : Dog
{
    public Bulldog(lengthofLeg lenghtofLeg, animalClass animalType, float maxSpeed, string color, eatingType eatingType) : base(lenghtofLeg, animalType, maxSpeed, color, eatingType)
    {
        this.maxSpeed = maxSpeed;
        this.color = color;
        this.eatingType = eatingType;
        this.animalType = animalType;
        this.lenghtofLeg = lenghtofLeg;

        sound = "Bork Bork";
    }
}
public class Chihuahua : Dog
{
    public Chihuahua(lengthofLeg lenghtofLeg, animalClass animalType, float maxSpeed, string color, eatingType eatingType) : base(lenghtofLeg, animalType, maxSpeed, color, eatingType)
    {
        this.maxSpeed = maxSpeed;
        this.color = color;
        this.eatingType = eatingType;
        this.animalType = animalType;
        this.lenghtofLeg = lenghtofLeg;

        sound = "Erf Erf";
    }
}