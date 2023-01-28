
// Entry class to store a single entry's data
class Entry
{
    private string prompt;
    private string response;
    private DateTime date;

    public Entry(string prompt, string response)
    {
        this.prompt = prompt;
        this.response = response;
        date = DateTime.Now;
    }

    public void Display()
    {
        Console.WriteLine("Prompt: " + prompt);
        Console.WriteLine("Response: " + response);
        Console.WriteLine("Date: " + date);
    }

    public override string ToString()
    {
        return prompt + "," + response + "," + date;
    }

    public static Entry FromString(string line)
    {
        string[] parts = line.Split(',');
        return new Entry(parts[0], parts[1]);
    }
}
