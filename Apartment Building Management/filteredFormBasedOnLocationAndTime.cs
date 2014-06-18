using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Apartment_Building_Management
{
    public partial class filteredFormBasedOnLocationAndTime : filteredFormBasedOnLocation
    {
        public filteredFormBasedOnLocationAndTime()
        {
            InitializeComponent();

            string[] monthNames = { "Ιανουάριος", "Φεβρουάριος", "Μάρτιος", "Απρίλιος", "Μάιος", "Ιούνιος", "Ιούλιος", "Αύγουστος", "Σεπτέμβριος", "Οκτώβριος",
                                  "Νοέμβριος", "Δεκέμβριος" };
            monthComboBox.Items.AddRange(monthNames);

            for (int i = 2010; i < 2050; i++)
            {
                yearComboBox.Items.Add(i);
            }

            monthComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            yearComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void filteredFormBasedOnLocationAndTime_Load(object sender, EventArgs e)
        {

        }

        public override void areaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            areaChanged();
            monthComboBox.SelectedIndex = -1;
            yearComboBox.SelectedIndex = -1;
        }

        public override void addressComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            monthComboBox.SelectedIndex = -1;
            yearComboBox.SelectedIndex = -1;
        }



        private void yearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void monthComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (monthComboBox.SelectedIndex != -1)
            {
                adapterInitialization();
            }
            else
            {
                UnfilteredDataGridView.Hide();
            }
        }

        public override void adapterInitialization()
        {
            UnfilteredDataGridView.Show();
            whileNotEditingControlsStatus(true);

            string queryString = "select buildingID from buildings where bArea = @Area and bAddress = @Address";
            string areaParameter = areaComboBox.SelectedItem.ToString();
            string addressParameter = addressComboBox.SelectedItem.ToString();
            SelectedID = RetrieveIdBasedOnLocation(areaParameter, addressParameter, queryString);

            string selectQuery = "select buildingID as 'Building ID', theMonth as Month, theYear as Year, costCategory as 'Cost Category'" +
            ", costDescription as 'Cost Description', cost as Cost from dapanes where buildingID = @buildingID and theMonth = @theMonth and theYear = @theYear";

            SqlConnection connection = new SqlConnection(ConnectionString);

            SqlCommand selectCommand = new SqlCommand();
            selectCommand.CommandText = selectQuery;
            selectCommand.Connection = connection;

            SqlParameter parameter1 = new SqlParameter();
            parameter1.ParameterName = "@buildingID";
            parameter1.SqlDbType = SqlDbType.VarChar;
            parameter1.SourceColumn = "buildingID";
            parameter1.Value = SelectedID;

            SqlParameter parameter2 = new SqlParameter();
            parameter2.ParameterName = "@theMonth";
            parameter2.SqlDbType = SqlDbType.NVarChar;
            parameter2.SourceColumn = "theMonth";
            parameter2.Value = monthComboBox.SelectedItem.ToString();

            SqlParameter parameter3 = new SqlParameter();
            parameter3.ParameterName = "@theYear";
            parameter3.SqlDbType = SqlDbType.VarChar;
            parameter3.SourceColumn = "theYear";
            parameter3.Value = yearComboBox.SelectedItem.ToString();

            selectCommand.Parameters.Add(parameter1);
            selectCommand.Parameters.Add(parameter2);
            selectCommand.Parameters.Add(parameter3);

            Adapter = new SqlDataAdapter();
            Adapter.SelectCommand = selectCommand;
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(Adapter);

            GetData();

            /*
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = selectCommand;

            SqlCommandBuilder builder = new SqlCommandBuilder(da);

            Adapter = da;

            GetData2();
             * */

            for (int i = 0; i < 3; i++ )
            {
                UnfilteredDataGridView.Columns[i].Visible = false;
            }

            whileEditingControlsStatus(false);
            whileNotEditingControlsStatus(true);
        }
    }
}
