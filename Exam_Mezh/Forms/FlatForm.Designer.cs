namespace Exam_Mezh.Forms
{
    partial class FlatForm
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
            this.cbClient = new System.Windows.Forms.ComboBox();
            this.cbReqType = new System.Windows.Forms.ComboBox();
            this.numFloor = new System.Windows.Forms.NumericUpDown();
            this.numFootage = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateBuilding = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.elevator = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numFloor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFootage)).BeginInit();
            this.SuspendLayout();
            // 
            // cbClient
            // 
            this.cbClient.FormattingEnabled = true;
            this.cbClient.Location = new System.Drawing.Point(159, 79);
            this.cbClient.Name = "cbClient";
            this.cbClient.Size = new System.Drawing.Size(155, 21);
            this.cbClient.TabIndex = 0;
            // 
            // cbReqType
            // 
            this.cbReqType.FormattingEnabled = true;
            this.cbReqType.Items.AddRange(new object[] {
            "Продам",
            "Куплю"});
            this.cbReqType.Location = new System.Drawing.Point(159, 121);
            this.cbReqType.Name = "cbReqType";
            this.cbReqType.Size = new System.Drawing.Size(155, 21);
            this.cbReqType.TabIndex = 1;
            // 
            // numFloor
            // 
            this.numFloor.Location = new System.Drawing.Point(159, 213);
            this.numFloor.Name = "numFloor";
            this.numFloor.Size = new System.Drawing.Size(69, 20);
            this.numFloor.TabIndex = 2;
            // 
            // numFootage
            // 
            this.numFootage.DecimalPlaces = 2;
            this.numFootage.Location = new System.Drawing.Point(159, 257);
            this.numFootage.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numFootage.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numFootage.Name = "numFootage";
            this.numFootage.Size = new System.Drawing.Size(105, 20);
            this.numFootage.TabIndex = 3;
            this.numFootage.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Клиент";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Куплю/продам";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Этаж";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Метраж";
            // 
            // dateBuilding
            // 
            this.dateBuilding.Location = new System.Drawing.Point(169, 302);
            this.dateBuilding.Name = "dateBuilding";
            this.dateBuilding.Size = new System.Drawing.Size(155, 20);
            this.dateBuilding.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Дата строительства";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // elevator
            // 
            this.elevator.AutoSize = true;
            this.elevator.Location = new System.Drawing.Point(45, 358);
            this.elevator.Name = "elevator";
            this.elevator.Size = new System.Drawing.Size(103, 17);
            this.elevator.TabIndex = 10;
            this.elevator.Text = "Наличие лифта";
            this.elevator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.elevator.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.elevator.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Тип помещения";
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(159, 166);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(155, 21);
            this.cbType.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(45, 432);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 32);
            this.button1.TabIndex = 13;
            this.button1.Text = "Принять";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(239, 432);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 32);
            this.button2.TabIndex = 14;
            this.button2.Text = "Отменить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(36, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 34);
            this.button3.TabIndex = 15;
            this.button3.Text = "Список клиентов";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(220, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 34);
            this.button4.TabIndex = 16;
            this.button4.Text = "Типы помещений";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // FlatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 496);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.elevator);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateBuilding);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numFootage);
            this.Controls.Add(this.numFloor);
            this.Controls.Add(this.cbReqType);
            this.Controls.Add(this.cbClient);
            this.Name = "FlatForm";
            this.Text = "Flat";
            this.Load += new System.EventHandler(this.Flat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numFloor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFootage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        protected internal System.Windows.Forms.ComboBox cbClient;
        protected internal System.Windows.Forms.ComboBox cbReqType;
        protected internal System.Windows.Forms.NumericUpDown numFloor;
        protected internal System.Windows.Forms.NumericUpDown numFootage;
        protected internal System.Windows.Forms.DateTimePicker dateBuilding;
        protected internal System.Windows.Forms.CheckBox elevator;
        private System.Windows.Forms.Label label6;
        protected internal System.Windows.Forms.ComboBox cbType;
        protected internal System.Windows.Forms.Button button1;
        protected internal System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}