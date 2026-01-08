namespace GestionScolariteIUT
{
    partial class FicheEtudiant
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FicheEtudiant));
            Filtre = new GroupBox();
            niveau = new Label();
            Parcours = new Label();
            mension = new Label();
            cycle = new Label();
            comboBox4 = new ComboBox();
            comboBoxParcours = new ComboBox();
            comboBoxMension = new ComboBox();
            comboBoxCycle = new ComboBox();
            Actions = new GroupBox();
            buttonCompte = new Button();
            buttonParametrage = new Button();
            buttonPayement = new Button();
            buttonInsciption = new Button();
            dataGridEtudiant = new DataGridView();
            numero = new DataGridViewTextBoxColumn();
            matricule = new DataGridViewTextBoxColumn();
            nom = new DataGridViewTextBoxColumn();
            DateNais = new DataGridViewTextBoxColumn();
            LieuNais = new DataGridViewTextBoxColumn();
            sexe = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            recherche = new Button();
            recherchEtu = new Label();
            research = new TextBox();
            LogoIUT = new PictureBox();
            Filtre.SuspendLayout();
            Actions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridEtudiant).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LogoIUT).BeginInit();
            SuspendLayout();
            // 
            // Filtre
            // 
            Filtre.Controls.Add(niveau);
            Filtre.Controls.Add(Parcours);
            Filtre.Controls.Add(mension);
            Filtre.Controls.Add(cycle);
            Filtre.Controls.Add(comboBox4);
            Filtre.Controls.Add(comboBoxParcours);
            Filtre.Controls.Add(comboBoxMension);
            Filtre.Controls.Add(comboBoxCycle);
            Filtre.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Filtre.Location = new Point(17, 232);
            Filtre.Margin = new Padding(3, 4, 3, 4);
            Filtre.Name = "Filtre";
            Filtre.Padding = new Padding(3, 4, 3, 4);
            Filtre.Size = new Size(838, 150);
            Filtre.TabIndex = 3;
            Filtre.TabStop = false;
            Filtre.Text = "Filtre";
            Filtre.Enter += Filtre_Enter;
            // 
            // niveau
            // 
            niveau.AutoSize = true;
            niveau.Location = new Point(644, 42);
            niveau.Name = "niveau";
            niveau.Size = new Size(60, 20);
            niveau.TabIndex = 7;
            niveau.Text = "Niveau";
            // 
            // Parcours
            // 
            Parcours.AutoSize = true;
            Parcours.Location = new Point(460, 42);
            Parcours.Name = "Parcours";
            Parcours.Size = new Size(77, 20);
            Parcours.TabIndex = 6;
            Parcours.Text = "Parcours";
            // 
            // mension
            // 
            mension.AutoSize = true;
            mension.Location = new Point(267, 42);
            mension.Name = "mension";
            mension.Size = new Size(72, 20);
            mension.TabIndex = 5;
            mension.Text = "Mension";
            mension.Click += mension_Click;
            // 
            // cycle
            // 
            cycle.AutoSize = true;
            cycle.Location = new Point(79, 42);
            cycle.Name = "cycle";
            cycle.Size = new Size(51, 20);
            cycle.TabIndex = 4;
            cycle.Text = "Cycle";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "1", "2", "3" });
            comboBox4.Location = new Point(648, 88);
            comboBox4.Margin = new Padding(3, 4, 3, 4);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(117, 28);
            comboBox4.TabIndex = 3;
            // 
            // comboBoxParcours
            // 
            comboBoxParcours.FormattingEnabled = true;
            comboBoxParcours.Items.AddRange(new object[] { "IA", "AAB", "MEB", "MIP", "GLO", "RT" });
            comboBoxParcours.Location = new Point(464, 88);
            comboBoxParcours.Margin = new Padding(3, 4, 3, 4);
            comboBoxParcours.Name = "comboBoxParcours";
            comboBoxParcours.Size = new Size(117, 28);
            comboBoxParcours.TabIndex = 2;
            // 
            // comboBoxMension
            // 
            comboBoxMension.FormattingEnabled = true;
            comboBoxMension.Items.AddRange(new object[] { "GIN", "GIM", "GBIO" });
            comboBoxMension.Location = new Point(271, 88);
            comboBoxMension.Margin = new Padding(3, 4, 3, 4);
            comboBoxMension.Name = "comboBoxMension";
            comboBoxMension.Size = new Size(117, 28);
            comboBoxMension.TabIndex = 1;
            // 
            // comboBoxCycle
            // 
            comboBoxCycle.FormattingEnabled = true;
            comboBoxCycle.Items.AddRange(new object[] { "DUT", "LICENCE Professionnelle" });
            comboBoxCycle.Location = new Point(83, 88);
            comboBoxCycle.Margin = new Padding(3, 4, 3, 4);
            comboBoxCycle.Name = "comboBoxCycle";
            comboBoxCycle.Size = new Size(117, 28);
            comboBoxCycle.TabIndex = 0;
            comboBoxCycle.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Actions
            // 
            Actions.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Actions.BackColor = SystemColors.Control;
            Actions.Controls.Add(buttonCompte);
            Actions.Controls.Add(buttonParametrage);
            Actions.Controls.Add(buttonPayement);
            Actions.Controls.Add(buttonInsciption);
            Actions.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Actions.ForeColor = Color.DarkGray;
            Actions.Location = new Point(960, 4);
            Actions.Margin = new Padding(3, 4, 3, 4);
            Actions.Name = "Actions";
            Actions.Padding = new Padding(3, 4, 3, 4);
            Actions.Size = new Size(156, 672);
            Actions.TabIndex = 4;
            Actions.TabStop = false;
            Actions.Text = "Actions";
            // 
            // buttonCompte
            // 
            buttonCompte.BackgroundImage = Properties.Resources.Capture4;
            buttonCompte.Location = new Point(6, 538);
            buttonCompte.Margin = new Padding(3, 4, 3, 4);
            buttonCompte.Name = "buttonCompte";
            buttonCompte.Size = new Size(140, 117);
            buttonCompte.TabIndex = 3;
            buttonCompte.UseVisualStyleBackColor = true;
            // 
            // buttonParametrage
            // 
            buttonParametrage.BackgroundImage = Properties.Resources.Capture3;
            buttonParametrage.Location = new Point(6, 394);
            buttonParametrage.Margin = new Padding(3, 4, 3, 4);
            buttonParametrage.Name = "buttonParametrage";
            buttonParametrage.Size = new Size(134, 111);
            buttonParametrage.TabIndex = 2;
            buttonParametrage.UseVisualStyleBackColor = true;
            // 
            // buttonPayement
            // 
            buttonPayement.BackgroundImage = Properties.Resources.Capture_2;
            buttonPayement.Location = new Point(16, 238);
            buttonPayement.Margin = new Padding(3, 4, 3, 4);
            buttonPayement.Name = "buttonPayement";
            buttonPayement.Size = new Size(118, 101);
            buttonPayement.TabIndex = 1;
            buttonPayement.UseVisualStyleBackColor = true;
            buttonPayement.Click += buttonPayement_Click;
            // 
            // buttonInsciption
            // 
            buttonInsciption.BackgroundImage = Properties.Resources.Capture;
            buttonInsciption.Location = new Point(6, 66);
            buttonInsciption.Margin = new Padding(3, 4, 3, 4);
            buttonInsciption.Name = "buttonInsciption";
            buttonInsciption.Size = new Size(144, 125);
            buttonInsciption.TabIndex = 0;
            buttonInsciption.UseVisualStyleBackColor = true;
            // 
            // dataGridEtudiant
            // 
            dataGridEtudiant.BackgroundColor = Color.White;
            dataGridEtudiant.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridEtudiant.Columns.AddRange(new DataGridViewColumn[] { numero, matricule, nom, DateNais, LieuNais, sexe });
            dataGridEtudiant.Location = new Point(17, 425);
            dataGridEtudiant.Margin = new Padding(3, 4, 3, 4);
            dataGridEtudiant.Name = "dataGridEtudiant";
            dataGridEtudiant.ReadOnly = true;
            dataGridEtudiant.RowHeadersWidth = 51;
            dataGridEtudiant.RowTemplate.Height = 24;
            dataGridEtudiant.Size = new Size(908, 234);
            dataGridEtudiant.TabIndex = 6;
            dataGridEtudiant.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // numero
            // 
            numero.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            numero.HeaderText = "N°";
            numero.MinimumWidth = 6;
            numero.Name = "numero";
            numero.Width = 55;
            // 
            // matricule
            // 
            matricule.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            matricule.HeaderText = "Matricule";
            matricule.MinimumWidth = 6;
            matricule.Name = "matricule";
            // 
            // nom
            // 
            nom.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nom.HeaderText = "Nom et prénom";
            nom.MinimumWidth = 6;
            nom.Name = "nom";
            // 
            // DateNais
            // 
            DateNais.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            DateNais.HeaderText = "Date de naissance";
            DateNais.MinimumWidth = 6;
            DateNais.Name = "DateNais";
            DateNais.Width = 145;
            // 
            // LieuNais
            // 
            LieuNais.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            LieuNais.HeaderText = "Lieu de naissance";
            LieuNais.MinimumWidth = 6;
            LieuNais.Name = "LieuNais";
            // 
            // sexe
            // 
            sexe.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            sexe.HeaderText = "Sexe";
            sexe.MinimumWidth = 6;
            sexe.Name = "sexe";
            sexe.Width = 69;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonShadow;
            label1.Location = new Point(166, 51);
            label1.Name = "label1";
            label1.Size = new Size(625, 43);
            label1.TabIndex = 0;
            label1.Text = "Bienvenue au service de la scolarité";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Tai Le", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(13, 398);
            label2.Name = "label2";
            label2.Size = new Size(191, 23);
            label2.TabIndex = 7;
            label2.Text = "Rechercher un étudiant";
            // 
            // recherche
            // 
            recherche.Location = new Point(817, 171);
            recherche.Margin = new Padding(3, 4, 3, 4);
            recherche.Name = "recherche";
            recherche.Size = new Size(115, 32);
            recherche.TabIndex = 8;
            recherche.Text = "Recherche";
            recherche.UseVisualStyleBackColor = true;
            // 
            // recherchEtu
            // 
            recherchEtu.AutoSize = true;
            recherchEtu.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            recherchEtu.Location = new Point(75, 171);
            recherchEtu.Name = "recherchEtu";
            recherchEtu.Size = new Size(213, 25);
            recherchEtu.TabIndex = 8;
            recherchEtu.Text = "Rechercher un étudiant";
            // 
            // research
            // 
            research.Location = new Point(306, 171);
            research.Margin = new Padding(3, 4, 3, 4);
            research.Name = "research";
            research.Size = new Size(505, 27);
            research.TabIndex = 9;
            // 
            // LogoIUT
            // 
            LogoIUT.Image = Properties.Resources.Capture_5;
            LogoIUT.InitialImage = (Image)resources.GetObject("LogoIUT.InitialImage");
            LogoIUT.Location = new Point(17, 18);
            LogoIUT.Margin = new Padding(3, 4, 3, 4);
            LogoIUT.Name = "LogoIUT";
            LogoIUT.Size = new Size(109, 104);
            LogoIUT.TabIndex = 0;
            LogoIUT.TabStop = false;
            // 
            // FicheEtudiant
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(research);
            Controls.Add(recherchEtu);
            Controls.Add(recherche);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(dataGridEtudiant);
            Controls.Add(Actions);
            Controls.Add(Filtre);
            Controls.Add(LogoIUT);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FicheEtudiant";
            Size = new Size(1119, 679);
            Filtre.ResumeLayout(false);
            Filtre.PerformLayout();
            Actions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridEtudiant).EndInit();
            ((System.ComponentModel.ISupportInitialize)LogoIUT).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LogoIUT;
        private System.Windows.Forms.GroupBox Filtre;
        private System.Windows.Forms.GroupBox Actions;
        private System.Windows.Forms.DataGridView dataGridEtudiant;
        private System.Windows.Forms.Button buttonInsciption;
        private System.Windows.Forms.Button buttonCompte;
        private System.Windows.Forms.Button buttonParametrage;
        private System.Windows.Forms.Button buttonPayement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn matricule;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateNais;
        private System.Windows.Forms.DataGridViewTextBoxColumn LieuNais;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexe;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBoxParcours;
        private System.Windows.Forms.ComboBox comboBoxMension;
        private System.Windows.Forms.ComboBox comboBoxCycle;
        private System.Windows.Forms.Label cycle;
        private System.Windows.Forms.Label mension;
        private System.Windows.Forms.Label niveau;
        private System.Windows.Forms.Label Parcours;
        private System.Windows.Forms.Button recherche;
        private System.Windows.Forms.Label recherchEtu;
        private System.Windows.Forms.TextBox research;
    }
}
