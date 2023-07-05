public class PetCommands {

    public PetCommands() {
        Commands = new List<string>();
    }
    public List<string> Commands { get;}

    public void PetCommand() {
        foreach (string item in Commands) {
            View.Print(item);
        }
    }

    public void AddCommand(Commands command) {
        Commands.Add(command.ToString());
    }

    public void AddCommand(string command) {
        Commands.Add(command);
    }
}