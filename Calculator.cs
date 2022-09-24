class Calculator
{
    public static void Main(){
        int result;
        Console.WriteLine("Enter action :");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Division");
        Console.WriteLine("4. Multiplication");
        int action = (Convert.ToInt32(Console.ReadLine()));
        Console.Write("first input : ");
        int num1 = (Convert.ToInt32(Console.ReadLine()));
        Console.Write("Second input : ");
        int num2 = (Convert.ToInt32(Console.ReadLine()));
        switch(action)
        {
            case 1:
                result = num1 + num2;
                Console.WriteLine("The result : "+ result +" addition");
                break;
            case 2:
                result = num1 - num2;
                Console.WriteLine("The result : "+ result +" Subtraction");
                break;
            case 3:
                result = num1 * num2;
                Console.WriteLine("The result : "+ result +" Division");
                break;
            case 4:
                result = num1 / num2;
                Console.WriteLine("The result : "+ result +" Multiplication");
                break;
        }
    }
}