namespace BuildOverviews
{
    partial class MainForm
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
            this.tb_inputPath = new System.Windows.Forms.TextBox();
            this.tb_outputPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Build = new System.Windows.Forms.Button();
            this.tb_numofOverviews = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tif文件目录：";
            // 
            // tb_inputPath
            // 
            this.tb_inputPath.AllowDrop = true;
            this.tb_inputPath.Location = new System.Drawing.Point(112, 37);
            this.tb_inputPath.Name = "tb_inputPath";
            this.tb_inputPath.Size = new System.Drawing.Size(380, 20);
            this.tb_inputPath.TabIndex = 1;
            this.tb_inputPath.DragDrop += new System.Windows.Forms.DragEventHandler(this.tb_inputPath_DragDrop);
            this.tb_inputPath.DragEnter += new System.Windows.Forms.DragEventHandler(this.tb_inputPath_DragEnter);
            // 
            // tb_outputPath
            // 
            this.tb_outputPath.Location = new System.Drawing.Point(126, 212);
            this.tb_outputPath.Name = "tb_outputPath";
            this.tb_outputPath.Size = new System.Drawing.Size(380, 20);
            this.tb_outputPath.TabIndex = 3;
            this.tb_outputPath.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "输出目录：";
            this.label2.Visible = false;
            // 
            // btn_Build
            // 
            this.btn_Build.Location = new System.Drawing.Point(244, 114);
            this.btn_Build.Name = "btn_Build";
            this.btn_Build.Size = new System.Drawing.Size(75, 23);
            this.btn_Build.TabIndex = 4;
            this.btn_Build.Text = "Build";
            this.btn_Build.UseVisualStyleBackColor = true;
            this.btn_Build.Click += new System.EventHandler(this.btn_Build_Click);
            // 
            // tb_numofOverviews
            // 
            this.tb_numofOverviews.Location = new System.Drawing.Point(112, 83);
            this.tb_numofOverviews.Name = "tb_numofOverviews";
            this.tb_numofOverviews.Size = new System.Drawing.Size(64, 20);
            this.tb_numofOverviews.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "OV级别：";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 167);
            this.Controls.Add(this.tb_numofOverviews);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Build);
            this.Controls.Add(this.tb_outputPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_inputPath);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "BuildOverviews";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_inputPath;
        private System.Windows.Forms.TextBox tb_outputPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Build;
        private System.Windows.Forms.TextBox tb_numofOverviews;
        private System.Windows.Forms.Label label3;
    }
}

