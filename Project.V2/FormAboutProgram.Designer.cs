
namespace Project.V2
{
    partial class FormAboutProgram
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAboutProgram));
            this.groupBoxAboutProgram_DAA = new System.Windows.Forms.GroupBox();
            this.buttonAboutProgramOk_DAA = new System.Windows.Forms.Button();
            this.labelAboutProgram_DAA = new System.Windows.Forms.Label();
            this.groupBoxAboutProgram_DAA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAboutProgram_DAA
            // 
            this.groupBoxAboutProgram_DAA.Controls.Add(this.labelAboutProgram_DAA);
            this.groupBoxAboutProgram_DAA.Controls.Add(this.buttonAboutProgramOk_DAA);
            this.groupBoxAboutProgram_DAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxAboutProgram_DAA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxAboutProgram_DAA.Name = "groupBoxAboutProgram_DAA";
            this.groupBoxAboutProgram_DAA.Padding = new System.Windows.Forms.Padding(12);
            this.groupBoxAboutProgram_DAA.Size = new System.Drawing.Size(875, 507);
            this.groupBoxAboutProgram_DAA.TabIndex = 0;
            this.groupBoxAboutProgram_DAA.TabStop = false;
            this.groupBoxAboutProgram_DAA.Text = "Справочные данные по приложению";
            // 
            // buttonAboutProgramOk_DAA
            // 
            this.buttonAboutProgramOk_DAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAboutProgramOk_DAA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAboutProgramOk_DAA.Location = new System.Drawing.Point(723, 454);
            this.buttonAboutProgramOk_DAA.Name = "buttonAboutProgramOk_DAA";
            this.buttonAboutProgramOk_DAA.Size = new System.Drawing.Size(133, 38);
            this.buttonAboutProgramOk_DAA.TabIndex = 0;
            this.buttonAboutProgramOk_DAA.Text = "Ok";
            this.buttonAboutProgramOk_DAA.UseVisualStyleBackColor = true;
            this.buttonAboutProgramOk_DAA.Click += new System.EventHandler(this.buttonAboutProgramOk_DAA_Click);
            // 
            // labelAboutProgram_DAA
            // 
            this.labelAboutProgram_DAA.AutoSize = true;
            this.labelAboutProgram_DAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAboutProgram_DAA.Location = new System.Drawing.Point(12, 31);
            this.labelAboutProgram_DAA.Name = "labelAboutProgram_DAA";
            this.labelAboutProgram_DAA.Padding = new System.Windows.Forms.Padding(3);
            this.labelAboutProgram_DAA.Size = new System.Drawing.Size(854, 366);
            this.labelAboutProgram_DAA.TabIndex = 1;
            this.labelAboutProgram_DAA.Text = resources.GetString("labelAboutProgram_DAA.Text");
            // 
            // FormAboutProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 507);
            this.Controls.Add(this.groupBoxAboutProgram_DAA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAboutProgram";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            this.groupBoxAboutProgram_DAA.ResumeLayout(false);
            this.groupBoxAboutProgram_DAA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAboutProgram_DAA;
        private System.Windows.Forms.Button buttonAboutProgramOk_DAA;
        private System.Windows.Forms.Label labelAboutProgram_DAA;
    }
}