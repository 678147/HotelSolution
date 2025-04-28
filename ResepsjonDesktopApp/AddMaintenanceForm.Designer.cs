namespace ResepsjonDesktopApp
{
    partial class AddMaintenanceForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxDescription = new TextBox();
            textBoxRoomNumber = new TextBox();
            comboBoxTaskType = new ComboBox();
            comboBoxTaskStatus = new ComboBox();
            buttonSave = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 17);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 0;
            label1.Text = "Beskrivelse:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 47);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 1;
            label2.Text = "Romnummer:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 77);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 2;
            label3.Text = "Service:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 107);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 3;
            label4.Text = "Status:";
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(163, 14);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(268, 23);
            textBoxDescription.TabIndex = 4;
            // 
            // textBoxRoomNumber
            // 
            textBoxRoomNumber.Location = new Point(163, 44);
            textBoxRoomNumber.Name = "textBoxRoomNumber";
            textBoxRoomNumber.Size = new Size(268, 23);
            textBoxRoomNumber.TabIndex = 5;
            // 
            // comboBoxTaskType
            // 
            comboBoxTaskType.FormattingEnabled = true;
            comboBoxTaskType.Location = new Point(163, 74);
            comboBoxTaskType.Name = "comboBoxTaskType";
            comboBoxTaskType.Size = new Size(268, 23);
            comboBoxTaskType.TabIndex = 6;
            // 
            // comboBoxTaskStatus
            // 
            comboBoxTaskStatus.FormattingEnabled = true;
            comboBoxTaskStatus.Location = new Point(163, 103);
            comboBoxTaskStatus.Name = "comboBoxTaskStatus";
            comboBoxTaskStatus.Size = new Size(268, 23);
            comboBoxTaskStatus.TabIndex = 7;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(35, 152);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(81, 23);
            buttonSave.TabIndex = 8;
            buttonSave.Text = "Lagre";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click_1;
            // 
            // AddMaintenanceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSave);
            Controls.Add(comboBoxTaskStatus);
            Controls.Add(comboBoxTaskType);
            Controls.Add(textBoxRoomNumber);
            Controls.Add(textBoxDescription);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddMaintenanceForm";
            Text = "AddMaintenanceForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxDescription;
        private TextBox textBoxRoomNumber;
        private ComboBox comboBoxTaskType;
        private ComboBox comboBoxTaskStatus;
        private Button buttonSave;
    }
}