using System.Net.Security;
using System.Diagnostics;
using System.Drawing.Text;
using System;

namespace Boxx
{
    public partial class BoxxWindow : Form
    {
        public BoxxWindow()
        {
            InitializeComponent();
            comboBox2.Items.Add("OK");
            comboBox2.Items.Add("OKCancel");
            comboBox2.Items.Add("YesNo");
            comboBox2.Items.Add("YesNoCancel");
            comboBox2.Items.Add("RetryCancel");
            comboBox2.SelectedIndex = 0;

            comboBox1.Items.Add("Warning");
            comboBox1.Items.Add("Error");
            comboBox1.Items.Add("Information");
            comboBox1.Items.Add("Question");
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var MessageIcon = comboBox1.SelectedIndex;
            var MessageButton = comboBox2.SelectedIndex;
            var command = textBox1.Text;

            var msgicon = MessageBoxIcon.Warning;
            var msgbtn = MessageBoxButtons.OK;

            if (MessageIcon == 0)
            {
                msgicon = MessageBoxIcon.Warning;
            }
            else if (MessageIcon == 1)
            {
                msgicon = MessageBoxIcon.Error;
            }
            else if (MessageIcon == 2)
            {
                msgicon = MessageBoxIcon.Information;
            }
            else if (MessageIcon == 3)
            {
                msgicon = MessageBoxIcon.Question;
            }

            if (MessageButton == 0)
            {
                msgbtn = MessageBoxButtons.OK;
            }
            else if (MessageButton == 1)
            {
                msgbtn = MessageBoxButtons.OKCancel;
            }
            else if (MessageButton == 2)
            {
                msgbtn = MessageBoxButtons.YesNo;
            }
            else if (MessageButton == 3)
            {
                msgbtn = MessageBoxButtons.YesNoCancel;
            }
            else if (MessageButton == 4)
            {
                msgbtn = MessageBoxButtons.RetryCancel;
            }

            this.Visible = false;
            MessageBox.Show(richTextBox1.Text, titleBox.Text, msgbtn, msgicon);

            if (textBox1.Text != "" && checkBox1.Checked == true)
            {
                var psi = new ProcessStartInfo
                {
                    UseShellExecute = true,
                    FileName = command
                };
                Process.Start(psi);
                this.Visible = true;
            }
            else if (textBox1.Text != "")
            {
                var psi = new ProcessStartInfo
                {
                    UseShellExecute = true,
                    FileName = command
                };
                Process.Start(psi);
                Application.Exit();
            }
            else if (checkBox1.Checked == true)
            {
                this.Visible = true;
            }
            else
            {
                Application.Exit();
            }
        }
    }
}