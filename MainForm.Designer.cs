namespace HexaBinaryDecConverter
{
    partial class MainForm
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
            this.InputBox = new System.Windows.Forms.TextBox();
            this.DecimalCheckIn = new System.Windows.Forms.CheckBox();
            this.HexaCheckIn = new System.Windows.Forms.CheckBox();
            this.BinaryCheckIn = new System.Windows.Forms.CheckBox();
            this.BinaryCheckOut = new System.Windows.Forms.CheckBox();
            this.HexaCheckOut = new System.Windows.Forms.CheckBox();
            this.DecimalCheckOut = new System.Windows.Forms.CheckBox();
            this.OutputBox = new System.Windows.Forms.TextBox();
            this.Arrow = new System.Windows.Forms.PictureBox();
            this.ConvertButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Arrow)).BeginInit();
            this.SuspendLayout();
            // 
            // InputBox
            // 
            this.InputBox.Location = new System.Drawing.Point(12, 78);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(100, 20);
            this.InputBox.TabIndex = 0;
            this.InputBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputBox_KeyPress);
            // 
            // DecimalCheckIn
            // 
            this.DecimalCheckIn.AutoSize = true;
            this.DecimalCheckIn.Checked = true;
            this.DecimalCheckIn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DecimalCheckIn.Location = new System.Drawing.Point(12, 9);
            this.DecimalCheckIn.Name = "DecimalCheckIn";
            this.DecimalCheckIn.Size = new System.Drawing.Size(64, 17);
            this.DecimalCheckIn.TabIndex = 1;
            this.DecimalCheckIn.Text = "Decimal";
            this.DecimalCheckIn.UseVisualStyleBackColor = true;
            this.DecimalCheckIn.CheckedChanged += new System.EventHandler(this.AnyBoxChecked);
            // 
            // HexaCheckIn
            // 
            this.HexaCheckIn.AutoSize = true;
            this.HexaCheckIn.Location = new System.Drawing.Point(12, 32);
            this.HexaCheckIn.Name = "HexaCheckIn";
            this.HexaCheckIn.Size = new System.Drawing.Size(87, 17);
            this.HexaCheckIn.TabIndex = 2;
            this.HexaCheckIn.Text = "Hexadecimal";
            this.HexaCheckIn.UseVisualStyleBackColor = true;
            this.HexaCheckIn.CheckedChanged += new System.EventHandler(this.AnyBoxChecked);
            // 
            // BinaryCheckIn
            // 
            this.BinaryCheckIn.AutoSize = true;
            this.BinaryCheckIn.Location = new System.Drawing.Point(12, 55);
            this.BinaryCheckIn.Name = "BinaryCheckIn";
            this.BinaryCheckIn.Size = new System.Drawing.Size(55, 17);
            this.BinaryCheckIn.TabIndex = 3;
            this.BinaryCheckIn.Text = "Binary";
            this.BinaryCheckIn.UseVisualStyleBackColor = true;
            this.BinaryCheckIn.CheckedChanged += new System.EventHandler(this.AnyBoxChecked);
            // 
            // BinaryCheckOut
            // 
            this.BinaryCheckOut.AutoSize = true;
            this.BinaryCheckOut.Location = new System.Drawing.Point(285, 55);
            this.BinaryCheckOut.Name = "BinaryCheckOut";
            this.BinaryCheckOut.Size = new System.Drawing.Size(55, 17);
            this.BinaryCheckOut.TabIndex = 6;
            this.BinaryCheckOut.Text = "Binary";
            this.BinaryCheckOut.UseVisualStyleBackColor = true;
            this.BinaryCheckOut.CheckedChanged += new System.EventHandler(this.AnyBoxChecked);
            // 
            // HexaCheckOut
            // 
            this.HexaCheckOut.AutoSize = true;
            this.HexaCheckOut.Location = new System.Drawing.Point(285, 32);
            this.HexaCheckOut.Name = "HexaCheckOut";
            this.HexaCheckOut.Size = new System.Drawing.Size(87, 17);
            this.HexaCheckOut.TabIndex = 5;
            this.HexaCheckOut.Text = "Hexadecimal";
            this.HexaCheckOut.UseVisualStyleBackColor = true;
            this.HexaCheckOut.CheckedChanged += new System.EventHandler(this.AnyBoxChecked);
            // 
            // DecimalCheckOut
            // 
            this.DecimalCheckOut.AutoSize = true;
            this.DecimalCheckOut.Location = new System.Drawing.Point(285, 9);
            this.DecimalCheckOut.Name = "DecimalCheckOut";
            this.DecimalCheckOut.Size = new System.Drawing.Size(64, 17);
            this.DecimalCheckOut.TabIndex = 4;
            this.DecimalCheckOut.Text = "Decimal";
            this.DecimalCheckOut.UseVisualStyleBackColor = true;
            this.DecimalCheckOut.CheckedChanged += new System.EventHandler(this.AnyBoxChecked);
            // 
            // OutputBox
            // 
            this.OutputBox.Location = new System.Drawing.Point(272, 78);
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.Size = new System.Drawing.Size(100, 20);
            this.OutputBox.TabIndex = 8;
            this.OutputBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OutputBox_KeyPress);
            // 
            // Arrow
            // 
            this.Arrow.Image = global::HexaBinaryDecConverter.Properties.Resources.Arrow;
            this.Arrow.Location = new System.Drawing.Point(139, 12);
            this.Arrow.Name = "Arrow";
            this.Arrow.Size = new System.Drawing.Size(100, 50);
            this.Arrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Arrow.TabIndex = 9;
            this.Arrow.TabStop = false;
            // 
            // ConvertButton
            // 
            this.ConvertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConvertButton.Location = new System.Drawing.Point(139, 68);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(100, 30);
            this.ConvertButton.TabIndex = 10;
            this.ConvertButton.Text = "Convert";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 108);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.Arrow);
            this.Controls.Add(this.OutputBox);
            this.Controls.Add(this.BinaryCheckOut);
            this.Controls.Add(this.HexaCheckOut);
            this.Controls.Add(this.DecimalCheckOut);
            this.Controls.Add(this.BinaryCheckIn);
            this.Controls.Add(this.HexaCheckIn);
            this.Controls.Add(this.DecimalCheckIn);
            this.Controls.Add(this.InputBox);
            this.Name = "MainForm";
            this.Text = "Conversion";
            ((System.ComponentModel.ISupportInitialize)(this.Arrow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.CheckBox DecimalCheckIn;
        private System.Windows.Forms.CheckBox HexaCheckIn;
        private System.Windows.Forms.CheckBox BinaryCheckIn;
        private System.Windows.Forms.CheckBox BinaryCheckOut;
        private System.Windows.Forms.CheckBox HexaCheckOut;
        private System.Windows.Forms.CheckBox DecimalCheckOut;
        private System.Windows.Forms.TextBox OutputBox;
        private System.Windows.Forms.PictureBox Arrow;
        private System.Windows.Forms.Button ConvertButton;
    }
}

