Person person1 = new("Иван Иванов", 21);

person1.SetAge(120);

Console.WriteLine(person1.GetName());
Console.WriteLine(person1.GetAge());

class Person
{
    private string name;
    private int age;

    public Person(string n, int a)
    {
        name = n;
        age = a;
    }
    //Геттеры
    public string GetName()
    {
        return name;
    }

    public int GetAge()
    {
        return age;
    }
    //Сеттеры
    public void SetName(string n)
    {
        name = n;
    }

    public void SetAge(int a)
    {
        age = a;
    }
}
;


