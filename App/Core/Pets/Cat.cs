
public class Cat:Pet {
    public Cat(int id, DateTime birthDay): base(id, birthDay) { }

    public void CatSay() {
        View.Print("Я чешу мурлычу. Муррррррррр....");
    }
}