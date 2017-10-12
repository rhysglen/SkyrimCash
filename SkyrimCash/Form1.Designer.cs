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
            this.catch2Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Lithos Pro Regular", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(55, -10);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(614, 81);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Todd\'s Skyrim Market";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titleLabel.Visible = false;
            // 
            // vanillaLabel
            // 
            this.vanillaLabel.AutoSize = true;
            this.vanillaLabel.Font = new System.Drawing.Font("Lithos Pro Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vanillaLabel.Location = new System.Drawing.Point(112, 83);
            this.vanillaLabel.Name = "vanillaLabel";
            this.vanillaLabel.Size = new System.Drawing.Size(247, 22);
            this.vanillaLabel.TabIndex = 1;
            this.vanillaLabel.Text = "Vanilla Skyrim: $29.99";
            this.vanillaLabel.Visible = false;
            // 
            // sameLabel
            // 
            this.sameLabel.AutoSize = true;
            this.sameLabel.Font = new System.Drawing.Font("Lithos Pro Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sameLabel.Location = new System.Drawing.Point(112, 198);
            this.sameLabel.Name = "sameLabel";
            this.sameLabel.Size = new System.Drawing.Size(271, 22);
            this.sameLabel.TabIndex = 2;
            this.sameLabel.Text = "The Same Skyrim $109.99";
            this.sameLabel.Visible = false;
            // 
            // betterLabel
            // 
            this.betterLabel.AutoSize = true;
            this.betterLabel.Font = new System.Drawing.Font("Lithos Pro Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betterLabel.Location = new System.Drawing.Point(112, 138);
            this.betterLabel.Name = "betterLabel";
            this.betterLabel.Size = new System.Drawing.Size(317, 22);
            this.betterLabel.TabIndex = 3;
            this.betterLabel.Text = "A little better Skyrim: $79.99";
            this.betterLabel.Visible = false;
            // 
            // vanillaBox
            // 
            this.vanillaBox.Location = new System.Drawing.Point(560, 83);
            this.vanillaBox.Name = "vanillaBox";
            this.vanillaBox.Size = new System.Drawing.Size(28, 27);
            this.vanillaBox.TabIndex = 4;
            this.vanillaBox.Visible = false;
            // 
            // sameBox
            // 
            this.sameBox.Location = new System.Drawing.Point(560, 198);
            this.sameBox.Name = "sameBox";
            this.sameBox.Size = new System.Drawing.Size(28, 27);
            this.sameBox.TabIndex = 5;
            this.sameBox.Visible = false;
            // 
            // betterBox
            // 
            this.betterBox.Location = new System.Drawing.Point(560, 138);
            this.betterBox.Name = "betterBox";
            this.betterBox.Size = new System.Drawing.Size(28, 27);
            this.betterBox.TabIndex = 6;
            this.betterBox.Visible = false;
            // 
            // totalButton
            // 
            this.totalButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.totalButton.Font = new System.Drawing.Font("Lithos Pro Regular", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalButton.ForeColor = System.Drawing.Color.Black;
            this.totalButton.Location = new System.Drawing.Point(291, 237);
            this.totalButton.Name = "totalButton";
            this.totalButton.Size = new System.Drawing.Size(152, 41);
            this.totalButton.TabIndex = 7;
            this.totalButton.Text = "Spend Money";
            this.totalButton.UseVisualStyleBackColor = false;
            this.totalButton.Visible = false;
            this.totalButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // changeButton
            // 
            this.changeButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.changeButton.Font = new System.Drawing.Font("Lithos Pro Regular", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeButton.ForeColor = System.Drawing.Color.Black;
            this.changeButton.Location = new System.Drawing.Point(291, 525);
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
            this.receiptButton.Location = new System.Drawing.Point(291, 633);
            this.receiptButton.Name = "receiptButton";
            this.receiptButton.Size = new System.Drawing.Size(152, 38);
            this.receiptButton.TabIndex = 9;
            this.receiptButton.Text = "Print Receipt";
            this.receiptButton.UseVisualStyleBackColor = false;
            this.receiptButton.Visible = false;
            this.receiptButton.Click += new System.EventHandler(this.receiptButton_Click);
            // 
            // moneyLabel
            // 
            this.moneyLabel.Font = new System.Drawing.Font("Lithos Pro Regular", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneyLabel.Location = new System.Drawing.Point(116, 295);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(472, 178);
            this.moneyLabel.TabIndex = 10;
            // 
            // catchLabel
            // 
            this.catchLabel.Font = new System.Drawing.Font("Lithos Pro Regular", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catchLabel.Location = new System.Drawing.Point(59, 295);
            this.catchLabel.Name = "catchLabel";
            this.catchLabel.Size = new System.Drawing.Size(610, 151);
            this.catchLabel.TabIndex = 11;
            this.catchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.catchLabel.Visible = false;
            // 
            // changeBox
            // 
            this.changeBox.Location = new System.Drawing.Point(549, 481);
            this.changeBox.Name = "changeBox";
            this.changeBox.Size = new System.Drawing.Size(69, 27);
            this.changeBox.TabIndex = 12;
            this.changeBox.Visible = false;
            // 
            // cashLabel
            // 
            this.cashLabel.Font = new System.Drawing.Font("Lithos Pro Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashLabel.Location = new System.Drawing.Point(115, 484);
            this.cashLabel.Name = "cashLabel";
            this.cashLabel.Size = new System.Drawing.Size(428, 19);
            this.cashLabel.TabIndex = 13;
            this.cashLabel.Text = "Cash                                                           $";
            this.cashLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cashLabel.Visible = false;
            // 
            // changeLabel
            // 
            this.changeLabel.Location = new System.Drawing.Point(115, 575);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(473, 57);
            this.changeLabel.TabIndex = 14;
            this.changeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // catch2Label
            // 
            this.catch2Label.Font = new System.Drawing.Font("Lithos Pro Regular", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catch2Label.Location = new System.Drawing.Point(115, 573);
            this.catch2Label.Name = "catch2Label";
            this.catch2Label.Size = new System.Drawing.Size(503, 57);
            this.catch2Label.TabIndex = 15;
            this.catch2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.catch2Label.Visible = false;
            // 
            // cashRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(715, 733);
            this.Controls.Add(this.catch2Label);
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
            this.Load += new System.EventHandler(this.cashRegister_Load);
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
        private System.Windows.Forms.Label catch2Label;
    }
}

