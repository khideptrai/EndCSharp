public class Student : IStudent
{
    public int StudID { get; set; }
    public string StudName { get; set; }
    public string StudGender { get; set; }
    public int StudAge { get; set; }
    public string StudClass { get; set; }
    public float StudAvgMark { get; private set; }
    int[] MarkList = new int[3];
    public void Print()
    {
        Console.WriteLine("Id: " + StudID);
        Console.WriteLine("Name: " + StudName);
        Console.WriteLine("Gender: " + StudGender);
        Console.WriteLine("Age: " + StudAge);
        Console.WriteLine("Class: " + StudClass);
        Console.WriteLine("AvgMark: " + StudAvgMark);
    }
    public int this[int index]
    {
        set
        {
            if (index < 0 || index > MarkList.Length - 1)
                throw new ArgumentOutOfRangeException();
            MarkList[index] = value;
        }
    }
    public void CalAvg()
    {
        float num = 0;
        foreach(var number in MarkList)
        {
            num += number;
        }
        StudAvgMark = num / MarkList.Length;
    }
}
