namespace ResepsjonDesktopApp
{
    partial class SeReservasjonerForm
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
            dataGridViewReservasjoner = new DataGridView();
            buttonCheckInn = new Button();
            buttonCheckOut = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReservasjoner).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewReservasjoner
            // 
            dataGridViewReservasjoner.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReservasjoner.Location = new Point(127, 12);
            dataGridViewReservasjoner.Name = "dataGridViewReservasjoner";
            dataGridViewReservasjoner.Size = new Size(661, 426);
            dataGridViewReservasjoner.TabIndex = 0;
            dataGridViewReservasjoner.CellContentClick += dataGridViewReservasjoner_CellContentClick;
            // 
            // buttonCheckInn
            // 
            buttonCheckInn.Location = new Point(6, 54);
            buttonCheckInn.Name = "buttonCheckInn";
            buttonCheckInn.Size = new Size(115, 23);
            buttonCheckInn.TabIndex = 1;
            buttonCheckInn.Text = "Check Inn";
            buttonCheckInn.UseVisualStyleBackColor = true;
            buttonCheckInn.Click += buttonCheckInn_Click;
            // 
            // buttonCheckOut
            // 
            buttonCheckOut.Location = new Point(6, 83);
            buttonCheckOut.Name = "buttonCheckOut";
            buttonCheckOut.Size = new Size(115, 23);
            buttonCheckOut.TabIndex = 2;
            buttonCheckOut.Text = "Check Out";
            buttonCheckOut.UseVisualStyleBackColor = true;
            buttonCheckOut.Click += buttonCheckOut_Click;
            // 
            // button3
            // 
            button3.Location = new Point(6, 112);
            button3.Name = "button3";
            button3.Size = new Size(115, 37);
            button3.TabIndex = 3;
            button3.Text = "Delete Reservasjon";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // SeReservasjonerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(buttonCheckOut);
            Controls.Add(buttonCheckInn);
            Controls.Add(dataGridViewReservasjoner);
            Name = "SeReservasjonerForm";
            Text = "SeReservasjonerForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewReservasjoner).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewReservasjoner;
        private Button buttonCheckInn;
        private Button buttonCheckOut;
        private Button button3;
    }
}