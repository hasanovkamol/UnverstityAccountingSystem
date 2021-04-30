
namespace UnverstityAccountingSystem.AllControls
{
    partial class OrganizatsionInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnUpdate = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lbName = new System.Windows.Forms.Label();
            this.lbINN = new System.Windows.Forms.Label();
            this.lbTelefon = new System.Windows.Forms.Label();
            this.lbRegistrationDate = new System.Windows.Forms.Label();
            this.lbOBankSchot = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbBalans = new System.Windows.Forms.Label();
            this.lbDateofContract = new System.Windows.Forms.Label();
            this.lbContracTerminationDate = new System.Windows.Forms.Label();
            this.lbAccountNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Depth = 0;
            this.btnUpdate.Location = new System.Drawing.Point(424, 24);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Primary = true;
            this.btnUpdate.Size = new System.Drawing.Size(378, 42);
            this.btnUpdate.TabIndex = 35;
            this.btnUpdate.Text = "Измените характеристики организации ";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(47, 131);
            this.lbName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(164, 16);
            this.lbName.TabIndex = 37;
            this.lbName.Text = "Название организации";
            // 
            // lbINN
            // 
            this.lbINN.AutoSize = true;
            this.lbINN.Location = new System.Drawing.Point(47, 173);
            this.lbINN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbINN.Name = "lbINN";
            this.lbINN.Size = new System.Drawing.Size(38, 16);
            this.lbINN.TabIndex = 38;
            this.lbINN.Text = "ИНН";
            // 
            // lbTelefon
            // 
            this.lbTelefon.AutoSize = true;
            this.lbTelefon.Location = new System.Drawing.Point(47, 215);
            this.lbTelefon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTelefon.Name = "lbTelefon";
            this.lbTelefon.Size = new System.Drawing.Size(60, 16);
            this.lbTelefon.TabIndex = 39;
            this.lbTelefon.Text = "Телфон";
            // 
            // lbRegistrationDate
            // 
            this.lbRegistrationDate.AutoSize = true;
            this.lbRegistrationDate.Location = new System.Drawing.Point(47, 299);
            this.lbRegistrationDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRegistrationDate.Name = "lbRegistrationDate";
            this.lbRegistrationDate.Size = new System.Drawing.Size(156, 16);
            this.lbRegistrationDate.TabIndex = 42;
            this.lbRegistrationDate.Text = "Дата гос. регистрации";
            // 
            // lbOBankSchot
            // 
            this.lbOBankSchot.AutoSize = true;
            this.lbOBankSchot.Location = new System.Drawing.Point(506, 131);
            this.lbOBankSchot.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbOBankSchot.Name = "lbOBankSchot";
            this.lbOBankSchot.Size = new System.Drawing.Size(154, 16);
            this.lbOBankSchot.TabIndex = 41;
            this.lbOBankSchot.Text = "Осн. банковский счет:";
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Location = new System.Drawing.Point(47, 257);
            this.lbAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(48, 16);
            this.lbAddress.TabIndex = 40;
            this.lbAddress.Text = "Адрес";
            // 
            // lbBalans
            // 
            this.lbBalans.AutoSize = true;
            this.lbBalans.Location = new System.Drawing.Point(506, 257);
            this.lbBalans.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbBalans.Name = "lbBalans";
            this.lbBalans.Size = new System.Drawing.Size(56, 16);
            this.lbBalans.TabIndex = 45;
            this.lbBalans.Text = "Баланс";
            // 
            // lbDateofContract
            // 
            this.lbDateofContract.AutoSize = true;
            this.lbDateofContract.Location = new System.Drawing.Point(506, 215);
            this.lbDateofContract.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDateofContract.Name = "lbDateofContract";
            this.lbDateofContract.Size = new System.Drawing.Size(200, 16);
            this.lbDateofContract.TabIndex = 44;
            this.lbDateofContract.Text = "Дата заключения контракта ";
            // 
            // lbContracTerminationDate
            // 
            this.lbContracTerminationDate.AutoSize = true;
            this.lbContracTerminationDate.Location = new System.Drawing.Point(506, 173);
            this.lbContracTerminationDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbContracTerminationDate.Name = "lbContracTerminationDate";
            this.lbContracTerminationDate.Size = new System.Drawing.Size(207, 16);
            this.lbContracTerminationDate.TabIndex = 43;
            this.lbContracTerminationDate.Text = "Дата прекращения контракта ";
            // 
            // lbAccountNumber
            // 
            this.lbAccountNumber.AutoSize = true;
            this.lbAccountNumber.Location = new System.Drawing.Point(506, 299);
            this.lbAccountNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAccountNumber.Name = "lbAccountNumber";
            this.lbAccountNumber.Size = new System.Drawing.Size(95, 16);
            this.lbAccountNumber.TabIndex = 46;
            this.lbAccountNumber.Text = "Номер счета ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(46, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 23);
            this.label1.TabIndex = 47;
            this.label1.Text = "Информация об организации ";
            // 
            // OrganizatsionInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbAccountNumber);
            this.Controls.Add(this.lbBalans);
            this.Controls.Add(this.lbDateofContract);
            this.Controls.Add(this.lbContracTerminationDate);
            this.Controls.Add(this.lbRegistrationDate);
            this.Controls.Add(this.lbOBankSchot);
            this.Controls.Add(this.lbAddress);
            this.Controls.Add(this.lbTelefon);
            this.Controls.Add(this.lbINN);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.btnUpdate);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "OrganizatsionInfo";
            this.Size = new System.Drawing.Size(897, 420);
            this.Load += new System.EventHandler(this.OrganizatsionInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialRaisedButton btnUpdate;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbINN;
        private System.Windows.Forms.Label lbTelefon;
        private System.Windows.Forms.Label lbRegistrationDate;
        private System.Windows.Forms.Label lbOBankSchot;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbBalans;
        private System.Windows.Forms.Label lbDateofContract;
        private System.Windows.Forms.Label lbContracTerminationDate;
        private System.Windows.Forms.Label lbAccountNumber;
        private System.Windows.Forms.Label label1;
    }
}
