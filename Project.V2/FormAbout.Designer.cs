
namespace Project.V2
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.groupBoxInfo_DAA = new System.Windows.Forms.GroupBox();
            this.buttonOk_DAA = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.groupBoxInfo_DAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxInfo_DAA
            // 
            this.groupBoxInfo_DAA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxInfo_DAA.Controls.Add(this.buttonOk_DAA);
            this.groupBoxInfo_DAA.Controls.Add(this.label1);
            this.groupBoxInfo_DAA.Controls.Add(this.pictureBox);
            this.groupBoxInfo_DAA.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.groupBoxInfo_DAA.Location = new System.Drawing.Point(13, 13);
            this.groupBoxInfo_DAA.Name = "groupBoxInfo_DAA";
            this.groupBoxInfo_DAA.Size = new System.Drawing.Size(806, 417);
            this.groupBoxInfo_DAA.TabIndex = 0;
            this.groupBoxInfo_DAA.TabStop = false;
            this.groupBoxInfo_DAA.Text = "Основная информация";
            // 
            // buttonOk_DAA
            // 
            this.buttonOk_DAA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(88)))), ((int)(((byte)(157)))));
            this.buttonOk_DAA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOk_DAA.ForeColor = System.Drawing.Color.White;
            this.buttonOk_DAA.Location = new System.Drawing.Point(557, 343);
            this.buttonOk_DAA.Name = "buttonOk_DAA";
            this.buttonOk_DAA.Size = new System.Drawing.Size(127, 36);
            this.buttonOk_DAA.TabIndex = 2;
            this.buttonOk_DAA.Text = "Ok";
            this.buttonOk_DAA.UseVisualStyleBackColor = false;
            this.buttonOk_DAA.Click += new System.EventHandler(this.buttonOk_DAA_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(271, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(504, 252);
            this.label1.TabIndex = 1;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(15, 33);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(223, 293);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(235)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(831, 442);
            this.Controls.Add(this.groupBoxInfo_DAA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О разработчике";
            this.groupBoxInfo_DAA.ResumeLayout(false);
            this.groupBoxInfo_DAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInfo_DAA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button buttonOk_DAA;
    }
}