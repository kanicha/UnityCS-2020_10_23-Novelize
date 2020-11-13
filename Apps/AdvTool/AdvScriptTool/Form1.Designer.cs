namespace AdvScriptTool
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ファイルの保存SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ファイルの読み込みOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.終了XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.listView2 = new System.Windows.Forms.ListView();
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.MessageAgreeButton = new System.Windows.Forms.Button();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SelectMessageTextBox1 = new System.Windows.Forms.TextBox();
            this.SelectMessageTextBox2 = new System.Windows.Forms.TextBox();
            this.SelectMessageTextBox3 = new System.Windows.Forms.TextBox();
            this.SelectMessageTextBox4 = new System.Windows.Forms.TextBox();
            this.SelectMessageTextBox5 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SelectJmupTextBox5 = new System.Windows.Forms.TextBox();
            this.SelectJmupTextBox4 = new System.Windows.Forms.TextBox();
            this.SelectJmupTextBox3 = new System.Windows.Forms.TextBox();
            this.SelectJmupTextBox2 = new System.Windows.Forms.TextBox();
            this.SelectJmupTextBox1 = new System.Windows.Forms.TextBox();
            this.SelectNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectAgreeButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.Filter = "テキストファイル|*.txt";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "txt";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "テキストファイル|*.txt";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルFToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1057, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ファイルFToolStripMenuItem
            // 
            this.ファイルFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルの保存SToolStripMenuItem,
            this.ファイルの読み込みOToolStripMenuItem,
            this.toolStripMenuItem1,
            this.終了XToolStripMenuItem});
            this.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem";
            this.ファイルFToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.ファイルFToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // ファイルの保存SToolStripMenuItem
            // 
            this.ファイルの保存SToolStripMenuItem.Name = "ファイルの保存SToolStripMenuItem";
            this.ファイルの保存SToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.ファイルの保存SToolStripMenuItem.Text = "ファイルの保存(&S)";
            this.ファイルの保存SToolStripMenuItem.Click += new System.EventHandler(this.button3_Click);
            // 
            // ファイルの読み込みOToolStripMenuItem
            // 
            this.ファイルの読み込みOToolStripMenuItem.Name = "ファイルの読み込みOToolStripMenuItem";
            this.ファイルの読み込みOToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.ファイルの読み込みOToolStripMenuItem.Text = "ファイルの読み込み(&O)";
            this.ファイルの読み込みOToolStripMenuItem.Click += new System.EventHandler(this.button4_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(178, 6);
            // 
            // 終了XToolStripMenuItem
            // 
            this.終了XToolStripMenuItem.Name = "終了XToolStripMenuItem";
            this.終了XToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.終了XToolStripMenuItem.Text = "終了(&X)";
            this.終了XToolStripMenuItem.Click += new System.EventHandler(this.終了XToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(479, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(569, 628);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.MessageAgreeButton);
            this.tabPage1.Controls.Add(this.MessageTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(549, 602);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "メッセージ入力";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.AllowDrop = true;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(12, 27);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(461, 628);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox1_DragDrop);
            this.listBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox1_DragEnter);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(549, 602);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "背景";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(241, 82);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(26, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "ファイル名";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(273, 84);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 19);
            this.textBox3.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 245);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.pictureBox2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(549, 602);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "キャラクター";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(32, 54);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(153, 209);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.listView1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(549, 602);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "BGM";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(37, 33);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(160, 242);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.listView2);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(549, 602);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "SE";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // listView2
            // 
            this.listView2.Location = new System.Drawing.Point(20, 32);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(187, 236);
            this.listView2.TabIndex = 0;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Location = new System.Drawing.Point(6, 6);
            this.MessageTextBox.Multiline = true;
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(537, 561);
            this.MessageTextBox.TabIndex = 0;
            // 
            // MessageAgreeButton
            // 
            this.MessageAgreeButton.Location = new System.Drawing.Point(468, 573);
            this.MessageAgreeButton.Name = "MessageAgreeButton";
            this.MessageAgreeButton.Size = new System.Drawing.Size(75, 23);
            this.MessageAgreeButton.TabIndex = 1;
            this.MessageAgreeButton.Text = "登録";
            this.MessageAgreeButton.UseVisualStyleBackColor = true;
            this.MessageAgreeButton.Click += new System.EventHandler(this.MessageAgreeButton_Click);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.SelectAgreeButton);
            this.tabPage6.Controls.Add(this.label1);
            this.tabPage6.Controls.Add(this.SelectNumericUpDown);
            this.tabPage6.Controls.Add(this.groupBox2);
            this.tabPage6.Controls.Add(this.groupBox1);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(561, 602);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "選択処理";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SelectMessageTextBox5);
            this.groupBox1.Controls.Add(this.SelectMessageTextBox4);
            this.groupBox1.Controls.Add(this.SelectMessageTextBox3);
            this.groupBox1.Controls.Add(this.SelectMessageTextBox2);
            this.groupBox1.Controls.Add(this.SelectMessageTextBox1);
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(532, 235);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "選択メッセージ";
            // 
            // SelectMessageTextBox1
            // 
            this.SelectMessageTextBox1.Location = new System.Drawing.Point(15, 30);
            this.SelectMessageTextBox1.Name = "SelectMessageTextBox1";
            this.SelectMessageTextBox1.Size = new System.Drawing.Size(502, 19);
            this.SelectMessageTextBox1.TabIndex = 0;
            // 
            // SelectMessageTextBox2
            // 
            this.SelectMessageTextBox2.Location = new System.Drawing.Point(15, 71);
            this.SelectMessageTextBox2.Name = "SelectMessageTextBox2";
            this.SelectMessageTextBox2.Size = new System.Drawing.Size(502, 19);
            this.SelectMessageTextBox2.TabIndex = 1;
            // 
            // SelectMessageTextBox3
            // 
            this.SelectMessageTextBox3.Location = new System.Drawing.Point(15, 112);
            this.SelectMessageTextBox3.Name = "SelectMessageTextBox3";
            this.SelectMessageTextBox3.Size = new System.Drawing.Size(502, 19);
            this.SelectMessageTextBox3.TabIndex = 2;
            // 
            // SelectMessageTextBox4
            // 
            this.SelectMessageTextBox4.Location = new System.Drawing.Point(15, 153);
            this.SelectMessageTextBox4.Name = "SelectMessageTextBox4";
            this.SelectMessageTextBox4.Size = new System.Drawing.Size(502, 19);
            this.SelectMessageTextBox4.TabIndex = 3;
            // 
            // SelectMessageTextBox5
            // 
            this.SelectMessageTextBox5.Location = new System.Drawing.Point(15, 194);
            this.SelectMessageTextBox5.Name = "SelectMessageTextBox5";
            this.SelectMessageTextBox5.Size = new System.Drawing.Size(502, 19);
            this.SelectMessageTextBox5.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SelectJmupTextBox5);
            this.groupBox2.Controls.Add(this.SelectJmupTextBox4);
            this.groupBox2.Controls.Add(this.SelectJmupTextBox3);
            this.groupBox2.Controls.Add(this.SelectJmupTextBox2);
            this.groupBox2.Controls.Add(this.SelectJmupTextBox1);
            this.groupBox2.Location = new System.Drawing.Point(14, 289);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(532, 235);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "選択のとび先";
            // 
            // SelectJmupTextBox5
            // 
            this.SelectJmupTextBox5.Location = new System.Drawing.Point(15, 194);
            this.SelectJmupTextBox5.Name = "SelectJmupTextBox5";
            this.SelectJmupTextBox5.Size = new System.Drawing.Size(502, 19);
            this.SelectJmupTextBox5.TabIndex = 4;
            // 
            // SelectJmupTextBox4
            // 
            this.SelectJmupTextBox4.Location = new System.Drawing.Point(15, 153);
            this.SelectJmupTextBox4.Name = "SelectJmupTextBox4";
            this.SelectJmupTextBox4.Size = new System.Drawing.Size(502, 19);
            this.SelectJmupTextBox4.TabIndex = 3;
            // 
            // SelectJmupTextBox3
            // 
            this.SelectJmupTextBox3.Location = new System.Drawing.Point(15, 112);
            this.SelectJmupTextBox3.Name = "SelectJmupTextBox3";
            this.SelectJmupTextBox3.Size = new System.Drawing.Size(502, 19);
            this.SelectJmupTextBox3.TabIndex = 2;
            // 
            // SelectJmupTextBox2
            // 
            this.SelectJmupTextBox2.Location = new System.Drawing.Point(15, 71);
            this.SelectJmupTextBox2.Name = "SelectJmupTextBox2";
            this.SelectJmupTextBox2.Size = new System.Drawing.Size(502, 19);
            this.SelectJmupTextBox2.TabIndex = 1;
            // 
            // SelectJmupTextBox1
            // 
            this.SelectJmupTextBox1.Location = new System.Drawing.Point(15, 30);
            this.SelectJmupTextBox1.Name = "SelectJmupTextBox1";
            this.SelectJmupTextBox1.Size = new System.Drawing.Size(502, 19);
            this.SelectJmupTextBox1.TabIndex = 0;
            // 
            // SelectNumericUpDown
            // 
            this.SelectNumericUpDown.Location = new System.Drawing.Point(150, 259);
            this.SelectNumericUpDown.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.SelectNumericUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.SelectNumericUpDown.Name = "SelectNumericUpDown";
            this.SelectNumericUpDown.Size = new System.Drawing.Size(120, 19);
            this.SelectNumericUpDown.TabIndex = 6;
            this.SelectNumericUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.SelectNumericUpDown.ValueChanged += new System.EventHandler(this.SelectNumericUpDown_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "選択行数";
            // 
            // SelectAgreeButton
            // 
            this.SelectAgreeButton.Location = new System.Drawing.Point(469, 563);
            this.SelectAgreeButton.Name = "SelectAgreeButton";
            this.SelectAgreeButton.Size = new System.Drawing.Size(77, 25);
            this.SelectAgreeButton.TabIndex = 8;
            this.SelectAgreeButton.Text = "登録";
            this.SelectAgreeButton.UseVisualStyleBackColor = true;
            this.SelectAgreeButton.Click += new System.EventHandler(this.SelectAgreeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 673);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "アドベンチャースクリプト生成ツール";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ファイルFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ファイルの保存SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ファイルの読み込みOToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 終了XToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button MessageAgreeButton;
        private System.Windows.Forms.TextBox MessageTextBox;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown SelectNumericUpDown;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox SelectJmupTextBox5;
        private System.Windows.Forms.TextBox SelectJmupTextBox4;
        private System.Windows.Forms.TextBox SelectJmupTextBox3;
        private System.Windows.Forms.TextBox SelectJmupTextBox2;
        private System.Windows.Forms.TextBox SelectJmupTextBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox SelectMessageTextBox5;
        private System.Windows.Forms.TextBox SelectMessageTextBox4;
        private System.Windows.Forms.TextBox SelectMessageTextBox3;
        private System.Windows.Forms.TextBox SelectMessageTextBox2;
        private System.Windows.Forms.TextBox SelectMessageTextBox1;
        private System.Windows.Forms.Button SelectAgreeButton;
    }
}

