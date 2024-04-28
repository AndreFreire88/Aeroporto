namespace Aeroporto
{
    partial class RegisterClient
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
            this.registerClientLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.cellphoneLabel = new System.Windows.Forms.Label();
            this.firstNameValue = new System.Windows.Forms.TextBox();
            this.lastNameValue = new System.Windows.Forms.TextBox();
            this.emailValue = new System.Windows.Forms.TextBox();
            this.addressValue = new System.Windows.Forms.TextBox();
            this.CellphoneNumberValue = new System.Windows.Forms.TextBox();
            this.registerClientBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // registerClientLabel
            // 
            this.registerClientLabel.AutoSize = true;
            this.registerClientLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerClientLabel.Location = new System.Drawing.Point(138, 40);
            this.registerClientLabel.Name = "registerClientLabel";
            this.registerClientLabel.Size = new System.Drawing.Size(207, 38);
            this.registerClientLabel.TabIndex = 0;
            this.registerClientLabel.Text = "Register Client";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(62, 130);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(97, 25);
            this.firstNameLabel.TabIndex = 1;
            this.firstNameLabel.Text = "First Name";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(62, 226);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(95, 25);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Last Name";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(62, 418);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(54, 25);
            this.emailLabel.TabIndex = 3;
            this.emailLabel.Text = "Email";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(62, 322);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(77, 25);
            this.addressLabel.TabIndex = 4;
            this.addressLabel.Text = "Address";
            // 
            // cellphoneLabel
            // 
            this.cellphoneLabel.AutoSize = true;
            this.cellphoneLabel.Location = new System.Drawing.Point(62, 514);
            this.cellphoneLabel.Name = "cellphoneLabel";
            this.cellphoneLabel.Size = new System.Drawing.Size(161, 25);
            this.cellphoneLabel.TabIndex = 5;
            this.cellphoneLabel.Text = "Cellphone Number";
            // 
            // firstNameValue
            // 
            this.firstNameValue.Location = new System.Drawing.Point(252, 130);
            this.firstNameValue.Name = "firstNameValue";
            this.firstNameValue.Size = new System.Drawing.Size(162, 31);
            this.firstNameValue.TabIndex = 6;
            // 
            // lastNameValue
            // 
            this.lastNameValue.Location = new System.Drawing.Point(252, 226);
            this.lastNameValue.Name = "lastNameValue";
            this.lastNameValue.Size = new System.Drawing.Size(162, 31);
            this.lastNameValue.TabIndex = 7;
            // 
            // emailValue
            // 
            this.emailValue.Location = new System.Drawing.Point(252, 418);
            this.emailValue.Name = "emailValue";
            this.emailValue.Size = new System.Drawing.Size(162, 31);
            this.emailValue.TabIndex = 8;
            // 
            // addressValue
            // 
            this.addressValue.Location = new System.Drawing.Point(252, 322);
            this.addressValue.Name = "addressValue";
            this.addressValue.Size = new System.Drawing.Size(162, 31);
            this.addressValue.TabIndex = 9;
            // 
            // CellphoneNumberValue
            // 
            this.CellphoneNumberValue.Location = new System.Drawing.Point(252, 514);
            this.CellphoneNumberValue.Name = "CellphoneNumberValue";
            this.CellphoneNumberValue.Size = new System.Drawing.Size(162, 31);
            this.CellphoneNumberValue.TabIndex = 10;
            // 
            // registerClientBtn
            // 
            this.registerClientBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.registerClientBtn.Location = new System.Drawing.Point(163, 593);
            this.registerClientBtn.Name = "registerClientBtn";
            this.registerClientBtn.Size = new System.Drawing.Size(148, 37);
            this.registerClientBtn.TabIndex = 11;
            this.registerClientBtn.Text = "Register Client";
            this.registerClientBtn.UseVisualStyleBackColor = true;
            this.registerClientBtn.Click += new System.EventHandler(this.registerClientBtn_Click);
            // 
            // RegisterClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(501, 665);
            this.Controls.Add(this.registerClientBtn);
            this.Controls.Add(this.CellphoneNumberValue);
            this.Controls.Add(this.addressValue);
            this.Controls.Add(this.emailValue);
            this.Controls.Add(this.lastNameValue);
            this.Controls.Add(this.firstNameValue);
            this.Controls.Add(this.cellphoneLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.registerClientLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RegisterClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label registerClientLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label cellphoneLabel;
        private System.Windows.Forms.TextBox firstNameValue;
        private System.Windows.Forms.TextBox lastNameValue;
        private System.Windows.Forms.TextBox emailValue;
        private System.Windows.Forms.TextBox addressValue;
        private System.Windows.Forms.TextBox CellphoneNumberValue;
        private System.Windows.Forms.Button registerClientBtn;
    }
}