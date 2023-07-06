namespace FINAL_CONTROL_WORK_ON_THE_SPECIALIZATION_BLOCK.View; 

public class View {
    public static void Print(string item) {
        Console.WriteLine(item);
    }

    private static void PrintStandardFrame(string inText) {
        Console.WriteLine("\n********************************");
        Console.WriteLine(inText);
        Console.WriteLine("\n********************************");
    }

    public void PrintMainMenu() {
        PrintStandardFrame(ViewText.MainMenuText);
    }

    public void PrintCreateAnimalMenu() {
        PrintStandardFrame(ViewText.CreateAnimalMenuText);
    }

    public void PrintAnimalMenu() {
        PrintStandardFrame(ViewText.AnimalMenuText);
    }

    public void PrintAnimalCommandsMenu() {
        PrintStandardFrame(ViewText.AnimalCommandsMenuText);
    }
}