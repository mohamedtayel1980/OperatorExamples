namespace OperatorExamples
{
    internal class Program
    {
       
                static void Main(string[] args)
                {
           
                    #region Section 1: Arithmetic Operators
                    Console.WriteLine("=== Arithmetic Operators ===");

                    int item1Price = 30;
                    int item2Price = 20;
                    int totalPrice = item1Price + item2Price;
                    Console.WriteLine($"Total Price: {item1Price} + {item2Price} = {totalPrice}");

                    int payment = 100;
                    int change = payment - totalPrice;
                    Console.WriteLine($"Change: {payment} - {totalPrice} = {change}");

                    int doublePrice = totalPrice * 2;
                    Console.WriteLine($"Double Price: {totalPrice} * 2 = {doublePrice}");

                    int half = totalPrice / 2;
                    Console.WriteLine($"Half of Total Price: {totalPrice} / 2 = {half}");

                    int remainder = totalPrice % 3;
                    Console.WriteLine($"Remainder of Total Price / 3: {totalPrice} % 3 = {remainder}");

                    Console.WriteLine();
                    #endregion

                    #region Section 2: Assignment Operators
                    Console.WriteLine("=== Assignment Operators ===");

                    int score = 100;
                    Console.WriteLine($"Initial Score: {score}");

                    score += 50;//score=score+50
                    Console.WriteLine($"Score after earning 50 points: {score}");

                    score -= 30;//score=score-30
                    Console.WriteLine($"Score after losing 30 points: {score}");

                    score *= 2;
                    Console.WriteLine($"Score after doubling: {score}");

                    score /= 3;
                    Console.WriteLine($"Score after dividing by 3: {score}");

                    score %= 7;
                    Console.WriteLine($"Remainder of Score / 7: {score}");

                    Console.WriteLine();
                    #endregion

                    #region Section 3: Comparison Operators
                    Console.WriteLine("=== Comparison Operators ===");

                    int a = 10;
                    int b = 20;//?:

                    Console.WriteLine($"a = {a}, b = {b}");
                    Console.WriteLine($"Is a equal to b? (a == b): {a == b}");
                    Console.WriteLine($"Is a not equal to b? (a != b): {a != b}");
                    Console.WriteLine($"Is a greater than b? (a > b): {a > b}");
                    Console.WriteLine($"Is a less than b? (a < b): {a < b}");
                    Console.WriteLine($"Is a greater than or equal to b? (a >= b): {a >= b}");
                    Console.WriteLine($"Is a less than or equal to b? (a <= b): {a <= b}");

                    Console.WriteLine();
                    #endregion

                    #region Section 4: Logical Operators
                    Console.WriteLine("=== Logical Operators ===");

                    bool isAdult = true;
                    bool hasID = false;

                    Console.WriteLine($"isAdult: {isAdult}, hasID: {hasID}");
                    Console.WriteLine($"Can enter (isAdult && hasID): {isAdult && hasID}");
                    Console.WriteLine($"Can enter with either (isAdult || hasID): {isAdult || hasID}");
                    Console.WriteLine($"Negate isAdult (!isAdult): {!isAdult}");

                    Console.WriteLine();
                    #endregion

                    #region Section 5: Increment and Decrement Operators
                    Console.WriteLine("=== Increment and Decrement Operators ===");

                    // Initial value
                    int ab = 5;

                    // Prefix Increment (++a)
                    Console.WriteLine("=== Prefix Increment ===");
                    Console.WriteLine($"Original value of a: {ab}");
                    Console.WriteLine($"Using prefix (++a): {++ab}");  
                    Console.WriteLine($"Value of a after prefix increment: {ab}");

                    // Reset value
                    ab = 5;

                    // Postfix Increment (a++)
                    Console.WriteLine("\n=== Postfix Increment ===");
                    Console.WriteLine($"Original value of a: {ab}");
                    Console.WriteLine($"Using postfix (a++): {ab++}");  
                    Console.WriteLine($"Value of a after postfix increment: {ab}");

                    // Reset value
                    ab = 5;

                    // Prefix Decrement (--a)
                    Console.WriteLine("\n=== Prefix Decrement ===");
                    Console.WriteLine($"Original value of a: {ab}");
                    Console.WriteLine($"Using prefix (--a): {--ab}"); 
                    Console.WriteLine($"Value of a after prefix decrement: {ab}");

                    // Reset value
                    ab = 5;

                    // Postfix Decrement (a--)
                    Console.WriteLine("\n=== Postfix Decrement ===");
                    Console.WriteLine($"Original value of a: {ab}");
                    Console.WriteLine($"Using postfix (a--): {ab--}"); 
                    Console.WriteLine($"Value of a after postfix decrement: {ab}");

                    Console.WriteLine();
                    #endregion

                   
                }
            }
        }
    

