namespace Helicopter_Game
{
    partial class frmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.btJocNou = new System.Windows.Forms.Button();
            this.btInstr = new System.Windows.Forms.Button();
            this.btIesire = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(471, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "Helicopter Game";
            // 
            // btJocNou
            // 
            this.btJocNou.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btJocNou.Font = new System.Drawing.Font("Microsoft Uighur", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btJocNou.Location = new System.Drawing.Point(292, 133);
            this.btJocNou.Name = "btJocNou";
            this.btJocNou.Size = new System.Drawing.Size(210, 49);
            this.btJocNou.TabIndex = 1;
            this.btJocNou.Text = "Joc Nou";
            this.btJocNou.UseVisualStyleBackColor = false;
            this.btJocNou.Click += new System.EventHandler(this.btJocNou_Click);
            // 
            // btInstr
            // 
            this.btInstr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btInstr.Font = new System.Drawing.Font("Microsoft Uighur", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInstr.Location = new System.Drawing.Point(292, 197);
            this.btInstr.Name = "btInstr";
            this.btInstr.Size = new System.Drawing.Size(210, 49);
            this.btInstr.TabIndex = 2;
            this.btInstr.Text = "Instructiuni";
            this.btInstr.UseVisualStyleBackColor = false;
            this.btInstr.Click += new System.EventHandler(this.btInstr_Click);
            // 
            // btIesire
            // 
            this.btIesire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btIesire.Font = new System.Drawing.Font("Microsoft Uighur", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIesire.Location = new System.Drawing.Point(292, 262);
            this.btIesire.Name = "btIesire";
            this.btIesire.Size = new System.Drawing.Size(210, 49);
            this.btIesire.TabIndex = 3;
            this.btIesire.Text = "Iesire Joc";
            this.btIesire.UseVisualStyleBackColor = false;
            this.btIesire.Click += new System.EventHandler(this.btIesire_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(797, 372);
            this.ControlBox = false;
            this.Controls.Add(this.btIesire);
            this.Controls.Add(this.btInstr);
            this.Controls.Add(this.btJocNou);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Helicopter Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btJocNou;
        private System.Windows.Forms.Button btInstr;
        private System.Windows.Forms.Button btIesire;
    }
}

