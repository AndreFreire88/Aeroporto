﻿namespace Aeroporto
{
    partial class BookFlight
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
            this.bookLabel = new System.Windows.Forms.Label();
            this.clientLabel = new System.Windows.Forms.Label();
            this.flightNameLabel = new System.Windows.Forms.Label();
            this.clientDropDown = new System.Windows.Forms.ComboBox();
            this.createClientLink = new System.Windows.Forms.LinkLabel();
            this.clientInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.telefoneValueLabel = new System.Windows.Forms.Label();
            this.emailValueLabel = new System.Windows.Forms.Label();
            this.enderecoValueLabel = new System.Windows.Forms.Label();
            this.nomeValueLabel = new System.Windows.Forms.Label();
            this.telefoneLabel = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.enderecoLabel = new System.Windows.Forms.Label();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.bagsListBox = new System.Windows.Forms.ListBox();
            this.CreateBagBtn = new System.Windows.Forms.Button();
            this.bookbutton = new System.Windows.Forms.Button();
            this.clientBagsLabel = new System.Windows.Forms.Label();
            this.deleteBagBtn = new System.Windows.Forms.Button();
            this.updateClientInfo = new System.Windows.Forms.Button();
            this.clientInfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // bookLabel
            // 
            this.bookLabel.AutoSize = true;
            this.bookLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookLabel.Location = new System.Drawing.Point(389, 43);
            this.bookLabel.Name = "bookLabel";
            this.bookLabel.Size = new System.Drawing.Size(188, 38);
            this.bookLabel.TabIndex = 0;
            this.bookLabel.Text = "Book a flight";
            // 
            // clientLabel
            // 
            this.clientLabel.AutoSize = true;
            this.clientLabel.Location = new System.Drawing.Point(72, 226);
            this.clientLabel.Name = "clientLabel";
            this.clientLabel.Size = new System.Drawing.Size(118, 25);
            this.clientLabel.TabIndex = 1;
            this.clientLabel.Text = "Select a client";
            // 
            // flightNameLabel
            // 
            this.flightNameLabel.AutoSize = true;
            this.flightNameLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flightNameLabel.Location = new System.Drawing.Point(70, 125);
            this.flightNameLabel.Name = "flightNameLabel";
            this.flightNameLabel.Size = new System.Drawing.Size(193, 38);
            this.flightNameLabel.TabIndex = 13;
            this.flightNameLabel.Text = "<flightName>";
            // 
            // clientDropDown
            // 
            this.clientDropDown.FormattingEnabled = true;
            this.clientDropDown.Location = new System.Drawing.Point(68, 268);
            this.clientDropDown.Name = "clientDropDown";
            this.clientDropDown.Size = new System.Drawing.Size(329, 33);
            this.clientDropDown.TabIndex = 14;
            this.clientDropDown.SelectedIndexChanged += new System.EventHandler(this.clientDropDown_SelectedIndexChanged);
            // 
            // createClientLink
            // 
            this.createClientLink.AutoSize = true;
            this.createClientLink.Location = new System.Drawing.Point(301, 227);
            this.createClientLink.Name = "createClientLink";
            this.createClientLink.Size = new System.Drawing.Size(99, 25);
            this.createClientLink.TabIndex = 21;
            this.createClientLink.TabStop = true;
            this.createClientLink.Text = "Create new";
            this.createClientLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.createClientLink_LinkClicked);
            // 
            // clientInfoGroupBox
            // 
            this.clientInfoGroupBox.Controls.Add(this.telefoneValueLabel);
            this.clientInfoGroupBox.Controls.Add(this.emailValueLabel);
            this.clientInfoGroupBox.Controls.Add(this.enderecoValueLabel);
            this.clientInfoGroupBox.Controls.Add(this.nomeValueLabel);
            this.clientInfoGroupBox.Controls.Add(this.telefoneLabel);
            this.clientInfoGroupBox.Controls.Add(this.email);
            this.clientInfoGroupBox.Controls.Add(this.enderecoLabel);
            this.clientInfoGroupBox.Controls.Add(this.nomeLabel);
            this.clientInfoGroupBox.Location = new System.Drawing.Point(514, 125);
            this.clientInfoGroupBox.Name = "clientInfoGroupBox";
            this.clientInfoGroupBox.Size = new System.Drawing.Size(337, 229);
            this.clientInfoGroupBox.TabIndex = 22;
            this.clientInfoGroupBox.TabStop = false;
            this.clientInfoGroupBox.Text = "Client Info";
            // 
            // telefoneValueLabel
            // 
            this.telefoneValueLabel.AutoSize = true;
            this.telefoneValueLabel.Location = new System.Drawing.Point(167, 183);
            this.telefoneValueLabel.Name = "telefoneValueLabel";
            this.telefoneValueLabel.Size = new System.Drawing.Size(76, 25);
            this.telefoneValueLabel.TabIndex = 9;
            this.telefoneValueLabel.Text = "<none>";
            // 
            // emailValueLabel
            // 
            this.emailValueLabel.AutoSize = true;
            this.emailValueLabel.Location = new System.Drawing.Point(167, 134);
            this.emailValueLabel.Name = "emailValueLabel";
            this.emailValueLabel.Size = new System.Drawing.Size(76, 25);
            this.emailValueLabel.TabIndex = 8;
            this.emailValueLabel.Text = "<none>";
            // 
            // enderecoValueLabel
            // 
            this.enderecoValueLabel.AutoSize = true;
            this.enderecoValueLabel.Location = new System.Drawing.Point(167, 85);
            this.enderecoValueLabel.Name = "enderecoValueLabel";
            this.enderecoValueLabel.Size = new System.Drawing.Size(76, 25);
            this.enderecoValueLabel.TabIndex = 7;
            this.enderecoValueLabel.Text = "<none>";
            // 
            // nomeValueLabel
            // 
            this.nomeValueLabel.AutoSize = true;
            this.nomeValueLabel.Location = new System.Drawing.Point(167, 36);
            this.nomeValueLabel.Name = "nomeValueLabel";
            this.nomeValueLabel.Size = new System.Drawing.Size(76, 25);
            this.nomeValueLabel.TabIndex = 5;
            this.nomeValueLabel.Text = "<none>";
            // 
            // telefoneLabel
            // 
            this.telefoneLabel.AutoSize = true;
            this.telefoneLabel.Location = new System.Drawing.Point(17, 183);
            this.telefoneLabel.Name = "telefoneLabel";
            this.telefoneLabel.Size = new System.Drawing.Size(132, 25);
            this.telefoneLabel.TabIndex = 4;
            this.telefoneLabel.Text = "Phone Number";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(17, 134);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(54, 25);
            this.email.TabIndex = 3;
            this.email.Text = "Email";
            // 
            // enderecoLabel
            // 
            this.enderecoLabel.AutoSize = true;
            this.enderecoLabel.Location = new System.Drawing.Point(17, 85);
            this.enderecoLabel.Name = "enderecoLabel";
            this.enderecoLabel.Size = new System.Drawing.Size(77, 25);
            this.enderecoLabel.TabIndex = 2;
            this.enderecoLabel.Text = "Address";
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Location = new System.Drawing.Point(17, 36);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(59, 25);
            this.nomeLabel.TabIndex = 0;
            this.nomeLabel.Text = "Name";
            // 
            // bagsListBox
            // 
            this.bagsListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bagsListBox.ForeColor = System.Drawing.SystemColors.Window;
            this.bagsListBox.FormattingEnabled = true;
            this.bagsListBox.ItemHeight = 25;
            this.bagsListBox.Location = new System.Drawing.Point(514, 409);
            this.bagsListBox.Name = "bagsListBox";
            this.bagsListBox.Size = new System.Drawing.Size(337, 179);
            this.bagsListBox.TabIndex = 23;
            // 
            // CreateBagBtn
            // 
            this.CreateBagBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CreateBagBtn.Location = new System.Drawing.Point(121, 381);
            this.CreateBagBtn.Name = "CreateBagBtn";
            this.CreateBagBtn.Size = new System.Drawing.Size(201, 34);
            this.CreateBagBtn.TabIndex = 24;
            this.CreateBagBtn.Text = "Register Bag";
            this.CreateBagBtn.UseVisualStyleBackColor = true;
            this.CreateBagBtn.Click += new System.EventHandler(this.CreateBagBtn_Click);
            // 
            // bookbutton
            // 
            this.bookbutton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bookbutton.Location = new System.Drawing.Point(88, 469);
            this.bookbutton.Name = "bookbutton";
            this.bookbutton.Size = new System.Drawing.Size(282, 51);
            this.bookbutton.TabIndex = 25;
            this.bookbutton.Text = "Book";
            this.bookbutton.UseVisualStyleBackColor = true;
            this.bookbutton.Click += new System.EventHandler(this.bookbutton_Click);
            // 
            // clientBagsLabel
            // 
            this.clientBagsLabel.AutoSize = true;
            this.clientBagsLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.clientBagsLabel.Location = new System.Drawing.Point(509, 381);
            this.clientBagsLabel.Name = "clientBagsLabel";
            this.clientBagsLabel.Size = new System.Drawing.Size(99, 25);
            this.clientBagsLabel.TabIndex = 26;
            this.clientBagsLabel.Text = "Client Bags";
            // 
            // deleteBagBtn
            // 
            this.deleteBagBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.deleteBagBtn.Location = new System.Drawing.Point(857, 469);
            this.deleteBagBtn.Name = "deleteBagBtn";
            this.deleteBagBtn.Size = new System.Drawing.Size(99, 36);
            this.deleteBagBtn.TabIndex = 27;
            this.deleteBagBtn.Text = "Delete";
            this.deleteBagBtn.UseVisualStyleBackColor = true;
            this.deleteBagBtn.Click += new System.EventHandler(this.deleteBagBtn_Click);
            // 
            // updateClientInfo
            // 
            this.updateClientInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.updateClientInfo.Location = new System.Drawing.Point(857, 226);
            this.updateClientInfo.Name = "updateClientInfo";
            this.updateClientInfo.Size = new System.Drawing.Size(99, 36);
            this.updateClientInfo.TabIndex = 28;
            this.updateClientInfo.Text = "Update";
            this.updateClientInfo.UseVisualStyleBackColor = true;
            this.updateClientInfo.Click += new System.EventHandler(this.updateClientInfo_Click);
            // 
            // BookFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(968, 619);
            this.Controls.Add(this.updateClientInfo);
            this.Controls.Add(this.deleteBagBtn);
            this.Controls.Add(this.clientBagsLabel);
            this.Controls.Add(this.bookbutton);
            this.Controls.Add(this.CreateBagBtn);
            this.Controls.Add(this.bagsListBox);
            this.Controls.Add(this.clientInfoGroupBox);
            this.Controls.Add(this.createClientLink);
            this.Controls.Add(this.clientDropDown);
            this.Controls.Add(this.flightNameLabel);
            this.Controls.Add(this.clientLabel);
            this.Controls.Add(this.bookLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BookFlight";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book a flight";
            this.clientInfoGroupBox.ResumeLayout(false);
            this.clientInfoGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bookLabel;
        private System.Windows.Forms.Label clientLabel;
        private System.Windows.Forms.Label flightNameLabel;
        private System.Windows.Forms.ComboBox clientDropDown;
        private System.Windows.Forms.LinkLabel createClientLink;
        private System.Windows.Forms.GroupBox clientInfoGroupBox;
        private System.Windows.Forms.ListBox bagsListBox;
        private System.Windows.Forms.Button CreateBagBtn;
        private System.Windows.Forms.Label telefoneValueLabel;
        private System.Windows.Forms.Label emailValueLabel;
        private System.Windows.Forms.Label enderecoValueLabel;
        private System.Windows.Forms.Label nomeValueLabel;
        private System.Windows.Forms.Label telefoneLabel;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label enderecoLabel;
        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.Button bookbutton;
        private System.Windows.Forms.Label clientBagsLabel;
        private System.Windows.Forms.Button deleteBagBtn;
        private System.Windows.Forms.Button updateClientInfo;
    }
}