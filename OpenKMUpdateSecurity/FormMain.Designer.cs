namespace OpenKMUpdateSecurity
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
            this.editAddress = new System.Windows.Forms.TextBox();
            this.editPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.editLoginName = new System.Windows.Forms.TextBox();
            this.editLoginPassword = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.editUUID = new System.Windows.Forms.TextBox();
            this.richEditOutput = new System.Windows.Forms.RichTextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // editAddress
            // 
            this.editAddress.Location = new System.Drawing.Point(132, 29);
            this.editAddress.Name = "editAddress";
            this.editAddress.Size = new System.Drawing.Size(188, 28);
            this.editAddress.TabIndex = 0;
            // 
            // editPort
            // 
            this.editPort.Location = new System.Drawing.Point(486, 29);
            this.editPort.Name = "editPort";
            this.editPort.Size = new System.Drawing.Size(177, 28);
            this.editPort.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(370, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Login:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(373, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Password:";
            // 
            // editLoginName
            // 
            this.editLoginName.Location = new System.Drawing.Point(132, 91);
            this.editLoginName.Name = "editLoginName";
            this.editLoginName.Size = new System.Drawing.Size(188, 28);
            this.editLoginName.TabIndex = 2;
            // 
            // editLoginPassword
            // 
            this.editLoginPassword.Location = new System.Drawing.Point(486, 90);
            this.editLoginPassword.Name = "editLoginPassword";
            this.editLoginPassword.PasswordChar = '*';
            this.editLoginPassword.Size = new System.Drawing.Size(177, 28);
            this.editLoginPassword.TabIndex = 3;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(31, 198);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(263, 31);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "&Update Security";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(376, 198);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(287, 31);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Parent UUID:";
            // 
            // editUUID
            // 
            this.editUUID.Location = new System.Drawing.Point(150, 146);
            this.editUUID.Name = "editUUID";
            this.editUUID.Size = new System.Drawing.Size(391, 28);
            this.editUUID.TabIndex = 4;
            // 
            // richEditOutput
            // 
            this.richEditOutput.Location = new System.Drawing.Point(31, 262);
            this.richEditOutput.Name = "richEditOutput";
            this.richEditOutput.ReadOnly = true;
            this.richEditOutput.Size = new System.Drawing.Size(632, 457);
            this.richEditOutput.TabIndex = 13;
            this.richEditOutput.Text = "";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(547, 146);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(115, 28);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 769);
            this.ControlBox = false;
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.richEditOutput);
            this.Controls.Add(this.editUUID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.editLoginPassword);
            this.Controls.Add(this.editLoginName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.editPort);
            this.Controls.Add(this.editAddress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmMain";
            this.Text = "OpenKM Update Security";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox editAddress;
        private System.Windows.Forms.TextBox editPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox editLoginName;
        private System.Windows.Forms.TextBox editLoginPassword;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox editUUID;
        private System.Windows.Forms.RichTextBox richEditOutput;
        private System.Windows.Forms.Button btnClear;
    }
}

