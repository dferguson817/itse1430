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
            this.btnOK.Location = new System.Drawing.Point(442, 306);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.OnOK);
            // 
            // btnCANCEL
            // 
            this.btnCANCEL.Location = new System.Drawing.Point(577, 306);
            this.btnCANCEL.Name = "btnCANCEL";
            this.btnCANCEL.Size = new System.Drawing.Size(75, 23);
            this.btnCANCEL.TabIndex = 1;
            this.btnCANCEL.Text = "Cancel";
            this.btnCANCEL.UseVisualStyleBackColor = true;
            this.btnCANCEL.Click += new System.EventHandler(this.OnCancel);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Title";
            // 
            // RunLength
            // 
            this.RunLength.AutoSize = true;
            this.RunLength.Location = new System.Drawing.Point(58, 90);
            this.RunLength.Name = "RunLength";
            this.RunLength.Size = new System.Drawing.Size(63, 13);
            this.RunLength.TabIndex = 3;
            this.RunLength.Text = "Run Length";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Release Year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Description";
            // 
            // chkIsCLASSIC
            // 
            this.chkIsCLASSIC.AutoSize = true;
            this.chkIsCLASSIC.Location = new System.Drawing.Point(152, 240);
            this.chkIsCLASSIC.Name = "chkIsCLASSIC";
            this.chkIsCLASSIC.Size = new System.Drawing.Size(73, 17);
            this.chkIsCLASSIC.TabIndex = 6;
            this.chkIsCLASSIC.Text = "Is  Classic";
            this.chkIsCLASSIC.UseVisualStyleBackColor = true;
            // 
            // txtRELEASEYEAR
            // 
            this.txtRELEASEYEAR.Location = new System.Drawing.Point(132, 130);
            this.txtRELEASEYEAR.Name = "txtRELEASEYEAR";
            this.txtRELEASEYEAR.Size = new System.Drawing.Size(100, 20);
            this.txtRELEASEYEAR.TabIndex = 7;
            // 
            // txtDESCRIPTION
            // 
            this.txtDESCRIPTION.Location = new System.Drawing.Point(132, 171);
            this.txtDESCRIPTION.Name = "txtDESCRIPTION";
            this.txtDESCRIPTION.Size = new System.Drawing.Size(100, 20);
            this.txtDESCRIPTION.TabIndex = 8;
            // 
            // txtRUNLENGTH
            // 
            this.txtRUNLENGTH.Location = new System.Drawing.Point(132, 90);
            this.txtRUNLENGTH.Name = "txtRUNLENGTH";
            this.txtRUNLENGTH.Size = new System.Drawing.Size(100, 20);
            this.txtRUNLENGTH.TabIndex = 9;
            // 
            // txtTITLE
            // 
            this.txtTITLE.Location = new System.Drawing.Point(132, 33);
            this.txtTITLE.Name = "txtTITLE";
            this.txtTITLE.Size = new System.Drawing.Size(100, 20);
            this.txtTITLE.TabIndex = 10;
            // 
            // ddlGenres
            // 
            this.ddlGenres.FormattingEnabled = true;
            this.ddlGenres.Location = new System.Drawing.Point(132, 292);
            this.ddlGenres.Name = "ddlGenres";
            this.ddlGenres.Size = new System.Drawing.Size(121, 21);
            this.ddlGenres.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Search";
            // 
            // MovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Text = "MovieSpaceDetail";
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