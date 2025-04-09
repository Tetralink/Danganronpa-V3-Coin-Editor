namespace DanganronpaV3CoinEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtSavePath = new System.Windows.Forms.TextBox();
            this.OriginalSavePath = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.OutputSavePath = new System.Windows.Forms.Label();
            this.txtOutputPath = new System.Windows.Forms.TextBox();
            this.CoinAmount = new System.Windows.Forms.Label();
            this.txtCoinAmount = new System.Windows.Forms.TextBox();
            this.chkBackup = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.CreateLabel = new System.Windows.Forms.Label();
            this.btnBrowseOutput = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CoinsCasinoEditor = new System.Windows.Forms.Label();
            this.actcasino = new System.Windows.Forms.CheckBox();
            this.monocoincheck = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.monocoinlabel = new System.Windows.Forms.TextBox();
            this.dccheck = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dclabel = new System.Windows.Forms.TextBox();
            this.buttontuto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSavePath
            // 
            this.txtSavePath.Location = new System.Drawing.Point(296, 75);
            this.txtSavePath.Name = "txtSavePath";
            this.txtSavePath.Size = new System.Drawing.Size(367, 20);
            this.txtSavePath.TabIndex = 0;
            // 
            // OriginalSavePath
            // 
            this.OriginalSavePath.AutoSize = true;
            this.OriginalSavePath.Font = new System.Drawing.Font("DorBlue", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OriginalSavePath.Location = new System.Drawing.Point(20, 70);
            this.OriginalSavePath.Name = "OriginalSavePath";
            this.OriginalSavePath.Size = new System.Drawing.Size(259, 26);
            this.OriginalSavePath.TabIndex = 1;
            this.OriginalSavePath.Text = "Original Save Path";
            this.OriginalSavePath.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("DorBlue", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(670, 74);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // OutputSavePath
            // 
            this.OutputSavePath.AutoSize = true;
            this.OutputSavePath.Font = new System.Drawing.Font("DorBlue", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputSavePath.Location = new System.Drawing.Point(20, 112);
            this.OutputSavePath.Name = "OutputSavePath";
            this.OutputSavePath.Size = new System.Drawing.Size(247, 26);
            this.OutputSavePath.TabIndex = 4;
            this.OutputSavePath.Text = "Output Save Path";
            // 
            // txtOutputPath
            // 
            this.txtOutputPath.Location = new System.Drawing.Point(273, 118);
            this.txtOutputPath.Name = "txtOutputPath";
            this.txtOutputPath.Size = new System.Drawing.Size(390, 20);
            this.txtOutputPath.TabIndex = 3;
            // 
            // CoinAmount
            // 
            this.CoinAmount.AutoSize = true;
            this.CoinAmount.Font = new System.Drawing.Font("DorBlue", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoinAmount.Location = new System.Drawing.Point(46, 154);
            this.CoinAmount.Name = "CoinAmount";
            this.CoinAmount.Size = new System.Drawing.Size(158, 26);
            this.CoinAmount.TabIndex = 7;
            this.CoinAmount.Text = "Casino Coin";
            // 
            // txtCoinAmount
            // 
            this.txtCoinAmount.Font = new System.Drawing.Font("DorBlue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCoinAmount.Location = new System.Drawing.Point(209, 158);
            this.txtCoinAmount.Name = "txtCoinAmount";
            this.txtCoinAmount.Size = new System.Drawing.Size(99, 24);
            this.txtCoinAmount.TabIndex = 6;
            this.txtCoinAmount.Text = "999999999";
            this.txtCoinAmount.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // chkBackup
            // 
            this.chkBackup.AutoSize = true;
            this.chkBackup.Font = new System.Drawing.Font("DorBlue", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBackup.Location = new System.Drawing.Point(516, 214);
            this.chkBackup.Name = "chkBackup";
            this.chkBackup.Size = new System.Drawing.Size(229, 30);
            this.chkBackup.TabIndex = 8;
            this.chkBackup.Text = "Create backup";
            this.chkBackup.UseVisualStyleBackColor = true;
            this.chkBackup.CheckedChanged += new System.EventHandler(this.chkBackup_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("DorBlue", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(670, 251);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Create";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CreateLabel
            // 
            this.CreateLabel.AutoSize = true;
            this.CreateLabel.Font = new System.Drawing.Font("DorBlue", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateLabel.Location = new System.Drawing.Point(543, 247);
            this.CreateLabel.Name = "CreateLabel";
            this.CreateLabel.Size = new System.Drawing.Size(121, 26);
            this.CreateLabel.TabIndex = 10;
            this.CreateLabel.Text = "Create :";
            this.CreateLabel.Click += new System.EventHandler(this.CreateLabel_Click);
            // 
            // btnBrowseOutput
            // 
            this.btnBrowseOutput.Font = new System.Drawing.Font("DorBlue", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseOutput.Location = new System.Drawing.Point(670, 118);
            this.btnBrowseOutput.Name = "btnBrowseOutput";
            this.btnBrowseOutput.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseOutput.TabIndex = 11;
            this.btnBrowseOutput.Text = "Browse";
            this.btnBrowseOutput.UseVisualStyleBackColor = true;
            this.btnBrowseOutput.Click += new System.EventHandler(this.btnBrowseOutput_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.Image = global::DanganronpaV3CoinEditor.Properties.Resources.DanganronpaV3_blacklogo;
            this.pictureBox1.Location = new System.Drawing.Point(25, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // CoinsCasinoEditor
            // 
            this.CoinsCasinoEditor.AutoSize = true;
            this.CoinsCasinoEditor.Font = new System.Drawing.Font("DorBlue", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoinsCasinoEditor.Location = new System.Drawing.Point(270, 21);
            this.CoinsCasinoEditor.Name = "CoinsCasinoEditor";
            this.CoinsCasinoEditor.Size = new System.Drawing.Size(475, 46);
            this.CoinsCasinoEditor.TabIndex = 13;
            this.CoinsCasinoEditor.Text = "Coins Casino Editor";
            this.CoinsCasinoEditor.Click += new System.EventHandler(this.CoinsCasinoEditor_Click_1);
            // 
            // actcasino
            // 
            this.actcasino.AutoSize = true;
            this.actcasino.Location = new System.Drawing.Point(25, 161);
            this.actcasino.Name = "actcasino";
            this.actcasino.Size = new System.Drawing.Size(15, 14);
            this.actcasino.TabIndex = 14;
            this.actcasino.UseVisualStyleBackColor = true;
            // 
            // monocoincheck
            // 
            this.monocoincheck.AutoSize = true;
            this.monocoincheck.Location = new System.Drawing.Point(25, 206);
            this.monocoincheck.Name = "monocoincheck";
            this.monocoincheck.Size = new System.Drawing.Size(15, 14);
            this.monocoincheck.TabIndex = 17;
            this.monocoincheck.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("DorBlue", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 26);
            this.label1.TabIndex = 16;
            this.label1.Text = "Monocoin";
            // 
            // monocoinlabel
            // 
            this.monocoinlabel.Font = new System.Drawing.Font("DorBlue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monocoinlabel.Location = new System.Drawing.Point(184, 201);
            this.monocoinlabel.Name = "monocoinlabel";
            this.monocoinlabel.Size = new System.Drawing.Size(39, 24);
            this.monocoinlabel.TabIndex = 15;
            this.monocoinlabel.Text = "999";
            // 
            // dccheck
            // 
            this.dccheck.AutoSize = true;
            this.dccheck.Location = new System.Drawing.Point(25, 252);
            this.dccheck.Name = "dccheck";
            this.dccheck.Size = new System.Drawing.Size(15, 14);
            this.dccheck.TabIndex = 20;
            this.dccheck.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("DorBlue", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 26);
            this.label2.TabIndex = 19;
            this.label2.Text = "Gold RPG Monokuma";
            // 
            // dclabel
            // 
            this.dclabel.Font = new System.Drawing.Font("DorBlue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dclabel.Location = new System.Drawing.Point(320, 249);
            this.dclabel.Name = "dclabel";
            this.dclabel.Size = new System.Drawing.Size(69, 24);
            this.dclabel.TabIndex = 18;
            this.dclabel.Text = "999999";
            // 
            // buttontuto
            // 
            this.buttontuto.Font = new System.Drawing.Font("DorBlue", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttontuto.Location = new System.Drawing.Point(665, 185);
            this.buttontuto.Name = "buttontuto";
            this.buttontuto.Size = new System.Drawing.Size(80, 23);
            this.buttontuto.TabIndex = 21;
            this.buttontuto.Text = "Tutorial";
            this.buttontuto.UseVisualStyleBackColor = true;
            this.buttontuto.Click += new System.EventHandler(this.buttontuto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 298);
            this.Controls.Add(this.buttontuto);
            this.Controls.Add(this.dccheck);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dclabel);
            this.Controls.Add(this.monocoincheck);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monocoinlabel);
            this.Controls.Add(this.actcasino);
            this.Controls.Add(this.CoinsCasinoEditor);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBrowseOutput);
            this.Controls.Add(this.CreateLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.chkBackup);
            this.Controls.Add(this.CoinAmount);
            this.Controls.Add(this.txtCoinAmount);
            this.Controls.Add(this.OutputSavePath);
            this.Controls.Add(this.txtOutputPath);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.OriginalSavePath);
            this.Controls.Add(this.txtSavePath);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Danganronpa V3 Coin Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSavePath;
        private System.Windows.Forms.Label OriginalSavePath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label OutputSavePath;
        private System.Windows.Forms.TextBox txtOutputPath;
        private System.Windows.Forms.Button btnBrowseOutput_Click;
        private System.Windows.Forms.Label CoinAmount;
        private System.Windows.Forms.TextBox txtCoinAmount;
        private System.Windows.Forms.CheckBox chkBackup;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label CreateLabel;
        private System.Windows.Forms.Button btnBrowseOutput;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label CoinsCasinoEditor;
        private System.Windows.Forms.CheckBox actcasino;
        private System.Windows.Forms.CheckBox monocoincheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox monocoinlabel;
        private System.Windows.Forms.CheckBox dccheck;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dclabel;
        private System.Windows.Forms.Button buttontuto;
    }
}

