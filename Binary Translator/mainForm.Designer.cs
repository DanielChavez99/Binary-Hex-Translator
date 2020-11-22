
namespace Binary_Translator
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.binaryLabel = new System.Windows.Forms.Label();
            this.hexLabel = new System.Windows.Forms.Label();
            this.translateButton = new System.Windows.Forms.Button();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.inputLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.binaryOutput = new System.Windows.Forms.Label();
            this.hexOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // binaryLabel
            // 
            this.binaryLabel.AutoSize = true;
            this.binaryLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.binaryLabel.ForeColor = System.Drawing.Color.White;
            this.binaryLabel.Location = new System.Drawing.Point(65, 78);
            this.binaryLabel.Name = "binaryLabel";
            this.binaryLabel.Size = new System.Drawing.Size(69, 22);
            this.binaryLabel.TabIndex = 1;
            this.binaryLabel.Text = "Binary";
            // 
            // hexLabel
            // 
            this.hexLabel.AutoSize = true;
            this.hexLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hexLabel.ForeColor = System.Drawing.Color.White;
            this.hexLabel.Location = new System.Drawing.Point(89, 128);
            this.hexLabel.Name = "hexLabel";
            this.hexLabel.Size = new System.Drawing.Size(45, 22);
            this.hexLabel.TabIndex = 4;
            this.hexLabel.Text = "Hex";
            // 
            // translateButton
            // 
            this.translateButton.BackColor = System.Drawing.Color.DimGray;
            this.translateButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.translateButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.translateButton.FlatAppearance.BorderSize = 0;
            this.translateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.translateButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.translateButton.ForeColor = System.Drawing.Color.White;
            this.translateButton.Location = new System.Drawing.Point(43, 187);
            this.translateButton.Name = "translateButton";
            this.translateButton.Size = new System.Drawing.Size(165, 50);
            this.translateButton.TabIndex = 6;
            this.translateButton.Text = "Translate";
            this.translateButton.UseVisualStyleBackColor = false;
            this.translateButton.Click += new System.EventHandler(this.translateButton_Click);
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(147, 30);
            this.inputTextBox.MaxLength = 9;
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(200, 20);
            this.inputTextBox.TabIndex = 9;
            this.inputTextBox.Text = "Enter a positive integer";
            this.inputTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inputTextBox.Click += new System.EventHandler(this.inputTextBox_Click);
            this.inputTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputTextBox_KeyDown);
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputLabel.ForeColor = System.Drawing.Color.White;
            this.inputLabel.Location = new System.Drawing.Point(77, 28);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(57, 22);
            this.inputLabel.TabIndex = 8;
            this.inputLabel.Text = "Input";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(229, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 50);
            this.button1.TabIndex = 10;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // binaryOutput
            // 
            this.binaryOutput.AutoSize = true;
            this.binaryOutput.BackColor = System.Drawing.Color.White;
            this.binaryOutput.Location = new System.Drawing.Point(147, 80);
            this.binaryOutput.MinimumSize = new System.Drawing.Size(200, 20);
            this.binaryOutput.Name = "binaryOutput";
            this.binaryOutput.Size = new System.Drawing.Size(200, 20);
            this.binaryOutput.TabIndex = 13;
            this.binaryOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hexOutput
            // 
            this.hexOutput.AutoSize = true;
            this.hexOutput.BackColor = System.Drawing.Color.White;
            this.hexOutput.Location = new System.Drawing.Point(147, 130);
            this.hexOutput.MinimumSize = new System.Drawing.Size(200, 20);
            this.hexOutput.Name = "hexOutput";
            this.hexOutput.Size = new System.Drawing.Size(200, 20);
            this.hexOutput.TabIndex = 14;
            this.hexOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(434, 261);
            this.Controls.Add(this.hexOutput);
            this.Controls.Add(this.binaryOutput);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.translateButton);
            this.Controls.Add(this.hexLabel);
            this.Controls.Add(this.binaryLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Binary Translator";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label binaryLabel;
        private System.Windows.Forms.Label hexLabel;
        private System.Windows.Forms.Button translateButton;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label binaryOutput;
        private System.Windows.Forms.Label hexOutput;
    }
}

