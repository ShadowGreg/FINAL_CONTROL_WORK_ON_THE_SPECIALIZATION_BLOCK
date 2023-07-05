public class Hamster: Pet {
    public Hamster(int id, DateTime birthDay): base(id, birthDay) { }

    public void HamsterSay() {
        View.Print("Я бегу по кругу уииии!");
    }
}