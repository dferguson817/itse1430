namespace MovieLibrary.Winforms
{
    partial class MovieForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing )
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
        private void InitializeComponent ()
        {
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCANCEL = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RunLength = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkIsCLASSIC = new System.Windows.Forms.CheckBox();
            this.txtRELEASEYEAR = new System.Windows.Forms.TextBox();
            this.txtDESCRIPTION = new System.Windows.Forms.TextBox();
            this.txtRUNLENGTH = new System.Windows.Forms.TextBox();
            this.txtTITLE = new System.Windows.Forms.TextBox();
            this.ddlGenres = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(212, 345);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.OnOK);
            // 
            // btnCANCEL
            // 
            this.btnCANCEL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCANCEL.Location = new System.Drawing.Point(293, 345);
            this.btnCANCEL.Name = "btnCANCEL";
            this.btnCANCEL.Size = new System.Drawing.Size(75, 23);
            this.btnCANCEL.TabIndex = 8;
            this.btnCANCEL.Text = "Cancel";
            this.btnCANCEL.UseVisualStyleBackColor = true;
            this.btnCANCEL.Click += new System.EventHandler(this.OnCancel);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Title";
            // 
            // RunLength
            // 
            this.RunLength.AutoSize = true;
            this.RunLength.Location = new System.Drawing.Point(36, 62);
            this.RunLength.Name = "RunLength";
            this.RunLength.Size = new System.Drawing.Size(63, 13);
            this.RunLength.TabIndex = 3;
            this.RunLength.Text = "Run Length";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Release Year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Description";
            // 
            // chkIsCLASSIC
            // 
            this.chkIsCLASSIC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkIsCLASSIC.AutoSize = true;
            this.chkIsCLASSIC.Location = new System.Drawing.Point(102, 240);
            this.chkIsCLASSIC.Name = "chkIsCLASSIC";
            this.chkIsCLASSIC.Size = new System.Drawing.Size(73, 17);
            this.chkIsCLASSIC.TabIndex = 5;
            this.chkIsCLASSIC.Text = "Is  Classic";
            this.chkIsCLASSIC.UseVisualStyleBackColor = true;
            // 
            // txtRELEASEYEAR
            // 
            this.txtRELEASEYEAR.Location = new System.Drawing.Point(105, 88);
            this.txtRELEASEYEAR.Name = "txtRELEASEYEAR";
            this.txtRELEASEYEAR.Size = new System.Drawing.Size(100, 20);
            this.txtRELEASEYEAR.TabIndex = 3;
            // 
            // txtDESCRIPTION
            // 
            this.txtDESCRIPTION.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDESCRIPTION.Location = new System.Drawing.Point(102, 132);
            this.txtDESCRIPTION.Multiline = true;
            this.txtDESCRIPTION.Name = "txtDESCRIPTION";
            this.txtDESCRIPTION.Size = new System.Drawing.Size(196, 79);
            this.txtDESCRIPTION.TabIndex = 4;
            // 
            // txtRUNLENGTH
            // 
            this.txtRUNLENGTH.Location = new System.Drawing.Point(105, 62);
            this.txtRUNLENGTH.Name = "txtRUNLENGTH";
            this.txtRUNLENGTH.Size = new System.Drawing.Size(100, 20);
            this.txtRUNLENGTH.TabIndex = 2;
            // 
            // txtTITLE
            // 
            this.txtTITLE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTITLE.Location = new System.Drawing.Point(105, 33);
            this.txtTITLE.Name = "txtTITLE";
            this.txtTITLE.Size = new System.Drawing.Size(258, 20);
            this.txtTITLE.TabIndex = 1;
            this.txtTITLE.TextChanged += new System.EventHandler(this.TxtTITLE_TextChanged);
            // 
            // ddlGenres
            // 
            this.ddlGenres.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ddlGenres.FormattingEnabled = true;
            this.ddlGenres.Location = new System.Drawing.Point(102, 284);
            this.ddlGenres.Name = "ddlGenres";
            this.ddlGenres.Size = new System.Drawing.Size(121, 21);
            this.ddlGenres.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Search";
            // 
            // MovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 399);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ddlGenres);
            this.Controls.Add(this.txtTITLE);
            this.Controls.Add(this.txtRUNLENGTH);
            this.Controls.Add(this.txtDESCRIPTION);
            this.Controls.Add(this.txtRELEASEYEAR);
            this.Controls.Add(this.chkIsCLASSIC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RunLength);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCANCEL);
            this.Controls.Add(this.btnOK);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MovieForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCANCEL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label RunLength;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkIsCLASSIC;
        private System.Windows.Forms.TextBox txtRELEASEYEAR;
        private System.Windows.Forms.TextBox txtDESCRIPTION;
        private System.Windows.Forms.TextBox txtRUNLENGTH;
        private System.Windows.Forms.TextBox txtTITLE;
        private System.Windows.Forms.ComboBox ddlGenres;
        private System.Windows.Forms.Label label2;
    }
}