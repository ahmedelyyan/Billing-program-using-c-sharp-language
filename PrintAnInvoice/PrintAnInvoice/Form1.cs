using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintAnInvoice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.facebook.com/ahmad.althwaherh");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true; 
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            comboBoxType.Select();
        }

        private void comboBoxType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtPrise.Select();
                txtPrise.SelectAll();
            }
        }

        private void comboBoxType_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            txtPrise.Select();
            txtPrise.SelectAll();
        }

        private void txtPrise_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtQuntety.Select();
                txtQuntety.SelectAll();
            }
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPrise.Text = comboBoxType.SelectedValue.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
                if (comboBoxType.SelectedIndex <= -1) return;
                txtPrise.Text = comboBoxType.SelectedValue.ToString();
                String item = comboBoxType.Text;
                int quntety = Convert.ToInt32(txtQuntety.Text);
                int price = Convert.ToInt32(txtPrise.Text);
                int subTotal = quntety * price;
                txtTotal.Text = (Convert.ToInt32(txtTotal.Text) + subTotal) + "";
                Object[] row = { item, quntety, price, subTotal };
                dgvInvioseIteam.Rows.Add(row);
        }

        private void txtPrise_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtPrise_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtQuntety_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtQuntety_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnAdd.PerformClick();
                txtUserName.Select();
                txtUserName.SelectAll();
            }
        }

        private void dgvInvioseIteam_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            ((Form)printPreviewDialog1).WindowState = FormWindowState.Maximized;
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float marige = 40;
            Font f = new Font("arial",18, FontStyle.Bold);
            Font ff = new Font("arial", 13, FontStyle.Bold);
            Font fff = new Font("arial", 22, FontStyle.Bold);
            SizeF sizeFont1 = e.Graphics.MeasureString("طباعة الفاتوره رقم :" + txtInvoiseNumber.Text,f);

            string date = "التاريخ :" + txtDate.Text;
            string userName = "مطلوب من السيد :" + txtUserName.Text;

            SizeF sizeFont2 = e.Graphics.MeasureString(date , f);
            SizeF sizeFont3 = e.Graphics.MeasureString(userName , f);

            Bitmap img = new Bitmap(Properties.Resources.bill);

            float rectSize = e.PageBounds.Width - (marige * 2);
            e.Graphics.DrawString("برمجة احمد الظواهره",ff,Brushes.DarkRed,marige,marige-20);
            e.Graphics.DrawImage(Properties.Resources.bill,marige+5,marige+5,120,120);
            e.Graphics.DrawString("طباعة الفاتوره رقم : #" + txtInvoiseNumber.Text,f,Brushes.Red,(e.PageBounds.Width - sizeFont1.Width)/2,marige-10);
            e.Graphics.DrawString(date,f,Brushes.Black,e.PageBounds.Width - sizeFont2.Width - marige , marige+10);
            e.Graphics.DrawString(userName,f,Brushes.Black,e.PageBounds.Width - sizeFont3.Width - marige,marige + sizeFont2.Height+10);
            e.Graphics.DrawRectangle(Pens.Black,marige,marige+135,e.PageBounds.Width-(marige*2),e.PageBounds.Height-(marige*2));
            e.Graphics.DrawLine(Pens.Black,marige+(rectSize/4) ,marige+135, marige + (rectSize / 4), e.PageBounds.Height);
            e.Graphics.DrawLine(Pens.Black, marige + ((rectSize / 4)*2), marige + 135, marige + ((rectSize / 4) * 2), e.PageBounds.Height);
            e.Graphics.DrawLine(Pens.Black, marige + ((rectSize / 4) * 3)-100, marige + 135, marige + ((rectSize / 4) * 3)-100, e.PageBounds.Height);

            e.Graphics.DrawLine(Pens.Black, marige, marige + 175,e.PageBounds.Width-(marige) , marige + 175);

            float cellHighpt = 0;
            float cellWidth = 0;
            e.Graphics.DrawString("الاجمالي الفرعي",f,Brushes.Black,marige + 20, ((marige*2) + (rectSize / 4)/2) + 10);
            e.Graphics.DrawString("سعر الوحده", f, Brushes.Black, marige + 20 + ((rectSize / 4)) +10, ((marige * 2) + (rectSize / 4) / 2) + 10);
            e.Graphics.DrawString("الكميه", f, Brushes.Black, marige + 20 + ((rectSize / 4)*2)+10, ((marige * 2) + (rectSize / 4) / 2) + 10);
            e.Graphics.DrawString("الصنف", f, Brushes.Black, marige + 20 + ((rectSize / 4)*3)+10, ((marige * 2) + (rectSize / 4) / 2) + 10);

            ///////////////print rows data
            int rowsHigtht = 40;
            for (int i = 0; i < dgvInvioseIteam.Rows.Count; i++)
            {
                e.Graphics.DrawString(dgvInvioseIteam.Rows[i].Cells[3].Value.ToString(), ff, Brushes.Black, marige + 20 , ((marige * 2) + (rectSize / 4) / 2) + 10 + rowsHigtht);
                e.Graphics.DrawString(dgvInvioseIteam.Rows[i].Cells[2].Value.ToString(), ff, Brushes.Black, marige + 20 + ((rectSize / 4)) + 10, ((marige * 2) + (rectSize / 4) / 2) + 10 + rowsHigtht);
                e.Graphics.DrawString(dgvInvioseIteam.Rows[i].Cells[1].Value.ToString(), ff, Brushes.Black, marige + 20 + ((rectSize / 4) * 2) + 10, ((marige * 2) + (rectSize / 4) / 2) + 10 + rowsHigtht);
                e.Graphics.DrawString(dgvInvioseIteam.Rows[i].Cells[0].Value.ToString(), ff, Brushes.Black, marige + 20 + ((rectSize / 4) * 3) - 110, ((marige * 2) + (rectSize / 4) / 2) + 10 + rowsHigtht);
                e.Graphics.DrawLine(Pens.Green, marige, marige + 175+rowsHigtht, e.PageBounds.Width - (marige ), marige + 175 + rowsHigtht);
                rowsHigtht += 40;
            }
            string total = "القيمه النهائيه للفاتورة :" +txtTotal.Text;
            SizeF sizeFont4 = e.Graphics.MeasureString(total, fff);
            e.Graphics.DrawString(total, fff, Brushes.Red, e.PageBounds.Width - sizeFont4.Width - marige, marige + (sizeFont2.Height)*2 + 30);
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            Dictionary<int, string> dataType = new Dictionary<int, string>();
            dataType.Add(40, "ram fury x 8GB");
            dataType.Add(70, "SSD samsung 240 GB");
            dataType.Add(30, "HDD TOWSHIPA 1 TB");
            dataType.Add(25, "Keypoard tectcal");
            dataType.Add(240, "GTX NVIDIA 1660 6 GB");
            dataType.Add(760, "GTX NVIDIA 2080 TI 12 GB");
            dataType.Add(130, "NVIDIA 1060 4 GB");
            dataType.Add(35, "AMD 2 GB GPU ");

            comboBoxType.DataSource = new BindingSource(dataType, null);
            comboBoxType.DisplayMember = "Value";
            comboBoxType.ValueMember = "Key";

            txtDate.Text = DateTime.Now.ToString("yyyy/MM/dd");
            txtUserName.Focus();
            txtUserName.SelectAll();
        }

        private void txtInvoiseNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtUserName.Focus();
                txtUserName.SelectAll();
            }
        }
    }
}
