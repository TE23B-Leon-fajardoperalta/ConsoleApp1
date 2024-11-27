List<string> valja = ["", "dog1", "dog2", "dog3", "dog4"];


static int GetChoice(List<string> options)
{
    for (int i = 0; i < options.Count; i++)
    {
        Console.WriteLine(options[i]);
    }

    Console.WriteLine("välj en");

    int result = 0;

    while (result <= 0 || result >= options.Count+1)
    {

        string read = Console.ReadLine();

        int.TryParse(read, out result);

    }

    return result;
}


int wow = GetChoice(["dog1", "dog2"]);


// int wow = getchoice(["cat1", "cat2"]);

Console.WriteLine(valja[wow]);
Console.ReadLine();

// wow