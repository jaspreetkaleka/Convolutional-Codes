using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Convolutional_Codes
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        bool Validated_knK;
        bool Validated_Gx;

        PolyNomial U;
        List<PolyNomial> gX;

        int k, n, K;

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            //PolyNomial mX = new PolyNomial(k_TextBox.Text);
            //PolyNomial g1X = new PolyNomial(G1_TextBox.Text);
            //PolyNomial g2X = new PolyNomial(G2_TextBox.Text);

            //PolyNomial mXg1X = mX.Multiply(g1X);
            //PolyNomial mXg2X = mX.Multiply(g2X);
        }

        #region "Validations"

        private string Validate_knK()
        {
            try
            {
                Validated_knK = false;

                if (k_TextBox.Text == "")
                {
                    return "Error - Invalid value of 'k'";
                }
                else if (n_TextBox.Text == "")
                {
                    return "Error - Invalid value of 'n'";
                }
                else if (K_CL_TextBox.Text == "")
                {
                    return "Error - Invalid value of 'K'";
                }
                else
                {
                    k = Convert.ToInt32(k_TextBox.Text);
                    n = Convert.ToInt32(n_TextBox.Text);
                    K = Convert.ToInt32(K_CL_TextBox.Text);
                }

                Validated_knK = true;
                return "No Error";
            }
            catch (Exception ex)
            {
                return "Error - " + ex.Message;
            }
        }

        private string Validate_Gx()
        {
            try
            {
                gX = null;
                U = null;

                Validated_Gx = false;

                foreach (DataGridViewRow row in gXDataGridView.Rows)
                {
                    string s = row.Cells[1].Value.ToString().Replace(" ", "");
                    s = s.Replace("X+", "+").Replace("+X", "");

                    if (s.Contains("X"))
                    {
                        mainErrorProvider.SetError(gXDataGridView, "Error - Invalid characters found.");
                        return "Error - Invalid characters found.";
                    }

                    for (int i = 0; i < 10; i++)
                    {
                        s = s.Replace(i.ToString(), "");
                    }

                    s = s.Replace("+", "");

                    if (s.Length != 0)
                    {
                        mainErrorProvider.SetError(gXDataGridView, "Error - Invalid characters found.");
                        return "Error - Invalid characters found.";
                    }
                }

                SetGx();
                mainErrorProvider.Clear();
                Validated_Gx = true;
                return "No Error";
            }
            catch (Exception ex)
            {
                mainErrorProvider.SetError(gXDataGridView, "Error - " + ex.Message);
                return "Error - " + ex.Message;
            }
        }

        #endregion

        #region "Inputs <n, k, Gx>

        private void knK_TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue > 57 || e.KeyValue == 32)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void k_TextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                k = Convert.ToInt32(k_TextBox.Text);
                mainErrorProvider.Clear();
            }
            catch
            {
                mainErrorProvider.SetError(k_TextBox, "Error - Invalid value of 'k'");
            }
        }

        private void n_TextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                n = Convert.ToInt32(n_TextBox.Text);
                mainErrorProvider.Clear();
                UpdateGXDataGridView();
            }
            catch
            {
                mainErrorProvider.SetError(n_TextBox, "Error - Invalid value of 'n'");
            }
        }

        private void K_CL_TextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                K = Convert.ToInt32(K_CL_TextBox.Text);
                mainErrorProvider.Clear();
            }
            catch
            {
                mainErrorProvider.SetError(K_CL_TextBox, "Error - Invalid value of 'K'");
            }
        }

        private void UpdateGXDataGridView()
        {
            int rowCount = gXDataGridView.Rows.Count;
            if (rowCount < n)
            {
                for (int i = 0; i < n - rowCount; i++)
                {
                    gXDataGridView.Rows.Add();
                }
            }
            else if (gXDataGridView.Rows.Count > n)
            {
                for (int i = rowCount - 1; i >= n; i--)
                {
                    gXDataGridView.Rows.RemoveAt(i);
                }
            }

            rowCount = gXDataGridView.Rows.Count;

            for (int i = 0; i < rowCount; i++)
            {
                gXDataGridView.Rows[i].Cells[0].Value = "g" + (i + 1);
            }
        }

        private void gXDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                try
                {
                    gXDataGridView.Rows[e.RowIndex].Cells[1].Value =
                        ApplyPolyFormat(gXDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString());
                }
                catch
                {
                }
            }
        }

        private void SetGx()
        {
            gX = new List<PolyNomial>();
            foreach (DataGridViewRow row in gXDataGridView.Rows)
            {
                gX.Add(new PolyNomial(row.Cells[1].Value.ToString().Replace(" ", "")));
            }
        }

        #endregion

        #region "Error Detection"

        private void detectErrorButton_Click(object sender, EventArgs e)
        {
            if (!r_ED_TextBox.Text.Contains("X"))
            {
                r_ED_TextBox.Text = r_ED_TextBox.Text.Replace(" ", "");
                if (r_ED_TextBox.Text.Length > n)
                {
                    mainErrorProvider.SetError(r_ED_TextBox,
                        "Length of the received Vector <r> is greator than the length of the codeword.");
                    return;
                }
                else if (r_ED_TextBox.Text.Length < n)
                {
                    mainErrorProvider.SetError(r_ED_TextBox,
                        "Length of the received Vector <r> is less than the length of the codeword.");
                    return;
                }
                else
                {
                    mainErrorProvider.Clear();
                }
            }

            PolyNomial r = new PolyNomial(r_ED_TextBox.Text);
            PolyNomial SX = null; // r.Remainder(gX);
            if (r_ED_TextBox.Text.Contains("X"))
            {
                S_ED_TextBox.Text = SX.ToPolynomialString();
            }
            else
            {
                S_ED_TextBox.Text = SX.ToBinaryString().PadRight(n - k, '0');
            }

            if (SX.IsAllZero)
            {
                S_ED_TextBox.Text = "0";
                S_ED_Label.Text = "No Error. The received vector <r> is a valid codeword.";
                S_ED_Label.ForeColor = Color.Green;
            }
            else
            {
                S_ED_Label.Text = "Error. The received vector <r> is not a valid codeword.";
                S_ED_Label.ForeColor = Color.Red;
            }
        }

        private void ror_ED_Button_Click(object sender, EventArgs e)
        {
            try
            {
                if (r_ED_TextBox.Text.Contains("X"))
                {
                    PolyNomial r = new PolyNomial(r_ED_TextBox.Text);
                    string rS = r.ToBinaryString().PadRight(n, '0');
                    rS = rS.Last() + rS.Substring(0, rS.Length - 1);
                    r_ED_TextBox.Text = ApplyPolyFormat((new PolyNomial(rS).ToPolynomialString()));
                }
                else
                {
                    r_ED_TextBox.Text = r_ED_TextBox.Text.Replace(" ", "");
                    r_ED_TextBox.Text = r_ED_TextBox.Text.Last() +
                                        r_ED_TextBox.Text.Substring(0, r_ED_TextBox.Text.Length - 1);
                }

                detectErrorButton.PerformClick();
            }
            catch
            {
            }
        }

        private void rol_ED_Button_Click(object sender, EventArgs e)
        {
            try
            {
                if (r_ED_TextBox.Text.Contains("X"))
                {
                    PolyNomial r = new PolyNomial(r_ED_TextBox.Text);
                    string rS = r.ToBinaryString().PadRight(n, '0');
                    rS = rS.Substring(1, rS.Length - 1) + rS.First();
                    r_ED_TextBox.Text = ApplyPolyFormat(new PolyNomial(rS).ToPolynomialString());
                }
                else
                {
                    r_ED_TextBox.Text = r_ED_TextBox.Text.Replace(" ", "");
                    r_ED_TextBox.Text = r_ED_TextBox.Text.Substring(1, r_ED_TextBox.Text.Length - 1) +
                                        r_ED_TextBox.Text.First();
                }

                detectErrorButton.PerformClick();
            }
            catch
            {
            }
        }

        private void r_ED_TextBox_Leave(object sender, EventArgs e)
        {
            if (r_ED_TextBox.Text.Contains("X"))
            {
                r_ED_TextBox.Text = ApplyPolyFormat(r_ED_TextBox.Text);
            }

            detectErrorButton.PerformClick();
        }

        private void r_ED_TextBox_TextChanged(object sender, EventArgs e)
        {
            S_ED_TextBox.Clear();
            S_ED_Label.Text = "";
        }

        #endregion

        #region "Error Correction"

        private void correctErrorButton_Click(object sender, EventArgs e)
        {
            if (!r_EC_TextBox.Text.Contains("X"))
            {
                r_EC_TextBox.Text = r_EC_TextBox.Text.Replace(" ", "");
                if (r_EC_TextBox.Text.Length > n)
                {
                    mainErrorProvider.SetError(r_EC_TextBox,
                        "Length of the received Vector <r> is greater than the length of the codeword.");
                    return;
                }
                else if (r_EC_TextBox.Text.Length < n)
                {
                    mainErrorProvider.SetError(r_EC_TextBox,
                        "Length of the received Vector <r> is less than the length of the codeword.");
                    return;
                }
                else
                {
                    mainErrorProvider.Clear();
                }
            }

            PolyNomial r = new PolyNomial(r_EC_TextBox.Text);
            PolyNomial SX = null; // r.Remainder(gX);

            if (r_EC_TextBox.Text.Contains("X"))
            {
                S_EC_TextBox.Text = SX.ToPolynomialString();
            }
            else
            {
                S_EC_TextBox.Text = SX.ToBinaryString().PadRight(n - k, '0');
            }

            if (SX.IsAllZero)
            {
                S_EC_TextBox.Text = "0".PadRight(n - k, '0');
                U_EC_TextBox.Text = r_EC_TextBox.Text;
            }
            else
            {
                SX = SX.LeftShift(n - SX.Length);
                PolyNomial eUX = r.AddWithoutCarry(SX);

                if (r_EC_TextBox.Text.Contains("X"))
                {
                    U_EC_TextBox.Text = eUX.LeftShift(n - eUX.Length).ToPolynomialString();
                }
                else
                {
                    U_EC_TextBox.Text = eUX.LeftShift(n - eUX.Length).ToBinaryString();
                }

                if (U_EC_TextBox.Text == "")
                {
                    U_EC_TextBox.Text = "0".PadRight(n, '0');
                }
            }
        }

        private void r_EC_TextBox_Leave(object sender, EventArgs e)
        {
            correctErrorButton.PerformClick();
        }

        private void r_EC_TextBox_TextChanged(object sender, EventArgs e)
        {
            S_EC_TextBox.Clear();
            U_EC_TextBox.Clear();
        }

        #endregion

        private void mainTabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            #region "Code Words"

            if (e.TabPageIndex == 1)
            {
                Validate_knK();
                Validate_Gx();

                if (Validated_Gx && Validated_knK)
                {
                    if (gX == null)
                    {
                        SetGx();
                    }

                    if (U == null)
                    {
                        int totalCodewords = Convert.ToInt32(Math.Pow(2, k));
                        U = new PolyNomial(totalCodewords);

                        int codeWordMaxLength = n * ((K - 1) * (k - 1) + 1);


                        StringBuilder sb = new StringBuilder();

                        for (int m = 0; m < totalCodewords; m++)
                        {
                            string mBinary = Convert.ToString(m, 2).PadLeft(k, '0');
                            sb.Append(Environment.NewLine + mBinary + "—————— ");

                            PolyNomial mX = new PolyNomial(mBinary);
                            List<PolyNomial> mXgX = new List<PolyNomial>();
                            foreach (PolyNomial pX in gX)
                            {
                                mXgX.Add(mX.Multiply(pX));
                            }

                            int len = mXgX[0].Length;
                            string str = "";

                            for (int i = 0; i < len; i++)
                            {
                                foreach (PolyNomial p in mXgX)
                                {
                                    str = str + p[i].ToString();
                                }
                            }

                            sb.Append(str.PadRight(codeWordMaxLength, '0'));
                        }

                        U_TextBox.Text = ApplyBinaryFormat(sb.ToString());
                        U_TextBox.SelectAll();
                        U_TextBox.SelectionAlignment = HorizontalAlignment.Center;
                        U_TextBox.DeselectAll();
                    }
                }
                else
                {
                    mainTabControl.SelectedIndex = 0;
                    MessageBox.Show("Enter valid inputs for 'k', 'n', 'K' and 'g(X)' first.", "Error!!!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            #endregion

            #region "Error Detection & Correction"

            else if (e.TabPageIndex == 2 || e.TabPageIndex == 3)
            {
                if (Validated_Gx && Validated_knK)
                {
                    if (gX == null)
                    {
                        //gX = new PolyNomial(G_Input_TextBox.Text);
                    }
                }
                else
                {
                    mainTabControl.SelectedIndex = 0;
                    MessageBox.Show("Enter valid inputs for 'k', 'n', 'K' and 'g(X)' first.", "Error!!!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            #endregion
        }

        public string ApplyBinaryFormat(string s)
        {
            s = s.Replace(" ", "");
            s = s.Trim(new char[] {'\n', '\r'});
            s = s.Replace("1", "1  ");
            s = s.Replace("0", "0  ");
            s = s.Replace("—", "—  ");
            return s;
        }

        public string ApplyPolyFormat(string s)
        {
            s = s.Replace("x", " X ");
            s = s.Replace(" ", "");
            s = s.Trim(new char[] {'\n', '\r'});
            s = s.Replace("+", " + ");
            s = s.Trim();
            return s;
        }
    }
}