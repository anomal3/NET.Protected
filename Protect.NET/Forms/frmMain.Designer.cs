namespace Protect.NET.Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tbPath = new System.Windows.Forms.TextBox();
            this.bCrypt = new System.Windows.Forms.Button();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.lOutF = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbPath
            // 
            this.tbPath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbPath.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbPath.Location = new System.Drawing.Point(0, 0);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(444, 20);
            this.tbPath.TabIndex = 0;
            this.tbPath.Text = "Click mouse here to select file crypt";
            this.tbPath.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbPath_MouseClick);
            // 
            // bCrypt
            // 
            this.bCrypt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bCrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bCrypt.Image = global::Protect.NET.Properties.Resources.token_match_single_character;
            this.bCrypt.Location = new System.Drawing.Point(0, 46);
            this.bCrypt.Name = "bCrypt";
            this.bCrypt.Size = new System.Drawing.Size(444, 50);
            this.bCrypt.TabIndex = 1;
            this.bCrypt.Text = "PROTECTED";
            this.bCrypt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bCrypt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bCrypt.UseVisualStyleBackColor = true;
            this.bCrypt.Click += new System.EventHandler(this.bCrypt_Click);
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // lOutF
            // 
            this.lOutF.AutoSize = true;
            this.lOutF.Enabled = false;
            this.lOutF.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lOutF.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.lOutF.Location = new System.Drawing.Point(0, 28);
            this.lOutF.Name = "lOutF";
            this.lOutF.Size = new System.Drawing.Size(77, 16);
            this.lOutF.TabIndex = 2;
            this.lOutF.Text = "Output name : ";
            this.lOutF.UseCompatibleTextRendering = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 96);
            this.Controls.Add(this.lOutF);
            this.Controls.Add(this.bCrypt);
            this.Controls.Add(this.tbPath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(350, 135);
            this.Name = "frmMain";
            this.Text = "EXE Obfuscator naming";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Button bCrypt;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.Label lOutF;
    }
}

