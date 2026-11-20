namespace FormsPUPPoints
{
    partial class Form1
    {
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblFacultyNumber = new Label();
            txtFacultyNumber = new TextBox();
            btnCheck = new Button();
            SuspendLayout();
            // 
            // lblFacultyNumber
            // 
            lblFacultyNumber.AutoSize = true;
            lblFacultyNumber.Location = new Point(82, 61);
            lblFacultyNumber.Name = "lblFacultyNumber";
            lblFacultyNumber.Size = new Size(136, 25);
            lblFacultyNumber.TabIndex = 0;
            lblFacultyNumber.Text = "Faculty Number";
            // 
            // txtFacultyNumber
            // 
            txtFacultyNumber.Location = new Point(224, 55);
            txtFacultyNumber.Name = "txtFacultyNumber";
            txtFacultyNumber.Size = new Size(150, 31);
            txtFacultyNumber.TabIndex = 1;
            // 
            // btnCheck
            // 
            btnCheck.Location = new Point(380, 56);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(112, 34);
            btnCheck.TabIndex = 2;
            btnCheck.Text = "Check";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCheck);
            Controls.Add(txtFacultyNumber);
            Controls.Add(lblFacultyNumber);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFacultyNumber;
        private TextBox txtFacultyNumber;
        private Button btnCheck;
    }
}
