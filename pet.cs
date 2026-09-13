class Pet(string name, string species)
{
    // public fields
    public string Name = name;
    public string Species = species;
    public PetOwner? Owner;

    // SayHi -> who am i
    public virtual string SayHi()
    {
        return $" I am the {Species} {Name}!";
    }

    // A method that lets the pet tell us who owns it
    public string TellAboutMyPets()
    {
        return SayHi() + "\n" + (Owner == null
            ? " No one owns me!"
            : $" My Owner is {Owner.FirstName} {Owner.LastName} ({Owner.Email})");

    }
}