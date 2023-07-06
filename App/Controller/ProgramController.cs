using FINAL_CONTROL_WORK_ON_THE_SPECIALIZATION_BLOCK.DataBase;
using FINAL_CONTROL_WORK_ON_THE_SPECIALIZATION_BLOCK.View;

namespace FINAL_CONTROL_WORK_ON_THE_SPECIALIZATION_BLOCK.Controller;

public class ProgramController {
    private readonly string[] _checkWords = new string[]
    {
        "EXIT", "0", "1", "2", "3", "4", "5", "6", "7"
    };

    private AnimalsRepository _repository;
    private Animal _selectedAnimal;

    public ProgramController(string url) {
        _repository = AnimalsRepository.GetConnection(url);
        _selectedAnimal = _repository.GetAnimalList()[0];
    }

    public void Run() {
        string? inText = "0";
        while (!inText.Equals("EXIT")) {
            try {
                inText = MinMenuSwitching();
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
                inText = "0";
            }
        }
    }

    private string? MinMenuSwitching() {
        string[] mainCheckWords = _checkWords[..4];
        View.View.PrintMainMenu();
        string? inText = Console.ReadLine();
        if (mainCheckWords.Contains(inText)) {
            inText = inText switch
            {
                "0" => "0",
                "1" => AddNewAnimal(),
                "2" => PrintAllAnimals(),
                "3" => СhooseAnimal(),
                _ => inText
            };
        }
        else {
            throw new Exception("Команда отсуствует в списке, попробуйте ещё раз");
        }

        return inText;
    }

    private string СhooseAnimal() {
        string[] mainCheckWords = _checkWords[..1];
        List<string> animalsNumList = _repository.GetAnimalsNumList();
        PrintAllAnimals();
        View.View.PrintStandardFrame(ViewText.ForAnimalText);
        string? inText = Console.ReadLine();
        if (inText.Equals("0")) {
            MinMenuSwitching();
            inText = ChooseAnimalAction();
        }
        else if (animalsNumList.Contains(inText)) {
            int intNum = int.Parse(inText)-1;
            _selectedAnimal = _repository.GetAnimalList()[intNum];
        }
        else {
            throw new Exception("Команда отсуствует в списке, попробуйте ещё раз");
        }

        return inText;
    }

    private string ChooseAnimalAction() {
       View.View.PrintAnimalMenu();
       string? inText = Console.ReadLine();
       string[] mainCheckWords = _checkWords[..4];
       if (mainCheckWords.Contains(inText)) {
           inText = inText switch
           {
               "0" => "0",
               "1" => SeeCommandsList(),
               "2" => TeachNewCommans(),
               "3" => SayCatchphrase(),
               _ => inText
           };
       }
       return inText;
    }

    private string? TeachNewCommans() {
        throw new NotImplementedException();
    }

    private string? SeeCommandsList() {
        throw new NotImplementedException();
    }

    private string? SayCatchphrase() {
        _selectedAnimal.SayCatchphrase();
        return "0";
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