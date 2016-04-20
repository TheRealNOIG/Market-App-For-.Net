namespace Buying_Form
{
    partial class VendorInfoUI
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
            this.nameTextLable = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.itemsSoldTextLabel = new System.Windows.Forms.Label();
            this.itemsSoldLabel = new System.Windows.Forms.Label();
            this.locationTextLabel = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.dateJoinedTextLabel = new System.Windows.Forms.Label();
            this.dateJoinedLabel = new System.Windows.Forms.Label();
            this.idTextLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameTextLable
            // 
            this.nameTextLable.AutoSize = true;
            this.nameTextLable.Location = new System.Drawing.Point(18, 12);
            this.nameTextLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameTextLable.Name = "nameTextLable";
            this.nameTextLable.Size = new System.Drawing.Size(54, 18);
            this.nameTextLable.TabIndex = 0;
            this.nameTextLable.Text = "Name:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(69, 12);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(77, 18);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Last, First";
            // 
            // itemsSoldTextLabel
            // 
            this.itemsSoldTextLabel.AutoSize = true;
            this.itemsSoldTextLabel.Location = new System.Drawing.Point(18, 30);
            this.itemsSoldTextLabel.Name = "itemsSoldTextLabel";
            this.itemsSoldTextLabel.Size = new System.Drawing.Size(164, 18);
            this.itemsSoldTextLabel.TabIndex = 2;
            this.itemsSoldTextLabel.Text = "Number Of Items Sold:";
            // 
            // itemsSoldLabel
            // 
            this.itemsSoldLabel.AutoSize = true;
            this.itemsSoldLabel.Location = new System.Drawing.Point(178, 30);
            this.itemsSoldLabel.Name = "itemsSoldLabel";
            this.itemsSoldLabel.Size = new System.Drawing.Size(17, 18);
            this.itemsSoldLabel.TabIndex = 3;
            this.itemsSoldLabel.Text = "0";
            // 
            // locationTextLabel
            // 
            this.locationTextLabel.AutoSize = true;
            this.locationTextLabel.Location = new System.Drawing.Point(18, 48);
            this.locationTextLabel.Name = "locationTextLabel";
            this.locationTextLabel.Size = new System.Drawing.Size(72, 18);
            this.locationTextLabel.TabIndex = 4;
            this.locationTextLabel.Text = "Location:";
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(87, 48);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(119, 18);
            this.locationLabel.TabIndex = 5;
            this.locationLabel.Text = "North Austin, TX";
            // 
            // dateJoinedTextLabel
            // 
            this.dateJoinedTextLabel.AutoSize = true;
            this.dateJoinedTextLabel.Location = new System.Drawing.Point(18, 66);
            this.dateJoinedTextLabel.Name = "dateJoinedTextLabel";
            this.dateJoinedTextLabel.Size = new System.Drawing.Size(97, 18);
            this.dateJoinedTextLabel.TabIndex = 6;
            this.dateJoinedTextLabel.Text = "Date Joined:";
            // 
            // dateJoinedLabel
            // 
            this.dateJoinedLabel.AutoSize = true;
            this.dateJoinedLabel.Location = new System.Drawing.Point(111, 66);
            this.dateJoinedLabel.Name = "dateJoinedLabel";
            this.dateJoinedLabel.Size = new System.Drawing.Size(49, 18);
            this.dateJoinedLabel.TabIndex = 7;
            this.dateJoinedLabel.Text = "Today";
            // 
            // idTextLabel
            // 
            this.idTextLabel.AutoSize = true;
            this.idTextLabel.Location = new System.Drawing.Point(18, 84);
            this.idTextLabel.Name = "idTextLabel";
            this.idTextLabel.Size = new System.Drawing.Size(89, 18);
            this.idTextLabel.TabIndex = 8;
            this.idTextLabel.Text = "Vendors ID:";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(104, 84);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(48, 18);
            this.idLabel.TabIndex = 9;
            this.idLabel.Text = "68.99";
            // 
            // VendorInfoUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 112);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.idTextLabel);
            this.Controls.Add(this.dateJoinedLabel);
            this.Controls.Add(this.dateJoinedTextLabel);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.locationTextLabel);
            this.Controls.Add(this.itemsSoldLabel);
            this.Controls.Add(this.itemsSoldTextLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameTextLable);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "VendorInfoUI";
            this.Text = "VendorInfoUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameTextLable;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label itemsSoldTextLabel;
        private System.Windows.Forms.Label itemsSoldLabel;
        private System.Windows.Forms.Label locationTextLabel;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Label dateJoinedTextLabel;
        private System.Windows.Forms.Label dateJoinedLabel;
        private System.Windows.Forms.Label idTextLabel;
        private System.Windows.Forms.Label idLabel;
    }
}