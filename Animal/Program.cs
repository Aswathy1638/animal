abstract class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }
    public abstract void Sound();
}
interface IMovable
{
    void move();
}
 class Dog : Animal, IMovable
{
    public Dog(string name,int age)
    {
        this.Name = name;
        this.Age = age;
    }
    public override void Sound()
    {
        Console.WriteLine($"{Name} has {Age} years and says Bow");
    }
    public void move()
{
        Console.WriteLine("Dog is moving");
}
}
 class Cat : Animal, IMovable
{
    public Cat(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }
    public override void Sound()
    {
        Console.WriteLine($"{Name} has {Age} years and says Meow");
    }
    public void move()
    {
        Console.WriteLine("Cat is moving");
    }

}

class Program
{
    public static void Main()
    {
        Cat c = new Cat("Tom",5);
        Dog d = new Dog("Tiger",1);
        Animal[] animals = new Animal[2];
        animals[0] = d;
        animals[1] = c;
        d.move();
        c.move();
        d.Sound();
        c.Sound();
    }
}