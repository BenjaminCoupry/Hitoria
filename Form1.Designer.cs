namespace Hitoria
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
            this.AffichageTexte = new System.Windows.Forms.RichTextBox();
            this.selecteurDir = new System.Windows.Forms.ComboBox();
            this.bGO = new System.Windows.Forms.Button();
            this.bretour = new System.Windows.Forms.Button();
            this.bOuvrirRep = new System.Windows.Forms.Button();
            this.bouvrirword = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.breload = new System.Windows.Forms.Button();
            this.selecteurModeles = new System.Windows.Forms.ListBox();
            this.indicPosition = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AffichageTexte
            // 
            this.AffichageTexte.Location = new System.Drawing.Point(13, 68);
            this.AffichageTexte.Name = "AffichageTexte";
            this.AffichageTexte.Size = new System.Drawing.Size(775, 435);
            this.AffichageTexte.TabIndex = 0;
            this.AffichageTexte.Text = "Chargez un repertoire... Creez des modeles au format .rtf dans le dossier _modele" +
    "s";
            this.AffichageTexte.SelectionChanged += new System.EventHandler(this.AffichageTexte_SelectionChanged);
            this.AffichageTexte.DoubleClick += new System.EventHandler(this.AffichageTexte_DoubleClick);
            // 
            // selecteurDir
            // 
            this.selecteurDir.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.selecteurDir.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.selecteurDir.FormattingEnabled = true;
            this.selecteurDir.Location = new System.Drawing.Point(13, 509);
            this.selecteurDir.Name = "selecteurDir";
            this.selecteurDir.Size = new System.Drawing.Size(212, 21);
            this.selecteurDir.TabIndex = 1;
            this.selecteurDir.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // bGO
            // 
            this.bGO.Location = new System.Drawing.Point(232, 509);
            this.bGO.Name = "bGO";
            this.bGO.Size = new System.Drawing.Size(75, 23);
            this.bGO.TabIndex = 2;
            this.bGO.Text = "Creer";
            this.bGO.UseVisualStyleBackColor = true;
            this.bGO.Click += new System.EventHandler(this.bGO_Click);
            // 
            // bretour
            // 
            this.bretour.Location = new System.Drawing.Point(232, 538);
            this.bretour.Name = "bretour";
            this.bretour.Size = new System.Drawing.Size(75, 23);
            this.bretour.TabIndex = 3;
            this.bretour.Text = "Retour";
            this.bretour.UseVisualStyleBackColor = true;
            this.bretour.Click += new System.EventHandler(this.bretour_Click);
            // 
            // bOuvrirRep
            // 
            this.bOuvrirRep.Location = new System.Drawing.Point(13, 13);
            this.bOuvrirRep.Name = "bOuvrirRep";
            this.bOuvrirRep.Size = new System.Drawing.Size(107, 23);
            this.bOuvrirRep.TabIndex = 6;
            this.bOuvrirRep.Text = "Ouvrir Repertoire";
            this.bOuvrirRep.UseVisualStyleBackColor = true;
            this.bOuvrirRep.Click += new System.EventHandler(this.bOuvrirRep_Click);
            // 
            // bouvrirword
            // 
            this.bouvrirword.Location = new System.Drawing.Point(527, 12);
            this.bouvrirword.Name = "bouvrirword";
            this.bouvrirword.Size = new System.Drawing.Size(123, 23);
            this.bouvrirword.TabIndex = 7;
            this.bouvrirword.Text = "Ouvrir dans Word";
            this.bouvrirword.UseVisualStyleBackColor = true;
            this.bouvrirword.Click += new System.EventHandler(this.bouvrirword_Click);
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(656, 12);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(75, 23);
            this.bSave.TabIndex = 8;
            this.bSave.Text = "Sauver";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // breload
            // 
            this.breload.Location = new System.Drawing.Point(446, 13);
            this.breload.Name = "breload";
            this.breload.Size = new System.Drawing.Size(75, 23);
            this.breload.TabIndex = 9;
            this.breload.Text = "Recharger";
            this.breload.UseVisualStyleBackColor = true;
            this.breload.Click += new System.EventHandler(this.breload_Click);
            // 
            // selecteurModeles
            // 
            this.selecteurModeles.FormattingEnabled = true;
            this.selecteurModeles.Location = new System.Drawing.Point(325, 509);
            this.selecteurModeles.Name = "selecteurModeles";
            this.selecteurModeles.Size = new System.Drawing.Size(208, 95);
            this.selecteurModeles.TabIndex = 10;
            // 
            // indicPosition
            // 
            this.indicPosition.AutoSize = true;
            this.indicPosition.Location = new System.Drawing.Point(12, 52);
            this.indicPosition.Name = "indicPosition";
            this.indicPosition.Size = new System.Drawing.Size(16, 13);
            this.indicPosition.TabIndex = 11;
            this.indicPosition.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 610);
            this.Controls.Add(this.indicPosition);
            this.Controls.Add(this.selecteurModeles);
            this.Controls.Add(this.breload);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.bouvrirword);
            this.Controls.Add(this.bOuvrirRep);
            this.Controls.Add(this.bretour);
            this.Controls.Add(this.bGO);
            this.Controls.Add(this.selecteurDir);
            this.Controls.Add(this.AffichageTexte);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox AffichageTexte;
        private System.Windows.Forms.ComboBox selecteurDir;
        private System.Windows.Forms.Button bGO;
        private System.Windows.Forms.Button bretour;
        private System.Windows.Forms.Button bOuvrirRep;
        private System.Windows.Forms.Button bouvrirword;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button breload;
        private System.Windows.Forms.ListBox selecteurModeles;
        private System.Windows.Forms.Label indicPosition;
    }
}

