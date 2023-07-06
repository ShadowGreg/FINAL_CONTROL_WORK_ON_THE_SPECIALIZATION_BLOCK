
using FINAL_CONTROL_WORK_ON_THE_SPECIALIZATION_BLOCK.View;

public class Cat:Pet {
    public Cat(int id, DateTime birthDay): base(id, birthDay) { }

    public void CatSay() {
        View.Print("Я чешу мурлычу. Муррррррррр....");
    }

    public override string ToString() {
        return "Кот/кошка: \n" + base.ToString();
    }
}