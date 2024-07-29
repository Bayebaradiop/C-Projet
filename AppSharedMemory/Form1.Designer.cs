namespace AppSharedMemory
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
            this.dgJury = new System.Windows.Forms.DataGridView();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSpecialite = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgJury)).BeginInit();
            this.SuspendLayout();
            // 
            // dgJury
            // 
            this.dgJury.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgJury.Location = new System.Drawing.Point(248, 4);
            this.dgJury.Name = "dgJury";
            this.dgJury.Size = new System.Drawing.Size(550, 434);
            this.dgJury.TabIndex = 0;
            this.dgJury.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgJury_CellContentClick);
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(22, 52);
            this.txtPrenom.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrenom.Multiline = true;
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(163, 29);
            this.txtPrenom.TabIndex = 5;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(92, 356);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(2);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(91, 29);
            this.btnAjouter.TabIndex = 16;
            this.btnAjouter.Text = "&Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // txtGrade
            // 
            this.txtGrade.Location = new System.Drawing.Point(22, 202);
            this.txtGrade.Margin = new System.Windows.Forms.Padding(2);
            this.txtGrade.Multiline = true;
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(163, 29);
            this.txtGrade.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 174);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Grade";
            // 
            // txtSpecialite
            // 
            this.txtSpecialite.Location = new System.Drawing.Point(22, 279);
            this.txtSpecialite.Margin = new System.Windows.Forms.Padding(2);
            this.txtSpecialite.Multiline = true;
            this.txtSpecialite.Name = "txtSpecialite";
            this.txtSpecialite.Size = new System.Drawing.Size(163, 29);
            this.txtSpecialite.TabIndex = 13;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(22, 125);
            this.txtNom.Margin = new System.Windows.Forms.Padding(2);
            this.txtNom.Multiline = true;
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(163, 29);
            this.txtNom.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 249);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Specialite";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Prenom";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSpecialite);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.dgJury);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgJury)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgJury;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSpecialite;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

