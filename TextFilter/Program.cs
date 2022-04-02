using System.Reflection;

// will get rid of all these characters, wasn't sure about the apostrophes but decided to get rid of them too
var charsToRemove = new string[] { "@", ",", ".", ";", "'","`",":" };
var vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Data\test_file.txt");


IDataReader dataReader = new DataReader(path, charsToRemove);

var data = dataReader.GetData();

//Console.WriteLine(OperationHandler.isWordLessThan("hello", 3));

var filteredWords = OperationHandler.FilterWordsWith(data, OperationHandler.IsWordShorterThan,3 );
foreach(var word in filteredWords)
{
    Console.WriteLine(word);
}

//var filteredWords = OperationHandler.GetMiddleChar("what");
//var filteredWords = OperationHandler.GetMiddleChar("currently");
//Console.WriteLine(filteredWords);




//foreach(var word in data)
//{
//    Console.WriteLine(word);
//}





// ======== edge case ===============================
// words where there is a dot without a space throw an error

//using (StreamWriter sw = new StreamWriter("correctedText.txt"))
//{
//    foreach (var word in text.ToString())
//    {
//        sw.Write(word);
//    }
//}


