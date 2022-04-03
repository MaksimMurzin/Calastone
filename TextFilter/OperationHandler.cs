
using System.Linq;
/// <summary>
/// this is an experimental way to do this,
/// I took inspiration from Math class where it is a static class that does a bunch of stuff and it is static
/// Another way to do this would be to create an interface but I couldn't see the point of making an instance of this class
/// 
/// </summary>
public static class OperationHandler
{
 
    /// <summary>
    /// this will be the 
    /// </summary>
    /// <param name="wordCollection"> can be a collection of any words which will be provided by the DataReader</param>
    /// <param name="selector">A boolean pass function, I will attach the filters buth other functions can be used</param>
    /// <returns></returns>
    public static IEnumerable<string> FilterWordsWith(IEnumerable<string> wordCollection, Func<string, int, bool> selector, int i)
    {
        return wordCollection.Where(word => selector(word, i));
    }

    public static IEnumerable<string> FilterWordsWith(IEnumerable<string> wordCollection, Func<string, IEnumerable<char>, bool> selector, IEnumerable<char> offendingChars)
    {
        return wordCollection.Where(word => selector(word, offendingChars));
    }

    public static bool IsWordShorterThan(string word, int length) 
        => word.Length < length;

    public static bool IsWordLongerOrEqualTo(string word, int length) 
        =>word.Length >= length;

    public static bool DoesWordContainChar(string word, string offendingChar)
        => word.Contains(offendingChar);

    public static string GetMiddleChar(string word)
    {
        string middleChar;
        // if word has even amount letters grab the 2 chars in the middle
        if (word.Length % 2 == 0)
        {
            middleChar = word.Substring((word.Length - 1) / 2, 2);

        }
        // if word has odd amount of letters grab the middle one
        else
        {
            middleChar = word.Substring((int)Math.Ceiling((word.Length-1) / 2.0), 1);

        }
        return middleChar;
    }
    public static bool WordHasCharsInMiddle(string word, IEnumerable<char> offendingChars)
    {
        var middleChar = GetMiddleChar(word); 
        if (middleChar.Length > 1)
        {
            foreach(var letter in middleChar)
            {
                return offendingChars.Contains(letter);
            }
        }
        // we know that lenght of middleChar cannot be more than 1 at this point so just check against First element
        return offendingChars.Contains(middleChar.First());

        
        
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



// ===================== words > 3  =====================================
// this is a start, still need to remove things like punctuation from words
//var reducedWords = text.Split(' ').Where(word => word.Count() > 3);
//foreach (var word in reducedWords)
//{
//    Console.WriteLine(word);
//}


// ========================= words with T filter
//var wordsWithT = text.Split(' ').Where(word => word.Contains('t'));
//foreach (var word in wordsWithT)
//{
//    Console.WriteLine(word);
//}
