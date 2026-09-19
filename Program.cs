using System;

// namespace HelloWorld
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
//       Console.WriteLine("Hello World!");    
//     }
//   }
// }

// static void method(int x, int y)
// {
//   if (x > y)
//   {
//     Console.WriteLine(x+ " is bigger.");
//   }
//   else
//   {
//     Console.WriteLine(y+ " is bigger.");
//   }
//   Console.Write("The End");  
// }

// method(Convert.ToInt32(Console.ReadLine()),
//        Convert.ToInt32(Console.ReadLine())
//       );

void func(int ?num){
    var age = 89;
    if(num!=null){
        Console.Write(num+ " is the data");
    }
    else
    {
        Console.Write("Data not provided");
    }
}

func(null);