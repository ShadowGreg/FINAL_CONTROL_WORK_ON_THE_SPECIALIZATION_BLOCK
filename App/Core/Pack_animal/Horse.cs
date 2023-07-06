using FINAL_CONTROL_WORK_ON_THE_SPECIALIZATION_BLOCK.View;

public class Horse: PackAnimal {
    public Horse(int id, DateTime birthDay): base(id, birthDay) { }
    public override void SayCatchphrase() {
        View.Print($"Я – маленькая лошадка {Name}, но стою очень много денег");
    }

    public override string ToString() {
        return "Жеребец/кобыла: \n" + base.ToString();
    }
}