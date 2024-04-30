using Aeroporto.Interfaces;
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
    public partial class UpdateFlight : Form
    {
        IUpdateFlightRequest callingForm;
        FlightModel flight;

        public UpdateFlight(IUpdateFlightRequest caller, FlightModel model)
        {
            InitializeComponent();
            callingForm = caller;
            flight = model;
            WireUpInfo();
        }

        private void WireUpInfo()
        {
            flightNameLabel.Text = flight.FlightName;
            departureDateValue.Value = flight.DataHoraPartida;
            arriveDateValue.Value = flight.DataHoraChegada;
        }

        private void updateFlightBtn_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                FlightModel model = new FlightModel(flight.ID_Voo, departureDateValue.Text, arriveDateValue.Text);
                GlobalConfig.Connection.UpdateFlights(model);
                callingForm.UpdateFlightComplete(model);
                Close();

            }
            else
                MessageBox.Show("Error", "Error");

        }

        private bool ValidateForm()
        {

            if (!DateTime.TryParse(departureDateValue.Text, out DateTime partida))
                return false;

            if (!DateTime.TryParse(arriveDateValue.Text, out DateTime chegada))
                return false;


            if (partida > chegada)
                return false;

            return true;
        }

    }
}
