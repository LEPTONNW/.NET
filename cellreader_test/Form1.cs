using System;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace cellreader_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.ShowInTaskbar = true;
            this.Visible = false;
            this.notifyIcon1.Visible = true;
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;
        }

        public static int day { get; set; }

        //갑, 을, 병 
        public static int juya { get; set; }
        public static int juya2 { get; set; }
        public static int juya3 { get; set; }

        //세로 열
        public static int A { get; set; }
        public static int A_1 { get; set; }


        //가로 행
        //7열부터 9열까지 갑
        public static int AA { get; set; }
        public static int AA_1 { get; set; }

        //20열부터 22열까지 을
        public static int BB { get; set; }
        public static int BB_1 { get; set; }

        //33열부터 35열까지 병
        public static int CC { get; set; }
        public static int CC_1 { get; set; }
        private void Form1_Load(object sender, EventArgs e)
        {
            Sheet_t.Text = "1";
            Exit_Power.Hide();
            trackBar1.Value = 100;

            day = 3; //요일

            juya = 6; //주,야 (갑)
            juya2 = 19; //주,야 (을)
            juya3 = 33; //주,야 (병)
            
            A = 3; //세로열 시작점
            A_1 = 34; //세로열 끝점
            
            AA = 7; //가로열 시작점 (갑)
            AA_1 = 9; //가로열 끝점 (갑)
            
            BB = 20; //가로열 시작점 (을)
            BB_1 = 22; //가로열 끝점(을)
            
            CC = 34; //가로열 시작점(병)
            CC_1 = 36; //가로열 끝점(병)
            
            Y_Text.Text = "TEST";
            Y_Text.Text = "현재날짜 : " + DateTime.Now.ToString("yyyy") + "년 " + DateTime.Now.ToString("MM") + "월 " + DateTime.Now.ToString("dd") + "일";
            TEST.Enabled = false;
            Read_b.Enabled = false;
            Option_b.Enabled = false;

            TEST.BackColor = Color.Gray;
            Read_b.BackColor = Color.Gray;
            Option_b.BackColor = Color.Gray;

            TEST.FlatAppearance.BorderColor = Color.Gray;
            Read_b.FlatAppearance.BorderColor = Color.Gray;
            Option_b.FlatAppearance.BorderColor = Color.Gray;
        }

        protected override void WndProc(ref Message m) //FormboardStyle = None 일 경우 마우스 제어 함수
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }

        private void Exit_b_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.WindowState = FormWindowState.Minimized;
            this.ShowIcon = true; //작업표시줄에서 제거.
            notifyIcon1.Visible = true; //트레이 아이콘을 표시한다.
            notifyIcon1.ShowBalloonTip(1000);
        }

        private void Path_b_Click(object sender, EventArgs e)
        {
            OpenFileDialog PA = new OpenFileDialog();
            PA.Filter = "엑셀 파일(*.xlsx)|*.xlsx|All Files(*.*)|*.*";
            PA.Title = "읽어올 휴무 파일을 선택해 주세요";

            if(PA.ShowDialog() == DialogResult.OK)
            {
                Path_text.Text = PA.FileName;
            }
            if(String.IsNullOrEmpty(Path_text.Text))
            {

            }
            else
            {
                Read_b.Enabled = true;
                Read_b.BackColor = Color.FromArgb(41, 157, 207);
                Read_b.FlatAppearance.BorderColor = Color.FromArgb(41, 157, 207);

                Option_b.Enabled = true;
                Option_b.BackColor = Color.FromArgb(41, 157, 207);
                Option_b.FlatAppearance.BorderColor = Color.FromArgb(41, 157, 207);
            }

        }
        public static int load_temp = 0;
        public static int load_temp_1 = 0;
        public static string PT = "";
        public static DataTable table = new DataTable();
        public static DataRow row = null;
        public static Excel.Application excelApp;
        public static Excel.Workbook workBook;
        public static Excel.Worksheet workSheet;
        public static Excel.Range range;
        public string string_temp = " ";
        private void Read_b_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Sheet_t.Text))
            {
                MessageBox.Show("시트순서 번호를 정해주세요" + Environment.NewLine + "ex)맨앞으로 할경우 1 을 입력");
            }
            else
            {
                dataGridView1.Columns.Clear();
                dataGridView1.Refresh();
                try
                {
                    excelApp = new Excel.Application();
                    workBook = excelApp.Workbooks.Open(Path_text.Text);
                    workSheet = workBook.Worksheets.get_Item(Convert.ToInt32(Sheet_t.Text)) as Excel.Worksheet; //1번 시트 불러옴
                    range = workSheet.UsedRange;


                    table.Columns.Add("비고", typeof(string));


                    if (A_1 - A < 31)
                    {
                        int temp = 31 - (A_1 - A);
                        for (int i = 1; i <= A_1 - A; i++)
                        {
                            table.Columns.Add(new DataColumn(i.ToString(), typeof(string)));
                        }

                        for (int i = 1; i <= temp; i++)
                        {
                            table.Columns.Add(new DataColumn(string_temp, typeof(string)));
                            string_temp = string_temp + string_temp;
                        }
                    }
                    else
                    {
                        for (int i = 1; i <= A_1 - A; i++)
                        {
                            table.Columns.Add(new DataColumn(i.ToString(), typeof(string)));
                        }
                    }




                    //ROW 추가 //요일 데이터 로드
                    row = table.NewRow();
                    row["비고"] = " ";
                    for (int i = 1; i <= A_1 - A; i++) //D열부터 AH열까지
                    {
                        row[i.ToString()] = range.Cells[day, i + A].value2.ToString(); //row[i = 1~ A_1(34) 까지] = range.Cells[3번행, 4번째 D열]
                    }
                    table.Rows.Add(row);
                    //ROW 추가 끝





                    //ROW 추가 //주. 야 데이터 로드
                    row = table.NewRow();
                    row["비고"] = "갑조";
                    for (int i = 1; i <= A_1 - A; i++)
                    {
                        if (String.IsNullOrEmpty(range.Cells[juya, i + A].value2))
                        {
                            row[i.ToString()] = " ";
                        }
                        else
                        {
                            row[i.ToString()] = range.Cells[juya, i + A].value2.ToString();
                        }
                    }
                    table.Rows.Add(row);
                    //ROW 끝

                    ////갑조 데이터 로드
                    load_temp = AA;
                    load_temp_1 = AA_1;
                    GAB_load();

                    //공백 생성
                    row = table.NewRow();
                    row["비고"] = " ";
                    table.Rows.Add(row);

                    load_temp = 0;
                    load_temp_1 = 0;
                    ////로드 끝


                    //ROW 추가 //주. 야 데이터 로드
                    row = table.NewRow();
                    row["비고"] = "을조";
                    for (int i = 1; i <= A_1 - A; i++)
                    {
                        if (String.IsNullOrEmpty(range.Cells[juya2, i + A].value2))
                        {
                            row[i.ToString()] = " ";
                        }
                        else
                        {
                            row[i.ToString()] = range.Cells[juya2, i + A].value2.ToString();
                        }
                    }
                    table.Rows.Add(row);
                    //ROW 끝
                    ////을조 데이터 로드
                    load_temp = BB;
                    load_temp_1 = BB_1;
                    GAB_load();

                    //공백 생성
                    row = table.NewRow();
                    row["비고"] = " ";
                    table.Rows.Add(row);

                    load_temp = 0;
                    load_temp_1 = 0;
                    ////로드 끝


                    //ROW 추가 //주. 야 데이터 로드
                    row = table.NewRow();
                    row["비고"] = "병조";
                    for (int i = 1; i <= A_1 - A; i++)
                    {
                        if (String.IsNullOrEmpty(range.Cells[juya3, i + A].value2))
                        {
                            row[i.ToString()] = " ";
                        }
                        else
                        {
                            row[i.ToString()] = range.Cells[juya3, i + A].value2.ToString();
                        }
                    }
                    table.Rows.Add(row);
                    //ROW 끝
                    ////병조 데이터 로드
                    load_temp = CC;
                    load_temp_1 = CC_1;
                    GAB_load();

                    //공백 생성
                    row = table.NewRow();
                    row["비고"] = " ";
                    table.Rows.Add(row);

                    load_temp = 0;
                    load_temp_1 = 0;
                    ////로드 끝

                    dataGridView1.DataSource = table;

                    Check(); //주말 색지정
                    Check2();

                    workBook.Close(true);
                    excelApp.Quit();

                    foreach (DataGridViewColumn item in dataGridView1.Columns) { item.SortMode = DataGridViewColumnSortMode.Programmatic; }
                }
                catch
                {
                    MessageBox.Show("Error! : Trouble shooting" + Environment.NewLine + "1.불러온 데이터 시트의 순서가 맞지 않을 수 있습니다." + Environment.NewLine + "2.불러온 엑셀 파일의 행 과 열이 맞지 않을 수 있습니다. 고급 옵션에서 변경 해 주세요" + Environment.NewLine + "3.엑셀 확장자가 아닌 파일을 불러왔을 수 있습니다.");
                }
                finally
                {
                    ReleaseObject(workSheet);
                    ReleaseObject(workBook);
                    ReleaseObject(excelApp);
                    TEST.Enabled = true;
                    TEST.BackColor = Color.FromArgb(41, 157, 207);
                    TEST.FlatAppearance.BorderColor = Color.FromArgb(41, 157, 207);

                    Option_b.Enabled = true;
                    Option_b.BackColor = Color.FromArgb(41, 157, 207);
                    Option_b.FlatAppearance.BorderColor = Color.FromArgb(41, 157, 207);


                    table = new DataTable();
                    row = null;
                }
            }
        }
        public void GAB_load()
        {

            if (load_temp > load_temp_1)
            {

            }
            else
            {
                //ROW 추가 //갑조 데이터 순차 로드 
                row = table.NewRow();
                row["비고"] = range.Cells[load_temp, A].value2.ToString();
                for (int i = 1; i <= A_1 - A; i++)
                {
                    if (String.IsNullOrEmpty(range.Cells[load_temp, i + A].value2))
                    {
                        row[i.ToString()] = " ";
                    }
                    else
                    {
                        row[i.ToString()] = range.Cells[load_temp, i + A].value2.ToString();
                    }
                }
                table.Rows.Add(row);

                load_temp++;
                GAB_load();
                //ROW 끝
                
            }
        }
        public static int temp = 0;
        public void Check()
        {
            try
            {
                foreach (DataGridViewRow R in dataGridView1.Rows)
                {
                    if (R.Cells[temp].Value.ToString() == "토" || R.Cells[temp].Value.ToString() == "일")
                    {
                        R.Cells[temp].Style.BackColor = Color.OrangeRed;
                    }
                }
            }
            catch
            {
                if (temp == A_1 - A)
                {
                    temp = 0;
                }
                else
                {
                    temp++;
                    Check();
                }

            }
        }

        public void Check2()
        {
            try
            {
                foreach (DataGridViewRow R in dataGridView1.Rows)
                {
                    if (R.Cells[temp].Value.ToString() == "갑조" || R.Cells[temp].Value.ToString() == "을조" || R.Cells[temp].Value.ToString() == "병조")
                    {
                        for (int i = temp; i < temp + 32; i++)
                        {
                            R.Cells[i].Style.BackColor = Color.Orange;
                            // MessageBox.Show(i.ToString());
                        }
                    }
                }
            }
            catch
            {

            }
            
        }

        public static void ReleaseObject(object obj)
        {
            try
            {
                if(obj != null)
                {
                    Marshal.ReleaseComObject(obj);
                    obj = null;
                }
            }

            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void 최소화ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.WindowState = FormWindowState.Minimized;
            this.ShowIcon = false; //작업표시줄에서 제거.
            notifyIcon1.Visible = true; //트레이 아이콘을 표시한다.
            notifyIcon1.ShowBalloonTip(1000);
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
            Application.Exit();
            this.Close();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Visible = true; // 폼의 표시
            if (this.WindowState == FormWindowState.Minimized)
                this.WindowState = FormWindowState.Normal; // 최소화를 멈춘다 
            this.Activate(); // 폼을 활성화 시킨다
        }

        private void Option_b_Click(object sender, EventArgs e)
        {
            Option MyForm = new Option();
            MyForm.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public static int min = 0;
        private void TEST_Click(object sender, EventArgs e)
        {
            if(min == 0)
            {
                TEST.Text = "작게보기 : ON";
                foreach (DataGridViewColumn item in dataGridView1.Columns) { item.SortMode = DataGridViewColumnSortMode.NotSortable; }


                min = 1;
            }
            else
            {
                TEST.Text = "작게보기 : OFF";
                foreach (DataGridViewColumn item in dataGridView1.Columns) { item.SortMode = DataGridViewColumnSortMode.Programmatic; }
                min = 0;
            }
            
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void Exit_Power_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
            Application.Exit();
            this.Close();
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            this.Opacity = trackBar1.Value;
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            this.Opacity = trackBar1.Value * 0.01;
        }

        private void Sheet_t_KeyPress(object sender, KeyPressEventArgs e)
        {
            //숫자만 입력되도록 필터링
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }
        }

        private void Color_Box_DoubleClick(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK) 
            {
                MessageBox.Show(colorDialog1.Color.ToString());
            }
            else 
            { 
                
            }
        }

        private void Color_Box_KeyPress(object sender, KeyPressEventArgs e)
        {
            //숫자만 입력되도록 필터링
            if (e.KeyChar == Convert.ToChar(Keys.Back))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }
        }
        public static int Col_A;
        public static int Col_R;
        public static int Col_G;
        public static int Col_B;
        private void Color_b_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                //MessageBox.Show(colorDialog1.Color.ToString());
                string color_temp = colorDialog1.Color.ToString();

                var p = color_temp.Split(new char[] { ',', ']' });
                Col_A = Convert.ToInt32(p[0].Substring(p[0].IndexOf('=') + 1));
                Col_R = Convert.ToInt32(p[1].Substring(p[1].IndexOf('=') + 1));
                Col_G = Convert.ToInt32(p[2].Substring(p[2].IndexOf('=') + 1));
                Col_B = Convert.ToInt32(p[3].Substring(p[3].IndexOf('=') + 1));
                Color_b.BackColor = Color.FromArgb(Col_A, Col_R, Col_G, Col_B);
            }
            else
            {

            }
        }

        private void Set_Color_Click(object sender, EventArgs e)
        {
            string a = dataGridView1.CurrentCell.Selected.ToString();

            MessageBox.Show(a);
        }
    }
}
