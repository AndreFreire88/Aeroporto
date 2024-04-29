namespace Aeroporto
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RoundDropdown = new System.Windows.Forms.ComboBox();
            this.flightDropDown = new System.Windows.Forms.ComboBox();
            this.flightInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.capacidadeValueLabel = new System.Windows.Forms.Label();
            this.capacidadeLabel = new System.Windows.Forms.Label();
            this.horaDeChegadaValueLabel = new System.Windows.Forms.Label();
            this.HoraDePartidadeValueLabel = new System.Windows.Forms.Label();
            this.companhiaValueLabel = new System.Windows.Forms.Label();
            this.origemValueLabel = new System.Windows.Forms.Label();
            this.destinoValueLabel = new System.Windows.Forms.Label();
            this.horaDeChegadaLabel = new System.Windows.Forms.Label();
            this.horaDePartidaLabel = new System.Windows.Forms.Label();
            this.destinoLabel = new System.Windows.Forms.Label();
            this.origemLabel = new System.Windows.Forms.Label();
            this.companhiaLabel = new System.Windows.Forms.Label();
            this.numeroVooValueLabel = new System.Windows.Forms.Label();
            this.numerovooLabel = new System.Windows.Forms.Label();
            this.UpdateFlightBtn = new System.Windows.Forms.Button();
            this.CreateFlightBtn = new System.Windows.Forms.Button();
            this.passangerListBox = new System.Windows.Forms.ListBox();
            this.removePassenger = new System.Windows.Forms.Button();
            this.flightNameLabel = new System.Windows.Forms.Label();
            this.addPassager = new System.Windows.Forms.Button();
            this.flightInfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // RoundDropdown
            // 
            this.RoundDropdown.FormattingEnabled = true;
            this.RoundDropdown.Location = new System.Drawing.Point(12, 783);
            this.RoundDropdown.Name = "RoundDropdown";
            this.RoundDropdown.Size = new System.Drawing.Size(223, 33);
            this.RoundDropdown.TabIndex = 4;
            // 
            // flightDropDown
            // 
            this.flightDropDown.FormattingEnabled = true;
            this.flightDropDown.Location = new System.Drawing.Point(24, 679);
            this.flightDropDown.Name = "flightDropDown";
            this.flightDropDown.Size = new System.Drawing.Size(763, 33);
            this.flightDropDown.TabIndex = 5;
            this.flightDropDown.SelectedIndexChanged += new System.EventHandler(this.flightDropDown_SelectedIndexChanged);
            // 
            // flightInfoGroupBox
            // 
            this.flightInfoGroupBox.Controls.Add(this.capacidadeValueLabel);
            this.flightInfoGroupBox.Controls.Add(this.capacidadeLabel);
            this.flightInfoGroupBox.Controls.Add(this.horaDeChegadaValueLabel);
            this.flightInfoGroupBox.Controls.Add(this.HoraDePartidadeValueLabel);
            this.flightInfoGroupBox.Controls.Add(this.companhiaValueLabel);
            this.flightInfoGroupBox.Controls.Add(this.origemValueLabel);
            this.flightInfoGroupBox.Controls.Add(this.destinoValueLabel);
            this.flightInfoGroupBox.Controls.Add(this.horaDeChegadaLabel);
            this.flightInfoGroupBox.Controls.Add(this.horaDePartidaLabel);
            this.flightInfoGroupBox.Controls.Add(this.destinoLabel);
            this.flightInfoGroupBox.Controls.Add(this.origemLabel);
            this.flightInfoGroupBox.Controls.Add(this.companhiaLabel);
            this.flightInfoGroupBox.Controls.Add(this.numeroVooValueLabel);
            this.flightInfoGroupBox.Controls.Add(this.numerovooLabel);
            this.flightInfoGroupBox.Location = new System.Drawing.Point(24, 95);
            this.flightInfoGroupBox.Name = "flightInfoGroupBox";
            this.flightInfoGroupBox.Size = new System.Drawing.Size(272, 408);
            this.flightInfoGroupBox.TabIndex = 6;
            this.flightInfoGroupBox.TabStop = false;
            this.flightInfoGroupBox.Text = "Info";
            // 
            // capacidadeValueLabel
            // 
            this.capacidadeValueLabel.AutoSize = true;
            this.capacidadeValueLabel.Location = new System.Drawing.Point(142, 364);
            this.capacidadeValueLabel.Name = "capacidadeValueLabel";
            this.capacidadeValueLabel.Size = new System.Drawing.Size(76, 25);
            this.capacidadeValueLabel.TabIndex = 13;
            this.capacidadeValueLabel.Text = "<none>";
            // 
            // capacidadeLabel
            // 
            this.capacidadeLabel.AutoSize = true;
            this.capacidadeLabel.Location = new System.Drawing.Point(17, 364);
            this.capacidadeLabel.Name = "capacidadeLabel";
            this.capacidadeLabel.Size = new System.Drawing.Size(79, 25);
            this.capacidadeLabel.TabIndex = 12;
            this.capacidadeLabel.Text = "Capacity";
            // 
            // horaDeChegadaValueLabel
            // 
            this.horaDeChegadaValueLabel.AutoSize = true;
            this.horaDeChegadaValueLabel.Location = new System.Drawing.Point(142, 315);
            this.horaDeChegadaValueLabel.Name = "horaDeChegadaValueLabel";
            this.horaDeChegadaValueLabel.Size = new System.Drawing.Size(76, 25);
            this.horaDeChegadaValueLabel.TabIndex = 11;
            this.horaDeChegadaValueLabel.Text = "<none>";
            // 
            // HoraDePartidadeValueLabel
            // 
            this.HoraDePartidadeValueLabel.AutoSize = true;
            this.HoraDePartidadeValueLabel.Location = new System.Drawing.Point(142, 260);
            this.HoraDePartidadeValueLabel.Name = "HoraDePartidadeValueLabel";
            this.HoraDePartidadeValueLabel.Size = new System.Drawing.Size(76, 25);
            this.HoraDePartidadeValueLabel.TabIndex = 10;
            this.HoraDePartidadeValueLabel.Text = "<none>";
            // 
            // companhiaValueLabel
            // 
            this.companhiaValueLabel.AutoSize = true;
            this.companhiaValueLabel.Location = new System.Drawing.Point(142, 95);
            this.companhiaValueLabel.Name = "companhiaValueLabel";
            this.companhiaValueLabel.Size = new System.Drawing.Size(76, 25);
            this.companhiaValueLabel.TabIndex = 9;
            this.companhiaValueLabel.Text = "<none>";
            // 
            // origemValueLabel
            // 
            this.origemValueLabel.AutoSize = true;
            this.origemValueLabel.Location = new System.Drawing.Point(142, 150);
            this.origemValueLabel.Name = "origemValueLabel";
            this.origemValueLabel.Size = new System.Drawing.Size(76, 25);
            this.origemValueLabel.TabIndex = 8;
            this.origemValueLabel.Text = "<none>";
            // 
            // destinoValueLabel
            // 
            this.destinoValueLabel.AutoSize = true;
            this.destinoValueLabel.Location = new System.Drawing.Point(142, 205);
            this.destinoValueLabel.Name = "destinoValueLabel";
            this.destinoValueLabel.Size = new System.Drawing.Size(76, 25);
            this.destinoValueLabel.TabIndex = 7;
            this.destinoValueLabel.Text = "<none>";
            // 
            // horaDeChegadaLabel
            // 
            this.horaDeChegadaLabel.AutoSize = true;
            this.horaDeChegadaLabel.Location = new System.Drawing.Point(17, 315);
            this.horaDeChegadaLabel.Name = "horaDeChegadaLabel";
            this.horaDeChegadaLabel.Size = new System.Drawing.Size(78, 25);
            this.horaDeChegadaLabel.TabIndex = 6;
            this.horaDeChegadaLabel.Text = "Arrive at";
            // 
            // horaDePartidaLabel
            // 
            this.horaDePartidaLabel.AutoSize = true;
            this.horaDePartidaLabel.Location = new System.Drawing.Point(17, 260);
            this.horaDePartidaLabel.Name = "horaDePartidaLabel";
            this.horaDePartidaLabel.Size = new System.Drawing.Size(111, 25);
            this.horaDePartidaLabel.TabIndex = 5;
            this.horaDePartidaLabel.Text = "Departure at";
            // 
            // destinoLabel
            // 
            this.destinoLabel.AutoSize = true;
            this.destinoLabel.Location = new System.Drawing.Point(17, 205);
            this.destinoLabel.Name = "destinoLabel";
            this.destinoLabel.Size = new System.Drawing.Size(30, 25);
            this.destinoLabel.TabIndex = 4;
            this.destinoLabel.Text = "To";
            // 
            // origemLabel
            // 
            this.origemLabel.AutoSize = true;
            this.origemLabel.Location = new System.Drawing.Point(17, 150);
            this.origemLabel.Name = "origemLabel";
            this.origemLabel.Size = new System.Drawing.Size(54, 25);
            this.origemLabel.TabIndex = 3;
            this.origemLabel.Text = "From";
            // 
            // companhiaLabel
            // 
            this.companhiaLabel.AutoSize = true;
            this.companhiaLabel.Location = new System.Drawing.Point(17, 95);
            this.companhiaLabel.Name = "companhiaLabel";
            this.companhiaLabel.Size = new System.Drawing.Size(89, 25);
            this.companhiaLabel.TabIndex = 2;
            this.companhiaLabel.Text = "Company";
            // 
            // numeroVooValueLabel
            // 
            this.numeroVooValueLabel.AutoSize = true;
            this.numeroVooValueLabel.Location = new System.Drawing.Point(142, 40);
            this.numeroVooValueLabel.Name = "numeroVooValueLabel";
            this.numeroVooValueLabel.Size = new System.Drawing.Size(76, 25);
            this.numeroVooValueLabel.TabIndex = 1;
            this.numeroVooValueLabel.Text = "<none>";
            // 
            // numerovooLabel
            // 
            this.numerovooLabel.AutoSize = true;
            this.numerovooLabel.Location = new System.Drawing.Point(17, 40);
            this.numerovooLabel.Name = "numerovooLabel";
            this.numerovooLabel.Size = new System.Drawing.Size(77, 25);
            this.numerovooLabel.TabIndex = 0;
            this.numerovooLabel.Text = "Number";
            // 
            // UpdateFlightBtn
            // 
            this.UpdateFlightBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.UpdateFlightBtn.Location = new System.Drawing.Point(67, 534);
            this.UpdateFlightBtn.Name = "UpdateFlightBtn";
            this.UpdateFlightBtn.Size = new System.Drawing.Size(169, 42);
            this.UpdateFlightBtn.TabIndex = 0;
            this.UpdateFlightBtn.Text = "Update Flight";
            this.UpdateFlightBtn.UseVisualStyleBackColor = true;
            // 
            // CreateFlightBtn
            // 
            this.CreateFlightBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CreateFlightBtn.Location = new System.Drawing.Point(260, 606);
            this.CreateFlightBtn.Name = "CreateFlightBtn";
            this.CreateFlightBtn.Size = new System.Drawing.Size(279, 44);
            this.CreateFlightBtn.TabIndex = 7;
            this.CreateFlightBtn.Text = "Register Flight";
            this.CreateFlightBtn.UseVisualStyleBackColor = true;
            this.CreateFlightBtn.Click += new System.EventHandler(this.CreateFlightBtn_Click);
            // 
            // passangerListBox
            // 
            this.passangerListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passangerListBox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.passangerListBox.FormattingEnabled = true;
            this.passangerListBox.ItemHeight = 25;
            this.passangerListBox.Location = new System.Drawing.Point(335, 108);
            this.passangerListBox.Name = "passangerListBox";
            this.passangerListBox.Size = new System.Drawing.Size(256, 404);
            this.passangerListBox.TabIndex = 8;
            // 
            // removePassenger
            // 
            this.removePassenger.ForeColor = System.Drawing.SystemColors.ControlText;
            this.removePassenger.Location = new System.Drawing.Point(618, 249);
            this.removePassenger.Name = "removePassenger";
            this.removePassenger.Size = new System.Drawing.Size(169, 42);
            this.removePassenger.TabIndex = 10;
            this.removePassenger.Text = "Remove Passenger";
            this.removePassenger.UseVisualStyleBackColor = true;
            this.removePassenger.Click += new System.EventHandler(this.removePassenger_Click);
            // 
            // flightNameLabel
            // 
            this.flightNameLabel.AutoSize = true;
            this.flightNameLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flightNameLabel.Location = new System.Drawing.Point(299, 34);
            this.flightNameLabel.Name = "flightNameLabel";
            this.flightNameLabel.Size = new System.Drawing.Size(193, 38);
            this.flightNameLabel.TabIndex = 12;
            this.flightNameLabel.Text = "<flightName>";
            // 
            // addPassager
            // 
            this.addPassager.ForeColor = System.Drawing.SystemColors.ControlText;
            this.addPassager.Location = new System.Drawing.Point(370, 534);
            this.addPassager.Name = "addPassager";
            this.addPassager.Size = new System.Drawing.Size(169, 42);
            this.addPassager.TabIndex = 13;
            this.addPassager.Text = "Add Passenger";
            this.addPassager.UseVisualStyleBackColor = true;
            this.addPassager.Click += new System.EventHandler(this.addPassager_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(801, 724);
            this.Controls.Add(this.addPassager);
            this.Controls.Add(this.flightNameLabel);
            this.Controls.Add(this.removePassenger);
            this.Controls.Add(this.passangerListBox);
            this.Controls.Add(this.CreateFlightBtn);
            this.Controls.Add(this.UpdateFlightBtn);
            this.Controls.Add(this.flightInfoGroupBox);
            this.Controls.Add(this.flightDropDown);
            this.Controls.Add(this.RoundDropdown);
            this.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trip viewer";
            this.flightInfoGroupBox.ResumeLayout(false);
            this.flightInfoGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox RoundDropdown;
        private System.Windows.Forms.ComboBox flightDropDown;
        private System.Windows.Forms.GroupBox flightInfoGroupBox;
        private System.Windows.Forms.Button UpdateFlightBtn;
        private System.Windows.Forms.Button CreateFlightBtn;
        private System.Windows.Forms.ListBox passangerListBox;
        private System.Windows.Forms.Button removePassenger;
        private System.Windows.Forms.Label flightNameLabel;
        private System.Windows.Forms.Button addPassager;
        private System.Windows.Forms.Label horaDeChegadaValueLabel;
        private System.Windows.Forms.Label HoraDePartidadeValueLabel;
        private System.Windows.Forms.Label companhiaValueLabel;
        private System.Windows.Forms.Label origemValueLabel;
        private System.Windows.Forms.Label destinoValueLabel;
        private System.Windows.Forms.Label horaDeChegadaLabel;
        private System.Windows.Forms.Label horaDePartidaLabel;
        private System.Windows.Forms.Label destinoLabel;
        private System.Windows.Forms.Label origemLabel;
        private System.Windows.Forms.Label companhiaLabel;
        private System.Windows.Forms.Label numeroVooValueLabel;
        private System.Windows.Forms.Label numerovooLabel;
        private System.Windows.Forms.Label capacidadeValueLabel;
        private System.Windows.Forms.Label capacidadeLabel;
    }
}

