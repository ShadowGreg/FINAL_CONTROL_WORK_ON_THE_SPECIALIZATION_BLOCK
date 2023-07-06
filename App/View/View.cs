namespace FINAL_CONTROL_WORK_ON_THE_SPECIALIZATION_BLOCK.View; 

public static class View {
    public static void Print(string item) {
        PrintItems(item);
    }

    private static void PrintItems(string text) {
        Console.WriteLine("\n********************************");
        Console.WriteLine(text);
        Console.WriteLine("\n********************************\n");
    }

    public static void PrintStandardFrame(string inText) {
        Console.WriteLine("\n********************************");
        Console.WriteLine(inText);
        Console.WriteLine("\n********************************");
        Console.Write("\n>");
    }

    public static void PrintMainMenu() {
        PrintStandardFrame(ViewText.MainMenuText);
    }

    public  static void PrintCreateAnimalMenu() {
        PrintStandardFrame(ViewText.CreateAnimalMenuText);
    }

    public  static void PrintAnimalMenu() {
        PrintStandardFrame(ViewText.AnimalMenuText);
    }

    public  static void PrintAnimalCommandsMenu() {
        PrintStandardFrame(ViewText.AnimalCommandsMenuText);
    }
}