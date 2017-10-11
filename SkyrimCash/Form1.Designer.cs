namespace SkyrimCash
{
    partial class cashRegister
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.vanillaLabel = new System.Windows.Forms.Label();
            this.sameLabel = new System.Windows.Forms.Label();
            this.betterLabel = new System.Windows.Forms.Label();
            this.vanillaBox = new System.Windows.Forms.TextBox();
            this.sameBox = new System.Windows.Forms.TextBox();
            this.betterBox = new System.Windows.Forms.TextBox();
            this.totalButton = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            this.receiptButton = new System.Windows.Forms.Button();
            this.moneyLabel = new System.Windows.Forms.Label();
            this.catchLabel = new System.Windows.Forms.Label();
            this.changeBox = new System.Windows.Forms.TextBox();
            this.cashLabel = new System.Windows.Forms.Label();
            this.changeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Lithos Pro Regular", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(49, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(614, 81);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Todd\'s Skyrim Market";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vanillaLabel
            // 
            this.vanillaLabel.AutoSize = true;
            this.vanillaLabel.Font = new System.Drawing.Font("Lithos Pro Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vanillaLabel.Location = new System.Drawing.Point(112, 111);
            this.vanillaLabel.Name = "vanillaLabel";
            this.vanillaLabel.Size = new System.Drawing.Size(247, 22);
            this.vanillaLabel.TabIndex = 1;
            this.vanillaLabel.Text = "Vanilla Skyrim: $29.99";
            // 
            // sameLabel
            // 
            this.sameLabel.AutoSize = true;
            this.sameLabel.Font = new System.Drawing.Font("Lithos Pro Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sameLabel.Location = new System.Drawing.Point(112, 222);
            this.sameLabel.Name = "sameLabel";
            this.sameLabel.Size = new System.Drawing.Size(271, 22);
            this.sameLabel.TabIndex = 2;
            this.sameLabel.Text = "The Same Skyrim $109.99";
            // 
            // betterLabel
            // 
            this.betterLabel.AutoSize = true;
            this.betterLabel.Font = new System.Drawing.Font("Lithos Pro Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betterLabel.Location = new System.Drawing.Point(112, 163);
            this.betterLabel.Name = "betterLabel";
            this.betterLabel.Size = new System.Drawing.Size(317, 22);
            this.betterLabel.TabIndex = 3;
            this.betterLabel.Text = "A little better Skyrim: $79.99";
            // 
            // vanillaBox
            // 
            this.vanillaBox.Location = new System.Drawing.Point(560, 111);
            this.vanillaBox.Name = "vanillaBox";
            this.vanillaBox.Size = new System.Drawing.Size(28, 27);
            this.vanillaBox.TabIndex = 4;
            // 
            // sameBox
            // 
            this.sameBox.Location = new System.Drawing.Point(560, 217);
            this.sameBox.Name = "sameBox";
            this.sameBox.Size = new System.Drawing.Size(28, 27);
            this.sameBox.TabIndex = 5;
            // 
            // betterBox
            // 
            this.betterBox.Location = new System.Drawing.Point(560, 163);
            this.betterBox.Name = "betterBox";
            this.betterBox.Size = new System.Drawing.Size(28, 27);
            this.betterBox.TabIndex = 6;
            // 
            // totalButton
            // 
            this.totalButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.totalButton.Font = new System.Drawing.Font("Lithos Pro Regular", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalButton.ForeColor = System.Drawing.Color.Black;
            this.totalButton.Location = new System.Drawing.Point(291, 275);
            this.totalButton.Name = "totalButton";
            this.totalButton.Size = new System.Drawing.Size(152, 41);
            this.totalButton.TabIndex = 7;
            this.totalButton.Text = "Spend Money";
            this.totalButton.UseVisualStyleBackColor = false;
            this.totalButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // changeButton
            // 
            this.changeButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.changeButton.Font = new System.Drawing.Font("Lithos Pro Regular", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeButton.ForeColor = System.Drawing.Color.Black;
            this.changeButton.Location = new System.Drawing.Point(291, 558);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(152, 45);
            this.changeButton.TabIndex = 8;
            this.changeButton.Text = "Calculate Septims";
            this.changeButton.UseVisualStyleBackColor = false;
            this.changeButton.Visible = false;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // receiptButton
            // 
            this.receiptButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.receiptButton.Font = new System.Drawing.Font("Lithos Pro Regular", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptButton.ForeColor = System.Drawing.Color.Black;
            this.receiptButton.Location = new System.Drawing.Point(291, 683);
            this.receiptButton.Name = "receiptButton";
            this.receiptButton.Size = new System.Drawing.Size(146, 38);
            this.receiptButton.TabIndex = 9;
            this.receiptButton.Text = "Print Receipt";
            this.receiptButton.UseVisualStyleBackColor = false;
            this.receiptButton.Visible = false;
            // 
            // moneyLabel
            // 
            this.moneyLabel.Font = new System.Drawing.Font("Lithos Pro Regular", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneyLabel.Location = new System.Drawing.Point(116, 337);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(472, 178);
            this.moneyLabel.TabIndex = 10;
            // 
            // catchLabel
            // 
            this.catchLabel.Font = new System.Drawing.Font("Lithos Pro Regular", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catchLabel.Location = new System.Drawing.Point(59, 337);
            this.catchLabel.Name = "catchLabel";
            this.catchLabel.Size = new System.Drawing.Size(604, 151);
            this.catchLabel.TabIndex = 11;
            this.catchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.catchLabel.Visible = false;
            // 
            // changeBox
            // 
            this.changeBox.Location = new System.Drawing.Point(549, 524);
            this.changeBox.Name = "changeBox";
            this.changeBox.Size = new System.Drawing.Size(69, 27);
            this.changeBox.TabIndex = 12;
            this.changeBox.Visible = false;
            // 
            // cashLabel
            // 
            this.cashLabel.Font = new System.Drawing.Font("Lithos Pro Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashLabel.Location = new System.Drawing.Point(115, 527);
            this.cashLabel.Name = "cashLabel";
            this.cashLabel.Size = new System.Drawing.Size(428, 19);
            this.cashLabel.TabIndex = 13;
            this.cashLabel.Text = "Cash                                                           $";
            this.cashLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cashLabel.Visible = false;
            // 
            // changeLabel
            // 
            this.changeLabel.Location = new System.Drawing.Point(115, 616);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(473, 57);
            this.changeLabel.TabIndex = 14;
            this.changeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cashRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(715, 733);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.cashLabel);
            this.Controls.Add(this.changeBox);
            this.Controls.Add(this.catchLabel);
            this.Controls.Add(this.moneyLabel);
            this.Controls.Add(this.receiptButton);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.totalButton);
            this.Controls.Add(this.betterBox);
            this.Controls.Add(this.sameBox);
            this.Controls.Add(this.vanillaBox);
            this.Controls.Add(this.betterLabel);
            this.Controls.Add(this.sameLabel);
            this.Controls.Add(this.vanillaLabel);
            this.Controls.Add(this.titleLabel);
            this.Font = new System.Drawing.Font("Lithos Pro Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "cashRegister";
            this.Text = "Todd\'s Skyrim Market";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label vanillaLabel;
        private System.Windows.Forms.Label sameLabel;
        private System.Windows.Forms.Label betterLabel;
        private System.Windows.Forms.TextBox vanillaBox;
        private System.Windows.Forms.TextBox sameBox;
        private System.Windows.Forms.TextBox betterBox;
        private System.Windows.Forms.Button totalButton;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button receiptButton;
        private System.Windows.Forms.Label moneyLabel;
        private System.Windows.Forms.Label catchLabel;
        private System.Windows.Forms.TextBox changeBox;
        private System.Windows.Forms.Label cashLabel;
        private System.Windows.Forms.Label changeLabel;
    }
}

