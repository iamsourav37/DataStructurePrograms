namespace DataStructurePrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Data Structure Implementation in C#");

            StackUsingArray stackUsingArray = new(5);


            Console.WriteLine($"Peek element is: {stackUsingArray.Peek()}");
            stackUsingArray.Pop();
            stackUsingArray.Push(8);
            stackUsingArray.Push(24);
            stackUsingArray.Push(29);
            stackUsingArray.Push(3);
            stackUsingArray.Push(98);
            stackUsingArray.Push(98);
            stackUsingArray.Push(98);

            Console.WriteLine($"Peek element is: {stackUsingArray.Peek()}");

            stackUsingArray.Show();

        }
    }
}
