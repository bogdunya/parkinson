
namespace parkinson
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.BeginButton = new System.Windows.Forms.Button();
            this.txtSnils = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdMale = new System.Windows.Forms.RadioButton();
            this.rdFemale = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.patientsBrowser = new System.Windows.Forms.ListBox();
            this.addPatientButton = new System.Windows.Forms.Button();
            this.txtSearchSnils = new System.Windows.Forms.TextBox();
            this.Sessions = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // BeginButton
            // 
            this.BeginButton.Location = new System.Drawing.Point(779, 521);
            this.BeginButton.Name = "BeginButton";
            this.BeginButton.Size = new System.Drawing.Size(86, 23);
            this.BeginButton.TabIndex = 3;
            this.BeginButton.Text = "Начать";
            this.BeginButton.UseVisualStyleBackColor = true;
            this.BeginButton.Click += new System.EventHandler(this.BeginButton_Click);
            // 
            // txtSnils
            // 
            this.txtSnils.Location = new System.Drawing.Point(82, 31);
            this.txtSnils.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSnils.Name = "txtSnils";
            this.txtSnils.Size = new System.Drawing.Size(268, 22);
            this.txtSnils.TabIndex = 5;
            this.txtSnils.TextChanged += new System.EventHandler(this.txtSnils_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "СНИЛС";
            // 
            // rdMale
            // 
            this.rdMale.AutoSize = true;
            this.rdMale.Location = new System.Drawing.Point(69, 122);
            this.rdMale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdMale.Name = "rdMale";
            this.rdMale.Size = new System.Drawing.Size(88, 21);
            this.rdMale.TabIndex = 8;
            this.rdMale.TabStop = true;
            this.rdMale.Text = "Мужчина";
            this.rdMale.UseVisualStyleBackColor = true;
            // 
            // rdFemale
            // 
            this.rdFemale.AutoSize = true;
            this.rdFemale.Location = new System.Drawing.Point(201, 122);
            this.rdFemale.Margin = new System.Windows.Forms.Padding(4);
            this.rdFemale.Name = "rdFemale";
            this.rdFemale.Size = new System.Drawing.Size(93, 21);
            this.rdFemale.TabIndex = 9;
            this.rdFemale.TabStop = true;
            this.rdFemale.Text = "Женщина";
            this.rdFemale.UseVisualStyleBackColor = true;
            this.rdFemale.CheckedChanged += new System.EventHandler(this.rdFemale_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdFemale);
            this.groupBox1.Controls.Add(this.rdMale);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSnils);
            this.groupBox1.Location = new System.Drawing.Point(495, 44);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(370, 165);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Информация о пациенте";
            // 
            // patientsBrowser
            // 
            this.patientsBrowser.BackColor = System.Drawing.SystemColors.Window;
            this.patientsBrowser.FormattingEnabled = true;
            this.patientsBrowser.ItemHeight = 16;
            this.patientsBrowser.Location = new System.Drawing.Point(12, 12);
            this.patientsBrowser.Name = "patientsBrowser";
            this.patientsBrowser.Size = new System.Drawing.Size(460, 532);
            this.patientsBrowser.TabIndex = 4;
            this.patientsBrowser.SelectedIndexChanged += new System.EventHandler(this.patientBox_SelectedIndexChanged);
            // 
            // addPatientButton
            // 
            this.addPatientButton.Location = new System.Drawing.Point(632, 221);
            this.addPatientButton.Name = "addPatientButton";
            this.addPatientButton.Size = new System.Drawing.Size(88, 23);
            this.addPatientButton.TabIndex = 5;
            this.addPatientButton.Text = "Добавить";
            this.addPatientButton.UseVisualStyleBackColor = true;
            this.addPatientButton.Click += new System.EventHandler(this.addPatientButton_Click);
            // 
            // txtSearchSnils
            // 
            this.txtSearchSnils.Location = new System.Drawing.Point(765, 12);
            this.txtSearchSnils.Name = "txtSearchSnils";
            this.txtSearchSnils.Size = new System.Drawing.Size(100, 22);
            this.txtSearchSnils.TabIndex = 6;
            this.txtSearchSnils.TextChanged += new System.EventHandler(this.txtSearchSnils_TextChanged);
            this.txtSearchSnils.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearchSnils_KeyUp);
            // 
            // Sessions
            // 
            this.Sessions.FormattingEnabled = true;
            this.Sessions.ItemHeight = 16;
            this.Sessions.Location = new System.Drawing.Point(495, 259);
            this.Sessions.Name = "Sessions";
            this.Sessions.Size = new System.Drawing.Size(370, 244);
            this.Sessions.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(711, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Поиск";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(632, 522);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(494, 524);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Врема замера, сек";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 555);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Sessions);
            this.Controls.Add(this.txtSearchSnils);
            this.Controls.Add(this.addPatientButton);
            this.Controls.Add(this.patientsBrowser);
            this.Controls.Add(this.BeginButton);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BeginButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdFemale;
        private System.Windows.Forms.RadioButton rdMale;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSnils;
        private System.Windows.Forms.ListBox patientsBrowser;
        private System.Windows.Forms.Button addPatientButton;
        private System.Windows.Forms.TextBox txtSearchSnils;
        private System.Windows.Forms.ListBox Sessions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
    }
}

