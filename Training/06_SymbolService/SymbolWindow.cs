using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Scada.AddIn.Contracts;
using Scada.AddIn.Contracts.ScreenElement;

namespace _06_SymbolService
{
    public partial class SymbolWindow : Form
    {
        IScreenElement  mySymbol;
        public SymbolWindow()
        {
            InitializeComponent();
        }
        public SymbolWindow(IScreenElement symbol)
        {
            mySymbol = symbol;
            InitializeComponent();
        }



        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Apply;
        private System.Windows.Forms.TextBox Linking;
        private System.Windows.Forms.TextBox Right;
        private System.Windows.Forms.TextBox Left;
        private System.Windows.Forms.TextBox Downing;
        private System.Windows.Forms.Label Down;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Link;
        private System.Windows.Forms.Label TOP;
        private System.Windows.Forms.TextBox Top2;

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            mySymbol.Top = Int32.Parse(this.Top2.Text);
            mySymbol.Left = Int32.Parse(this.Left.Text);
            mySymbol.Right = Int32.Parse(this.Right.Text);
            mySymbol.Link = Int32.Parse(this.Linking.Text);
            mySymbol.Downing = Int32.Parse(this.Downing.Text);
        }

        private void Apply_Click(object sender, EventArgs e)
        {

        }

        private void Cancel_Click(object sender, EventArgs e)
        {

        }

        private void Link_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
