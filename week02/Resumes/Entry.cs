using System;

class Entry
{
    private string _date;
    private string _promptToUser;
    private string _userResponse;

    public Entry(string promptToUser, string userResponse)
    {
        _date = DateTime.Now.ToShortDateString();
        _promptToUser = promptToUser;
        _userResponse = userResponse;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptToUser}");
        Console.WriteLine(_userResponse);
        Console.WriteLine();
    }

    public string ToFileString()
    {
        return $"{_date}|{_promptToUser}|{_userResponse}";
    }

    public static Entry FromFileString(string line)
    {
        string[] parts = line.Split('|');
        if (parts.Length == 3)
        {
            Entry newEntry = new Entry(parts[1], parts[2]);
            newEntry._date = parts[0];
            return newEntry;
        }
        return null;
    }
}
