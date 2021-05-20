using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cellreader_test
{
    static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool createdNew;
            // mutex 객체 생성합니다. 아래와 같이 생성해두면 된다.
            Mutex mutex = new Mutex(true, "cellreader_test", out createdNew);
            if (createdNew)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
                mutex.ReleaseMutex();
            }
            else
            {
                MessageBox.Show("프로그램이 이미 실행되고 있습니다.");
                return;
            }
        }
    }
}
