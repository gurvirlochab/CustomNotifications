namespace CustomNotifications.NotificationClasses
{
    partial class DialogFormDisplay
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
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.displayTitle = new System.Windows.Forms.Label();
            this.displayMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLeft
            // 
            this.btnLeft.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnLeft.FlatAppearance.BorderSize = 2;
            this.btnLeft.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLeft.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeft.Location = new System.Drawing.Point(116, 199);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(120, 33);
            this.btnLeft.TabIndex = 1;
            this.btnLeft.Text = "Yes";
            this.btnLeft.UseVisualStyleBackColor = false;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnRight.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnRight.FlatAppearance.BorderSize = 2;
            this.btnRight.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRight.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRight.Location = new System.Drawing.Point(245, 199);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(120, 33);
            this.btnRight.TabIndex = 2;
            this.btnRight.Text = "No";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // displayTitle
            // 
            this.displayTitle.Font = new System.Drawing.Font("Microsoft New Tai Lue", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayTitle.Location = new System.Drawing.Point(12, 9);
            this.displayTitle.Name = "displayTitle";
            this.displayTitle.Size = new System.Drawing.Size(441, 47);
            this.displayTitle.TabIndex = 0;
            this.displayTitle.Text = "Dialog Title";
            this.displayTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // displayMessage
            // 
            this.displayMessage.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayMessage.Location = new System.Drawing.Point(12, 56);
            this.displayMessage.Name = "displayMessage";
            this.displayMessage.Size = new System.Drawing.Size(441, 130);
            this.displayMessage.TabIndex = 0;
            this.displayMessage.Text = "Dialog Message";
            // 
            // DialogFormDisplay
            // 
            this.AcceptButton = this.btnLeft;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnRight;
            this.ClientSize = new System.Drawing.Size(465, 244);
            this.Controls.Add(this.displayMessage);
            this.Controls.Add(this.displayTitle);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DialogFormDisplay";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DialogFormDisplay";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Label displayTitle;
        private System.Windows.Forms.Label displayMessage;
    }
}