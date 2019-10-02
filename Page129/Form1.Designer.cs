namespace Page129
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
            this.joeCashLabel = new System.Windows.Forms.Label();
            this.bobCashLabel = new System.Windows.Forms.Label();
            this.bankCashLabel = new System.Windows.Forms.Label();
            this.joeButton = new System.Windows.Forms.Button();
            this.bobButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.joeGivesToBob = new System.Windows.Forms.Button();
            this.bobGivesToJoe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // joeCashLabel
            // 
            this.joeCashLabel.AutoSize = true;
            this.joeCashLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joeCashLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.joeCashLabel.Location = new System.Drawing.Point(31, 34);
            this.joeCashLabel.Name = "joeCashLabel";
            this.joeCashLabel.Size = new System.Drawing.Size(45, 13);
            this.joeCashLabel.TabIndex = 0;
            this.joeCashLabel.Text = "Joe has";
            // 
            // bobCashLabel
            // 
            this.bobCashLabel.AutoSize = true;
            this.bobCashLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bobCashLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.bobCashLabel.Location = new System.Drawing.Point(31, 55);
            this.bobCashLabel.Name = "bobCashLabel";
            this.bobCashLabel.Size = new System.Drawing.Size(49, 13);
            this.bobCashLabel.TabIndex = 1;
            this.bobCashLabel.Text = "Bob has";
            // 
            // bankCashLabel
            // 
            this.bankCashLabel.AutoSize = true;
            this.bankCashLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bankCashLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.bankCashLabel.Location = new System.Drawing.Point(31, 76);
            this.bankCashLabel.Name = "bankCashLabel";
            this.bankCashLabel.Size = new System.Drawing.Size(75, 13);
            this.bankCashLabel.TabIndex = 2;
            this.bankCashLabel.Text = "The bank has";
            // 
            // joeButton
            // 
            this.joeButton.Location = new System.Drawing.Point(33, 118);
            this.joeButton.Name = "joeButton";
            this.joeButton.Size = new System.Drawing.Size(82, 37);
            this.joeButton.TabIndex = 3;
            this.joeButton.Text = "Give $10 to Joe";
            this.joeButton.UseVisualStyleBackColor = true;
            this.joeButton.Click += new System.EventHandler(this.JoeButton_Click);
            // 
            // bobButton
            // 
            this.bobButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bobButton.Location = new System.Drawing.Point(143, 118);
            this.bobButton.Name = "bobButton";
            this.bobButton.Size = new System.Drawing.Size(118, 37);
            this.bobButton.TabIndex = 4;
            this.bobButton.Text = "Receive $5 from Bob";
            this.bobButton.UseVisualStyleBackColor = true;
            this.bobButton.Click += new System.EventHandler(this.BobButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            // 
            // joeGivesToBob
            // 
            this.joeGivesToBob.Location = new System.Drawing.Point(33, 161);
            this.joeGivesToBob.Name = "joeGivesToBob";
            this.joeGivesToBob.Size = new System.Drawing.Size(83, 37);
            this.joeGivesToBob.TabIndex = 5;
            this.joeGivesToBob.Text = "Joe gives $10 to Bob";
            this.joeGivesToBob.UseVisualStyleBackColor = true;
            this.joeGivesToBob.Click += new System.EventHandler(this.JoeGivesToBob_Click);
            // 
            // bobGivesToJoe
            // 
            this.bobGivesToJoe.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bobGivesToJoe.Location = new System.Drawing.Point(143, 161);
            this.bobGivesToJoe.Name = "bobGivesToJoe";
            this.bobGivesToJoe.Size = new System.Drawing.Size(118, 37);
            this.bobGivesToJoe.TabIndex = 6;
            this.bobGivesToJoe.Text = "Bob gives $5 to Joe";
            this.bobGivesToJoe.UseVisualStyleBackColor = true;
            this.bobGivesToJoe.Click += new System.EventHandler(this.BobGivesToJoe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(290, 241);
            this.Controls.Add(this.bobGivesToJoe);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.joeGivesToBob);
            this.Controls.Add(this.bobButton);
            this.Controls.Add(this.joeButton);
            this.Controls.Add(this.bankCashLabel);
            this.Controls.Add(this.bobCashLabel);
            this.Controls.Add(this.joeCashLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label joeCashLabel;
        private System.Windows.Forms.Label bobCashLabel;
        private System.Windows.Forms.Label bankCashLabel;
        private System.Windows.Forms.Button joeButton;
        private System.Windows.Forms.Button bobButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button joeGivesToBob;
        private System.Windows.Forms.Button bobGivesToJoe;
    }
}

