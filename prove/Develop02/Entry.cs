using System;

class Entry
{
    public string _date, _prompt, _response;

    public Entry(string prompt, string response)
    {
        _date = DateTime.Now.ToString("MMM dd yyyy");
        _prompt = prompt;
        _response = response;


    }
    public Entry(string prompt, string response, string date)
    {
        _date = date;
        _prompt = prompt;
        _response = response;


    }

    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Entry: {_response}");
    }

    public string getEntryAsCSV()
    {
        return string.Format("{0}|{1}|{2}", _date, _prompt, _response);
    }
}