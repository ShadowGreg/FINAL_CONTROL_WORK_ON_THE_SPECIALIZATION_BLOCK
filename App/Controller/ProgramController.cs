namespace FINAL_CONTROL_WORK_ON_THE_SPECIALIZATION_BLOCK.Controller;

public class ProgramController {
    private string[] _checkWords = new string[]
    {
        "EXIT", "0", "1", "2", "3", "4", "5", "6", "7"
    };

    private string _url;

    public ProgramController(string url) {
        _url = url;
    }

    public void Run() {
        string? inText = "0";
        while (!inText.Equals("EXIT")) {
            try {
                inText = MinMenuSwitcher();
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
                inText = "0";
            }
        }
    }

    private string? MinMenuSwitcher() {
        string[] mainCheckWords = _checkWords[..4];
        View.View.PrintMainMenu();
        string? inText = Console.ReadLine();
        if (mainCheckWords.Contains(inText)) {
            switch (inText) {
                case "0":
                    inText = "0";
                    break;
                case "1":
                    AddNewAnimal();
                    break;
                case "2":
                    PrintAllAnimals();
                    break;
                case "3":
                    СhooseAnimal();
                    break;
            }
        }
        else {
            throw new Exception("Команда отсуствует в списке, попробуйте ещё раз");
        }

        return inText;
    }

    private void СhooseAnimal() {
        throw new NotImplementedException();
    }

    private void PrintAllAnimals() {
        throw new NotImplementedException();
    }

    private void AddNewAnimal() {
        throw new NotImplementedException();
    }
}