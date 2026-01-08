namespace GestionScolariteIUT
{
    partial class GestionDuPersonnel
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxName = new TextBox();
            textBoxFonction = new TextBox();
            textBoxEmail = new TextBox();
            groupBox1 = new GroupBox();
            anuler = new Button();
            Enregistrer = new Button();
            radioButtonMasculin = new RadioButton();
            radioButtonFeminin = new RadioButton();
            label5 = new Label();
            label6 = new Label();
            dataGridViewPersonnel = new DataGridView();
            numero = new DataGridViewTextBoxColumn();
            fulName = new DataGridViewTextBoxColumn();
            sexe = new DataGridViewTextBoxColumn();
            Fonction = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPersonnel).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.Capture_6;
            pictureBox1.Location = new Point(689, 84);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(393, 262);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonShadow;
            label1.Location = new Point(48, 36);
            label1.Name = "label1";
            label1.Size = new Size(151, 22);
            label1.TabIndex = 1;
            label1.Text = "Nom et prénom:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonShadow;
            label2.Location = new Point(48, 82);
            label2.Name = "label2";
            label2.Size = new Size(61, 22);
            label2.TabIndex = 2;
            label2.Text = "Sexe:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonShadow;
            label3.Location = new Point(48, 127);
            label3.Name = "label3";
            label3.Size = new Size(93, 22);
            label3.TabIndex = 3;
            label3.Text = "Fonction:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonShadow;
            label4.Location = new Point(48, 174);
            label4.Name = "label4";
            label4.Size = new Size(65, 22);
            label4.TabIndex = 4;
            label4.Text = "Email:";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(225, 36);
            textBoxName.Margin = new Padding(3, 4, 3, 4);
            textBoxName.Name = "textBoxName";
            textBoxName.PlaceholderText = "Entrez vos nom et prénom";
            textBoxName.Size = new Size(345, 27);
            textBoxName.TabIndex = 5;
            // 
            // textBoxFonction
            // 
            textBoxFonction.Location = new Point(225, 127);
            textBoxFonction.Margin = new Padding(3, 4, 3, 4);
            textBoxFonction.Name = "textBoxFonction";
            textBoxFonction.PlaceholderText = "Entrez votre fonction";
            textBoxFonction.Size = new Size(345, 27);
            textBoxFonction.TabIndex = 6;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(225, 173);
            textBoxEmail.Margin = new Padding(3, 4, 3, 4);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.PlaceholderText = "Entrez votre adresse Email";
            textBoxEmail.Size = new Size(345, 27);
            textBoxEmail.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(anuler);
            groupBox1.Controls.Add(Enregistrer);
            groupBox1.Controls.Add(radioButtonMasculin);
            groupBox1.Controls.Add(radioButtonFeminin);
            groupBox1.Controls.Add(textBoxEmail);
            groupBox1.Controls.Add(textBoxFonction);
            groupBox1.Controls.Add(textBoxName);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(15, 73);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(653, 273);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            // 
            // anuler
            // 
            anuler.BackColor = Color.PaleVioletRed;
            anuler.Location = new Point(374, 224);
            anuler.Margin = new Padding(3, 4, 3, 4);
            anuler.Name = "anuler";
            anuler.Size = new Size(110, 34);
            anuler.TabIndex = 12;
            anuler.Text = "Anuler";
            anuler.UseVisualStyleBackColor = false;
            // 
            // Enregistrer
            // 
            Enregistrer.BackColor = Color.PaleGreen;
            Enregistrer.Location = new Point(553, 224);
            Enregistrer.Margin = new Padding(3, 4, 3, 4);
            Enregistrer.Name = "Enregistrer";
            Enregistrer.Size = new Size(110, 34);
            Enregistrer.TabIndex = 11;
            Enregistrer.Text = "Enregistrer";
            Enregistrer.UseVisualStyleBackColor = false;
            // 
            // radioButtonMasculin
            // 
            radioButtonMasculin.AutoSize = true;
            radioButtonMasculin.Location = new Point(374, 80);
            radioButtonMasculin.Margin = new Padding(3, 4, 3, 4);
            radioButtonMasculin.Name = "radioButtonMasculin";
            radioButtonMasculin.Size = new Size(88, 24);
            radioButtonMasculin.TabIndex = 9;
            radioButtonMasculin.TabStop = true;
            radioButtonMasculin.Text = "Masculin";
            radioButtonMasculin.UseVisualStyleBackColor = true;
            radioButtonMasculin.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButtonFeminin
            // 
            radioButtonFeminin.AutoSize = true;
            radioButtonFeminin.Location = new Point(225, 82);
            radioButtonFeminin.Margin = new Padding(3, 4, 3, 4);
            radioButtonFeminin.Name = "radioButtonFeminin";
            radioButtonFeminin.Size = new Size(82, 24);
            radioButtonFeminin.TabIndex = 8;
            radioButtonFeminin.TabStop = true;
            radioButtonFeminin.Text = "Feminin";
            radioButtonFeminin.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(15, 367);
            label5.Name = "label5";
            label5.Size = new Size(147, 20);
            label5.TabIndex = 10;
            label5.Text = "Liste du personnel";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ActiveBorder;
            label6.Location = new Point(15, 37);
            label6.Name = "label6";
            label6.Size = new Size(432, 32);
            label6.TabIndex = 11;
            label6.Text = "Gérer le personnel de la scolarité";
            // 
            // dataGridViewPersonnel
            // 
            dataGridViewPersonnel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewPersonnel.BackgroundColor = Color.White;
            dataGridViewPersonnel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPersonnel.Columns.AddRange(new DataGridViewColumn[] { numero, fulName, sexe, Fonction, Email });
            dataGridViewPersonnel.Location = new Point(15, 401);
            dataGridViewPersonnel.Margin = new Padding(3, 4, 3, 4);
            dataGridViewPersonnel.Name = "dataGridViewPersonnel";
            dataGridViewPersonnel.RowHeadersWidth = 51;
            dataGridViewPersonnel.RowTemplate.Height = 24;
            dataGridViewPersonnel.Size = new Size(1067, 292);
            dataGridViewPersonnel.TabIndex = 12;
            dataGridViewPersonnel.CellContentClick += dataGridViewPersonnel_CellContentClick;
            // 
            // numero
            // 
            numero.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            numero.HeaderText = "N°";
            numero.MinimumWidth = 6;
            numero.Name = "numero";
            numero.Width = 55;
            // 
            // fulName
            // 
            fulName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            fulName.HeaderText = "Nom complet";
            fulName.MinimumWidth = 6;
            fulName.Name = "fulName";
            // 
            // sexe
            // 
            sexe.HeaderText = "Sexe";
            sexe.MinimumWidth = 6;
            sexe.Name = "sexe";
            sexe.Width = 125;
            // 
            // Fonction
            // 
            Fonction.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Fonction.HeaderText = "Fonction";
            Fonction.MinimumWidth = 6;
            Fonction.Name = "Fonction";
            // 
            // Email
            // 
            Email.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            // 
            // GestionDuPersonnel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(dataGridViewPersonnel);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "GestionDuPersonnel";
            Size = new Size(1100, 698);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPersonnel).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxFonction;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonMasculin;
        private System.Windows.Forms.RadioButton radioButtonFeminin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridViewPersonnel;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn fulName;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fonction;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.Button anuler;
        private System.Windows.Forms.Button Enregistrer;
    }
}
