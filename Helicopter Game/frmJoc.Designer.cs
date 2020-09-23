﻿namespace Helicopter_Game
{
    partial class frmJoc
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
            this.components = new System.ComponentModel.Container();
            this.pbPlayer = new System.Windows.Forms.PictureBox();
            this.pbPillar1 = new System.Windows.Forms.PictureBox();
            this.pbPillar2 = new System.Windows.Forms.PictureBox();
            this.pbUfo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPillar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPillar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUfo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPlayer
            // 
            this.pbPlayer.BackColor = System.Drawing.Color.Transparent;
            this.pbPlayer.Image = global::Helicopter_Game.Properties.Resources.Halicopter;
            this.pbPlayer.Location = new System.Drawing.Point(83, 171);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(100, 54);
            this.pbPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbPlayer.TabIndex = 0;
            this.pbPlayer.TabStop = false;
            // 
            // pbPillar1
            // 
            this.pbPillar1.Image = global::Helicopter_Game.Properties.Resources.pillar;
            this.pbPillar1.Location = new System.Drawing.Point(338, -6);
            this.pbPillar1.Name = "pbPillar1";
            this.pbPillar1.Size = new System.Drawing.Size(56, 150);
            this.pbPillar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPillar1.TabIndex = 1;
            this.pbPillar1.TabStop = false;
            // 
            // pbPillar2
            // 
            this.pbPillar2.Image = global::Helicopter_Game.Properties.Resources.pillar;
            this.pbPillar2.Location = new System.Drawing.Point(495, 246);
            this.pbPillar2.Name = "pbPillar2";
            this.pbPillar2.Size = new System.Drawing.Size(56, 146);
            this.pbPillar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPillar2.TabIndex = 2;
            this.pbPillar2.TabStop = false;
            // 
            // pbUfo
            // 
            this.pbUfo.BackColor = System.Drawing.Color.Transparent;
            this.pbUfo.Image = global::Helicopter_Game.Properties.Resources.alien1;
            this.pbUfo.Location = new System.Drawing.Point(572, 155);
            this.pbUfo.Name = "pbUfo";
            this.pbUfo.Size = new System.Drawing.Size(68, 72);
            this.pbUfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbUfo.TabIndex = 3;
            this.pbUfo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "00";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // frmJoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(797, 372);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbUfo);
            this.Controls.Add(this.pbPillar2);
            this.Controls.Add(this.pbPillar1);
            this.Controls.Add(this.pbPlayer);
            this.Name = "frmJoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Helicopter Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPillar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPillar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPlayer;
        private System.Windows.Forms.PictureBox pbPillar1;
        private System.Windows.Forms.PictureBox pbPillar2;
        private System.Windows.Forms.PictureBox pbUfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer gameTimer;
    }
}