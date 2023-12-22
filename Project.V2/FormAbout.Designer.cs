
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.buttonOk_DAA = new System.Windows.Forms.Button();
            this.groupBoxInfo_DAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxInfo_DAA
            // 
            this.groupBoxInfo_DAA.Controls.Add(this.buttonOk_DAA);
            this.groupBoxInfo_DAA.Controls.Add(this.label1);
            this.groupBoxInfo_DAA.Controls.Add(this.pictureBox);
            this.groupBoxInfo_DAA.Location = new System.Drawing.Point(13, 13);
            this.groupBoxInfo_DAA.Name = "groupBoxInfo_DAA";
            this.groupBoxInfo_DAA.Size = new System.Drawing.Size(705, 395);
            this.groupBoxInfo_DAA.TabIndex = 0;
            this.groupBoxInfo_DAA.TabStop = false;
            this.groupBoxInfo_DAA.Text = "Основная информация";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 180);
            this.label1.TabIndex = 1;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(7, 26);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(223, 293);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // buttonOk_DAA
            // 
            this.buttonOk_DAA.Location = new System.Drawing.Point(571, 346);
            this.buttonOk_DAA.Name = "buttonOk_DAA";
            this.buttonOk_DAA.Size = new System.Drawing.Size(113, 33);
            this.buttonOk_DAA.TabIndex = 2;
            this.buttonOk_DAA.Text = "Ok";
            this.buttonOk_DAA.UseVisualStyleBackColor = true;
            this.buttonOk_DAA.Click += new System.EventHandler(this.buttonOk_DAA_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 420);
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