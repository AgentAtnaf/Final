class Program
{
    static void Main(string[] args)
    {
        int left = 0;
        int right = 0;
        int exit = 1;
        do
        {
        char current = char.Parse(Console.ReadLine());
        if(current == '(')
        {
            left++;
        }
        else if (current == ')')
        {
            right++;
        }
        else
        {
            exit = 0;
        }
        }
        while(exit == 1);
        
        if(left == right)
        {
            Console.WriteLine("valid");
        }
        else
        {
            Console.WriteLine("Invalid");
        }
    }
}
