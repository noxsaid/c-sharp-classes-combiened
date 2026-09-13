class PetOwner(string firstName, string lastName, string email)
{
    // public fields
    public string FirstName = firstName;
    public string LastName = lastName;
    public string Email = email;

    public List<Pet> pets = [];

    public string SayHi()
    {
        return $"I am {FirstName} {LastName}!";
    }

    public void BuyPet(Pet newPet)
    {
        // Add the pet to my last pets
        pets.Add(newPet);
        // set the owner field of the pet
        // Note: THis -> me the instance running the method
        newPet.Owner = this; 
    }

    public string TellAboutMyPets()
    {
        string story = SayHi() + "\n";
        if (pets.Count == 0)
        {
            return story + " I dont own any pets yet!";
        }
        story += "I own the following pets";
        foreach(Pet pet in pets)
        {
            story += $"\n{pet.Name} ({pet.Species})";
        }
        // return the story
        return story;
    }
}