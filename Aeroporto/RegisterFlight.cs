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


            if (ValidateForm())
            {
                FlightModel model = new FlightModel(
                    numberValueTextBox.Text,
                    companyValueTextBox.Text,
                    fromValueTextBox.Text,
                    toValueTextBox.Text,
                    departureDateValue.Text,
                    arriveDateValue.Text,
                    capacityValueTextBox.Text);

                GlobalConfig.Connection.CreateFlight(model);
                callingForm.FlightComplete(model);

                Close();
            }
            else
                MessageBox.Show("Error", "Error");


        }

        private bool ValidateForm()
        {
            if (numberValueTextBox.Text.Length == 0)
                return false;            

            if(companyValueTextBox.Text.Length == 0)
                return false;
            
            if (fromValueTextBox.Text.Length == 0)        
                return false;            

            if (toValueTextBox.Text.Length == 0)
                return false;

            if (!DateTime.TryParse(departureDateValue.Text, out DateTime partida))
                return false;

            if (!DateTime.TryParse(arriveDateValue.Text, out DateTime chegada))
                return false;

            if (partida >  chegada) 
                return false;

            if (!int.TryParse(capacityValueTextBox.Text,out int capacidade))
                return false;

            return true;
        }

        private void departureDateValue_ValueChanged(object sender, EventArgs e)
        {
            if (departureDateValue.Value > arriveDateValue.Value)
            {
                arriveDateValue.Value = departureDateValue.Value;
            }
        }
    }
}
