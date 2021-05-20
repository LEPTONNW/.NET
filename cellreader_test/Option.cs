using System;
using System.Windows.Forms;

namespace cellreader_test
{
    public partial class Option : Form
    {
        public Option()
        {
            InitializeComponent();
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
        private void Option_Load(object sender, EventArgs e)
        {
            today_t.Text = Form1.day.ToString();

            juya_t.Text = Form1.juya.ToString();
            juya2_t.Text = Form1.juya2.ToString();
            juya3_t.Text = Form1.juya3.ToString();

            Col_S.Text = Form1.A.ToString();
            Col_E.Text = Form1.A_1.ToString();

            Row_S.Text = Form1.AA.ToString();
            Row_E.Text = Form1.AA_1.ToString();

            Row2_S.Text = Form1.BB.ToString();
            Row2_E.Text = Form1.BB_1.ToString();

            Row3_S.Text = Form1.CC.ToString();
            Row3_E.Text = Form1.CC_1.ToString();
        }

        private void Exit_b_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Save_b_Click(object sender, EventArgs e)
        {
            Form1.day = Convert.ToInt32(today_t.Text);

            Form1.juya = Convert.ToInt32(juya_t.Text);
            Form1.juya2 = Convert.ToInt32(juya2_t.Text);
            Form1.juya3 = Convert.ToInt32(juya3_t.Text);

            Form1.A = Convert.ToInt32(Col_S.Text);
            Form1.A_1 = Convert.ToInt32(Col_E.Text);

            Form1.AA = Convert.ToInt32(Row_S.Text);
            Form1.AA_1 = Convert.ToInt32(Row_E.Text);

            Form1.BB = Convert.ToInt32(Row2_S.Text);
            Form1.BB_1 = Convert.ToInt32(Row2_E.Text);

            Form1.CC = Convert.ToInt32(Row3_S.Text);
            Form1.CC_1 = Convert.ToInt32(Row3_E.Text);

            this.Close();
        }

        private void Re_b_Click(object sender, EventArgs e)
        {
            today_t.Text = 3.ToString();

            juya_t.Text = 6.ToString();
            juya2_t.Text = 19.ToString();
            juya3_t.Text = 33.ToString();

            Col_S.Text = 3.ToString();
            Col_E.Text = 34.ToString();

            Row_S.Text = 7.ToString();
            Row_E.Text = 9.ToString();

            Row2_S.Text = 20.ToString();
            Row2_E.Text = 22.ToString();

            Row3_S.Text = 34.ToString();
            Row3_E.Text = 36.ToString();
        }

        private void today_t_KeyPress(object sender, KeyPressEventArgs e)
        {
            //숫자만 입력되도록 필터링
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }
        }

        private void juya_t_KeyPress(object sender, KeyPressEventArgs e)
        {
            //숫자만 입력되도록 필터링
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }
        }

        private void juya2_t_KeyPress(object sender, KeyPressEventArgs e)
        {
            //숫자만 입력되도록 필터링
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }
        }

        private void juya3_t_KeyPress(object sender, KeyPressEventArgs e)
        {
            //숫자만 입력되도록 필터링
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }
        }

        private void Col_S_KeyPress(object sender, KeyPressEventArgs e)
        {
            //숫자만 입력되도록 필터링
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }
        }

        private void Row_S_KeyPress(object sender, KeyPressEventArgs e)
        {
            //숫자만 입력되도록 필터링
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }
        }

        private void Row2_S_KeyPress(object sender, KeyPressEventArgs e)
        {
            //숫자만 입력되도록 필터링
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }
        }

        private void Row3_S_KeyPress(object sender, KeyPressEventArgs e)
        {
            //숫자만 입력되도록 필터링
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }
        }

        private void Col_E_TextChanged(object sender, EventArgs e)
        {

        }

        private void Col_E_KeyPress(object sender, KeyPressEventArgs e)
        {
            //숫자만 입력되도록 필터링
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }
        }

        private void Row_E_KeyPress(object sender, KeyPressEventArgs e)
        {
            //숫자만 입력되도록 필터링
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }
        }

        private void Row2_E_KeyPress(object sender, KeyPressEventArgs e)
        {
            //숫자만 입력되도록 필터링
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }
        }

        private void Row3_E_KeyPress(object sender, KeyPressEventArgs e)
        {
            //숫자만 입력되도록 필터링
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }
        }
    }
}
