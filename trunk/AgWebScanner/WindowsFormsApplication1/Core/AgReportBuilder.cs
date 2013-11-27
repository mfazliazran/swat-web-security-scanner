using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using AgWebScanner.Core.Scanner;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace AgWebScanner.Core
{
	public class AgReportBuilder
	{
		public void CreateDocument( List< ScanDetails > info, string path )
		{
			var doc = new Document( PageSize.A4 );
			PdfWriter.GetInstance( doc, new FileStream( path, FileMode.Create ) );

			doc.Open();
			doc.Add( new Paragraph() );

			PdfPTable table = new PdfPTable( 4 ) { WidthPercentage = 100 };
			//header
			PdfPCell cell = new PdfPCell { BackgroundColor = BaseColor.LIGHT_GRAY, Phrase = new Phrase( "URL" ) };
			table.AddCell( cell );

			cell.Phrase = new Phrase( "Response" );
			table.AddCell( cell );

			cell.Phrase = new Phrase( "Size" );
			table.AddCell( cell );

			cell.Phrase = new Phrase( "Page Title" );
			table.AddCell( cell );

			//rows
			foreach( var item in info )
			{
				table.AddCell( item.Url.ToString() );
				table.AddCell( item.Response );
				table.AddCell( item.Size.ToString() );
				table.AddCell( item.PageTitle );
			}

			doc.Add( table );

			doc.Close();
		}

		public string GetResultForTextExport( List< ScanDetails > scanDetails )
		{
			var result = new StringBuilder();

			foreach( var item in scanDetails )
			{
				result.Append( String.Format( "{0}{1}{2}{3}{4}{5}{6}{7}", item.Url, '\t', item.Response, '\t',
				                              item.Size, 't', item.PageTitle, '\n' ) );
			}

			return result.ToString();
		}
	}
}
