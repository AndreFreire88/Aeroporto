namespace Aeroporto
{
    partial class UpdateClient
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
            this.updateClientBtn = new System.Windows.Forms.Button();
            this.CellphoneNumberValue = new System.Windows.Forms.TextBox();
            this.addressValue = new System.Windows.Forms.TextBox();
            this.emailValue = new System.Windows.Forms.TextBox();
            this.cellphoneLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.updateClientLabel = new System.Windows.Forms.Label();
            this.firstNameValueLabel = new System.Windows.Forms.Label();
            this.lastNameValueLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // updateClientBtn
            // 
            this.updateClientBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.updateClientBtn.Location = new System.Drawing.Point(175, 590);
            this.updateClientBtn.Name = "updateClientBtn";
            this.updateClientBtn.Size = new System.Drawing.Size(148, 37);
            this.updateClientBtn.TabIndex = 23;
            this.updateClientBtn.Text = "Update Client";
            this.updateClientBtn.UseVisualStyleBackColor = true;
            this.updateClientBtn.Click += new System.EventHandler(this.updateClientBtn_Click);
            // 
            // CellphoneNumberValue
            // 
            this.CellphoneNumberValue.Location = new System.Drawing.Point(264, 511);
            this.CellphoneNumberValue.Name = "CellphoneNumberValue";
            this.CellphoneNumberValue.Size = new System.Drawing.Size(162, 31);
            this.CellphoneNumberValue.TabIndex = 22;
            // 
            // addressValue
            // 
            this.addressValue.Location = new System.Drawing.Point(264, 319);
            this.addressValue.Name = "addressValue";
            this.addressValue.Size = new System.Drawing.Size(162, 31);
            this.addressValue.TabIndex = 20;
            // 
            // emailValue
            // 
            this.emailValue.Location = new System.Drawing.Point(264, 415);
            this.emailValue.Name = "emailValue";
            this.emailValue.Size = new System.Drawing.Size(162, 31);
            this.emailValue.TabIndex = 21;
            // 
            // cellphoneLabel
            // 
            this.cellphoneLabel.AutoSize = true;
            this.cellphoneLabel.Location = new System.Drawing.Point(74, 511);
            this.cellphoneLabel.Name = "cellphoneLabel";
            this.cellphoneLabel.Size = new System.Drawing.Size(161, 25);
            this.cellphoneLabel.TabIndex = 17;
            this.cellphoneLabel.Text = "Cellphone Number";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(74, 319);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(77, 25);
            this.addressLabel.TabIndex = 16;
            this.addressLabel.Text = "Address";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(74, 415);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(54, 25);
            this.emailLabel.TabIndex = 15;
            this.emailLabel.Text = "Email";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(74, 223);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(95, 25);
            this.lastNameLabel.TabIndex = 14;
            this.lastNameLabel.Text = "Last Name";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(74, 127);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(97, 25);
            this.firstNameLabel.TabIndex = 13;
            this.firstNameLabel.Text = "First Name";
            // 
            // updateClientLabel
            // 
            this.updateClientLabel.AutoSize = true;
            this.updateClientLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateClientLabel.Location = new System.Drawing.Point(150, 37);
            this.updateClientLabel.Name = "updateClientLabel";
            this.updateClientLabel.Size = new System.Drawing.Size(196, 38);
            this.updateClientLabel.TabIndex = 12;
            this.updateClientLabel.Text = "Update Client";
            // 
            // firstNameValueLabel
            // 
            this.firstNameValueLabel.AutoSize = true;
            this.firstNameValueLabel.Location = new System.Drawing.Point(259, 127);
            this.firstNameValueLabel.Name = "firstNameValueLabel";
            this.firstNameValueLabel.Size = new System.Drawing.Size(76, 25);
            this.firstNameValueLabel.TabIndex = 24;
            this.firstNameValueLabel.Text = "<none>";
            // 
            // lastNameValueLabel
            // 
            this.lastNameValueLabel.AutoSize = true;
            this.lastNameValueLabel.Location = new System.Drawing.Point(259, 223);
            this.lastNameValueLabel.Name = "lastNameValueLabel";
            this.lastNameValueLabel.Size = new System.Drawing.Size(76, 25);
            this.lastNameValueLabel.TabIndex = 25;
            this.lastNameValueLabel.Text = "<none>";
            // 
            // UpdateClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(501, 665);
            this.Controls.Add(this.lastNameValueLabel);
            this.Controls.Add(this.firstNameValueLabel);
            this.Controls.Add(this.updateClientBtn);
            this.Controls.Add(this.CellphoneNumberValue);
            this.Controls.Add(this.addressValue);
            this.Controls.Add(this.emailValue);
            this.Controls.Add(this.cellphoneLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.updateClientLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UpdateClient";
            this.Text = "UpdateClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button updateClientBtn;
        private System.Windows.Forms.TextBox CellphoneNumberValue;
        private System.Windows.Forms.TextBox addressValue;
        private System.Windows.Forms.TextBox emailValue;
        private System.Windows.Forms.Label cellphoneLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label updateClientLabel;
        private System.Windows.Forms.Label firstNameValueLabel;
        private System.Windows.Forms.Label lastNameValueLabel;
    }
}