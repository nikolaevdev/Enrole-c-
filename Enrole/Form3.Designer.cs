namespace Enrole
{
    partial class SearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            this.label1 = new System.Windows.Forms.Label();
            this.btnStr = new System.Windows.Forms.Button();
            this.tbStr = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exit_app = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10);
            this.label1.Size = new System.Drawing.Size(163, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Поиск по полям";
            // 
            // btnStr
            // 
            this.btnStr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStr.AutoSize = true;
            this.btnStr.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStr.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStr.BackgroundImage")));
            this.btnStr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnStr.FlatAppearance.BorderSize = 0;
            this.btnStr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStr.Location = new System.Drawing.Point(414, 53);
            this.btnStr.Name = "btnStr";
            this.btnStr.Padding = new System.Windows.Forms.Padding(10);
            this.btnStr.Size = new System.Drawing.Size(51, 40);
            this.btnStr.TabIndex = 1;
            this.btnStr.UseVisualStyleBackColor = false;
            this.btnStr.Click += new System.EventHandler(this.btnStr_Click);
            // 
            // tbStr
            // 
            this.tbStr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbStr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbStr.Font = new System.Drawing.Font("Microsoft Tai Le", 23F);
            this.tbStr.Location = new System.Drawing.Point(12, 53);
            this.tbStr.Name = "tbStr";
            this.tbStr.Size = new System.Drawing.Size(396, 39);
            this.tbStr.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.exit_app);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel1.Size = new System.Drawing.Size(477, 40);
            this.panel1.TabIndex = 6;
            // 
            // exit_app
            // 
            this.exit_app.AutoSize = true;
            this.exit_app.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.exit_app.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exit_app.Dock = System.Windows.Forms.DockStyle.Right;
            this.exit_app.FlatAppearance.BorderSize = 0;
            this.exit_app.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_app.Image = ((System.Drawing.Image)(resources.GetObject("exit_app.Image")));
            this.exit_app.Location = new System.Drawing.Point(437, 0);
            this.exit_app.Name = "exit_app";
            this.exit_app.Padding = new System.Windows.Forms.Padding(5);
            this.exit_app.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.exit_app.Size = new System.Drawing.Size(40, 40);
            this.exit_app.TabIndex = 4;
            this.exit_app.UseVisualStyleBackColor = false;
            this.exit_app.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 114);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbStr);
            this.Controls.Add(this.btnStr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchForm";
            this.Text = "Поиск";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStr;
        private System.Windows.Forms.TextBox tbStr;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exit_app;
    }
}