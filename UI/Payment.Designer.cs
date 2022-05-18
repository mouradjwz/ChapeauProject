namespace UI
{
    partial class Payment
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            ""}, -1, System.Drawing.SystemColors.InactiveBorder, System.Drawing.SystemColors.WindowFrame, null);
            this.lblTableID = new System.Windows.Forms.Label();
            this.listViewBill = new System.Windows.Forms.ListView();
            this.Item = new System.Windows.Forms.ColumnHeader();
            this.Quantity = new System.Windows.Forms.ColumnHeader();
            this.Price = new System.Windows.Forms.ColumnHeader();
            this.VAT = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // lblTableID
            // 
            this.lblTableID.AutoSize = true;
            this.lblTableID.BackColor = System.Drawing.SystemColors.Menu;
            this.lblTableID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTableID.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTableID.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblTableID.Location = new System.Drawing.Point(50, 47);
            this.lblTableID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTableID.Name = "lblTableID";
            this.lblTableID.Size = new System.Drawing.Size(49, 27);
            this.lblTableID.TabIndex = 0;
            this.lblTableID.Text = "T_ID";
            // 
            // listViewBill
            // 
            this.listViewBill.AllowDrop = true;
            this.listViewBill.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.listViewBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Item,
            this.Quantity,
            this.Price,
            this.VAT});
            this.listViewBill.HideSelection = false;
            this.listViewBill.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listViewBill.Location = new System.Drawing.Point(38, 91);
            this.listViewBill.Name = "listViewBill";
            this.listViewBill.Size = new System.Drawing.Size(366, 146);
            this.listViewBill.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewBill.TabIndex = 1;
            this.listViewBill.UseCompatibleStateImageBehavior = false;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(445, 570);
            this.ControlBox = false;
            this.Controls.Add(this.listViewBill);
            this.Controls.Add(this.lblTableID);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Payment";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Payment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTableID;
        private System.Windows.Forms.ListView listViewBill;
        private System.Windows.Forms.ColumnHeader Item;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader VAT;
    }
}