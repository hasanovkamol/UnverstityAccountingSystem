
namespace UnverstityAccountingSystem.AllWindows
{
    partial class PaymentStudent
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbPrace = new System.Windows.Forms.TextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.tbFIO = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbPayment = new MaterialSkin.Controls.MaterialLabel();
            this.tbDiraction = new MaterialSkin.Controls.MaterialLabel();
            this.tbFacultet = new MaterialSkin.Controls.MaterialLabel();
            this.tbCourse = new MaterialSkin.Controls.MaterialLabel();
            this.btnBank = new System.Windows.Forms.Button();
            this.tbBankAccount = new System.Windows.Forms.TextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.tbValuta = new System.Windows.Forms.ComboBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.lbError = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(89, 386);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 40);
            this.button1.TabIndex = 46;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Location = new System.Drawing.Point(260, 386);
            this.btnSave.Margin = new System.Windows.Forms.Padding(6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(129, 40);
            this.btnSave.TabIndex = 45;
            this.btnSave.Text = "Оплата";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbPrace
            // 
            this.tbPrace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPrace.Location = new System.Drawing.Point(89, 331);
            this.tbPrace.Name = "tbPrace";
            this.tbPrace.Size = new System.Drawing.Size(207, 26);
            this.tbPrace.TabIndex = 48;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(89, 305);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(152, 19);
            this.materialLabel1.TabIndex = 49;
            this.materialLabel1.Text = "Договорные деньги";
            this.materialLabel1.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // tbFIO
            // 
            this.tbFIO.AutoSize = true;
            this.tbFIO.Depth = 0;
            this.tbFIO.Font = new System.Drawing.Font("Roboto", 11F);
            this.tbFIO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbFIO.Location = new System.Drawing.Point(32, 35);
            this.tbFIO.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbFIO.Name = "tbFIO";
            this.tbFIO.Size = new System.Drawing.Size(109, 19);
            this.tbFIO.TabIndex = 50;
            this.tbFIO.Text = "Имя Фамилия";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Azure;
            this.groupBox1.Controls.Add(this.tbPayment);
            this.groupBox1.Controls.Add(this.tbDiraction);
            this.groupBox1.Controls.Add(this.tbFacultet);
            this.groupBox1.Controls.Add(this.tbCourse);
            this.groupBox1.Controls.Add(this.tbFIO);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(52, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 195);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Информация для студентов ";
            // 
            // tbPayment
            // 
            this.tbPayment.AutoSize = true;
            this.tbPayment.Depth = 0;
            this.tbPayment.Font = new System.Drawing.Font("Roboto", 11F);
            this.tbPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbPayment.Location = new System.Drawing.Point(14, 157);
            this.tbPayment.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbPayment.Name = "tbPayment";
            this.tbPayment.Size = new System.Drawing.Size(127, 19);
            this.tbPayment.TabIndex = 54;
            this.tbPayment.Text = "Текущий платеж";
            // 
            // tbDiraction
            // 
            this.tbDiraction.AutoSize = true;
            this.tbDiraction.Depth = 0;
            this.tbDiraction.Font = new System.Drawing.Font("Roboto", 11F);
            this.tbDiraction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbDiraction.Location = new System.Drawing.Point(36, 125);
            this.tbDiraction.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbDiraction.Name = "tbDiraction";
            this.tbDiraction.Size = new System.Drawing.Size(105, 19);
            this.tbDiraction.TabIndex = 53;
            this.tbDiraction.Text = "Направление";
            // 
            // tbFacultet
            // 
            this.tbFacultet.AutoSize = true;
            this.tbFacultet.Depth = 0;
            this.tbFacultet.Font = new System.Drawing.Font("Roboto", 11F);
            this.tbFacultet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbFacultet.Location = new System.Drawing.Point(58, 95);
            this.tbFacultet.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbFacultet.Name = "tbFacultet";
            this.tbFacultet.Size = new System.Drawing.Size(83, 19);
            this.tbFacultet.TabIndex = 52;
            this.tbFacultet.Text = "Факультет";
            // 
            // tbCourse
            // 
            this.tbCourse.AutoSize = true;
            this.tbCourse.Depth = 0;
            this.tbCourse.Font = new System.Drawing.Font("Roboto", 11F);
            this.tbCourse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbCourse.Location = new System.Drawing.Point(99, 65);
            this.tbCourse.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbCourse.Name = "tbCourse";
            this.tbCourse.Size = new System.Drawing.Size(42, 19);
            this.tbCourse.TabIndex = 51;
            this.tbCourse.Text = "Курс";
            // 
            // btnBank
            // 
            this.btnBank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnBank.Location = new System.Drawing.Point(350, 264);
            this.btnBank.Name = "btnBank";
            this.btnBank.Size = new System.Drawing.Size(39, 29);
            this.btnBank.TabIndex = 57;
            this.btnBank.Text = "...";
            this.btnBank.UseVisualStyleBackColor = false;
            this.btnBank.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbBankAccount
            // 
            this.tbBankAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbBankAccount.Location = new System.Drawing.Point(89, 264);
            this.tbBankAccount.Name = "tbBankAccount";
            this.tbBankAccount.Size = new System.Drawing.Size(256, 26);
            this.tbBankAccount.TabIndex = 56;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(89, 234);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(194, 19);
            this.materialLabel3.TabIndex = 55;
            this.materialLabel3.Text = "Номер банковского счета";
            // 
            // tbValuta
            // 
            this.tbValuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbValuta.FormattingEnabled = true;
            this.tbValuta.Location = new System.Drawing.Point(302, 331);
            this.tbValuta.Name = "tbValuta";
            this.tbValuta.Size = new System.Drawing.Size(87, 26);
            this.tbValuta.TabIndex = 58;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(304, 305);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(66, 19);
            this.materialLabel2.TabIndex = 59;
            this.materialLabel2.Text = "Валюта ";
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.ForeColor = System.Drawing.Color.Red;
            this.lbError.Location = new System.Drawing.Point(138, 364);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(0, 13);
            this.lbError.TabIndex = 60;
            // 
            // PaymentStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 461);
            this.Controls.Add(this.lbError);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.tbValuta);
            this.Controls.Add(this.btnBank);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbBankAccount);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.tbPrace);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSave);
            this.Name = "PaymentStudent";
            this.Text = "PaymentStudent";
            this.Load += new System.EventHandler(this.PaymentStudent_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbPrace;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel tbFIO;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialLabel tbDiraction;
        private MaterialSkin.Controls.MaterialLabel tbFacultet;
        private MaterialSkin.Controls.MaterialLabel tbCourse;
        private MaterialSkin.Controls.MaterialLabel tbPayment;
        private System.Windows.Forms.Button btnBank;
        private System.Windows.Forms.TextBox tbBankAccount;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.ComboBox tbValuta;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.Label lbError;
    }
}