namespace WindowsFormsApp1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.textBoxDirPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDirClick = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnLoadDir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxDirPath
            // 
            this.textBoxDirPath.Location = new System.Drawing.Point(144, 25);
            this.textBoxDirPath.Name = "textBoxDirPath";
            this.textBoxDirPath.Size = new System.Drawing.Size(538, 26);
            this.textBoxDirPath.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Directory:";
            // 
            // btnDirClick
            // 
            this.btnDirClick.Location = new System.Drawing.Point(713, 23);
            this.btnDirClick.Name = "btnDirClick";
            this.btnDirClick.Size = new System.Drawing.Size(75, 31);
            this.btnDirClick.TabIndex = 2;
            this.btnDirClick.Text = ". . .";
            this.btnDirClick.UseVisualStyleBackColor = true;
            this.btnDirClick.Click += new System.EventHandler(this.BtnDirClick_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(17, 87);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(665, 250);
            this.treeView1.TabIndex = 3;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(17, 374);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(490, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // btnLoadDir
            // 
            this.btnLoadDir.Location = new System.Drawing.Point(537, 374);
            this.btnLoadDir.Name = "btnLoadDir";
            this.btnLoadDir.Size = new System.Drawing.Size(143, 34);
            this.btnLoadDir.TabIndex = 5;
            this.btnLoadDir.Text = "Load Directory";
            this.btnLoadDir.UseVisualStyleBackColor = true;
            this.btnLoadDir.Click += new System.EventHandler(this.BtnLoadDir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLoadDir);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.btnDirClick);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDirPath);
            this.Name = "Form1";
            this.Text = "File_Explorer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDirPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDirClick;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnLoadDir;
    }
}

