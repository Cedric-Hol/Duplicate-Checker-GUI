namespace Duplicate_Checker_GUI
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblDownload = new System.Windows.Forms.Button();
            this.txtNameFile = new System.Windows.Forms.TextBox();
            this.lblNameFile = new System.Windows.Forms.Label();
            this.lbBudgetConsole = new System.Windows.Forms.ListBox();
            this.btnChoice2 = new System.Windows.Forms.Button();
            this.btnChoice1 = new System.Windows.Forms.Button();
            this.txtSecondChoice = new System.Windows.Forms.TextBox();
            this.txtFirstChoice = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.Controls.Add(this.lblDownload);
            this.pnlMain.Controls.Add(this.txtNameFile);
            this.pnlMain.Controls.Add(this.lblNameFile);
            this.pnlMain.Controls.Add(this.lbBudgetConsole);
            this.pnlMain.Controls.Add(this.btnChoice2);
            this.pnlMain.Controls.Add(this.btnChoice1);
            this.pnlMain.Controls.Add(this.txtSecondChoice);
            this.pnlMain.Controls.Add(this.txtFirstChoice);
            this.pnlMain.Controls.Add(this.lblTitle);
            this.pnlMain.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlMain.Location = new System.Drawing.Point(12, 12);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(660, 637);
            this.pnlMain.TabIndex = 0;
            // 
            // lblDownload
            // 
            this.lblDownload.BackColor = System.Drawing.Color.Transparent;
            this.lblDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDownload.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDownload.Location = new System.Drawing.Point(212, 530);
            this.lblDownload.Name = "lblDownload";
            this.lblDownload.Size = new System.Drawing.Size(231, 89);
            this.lblDownload.TabIndex = 9;
            this.lblDownload.Text = "Download";
            this.lblDownload.UseVisualStyleBackColor = false;
            this.lblDownload.Click += new System.EventHandler(this.lblDownload_Click);
            // 
            // txtNameFile
            // 
            this.txtNameFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.txtNameFile.Location = new System.Drawing.Point(212, 456);
            this.txtNameFile.Name = "txtNameFile";
            this.txtNameFile.Size = new System.Drawing.Size(231, 40);
            this.txtNameFile.TabIndex = 8;
            // 
            // lblNameFile
            // 
            this.lblNameFile.AutoSize = true;
            this.lblNameFile.BackColor = System.Drawing.Color.Transparent;
            this.lblNameFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.lblNameFile.Location = new System.Drawing.Point(221, 403);
            this.lblNameFile.Name = "lblNameFile";
            this.lblNameFile.Size = new System.Drawing.Size(212, 33);
            this.lblNameFile.TabIndex = 7;
            this.lblNameFile.Text = "Name your file!";
            // 
            // lbBudgetConsole
            // 
            this.lbBudgetConsole.FormattingEnabled = true;
            this.lbBudgetConsole.HorizontalScrollbar = true;
            this.lbBudgetConsole.Location = new System.Drawing.Point(212, 200);
            this.lbBudgetConsole.Name = "lbBudgetConsole";
            this.lbBudgetConsole.Size = new System.Drawing.Size(231, 186);
            this.lbBudgetConsole.TabIndex = 5;
            // 
            // btnChoice2
            // 
            this.btnChoice2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoice2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnChoice2.Location = new System.Drawing.Point(449, 194);
            this.btnChoice2.Name = "btnChoice2";
            this.btnChoice2.Size = new System.Drawing.Size(101, 36);
            this.btnChoice2.TabIndex = 4;
            this.btnChoice2.Text = "Choice";
            this.btnChoice2.UseVisualStyleBackColor = true;
            this.btnChoice2.Click += new System.EventHandler(this.btnChoice2_Click);
            // 
            // btnChoice1
            // 
            this.btnChoice1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoice1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnChoice1.Location = new System.Drawing.Point(105, 194);
            this.btnChoice1.Name = "btnChoice1";
            this.btnChoice1.Size = new System.Drawing.Size(101, 36);
            this.btnChoice1.TabIndex = 3;
            this.btnChoice1.Text = "Choice";
            this.btnChoice1.UseVisualStyleBackColor = true;
            this.btnChoice1.Click += new System.EventHandler(this.btnChoice1_Click);
            // 
            // txtSecondChoice
            // 
            this.txtSecondChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecondChoice.Location = new System.Drawing.Point(336, 148);
            this.txtSecondChoice.Name = "txtSecondChoice";
            this.txtSecondChoice.ReadOnly = true;
            this.txtSecondChoice.Size = new System.Drawing.Size(324, 40);
            this.txtSecondChoice.TabIndex = 2;
            // 
            // txtFirstChoice
            // 
            this.txtFirstChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstChoice.Location = new System.Drawing.Point(0, 148);
            this.txtFirstChoice.Name = "txtFirstChoice";
            this.txtFirstChoice.ReadOnly = true;
            this.txtFirstChoice.Size = new System.Drawing.Size(324, 40);
            this.txtFirstChoice.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitle.Location = new System.Drawing.Point(200, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(254, 33);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Duplicate Checker";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(37)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(684, 661);
            this.Controls.Add(this.pnlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Duplicate Checker";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnChoice2;
        private System.Windows.Forms.Button btnChoice1;
        private System.Windows.Forms.TextBox txtSecondChoice;
        private System.Windows.Forms.TextBox txtFirstChoice;
        private System.Windows.Forms.ListBox lbBudgetConsole;
        private System.Windows.Forms.Label lblNameFile;
        private System.Windows.Forms.Button lblDownload;
        private System.Windows.Forms.TextBox txtNameFile;
    }
}

