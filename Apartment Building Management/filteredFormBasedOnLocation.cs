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
    public partial class filteredFormBasedOnLocation : UnfilteredForm
    {
        public filteredFormBasedOnLocation()
        {
            InitializeComponent();
            areaComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            addressComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public ComboBox AreaComboBox
        {
            get { return areaComboBox; }
            set { areaComboBox = value; }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void filteredFormBasedOnLocation_Load(object sender, EventArgs e)
        {

        }

        public void fillTheComboBox(string queryString, ComboBox comboBox)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            SqlCommand command = new SqlCommand(queryString, connection);

            using (connection)
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        comboBox.Items.Add(reader[0]);
                    }
                }
            }
        }

        public void fillTheComboBox(string queryString, ComboBox comboBox, string filterItem)
        {
            addressComboBox.ResetText();
            addressComboBox.Items.Clear();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand();
                command.CommandText = queryString;
                command.Connection = connection;

                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@parameter";
                parameter.SqlDbType = SqlDbType.NVarChar;
                parameter.Value = filterItem;

                command.Parameters.Add(parameter);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        comboBox.Items.Add(reader[0]);
                    }
                }
            }
        }

        private void areaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            whileEditingControlsStatus(false);
            whileNotEditingControlsStatus(true);
            EditBtn.Hide();
            UnfilteredDataGridView.Hide();
            string queryString = "select bAddress from buildings where bArea = @parameter order by bAddress";
            fillTheComboBox(queryString, addressComboBox , areaComboBox.SelectedItem.ToString());
        }

        private void addressComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
