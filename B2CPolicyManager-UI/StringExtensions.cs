using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2CPolicyManager
{
	internal static class StringExtensions
	{
		public static bool ContainsEx( this string source, string toCheck, StringComparison comp = StringComparison.OrdinalIgnoreCase )
		{
			return source?.IndexOf( toCheck, comp ) >= 0;
		}
	}
}
