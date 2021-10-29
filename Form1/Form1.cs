using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            if (TextUser.Text == "" || TextPass.Text == "")
            {
                MessageBox.Show("Username dan Password tidak boleh kosong");
            }
            if (TextUser.Text != "admin" || TextPass.Text != "12345")
            {
                MessageBox.Show("Username atau Password salah");
            }
            else
            {
                this.Hide();
                Sukses s = new Sukses();
                s.Show();
            }
        }
    }
}
