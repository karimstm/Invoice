namespace Facturation.PL
{
    partial class Facturation
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
            this.btnarticle = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.txtCodevent = new System.Windows.Forms.TextBox();
            this.txtQtevendu = new System.Windows.Forms.TextBox();
            this.txtQteStock = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txtdesigniation = new System.Windows.Forms.TextBox();
            this.txtarticle = new System.Windows.Forms.TextBox();
            this.btnclient = new System.Windows.Forms.Button();
            this.txtfirstname = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtCodeclient = new System.Windows.Forms.TextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dgvFacture = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnaddpro = new System.Windows.Forms.Button();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtsold = new System.Windows.Forms.TextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.btnaddclient = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.txtrest = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.PrintPurchase = new System.Windows.Forms.Button();
            this.btnAddnewPurchase = new System.Windows.Forms.Button();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacture)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnarticle
            // 
            this.btnarticle.Location = new System.Drawing.Point(321, 26);
            this.btnarticle.Name = "btnarticle";
            this.btnarticle.Size = new System.Drawing.Size(39, 23);
            this.btnarticle.TabIndex = 13;
            this.btnarticle.Text = "...";
            this.btnarticle.UseVisualStyleBackColor = true;
            this.btnarticle.Click += new System.EventHandler(this.btnarticle_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(632, 20);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(529, 21);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(36, 19);
            this.metroLabel10.TabIndex = 6;
            this.metroLabel10.Text = "Date";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(20, 21);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(70, 19);
            this.metroLabel9.TabIndex = 5;
            this.metroLabel9.Text = "Code Vent";
            // 
            // txtCodevent
            // 
            this.txtCodevent.Location = new System.Drawing.Point(116, 19);
            this.txtCodevent.Name = "txtCodevent";
            this.txtCodevent.ReadOnly = true;
            this.txtCodevent.Size = new System.Drawing.Size(192, 20);
            this.txtCodevent.TabIndex = 4;
            // 
            // txtQtevendu
            // 
            this.txtQtevendu.Location = new System.Drawing.Point(123, 161);
            this.txtQtevendu.Name = "txtQtevendu";
            this.txtQtevendu.Size = new System.Drawing.Size(192, 20);
            this.txtQtevendu.TabIndex = 12;
            this.txtQtevendu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtevendu_KeyPress);
            // 
            // txtQteStock
            // 
            this.txtQteStock.Location = new System.Drawing.Point(123, 126);
            this.txtQteStock.Name = "txtQteStock";
            this.txtQteStock.ReadOnly = true;
            this.txtQteStock.Size = new System.Drawing.Size(192, 20);
            this.txtQteStock.TabIndex = 11;
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(123, 96);
            this.txtprice.Name = "txtprice";
            this.txtprice.ReadOnly = true;
            this.txtprice.Size = new System.Drawing.Size(192, 20);
            this.txtprice.TabIndex = 10;
            // 
            // txtdesigniation
            // 
            this.txtdesigniation.Location = new System.Drawing.Point(123, 62);
            this.txtdesigniation.Name = "txtdesigniation";
            this.txtdesigniation.ReadOnly = true;
            this.txtdesigniation.Size = new System.Drawing.Size(192, 20);
            this.txtdesigniation.TabIndex = 9;
            // 
            // txtarticle
            // 
            this.txtarticle.Location = new System.Drawing.Point(123, 28);
            this.txtarticle.Name = "txtarticle";
            this.txtarticle.ReadOnly = true;
            this.txtarticle.Size = new System.Drawing.Size(192, 20);
            this.txtarticle.TabIndex = 8;
            // 
            // btnclient
            // 
            this.btnclient.Location = new System.Drawing.Point(327, 28);
            this.btnclient.Name = "btnclient";
            this.btnclient.Size = new System.Drawing.Size(50, 23);
            this.btnclient.TabIndex = 6;
            this.btnclient.Text = "...";
            this.btnclient.UseVisualStyleBackColor = true;
            this.btnclient.Click += new System.EventHandler(this.btnclient_Click);
            // 
            // txtfirstname
            // 
            this.txtfirstname.Location = new System.Drawing.Point(116, 96);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.ReadOnly = true;
            this.txtfirstname.Size = new System.Drawing.Size(192, 20);
            this.txtfirstname.TabIndex = 5;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(116, 62);
            this.txtname.Name = "txtname";
            this.txtname.ReadOnly = true;
            this.txtname.Size = new System.Drawing.Size(192, 20);
            this.txtname.TabIndex = 4;
            // 
            // txtCodeclient
            // 
            this.txtCodeclient.Location = new System.Drawing.Point(116, 28);
            this.txtCodeclient.Name = "txtCodeclient";
            this.txtCodeclient.ReadOnly = true;
            this.txtCodeclient.Size = new System.Drawing.Size(192, 20);
            this.txtCodeclient.TabIndex = 3;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(20, 126);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(66, 19);
            this.metroLabel7.TabIndex = 6;
            this.metroLabel7.Text = "Qte Stock";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(20, 28);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(83, 19);
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "Code Article";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(20, 96);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(31, 19);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "Prix";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(20, 62);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(80, 19);
            this.metroLabel6.TabIndex = 3;
            this.metroLabel6.Text = "Designiation";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(20, 28);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(78, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Code Client";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(20, 96);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(56, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Prenom";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(20, 62);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(39, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Nom";
            // 
            // dgvFacture
            // 
            this.dgvFacture.AllowUserToAddRows = false;
            this.dgvFacture.AllowUserToDeleteRows = false;
            this.dgvFacture.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFacture.BackgroundColor = System.Drawing.Color.White;
            this.dgvFacture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvFacture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacture.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvFacture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFacture.Location = new System.Drawing.Point(3, 16);
            this.dgvFacture.MultiSelect = false;
            this.dgvFacture.Name = "dgvFacture";
            this.dgvFacture.ReadOnly = true;
            this.dgvFacture.RowHeadersVisible = false;
            this.dgvFacture.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFacture.Size = new System.Drawing.Size(909, 189);
            this.dgvFacture.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Code Article";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Designiation";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Prix unitaire";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Qte vendus";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Montant";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvFacture);
            this.groupBox4.Location = new System.Drawing.Point(23, 359);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(915, 208);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnaddpro);
            this.groupBox3.Controls.Add(this.btnarticle);
            this.groupBox3.Controls.Add(this.txtQtevendu);
            this.groupBox3.Controls.Add(this.txtQteStock);
            this.groupBox3.Controls.Add(this.txtprice);
            this.groupBox3.Controls.Add(this.txtdesigniation);
            this.groupBox3.Controls.Add(this.txtarticle);
            this.groupBox3.Controls.Add(this.metroLabel8);
            this.groupBox3.Controls.Add(this.metroLabel7);
            this.groupBox3.Controls.Add(this.metroLabel4);
            this.groupBox3.Controls.Add(this.metroLabel5);
            this.groupBox3.Controls.Add(this.metroLabel6);
            this.groupBox3.Location = new System.Drawing.Point(532, 130);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(406, 214);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Article";
            // 
            // btnaddpro
            // 
            this.btnaddpro.Location = new System.Drawing.Point(361, 26);
            this.btnaddpro.Name = "btnaddpro";
            this.btnaddpro.Size = new System.Drawing.Size(40, 23);
            this.btnaddpro.TabIndex = 14;
            this.btnaddpro.Text = "+";
            this.btnaddpro.UseVisualStyleBackColor = true;
            this.btnaddpro.Click += new System.EventHandler(this.btnaddpro_Click);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(20, 162);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(76, 19);
            this.metroLabel8.TabIndex = 7;
            this.metroLabel8.Text = "Qte Vendus";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtsold);
            this.groupBox2.Controls.Add(this.metroLabel11);
            this.groupBox2.Controls.Add(this.btnaddclient);
            this.groupBox2.Controls.Add(this.btnclient);
            this.groupBox2.Controls.Add(this.txtfirstname);
            this.groupBox2.Controls.Add(this.txtname);
            this.groupBox2.Controls.Add(this.txtCodeclient);
            this.groupBox2.Controls.Add(this.metroLabel3);
            this.groupBox2.Controls.Add(this.metroLabel2);
            this.groupBox2.Controls.Add(this.metroLabel1);
            this.groupBox2.Location = new System.Drawing.Point(23, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(451, 214);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Client";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtsold
            // 
            this.txtsold.Location = new System.Drawing.Point(116, 136);
            this.txtsold.Name = "txtsold";
            this.txtsold.ReadOnly = true;
            this.txtsold.Size = new System.Drawing.Size(192, 20);
            this.txtsold.TabIndex = 9;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(20, 136);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(42, 19);
            this.metroLabel11.TabIndex = 8;
            this.metroLabel11.Text = "Solde";
            // 
            // btnaddclient
            // 
            this.btnaddclient.Location = new System.Drawing.Point(383, 28);
            this.btnaddclient.Name = "btnaddclient";
            this.btnaddclient.Size = new System.Drawing.Size(40, 23);
            this.btnaddclient.TabIndex = 7;
            this.btnaddclient.Text = "+";
            this.btnaddclient.UseVisualStyleBackColor = true;
            this.btnaddclient.Click += new System.EventHandler(this.btnaddclient_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.metroLabel10);
            this.groupBox1.Controls.Add(this.metroLabel9);
            this.groupBox1.Controls.Add(this.txtCodevent);
            this.groupBox1.Location = new System.Drawing.Point(23, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(915, 61);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(572, 581);
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(132, 20);
            this.txttotal.TabIndex = 13;
            // 
            // txtrest
            // 
            this.txtrest.Location = new System.Drawing.Point(803, 581);
            this.txtrest.Name = "txtrest";
            this.txtrest.ReadOnly = true;
            this.txtrest.Size = new System.Drawing.Size(132, 20);
            this.txtrest.TabIndex = 14;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.Gray;
            this.btnDelete.Location = new System.Drawing.Point(277, 578);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(197, 27);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Supprimer le produit sélectionné";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.White;
            this.btnAddProduct.FlatAppearance.BorderSize = 0;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.ForeColor = System.Drawing.Color.Gray;
            this.btnAddProduct.Location = new System.Drawing.Point(19, 578);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(197, 27);
            this.btnAddProduct.TabIndex = 17;
            this.btnAddProduct.Text = "Ajouter un Produit Dans la facture";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnCancel);
            this.groupBox5.Controls.Add(this.PrintPurchase);
            this.groupBox5.Controls.Add(this.btnAddnewPurchase);
            this.groupBox5.Location = new System.Drawing.Point(26, 611);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(639, 43);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.Gray;
            this.btnCancel.Location = new System.Drawing.Point(403, 10);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(107, 27);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // PrintPurchase
            // 
            this.PrintPurchase.BackColor = System.Drawing.Color.White;
            this.PrintPurchase.Enabled = false;
            this.PrintPurchase.FlatAppearance.BorderSize = 0;
            this.PrintPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintPurchase.ForeColor = System.Drawing.Color.Gray;
            this.PrintPurchase.Location = new System.Drawing.Point(198, 10);
            this.PrintPurchase.Name = "PrintPurchase";
            this.PrintPurchase.Size = new System.Drawing.Size(107, 27);
            this.PrintPurchase.TabIndex = 21;
            this.PrintPurchase.Text = "Imprimer la facture";
            this.PrintPurchase.UseVisualStyleBackColor = false;
            this.PrintPurchase.Click += new System.EventHandler(this.PrintPurchase_Click);
            // 
            // btnAddnewPurchase
            // 
            this.btnAddnewPurchase.BackColor = System.Drawing.Color.White;
            this.btnAddnewPurchase.FlatAppearance.BorderSize = 0;
            this.btnAddnewPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddnewPurchase.ForeColor = System.Drawing.Color.Gray;
            this.btnAddnewPurchase.Location = new System.Drawing.Point(9, 10);
            this.btnAddnewPurchase.Name = "btnAddnewPurchase";
            this.btnAddnewPurchase.Size = new System.Drawing.Size(107, 27);
            this.btnAddnewPurchase.TabIndex = 20;
            this.btnAddnewPurchase.Text = "Valider";
            this.btnAddnewPurchase.UseVisualStyleBackColor = false;
            this.btnAddnewPurchase.Click += new System.EventHandler(this.btnAddnewPurchase_Click);
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(494, 582);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(36, 19);
            this.metroLabel12.TabIndex = 20;
            this.metroLabel12.Text = "Total";
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(736, 582);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(47, 19);
            this.metroLabel13.TabIndex = 21;
            this.metroLabel13.Text = "Le rest";
            // 
            // Facturation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 659);
            this.Controls.Add(this.metroLabel13);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.txtrest);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Facturation";
            this.Resizable = false;
            this.Text = "Facturation";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacture)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnarticle;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private System.Windows.Forms.TextBox txtCodevent;
        private System.Windows.Forms.TextBox txtQtevendu;
        private System.Windows.Forms.TextBox txtQteStock;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.TextBox txtdesigniation;
        private System.Windows.Forms.TextBox txtarticle;
        private System.Windows.Forms.Button btnclient;
        private System.Windows.Forms.TextBox txtfirstname;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtCodeclient;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DataGridView dgvFacture;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.TextBox txtrest;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button PrintPurchase;
        private System.Windows.Forms.Button btnAddnewPurchase;
        private System.Windows.Forms.Button btnaddclient;
        private System.Windows.Forms.Button btnaddpro;
        private System.Windows.Forms.TextBox txtsold;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel13;
    }
}