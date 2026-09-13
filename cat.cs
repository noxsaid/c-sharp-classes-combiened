class cat(string name):Pet(name, "cat")
{
    public override string SayHi()
    {
        return"Meow! " + base.SayHi();
    }
}