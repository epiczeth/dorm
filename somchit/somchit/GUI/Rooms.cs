using System.Windows.Forms;

namespace somchit.GUI
{
    public partial class Rooms : Form
    {
        public Rooms()
        {
            InitializeComponent();
        }

        private void roomsBindingNavigatorSaveItem_Click(object sender, System.EventArgs e)
        {
            if (del)
            {
                this.Validate();
                this.roomsBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.roomsDataSet);
                del = false;
                bindingNavigatorAddNewItem.Enabled = true;
            }
            else
            {
                if (IsValidated())
                {
                    this.Validate();
                    this.roomsBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.roomsDataSet);
                    MessageBox.Show("บันทึกข้อมูลสำเร็จ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bindingNavigatorAddNewItem.Enabled = true;
                }
                else
                {
                    MessageBox.Show("ข้อมูลยังไม่ครบ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            

        }

        private bool IsValidated()
        {
            if (room_noLabel1.Text.Length < 1 || room_buildingTextBox.Text.Length < 1 ||
                room_floorTextBox.Text.Length < 1
                || room_statusComboBox.Text.Length < 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void Rooms_Load(object sender, System.EventArgs e)
        {
            // TODO: This line of code loads data into the 'roomsDataSet.Rooms' table. You can move, or remove it, as needed.
            this.roomsTableAdapter.Fill(this.roomsDataSet.Rooms);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, System.EventArgs e)
        {
            room_noLabel1.Text = new SC.Adodb().GetNewRoomNumber();
            room_statusComboBox.SelectedIndex = 0;
            bindingNavigatorAddNewItem.Enabled = false;
        }

        private bool del = false;
        private void bindingNavigatorDeleteItem_Click(object sender, System.EventArgs e)
        {
            del = true;
            MessageBox.Show("คลิกที่ปุ่มบันทึกเพื่อลบข้อมูล", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
