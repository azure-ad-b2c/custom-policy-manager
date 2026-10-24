using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B2CPolicyManagerUI
{
	public class TextBoxLogger
		: ActionLogger
	{
		public TextBoxLogger( TextBox txtBox )
			: base( ( msg ) => txtBox.AppendText( msg + Environment.NewLine ) )
		{
		}
	}
}
