using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace WinFormsIntro
{
    public partial class InvoiceAppForm : Form
    {
        public InvoiceAppForm()
        {
            InitializeComponent();
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            var path = pathTextBox.Text;

            var content = File.ReadAllText(path);

            content = content.Replace(";", "\t");

            resultTextBox.Text = content;
        }

        private void categoryButton_Click(object sender, EventArgs e)
        {
            var path = pathTextBox.Text;

            var lines = File.ReadAllLines(path);

            var result = new Dictionary<string, decimal>();

            for (var i = 1; i < lines.Length; i++)
            {
                var line = lines[i];
                var split = line.Split(";");

                var price = decimal.Parse(split[1]);
                var category = split[2];

                if (result.ContainsKey(category))
                {
                    result[category] += price;
                }
                else
                {
                    result[category] = price;
                }
            }

            resultTextBox.Text = $"Category\tAmount{Environment.NewLine}";

            foreach (var item in result)
            {
                resultTextBox.Text += $"{item.Key}\t{item.Value}{Environment.NewLine}";
            }
        }
    }
}
