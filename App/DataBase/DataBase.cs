namespace FINAL_CONTROL_WORK_ON_THE_SPECIALIZATION_BLOCK.DataBase; 

public static class DataBase {
    private static List<List<string>> SomeData = new()
    {
        new List<string>()
        {
            "ID1",
            "cat",
            "1",
            "2023-07-05",
            "Milka",
            "RUN_AWAY"
        },
        new List<string>()
        {
            "ID2",
            "dog",
            "2",
            "2023-06-05",
            "Rex",
            "RUN_AWAY GO JUMP LIE"
        },
        new List<string>()
        {
            "ID3",
            "hamster",
            "3",
            "2023-07-01",
            "Buby",
            "RUN_AWAY"
        },
        new List<string>()
        {
            "ID4",
            "camel",
            "4",
            "2020-07-01",
            "Camel",
            "RUN_AWAY"
        },
        new List<string>()
        {
            "ID5",
            "donkey",
            "5",
            "2020-07-01",
            "Donkey",
            "RUN_AWAY"
        },
        new List<string>()
        {
            "ID6",
            "horse",
            "6",
            "2020-07-01",
            "Horse",
            "RUN_AWAY"
        },
    };

    public static List<List<string>> GetSomeData() => SomeData;
    public static void AddSomeData(List<string> inData) => SomeData.Add(inData) ;
}