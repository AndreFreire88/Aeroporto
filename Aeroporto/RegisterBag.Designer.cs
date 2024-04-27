namespace Aeroporto
{
    partial class RegisterBag
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
            this.baggageLabel = new System.Windows.Forms.Label();
            this.pesoLabel = new System.Windows.Forms.Label();
            this.pesoValue = new System.Windows.Forms.TextBox();
            this.registerBagBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // baggageLabel
            // 
            this.baggageLabel.AutoSize = true;
            this.baggageLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baggageLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.baggageLabel.Location = new System.Drawing.Point(162, 18);
            this.baggageLabel.Name = "baggageLabel";
            this.baggageLabel.Size = new System.Drawing.Size(245, 38);
            this.baggageLabel.TabIndex = 0;
            this.baggageLabel.Text = "Register Baggage";
            // 
            // pesoLabel
            // 
            this.pesoLabel.AutoSize = true;
            this.pesoLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.pesoLabel.Location = new System.Drawing.Point(250, 108);
            this.pesoLabel.Name = "pesoLabel";
            this.pesoLabel.Size = new System.Drawing.Size(68, 25);
            this.pesoLabel.TabIndex = 1;
            this.pesoLabel.Text = "Weight";
            // 
            // pesoValue
            // 
            this.pesoValue.Location = new System.Drawing.Point(197, 148);
            this.pesoValue.Name = "pesoValue";
            this.pesoValue.Size = new System.Drawing.Size(176, 31);
            this.pesoValue.TabIndex = 2;
            // 
            // registerBagBtn
            // 
            this.registerBagBtn.Location = new System.Drawing.Point(206, 268);
            this.registerBagBtn.Name = "registerBagBtn";
            this.registerBagBtn.Size = new System.Drawing.Size(157, 42);
            this.registerBagBtn.TabIndex = 3;
            this.registerBagBtn.Text = "Register Bad";
            this.registerBagBtn.UseVisualStyleBackColor = true;
            // 
            // RegisterBag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(620, 373);
            this.Controls.Add(this.registerBagBtn);
            this.Controls.Add(this.pesoValue);
            this.Controls.Add(this.pesoLabel);
            this.Controls.Add(this.baggageLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RegisterBag";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterBag";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label baggageLabel;
        private System.Windows.Forms.Label pesoLabel;
        private System.Windows.Forms.TextBox pesoValue;
        private System.Windows.Forms.Button registerBagBtn;
    }
}