// string value = "abc123";
// char[] valueArray = value.ToCharArray();
// Array.Reverse(valueArray);

// string reverse = new string(valueArray);
// // Console.WriteLine(reverse);

// string result = String.Join("-", valueArray);
// Console.WriteLine(result);

// string[] items = result.Split('-');
// foreach (string item in items)
// {
//     Console.WriteLine(item);
// }

string pangram = "The quick brown fox jumps over the lazy dog";
string[] words = pangram.Split(" ");
string result = "";

foreach (string item in words)
{
    char[] valueItem = item.ToCharArray();
    Array.Reverse(valueItem);
    string word = String.Join("", valueItem);    
    result = result + String.Join("", word) + " ";
    
}

// Console.WriteLine(result);

string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] ids = orderStream.Split(",");
Array.Sort(ids);

foreach (string id in ids)
{   
    if (id.Length != 4)
    {
        Console.WriteLine(id + "\t- Error");
    } 
    else 
    {
        Console.WriteLine(id);
    }
    
}
