namespace cellreader_test
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Exit_b = new System.Windows.Forms.Button();
            this.Path_text = new System.Windows.Forms.TextBox();
            this.Path_b = new System.Windows.Forms.Button();
            this.Y_Text = new System.Windows.Forms.Label();
            this.Read_b = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.최소화ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.Option_b = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TEST = new System.Windows.Forms.Button();
            this.Exit_Power = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.sheet_l = new System.Windows.Forms.Label();
            this.Sheet_t = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.Set_Color = new System.Windows.Forms.Button();
            this.Color_b = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // Exit_b
            // 
            this.Exit_b.FlatAppearance.BorderSize = 0;
            this.Exit_b.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(157)))), ((int)(((byte)(207)))));
            this.Exit_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_b.Font = new System.Drawing.Font("한컴 바겐세일 B", 14.25F);
            this.Exit_b.ForeColor = System.Drawing.Color.White;
            this.Exit_b.Location = new System.Drawing.Point(966, -4);
            this.Exit_b.Name = "Exit_b";
            this.Exit_b.Size = new System.Drawing.Size(80, 45);
            this.Exit_b.TabIndex = 0;
            this.Exit_b.Text = "최소화";
            this.Exit_b.UseVisualStyleBackColor = true;
            this.Exit_b.Click += new System.EventHandler(this.Exit_b_Click);
            // 
            // Path_text
            // 
            this.Path_text.Enabled = false;
            this.Path_text.Font = new System.Drawing.Font("함초롬돋움", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Path_text.Location = new System.Drawing.Point(12, 457);
            this.Path_text.Name = "Path_text";
            this.Path_text.Size = new System.Drawing.Size(296, 23);
            this.Path_text.TabIndex = 1;
            // 
            // Path_b
            // 
            this.Path_b.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(157)))), ((int)(((byte)(207)))));
            this.Path_b.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(157)))), ((int)(((byte)(207)))));
            this.Path_b.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(87)))), ((int)(((byte)(141)))));
            this.Path_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Path_b.Font = new System.Drawing.Font("함초롬돋움", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Path_b.ForeColor = System.Drawing.Color.White;
            this.Path_b.Location = new System.Drawing.Point(315, 457);
            this.Path_b.Name = "Path_b";
            this.Path_b.Size = new System.Drawing.Size(122, 30);
            this.Path_b.TabIndex = 2;
            this.Path_b.Text = "엑셀파일 불러오기";
            this.Path_b.UseVisualStyleBackColor = false;
            this.Path_b.Click += new System.EventHandler(this.Path_b_Click);
            // 
            // Y_Text
            // 
            this.Y_Text.AutoSize = true;
            this.Y_Text.Font = new System.Drawing.Font("한컴 바겐세일 B", 14.25F);
            this.Y_Text.ForeColor = System.Drawing.Color.White;
            this.Y_Text.Location = new System.Drawing.Point(12, 6);
            this.Y_Text.Name = "Y_Text";
            this.Y_Text.Size = new System.Drawing.Size(245, 24);
            this.Y_Text.TabIndex = 3;
            this.Y_Text.Text = "현재날짜 : 0000년 00월 00일";
            // 
            // Read_b
            // 
            this.Read_b.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(157)))), ((int)(((byte)(207)))));
            this.Read_b.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(157)))), ((int)(((byte)(207)))));
            this.Read_b.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(87)))), ((int)(((byte)(141)))));
            this.Read_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Read_b.Font = new System.Drawing.Font("함초롬돋움", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Read_b.ForeColor = System.Drawing.Color.White;
            this.Read_b.Location = new System.Drawing.Point(435, 457);
            this.Read_b.Name = "Read_b";
            this.Read_b.Size = new System.Drawing.Size(91, 52);
            this.Read_b.TabIndex = 16;
            this.Read_b.Text = "파일읽기";
            this.Read_b.UseVisualStyleBackColor = false;
            this.Read_b.Click += new System.EventHandler(this.Read_b_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("함초롬돋움", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dateTimePicker1.Location = new System.Drawing.Point(79, 488);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(229, 23);
            this.dateTimePicker1.TabIndex = 48;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.최소화ToolStripMenuItem,
            this.종료ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(111, 48);
            // 
            // 최소화ToolStripMenuItem
            // 
            this.최소화ToolStripMenuItem.Name = "최소화ToolStripMenuItem";
            this.최소화ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.최소화ToolStripMenuItem.Text = "최소화";
            this.최소화ToolStripMenuItem.Click += new System.EventHandler(this.최소화ToolStripMenuItem_Click);
            // 
            // 종료ToolStripMenuItem
            // 
            this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
            this.종료ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.종료ToolStripMenuItem.Text = "종료";
            this.종료ToolStripMenuItem.Click += new System.EventHandler(this.종료ToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "트레이상태로 최소화되었습니다.";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "일정표자동화";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // Option_b
            // 
            this.Option_b.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(157)))), ((int)(((byte)(207)))));
            this.Option_b.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(157)))), ((int)(((byte)(207)))));
            this.Option_b.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(87)))), ((int)(((byte)(141)))));
            this.Option_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Option_b.Font = new System.Drawing.Font("함초롬돋움", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Option_b.ForeColor = System.Drawing.Color.White;
            this.Option_b.Location = new System.Drawing.Point(526, 457);
            this.Option_b.Name = "Option_b";
            this.Option_b.Size = new System.Drawing.Size(119, 30);
            this.Option_b.TabIndex = 111;
            this.Option_b.Text = "고급옵션";
            this.Option_b.UseVisualStyleBackColor = false;
            this.Option_b.Click += new System.EventHandler(this.Option_b_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1047, 402);
            this.dataGridView1.TabIndex = 112;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            // 
            // TEST
            // 
            this.TEST.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(157)))), ((int)(((byte)(207)))));
            this.TEST.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(157)))), ((int)(((byte)(207)))));
            this.TEST.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(87)))), ((int)(((byte)(141)))));
            this.TEST.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TEST.Font = new System.Drawing.Font("함초롬돋움", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TEST.ForeColor = System.Drawing.Color.White;
            this.TEST.Location = new System.Drawing.Point(526, 477);
            this.TEST.Name = "TEST";
            this.TEST.Size = new System.Drawing.Size(119, 32);
            this.TEST.TabIndex = 113;
            this.TEST.Text = "작게보기 : OFF";
            this.TEST.UseVisualStyleBackColor = false;
            this.TEST.Click += new System.EventHandler(this.TEST_Click);
            // 
            // Exit_Power
            // 
            this.Exit_Power.FlatAppearance.BorderSize = 0;
            this.Exit_Power.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(157)))), ((int)(((byte)(207)))));
            this.Exit_Power.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_Power.ForeColor = System.Drawing.Color.White;
            this.Exit_Power.Location = new System.Drawing.Point(288, 8);
            this.Exit_Power.Name = "Exit_Power";
            this.Exit_Power.Size = new System.Drawing.Size(36, 29);
            this.Exit_Power.TabIndex = 114;
            this.Exit_Power.Text = "X";
            this.Exit_Power.UseVisualStyleBackColor = true;
            this.Exit_Power.Click += new System.EventHandler(this.Exit_Power_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(756, 486);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Minimum = 20;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(284, 45);
            this.trackBar1.TabIndex = 115;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Value = 20;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("한컴 바겐세일 B", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(759, 459);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 24);
            this.label1.TabIndex = 116;
            this.label1.Text = "투명도";
            // 
            // sheet_l
            // 
            this.sheet_l.AutoSize = true;
            this.sheet_l.Font = new System.Drawing.Font("함초롬돋움", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sheet_l.ForeColor = System.Drawing.Color.White;
            this.sheet_l.Location = new System.Drawing.Point(321, 494);
            this.sheet_l.Name = "sheet_l";
            this.sheet_l.Size = new System.Drawing.Size(68, 16);
            this.sheet_l.TabIndex = 117;
            this.sheet_l.Text = "불러올시트";
            // 
            // Sheet_t
            // 
            this.Sheet_t.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Sheet_t.Location = new System.Drawing.Point(387, 493);
            this.Sheet_t.Name = "Sheet_t";
            this.Sheet_t.Size = new System.Drawing.Size(42, 21);
            this.Sheet_t.TabIndex = 118;
            this.Sheet_t.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Sheet_t_KeyPress);
            // 
            // Set_Color
            // 
            this.Set_Color.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(157)))), ((int)(((byte)(207)))));
            this.Set_Color.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(157)))), ((int)(((byte)(207)))));
            this.Set_Color.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(87)))), ((int)(((byte)(141)))));
            this.Set_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Set_Color.Font = new System.Drawing.Font("함초롬돋움", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Set_Color.ForeColor = System.Drawing.Color.White;
            this.Set_Color.Location = new System.Drawing.Point(651, 457);
            this.Set_Color.Name = "Set_Color";
            this.Set_Color.Size = new System.Drawing.Size(102, 30);
            this.Set_Color.TabIndex = 119;
            this.Set_Color.Text = "선택칸 색변경";
            this.Set_Color.UseVisualStyleBackColor = false;
            this.Set_Color.Click += new System.EventHandler(this.Set_Color_Click);
            // 
            // Color_b
            // 
            this.Color_b.BackColor = System.Drawing.Color.White;
            this.Color_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Color_b.ForeColor = System.Drawing.Color.White;
            this.Color_b.Location = new System.Drawing.Point(712, 493);
            this.Color_b.Name = "Color_b";
            this.Color_b.Size = new System.Drawing.Size(41, 21);
            this.Color_b.TabIndex = 121;
            this.Color_b.UseVisualStyleBackColor = false;
            this.Color_b.Click += new System.EventHandler(this.Color_b_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(109)))), ((int)(((byte)(160)))));
            this.ClientSize = new System.Drawing.Size(1046, 520);
            this.Controls.Add(this.Color_b);
            this.Controls.Add(this.Set_Color);
            this.Controls.Add(this.Sheet_t);
            this.Controls.Add(this.sheet_l);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.Exit_Power);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Option_b);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Read_b);
            this.Controls.Add(this.Y_Text);
            this.Controls.Add(this.Path_b);
            this.Controls.Add(this.Path_text);
            this.Controls.Add(this.Exit_b);
            this.Controls.Add(this.TEST);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "휴무표자동화";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DoubleClick += new System.EventHandler(this.Form1_DoubleClick);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exit_b;
        private System.Windows.Forms.TextBox Path_text;
        private System.Windows.Forms.Button Path_b;
        private System.Windows.Forms.Label Y_Text;
        private System.Windows.Forms.Button Read_b;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 최소화ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button Option_b;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button TEST;
        private System.Windows.Forms.Button Exit_Power;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label sheet_l;
        private System.Windows.Forms.TextBox Sheet_t;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button Set_Color;
        private System.Windows.Forms.Button Color_b;
    }
}

