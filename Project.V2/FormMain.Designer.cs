
namespace Project.V2
{
    partial class FormMain
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
            this.panelButton_DAA = new System.Windows.Forms.Panel();
            this.panelFill_DAA = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panelButton_DAA.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButton_DAA
            // 
            this.panelButton_DAA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(88)))), ((int)(((byte)(157)))));
            this.panelButton_DAA.Controls.Add(this.button1);
            this.panelButton_DAA.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButton_DAA.Location = new System.Drawing.Point(0, 360);
            this.panelButton_DAA.Name = "panelButton_DAA";
            this.panelButton_DAA.Size = new System.Drawing.Size(1020, 216);
            this.panelButton_DAA.TabIndex = 0;
            // 
            // panelFill_DAA
            // 
            this.panelFill_DAA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(235)))), ((int)(((byte)(253)))));
            this.panelFill_DAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill_DAA.Location = new System.Drawing.Point(0, 0);
            this.panelFill_DAA.Name = "panelFill_DAA";
            this.panelFill_DAA.Size = new System.Drawing.Size(1020, 360);
            this.panelFill_DAA.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Leelawadee", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(31, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(247, 72);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 576);
            this.Controls.Add(this.panelFill_DAA);
            this.Controls.Add(this.panelButton_DAA);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сеть книжных магазинов";
            this.panelButton_DAA.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButton_DAA;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelFill_DAA;
    }
}

