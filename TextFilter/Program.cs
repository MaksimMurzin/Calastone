using System.Reflection;
using System.Text.RegularExpressions;
using TextFilter;

// you can add more chars here which can be rejected
var charsToRemove = new string[] { "@", ",", ".", ";", "'","`",":", "(", ")" };
var vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Data\data_file.txt");


/// <summary>
/// this is still not perfect, there are some more edgecases 
/// that I could come up with but it would go beyond the scope of this project
/// </summary>
IDataReader dataReader = (SimpleFactory.GetDataReader(path, charsToRemove) as DataReader);
var data = dataReader.GetData().ToList();
//foreach(var word in data)
//{
//    Console.WriteLine(word);
//}


// this is an example of how to use the OperationHandler, swap out the delegate for the other functions I made or add your own
//var filteredWords = OperationHandler.FilterWordsWith(data, OperationHandler.IsWordLongerOrEqualTo, 4).ToList();

//foreach(var word in filteredWords)
//{
//    Console.WriteLine(word);
//}


//var data = "get out again.The rabbit hole".Split(' ');

//var test = (dataReader as DataReader).EdgeCaseProblem(data);
// ======== edge case ===============================
// words where there is a dot without a space throw an error

//using (StreamWriter sw = new StreamWriter("correctedText.txt"))
//{
//    foreach (var word in test)
//    {
//        sw.Write(word+ " ");
//    }
//}






