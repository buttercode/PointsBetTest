using System.Linq;

namespace PointsBetBackendOnlineCodeTest
{
    public class StringFormatter
    {
        public static string ToCommaSeparatedList(string[] items, string quote)
        {
			if(items == null)
				return string.Empty;
				
			return string.Join(", ", items.Select(x => quote + x + quote));
        }
    }
}