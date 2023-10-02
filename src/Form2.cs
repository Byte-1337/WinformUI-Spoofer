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
namespace carbon.wtf_new_frontend

{

    public partial class Form2 : Form
    {
        public static api KeyAuthApp = new api(
            name: "UB.WTF",
            ownerid: "qhmn2aIwBh",
            secret: "156c6745c678ff6d3ef9241c51dbd110a80bb37be19df1f2c4e060d49ce26468",
            version: "1.0"
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
        public Form2()
        {
            InitializeComponent();
            KeyAuthApp.init();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)// login
        {
            KeyAuthApp.login(guna2TextBox3.Text, guna2TextBox5.Text);
            if (KeyAuthApp.response.success)
            {
                Form1 ui = new Form1();
                ui.Show();
                this.Hide();
            }
            else
            {

                MessageBox.Show("Invalid Login", "0x00", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)// register
        {
            KeyAuthApp.register(guna2TextBox3.Text, guna2TextBox5.Text, guna2TextBox4.Text);
            if (KeyAuthApp.response.success)
            {
                Form1 ui = new Form1();
                ui.Show();
                this.Hide();
            }
            else
            {

                MessageBox.Show("Invalid License", "0x00", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
