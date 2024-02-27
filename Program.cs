// base Class 
class Animal
{
    private string name; // only accessible within this class
    protected string type; //accessible from derived classes
    public string color;  // accessible from any class

    public void setName(string name)
    {
        this.name = name;
    }
    public virtual string getName()
    {
        return this.name;
    }
    public void setType(string type)
    {
        this.type = type;
    }
    public virtual string getType()
    {
        return this.type;
    }
}

class Cow : Animal
{
    public int age;
    protected string gender;
    public double weight;
    
    public void setGender(string gender)
    {
        this.gender = gender;
    }
    public virtual string getGender()
    {
        return gender;
    }
    public override string getName()
    {
        return base.getName();
    }
    public override string getType()
    {
        return type;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Animal animal = new Animal();
        animal.setName("George");
        animal.setType("monkey");
        animal.color = "brown";
        Console.WriteLine("Animal Information...");
        Console.WriteLine($"My name is {animal.getName()}");
        Console.WriteLine($"I am a {animal.getType()}");
        Console.WriteLine($"I am a {animal.color} color");
        Console.WriteLine();

        Cow cow = new Cow();
        cow.setName("Bertha");
        cow.setType("Cow");
        cow.color = "black and white";
        cow.age = 2;
        cow.setGender("female");
        cow.weight = 1000;
        Console.WriteLine("Cow Information...");
        Console.WriteLine($"My name is {cow.getName()}");
        Console.WriteLine($"I am a {cow.getGender()} {cow.getType()}");
        Console.WriteLine($"I am a {cow.color} color");
        Console.WriteLine($"I am {cow.age} years old");
        Console.WriteLine($"I weigh {cow.weight} pounds");
    }
}