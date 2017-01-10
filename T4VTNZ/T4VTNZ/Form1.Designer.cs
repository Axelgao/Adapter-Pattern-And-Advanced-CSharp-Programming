namespace T4VTNZ
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.lstInspection = new System.Windows.Forms.ListBox();
            this.lblSelect = new System.Windows.Forms.Label();
            this.btnServiceRequest = new System.Windows.Forms.Button();
            this.lblServiceDetails = new System.Windows.Forms.Label();
            this.lblDetails = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblRequested = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(319, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(90, 20);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "lblHeader";
            // 
            // lstInspection
            // 
            this.lstInspection.FormattingEnabled = true;
            this.lstInspection.Location = new System.Drawing.Point(323, 81);
            this.lstInspection.Name = "lstInspection";
            this.lstInspection.Size = new System.Drawing.Size(237, 108);
            this.lstInspection.TabIndex = 1;
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Location = new System.Drawing.Point(59, 71);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(47, 13);
            this.lblSelect.TabIndex = 2;
            this.lblSelect.Text = "lblSelect";
            // 
            // btnServiceRequest
            // 
            this.btnServiceRequest.Location = new System.Drawing.Point(62, 115);
            this.btnServiceRequest.Name = "btnServiceRequest";
            this.btnServiceRequest.Size = new System.Drawing.Size(154, 23);
            this.btnServiceRequest.TabIndex = 3;
            this.btnServiceRequest.Text = "Service Request";
            this.btnServiceRequest.UseVisualStyleBackColor = true;
            this.btnServiceRequest.Click += new System.EventHandler(this.btnServiceRequest_Click);
            // 
            // lblServiceDetails
            // 
            this.lblServiceDetails.AutoSize = true;
            this.lblServiceDetails.Location = new System.Drawing.Point(62, 200);
            this.lblServiceDetails.Name = "lblServiceDetails";
            this.lblServiceDetails.Size = new System.Drawing.Size(85, 13);
            this.lblServiceDetails.TabIndex = 4;
            this.lblServiceDetails.Text = "lblServiceDetails";
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Location = new System.Drawing.Point(62, 227);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(49, 13);
            this.lblDetails.TabIndex = 5;
            this.lblDetails.Text = "lblDetails";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(308, 249);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(65, 13);
            this.lblTotalPrice.TabIndex = 6;
            this.lblTotalPrice.Text = "lblTotalPrice";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(320, 283);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(41, 13);
            this.lblPrice.TabIndex = 7;
            this.lblPrice.Text = "lblPrice";
            // 
            // lblRequested
            // 
            this.lblRequested.AutoSize = true;
            this.lblRequested.Location = new System.Drawing.Point(568, 200);
            this.lblRequested.Name = "lblRequested";
            this.lblRequested.Size = new System.Drawing.Size(69, 13);
            this.lblRequested.TabIndex = 8;
            this.lblRequested.Text = "lblRequested";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(580, 227);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(45, 13);
            this.lblCount.TabIndex = 9;
            this.lblCount.Text = "lblCount";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 355);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblRequested);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.lblServiceDetails);
            this.Controls.Add(this.btnServiceRequest);
            this.Controls.Add(this.lblSelect);
            this.Controls.Add(this.lstInspection);
            this.Controls.Add(this.lblHeader);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.ListBox lstInspection;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.Button btnServiceRequest;
        private System.Windows.Forms.Label lblServiceDetails;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblRequested;
        private System.Windows.Forms.Label lblCount;
    }
}

