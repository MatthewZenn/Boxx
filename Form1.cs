namespace Boxx
{
    public partial class BoxxWindow : Form
    {
        public BoxxWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(richTextBox1.Text, titleBox.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }
    }
}