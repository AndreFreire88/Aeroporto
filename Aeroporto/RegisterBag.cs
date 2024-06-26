﻿using Aeroporto.Interfaces;
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
    public partial class RegisterBag : Form
    {
        private ClientModel Passanger;
        private IRegisterBagRequest callingform;
        public RegisterBag(IRegisterBagRequest caller, ClientModel passanger)
        {
            InitializeComponent();
            callingform = caller;
            Passanger = passanger;
        }

        private void registerBagBtn_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                BaggageModel model = new BaggageModel(Passanger.ID_Passageiro, pesoValue.Text);
                GlobalConfig.Connection.CreateBag(model);
                callingform.BagComplete(model);

                Close();
            }
            else
                MessageBox.Show("Error","Error");

        }

        private bool ValidateForm()
        {

            if (!decimal.TryParse(pesoValue.Text, out decimal peso) || peso <= 0)
                return false;

            return true;
        }
    }
}
