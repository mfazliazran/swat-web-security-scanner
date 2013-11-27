using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;

namespace AgWebScanner.Core.Scanner
{
	internal class Utils
	{
		public static void SortList< T >( List< T > dataSource, string fieldName, ListSortDirection sortDirection )
		{
			PropertyInfo propInfo = typeof( T ).GetProperty( fieldName );
			Comparison< T > compare = delegate( T a, T b )
				{
					bool asc = sortDirection == ListSortDirection.Ascending;
					object valueA = asc
					                	? propInfo.GetValue( a, null )
					                	: propInfo.GetValue( b, null );
					object valueB = asc
					                	? propInfo.GetValue( b, null )
					                	: propInfo.GetValue( a, null );

					return valueA is IComparable ? ( ( IComparable )valueA ).CompareTo( valueB ) : 0;
				};

			dataSource.Sort( compare );
		}
	}
}
