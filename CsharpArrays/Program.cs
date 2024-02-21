// Code challenge

string[] ids = [
    "B123",
    "C234",
    "A345",
    "C15",
    "B177",
    "G3003",
    "C235",
    "B179"
];

foreach (string id in ids)
{
    if (id.ToLower().StartsWith('b'))
    {
        Console.WriteLine(id);
    }
}