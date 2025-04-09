namespace SnappyQRServer
{
    partial class Form1
    {
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxSummary;
        private System.Windows.Forms.TextBox textBoxLocation;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            textBoxSummary = new TextBox();
            textBoxLocation = new TextBox();
            dateTimePickerStart = new DateTimePicker();
            dateTimePickerEnd = new DateTimePicker();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(14, 16);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(297, 347);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // textBoxSummary
            // 
            textBoxSummary.Location = new Point(14, 371);
            textBoxSummary.Margin = new Padding(3, 4, 3, 4);
            textBoxSummary.Name = "textBoxSummary";
            textBoxSummary.PlaceholderText = "Résumé";
            textBoxSummary.Size = new Size(297, 27);
            textBoxSummary.TabIndex = 1;
            // 
            // textBoxLocation
            // 
            textBoxLocation.Location = new Point(14, 409);
            textBoxLocation.Margin = new Padding(3, 4, 3, 4);
            textBoxLocation.Name = "textBoxLocation";
            textBoxLocation.PlaceholderText = "Lieu";
            textBoxLocation.Size = new Size(297, 27);
            textBoxLocation.TabIndex = 2;
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.Location = new Point(14, 448);
            dateTimePickerStart.Margin = new Padding(3, 4, 3, 4);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(297, 27);
            dateTimePickerStart.TabIndex = 3;
            dateTimePickerStart.ValueChanged += dateTimePickerStart_ValueChanged;
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.Location = new Point(14, 487);
            dateTimePickerEnd.Margin = new Padding(3, 4, 3, 4);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(297, 27);
            dateTimePickerEnd.TabIndex = 4;
            dateTimePickerEnd.ValueChanged += dateTimePickerEnd_ValueChanged;
            // 
            // button1
            // 
            button1.Location = new Point(114, 531);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "Valider";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 572);
            Controls.Add(button1);
            Controls.Add(dateTimePickerEnd);
            Controls.Add(dateTimePickerStart);
            Controls.Add(textBoxLocation);
            Controls.Add(textBoxSummary);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "QR Code iCal Generator";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private Button button1;
    }
}


