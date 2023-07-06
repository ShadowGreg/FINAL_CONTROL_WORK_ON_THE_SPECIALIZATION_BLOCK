using FINAL_CONTROL_WORK_ON_THE_SPECIALIZATION_BLOCK.DataBase;

namespace FINAL_CONTROL_WORK_ON_THE_SPECIALIZATION_BLOCK.Controller;

public class ProgramController {
    private readonly string[] _checkWords = new string[]
    {
        "EXIT", "0", "1", "2", "3", "4", "5", "6", "7"
    };

    private AnimalsRepository _repository;

    public ProgramController(string url) {
        _repository = AnimalsRepository.GetConnection(url);
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
                    inText = AddNewAnimal();
                    break;
                case "2":
                    inText = PrintAllAnimals();
                    break;
                case "3":
                    inText = СhooseAnimal();
                    break;
            }
        }
        else {
            throw new Exception("Команда отсуствует в списке, попробуйте ещё раз");
        }

        return inText;
    }

    private string СhooseAnimal() {
        throw new NotImplementedException();
    }

    private string PrintAllAnimals() {
        List<Animal> animalList = _repository.GetAnimalList();
        foreach (Animal item in animalList) {
            View.View.Print(item.ToString());
        }
        return "0";
    }

    private string AddNewAnimal() {
        string? inText = Console.ReadLine();
        throw new NotImplementedException();
    }
}