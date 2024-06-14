namespace _3.Zadaca
{
    partial class Frmstudents
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
            this.btnMeni = new System.Windows.Forms.Button();
            this.btnPrikazKomentara = new System.Windows.Forms.Button();
            this.lblOdabir = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMeni
            // 
            this.btnMeni.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMeni.Location = new System.Drawing.Point(42, 144);
            this.btnMeni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMeni.Name = "btnMeni";
            this.btnMeni.Size = new System.Drawing.Size(189, 96);
            this.btnMeni.TabIndex = 4;
            this.btnMeni.Text = "Meni menze";
            this.btnMeni.UseVisualStyleBackColor = false;
            this.btnMeni.Click += new System.EventHandler(this.btnMeni_Click);
            // 
            // btnPrikazKomentara
            // 
            this.btnPrikazKomentara.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPrikazKomentara.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrikazKomentara.Location = new System.Drawing.Point(333, 144);
            this.btnPrikazKomentara.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrikazKomentara.Name = "btnPrikazKomentara";
            this.btnPrikazKomentara.Size = new System.Drawing.Size(188, 96);
            this.btnPrikazKomentara.TabIndex = 5;
            this.btnPrikazKomentara.Text = "Povratni komentari";
            this.btnPrikazKomentara.UseVisualStyleBackColor = false;
            this.btnPrikazKomentara.Click += new System.EventHandler(this.btnPrikazKomentara_Click);
            // 
            // lblOdabir
            // 
            this.lblOdabir.AutoSize = true;
            this.lblOdabir.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOdabir.Location = new System.Drawing.Point(58, 59);
            this.lblOdabir.Name = "lblOdabir";
            this.lblOdabir.Size = new System.Drawing.Size(401, 29);
            this.lblOdabir.TabIndex = 6;
            this.lblOdabir.Text = "Odaberite opciju pa vašem ukusu";
            // 
            // Frmstudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(548, 294);
            this.Controls.Add(this.lblOdabir);
            this.Controls.Add(this.btnPrikazKomentara);
            this.Controls.Add(this.btnMeni);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frmstudents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Izbornik";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnMeni;
        private System.Windows.Forms.Button btnPrikazKomentara;
        private System.Windows.Forms.Label lblOdabir;
    }
}