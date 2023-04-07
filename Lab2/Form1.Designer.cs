
namespace Lab2
{
    partial class tipCalculator
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
            this.priceLabel = new System.Windows.Forms.Label();
            this.priceTxt = new System.Windows.Forms.TextBox();
            this.Label15 = new System.Windows.Forms.Label();
            this.Label18 = new System.Windows.Forms.Label();
            this.Label20 = new System.Windows.Forms.Label();
            this.displayTipButton = new System.Windows.Forms.Button();
            this.outputLabel15P = new System.Windows.Forms.Label();
            this.outputLabel18P = new System.Windows.Forms.Label();
            this.outputLabel20P = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(85, 40);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(98, 13);
            this.priceLabel.TabIndex = 0;
            this.priceLabel.Text = "Enter price of meal:";
            // 
            // priceTxt
            // 
            this.priceTxt.Location = new System.Drawing.Point(202, 37);
            this.priceTxt.Name = "priceTxt";
            this.priceTxt.Size = new System.Drawing.Size(103, 20);
            this.priceTxt.TabIndex = 1;
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Location = new System.Drawing.Point(129, 76);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(27, 13);
            this.Label15.TabIndex = 2;
            this.Label15.Text = "15%";
            // 
            // Label18
            // 
            this.Label18.AutoSize = true;
            this.Label18.Location = new System.Drawing.Point(129, 115);
            this.Label18.Name = "Label18";
            this.Label18.Size = new System.Drawing.Size(27, 13);
            this.Label18.TabIndex = 3;
            this.Label18.Text = "18%";
            // 
            // Label20
            // 
            this.Label20.AutoSize = true;
            this.Label20.Location = new System.Drawing.Point(129, 153);
            this.Label20.Name = "Label20";
            this.Label20.Size = new System.Drawing.Size(27, 13);
            this.Label20.TabIndex = 4;
            this.Label20.Text = "20%";
            // 
            // displayTipButton
            // 
            this.displayTipButton.Location = new System.Drawing.Point(148, 196);
            this.displayTipButton.Name = "displayTipButton";
            this.displayTipButton.Size = new System.Drawing.Size(94, 23);
            this.displayTipButton.TabIndex = 8;
            this.displayTipButton.Text = "Calculate Tip";
            this.displayTipButton.UseVisualStyleBackColor = true;
            this.displayTipButton.Click += new System.EventHandler(this.displayTipButton_Click);
            // 
            // outputLabel15P
            // 
            this.outputLabel15P.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputLabel15P.Location = new System.Drawing.Point(175, 75);
            this.outputLabel15P.Name = "outputLabel15P";
            this.outputLabel15P.Size = new System.Drawing.Size(103, 23);
            this.outputLabel15P.TabIndex = 9;
            // 
            // outputLabel18P
            // 
            this.outputLabel18P.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputLabel18P.Location = new System.Drawing.Point(175, 114);
            this.outputLabel18P.Name = "outputLabel18P";
            this.outputLabel18P.Size = new System.Drawing.Size(103, 23);
            this.outputLabel18P.TabIndex = 10;
            // 
            // outputLabel20P
            // 
            this.outputLabel20P.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputLabel20P.Location = new System.Drawing.Point(175, 152);
            this.outputLabel20P.Name = "outputLabel20P";
            this.outputLabel20P.Size = new System.Drawing.Size(103, 23);
            this.outputLabel20P.TabIndex = 11;
            // 
            // tipCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 300);
            this.Controls.Add(this.outputLabel20P);
            this.Controls.Add(this.outputLabel18P);
            this.Controls.Add(this.outputLabel15P);
            this.Controls.Add(this.displayTipButton);
            this.Controls.Add(this.Label20);
            this.Controls.Add(this.Label18);
            this.Controls.Add(this.Label15);
            this.Controls.Add(this.priceTxt);
            this.Controls.Add(this.priceLabel);
            this.Name = "tipCalculator";
            this.Text = "Lab2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox priceTxt;
        private System.Windows.Forms.Label Label15;
        private System.Windows.Forms.Label Label18;
        private System.Windows.Forms.Label Label20;
        private System.Windows.Forms.Button displayTipButton;
        private System.Windows.Forms.Label outputLabel15P;
        private System.Windows.Forms.Label outputLabel18P;
        private System.Windows.Forms.Label outputLabel20P;
    }
}

