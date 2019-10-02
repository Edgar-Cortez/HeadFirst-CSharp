namespace Page151
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
            this.startingMileageLabel = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.endingMileageLabel = new System.Windows.Forms.Label();
            this.amountOwedLabel = new System.Windows.Forms.Label();
            this.amountOwedValueLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.displayMilesButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // startingMileageLabel
            // 
            this.startingMileageLabel.AutoSize = true;
            this.startingMileageLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.startingMileageLabel.Location = new System.Drawing.Point(23, 28);
            this.startingMileageLabel.Name = "startingMileageLabel";
            this.startingMileageLabel.Size = new System.Drawing.Size(83, 13);
            this.startingMileageLabel.TabIndex = 0;
            this.startingMileageLabel.Text = "Starting Mileage";
            this.startingMileageLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(118, 26);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(118, 58);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2.TabIndex = 3;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // endingMileageLabel
            // 
            this.endingMileageLabel.AutoSize = true;
            this.endingMileageLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.endingMileageLabel.Location = new System.Drawing.Point(26, 60);
            this.endingMileageLabel.Name = "endingMileageLabel";
            this.endingMileageLabel.Size = new System.Drawing.Size(80, 13);
            this.endingMileageLabel.TabIndex = 2;
            this.endingMileageLabel.Text = "Ending Mileage";
            this.endingMileageLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // amountOwedLabel
            // 
            this.amountOwedLabel.AutoSize = true;
            this.amountOwedLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.amountOwedLabel.Location = new System.Drawing.Point(32, 94);
            this.amountOwedLabel.Name = "amountOwedLabel";
            this.amountOwedLabel.Size = new System.Drawing.Size(74, 13);
            this.amountOwedLabel.TabIndex = 4;
            this.amountOwedLabel.Text = "Amount Owed";
            this.amountOwedLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // amountOwedValueLabel
            // 
            this.amountOwedValueLabel.AutoSize = true;
            this.amountOwedValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountOwedValueLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.amountOwedValueLabel.Location = new System.Drawing.Point(118, 94);
            this.amountOwedValueLabel.Name = "amountOwedValueLabel";
            this.amountOwedValueLabel.Size = new System.Drawing.Size(47, 13);
            this.amountOwedValueLabel.TabIndex = 5;
            this.amountOwedValueLabel.Text = "VALUE";
            this.amountOwedValueLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(12, 124);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(133, 23);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // displayMilesButton
            // 
            this.displayMilesButton.Location = new System.Drawing.Point(156, 124);
            this.displayMilesButton.Name = "displayMilesButton";
            this.displayMilesButton.Size = new System.Drawing.Size(133, 23);
            this.displayMilesButton.TabIndex = 7;
            this.displayMilesButton.Text = "Display Miles";
            this.displayMilesButton.UseVisualStyleBackColor = true;
            this.displayMilesButton.Click += new System.EventHandler(this.DisplayMilesButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 177);
            this.Controls.Add(this.displayMilesButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.amountOwedValueLabel);
            this.Controls.Add(this.amountOwedLabel);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.endingMileageLabel);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.startingMileageLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label startingMileageLabel;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label endingMileageLabel;
        private System.Windows.Forms.Label amountOwedLabel;
        private System.Windows.Forms.Label amountOwedValueLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button displayMilesButton;
    }
}

