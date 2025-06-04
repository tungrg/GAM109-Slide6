using System;

public class Program
{
    public static void Main(string[] args)
    {
        //First khong dieu kien
        //List<string> list = new List<string>() { "1", "2", "3", "haha" };
        //Console.WriteLine(list.Last());
        ////First nhung co dieu kien
        //var intList = new List<int>() { 1, 2, 3, 4,2,-99 };
        //Console.WriteLine(intList.LastOrDefault(x => x > 5));
        //Console.WriteLine("hihhahaia");

        
        //var intList = new List<int>() { 1};
        //Console.WriteLine(intList.Single());
        //var stringList = new List<string>() { "T1", "T2", "T3", "T4", "T1" };
        //Console.WriteLine(stringList.SingleOrDefault(x => x.CompareTo("T1") == 0));

        var intList = new List<int>();
        var check = intList.DefaultIfEmpty(-1);
        Console.WriteLine(intList.Count);
        Console.WriteLine(check.ElementAt(0));
        

    }
}