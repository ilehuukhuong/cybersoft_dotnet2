class Animal : IEat, ISleep
{
    private string name;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public Animal(string name)
    {
        this.name = name;
    }

    // định nghĩa lại hàm eat dành riêng cho class Animal
    public void Eat()
    {
        Console.WriteLine("Animal is eating");
    }

    // định nghĩa lại hàm sleep dành riêng cho class Animal
    public void Sleep()
    {
        Console.WriteLine("Animal is sleeping");
    }
}