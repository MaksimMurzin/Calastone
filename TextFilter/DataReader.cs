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
        return Data.Split(' ');
        
    }
}

// ======== edge case ===============================
// words where there is a dot without a space throw an error

//using (StreamWriter sw = new StreamWriter("correctedText.txt"))
//{
//    foreach (var word in text.ToString())
//    {
//        sw.Write(word);
//    }
//}




