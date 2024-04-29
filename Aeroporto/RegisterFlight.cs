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
        IRegisterFlightRequest callingForm;
        public RegisterFlight(IRegisterFlightRequest caller)
        {
            InitializeComponent();
            callingForm = caller;
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
            callingForm.FlightComplete();

            Close();

        }
    }
}
