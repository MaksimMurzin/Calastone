public class DataReader : IDataReader
{
    private string Data { get; set; }
    // we may alter the chars we want to remove so it's best to keep it as public prop
    public IEnumerable<string> CharsToRemove { get; set; }

    public DataReader(string filepath, IEnumerable<string> charsToRemove)
    {
        // this actually calls StreamReader internally so I don't have to deal with it
        Data = System.IO.File.ReadAllText(filepath);
        CharsToRemove = charsToRemove;
    }

    /// <summary>
    /// This is for the edge cases where there are 2 words separated by a dot
    /// This will return a new list of data rather than mutate the property
    /// as I feel that this should be an optional function based on circumstances
    /// </summary>
    public IEnumerable<string> EdgeCaseProblem(IEnumerable<string> data)
    {
        
        var correctedWords = new List<string>();
        foreach (var item in data)
        {
            if (!item.Contains('.'))
            {
                correctedWords.Add(item);
                continue;
            }
            correctedWords.AddRange(item.ToString().Split('.').ToList());

        }
        return correctedWords;

    }
    public void CleanData()
    {
        foreach (var c in CharsToRemove)
        {
            Data = Data.Replace(c, string.Empty);
        }

    }
    public IEnumerable<string> GetData()
    {
        CleanData();
        return EdgeCaseProblem(Data.Split(' '));
        
    }
}






