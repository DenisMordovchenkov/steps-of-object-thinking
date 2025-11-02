

String[] CreatePersons(int amount)
{
    String[] names = new String[amount];
    for (int i = 0; i < amount; i++)
    {
        names[i] = $"Человек Человеков - {i}, Возраст - {Random.Shared.Next(99)}";
    }
    return names;
}
;


String[] persons = CreatePersons(10);

foreach (var item in persons)
{
    Console.WriteLine(item);
}



