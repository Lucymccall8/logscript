using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogScript
{
    public partial class Form1 : Form
    {

        string FilePath;
        Splitter splitterclass = new Splitter();
        
        public Form1()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string log = System.IO.File.ReadAllText(@FilePath);
            splitterclass.runProgram(log);
            addips();
        }



        public void addips()
        {
            var ips = splitterclass.iplist.Distinct().ToArray();
            this.lbIP.Items.Clear();

            foreach (var item in ips)
            {
                this.lbIP.Items.Add(item);
            }
        }

        private void browse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FilePath = openFileDialog.FileName;
                    tbfilename.Text = FilePath;
                    tbfilename.Refresh();
                    tbfilename.Text.Equals(FilePath);
                }
            }
        }

        private void btcopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(string.Join(Environment.NewLine, lbIP.Items.OfType<string>()));
        }
    }
}
