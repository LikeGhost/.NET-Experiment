
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
            this.HSBox = new System.Windows.Forms.PictureBox();
            this.LoECBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.UnderHPOne = new System.Windows.Forms.Label();
            this.UnderHPTwo = new System.Windows.Forms.Label();
            this.HPTwo = new System.Windows.Forms.Label();
            this.HPOne = new System.Windows.Forms.Label();
            this.HPThree = new System.Windows.Forms.Label();
            this.UnderHPtree = new System.Windows.Forms.Label();
            this.STRBox = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.DTIBox = new System.Windows.Forms.PictureBox();
            this.HPFour = new System.Windows.Forms.Label();
            this.UnderHPFour = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.HSBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoECBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.STRBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTIBox)).BeginInit();
            this.SuspendLayout();
            // 
            // HSBox
            // 
            this.HSBox.BackColor = System.Drawing.SystemColors.Control;
            this.HSBox.Image = ((System.Drawing.Image)(resources.GetObject("HSBox.Image")));
            this.HSBox.InitialImage = null;
            this.HSBox.Location = new System.Drawing.Point(11, 53);
            this.HSBox.Margin = new System.Windows.Forms.Padding(2);
            this.HSBox.Name = "HSBox";
            this.HSBox.Size = new System.Drawing.Size(256, 256);
            this.HSBox.TabIndex = 0;
            this.HSBox.TabStop = false;
            this.HSBox.Click += new System.EventHandler(this.HSBox_Click);
            // 
            // LoECBox
            // 
            this.LoECBox.BackColor = System.Drawing.SystemColors.Control;
            this.LoECBox.Image = ((System.Drawing.Image)(resources.GetObject("LoECBox.Image")));
            this.LoECBox.InitialImage = null;
            this.LoECBox.Location = new System.Drawing.Point(917, 53);
            this.LoECBox.Margin = new System.Windows.Forms.Padding(2);
            this.LoECBox.Name = "LoECBox";
            this.LoECBox.Size = new System.Drawing.Size(256, 256);
            this.LoECBox.TabIndex = 1;
            this.LoECBox.TabStop = false;
            this.LoECBox.Click += new System.EventHandler(this.LoECBox_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(102, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "神灵救世光";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(995, 314);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "混沌灭世决";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // UnderHPOne
            // 
            this.UnderHPOne.BackColor = System.Drawing.Color.Yellow;
            this.UnderHPOne.Location = new System.Drawing.Point(11, 18);
            this.UnderHPOne.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UnderHPOne.Name = "UnderHPOne";
            this.UnderHPOne.Size = new System.Drawing.Size(256, 32);
            this.UnderHPOne.TabIndex = 4;
            // 
            // UnderHPTwo
            // 
            this.UnderHPTwo.BackColor = System.Drawing.Color.Yellow;
            this.UnderHPTwo.Location = new System.Drawing.Point(917, 18);
            this.UnderHPTwo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UnderHPTwo.Name = "UnderHPTwo";
            this.UnderHPTwo.Size = new System.Drawing.Size(256, 32);
            this.UnderHPTwo.TabIndex = 5;
            // 
            // HPTwo
            // 
            this.HPTwo.BackColor = System.Drawing.Color.Red;
            this.HPTwo.Location = new System.Drawing.Point(917, 18);
            this.HPTwo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HPTwo.Name = "HPTwo";
            this.HPTwo.Size = new System.Drawing.Size(256, 32);
            this.HPTwo.TabIndex = 6;
            // 
            // HPOne
            // 
            this.HPOne.BackColor = System.Drawing.Color.Red;
            this.HPOne.Location = new System.Drawing.Point(11, 18);
            this.HPOne.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HPOne.Name = "HPOne";
            this.HPOne.Size = new System.Drawing.Size(256, 32);
            this.HPOne.TabIndex = 7;
            // 
            // HPThree
            // 
            this.HPThree.BackColor = System.Drawing.Color.Red;
            this.HPThree.Location = new System.Drawing.Point(11, 373);
            this.HPThree.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HPThree.Name = "HPThree";
            this.HPThree.Size = new System.Drawing.Size(256, 32);
            this.HPThree.TabIndex = 11;
            // 
            // UnderHPtree
            // 
            this.UnderHPtree.BackColor = System.Drawing.Color.Yellow;
            this.UnderHPtree.Location = new System.Drawing.Point(11, 373);
            this.UnderHPtree.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UnderHPtree.Name = "UnderHPtree";
            this.UnderHPtree.Size = new System.Drawing.Size(256, 32);
            this.UnderHPtree.TabIndex = 10;
            // 
            // STRBox
            // 
            this.STRBox.BackColor = System.Drawing.SystemColors.Control;
            this.STRBox.Image = ((System.Drawing.Image)(resources.GetObject("STRBox.Image")));
            this.STRBox.Location = new System.Drawing.Point(11, 408);
            this.STRBox.Margin = new System.Windows.Forms.Padding(2);
            this.STRBox.Name = "STRBox";
            this.STRBox.Size = new System.Drawing.Size(256, 256);
            this.STRBox.TabIndex = 8;
            this.STRBox.TabStop = false;
            this.STRBox.Click += new System.EventHandler(this.STRBox_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(102, 669);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 12;
            this.button4.Text = "圣灵雷霆斩";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(995, 669);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "暗阒夜狂雷";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // DTIBox
            // 
            this.DTIBox.BackColor = System.Drawing.SystemColors.Control;
            this.DTIBox.Image = ((System.Drawing.Image)(resources.GetObject("DTIBox.Image")));
            this.DTIBox.InitialImage = null;
            this.DTIBox.Location = new System.Drawing.Point(917, 408);
            this.DTIBox.Margin = new System.Windows.Forms.Padding(2);
            this.DTIBox.Name = "DTIBox";
            this.DTIBox.Size = new System.Drawing.Size(256, 256);
            this.DTIBox.TabIndex = 13;
            this.DTIBox.TabStop = false;
            this.DTIBox.Click += new System.EventHandler(this.DTIBox_Click);
            // 
            // HPFour
            // 
            this.HPFour.BackColor = System.Drawing.Color.Red;
            this.HPFour.Location = new System.Drawing.Point(917, 373);
            this.HPFour.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HPFour.Name = "HPFour";
            this.HPFour.Size = new System.Drawing.Size(256, 32);
            this.HPFour.TabIndex = 16;
            // 
            // UnderHPFour
            // 
            this.UnderHPFour.BackColor = System.Drawing.Color.Yellow;
            this.UnderHPFour.Location = new System.Drawing.Point(917, 373);
            this.UnderHPFour.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UnderHPFour.Name = "UnderHPFour";
            this.UnderHPFour.Size = new System.Drawing.Size(256, 32);
            this.UnderHPFour.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.HSBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.DTIBox);
            this.Controls.Add(this.HPFour);
            this.Controls.Add(this.UnderHPFour);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.HPThree);
            this.Controls.Add(this.UnderHPtree);
            this.Controls.Add(this.STRBox);
            this.Controls.Add(this.HPOne);
            this.Controls.Add(this.UnderHPOne);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LoECBox);
            this.Controls.Add(this.HPTwo);
            this.Controls.Add(this.UnderHPTwo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.HSBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoECBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.STRBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTIBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox HSBox;
        private System.Windows.Forms.PictureBox LoECBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private HolySpirit HS;
        private LordofEssentialChaos LoEC;
        private SaintTingRey STR;
        private DarkThunderlshulandi DTI;
        private Spirits Attacker;
        private System.Windows.Forms.Label UnderHPOne;
        private System.Windows.Forms.Label UnderHPTwo;
        private System.Windows.Forms.Label HPTwo;
        private System.Windows.Forms.Label HPOne;
        private System.Windows.Forms.Label HPThree;
        private System.Windows.Forms.Label UnderHPtree;
        private System.Windows.Forms.PictureBox STRBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox DTIBox;
        private System.Windows.Forms.Label HPFour;
        private System.Windows.Forms.Label UnderHPFour;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

