using System.Text;

public abstract class Animal {
    public Animal(int id, DateTime birthDay) {
        Id = id;
        DateOfBirth = birthDay;
        PetCommands = new PetCommands();
        PetCommands.AddCommand(Commands.RUN_AWAY);
    }

    public int Id { get; set; }
    public int Number { get; set; }
    public PetCommands PetCommands { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Name { get; set; }

    public virtual void AddCommand(Commands command) {
        PetCommands.AddCommand(command);
    }
    public virtual void AddCommand(string command) {
        PetCommands.AddCommand(command);
    }

    public override string ToString() {
        string output = new StringBuilder($"По имени {Name}" + "\n" +
                                          $"С порядковым номером {Number}" + "\n" +
                                          $"Предположительной даты рождения {DateOfBirth:dd/MM/yyyy}" + "\n"+
                                          $"Знает команды:\n").ToString();
        foreach (string command in PetCommands.Commands) {
            output += " -" + command + "\n";
        }
        return output;
    }
    public virtual void SayCatchphrase() {
        throw new Exception("Пока не создал такого метода");
    }
}