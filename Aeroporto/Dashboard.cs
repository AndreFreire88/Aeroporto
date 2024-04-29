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
    public partial class Dashboard : Form
    {
        List<FlightModel> flights = GlobalConfig.Connection.GetFlights_All();
        public Dashboard()
        {
            InitializeComponent();
            WireUpLIst();
            WireUpInfo();
        }

        private void WireUpLIst()
        {
            flightDropDown.DataSource = null;
            flightDropDown.DataSource = flights;
            flightDropDown.DisplayMember = nameof(FlightModel.FlightName);
        }

        private void WireUpInfo()
        {
            FlightModel model = flightDropDown.SelectedItem as FlightModel;
            numeroVooValueLabel.Text = model.NumeroVoo;
            companhiaValueLabel.Text = model.CompanhiaAerea;
            origemValueLabel.Text = model.Origem;
            destinoValueLabel.Text = model.Destino;
            HoraDePartidadeValueLabel.Text = model.DataHoraPartida.Substring(0, model.DataHoraPartida.Length - 3);
            horaDeChegadaValueLabel.Text = model.DataHoraChegada.Substring(0, model.DataHoraChegada.Length - 3);
            capacidadeValueLabel.Text = model.Capacidade.ToString();

            flightNameLabel.Text = model.FlightName;

            passangerListBox.DataSource = null;
            passangerListBox.DataSource = model.Passengers;
            passangerListBox.DisplayMember = nameof(ClientModel.FullName);

        }

        private void flightDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            WireUpInfo();
        }

        private void CreateFlightBtn_Click(object sender, EventArgs e)
        {
            RegisterFlight frm = new RegisterFlight();
            frm.Show();
        }
    }
}
