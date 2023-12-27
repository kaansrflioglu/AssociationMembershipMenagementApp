using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace PresentationLayer
{
    public partial class MainScreen : Form
    {
        AddMember addMember = new AddMember();
        ListMembers listMembers = new ListMembers();
        ShowPayments showDebt = new ShowPayments();

        public MainScreen()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void btn_memberAdd_Click(object sender, EventArgs e)
        {
            AddMember addMember = new AddMember();
            this.Width = addMember.Width + 272;
            addMember.MdiParent = this;
            addMember.Dock = DockStyle.Fill;
            addMember.Show();
        }

        private void btn_membersList_Click(object sender, EventArgs e)
        {
            ListMembers listMember = new ListMembers();
            this.Width = listMember.Width + 272;
            listMember.MdiParent = this;
            listMember.Dock = DockStyle.Fill;
            listMember.Show();
        }

        private void btn_debt_Click(object sender, EventArgs e)
        {
            ShowPayments showPayments = new ShowPayments();
            this.Width = showPayments.Width + 272;
            showPayments.MdiParent = this;
            showPayments.Dock = DockStyle.Fill;
            showPayments.Show();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }
}

