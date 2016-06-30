using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomTextBoxTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var searchIndex = new Dictionary<string, string>();
            searchIndex.Add("hall-o", "hai");
            searchIndex.Add("da'sdas", "hai");
            searchIndex.Add("hal dasdlo", "hai");
            searchIndex.Add("ha;ld as dalo", "hai");
            searchIndex.Add("halsdalo", "hai");
            searchIndex.Add("hadasallo", "hai");
            searchIndex.Add("hdallo", "hai");
            searchIndex.Add("hsdaallo", "hai");
            searchIndex.Add("hasallo", "hai");
            searchIndex.Add("hasdallo", "hai");
            searchIndex.Add("haallo", "hai");
            searchIndex.Add("hsallo", "hai");
            searchIndex.Add("hdasdallo", "hai");
            searchIndex.Add("haadallo", "hai");
            searchIndex.Add("hadsdallo", "hai");
            searchIndex.Add("hdaaallo", "hai");
            searchIndex.Add("hdadasdasdllo", "hai");
            searchIndex.Add("dadsads", "hai");
            customAutoCompleteTextBox1.UsedAutoCompleteMode = CustomAutoCompleteTextBox.AutoCompleteMode.Index;
            customAutoCompleteTextBox1.FuzzyAutoCompleteSource = searchIndex.Keys.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("RIP");
        }
    }
}
