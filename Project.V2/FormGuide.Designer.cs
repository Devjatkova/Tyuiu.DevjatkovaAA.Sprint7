
namespace Project.V2
{
    partial class FormGuide
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGuide));
            this.groupBoxGuide_DAA = new System.Windows.Forms.GroupBox();
            this.labelGuide_DAA = new System.Windows.Forms.Label();
            this.buttonGuideOk_DAA = new System.Windows.Forms.Button();
            this.groupBoxGuide_DAA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxGuide_DAA
            // 
            this.groupBoxGuide_DAA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxGuide_DAA.Controls.Add(this.labelGuide_DAA);
            this.groupBoxGuide_DAA.Controls.Add(this.buttonGuideOk_DAA);
            this.groupBoxGuide_DAA.Location = new System.Drawing.Point(12, 5);
            this.groupBoxGuide_DAA.Name = "groupBoxGuide_DAA";
            this.groupBoxGuide_DAA.Padding = new System.Windows.Forms.Padding(12);
            this.groupBoxGuide_DAA.Size = new System.Drawing.Size(782, 480);
            this.groupBoxGuide_DAA.TabIndex = 0;
            this.groupBoxGuide_DAA.TabStop = false;
            // 
            // labelGuide_DAA
            // 
            this.labelGuide_DAA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelGuide_DAA.AutoSize = true;
            this.labelGuide_DAA.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelGuide_DAA.Location = new System.Drawing.Point(13, 22);
            this.labelGuide_DAA.Name = "labelGuide_DAA";
            this.labelGuide_DAA.Size = new System.Drawing.Size(755, 196);
            this.labelGuide_DAA.TabIndex = 1;
            this.labelGuide_DAA.Text = resources.GetString("labelGuide_DAA.Text");
            // 
            // buttonGuideOk_DAA
            // 
            this.buttonGuideOk_DAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGuideOk_DAA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(88)))), ((int)(((byte)(157)))));
            this.buttonGuideOk_DAA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGuideOk_DAA.ForeColor = System.Drawing.Color.White;
            this.buttonGuideOk_DAA.Location = new System.Drawing.Point(644, 432);
            this.buttonGuideOk_DAA.Name = "buttonGuideOk_DAA";
            this.buttonGuideOk_DAA.Size = new System.Drawing.Size(123, 33);
            this.buttonGuideOk_DAA.TabIndex = 0;
            this.buttonGuideOk_DAA.Text = "Ok";
            this.buttonGuideOk_DAA.UseVisualStyleBackColor = false;
            this.buttonGuideOk_DAA.Click += new System.EventHandler(this.buttonGuideOk_DAA_Click);
            // 
            // FormGuide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(235)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(806, 497);
            this.Controls.Add(this.groupBoxGuide_DAA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGuide";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Краткое руководство пользователя";
            this.groupBoxGuide_DAA.ResumeLayout(false);
            this.groupBoxGuide_DAA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxGuide_DAA;
        private System.Windows.Forms.Label labelGuide_DAA;
        private System.Windows.Forms.Button buttonGuideOk_DAA;
    }
}