namespace ResepsjonDesktopApp
{
    partial class ResepsjonForm
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
            dataGridViewMaintenance = new DataGridView();
            buttonNewTask = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMaintenance).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewMaintenance
            // 
            dataGridViewMaintenance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMaintenance.Location = new Point(128, 82);
            dataGridViewMaintenance.Name = "dataGridViewMaintenance";
            dataGridViewMaintenance.Size = new Size(600, 300);
            dataGridViewMaintenance.TabIndex = 0;
            // 
            // buttonNewTask
            // 
            buttonNewTask.Location = new Point(366, 210);
            buttonNewTask.Name = "buttonNewTask";
            buttonNewTask.Size = new Size(102, 23);
            buttonNewTask.TabIndex = 1;
            buttonNewTask.Text = "Ny Oppgave";
            buttonNewTask.UseVisualStyleBackColor = true;
            buttonNewTask.Click += buttonNewTask_Click_1;
            // 
            // ResepsjonForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 517);
            Controls.Add(buttonNewTask);
            Controls.Add(dataGridViewMaintenance);
            Name = "ResepsjonForm";
            Text = "ResepsjonForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewMaintenance).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewMaintenance;
        private Button buttonNewTask;
    }
}