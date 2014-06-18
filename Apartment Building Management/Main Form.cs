using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apartment_Building_Management
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void buildingsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            string queryString = "select buildingID as 'Building ID', bAddress as Address, bArea as Area from buildings order by buildingID";
            UnfilteredForm buildings = new UnfilteredForm(queryString);
            buildings.GetData();
            buildings.whileEditingControlsStatus(false);
            buildings.Show();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void categoriesOfCostBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            string queryString = "select costCategory as 'Cost Category', costDescription as 'Cost Description' from costPredefinedItems";
            UnfilteredForm categoriesOfCost = new UnfilteredForm(queryString);
            categoriesOfCost.GetData();
            categoriesOfCost.whileEditingControlsStatus(false);
            categoriesOfCost.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            filteredFormBasedOnLocation apartments = new filteredFormBasedOnLocation();
            string queryString = "select distinct bArea from buildings order by bArea";
            apartments.fillTheComboBox(queryString, apartments.AreaComboBox);
            apartments.Show();
        }
    }
}
