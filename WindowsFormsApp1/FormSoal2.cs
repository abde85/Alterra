using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormSoal2 : Form
    {
        public FormSoal2()
        {
            InitializeComponent();
        }

        private void buttonProccess_Click(object sender, EventArgs e)
        {
            CheckDiagonalResult();
        }

        private void CheckDiagonalResult()
        {
            if (txtInput.Text.Trim() == "")
            {
                MessageBox.Show("Please input data");
            }
            else
            {
                var data = txtInput.Text.Split('\n');
                var rightData = RightDiagonalResult(data);
                var leftData = LeftDiagonalResult(data);
                var summaries = rightData + leftData;
                textBoxSummaries.Text = summaries.ToString();
            }
        }

        private int RightDiagonalResult(string[] data)
        {
            var data1 = new int[] { 1, 2, 3, 4 };
            var data2 = new int[] { 1, 2, 3, 4 };
            var data3 = new int[] { 1, 2, 3, 4 };
            var data4 = new int[] { 1, 2, 3, 4 };

            List<int[]> dataSummaries = new List<int[]>();
            dataSummaries.Add(data1);
            dataSummaries.Add(data2);
            dataSummaries.Add(data3);
            dataSummaries.Add(data4);

            var count = dataSummaries.Count;
            var rightResult = 0;
            var leftResult = 0;

            for (int i = 0; i < count - 1; i++)
            {
                var item = dataSummaries[i];
                var itemCount = item.Length;


            }

            //var data1 = data[0].Split(' ');
            //var data2 = data[1].Split(' ');
            //var data3 = data[2].Split(' ');

            //var result = Convert.ToInt32(data1[0]) + Convert.ToInt32(data2[1]) + Convert.ToInt32(data3[2]);
            //textBoxDiagonalkekanan.Text = result.ToString();

            return result;
        }

        private int LeftDiagonalResult(string[] data)
        {
            var data1 = data[0].Split(' ');
            var data2 = data[1].Split(' ');
            var data3 = data[2].Split(' ');

            var result = Convert.ToInt32(data1[2]) + Convert.ToInt32(data2[1]) + Convert.ToInt32(data3[0]);
            textBoxDiagonalKekiri.Text = result.ToString();

            return result;
        }

    }
}
