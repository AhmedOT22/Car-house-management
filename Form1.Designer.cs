
namespace WindowsFormsAppGrA
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionDeVoituresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterVoitureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercherVoitureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listerVoituresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDeVoituresToolStripMenuItem,
            this.aideToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1258, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionDeVoituresToolStripMenuItem
            // 
            this.gestionDeVoituresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterVoitureToolStripMenuItem,
            this.rechercherVoitureToolStripMenuItem,
            this.listerVoituresToolStripMenuItem,
            this.toolStripMenuItem1,
            this.quitterToolStripMenuItem});
            this.gestionDeVoituresToolStripMenuItem.Name = "gestionDeVoituresToolStripMenuItem";
            this.gestionDeVoituresToolStripMenuItem.Size = new System.Drawing.Size(181, 29);
            this.gestionDeVoituresToolStripMenuItem.Text = "Gestion de voitures";
            // 
            // ajouterVoitureToolStripMenuItem
            // 
            this.ajouterVoitureToolStripMenuItem.Name = "ajouterVoitureToolStripMenuItem";
            this.ajouterVoitureToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.ajouterVoitureToolStripMenuItem.Text = "Ajouter Voiture";
            this.ajouterVoitureToolStripMenuItem.Click += new System.EventHandler(this.ajouterVoitureToolStripMenuItem_Click);
            // 
            // rechercherVoitureToolStripMenuItem
            // 
            this.rechercherVoitureToolStripMenuItem.Name = "rechercherVoitureToolStripMenuItem";
            this.rechercherVoitureToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.rechercherVoitureToolStripMenuItem.Text = "Rechercher Voiture";
            this.rechercherVoitureToolStripMenuItem.Click += new System.EventHandler(this.rechercherVoitureToolStripMenuItem_Click);
            // 
            // listerVoituresToolStripMenuItem
            // 
            this.listerVoituresToolStripMenuItem.Name = "listerVoituresToolStripMenuItem";
            this.listerVoituresToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.listerVoituresToolStripMenuItem.Text = "Lister Voitures";
            this.listerVoituresToolStripMenuItem.Click += new System.EventHandler(this.listerVoituresToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(267, 6);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aProposDeToolStripMenuItem});
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(64, 29);
            this.aideToolStripMenuItem.Text = "Aide";
            // 
            // aProposDeToolStripMenuItem
            // 
            this.aProposDeToolStripMenuItem.Name = "aProposDeToolStripMenuItem";
            this.aProposDeToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.aProposDeToolStripMenuItem.Text = "A propos de ...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1258, 752);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Gestion de voitures";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionDeVoituresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterVoitureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechercherVoitureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listerVoituresToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aProposDeToolStripMenuItem;
    }
}

