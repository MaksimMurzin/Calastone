using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFilter
{
    /// <summary>
    /// I could use the DI container but that would involve using IHostBuilder which seems like unnecessary overhead for something this simple
    /// </summary>
    public static class SimpleFactory
    {
        public static IDataReader GetDataReader(string path, IEnumerable<string> charsToRemove)
        {
            return (new DataReader(path, charsToRemove) as DataReader);
        }

    }
}
