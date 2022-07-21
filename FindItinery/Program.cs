// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Dictionary<string, string> dict = new Dictionary<string, string>();
dict.Add("Chennai", "Banglore");
dict.Add("Bombay", "Delhi");
dict.Add("Goa", "Chennai");
dict.Add("Delhi", "Goa");
Dictionary<string, string> itn = new Dictionary<string, string>();
KeyValuePair<string, string> start = new KeyValuePair<string, string>();
foreach(var pair in dict)
{
    if (!dict.ContainsValue(pair.Key))
    {
        start = pair;
    }
}

var foundDest = false;
var current = start;
itn.Add(current.Key, current.Value);
while (foundDest != true)
{
    if (!dict.ContainsKey(current.Value))
    {
        foundDest = true;
    }
    else
    {
       current = dict.Where(c => c.Key == current.Value).First();
        itn.Add(current.Key, current.Value);
    }
}

foreach (var pair in itn)
{
    Console.WriteLine(pair.Key + "->" + pair.Value);
}