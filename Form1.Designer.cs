namespace GestionScolariteIUT
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
            groupBox1 = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            TBxpwd = new TextBox();
            TBxlogin = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox1.BackColor = SystemColors.GradientActiveCaption;
            groupBox1.BackgroundImageLayout = ImageLayout.None;
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(TBxpwd);
            groupBox1.Controls.Add(TBxlogin);
            groupBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(384, 35);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(459, 427);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Connectez vous";
            // 
            // button2
            // 
            button2.BackColor = Color.Crimson;
            button2.CausesValidation = false;
            button2.Font = new Font("Microsoft Uighur", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(117, 338);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(157, 40);
            button2.TabIndex = 6;
            button2.Text = "Quitter";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Uighur", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(296, 338);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(157, 40);
            button1.TabIndex = 5;
            button1.Text = "Se connecter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Uighur", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(48, 117);
            label1.Name = "label1";
            label1.Size = new Size(46, 27);
            label1.TabIndex = 4;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Uighur", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(48, 216);
            label2.Name = "label2";
            label2.Size = new Size(84, 27);
            label2.TabIndex = 3;
            label2.Text = "Mot de passe";
            // 
            // TBxpwd
            // 
            TBxpwd.Font = new Font("Microsoft Uighur", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            TBxpwd.Location = new Point(154, 216);
            TBxpwd.Margin = new Padding(3, 4, 3, 4);
            TBxpwd.Name = "TBxpwd";
            TBxpwd.PlaceholderText = "**********";
            TBxpwd.Size = new Size(289, 27);
            TBxpwd.TabIndex = 1;
            TBxpwd.UseSystemPasswordChar = true;
            TBxpwd.TextChanged += TBxpwd_TextChanged;
            // 
            // TBxlogin
            // 
            TBxlogin.Font = new Font("Microsoft Uighur", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            TBxlogin.Location = new Point(154, 115);
            TBxlogin.Margin = new Padding(3, 4, 3, 4);
            TBxlogin.Name = "TBxlogin";
            TBxlogin.PlaceholderText = "Entrez votre identifiant";
            TBxlogin.Size = new Size(289, 27);
            TBxlogin.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(855, 493);
            Controls.Add(groupBox1);
            ForeColor = SystemColors.ActiveCaption;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Connexion";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TBxlogin;
        private System.Windows.Forms.TextBox TBxpwd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

