
namespace Live_Currency_Converter
{
    partial class Form1
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.FromLabel = new System.Windows.Forms.Label();
            this.ToLabel = new System.Windows.Forms.Label();
            this.FromComboBox = new System.Windows.Forms.ComboBox();
            this.ToComboBox = new System.Windows.Forms.ComboBox();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ConvertedAmountLabel = new System.Windows.Forms.Label();
            this.Convert_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(204, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(365, 62);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Dynamic Currency Converter\r\nChoose the date and time";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(289, 118);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // FromLabel
            // 
            this.FromLabel.AutoSize = true;
            this.FromLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromLabel.Location = new System.Drawing.Point(37, 168);
            this.FromLabel.Name = "FromLabel";
            this.FromLabel.Size = new System.Drawing.Size(55, 24);
            this.FromLabel.TabIndex = 2;
            this.FromLabel.Text = "From";
            // 
            // ToLabel
            // 
            this.ToLabel.AutoSize = true;
            this.ToLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToLabel.Location = new System.Drawing.Point(536, 168);
            this.ToLabel.Name = "ToLabel";
            this.ToLabel.Size = new System.Drawing.Size(33, 24);
            this.ToLabel.TabIndex = 3;
            this.ToLabel.Text = "To";
            // 
            // FromComboBox
            // 
            this.FromComboBox.FormattingEnabled = true;
            this.FromComboBox.Location = new System.Drawing.Point(41, 227);
            this.FromComboBox.Name = "FromComboBox";
            this.FromComboBox.Size = new System.Drawing.Size(211, 21);
            this.FromComboBox.TabIndex = 4;
            this.FromComboBox.SelectedIndexChanged += new System.EventHandler(this.FromComboBox_SelectedIndexChanged);
            // 
            // ToComboBox
            // 
            this.ToComboBox.FormattingEnabled = true;
            this.ToComboBox.Location = new System.Drawing.Point(540, 227);
            this.ToComboBox.Name = "ToComboBox";
            this.ToComboBox.Size = new System.Drawing.Size(217, 21);
            this.ToComboBox.TabIndex = 5;
            this.ToComboBox.SelectedIndexChanged += new System.EventHandler(this.ToComboBox_SelectedIndexChanged);
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountLabel.Location = new System.Drawing.Point(37, 343);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(86, 24);
            this.AmountLabel.TabIndex = 6;
            this.AmountLabel.Text = "Amount :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(210, 348);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(217, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ConvertedAmountLabel
            // 
            this.ConvertedAmountLabel.AutoSize = true;
            this.ConvertedAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConvertedAmountLabel.Location = new System.Drawing.Point(37, 453);
            this.ConvertedAmountLabel.Name = "ConvertedAmountLabel";
            this.ConvertedAmountLabel.Size = new System.Drawing.Size(183, 24);
            this.ConvertedAmountLabel.TabIndex = 8;
            this.ConvertedAmountLabel.Text = "Converted Amount : ";
            this.ConvertedAmountLabel.Click += new System.EventHandler(this.ConvertedAmountLabel_Click);
            // 
            // Convert_Button
            // 
            this.Convert_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Convert_Button.Location = new System.Drawing.Point(320, 264);
            this.Convert_Button.Name = "Convert_Button";
            this.Convert_Button.Size = new System.Drawing.Size(134, 49);
            this.Convert_Button.TabIndex = 9;
            this.Convert_Button.Text = "Convert";
            this.Convert_Button.UseVisualStyleBackColor = true;
            this.Convert_Button.Click += new System.EventHandler(this.Convert_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.Convert_Button);
            this.Controls.Add(this.ConvertedAmountLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.ToComboBox);
            this.Controls.Add(this.FromComboBox);
            this.Controls.Add(this.ToLabel);
            this.Controls.Add(this.FromLabel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.TitleLabel);
            this.Name = "Form1";
            this.Text = "Dynamic Currency Converter by Dicksen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label FromLabel;
        private System.Windows.Forms.Label ToLabel;
        private System.Windows.Forms.ComboBox FromComboBox;
        private System.Windows.Forms.ComboBox ToComboBox;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label ConvertedAmountLabel;
        private System.Windows.Forms.Button Convert_Button;
    }
}

