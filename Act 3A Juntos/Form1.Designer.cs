namespace Act_3A_Juntos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddLoan = new System.Windows.Forms.Button();
            this.lblLoanOutput = new System.Windows.Forms.Label();
            this.txtLoanInput = new System.Windows.Forms.TextBox();
            this.btnShowLoans = new System.Windows.Forms.Button();
            this.btnFindAuthor = new System.Windows.Forms.Button();
            this.numAuthorIndex = new System.Windows.Forms.NumericUpDown();
            this.lblAuthorOutput = new System.Windows.Forms.Label();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.txtUserInput = new System.Windows.Forms.TextBox();
            this.numUserIndex = new System.Windows.Forms.NumericUpDown();
            this.lblUserOutput = new System.Windows.Forms.Label();
            this.btnReadUser = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numAuthorIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUserIndex)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddLoan
            // 
            this.btnAddLoan.Location = new System.Drawing.Point(47, 141);
            this.btnAddLoan.Name = "btnAddLoan";
            this.btnAddLoan.Size = new System.Drawing.Size(75, 23);
            this.btnAddLoan.TabIndex = 0;
            this.btnAddLoan.Text = "button1";
            this.btnAddLoan.UseVisualStyleBackColor = true;
            this.btnAddLoan.Click += new System.EventHandler(this.btnAddLoan_Click);
            // 
            // lblLoanOutput
            // 
            this.lblLoanOutput.AutoSize = true;
            this.lblLoanOutput.Location = new System.Drawing.Point(87, 224);
            this.lblLoanOutput.Name = "lblLoanOutput";
            this.lblLoanOutput.Size = new System.Drawing.Size(35, 13);
            this.lblLoanOutput.TabIndex = 1;
            this.lblLoanOutput.Text = "label1";
            // 
            // txtLoanInput
            // 
            this.txtLoanInput.Location = new System.Drawing.Point(62, 32);
            this.txtLoanInput.Name = "txtLoanInput";
            this.txtLoanInput.Size = new System.Drawing.Size(381, 20);
            this.txtLoanInput.TabIndex = 2;
            // 
            // btnShowLoans
            // 
            this.btnShowLoans.Location = new System.Drawing.Point(143, 141);
            this.btnShowLoans.Name = "btnShowLoans";
            this.btnShowLoans.Size = new System.Drawing.Size(75, 23);
            this.btnShowLoans.TabIndex = 3;
            this.btnShowLoans.Text = "button1";
            this.btnShowLoans.UseVisualStyleBackColor = true;
            this.btnShowLoans.Click += new System.EventHandler(this.btnShowLoans_Click);
            // 
            // btnFindAuthor
            // 
            this.btnFindAuthor.Location = new System.Drawing.Point(244, 141);
            this.btnFindAuthor.Name = "btnFindAuthor";
            this.btnFindAuthor.Size = new System.Drawing.Size(75, 23);
            this.btnFindAuthor.TabIndex = 4;
            this.btnFindAuthor.Text = "button1";
            this.btnFindAuthor.UseVisualStyleBackColor = true;
            this.btnFindAuthor.Click += new System.EventHandler(this.btnFindAuthor_Click);
            // 
            // numAuthorIndex
            // 
            this.numAuthorIndex.Location = new System.Drawing.Point(475, 33);
            this.numAuthorIndex.Name = "numAuthorIndex";
            this.numAuthorIndex.Size = new System.Drawing.Size(120, 20);
            this.numAuthorIndex.TabIndex = 5;
            // 
            // lblAuthorOutput
            // 
            this.lblAuthorOutput.AutoSize = true;
            this.lblAuthorOutput.Location = new System.Drawing.Point(262, 224);
            this.lblAuthorOutput.Name = "lblAuthorOutput";
            this.lblAuthorOutput.Size = new System.Drawing.Size(35, 13);
            this.lblAuthorOutput.TabIndex = 6;
            this.lblAuthorOutput.Text = "label1";
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(343, 141);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(75, 23);
            this.btnAddUser.TabIndex = 7;
            this.btnAddUser.Text = "button1";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // txtUserInput
            // 
            this.txtUserInput.Location = new System.Drawing.Point(62, 67);
            this.txtUserInput.Name = "txtUserInput";
            this.txtUserInput.Size = new System.Drawing.Size(381, 20);
            this.txtUserInput.TabIndex = 8;
            // 
            // numUserIndex
            // 
            this.numUserIndex.Location = new System.Drawing.Point(475, 68);
            this.numUserIndex.Name = "numUserIndex";
            this.numUserIndex.Size = new System.Drawing.Size(120, 20);
            this.numUserIndex.TabIndex = 9;
            // 
            // lblUserOutput
            // 
            this.lblUserOutput.AutoSize = true;
            this.lblUserOutput.Location = new System.Drawing.Point(408, 224);
            this.lblUserOutput.Name = "lblUserOutput";
            this.lblUserOutput.Size = new System.Drawing.Size(35, 13);
            this.lblUserOutput.TabIndex = 10;
            this.lblUserOutput.Text = "label1";
            // 
            // btnReadUser
            // 
            this.btnReadUser.Location = new System.Drawing.Point(493, 141);
            this.btnReadUser.Name = "btnReadUser";
            this.btnReadUser.Size = new System.Drawing.Size(75, 23);
            this.btnReadUser.TabIndex = 11;
            this.btnReadUser.Text = "button1";
            this.btnReadUser.UseVisualStyleBackColor = true;
            this.btnReadUser.Click += new System.EventHandler(this.btnReadUser_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(627, 141);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteUser.TabIndex = 12;
            this.btnDeleteUser.Text = "button1";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.btnReadUser);
            this.Controls.Add(this.lblUserOutput);
            this.Controls.Add(this.numUserIndex);
            this.Controls.Add(this.txtUserInput);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.lblAuthorOutput);
            this.Controls.Add(this.numAuthorIndex);
            this.Controls.Add(this.btnFindAuthor);
            this.Controls.Add(this.btnShowLoans);
            this.Controls.Add(this.txtLoanInput);
            this.Controls.Add(this.lblLoanOutput);
            this.Controls.Add(this.btnAddLoan);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numAuthorIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUserIndex)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddLoan;
        private System.Windows.Forms.Label lblLoanOutput;
        private System.Windows.Forms.TextBox txtLoanInput;
        private System.Windows.Forms.Button btnShowLoans;
        private System.Windows.Forms.Button btnFindAuthor;
        private System.Windows.Forms.NumericUpDown numAuthorIndex;
        private System.Windows.Forms.Label lblAuthorOutput;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.TextBox txtUserInput;
        private System.Windows.Forms.NumericUpDown numUserIndex;
        private System.Windows.Forms.Label lblUserOutput;
        private System.Windows.Forms.Button btnReadUser;
        private System.Windows.Forms.Button btnDeleteUser;
    }
}

