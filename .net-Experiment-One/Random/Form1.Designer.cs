
namespace RandomNum
{
    partial class RandomForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.textBoxM = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labN = new System.Windows.Forms.Label();
            this.labM = new System.Windows.Forms.Label();
            this.btnRandom = new System.Windows.Forms.Button();
            this.textBoxOut = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(12, 35);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(100, 27);
            this.textBoxN.TabIndex = 0;
            // 
            // textBoxM
            // 
            this.textBoxM.Location = new System.Drawing.Point(170, 35);
            this.textBoxM.Name = "textBoxM";
            this.textBoxM.Size = new System.Drawing.Size(100, 27);
            this.textBoxM.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(122, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(0, 0);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // labN
            // 
            this.labN.AutoSize = true;
            this.labN.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labN.Location = new System.Drawing.Point(44, -4);
            this.labN.Name = "labN";
            this.labN.Size = new System.Drawing.Size(32, 36);
            this.labN.TabIndex = 4;
            this.labN.Text = "n";
            // 
            // labM
            // 
            this.labM.AutoSize = true;
            this.labM.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labM.Location = new System.Drawing.Point(198, -4);
            this.labM.Name = "labM";
            this.labM.Size = new System.Drawing.Size(41, 36);
            this.labM.TabIndex = 6;
            this.labM.Text = "m";
            // 
            // btnRandom
            // 
            this.btnRandom.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRandom.Location = new System.Drawing.Point(29, 68);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(226, 43);
            this.btnRandom.TabIndex = 7;
            this.btnRandom.Text = "生成m个随机数";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // textBoxOut
            // 
            this.textBoxOut.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxOut.Location = new System.Drawing.Point(12, 117);
            this.textBoxOut.Multiline = true;
            this.textBoxOut.Name = "textBoxOut";
            this.textBoxOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOut.Size = new System.Drawing.Size(258, 124);
            this.textBoxOut.TabIndex = 8;
            // 
            // RandomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.textBoxOut);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.labM);
            this.Controls.Add(this.labN);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxM);
            this.Controls.Add(this.textBoxN);
            this.Name = "RandomForm";
            this.Text = "Random";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.TextBox textBoxM;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labN;
        private System.Windows.Forms.Label labM;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.TextBox textBoxOut;
    }
}

