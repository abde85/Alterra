using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormSoal1 : Form
    {
        public FormSoal1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private bool CheckValidatePhrase(string phrase)
        {
            var result = true;

            char[] param = phrase.ToCharArray();
            var count = param.Length - 1;

            for (int i = count; i >= 0; i--)
            {
                var sub1 = param[i].ToString();
                var sub2 = param[count - i].ToString();
                if (sub1 != sub2)
                {
                    return false;
                }
            }

            return result;
        }

        private void btnCheckValidate_Click(object sender, EventArgs e)
        {
            if (textBoxInput.Text.Length == 0)
            {
                MessageBox.Show("Please input text");
            }
            else
            {
                textBoxOutput.Text = CheckValidatePhrase(textBoxInput.Text.ToLower()).ToString();
            }

        }
    }
}
