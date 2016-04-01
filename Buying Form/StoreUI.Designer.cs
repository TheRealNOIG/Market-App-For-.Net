namespace Buying_Form
{
    partial class ShopGUI
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
            this.Header = new System.Windows.Forms.Label();
            this.StoreItemsLable = new System.Windows.Forms.Label();
            this.itemListBox = new System.Windows.Forms.ListBox();
            this.infoBox = new System.Windows.Forms.ListBox();
            this.infoWindow = new System.Windows.Forms.Label();
            this.sendRequest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.AutoSize = true;
            this.Header.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.Location = new System.Drawing.Point(12, 9);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(392, 38);
            this.Header.TabIndex = 0;
            this.Header.Text = "Tyler Gregorcyk\'s Market";
            // 
            // StoreItemsLable
            // 
            this.StoreItemsLable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StoreItemsLable.AutoSize = true;
            this.StoreItemsLable.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoreItemsLable.Location = new System.Drawing.Point(15, 81);
            this.StoreItemsLable.Name = "StoreItemsLable";
            this.StoreItemsLable.Size = new System.Drawing.Size(115, 22);
            this.StoreItemsLable.TabIndex = 1;
            this.StoreItemsLable.Text = "Store Items";
            // 
            // itemListBox
            // 
            this.itemListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemListBox.FormattingEnabled = true;
            this.itemListBox.ItemHeight = 18;
            this.itemListBox.Location = new System.Drawing.Point(19, 107);
            this.itemListBox.Name = "itemListBox";
            this.itemListBox.Size = new System.Drawing.Size(474, 274);
            this.itemListBox.TabIndex = 2;
            // 
            // infoBox
            // 
            this.infoBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infoBox.FormattingEnabled = true;
            this.infoBox.ItemHeight = 18;
            this.infoBox.Location = new System.Drawing.Point(553, 107);
            this.infoBox.Name = "infoBox";
            this.infoBox.Size = new System.Drawing.Size(385, 274);
            this.infoBox.TabIndex = 4;
            // 
            // infoWindow
            // 
            this.infoWindow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infoWindow.AutoSize = true;
            this.infoWindow.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoWindow.Location = new System.Drawing.Point(549, 81);
            this.infoWindow.Name = "infoWindow";
            this.infoWindow.Size = new System.Drawing.Size(123, 22);
            this.infoWindow.TabIndex = 3;
            this.infoWindow.Text = "Info Window";
            // 
            // sendRequest
            // 
            this.sendRequest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sendRequest.Location = new System.Drawing.Point(19, 387);
            this.sendRequest.Name = "sendRequest";
            this.sendRequest.Size = new System.Drawing.Size(919, 75);
            this.sendRequest.TabIndex = 5;
            this.sendRequest.Text = "Send Request";
            this.sendRequest.UseVisualStyleBackColor = true;
            // 
            // ShopGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 474);
            this.Controls.Add(this.sendRequest);
            this.Controls.Add(this.infoBox);
            this.Controls.Add(this.infoWindow);
            this.Controls.Add(this.itemListBox);
            this.Controls.Add(this.StoreItemsLable);
            this.Controls.Add(this.Header);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(750, 306);
            this.Name = "ShopGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.Label StoreItemsLable;
        private System.Windows.Forms.ListBox itemListBox;
        private System.Windows.Forms.ListBox infoBox;
        private System.Windows.Forms.Label infoWindow;
        private System.Windows.Forms.Button sendRequest;
    }
}

