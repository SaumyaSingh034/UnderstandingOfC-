using System
namespace LearningC#
{
    public class Practice{
    static void Main(String[] args){
        Console.WriteLine("Hello Word");
        int a = 4;
        Console.WriteLine($"Printining Integer Value {a}");
        String str = "Saumya";
        Console.WriteLine($"Hello {str}");
        var age = 27;
        Console.WriteLine($"Hello {age}");
        //age = "Singh";
        dynamic data = "Tryaksh Singh Bist";
        Console.WriteLine($"Hello {data}");
        data = 899.9999;
        Console.WriteLine($"Hello {data}");
        
    }
}
}