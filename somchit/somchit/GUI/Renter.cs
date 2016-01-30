using System;
using System.Windows.Forms;
using somchit.SC;

namespace somchit.GUI
{
    public partial class Renter : Form
    {
        public Renter()
        {
            InitializeComponent();
        }

        private bool del;
        private void rentersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (del)
            {
                Validate();
                rentersBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(renterDataSet);
                MessageBox.Show("ลบข้อมูลสำเร็จ","",MessageBoxButtons.OK,MessageBoxIcon.Information);
                del = false;
                bindingNavigatorAddNewItem.Enabled = true;
            }
            else
            {
                if (IsValidated())
                {
                    Validate();
                    rentersBindingSource.EndEdit();
                    tableAdapterManager.UpdateAll(renterDataSet);
                    MessageBox.Show("บันทึกข้อมูลสำเร็จ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bindingNavigatorAddNewItem.Enabled = true;
                }
                else
                {
                    MessageBox.Show("ข้อมูลยังไม่ครบ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            

        }

        private void Renter_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'renterDataSet.Renters' table. You can move, or remove it, as needed.
            rentersTableAdapter.Fill(renterDataSet.Renters);

        }

        private bool IsValidated()
        {
            if (r_idLabel1.Text.Length < 1 || r_namelastTextBox.Text.Length < 1 || r_ageTextBox.Text.Length < 1
                || r_districtTextBox.Text.Length < 1 || r_hnumberTextBox.Text.Length < 1 || r_issueplaceTextBox.Text.Length < 1
                || r_mooTextBox.Text.Length < 1 || r_pidTextBox.Text.Length < 1 || r_postalcodeTextBox.Text.Length < 1 ||
                r_provinceTextBox.Text.Length < 1 || r_sexComboBox.Text.Length < 1 || r_soiTextBox.Text.Length < 1 ||
                r_telTextBox.Text.Length < 1)
            {
                return false;
            }
            return true;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            r_idLabel1.Text = new Adodb().GetNewRenterID();
            bindingNavigatorAddNewItem.Enabled = false;
        }

        private void r_ageTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void r_telTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void r_pidTextBox_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void r_pidTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void r_hnumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void r_postalcodeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void r_mooTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            del = true;
            MessageBox.Show("คลิกที่ปุ่มบันทึกเพื่อลบข้อมูล", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (r_idLabel1.Text.Length < 1 && del == false)
            {
                rentersBindingNavigatorSaveItem.Enabled = false;
            }
            else
            {
                rentersBindingNavigatorSaveItem.Enabled = true;
            }
        }
    }
}
