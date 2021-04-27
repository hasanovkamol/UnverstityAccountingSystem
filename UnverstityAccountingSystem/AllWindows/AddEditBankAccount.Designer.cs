
namespace UnverstityAccountingSystem.AllWindows
{
    partial class AddEditBankAccount
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbAccountNumber = new System.Windows.Forms.TextBox();
            this.tbGetBank = new System.Windows.Forms.TextBox();
            this.btnBank = new System.Windows.Forms.Button();
            this.dtDateofContract = new System.Windows.Forms.DateTimePicker();
            this.dtContracTerminationDate = new System.Windows.Forms.DateTimePicker();
            this.tbValuta = new System.Windows.Forms.ComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.btnValuta = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.tbAccountBalance = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(174, 39);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(285, 34);
            this.tbName.TabIndex = 0;
            // 
            // tbAccountNumber
            // 
            this.tbAccountNumber.Location = new System.Drawing.Point(174, 93);
            this.tbAccountNumber.Name = "tbAccountNumber";
            this.tbAccountNumber.Size = new System.Drawing.Size(285, 34);
            this.tbAccountNumber.TabIndex = 1;
            // 
            // tbGetBank
            // 
            this.tbGetBank.Location = new System.Drawing.Point(174, 147);
            this.tbGetBank.Name = "tbGetBank";
            this.tbGetBank.Size = new System.Drawing.Size(238, 34);
            this.tbGetBank.TabIndex = 2;
            // 
            // btnBank
            // 
            this.btnBank.BackColor = System.Drawing.Color.Brown;
            this.btnBank.Location = new System.Drawing.Point(418, 147);
            this.btnBank.Name = "btnBank";
            this.btnBank.Size = new System.Drawing.Size(41, 34);
            this.btnBank.TabIndex = 3;
            this.btnBank.Text = "...";
            this.btnBank.UseVisualStyleBackColor = false;
            this.btnBank.Click += new System.EventHandler(this.btnBank_Click);
            // 
            // dtDateofContract
            // 
            this.dtDateofContract.Location = new System.Drawing.Point(174, 201);
            this.dtDateofContract.Name = "dtDateofContract";
            this.dtDateofContract.Size = new System.Drawing.Size(285, 34);
            this.dtDateofContract.TabIndex = 4;
            // 
            // dtContracTerminationDate
            // 
            this.dtContracTerminationDate.Location = new System.Drawing.Point(174, 255);
            this.dtContracTerminationDate.Name = "dtContracTerminationDate";
            this.dtContracTerminationDate.Size = new System.Drawing.Size(285, 34);
            this.dtContracTerminationDate.TabIndex = 5;
            // 
            // tbValuta
            // 
            this.tbValuta.FormattingEnabled = true;
            this.tbValuta.Location = new System.Drawing.Point(174, 309);
            this.tbValuta.Name = "tbValuta";
            this.tbValuta.Size = new System.Drawing.Size(238, 34);
            this.tbValuta.TabIndex = 6;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(53, 45);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(117, 19);
            this.materialLabel1.TabIndex = 7;
            this.materialLabel1.Text = "Наименование";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(22, 100);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(148, 19);
            this.materialLabel2.TabIndex = 8;
            this.materialLabel2.Text = "Банковского счета ";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(127, 153);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(43, 19);
            this.materialLabel3.TabIndex = 9;
            this.materialLabel3.Text = "Банк";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(55, 207);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(115, 19);
            this.materialLabel4.TabIndex = 10;
            this.materialLabel4.Text = "Дата открытия";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(55, 261);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(115, 19);
            this.materialLabel5.TabIndex = 11;
            this.materialLabel5.Text = "Дата закрытия";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(113, 315);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(57, 19);
            this.materialLabel6.TabIndex = 12;
            this.materialLabel6.Text = "Валута";
            // 
            // btnValuta
            // 
            this.btnValuta.BackColor = System.Drawing.Color.Brown;
            this.btnValuta.Location = new System.Drawing.Point(419, 307);
            this.btnValuta.Name = "btnValuta";
            this.btnValuta.Size = new System.Drawing.Size(40, 36);
            this.btnValuta.TabIndex = 13;
            this.btnValuta.Text = "...";
            this.btnValuta.UseVisualStyleBackColor = false;
            this.btnValuta.Click += new System.EventHandler(this.btnValuta_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Location = new System.Drawing.Point(328, 429);
            this.btnSave.Margin = new System.Windows.Forms.Padding(6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(131, 40);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "Добавить";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(174, 429);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 40);
            this.button1.TabIndex = 27;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(7, 372);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(163, 19);
            this.materialLabel7.TabIndex = 29;
            this.materialLabel7.Text = "Начисленный баланс";
            // 
            // tbAccountBalance
            // 
            this.tbAccountBalance.Location = new System.Drawing.Point(174, 366);
            this.tbAccountBalance.Name = "tbAccountBalance";
            this.tbAccountBalance.Size = new System.Drawing.Size(285, 34);
            this.tbAccountBalance.TabIndex = 28;
            // 
            // AddEditBankAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(560, 500);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.tbAccountBalance);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnValuta);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.tbValuta);
            this.Controls.Add(this.dtContracTerminationDate);
            this.Controls.Add(this.dtDateofContract);
            this.Controls.Add(this.btnBank);
            this.Controls.Add(this.tbGetBank);
            this.Controls.Add(this.tbAccountNumber);
            this.Controls.Add(this.tbName);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "AddEditBankAccount";
            this.Text = "Добавить банковский счет ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbAccountNumber;
        private System.Windows.Forms.TextBox tbGetBank;
        private System.Windows.Forms.Button btnBank;
        private System.Windows.Forms.DateTimePicker dtDateofContract;
        private System.Windows.Forms.DateTimePicker dtContracTerminationDate;
        private System.Windows.Forms.ComboBox tbValuta;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.Button btnValuta;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button1;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private System.Windows.Forms.TextBox tbAccountBalance;
    }
}