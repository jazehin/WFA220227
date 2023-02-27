namespace WFA220227
{
    partial class frmuj
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUjSzemely = new System.Windows.Forms.Button();
            this.tbSzemelyFogl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSzemelyNev = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUjDij = new System.Windows.Forms.Button();
            this.nupDijEv = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDijNev = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupDijEv)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightCoral;
            this.groupBox1.Controls.Add(this.btnUjSzemely);
            this.groupBox1.Controls.Add(this.tbSzemelyFogl);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbSzemelyNev);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 17);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(543, 234);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Új személy felvétele";
            // 
            // btnUjSzemely
            // 
            this.btnUjSzemely.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUjSzemely.ForeColor = System.Drawing.Color.Firebrick;
            this.btnUjSzemely.Location = new System.Drawing.Point(127, 171);
            this.btnUjSzemely.Name = "btnUjSzemely";
            this.btnUjSzemely.Size = new System.Drawing.Size(288, 46);
            this.btnUjSzemely.TabIndex = 4;
            this.btnUjSzemely.Text = "Új személy";
            this.btnUjSzemely.UseVisualStyleBackColor = true;
            this.btnUjSzemely.Click += new System.EventHandler(this.OnUjSzemelyClick);
            // 
            // tbSzemelyFogl
            // 
            this.tbSzemelyFogl.Location = new System.Drawing.Point(208, 107);
            this.tbSzemelyFogl.Margin = new System.Windows.Forms.Padding(4);
            this.tbSzemelyFogl.Name = "tbSzemelyFogl";
            this.tbSzemelyFogl.Size = new System.Drawing.Size(250, 29);
            this.tbSzemelyFogl.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(76, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Foglalkozások:";
            // 
            // tbSzemelyNev
            // 
            this.tbSzemelyNev.Location = new System.Drawing.Point(208, 55);
            this.tbSzemelyNev.Margin = new System.Windows.Forms.Padding(4);
            this.tbSzemelyNev.Name = "tbSzemelyNev";
            this.tbSzemelyNev.Size = new System.Drawing.Size(250, 29);
            this.tbSzemelyNev.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(155, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Név:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightCoral;
            this.groupBox2.Controls.Add(this.btnUjDij);
            this.groupBox2.Controls.Add(this.nupDijEv);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbDijNev);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(15, 259);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(543, 148);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Új díj kiosztása";
            // 
            // btnUjDij
            // 
            this.btnUjDij.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUjDij.ForeColor = System.Drawing.Color.Firebrick;
            this.btnUjDij.Location = new System.Drawing.Point(127, 95);
            this.btnUjDij.Name = "btnUjDij";
            this.btnUjDij.Size = new System.Drawing.Size(288, 46);
            this.btnUjDij.TabIndex = 5;
            this.btnUjDij.Text = "Új József Attila Díj";
            this.btnUjDij.UseVisualStyleBackColor = true;
            this.btnUjDij.Click += new System.EventHandler(this.OnUjDijClick);
            // 
            // nupDijEv
            // 
            this.nupDijEv.Location = new System.Drawing.Point(381, 46);
            this.nupDijEv.Margin = new System.Windows.Forms.Padding(4);
            this.nupDijEv.Name = "nupDijEv";
            this.nupDijEv.Size = new System.Drawing.Size(107, 29);
            this.nupDijEv.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(350, 48);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Év:";
            // 
            // tbDijNev
            // 
            this.tbDijNev.Location = new System.Drawing.Point(83, 45);
            this.tbDijNev.Margin = new System.Windows.Forms.Padding(4);
            this.tbDijNev.Name = "tbDijNev";
            this.tbDijNev.Size = new System.Drawing.Size(250, 29);
            this.tbDijNev.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(30, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Név:";
            // 
            // frmuj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(571, 420);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmuj";
            this.Text = "Új adatok felvétele";
            this.Load += new System.EventHandler(this.OnFormLoad);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupDijEv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button btnUjSzemely;
        private TextBox tbSzemelyFogl;
        private Label label2;
        private TextBox tbSzemelyNev;
        private Label label1;
        private GroupBox groupBox2;
        private Button btnUjDij;
        private NumericUpDown nupDijEv;
        private Label label4;
        private TextBox tbDijNev;
        private Label label3;
    }
}