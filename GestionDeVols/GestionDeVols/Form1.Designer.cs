namespace GestionDeVols
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.PnlNav = new System.Windows.Forms.Panel();
            this.BtnApropos = new System.Windows.Forms.Button();
            this.BtnVolAnnuler = new System.Windows.Forms.Button();
            this.BtnReservation = new System.Windows.Forms.Button();
            this.BtnVoyage = new System.Windows.Forms.Button();
            this.BtnPassager = new System.Windows.Forms.Button();
            this.BtnAcceuil = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnAvion = new System.Windows.Forms.Button();
            this.AcceuilTitre = new System.Windows.Forms.Label();
            this.PnlFormLoader = new System.Windows.Forms.Panel();
            this.Datelbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.PnlNav);
            this.panel1.Controls.Add(this.BtnApropos);
            this.panel1.Controls.Add(this.BtnVolAnnuler);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.BtnReservation);
            this.panel1.Controls.Add(this.BtnVoyage);
            this.panel1.Controls.Add(this.BtnAcceuil);
            this.panel1.Controls.Add(this.BtnPassager);
            this.panel1.Controls.Add(this.BtnAvion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 577);
            this.panel1.TabIndex = 0;
            // 
            // PnlNav
            // 
            this.PnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.PnlNav.Location = new System.Drawing.Point(0, 211);
            this.PnlNav.Name = "PnlNav";
            this.PnlNav.Size = new System.Drawing.Size(4, 100);
            this.PnlNav.TabIndex = 4;
            // 
            // BtnApropos
            // 
            this.BtnApropos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnApropos.FlatAppearance.BorderSize = 0;
            this.BtnApropos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnApropos.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnApropos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.BtnApropos.Image = ((System.Drawing.Image)(resources.GetObject("BtnApropos.Image")));
            this.BtnApropos.Location = new System.Drawing.Point(0, 535);
            this.BtnApropos.Name = "BtnApropos";
            this.BtnApropos.Size = new System.Drawing.Size(186, 42);
            this.BtnApropos.TabIndex = 3;
            this.BtnApropos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnApropos.UseVisualStyleBackColor = true;
            this.BtnApropos.Click += new System.EventHandler(this.BtnApropos_Click);
            this.BtnApropos.Leave += new System.EventHandler(this.BtnApropos_Leave);
            // 
            // BtnVolAnnuler
            // 
            this.BtnVolAnnuler.FlatAppearance.BorderSize = 0;
            this.BtnVolAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVolAnnuler.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVolAnnuler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.BtnVolAnnuler.Location = new System.Drawing.Point(0, 380);
            this.BtnVolAnnuler.Name = "BtnVolAnnuler";
            this.BtnVolAnnuler.Size = new System.Drawing.Size(186, 42);
            this.BtnVolAnnuler.TabIndex = 5;
            this.BtnVolAnnuler.Text = "Vol annulé";
            this.BtnVolAnnuler.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnVolAnnuler.UseVisualStyleBackColor = true;
            this.BtnVolAnnuler.Click += new System.EventHandler(this.BtnVolAnnuler_Click);
            this.BtnVolAnnuler.Leave += new System.EventHandler(this.BtnVolAnnuler_Leave);
            // 
            // BtnReservation
            // 
            this.BtnReservation.FlatAppearance.BorderSize = 0;
            this.BtnReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReservation.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReservation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.BtnReservation.Location = new System.Drawing.Point(0, 332);
            this.BtnReservation.Name = "BtnReservation";
            this.BtnReservation.Size = new System.Drawing.Size(186, 42);
            this.BtnReservation.TabIndex = 2;
            this.BtnReservation.Text = "Reservation";
            this.BtnReservation.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnReservation.UseVisualStyleBackColor = true;
            this.BtnReservation.Click += new System.EventHandler(this.BtnReservation_Click);
            this.BtnReservation.Leave += new System.EventHandler(this.BtnReservation_Leave);
            // 
            // BtnVoyage
            // 
            this.BtnVoyage.FlatAppearance.BorderSize = 0;
            this.BtnVoyage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVoyage.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVoyage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.BtnVoyage.Location = new System.Drawing.Point(0, 284);
            this.BtnVoyage.Name = "BtnVoyage";
            this.BtnVoyage.Size = new System.Drawing.Size(186, 42);
            this.BtnVoyage.TabIndex = 8;
            this.BtnVoyage.Text = "Les Voyages";
            this.BtnVoyage.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnVoyage.UseVisualStyleBackColor = true;
            this.BtnVoyage.Click += new System.EventHandler(this.BtnVoyage_Click);
            this.BtnVoyage.Leave += new System.EventHandler(this.BtnVoyage_Leave);
            // 
            // BtnPassager
            // 
            this.BtnPassager.FlatAppearance.BorderSize = 0;
            this.BtnPassager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPassager.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPassager.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.BtnPassager.Location = new System.Drawing.Point(0, 236);
            this.BtnPassager.Name = "BtnPassager";
            this.BtnPassager.Size = new System.Drawing.Size(186, 42);
            this.BtnPassager.TabIndex = 7;
            this.BtnPassager.Text = "Les Passagers";
            this.BtnPassager.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnPassager.UseVisualStyleBackColor = true;
            this.BtnPassager.Click += new System.EventHandler(this.BtnPassager_Click);
            this.BtnPassager.Leave += new System.EventHandler(this.BtnPassager_Leave);
            // 
            // BtnAcceuil
            // 
            this.BtnAcceuil.FlatAppearance.BorderSize = 0;
            this.BtnAcceuil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAcceuil.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAcceuil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.BtnAcceuil.Location = new System.Drawing.Point(0, 140);
            this.BtnAcceuil.Name = "BtnAcceuil";
            this.BtnAcceuil.Size = new System.Drawing.Size(186, 42);
            this.BtnAcceuil.TabIndex = 1;
            this.BtnAcceuil.Text = "Accueil";
            this.BtnAcceuil.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnAcceuil.UseVisualStyleBackColor = true;
            this.BtnAcceuil.Click += new System.EventHandler(this.BtnAcceuil_Click);
            this.BtnAcceuil.Leave += new System.EventHandler(this.BtnAcceuil_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 143);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.label2.Location = new System.Drawing.Point(55, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "i-voyage";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(58, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BtnAvion
            // 
            this.BtnAvion.FlatAppearance.BorderSize = 0;
            this.BtnAvion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAvion.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAvion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.BtnAvion.Location = new System.Drawing.Point(0, 188);
            this.BtnAvion.Name = "BtnAvion";
            this.BtnAvion.Size = new System.Drawing.Size(186, 42);
            this.BtnAvion.TabIndex = 6;
            this.BtnAvion.Text = "Nos Avions";
            this.BtnAvion.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnAvion.UseVisualStyleBackColor = true;
            this.BtnAvion.Click += new System.EventHandler(this.button2_Cklic);
            this.BtnAvion.Leave += new System.EventHandler(this.BtnAvion_Leave);
            // 
            // AcceuilTitre
            // 
            this.AcceuilTitre.AutoSize = true;
            this.AcceuilTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcceuilTitre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.AcceuilTitre.Location = new System.Drawing.Point(220, 22);
            this.AcceuilTitre.Name = "AcceuilTitre";
            this.AcceuilTitre.Size = new System.Drawing.Size(114, 32);
            this.AcceuilTitre.TabIndex = 1;
            this.AcceuilTitre.Text = "Accueil";
            // 
            // PnlFormLoader
            // 
            this.PnlFormLoader.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlFormLoader.Location = new System.Drawing.Point(186, 100);
            this.PnlFormLoader.Name = "PnlFormLoader";
            this.PnlFormLoader.Size = new System.Drawing.Size(765, 477);
            this.PnlFormLoader.TabIndex = 2;
            // 
            // Datelbl
            // 
            this.Datelbl.AutoSize = true;
            this.Datelbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datelbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.Datelbl.Location = new System.Drawing.Point(715, 35);
            this.Datelbl.Name = "Datelbl";
            this.Datelbl.Size = new System.Drawing.Size(42, 19);
            this.Datelbl.TabIndex = 3;
            this.Datelbl.Text = "Date";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(649, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "HEURE :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Datelbl);
            this.Controls.Add(this.PnlFormLoader);
            this.Controls.Add(this.AcceuilTitre);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnApropos;
        private System.Windows.Forms.Button BtnReservation;
        private System.Windows.Forms.Button BtnAcceuil;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel PnlNav;
        private System.Windows.Forms.Label AcceuilTitre;
        private System.Windows.Forms.Panel PnlFormLoader;
        private System.Windows.Forms.Button BtnVolAnnuler;
        private System.Windows.Forms.Button BtnVoyage;
        private System.Windows.Forms.Button BtnPassager;
        private System.Windows.Forms.Button BtnAvion;
        private System.Windows.Forms.Label Datelbl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}

