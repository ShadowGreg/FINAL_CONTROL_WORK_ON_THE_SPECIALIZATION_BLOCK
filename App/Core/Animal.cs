public abstract class Animal {

    public Animal(int id, DateTime birthDay) {
        Id = id;
        DateOfBirth = birthDay;
        Commands = new PetCommands();
    }
    public int Id { get; set; }
    public int Number { get; set; }
    public PetCommands Commands { get; set;}
    public DateTime DateOfBirth { get; set; }
    public string Name { get; set; }
    public virtual void AddCommand(Commands command) {
        Commands.AddCommand(command);
    }
}