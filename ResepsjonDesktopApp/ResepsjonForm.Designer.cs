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
            buttonManageRooms = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMaintenance).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewMaintenance
            // 
            dataGridViewMaintenance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMaintenance.Location = new Point(207, 44);
            dataGridViewMaintenance.Name = "dataGridViewMaintenance";
            dataGridViewMaintenance.Size = new Size(600, 446);
            dataGridViewMaintenance.TabIndex = 0;
            // 
            // buttonNewTask
            // 
            buttonNewTask.Location = new Point(80, 44);
            buttonNewTask.Name = "buttonNewTask";
            buttonNewTask.Size = new Size(111, 23);
            buttonNewTask.TabIndex = 1;
            buttonNewTask.Text = "Ny Oppgave";
            buttonNewTask.UseVisualStyleBackColor = true;
            buttonNewTask.Click += buttonNewTask_Click_1;
            // 
            // buttonManageRooms
            // 
            buttonManageRooms.Location = new Point(80, 87);
            buttonManageRooms.Name = "buttonManageRooms";
            buttonManageRooms.Size = new Size(111, 43);
            buttonManageRooms.TabIndex = 2;
            buttonManageRooms.Text = "Administrer Rom/Reservasjoner";
            buttonManageRooms.UseVisualStyleBackColor = true;
            buttonManageRooms.Click += buttonManageRooms_Click;
            // 
            // ResepsjonForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 517);
            Controls.Add(buttonManageRooms);
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
        private Button buttonManageRooms;
    }
}