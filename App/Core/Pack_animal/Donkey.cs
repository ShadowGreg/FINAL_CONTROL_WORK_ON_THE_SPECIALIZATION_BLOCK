using FINAL_CONTROL_WORK_ON_THE_SPECIALIZATION_BLOCK.View;

public class Donkey: PackAnimal {
    public Donkey(int id, DateTime birthDay): base(id, birthDay) { }

    public override void SayCatchphrase() {
        View.Print($"Я – маленький ослик {Name}, и мне живётскя не сладко");
    }

    public override string ToString() {
        return "Осёл/ослица: \n" + base.ToString();
    }
}