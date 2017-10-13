namespace Pressure_Converter
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
            this.lblEntry = new System.Windows.Forms.Label();
            this.lblOut = new System.Windows.Forms.Label();
            this.lblVal = new System.Windows.Forms.Label();
            this.lblOutputAnswer = new System.Windows.Forms.Label();
            this.cmbEntry = new System.Windows.Forms.ComboBox();
            this.cmbOut = new System.Windows.Forms.ComboBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEntry
            // 
            this.lblEntry.AutoSize = true;
            this.lblEntry.Location = new System.Drawing.Point(103, 65);
            this.lblEntry.Name = "lblEntry";
            this.lblEntry.Size = new System.Drawing.Size(53, 13);
            this.lblEntry.TabIndex = 0;
            this.lblEntry.Text = "Entry Unit";
            // 
            // lblOut
            // 
            this.lblOut.AutoSize = true;
            this.lblOut.Location = new System.Drawing.Point(345, 65);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(61, 13);
            this.lblOut.TabIndex = 1;
            this.lblOut.Text = "Output Unit";
            // 
            // lblVal
            // 
            this.lblVal.AutoSize = true;
            this.lblVal.Location = new System.Drawing.Point(103, 151);
            this.lblVal.Name = "lblVal";
            this.lblVal.Size = new System.Drawing.Size(62, 13);
            this.lblVal.TabIndex = 2;
            this.lblVal.Text = "Enter Value";
            // 
            // lblOutputAnswer
            // 
            this.lblOutputAnswer.AutoSize = true;
            this.lblOutputAnswer.Location = new System.Drawing.Point(103, 208);
            this.lblOutputAnswer.Name = "lblOutputAnswer";
            this.lblOutputAnswer.Size = new System.Drawing.Size(39, 13);
            this.lblOutputAnswer.TabIndex = 3;
            this.lblOutputAnswer.Text = "Output";
            // 
            // cmbEntry
            // 
            this.cmbEntry.FormattingEnabled = true;
            this.cmbEntry.Items.AddRange(new object[] {
            "Pascal",
            "atm",
            "mmHg",
            "bar",
            "torr",
            "psi"});
            this.cmbEntry.Location = new System.Drawing.Point(185, 65);
            this.cmbEntry.Name = "cmbEntry";
            this.cmbEntry.Size = new System.Drawing.Size(121, 21);
            this.cmbEntry.TabIndex = 4;
            // 
            // cmbOut
            // 
            this.cmbOut.FormattingEnabled = true;
            this.cmbOut.Items.AddRange(new object[] {
            "Pascal",
            "atm",
            "mmHg",
            "bar",
            "torr",
            "psi"});
            this.cmbOut.Location = new System.Drawing.Point(436, 62);
            this.cmbOut.Name = "cmbOut";
            this.cmbOut.Size = new System.Drawing.Size(121, 21);
            this.cmbOut.TabIndex = 5;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(185, 143);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 20);
            this.txtInput.TabIndex = 6;
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Location = new System.Drawing.Point(182, 208);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(35, 13);
            this.lblDisplay.TabIndex = 7;
            this.lblDisplay.Text = "label5";
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(402, 240);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 8;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 306);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.cmbOut);
            this.Controls.Add(this.cmbEntry);
            this.Controls.Add(this.lblOutputAnswer);
            this.Controls.Add(this.lblVal);
            this.Controls.Add(this.lblOut);
            this.Controls.Add(this.lblEntry);
            this.Name = "Form1";
            this.Text = "Pressure Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEntry;
        private System.Windows.Forms.Label lblOut;
        private System.Windows.Forms.Label lblVal;
        private System.Windows.Forms.Label lblOutputAnswer;
        private System.Windows.Forms.ComboBox cmbEntry;
        private System.Windows.Forms.ComboBox cmbOut;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Button btnConvert;
    }
}

