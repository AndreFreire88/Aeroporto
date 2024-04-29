using Libary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aeroporto
{
    public partial class RegisterFlight : Form
    {
        public RegisterFlight()
        {
            InitializeComponent();
        }

        private void registerFlightBtn_Click(object sender, EventArgs e)
        {


            FlightModel model = new FlightModel(
                numberValueTextBox.Text,
                companyValueTextBox.Text,
                fromValueTextBox.Text,
                toValueTextBox.Text,
                departureValueTextBox.Text,
                arriveValueTextBox.Text,
                capacityValueTextBox.Text);

            GlobalConfig.Connection.CreateFlight(model);

            this.Close();

        }
    }
}
