//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace StudentManagementSystem
//{
//    static void CallProgram(string[] arr, int count)
//    {

//        Greeting(count);
//        int n1 = int.Parse(Console.ReadLine());
//        if (n1 == 1)
//        {
//            count++;
//            Add(arr, count);
//        }
//        else if (n1 == 2 && count < 1)
//        {
//            Console.WriteLine("There is no item to remove");
//        }
//        else if (n1 == 2)
//        {
//            count--;
//            Remove(arr, count);
//        }
//        else
//        {
//            return;
//        }
//        Console.ReadLine();
//    }

//    static void Greeting(int count)
//    {
//        string add = "1.ADD";
//        string remove = "2.REMOVE";
//        string esc = "3.ESC";
//        if (count == 0)
//        {
//            Console.WriteLine("You Can ADD or REMOVE Students!!");
//        }
//        Console.WriteLine("Choose an option");
//        Console.WriteLine($"{add}  {remove}   {esc}");
//    }

//    static void Add(string[] arr, int count)
//    {
//        Console.Write("Name: ");
//        string name = Console.ReadLine();
//        Console.Write("Age: ");
//        int age = int.Parse(Console.ReadLine());
//        Array.Resize(ref arr, count);
//        arr[count - 1] = name;
//        Array.Sort(arr);
//        Console.Clear();
//        for (int i = 0; i < arr.Length; i++)
//        {
//            Console.Write($"{i + 1}:{arr[i]} ");
//        }
//        Console.ReadLine();
//        CallProgram(arr, count);

//    }
//    static void Remove(string[] arr, int count)
//    {

//        Console.Write("Choose Removeing item:");
//        int input = int.Parse(Console.ReadLine());
//        if (count == 0)
//        {
//            Array.Resize(ref arr, count);
//        }
//        else
//        {
//            arr[input - 1] = "zzzzzzzzzzzzzzzzzzzzzzzzz";
//            Array.Sort(arr);
//            Array.Resize(ref arr, count);
//        }
//        Console.Clear();
//        for (int i = 0; i < arr.Length; i++)
//        {
//            Console.Write($"{i + 1}:{arr[i]} ");
//        }
//        Console.ReadLine();
//        CallProgram(arr, count);
//    }
//}
