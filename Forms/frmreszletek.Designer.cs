namespace WFA220227
{
    partial class frmreszletek
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
            this.lblNev = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEvek = new System.Windows.Forms.Label();
            this.lblFoglalkozasok = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNev
            // 
            this.lblNev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNev.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNev.Location = new System.Drawing.Point(12, 34);
            this.lblNev.Name = "lblNev";
            this.lblNev.Size = new System.Drawing.Size(372, 21);
            this.lblNev.TabIndex = 0;
            this.lblNev.Text = "label1";
            this.lblNev.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.IndianRed;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fő foglalkozásai:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "A díjat elnyerte:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEvek
            // 
            this.lblEvek.AutoSize = true;
            this.lblEvek.Location = new System.Drawing.Point(149, 263);
            this.lblEvek.Name = "lblEvek";
            this.lblEvek.Size = new System.Drawing.Size(0, 21);
            this.lblEvek.TabIndex = 4;
            // 
            // lblFoglalkozasok
            // 
            this.lblFoglalkozasok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFoglalkozasok.BackColor = System.Drawing.Color.IndianRed;
            this.lblFoglalkozasok.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFoglalkozasok.Location = new System.Drawing.Point(12, 109);
            this.lblFoglalkozasok.Name = "lblFoglalkozasok";
            this.lblFoglalkozasok.Size = new System.Drawing.Size(372, 131);
            this.lblFoglalkozasok.TabIndex = 5;
            // 
            // frmreszletek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(396, 311);
            this.Controls.Add(this.lblFoglalkozasok);
            this.Controls.Add(this.lblEvek);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNev);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmreszletek";
            this.Text = "Részletek";
            this.Load += new System.EventHandler(this.frmreszletek_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNev;
        private Label label1;
        private Label label2;
        private Label lblEvek;
        private Label lblFoglalkozasok;
    }
}