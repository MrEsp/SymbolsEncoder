namespace Encoder
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
            this.sourceDataTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sourceBytesTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.encodedDataTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.encodedBytesTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sourceEncodingsCmbx = new System.Windows.Forms.ComboBox();
            this.encodedEncodingsCmbx = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sourceDataTextBox
            // 
            this.sourceDataTextBox.Location = new System.Drawing.Point(13, 104);
            this.sourceDataTextBox.Multiline = true;
            this.sourceDataTextBox.Name = "sourceDataTextBox";
            this.sourceDataTextBox.Size = new System.Drawing.Size(246, 165);
            this.sourceDataTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Source";
            // 
            // sourceBytesTextBox
            // 
            this.sourceBytesTextBox.Location = new System.Drawing.Point(13, 296);
            this.sourceBytesTextBox.Multiline = true;
            this.sourceBytesTextBox.Name = "sourceBytesTextBox";
            this.sourceBytesTextBox.Size = new System.Drawing.Size(246, 108);
            this.sourceBytesTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bytes";
            // 
            // encodedDataTextbox
            // 
            this.encodedDataTextbox.Location = new System.Drawing.Point(291, 106);
            this.encodedDataTextbox.Multiline = true;
            this.encodedDataTextbox.Name = "encodedDataTextbox";
            this.encodedDataTextbox.Size = new System.Drawing.Size(294, 162);
            this.encodedDataTextbox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Decoded";
            // 
            // encodedBytesTextBox
            // 
            this.encodedBytesTextBox.Location = new System.Drawing.Point(291, 296);
            this.encodedBytesTextBox.Multiline = true;
            this.encodedBytesTextBox.Name = "encodedBytesTextBox";
            this.encodedBytesTextBox.Size = new System.Drawing.Size(294, 108);
            this.encodedBytesTextBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(299, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Bytes";
            // 
            // sourceEncodingsCmbx
            // 
            this.sourceEncodingsCmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sourceEncodingsCmbx.FormattingEnabled = true;
            this.sourceEncodingsCmbx.Location = new System.Drawing.Point(13, 28);
            this.sourceEncodingsCmbx.Name = "sourceEncodingsCmbx";
            this.sourceEncodingsCmbx.Size = new System.Drawing.Size(195, 21);
            this.sourceEncodingsCmbx.TabIndex = 8;
            // 
            // encodedEncodingsCmbx
            // 
            this.encodedEncodingsCmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.encodedEncodingsCmbx.FormattingEnabled = true;
            this.encodedEncodingsCmbx.Location = new System.Drawing.Point(291, 28);
            this.encodedEncodingsCmbx.Name = "encodedEncodingsCmbx";
            this.encodedEncodingsCmbx.Size = new System.Drawing.Size(187, 21);
            this.encodedEncodingsCmbx.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(184, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Decode";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 438);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.encodedEncodingsCmbx);
            this.Controls.Add(this.sourceEncodingsCmbx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.encodedBytesTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.encodedDataTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sourceBytesTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sourceDataTextBox);
            this.Name = "Form1";
            this.Text = "Symbols Encoder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sourceDataTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sourceBytesTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox encodedDataTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox encodedBytesTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox sourceEncodingsCmbx;
        private System.Windows.Forms.ComboBox encodedEncodingsCmbx;
        private System.Windows.Forms.Button button1;
    }
}

