using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StonehearthEditor.subViews
{
   public partial class NameValueInputView : UserControl
   {
      public NameValueInputView()
      {
         InitializeComponent();
      }

      public NameValueInputView(string name)
      {
         setName(nameLabel, name);
      }

      public string NameLabel
      {
         get { return nameLabel.Text; }
         set { setName(nameLabel, value); }
      }
      public TextBox InputTextBox
      {
         get { return inputTextBox;  }
      }

      private void setName(Control control, string value)
      {
         control.Name = value;
         control.Text = value;
      }
   }
}
