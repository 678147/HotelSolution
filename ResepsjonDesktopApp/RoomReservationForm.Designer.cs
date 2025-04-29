namespace ResepsjonDesktopApp
{
    partial class RoomReservationForm
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
            dataGridViewRooms = new DataGridView();
            buttonNewReservation = new Button();
            label1 = new Label();
            textBoxEmail = new TextBox();
            dateTimePickerCheckInn = new DateTimePicker();
            dateTimePickerCheckOut = new DateTimePicker();
            buttonSeReservasjoner = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRooms).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewRooms
            // 
            dataGridViewRooms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRooms.Location = new Point(229, 12);
            dataGridViewRooms.Name = "dataGridViewRooms";
            dataGridViewRooms.Size = new Size(559, 404);
            dataGridViewRooms.TabIndex = 0;
            // 
            // buttonNewReservation
            // 
            buttonNewReservation.Location = new Point(60, 161);
            buttonNewReservation.Name = "buttonNewReservation";
            buttonNewReservation.Size = new Size(112, 35);
            buttonNewReservation.TabIndex = 1;
            buttonNewReservation.Text = "Ny Reservasjon";
            buttonNewReservation.UseVisualStyleBackColor = true;
            buttonNewReservation.Click += buttonNewReservation_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 48);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 2;
            label1.Text = "Email: ";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(60, 45);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(100, 23);
            textBoxEmail.TabIndex = 3;
            // 
            // dateTimePickerCheckInn
            // 
            dateTimePickerCheckInn.Location = new Point(12, 89);
            dateTimePickerCheckInn.Name = "dateTimePickerCheckInn";
            dateTimePickerCheckInn.Size = new Size(190, 23);
            dateTimePickerCheckInn.TabIndex = 4;
            // 
            // dateTimePickerCheckOut
            // 
            dateTimePickerCheckOut.Location = new Point(12, 118);
            dateTimePickerCheckOut.Name = "dateTimePickerCheckOut";
            dateTimePickerCheckOut.Size = new Size(190, 23);
            dateTimePickerCheckOut.TabIndex = 5;
            // 
            // buttonSeReservasjoner
            // 
            buttonSeReservasjoner.Location = new Point(60, 202);
            buttonSeReservasjoner.Name = "buttonSeReservasjoner";
            buttonSeReservasjoner.Size = new Size(112, 36);
            buttonSeReservasjoner.TabIndex = 6;
            buttonSeReservasjoner.Text = "Se Reservasjoner";
            buttonSeReservasjoner.UseVisualStyleBackColor = true;
            buttonSeReservasjoner.Click += buttonSeReservasjoner_Click;
            // 
            // RoomReservationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSeReservasjoner);
            Controls.Add(dateTimePickerCheckOut);
            Controls.Add(dateTimePickerCheckInn);
            Controls.Add(textBoxEmail);
            Controls.Add(label1);
            Controls.Add(buttonNewReservation);
            Controls.Add(dataGridViewRooms);
            Name = "RoomReservationForm";
            Text = "RoomReservationForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewRooms).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewRooms;
        private Button buttonNewReservation;
        private Label label1;
        private TextBox textBoxEmail;
        private DateTimePicker dateTimePickerCheckInn;
        private DateTimePicker dateTimePickerCheckOut;
        private Button buttonSeReservasjoner;
    }
}