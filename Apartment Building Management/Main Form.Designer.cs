﻿namespace Apartment_Building_Management
{
    partial class MainForm
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
            this.buildingsBtn = new System.Windows.Forms.Button();
            this.categoriesOfCostBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.apartmentsBtn = new System.Windows.Forms.Button();
            this.dapanesBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buildingsBtn
            // 
            this.buildingsBtn.Location = new System.Drawing.Point(67, 66);
            this.buildingsBtn.Name = "buildingsBtn";
            this.buildingsBtn.Size = new System.Drawing.Size(140, 41);
            this.buildingsBtn.TabIndex = 0;
            this.buildingsBtn.Text = "Προσθήκη / επεξεργασία πολυκατοικίας";
            this.buildingsBtn.UseVisualStyleBackColor = true;
            this.buildingsBtn.Click += new System.EventHandler(this.buildingsBtn_Click);
            // 
            // categoriesOfCostBtn
            // 
            this.categoriesOfCostBtn.Location = new System.Drawing.Point(67, 186);
            this.categoriesOfCostBtn.Name = "categoriesOfCostBtn";
            this.categoriesOfCostBtn.Size = new System.Drawing.Size(140, 43);
            this.categoriesOfCostBtn.TabIndex = 1;
            this.categoriesOfCostBtn.Text = "Προσθήκη / επεξεργασία κατηγοριών δαπάνης";
            this.categoriesOfCostBtn.UseVisualStyleBackColor = true;
            this.categoriesOfCostBtn.Click += new System.EventHandler(this.categoriesOfCostBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(451, 303);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 2;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // apartmentsBtn
            // 
            this.apartmentsBtn.Location = new System.Drawing.Point(312, 66);
            this.apartmentsBtn.Name = "apartmentsBtn";
            this.apartmentsBtn.Size = new System.Drawing.Size(151, 41);
            this.apartmentsBtn.TabIndex = 3;
            this.apartmentsBtn.Text = "Προσθήκη / επεξεργασία διαμερισμάτων";
            this.apartmentsBtn.UseVisualStyleBackColor = true;
            this.apartmentsBtn.Click += new System.EventHandler(this.apartmentsBtn_Click);
            // 
            // dapanesBtn
            // 
            this.dapanesBtn.Location = new System.Drawing.Point(312, 186);
            this.dapanesBtn.Name = "dapanesBtn";
            this.dapanesBtn.Size = new System.Drawing.Size(151, 43);
            this.dapanesBtn.TabIndex = 4;
            this.dapanesBtn.Text = "Προσθήκη / επεξεργασία δαπάνης";
            this.dapanesBtn.UseVisualStyleBackColor = true;
            this.dapanesBtn.Click += new System.EventHandler(this.dapanesBtn_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(625, 367);
            this.Controls.Add(this.dapanesBtn);
            this.Controls.Add(this.apartmentsBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.categoriesOfCostBtn);
            this.Controls.Add(this.buildingsBtn);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buildingsBtn;
        private System.Windows.Forms.Button categoriesOfCostBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button apartmentsBtn;
        private System.Windows.Forms.Button dapanesBtn;
    }
}

