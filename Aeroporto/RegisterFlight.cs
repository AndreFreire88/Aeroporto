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
            Gettimedateform();
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
                    departureValueTextBox.Text,
                    arriveValueTextBox.Text,
                    capacityValueTextBox.Text);

                GlobalConfig.Connection.CreateFlight(model);
                callingForm.FlightComplete();

                Close();
            }
            else
                MessageBox.Show("Error", "Error");


        }

        private void Gettimedateform()
        {
            DateTime date = DateTime.Now;

            departureValueTextBox.Text = date.ToString();
            arriveValueTextBox.Text = date.ToString();

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

            if (!DateTime.TryParse(departureValueTextBox.Text, out DateTime hora))            
                return false;
            
            if(!DateTime.TryParse(arriveValueTextBox.Text, out DateTime result))
                return false;

            if(!int.TryParse(capacityValueTextBox.Text,out int capacidade))
                return false;

            return true;
        }

    }
}
