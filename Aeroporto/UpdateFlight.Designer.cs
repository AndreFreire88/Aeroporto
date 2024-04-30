namespace Aeroporto
{
    partial class UpdateFlight
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
            this.updateFlightBtn = new System.Windows.Forms.Button();
            this.flightNameLabel = new System.Windows.Forms.Label();
            this.horaDeChegadaLabel = new System.Windows.Forms.Label();
            this.horaDePartidaLabel = new System.Windows.Forms.Label();
            this.departureDateValue = new System.Windows.Forms.DateTimePicker();
            this.arriveDateValue = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // updateFlightBtn
            // 
            this.updateFlightBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.updateFlightBtn.Location = new System.Drawing.Point(311, 244);
            this.updateFlightBtn.Name = "updateFlightBtn";
            this.updateFlightBtn.Size = new System.Drawing.Size(200, 38);
            this.updateFlightBtn.TabIndex = 3;
            this.updateFlightBtn.Text = "Update";
            this.updateFlightBtn.UseVisualStyleBackColor = true;
            this.updateFlightBtn.Click += new System.EventHandler(this.updateFlightBtn_Click);
            // 
            // flightNameLabel
            // 
            this.flightNameLabel.AutoSize = true;
            this.flightNameLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flightNameLabel.Location = new System.Drawing.Point(351, 24);
            this.flightNameLabel.Name = "flightNameLabel";
            this.flightNameLabel.Size = new System.Drawing.Size(123, 38);
            this.flightNameLabel.TabIndex = 50;
            this.flightNameLabel.Text = "<none>";
            // 
            // horaDeChegadaLabel
            // 
            this.horaDeChegadaLabel.AutoSize = true;
            this.horaDeChegadaLabel.Location = new System.Drawing.Point(453, 147);
            this.horaDeChegadaLabel.Name = "horaDeChegadaLabel";
            this.horaDeChegadaLabel.Size = new System.Drawing.Size(78, 25);
            this.horaDeChegadaLabel.TabIndex = 48;
            this.horaDeChegadaLabel.Text = "Arrive at";
            // 
            // horaDePartidaLabel
            // 
            this.horaDePartidaLabel.AutoSize = true;
            this.horaDePartidaLabel.Location = new System.Drawing.Point(62, 142);
            this.horaDePartidaLabel.Name = "horaDePartidaLabel";
            this.horaDePartidaLabel.Size = new System.Drawing.Size(111, 25);
            this.horaDePartidaLabel.TabIndex = 47;
            this.horaDePartidaLabel.Text = "Departure at";
            // 
            // departureDateValue
            // 
            this.departureDateValue.CustomFormat = "yyyy-MM-dd HH:mm";
            this.departureDateValue.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departureDateValue.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.departureDateValue.Location = new System.Drawing.Point(188, 142);
            this.departureDateValue.Name = "departureDateValue";
            this.departureDateValue.Size = new System.Drawing.Size(189, 31);
            this.departureDateValue.TabIndex = 63;
            this.departureDateValue.ValueChanged += new System.EventHandler(this.departureDateValue_ValueChanged);
            // 
            // arriveDateValue
            // 
            this.arriveDateValue.CustomFormat = "yyyy-MM-dd HH:mm";
            this.arriveDateValue.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arriveDateValue.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.arriveDateValue.Location = new System.Drawing.Point(549, 142);
            this.arriveDateValue.Name = "arriveDateValue";
            this.arriveDateValue.Size = new System.Drawing.Size(189, 31);
            this.arriveDateValue.TabIndex = 64;
            // 
            // UpdateFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(834, 311);
            this.Controls.Add(this.arriveDateValue);
            this.Controls.Add(this.departureDateValue);
            this.Controls.Add(this.updateFlightBtn);
            this.Controls.Add(this.flightNameLabel);
            this.Controls.Add(this.horaDeChegadaLabel);
            this.Controls.Add(this.horaDePartidaLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UpdateFlight";
            this.Text = "UpdateFlight";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button updateFlightBtn;
        private System.Windows.Forms.Label flightNameLabel;
        private System.Windows.Forms.Label horaDeChegadaLabel;
        private System.Windows.Forms.Label horaDePartidaLabel;
        private System.Windows.Forms.DateTimePicker departureDateValue;
        private System.Windows.Forms.DateTimePicker arriveDateValue;
    }
}