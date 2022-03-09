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
            DiagonalResult();
        }

        private void DiagonalResult()
        {
            var data1 = new int[] { 1, 2, 3, 4 };
            var data2 = new int[] { 2, 3, 4, 5 };
            var data3 = new int[] { 3, 4, 5, 6 };
            var data4 = new int[] { 4, 5, 6, 7 };

            List<int[]> dataSummaries = new List<int[]>();
            dataSummaries.Add(data1);
            dataSummaries.Add(data2);
            dataSummaries.Add(data3);
            dataSummaries.Add(data4);

            var count = dataSummaries.Count - 1;
            var rightResult = 0;
            var leftResult = 0;

            for (int i = 0; i < count; i++)
            {
                rightResult += dataSummaries[i][i];
                leftResult += dataSummaries[i][count - i];
            }

            textBoxDiagonalkekanan.Text = rightResult.ToString();
            textBoxDiagonalKekiri.Text = rightResult.ToString();
            textBoxSummaries.Text = (rightResult + leftResult).ToString();
        }

    }
}
