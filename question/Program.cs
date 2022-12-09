class Program
{
    static void Main(string[] args)
    {
        CircularLinkedList<int> circularLinked = new CircularLinkedList<int>();
        int x = 0;
        int index = -1;
        do
        {
            index++;
            circularLinked.Add(int.Parse(Console.ReadLine()));
            x = circularLinked.Get(index);
            if(x < 0)
            {
                circularLinked.Remove(index);
            }
        }
        while(x > 0);
        CircularLinkedList<float> ans = new CircularLinkedList<float>();

        int diveder = int.Parse(Console.ReadLine());
        while(diveder % 2 == 0)
        {
            diveder = int.Parse(Console.ReadLine());
        }
        for(int i = 0; i < circularLinked.GetLength(); i++)
        {
            float l = (circularLinked.Get(i) + circularLinked.Get(i-1) + circularLinked.Get(i+1)) / diveder;
            ans.Add(l);
        }
        for(int i = 0; i < ans.GetLength(); i++)
        {
            Console.WriteLine(ans.Get(i));
        }
    }
}