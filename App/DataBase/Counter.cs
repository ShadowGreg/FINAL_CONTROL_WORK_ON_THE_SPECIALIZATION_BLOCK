public class Counter {
    private int _counter;
    public int GetNumber() => ++_counter;
    public void SetStartNum(int num) => _counter = num;
}