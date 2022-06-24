namespace GestionDeVols
{
    partial class Voyages
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Voyages));
            this.panel1 = new System.Windows.Forms.Panel();
            this.VoyageDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.VoyageSourceCb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.VoyageCodeCb = new System.Windows.Forms.ComboBox();
            this.VoyageDateDt = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.VoyageCoutTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.VoyageDestinationCb = new System.Windows.Forms.ComboBox();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VoyageDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.VoyageDGV);
            this.panel1.Controls.Add(this.VoyageSourceCb);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.VoyageCodeCb);
            this.panel1.Controls.Add(this.VoyageDateDt);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.VoyageCoutTb);
            this.panel1.Controls.Add(this.VoyageDestinationCb);
            this.panel1.Controls.Add(this.guna2Button4);
            this.panel1.Controls.Add(this.guna2Button2);
            this.panel1.Controls.Add(this.guna2Button1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(741, 412);
            this.panel1.TabIndex = 5;
            // 
            // VoyageDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.VoyageDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.VoyageDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.VoyageDGV.BackgroundColor = System.Drawing.Color.White;
            this.VoyageDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.VoyageDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.VoyageDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.VoyageDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.VoyageDGV.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.VoyageDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.VoyageDGV.EnableHeadersVisualStyles = false;
            this.VoyageDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.VoyageDGV.Location = new System.Drawing.Point(23, 173);
            this.VoyageDGV.Name = "VoyageDGV";
            this.VoyageDGV.RowHeadersVisible = false;
            this.VoyageDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.VoyageDGV.Size = new System.Drawing.Size(701, 236);
            this.VoyageDGV.TabIndex = 32;
            this.VoyageDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.VoyageDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.VoyageDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.VoyageDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.VoyageDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.VoyageDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.VoyageDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.VoyageDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.VoyageDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.VoyageDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VoyageDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.VoyageDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.VoyageDGV.ThemeStyle.HeaderStyle.Height = 25;
            this.VoyageDGV.ThemeStyle.ReadOnly = false;
            this.VoyageDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.VoyageDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.VoyageDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VoyageDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.VoyageDGV.ThemeStyle.RowsStyle.Height = 22;
            this.VoyageDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.VoyageDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.VoyageDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VoyageDGV_CellContentClick);
            // 
            // VoyageSourceCb
            // 
            this.VoyageSourceCb.FormattingEnabled = true;
            this.VoyageSourceCb.Items.AddRange(new object[] {
            "Allemagne",
            "Autriche",
            "Belgique",
            "Bulgarie",
            "Chypre",
            "Croatie",
            "Danemark",
            "Espagne",
            "Estonie",
            "Finlande",
            "France",
            "Grèce",
            "Hongrie",
            "Irlande",
            "Italie",
            "Lettonie",
            "Lituanie",
            "Luxembourg",
            "Malte",
            "Pays-Bas",
            "Pologne",
            "Portugal",
            "République tchèque",
            "Roumanie",
            "Slovaquie",
            "Slovénie",
            "Suède",
            "Madagascar"});
            this.VoyageSourceCb.Location = new System.Drawing.Point(300, 41);
            this.VoyageSourceCb.Name = "VoyageSourceCb";
            this.VoyageSourceCb.Size = new System.Drawing.Size(131, 21);
            this.VoyageSourceCb.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(442, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "Destination";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Location = new System.Drawing.Point(157, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 16);
            this.label7.TabIndex = 24;
            this.label7.Text = "Code d\'avion";
            // 
            // VoyageCodeCb
            // 
            this.VoyageCodeCb.FormattingEnabled = true;
            this.VoyageCodeCb.Items.AddRange(new object[] {
            "Malagasy"});
            this.VoyageCodeCb.Location = new System.Drawing.Point(160, 41);
            this.VoyageCodeCb.Name = "VoyageCodeCb";
            this.VoyageCodeCb.Size = new System.Drawing.Size(131, 21);
            this.VoyageCodeCb.TabIndex = 29;
            // 
            // VoyageDateDt
            // 
            this.VoyageDateDt.Location = new System.Drawing.Point(23, 42);
            this.VoyageDateDt.Name = "VoyageDateDt";
            this.VoyageDateDt.Size = new System.Drawing.Size(131, 20);
            this.VoyageDateDt.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Location = new System.Drawing.Point(590, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 16);
            this.label8.TabIndex = 27;
            this.label8.Text = "Cout de voyage";
            // 
            // VoyageCoutTb
            // 
            this.VoyageCoutTb.BorderColor = System.Drawing.Color.MediumSpringGreen;
            this.VoyageCoutTb.BorderRadius = 10;
            this.VoyageCoutTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.VoyageCoutTb.DefaultText = "";
            this.VoyageCoutTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.VoyageCoutTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.VoyageCoutTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.VoyageCoutTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.VoyageCoutTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.VoyageCoutTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.VoyageCoutTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.VoyageCoutTb.Location = new System.Drawing.Point(593, 39);
            this.VoyageCoutTb.Name = "VoyageCoutTb";
            this.VoyageCoutTb.PasswordChar = '\0';
            this.VoyageCoutTb.PlaceholderText = "";
            this.VoyageCoutTb.SelectedText = "";
            this.VoyageCoutTb.ShadowDecoration.BorderRadius = 10;
            this.VoyageCoutTb.Size = new System.Drawing.Size(131, 22);
            this.VoyageCoutTb.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.VoyageCoutTb.TabIndex = 26;
            // 
            // VoyageDestinationCb
            // 
            this.VoyageDestinationCb.FormattingEnabled = true;
            this.VoyageDestinationCb.Items.AddRange(new object[] {
            "Allemagne",
            "Autriche",
            "Belgique",
            "Bulgarie",
            "Chypre",
            "Croatie",
            "Danemark",
            "Espagne",
            "Estonie",
            "Finlande",
            "France",
            "Grèce",
            "Hongrie",
            "Irlande",
            "Italie",
            "Lettonie",
            "Lituanie",
            "Luxembourg",
            "Malte",
            "Pays-Bas",
            "Pologne",
            "Portugal",
            "République tchèque",
            "Roumanie",
            "Slovaquie",
            "Slovénie",
            "Suède",
            "Madagascar"});
            this.VoyageDestinationCb.Location = new System.Drawing.Point(445, 41);
            this.VoyageDestinationCb.Name = "VoyageDestinationCb";
            this.VoyageDestinationCb.Size = new System.Drawing.Size(131, 21);
            this.VoyageDestinationCb.TabIndex = 25;
            // 
            // guna2Button4
            // 
            this.guna2Button4.CheckedState.FillColor = System.Drawing.SystemColors.InfoText;
            this.guna2Button4.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.FillColor = System.Drawing.Color.Gray;
            this.guna2Button4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.Location = new System.Drawing.Point(456, 86);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(98, 26);
            this.guna2Button4.TabIndex = 23;
            this.guna2Button4.Text = "Réinitialiser";
            this.guna2Button4.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.CheckedState.FillColor = System.Drawing.SystemColors.InfoText;
            this.guna2Button2.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.Gray;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(322, 86);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(98, 26);
            this.guna2Button2.TabIndex = 21;
            this.guna2Button2.Text = "Modifier";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.CheckedState.FillColor = System.Drawing.SystemColors.InfoText;
            this.guna2Button1.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Gray;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(195, 86);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(98, 26);
            this.guna2Button1.TabIndex = 20;
            this.guna2Button1.Text = "Ajouter";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(333, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 22);
            this.label6.TabIndex = 19;
            this.label6.Text = "Voyages";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(299, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Source";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(33, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "i-Voyage";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(560, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 19);
            this.label5.TabIndex = 33;
            this.label5.Text = "Les passagers";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(659, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // Voyages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(765, 477);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Voyages";
            this.Text = "Voyages";
            this.Load += new System.EventHandler(this.Voyages_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VoyageDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox VoyageCoutTb;
        private System.Windows.Forms.ComboBox VoyageDestinationCb;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox VoyageSourceCb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox VoyageCodeCb;
        private System.Windows.Forms.DateTimePicker VoyageDateDt;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DataGridView VoyageDGV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}