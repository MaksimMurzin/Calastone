using System.Reflection;
using System.Text.RegularExpressions;
using TextFilter;

var charsToRemove = new string[] { "@", ",", ".", ";", "'","`",":" };
var vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Data\data_file.txt");


IDataReader dataReader = (SimpleFactory.GetDataReader(path, charsToRemove) as DataReader);




var data = "get out again.The rabbit hole".Split(' ');

var test = (dataReader as DataReader).EdgeCaseProblem(data);
// ======== edge case ===============================
// words where there is a dot without a space throw an error

//using (StreamWriter sw = new StreamWriter("correctedText.txt"))
//{
//    foreach (var word in test)
//    {
//        sw.Write(word+ " ");
//    }
//}






