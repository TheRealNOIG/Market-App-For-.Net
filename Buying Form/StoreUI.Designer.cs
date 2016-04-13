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
            this.panel1 = new System.Windows.Forms.Panel();
            this.refreshButton = new System.Windows.Forms.Button();
            this.sendRequest = new System.Windows.Forms.Button();
            this.infoBox = new System.Windows.Forms.ListBox();
            this.infoWindow = new System.Windows.Forms.Label();
            this.itemListBox = new System.Windows.Forms.ListBox();
            this.StoreItemsLable = new System.Windows.Forms.Label();
            this.Header = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.refreshButton);
            this.panel1.Controls.Add(this.sendRequest);
            this.panel1.Controls.Add(this.infoBox);
            this.panel1.Controls.Add(this.infoWindow);
            this.panel1.Controls.Add(this.itemListBox);
            this.panel1.Controls.Add(this.StoreItemsLable);
            this.panel1.Controls.Add(this.Header);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(951, 474);
            this.panel1.TabIndex = 0;
            // 
            // refreshButton
            // 
            this.refreshButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshButton.Location = new System.Drawing.Point(136, 83);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 22);
            this.refreshButton.TabIndex = 13;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // sendRequest
            // 
            this.sendRequest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sendRequest.Location = new System.Drawing.Point(19, 389);
            this.sendRequest.Name = "sendRequest";
            this.sendRequest.Size = new System.Drawing.Size(919, 75);
            this.sendRequest.TabIndex = 12;
            this.sendRequest.Text = "Send Request";
            this.sendRequest.UseVisualStyleBackColor = true;
            // 
            // infoBox
            // 
            this.infoBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infoBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.infoBox.FormattingEnabled = true;
            this.infoBox.ItemHeight = 18;
            this.infoBox.Location = new System.Drawing.Point(553, 109);
            this.infoBox.Name = "infoBox";
            this.infoBox.Size = new System.Drawing.Size(385, 274);
            this.infoBox.TabIndex = 11;
            this.infoBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.infoBox_DrawItem);
            this.infoBox.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.infoBox_MeasureItem);
            // 
            // infoWindow
            // 
            this.infoWindow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infoWindow.AutoSize = true;
            this.infoWindow.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoWindow.Location = new System.Drawing.Point(549, 83);
            this.infoWindow.Name = "infoWindow";
            this.infoWindow.Size = new System.Drawing.Size(123, 22);
            this.infoWindow.TabIndex = 10;
            this.infoWindow.Text = "Info Window";
            // 
            // itemListBox
            // 
            this.itemListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemListBox.FormattingEnabled = true;
            this.itemListBox.ItemHeight = 18;
            this.itemListBox.Location = new System.Drawing.Point(19, 109);
            this.itemListBox.Name = "itemListBox";
            this.itemListBox.Size = new System.Drawing.Size(474, 274);
            this.itemListBox.TabIndex = 9;
            this.itemListBox.SelectedIndexChanged += new System.EventHandler(this.itemListBox_SelectedIndexChanged);
            // 
            // StoreItemsLable
            // 
            this.StoreItemsLable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StoreItemsLable.AutoSize = true;
            this.StoreItemsLable.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoreItemsLable.Location = new System.Drawing.Point(15, 83);
            this.StoreItemsLable.Name = "StoreItemsLable";
            this.StoreItemsLable.Size = new System.Drawing.Size(115, 22);
            this.StoreItemsLable.TabIndex = 8;
            this.StoreItemsLable.Text = "Store Items";
            // 
            // Header
            // 
            this.Header.AutoSize = true;
            this.Header.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.Location = new System.Drawing.Point(12, 11);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(392, 38);
            this.Header.TabIndex = 7;
            this.Header.Text = "Tyler Gregorcyk\'s Market";
            // 
            // ShopGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 474);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(750, 306);
            this.Name = "ShopGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shop";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button sendRequest;
        private System.Windows.Forms.ListBox infoBox;
        private System.Windows.Forms.Label infoWindow;
        private System.Windows.Forms.ListBox itemListBox;
        private System.Windows.Forms.Label StoreItemsLable;
        private System.Windows.Forms.Label Header;
    }
}

