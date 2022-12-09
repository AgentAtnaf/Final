class Program
{
    static void Main(string[] args)
    {
     CircularLinkedList<string> circularLinked = new CircularLinkedList<string>();
     string checker = "pass";
     int index = -1;
     do
     {
        index++;
        circularLinked.Add(Console.ReadLine());
        string input = circularLinked.Get(index);
        if(input == "exit")
        {
            circularLinked.Remove(index);
            checker = "exit";
        }
        else
        {
        int lastcheck = circularLinked.GetLength() -1 ;
        for(int i = 0; i < circularLinked.GetLength(); i++)
        {
            if(circularLinked.Get(i) == circularLinked.Get(lastcheck) && i != lastcheck)
            {
                index--;
                circularLinked.Remove(lastcheck);
            }
        }
        checker = "pass";
        }
     }
     while(checker == "pass");
     int last = circularLinked.GetLength() -1 ;
     string last1 = circularLinked.Get(last);
     string last2 = circularLinked.Get(last-1);
     string last3 = circularLinked.Get(last-2);
     Console.WriteLine(last3);
     Console.WriteLine(last2);
     Console.WriteLine(last1);
    }
}
