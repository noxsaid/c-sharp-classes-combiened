/*PetOwner Gabriella = new("Gabriella", "Gustavsson", "gabriella@snakelovers.com");
Pet sirHiss = new ("Sir Hiss", "snake");
Pet mrMouse = new("Mr Mouse", "mouse");

Gabriella.BuyPet(sirHiss);
Gabriella.BuyPet(mrMouse);

Console.WriteLine(Gabriella.TellAboutMyPets());
Console.WriteLine("");
Console.WriteLine(sirHiss.TellAboutMyPets());
Console.WriteLine("");
Console.WriteLine(mrMouse.TellAboutMyPets());*/

List<PetOwner> owners = [];
List<Pet> pets = [];

while (true)
{
    string[] menu = [
        "Vad vill du göra?",
        "1. Lägg till en djurägare",
        "2. Lägg till ett husdjur",
        "3. Visa all djurägare",
        "4. visa alla husdjur",
        "5. låt en djurägare köpa ett husdjur",
        "6. Avsluta"
    ];
    string choice = Ask(string.Join("\n", menu) + "\nVal: ");

    if (choice == "1")
    {
        PetOwner owner = new(Ask("Förnamn: "), Ask("Efternamn: "), Ask("E-post: "));
        owners.Add(owner);
        Console.WriteLine($"{owner.FirstName} har lagts till.\n");
    }
    else if (choice == "2")
    {
        Pet newPet = new(Ask("Namn: "), Ask("Art: "));
        pets.Add(newPet);
        Console.WriteLine($"{newPet.Name} har lagts till.\n");
    }
    else if (choice == "3")
    {
        int counter = 1;
        foreach (PetOwner owner in owners)
        {
            Console.WriteLine($"{counter++}. ");
            Console.WriteLine(owner.TellAboutMyPets());
        }
        Console.ReadLine();
    }
    else if (choice == "4")
    {
        int counter = 1;
        foreach (Pet currentPet in pets)
        {
            Console.WriteLine($"{counter++}. ");
            Console.WriteLine(currentPet.TellAboutMyPets());
        }
        Console.ReadLine();
    }
    else if (choice == "5")
    {
        if (owners.Count == 0 || pets.Count == 0)
        {
            Console.WriteLine("Det behövs minst en djurägare och ett husdjur.\n");
            continue;
        }

        int petOwnerIndex = int.Parse(Ask("Vilken djurägare? (ange nummer): ")) - 1;
        int petIndex = int.Parse(Ask("Vilket husdjur? (ange nummer): ")) - 1;

        if (petOwnerIndex >= 0 && petOwnerIndex < owners.Count && petIndex >= 0 && petIndex < pets.Count)
        {
            owners[petOwnerIndex].BuyPet(pets[petIndex]);
            Console.WriteLine("Husdjuret har kopplats till djurägaren.\n");
        }
        else
        {
            Console.WriteLine("Ogiltigt nummer.\n");
        }
    }
    else if (choice == "6")
    {
        break;
    }
}

static string Ask(string question)
{
    Console.Write(question);
    return Console.ReadLine()?.Trim() ?? "";
}