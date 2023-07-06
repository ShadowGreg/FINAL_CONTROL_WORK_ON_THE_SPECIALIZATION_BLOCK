using FINAL_CONTROL_WORK_ON_THE_SPECIALIZATION_BLOCK.Controller;
public class Program {
    private const string Url = "http://localhost:8080";
    private static readonly ProgramController Controller = new ProgramController(Url);
    public static void Main(string[] args) {
        Controller.Run();
        Console.WriteLine("Благодраю за использование!");
    }
}