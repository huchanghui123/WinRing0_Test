namespace WinRing0_Test
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chip_name = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fan_ram = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10F);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "driver init ...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chip Name:";
            // 
            // chip_name
            // 
            this.chip_name.AutoSize = true;
            this.chip_name.Location = new System.Drawing.Point(82, 46);
            this.chip_name.Name = "chip_name";
            this.chip_name.Size = new System.Drawing.Size(41, 12);
            this.chip_name.TabIndex = 2;
            this.chip_name.Text = "unknow";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "FAN RPM:";
            // 
            // fan_ram
            // 
            this.fan_ram.AutoSize = true;
            this.fan_ram.Location = new System.Drawing.Point(84, 79);
            this.fan_ram.Name = "fan_ram";
            this.fan_ram.Size = new System.Drawing.Size(41, 12);
            this.fan_ram.TabIndex = 4;
            this.fan_ram.Text = "unknow";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 111);
            this.Controls.Add(this.fan_ram);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chip_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "WinRing0 TEST";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label chip_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label fan_ram;
    }
}

