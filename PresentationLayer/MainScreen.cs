using ADOX;
using BusinessLayer;
using DataAccessLayer;
using System;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class MainScreen : Form
    {
        private BusinessLayer.BusinessLayer businessLayer;
        private DataAccessLayer.DataAccessLayer dataAccessLayer;
        AddMember addMember = new AddMember();
        ListMembers listMembers = new ListMembers();
        ShowPayments showDebt = new ShowPayments();

        public MainScreen()
        {
            businessLayer = new BusinessLayer.BusinessLayer();
            dataAccessLayer = new DataAccessLayer.DataAccessLayer();
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

        void CreateDataBase()
        {
            try
            {
                string databasePath = "Database.accdb";

                if (!File.Exists(databasePath))
                {
                    Catalog cat = new Catalog();
                    cat.Create($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={databasePath};Jet OLEDB:Engine Type=5");
                    MessageBox.Show("Veritabanı oluşturuldu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void CreateTables()
        {
            string query = businessLayer.CreateUyelerTable();
            dataAccessLayer.ExecuteNonQuery(query);
            query = businessLayer.CreateAidatlarTable();
            dataAccessLayer.ExecuteNonQuery(query);
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            CreateDataBase();
            CreateTables();
            this.ControlBox = false;
        }
    }
}
