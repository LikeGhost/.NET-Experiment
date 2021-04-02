
namespace RPG
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.HolySpiritBox = new System.Windows.Forms.PictureBox();
            this.LoECBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.HPLeftUnder = new System.Windows.Forms.Label();
            this.HPRightUnder = new System.Windows.Forms.Label();
            this.HPRight = new System.Windows.Forms.Label();
            this.HPLeft = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.HolySpiritBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoECBox)).BeginInit();
            this.SuspendLayout();
            // 
            // HolySpiritBox
            // 
            this.HolySpiritBox.BackColor = System.Drawing.SystemColors.Control;
            this.HolySpiritBox.Image = ((System.Drawing.Image)(resources.GetObject("HolySpiritBox.Image")));
            this.HolySpiritBox.Location = new System.Drawing.Point(15, 301);
            this.HolySpiritBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HolySpiritBox.Name = "HolySpiritBox";
            this.HolySpiritBox.Size = new System.Drawing.Size(341, 320);
            this.HolySpiritBox.TabIndex = 0;
            this.HolySpiritBox.TabStop = false;
            // 
            // LoECBox
            // 
            this.LoECBox.Image = ((System.Drawing.Image)(resources.GetObject("LoECBox.Image")));
            this.LoECBox.InitialImage = null;
            this.LoECBox.Location = new System.Drawing.Point(1127, 301);
            this.LoECBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoECBox.Name = "LoECBox";
            this.LoECBox.Size = new System.Drawing.Size(341, 320);
            this.LoECBox.TabIndex = 1;
            this.LoECBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(135, 660);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "神灵救世光";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1253, 660);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 29);
            this.button2.TabIndex = 3;
            this.button2.Text = "混沌灭世决";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // HPLeftUnder
            // 
            this.HPLeftUnder.BackColor = System.Drawing.Color.Yellow;
            this.HPLeftUnder.Location = new System.Drawing.Point(12, 171);
            this.HPLeftUnder.Name = "HPLeftUnder";
            this.HPLeftUnder.Size = new System.Drawing.Size(256, 32);
            this.HPLeftUnder.TabIndex = 4;
            // 
            // HPRightUnder
            // 
            this.HPRightUnder.BackColor = System.Drawing.Color.Yellow;
            this.HPRightUnder.Location = new System.Drawing.Point(1212, 171);
            this.HPRightUnder.Name = "HPRightUnder";
            this.HPRightUnder.Size = new System.Drawing.Size(256, 32);
            this.HPRightUnder.TabIndex = 5;
            // 
            // HPRight
            // 
            this.HPRight.BackColor = System.Drawing.Color.Red;
            this.HPRight.Location = new System.Drawing.Point(1212, 171);
            this.HPRight.Name = "HPRight";
            this.HPRight.Size = new System.Drawing.Size(256, 32);
            this.HPRight.TabIndex = 6;
            // 
            // HPLeft
            // 
            this.HPLeft.BackColor = System.Drawing.Color.Red;
            this.HPLeft.Location = new System.Drawing.Point(12, 171);
            this.HPLeft.Name = "HPLeft";
            this.HPLeft.Size = new System.Drawing.Size(256, 32);
            this.HPLeft.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1483, 752);
            this.Controls.Add(this.HPLeft);
            this.Controls.Add(this.HPRight);
            this.Controls.Add(this.HPRightUnder);
            this.Controls.Add(this.HPLeftUnder);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LoECBox);
            this.Controls.Add(this.HolySpiritBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.HolySpiritBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoECBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox HolySpiritBox;
        private System.Windows.Forms.PictureBox LoECBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private HolySpirit holySpirit;
        private LoEC loEC;
        private System.Windows.Forms.Label HPLeftUnder;
        private System.Windows.Forms.Label HPRightUnder;
        private System.Windows.Forms.Label HPRight;
        private System.Windows.Forms.Label HPLeft;
    }
}

