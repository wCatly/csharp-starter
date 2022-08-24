using RiotAutomatization.API;
using System;
using System.Windows.Forms;
using MessageBox;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoUpdaterDotNET;
using Discord.Net;
using SharpConfig;
using Loader;

namespace RiotAutomatization
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }

        private void siticoneControlBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            this.Alert("wcat31", Form_Alert.enmType.Success);
        }
    }
}
