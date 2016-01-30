using System;
using System.Windows.Forms;
using somchit.SC;

namespace somchit.GUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (new Adodb().IsExistingUser(textBox1.Text, textBox2.Text))
            {
                Hide();
                new MainMenu().Show();
            }
            else
            {
                MessageBox.Show(this, "ชื่อผู้ใช้หรือรหัสผ่านผิด", "เข้าสู่ระบบล้มเหลว", MessageBoxButtons.OK,
                    MessageBoxIcon.Stop);
                textBox2.Clear();
            }
        }
    }
}
