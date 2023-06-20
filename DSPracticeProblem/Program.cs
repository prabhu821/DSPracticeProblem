using System.Collections.Generic;

namespace DSPracticeProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Data Structure Practice Problem!");
            LinkedList<int> list = new LinkedList<int>();
            Stack<int> stack = new Stack<int>();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nSelect the operation to perform \n1.Create Linked List \n2.Display \n3.Create and Display Stack" +
                    "\n4.Exit");
                int options = Convert.ToInt32(Console.ReadLine());
                switch (options)
                {
                    case 1:
                        list.Add(56);
                        list.Add(30);
                        list.Add(70);
                        break;
                    case 2:
                        list.Display();
                        break;
                    case 3:
                        stack.Push(70);
                        stack.Push(30);
                        stack.Push(56);
                        stack.Display();
                        break;
                    default:
                        flag=false;
                        break;
                }
            }
        }
    }
}