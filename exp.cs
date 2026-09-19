// void Execute(String targetValue)
// {
//     // Implementation of the Execute method
//     Console.WriteLine("Executing the operation...");
//     // Additional logic can be added here

//     string actionDetails = string.IsNullOrEmpty(targetValue) ? "" : $"with value['{targetValue}']";
//     Console.WriteLine($"Action details: {actionDetails}");
// }

// Console.WriteLine("Enter a target value (or leave empty):");
// string userInput = Console.ReadLine();
// Execute(userInput);

void expFunction(string targetValue ="Initial Value")
{
    String initialValue=targetValue+" Changed";
    Console.WriteLine("Executing the operation...");
    Console.WriteLine($"Target value: {initialValue}");
}
expFunction();

