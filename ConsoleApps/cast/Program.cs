// int first = 10;
// int second = 5;

// string message = first.ToString() + second.ToString();
// Console.WriteLine(message);

// string third = "10";
// string fourth = "5";

// int thirdCast;
// int fourthCast;

// bool cast = int.TryParse(third, out thirdCast);
// bool cast2 = int.TryParse(fourth, out fourthCast);
// Console.WriteLine($"TryParse result: {thirdCast + fourthCast}");

// int value = (int)1.5m; // casting truncates
// Console.WriteLine(value);

// int value2 = Convert.ToInt32(1.5m); // converting rounds up
// Console.WriteLine(value2);


//challenge 1
// string[] values = { "12,3", "45", "ABC", "11", "DEF" };
// string message = "";
// decimal total = 0m;

// foreach (var value in values)
// {   
//     decimal aux;
//     if (decimal.TryParse(value, out aux))
//     {
//         total += aux;
//     }
//     else
//     {
//         message += value.ToString();
//     }
// }


// Console.WriteLine($"Message:    {message}");
// Console.WriteLine($"Total:      {total}");

//challenge 2
int value1 = 12;
decimal value2 = 6.2m;
float value3 = 4.3f;

int result1 = value1 / (int)value2;
decimal result2 = value2 / (decimal)value3;
float result3 = value3 / value1;

Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");