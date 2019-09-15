namespace CoffeeShop
{
    partial class Home
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
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.contactNoTextBox = new System.Windows.Forms.TextBox();
            this.contactNoLabel = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.orderComboBox = new System.Windows.Forms.ComboBox();
            this.coffeeShopgroupBox = new System.Windows.Forms.GroupBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.showInfoRichTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.saveButton2 = new System.Windows.Forms.Button();
            this.coffeeShopgroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameLabel.Location = new System.Drawing.Point(28, 38);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(117, 19);
            this.customerNameLabel.TabIndex = 0;
            this.customerNameLabel.Text = "Customer Name";
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameTextBox.Location = new System.Drawing.Point(220, 38);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(228, 29);
            this.customerNameTextBox.TabIndex = 1;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTextBox.Location = new System.Drawing.Point(220, 160);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(228, 79);
            this.addressTextBox.TabIndex = 3;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.Location = new System.Drawing.Point(28, 160);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(63, 19);
            this.addressLabel.TabIndex = 2;
            this.addressLabel.Text = "Address";
            // 
            // contactNoTextBox
            // 
            this.contactNoTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactNoTextBox.Location = new System.Drawing.Point(220, 107);
            this.contactNoTextBox.Name = "contactNoTextBox";
            this.contactNoTextBox.Size = new System.Drawing.Size(228, 29);
            this.contactNoTextBox.TabIndex = 5;
            // 
            // contactNoLabel
            // 
            this.contactNoLabel.AutoSize = true;
            this.contactNoLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactNoLabel.Location = new System.Drawing.Point(28, 107);
            this.contactNoLabel.Name = "contactNoLabel";
            this.contactNoLabel.Size = new System.Drawing.Size(84, 19);
            this.contactNoLabel.TabIndex = 4;
            this.contactNoLabel.Text = "Contact No";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityTextBox.Location = new System.Drawing.Point(220, 392);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(228, 29);
            this.quantityTextBox.TabIndex = 9;
            // 
            // orderComboBox
            // 
            this.orderComboBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderComboBox.FormattingEnabled = true;
            this.orderComboBox.Items.AddRange(new object[] {
            "Black-120",
            "Cold-100",
            "Hot-90",
            "Regular-80"});
            this.orderComboBox.Location = new System.Drawing.Point(220, 328);
            this.orderComboBox.Name = "orderComboBox";
            this.orderComboBox.Size = new System.Drawing.Size(228, 32);
            this.orderComboBox.TabIndex = 10;
            // 
            // coffeeShopgroupBox
            // 
            this.coffeeShopgroupBox.BackColor = System.Drawing.SystemColors.Info;
            this.coffeeShopgroupBox.Controls.Add(this.saveButton);
            this.coffeeShopgroupBox.Controls.Add(this.customerNameLabel);
            this.coffeeShopgroupBox.Controls.Add(this.contactNoLabel);
            this.coffeeShopgroupBox.Controls.Add(this.addressLabel);
            this.coffeeShopgroupBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coffeeShopgroupBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.coffeeShopgroupBox.Location = new System.Drawing.Point(22, 5);
            this.coffeeShopgroupBox.Name = "coffeeShopgroupBox";
            this.coffeeShopgroupBox.Size = new System.Drawing.Size(501, 254);
            this.coffeeShopgroupBox.TabIndex = 11;
            this.coffeeShopgroupBox.TabStop = false;
            this.coffeeShopgroupBox.Text = "Customer Informatiion";
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.Color.DarkGreen;
            this.saveButton.Location = new System.Drawing.Point(138, 410);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(173, 45);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            // 
            // showInfoRichTextBox
            // 
            this.showInfoRichTextBox.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showInfoRichTextBox.Location = new System.Drawing.Point(529, 13);
            this.showInfoRichTextBox.Name = "showInfoRichTextBox";
            this.showInfoRichTextBox.ReadOnly = true;
            this.showInfoRichTextBox.Size = new System.Drawing.Size(400, 473);
            this.showInfoRichTextBox.TabIndex = 12;
            this.showInfoRichTextBox.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.groupBox1.Location = new System.Drawing.Point(22, 266);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 199);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Informatiion";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkGreen;
            this.button1.Location = new System.Drawing.Point(138, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Quantity";
            // 
            // saveButton2
            // 
            this.saveButton2.BackColor = System.Drawing.Color.RosyBrown;
            this.saveButton2.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saveButton2.Location = new System.Drawing.Point(200, 484);
            this.saveButton2.Name = "saveButton2";
            this.saveButton2.Size = new System.Drawing.Size(99, 46);
            this.saveButton2.TabIndex = 14;
            this.saveButton2.Text = "Save";
            this.saveButton2.UseVisualStyleBackColor = false;
            this.saveButton2.Click += new System.EventHandler(this.saveButton2_Click_1);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(974, 541);
            this.Controls.Add(this.saveButton2);
            this.Controls.Add(this.showInfoRichTextBox);
            this.Controls.Add(this.orderComboBox);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.contactNoTextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.customerNameTextBox);
            this.Controls.Add(this.coffeeShopgroupBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.coffeeShopgroupBox.ResumeLayout(false);
            this.coffeeShopgroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox contactNoTextBox;
        private System.Windows.Forms.Label contactNoLabel;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.ComboBox orderComboBox;
        private System.Windows.Forms.GroupBox coffeeShopgroupBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.RichTextBox showInfoRichTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button saveButton2;
    }
}

