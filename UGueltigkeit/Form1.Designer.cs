namespace UGueltigkeit
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CmdErhoeheXY = new System.Windows.Forms.Button();
            this.CmdErhoeheXZ = new System.Windows.Forms.Button();
            this.LblAnzeige = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmdErhoeheXY
            // 
            this.CmdErhoeheXY.Location = new System.Drawing.Point(264, 12);
            this.CmdErhoeheXY.Name = "CmdErhoeheXY";
            this.CmdErhoeheXY.Size = new System.Drawing.Size(75, 23);
            this.CmdErhoeheXY.TabIndex = 0;
            this.CmdErhoeheXY.Text = "Erhöhe xy";
            this.CmdErhoeheXY.UseVisualStyleBackColor = true;
            this.CmdErhoeheXY.Click += new System.EventHandler(this.CmdErhoeheXY_Click);
            // 
            // CmdErhoeheXZ
            // 
            this.CmdErhoeheXZ.Location = new System.Drawing.Point(264, 41);
            this.CmdErhoeheXZ.Name = "CmdErhoeheXZ";
            this.CmdErhoeheXZ.Size = new System.Drawing.Size(75, 23);
            this.CmdErhoeheXZ.TabIndex = 1;
            this.CmdErhoeheXZ.Text = "Erhöhe xz";
            this.CmdErhoeheXZ.UseVisualStyleBackColor = true;
            this.CmdErhoeheXZ.Click += new System.EventHandler(this.CmdErhoeheXZ_Click);
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.Location = new System.Drawing.Point(23, 17);
            this.LblAnzeige.Name = "LblAnzeige";
            this.LblAnzeige.Size = new System.Drawing.Size(34, 15);
            this.LblAnzeige.TabIndex = 2;
            this.LblAnzeige.Text = "(leer)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 260);
            this.Controls.Add(this.LblAnzeige);
            this.Controls.Add(this.CmdErhoeheXZ);
            this.Controls.Add(this.CmdErhoeheXY);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button CmdErhoeheXY;
        private Button CmdErhoeheXZ;
        private Label LblAnzeige;
    }
}