using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;


namespace carbon.wtf_new_frontend
{
    public partial class Form1 : Form
    {
        public static api KeyAuthApp = new api(
            name: "",
            ownerid: "",
            secret: "",
            version: ""
        );
        static void KillProcess(string proc)
        {
            Process[] ps = Process.GetProcessesByName(proc);

            foreach (Process p in ps)
                p.Kill();
        }

        void LoopKill()
        {
            KillProcess("EpicGamesLauncher");
            KillProcess("BEService");
            KillProcess("FortniteClient-Win64-Shipping");
            KillProcess("FortniteClient-Win64-Shipping-EAC");
            KillProcess("FortniteClient-Win64-Shipping-BE");
            KillProcess("vgtray");
            KillProcess("vanguard");
            KillProcess("dnSpy");
            KillProcess("x64dbg");
            KillProcess("x32dbg");
            KillProcess("ida64");
            KillProcess("ida32");
            KillProcess("FolderChangesView");
            KillProcess("MegaDumper");
            KillProcess("ExtremeDumper");
            KillProcess("VALORANT");

            LoopKill();
        }
        public Form1()
        {
            InitializeComponent();
            guna2GradientPanel1.Hide();
            guna2GradientPanel2.Show();
            guna2GradientPanel3.Hide();
            panel2.Show();
            panel3.Show();
            panel8.Hide();
            panel6.Hide();
            panel12.Hide();
            panel10.Hide();
        }
        private void guna2button1_Click(object sender, PaintEventArgs e)
        {
            MessageBox.Show("Hallo");
        }
        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            guna2GradientPanel2.Hide();
            guna2GradientPanel3.Hide();
            guna2GradientPanel1.Show();
            panel2.Hide();
            panel3.Hide();
            panel8.Show();
            panel6.Show();
            panel12.Hide();
            panel10.Hide();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            guna2GradientPanel1.Hide();
            guna2GradientPanel3.Hide();
            guna2GradientPanel2.Show();
            panel2.Show();
            panel3.Show();
            panel8.Hide();
            panel6.Hide();
            panel12.Hide();
            panel10.Hide();
        }

        private void Profilebutton_Click(object sender, EventArgs e)
        {
            guna2GradientPanel1.Hide();
            guna2GradientPanel2.Hide();
            guna2GradientPanel3.Show();
            panel2.Hide();
            panel3.Hide();
            panel8.Hide();
            panel6.Hide();
            panel12.Show();
            panel10.Show();
        }
        private void guna2TextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2TextBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
