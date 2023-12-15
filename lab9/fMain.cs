using System.Windows.Forms;
using System;

namespace lb9
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double x1min = double.Parse(tbx1min.Text);
            double x1max = double.Parse(tbx1max.Text);
            double x2min = double.Parse(tbx2min.Text);
            double x2max = double.Parse(tbx2max.Text);
            double dx1 = double.Parse(tbdx1.Text);
            double dx2 = double.Parse(tbdx2.Text);

            gv.ColumnCount = (int)Math.Truncate((x2max - x2min) / dx2) + 2;
            gv.RowCount = (int)Math.Truncate((x1max - x1min) / dx1) + 2;

            //      
            for (int i = 0; i < gv.RowCount; i++)
                gv.Rows[i].HeaderCell.Value = (x1min + i * dx1).ToString("0.000");
            gv.RowHeadersWidth = 80;
            for (int i = 0; i < gv.ColumnCount; i++)
            {
                gv.Columns[i].HeaderCell.Value = (x2min + i *
               dx2).ToString("0.000");
                gv.Columns[i].Width = 60;
            }

            int cl, rw;
            double x1, x2, y;
            double[] sumColumn = new double[gv.ColumnCount];
            double[] sumRow = new double[gv.RowCount];

            rw = 0;
            x1 = x1min;
            double sumSin = 0;
            while (x1 <= x1max)
            {
                x2 = x2min;
                cl = 0;
                while (x2 <= x2max)
                {
                    y = Function(x1, x2);

                    if (Math.Sin(y) > 0)
                    {
                        sumSin += Math.Sin(y);
                    }
                    gv.Rows[rw].Cells[cl].Value = y.ToString("0.000");

                    sumColumn[cl] += y;
                    sumRow[rw] += y;

                    x2 += dx2;
                    cl++;
                }
                x1 += dx1;
                rw++;
            }
            for (int i = 0; i < gv.ColumnCount; i++)
            {
                gv.Rows[rw].Cells[i].Value = sumColumn[i].ToString("0.000");
            }

            for (int i = 0; i < gv.RowCount; i++)
            {
                gv.Rows[i].Cells[gv.ColumnCount - 1].Value = sumRow[i].ToString("0.000");
            }
            MessageBox.Show(" ' :" + sumSin);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbx1min.Text = "";
            tbx1max.Text = "";
            tbx2min.Text = "";
            tbx2max.Text = "";
            tbdx1.Text = "";
            tbdx2.Text = "";

            gv.Rows.Clear();
            for (int Cl = 0; Cl < gv.ColumnCount; Cl++)
                gv.Columns[Cl].HeaderCell.Value = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" ?", "  ",
 MessageBoxButtons.OKCancel, MessageBoxIcon.Question) ==
DialogResult.OK)
                Application.Exit();
        }

        private double Function(double x1, double x2)
        {
            return Math.Exp(x1 - Math.Pow(x2, 2)) + 31.55 * x2 * Math.Pow(x1, 2);
        }
    }
}