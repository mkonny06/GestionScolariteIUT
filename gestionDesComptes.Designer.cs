namespace GestionScolariteIUT
{
    partial class gestionDesComptes
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
            groupBox1 = new GroupBox();
            button2 = new Button();
            comboBox1 = new ComboBox();
            button1 = new Button();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            MotDePasse = new Label();
            Mdpasse = new Label();
            Login = new Label();
            SelectPerson = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            numero = new DataGridViewTextBoxColumn();
            proprietaire = new DataGridViewTextBoxColumn();
            poste = new DataGridViewTextBoxColumn();
            identifiant = new DataGridViewTextBoxColumn();
            MDP = new DataGridViewTextBoxColumn();
            etat = new DataGridViewTextBoxColumn();
            action = new DataGridViewTextBoxColumn();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(MotDePasse);
            groupBox1.Controls.Add(Mdpasse);
            groupBox1.Controls.Add(Login);
            groupBox1.Controls.Add(SelectPerson);
            groupBox1.Location = new Point(17, 87);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(808, 267);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button2
            // 
            button2.Location = new Point(666, 224);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(120, 29);
            button2.TabIndex = 10;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(292, 38);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(392, 28);
            comboBox1.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(486, 224);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(126, 29);
            button1.TabIndex = 8;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(292, 180);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "**********";
            textBox4.Size = new Size(392, 27);
            textBox4.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(292, 129);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "**********";
            textBox3.Size = new Size(392, 27);
            textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(292, 78);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Entrez votre login";
            textBox2.Size = new Size(392, 27);
            textBox2.TabIndex = 5;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // MotDePasse
            // 
            MotDePasse.AutoSize = true;
            MotDePasse.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MotDePasse.ForeColor = SystemColors.ControlDarkDark;
            MotDePasse.Location = new Point(34, 180);
            MotDePasse.Name = "MotDePasse";
            MotDePasse.Size = new Size(232, 20);
            MotDePasse.TabIndex = 3;
            MotDePasse.Text = "Confirmer le mot de passe";
            // 
            // Mdpasse
            // 
            Mdpasse.AutoSize = true;
            Mdpasse.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Mdpasse.ForeColor = SystemColors.ControlDarkDark;
            Mdpasse.Location = new Point(34, 129);
            Mdpasse.Name = "Mdpasse";
            Mdpasse.Size = new Size(122, 20);
            Mdpasse.TabIndex = 2;
            Mdpasse.Text = "Mot de passe";
            // 
            // Login
            // 
            Login.AutoSize = true;
            Login.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Login.ForeColor = SystemColors.ControlDarkDark;
            Login.Location = new Point(34, 78);
            Login.Name = "Login";
            Login.Size = new Size(55, 20);
            Login.TabIndex = 1;
            Login.Text = "Login";
            // 
            // SelectPerson
            // 
            SelectPerson.AutoSize = true;
            SelectPerson.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SelectPerson.ForeColor = SystemColors.ControlDarkDark;
            SelectPerson.Location = new Point(34, 38);
            SelectPerson.Name = "SelectPerson";
            SelectPerson.Size = new Size(223, 20);
            SelectPerson.TabIndex = 0;
            SelectPerson.Text = "Selectionner le personnel";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.BackgroundImage = Properties.Resources.Capture_9;
            pictureBox1.Location = new Point(831, 97);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 257);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveBorder;
            label2.Location = new Point(17, 29);
            label2.Name = "label2";
            label2.Size = new Size(419, 32);
            label2.TabIndex = 1;
            label2.Text = "Gérer les comptes utilisateurs";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { numero, proprietaire, poste, identifiant, MDP, etat, action });
            dataGridView1.Location = new Point(17, 394);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new Size(1064, 298);
            dataGridView1.TabIndex = 2;
            // 
            // numero
            // 
            numero.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            numero.HeaderText = "N°";
            numero.MinimumWidth = 6;
            numero.Name = "numero";
            numero.Width = 55;
            // 
            // proprietaire
            // 
            proprietaire.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            proprietaire.HeaderText = "Propriétaire";
            proprietaire.MinimumWidth = 6;
            proprietaire.Name = "proprietaire";
            // 
            // poste
            // 
            poste.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            poste.HeaderText = "Poste";
            poste.MinimumWidth = 6;
            poste.Name = "poste";
            // 
            // identifiant
            // 
            identifiant.HeaderText = "Login";
            identifiant.MinimumWidth = 6;
            identifiant.Name = "identifiant";
            identifiant.Width = 125;
            // 
            // MDP
            // 
            MDP.HeaderText = "Mot de passe";
            MDP.MinimumWidth = 6;
            MDP.Name = "MDP";
            MDP.Width = 125;
            // 
            // etat
            // 
            etat.HeaderText = "Etat";
            etat.MinimumWidth = 6;
            etat.Name = "etat";
            etat.Width = 125;
            // 
            // action
            // 
            action.HeaderText = "Action";
            action.MinimumWidth = 6;
            action.Name = "action";
            action.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(17, 368);
            label1.Name = "label1";
            label1.Size = new Size(147, 20);
            label1.TabIndex = 3;
            label1.Text = "Liste des comptes";
            // 
            // gestionDesComptes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "gestionDesComptes";
            Size = new Size(1095, 696);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label SelectPerson;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Mdpasse;
        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label MotDePasse;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn proprietaire;
        private System.Windows.Forms.DataGridViewTextBoxColumn poste;
        private System.Windows.Forms.DataGridViewTextBoxColumn identifiant;
        private System.Windows.Forms.DataGridViewTextBoxColumn MDP;
        private System.Windows.Forms.DataGridViewTextBoxColumn etat;
        private System.Windows.Forms.DataGridViewTextBoxColumn action;
        private System.Windows.Forms.Label label1;
    }
}
