using FINAL_CONTROL_WORK_ON_THE_SPECIALIZATION_BLOCK.View;

public class Hamster: Pet {
    public Hamster(int id, DateTime birthDay): base(id, birthDay) { }

    public override void SayCatchphrase() {
        View.Print("Я бегу по кругу уииии!");
    }

    public override string ToString() {
        return "Хомяк/хомячиха: \n" + base.ToString();
    }
}