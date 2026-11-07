
namespace ComputerRepairManagementSystem
{
    partial class DataForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataForm));
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbPhoneNumber = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.lbModel = new System.Windows.Forms.Label();
            this.dpCatogory = new System.Windows.Forms.ComboBox();
            this.lbCatagory = new System.Windows.Forms.Label();
            this.PanData = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.PanData.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(153, 65);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(148, 26);
            this.txtName.TabIndex = 0;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(522, 65);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(148, 26);
            this.txtPhone.TabIndex = 1;
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(60, 75);
            this.lbName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(51, 20);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Name";
            // 
            // lbPhoneNumber
            // 
            this.lbPhoneNumber.AutoSize = true;
            this.lbPhoneNumber.Location = new System.Drawing.Point(444, 75);
            this.lbPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPhoneNumber.Name = "lbPhoneNumber";
            this.lbPhoneNumber.Size = new System.Drawing.Size(55, 20);
            this.lbPhoneNumber.TabIndex = 3;
            this.lbPhoneNumber.Text = "Phone";
            this.lbPhoneNumber.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(226, 302);
            this.lbEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(48, 20);
            this.lbEmail.TabIndex = 4;
            this.lbEmail.Text = "Email";
            this.lbEmail.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(324, 291);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(300, 26);
            this.txtEmail.TabIndex = 5;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(522, 166);
            this.txtModel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(148, 26);
            this.txtModel.TabIndex = 6;
            this.txtModel.TextChanged += new System.EventHandler(this.txtModel_TextChanged);
            // 
            // lbModel
            // 
            this.lbModel.AutoSize = true;
            this.lbModel.Location = new System.Drawing.Point(444, 177);
            this.lbModel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbModel.Name = "lbModel";
            this.lbModel.Size = new System.Drawing.Size(52, 20);
            this.lbModel.TabIndex = 7;
            this.lbModel.Text = "Model";
            // 
            // dpCatogory
            // 
            this.dpCatogory.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.dpCatogory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dpCatogory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dpCatogory.FormattingEnabled = true;
            this.dpCatogory.Items.AddRange(new object[] {
            "Mobile",
            "Tablet",
            "IPad",
            "Earphones"});
            this.dpCatogory.Location = new System.Drawing.Point(153, 177);
            this.dpCatogory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dpCatogory.Name = "dpCatogory";
            this.dpCatogory.Size = new System.Drawing.Size(148, 28);
            this.dpCatogory.TabIndex = 8;
            // 
            // lbCatagory
            // 
            this.lbCatagory.AutoSize = true;
            this.lbCatagory.Location = new System.Drawing.Point(60, 189);
            this.lbCatagory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCatagory.Name = "lbCatagory";
            this.lbCatagory.Size = new System.Drawing.Size(73, 20);
            this.lbCatagory.TabIndex = 9;
            this.lbCatagory.Text = "Catogory";
            // 
            // PanData
            // 
            this.PanData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PanData.Controls.Add(this.btnExit);
            this.PanData.Controls.Add(this.btnReset);
            this.PanData.Controls.Add(this.btnSave);
            this.PanData.Controls.Add(this.lbDescription);
            this.PanData.Controls.Add(this.txtDescription);
            this.PanData.Controls.Add(this.txtEmail);
            this.PanData.Controls.Add(this.lbCatagory);
            this.PanData.Controls.Add(this.lbEmail);
            this.PanData.Controls.Add(this.dpCatogory);
            this.PanData.Controls.Add(this.txtName);
            this.PanData.Controls.Add(this.lbModel);
            this.PanData.Controls.Add(this.lbName);
            this.PanData.Controls.Add(this.txtModel);
            this.PanData.Controls.Add(this.txtPhone);
            this.PanData.Controls.Add(this.lbPhoneNumber);
            this.PanData.Location = new System.Drawing.Point(20, 3);
            this.PanData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PanData.Name = "PanData";
            this.PanData.Size = new System.Drawing.Size(892, 682);
            this.PanData.TabIndex = 10;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(578, 615);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 51);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Yellow;
            this.btnReset.Location = new System.Drawing.Point(681, 615);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(94, 51);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Lime;
            this.btnSave.Location = new System.Drawing.Point(784, 617);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 51);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Location = new System.Drawing.Point(102, 437);
            this.lbDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(89, 20);
            this.lbDescription.TabIndex = 11;
            this.lbDescription.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(204, 378);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(511, 144);
            this.txtDescription.TabIndex = 10;
            // 
            // DataForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(920, 689);
            this.Controls.Add(this.PanData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DataForm";
            this.Text = "Data";
            this.PanData.ResumeLayout(false);
            this.PanData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbPhoneNumber;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label lbModel;
        private System.Windows.Forms.ComboBox dpCatogory;
        private System.Windows.Forms.Label lbCatagory;
        private System.Windows.Forms.Panel PanData;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.TextBox txtDescription;
    }
}