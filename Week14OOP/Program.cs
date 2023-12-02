Console.WriteLine("Name your dog:");
string myDogName = Console.ReadLine();
Dog myDog = new(myDogName);

Dog neighboursDog = new Dog("Good Girl");

Console.WriteLine($"My dogs name is {myDog.Name}.");
Console.WriteLine($"My Neighbours dog name is {neighboursDog.Name}.");


myDog.Rename("Bad Boy");

while (myDog.LevelOfHapiness != 5)
{
    myDog.Bark();
}

myDog.WagTail();


class Dog
{
    public string _name;
    public int _levelofHapiness;

    //constructor
    public Dog(string name)
    {
        _name = name;
        _levelofHapiness = 0;
    }  

    //getter
    public string Name
    {
        get { return _name; }
    }

    public int LevelOfHapiness
    {
        get { return _levelofHapiness; }
    }

    public void Rename(string newName)
    {
        _name = newName;
        Console.WriteLine($"The dog has been renamed to: {newName}");
    }

    public void Bark()
    {
        Console.WriteLine("Woof-woof!");
        _levelofHapiness++;
    }

    public void WagTail()
    {
        Console.WriteLine("Wiggle-wiggle!");
    }

}


