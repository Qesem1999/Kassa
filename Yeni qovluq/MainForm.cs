using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeinPos
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm(Program.ActualSettings.Server);
            loginForm.ShowDialog();
            if (loginForm.DialogResult == DialogResult.OK && loginForm.Token != "")
            {
                Program.ActualSettings.Token = loginForm.Token;
                Program.GetSettingService().Set(Program.ActualSettings);
            }
            else
            {
                Close();
            }
            Program.ActualProduct = Program.GetProductService().GetList(Program.ActualSettings.Token);
            Program.ActualCustomers = Program.GetCustomerService().GetList(Program.ActualSettings.Token);
            Program.ActualCash = Program.GetCashService().Get(Program.ActualSettings.Token);
        }
    }
}
