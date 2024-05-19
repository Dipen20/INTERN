//parallel programming

class ParallelAsyns{
    int[] numbers=[23,453,11,22,44533];

    public void Processnumber(){
        foreach(var num in numbers)
        {
            DoWork(num);
        }
    }

    public void DoWork(int num)
    {
        Thread.Sleep(1000);//simulating delay
        Console.WriteLine($"num: {num}");
    }

}