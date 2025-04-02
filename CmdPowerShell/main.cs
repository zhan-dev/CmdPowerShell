using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CmdPowerShell
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private bool isEnterPressed = false;

        private void cmd_btn_Click(object sender, EventArgs e)
        {
            cmd_txt.Text = "ipconfig";
            ThroughPowerShellOrCmd("cmd", "/c", cmd_txt.Text);

            DataToArray();

            cmd_txt.Text = "";
            cmd_txt.Focus();
        }

        private void pwShell_btn_Click(object sender, EventArgs e)
        {
            pwShell_txt.Text = "get-appxpackage | ft name";
            ThroughPowerShellOrCmd("powershell", "/command", pwShell_txt.Text);

            DataToArray();

            pwShell_txt.Text = "";
            pwShell_txt.Focus();
        }

        int i = 0;
        string[] history = new string[0];
        void DataToArray()
        {
            result_txt.Text = "Result:";
            history_lbl.Text = "Request History:";

            //Resize the array to a bigger size(five elements larger).
            Array.Resize(ref history, history.Length + 1);
            history[i] = $"{cmd_txt.Text}{pwShell_txt.Text}";
            i++;

            ////удаление через реверс
            if (i >= 10)
            {
                Array.Reverse(history);
                Array.Resize(ref history, history.Length - 1);
                Array.Reverse(history);
                i--;
            }

            foreach (string print_history in history)
                history_lbl.Text += $"\n {print_history}";

            //удаление через конвертирование в лист
            //if (i >= 10)
            //{
            //    List<string> stringList = history.ToList();
            //    stringList.RemoveAt(0);
            //    history = stringList.ToArray();
            //    i--;
            //}
        }

        void ThroughPowerShellOrCmd(string environmentName, string environmentFormat, string environmentRequest)
        {
            Process process = Process.Start(new ProcessStartInfo
            {
                FileName = environmentName,
                Arguments = $"{environmentFormat} {environmentRequest}",
                UseShellExecute = false,
                RedirectStandardOutput = true, //под запись данных из cmd в поток (выбивает ошибку если не используешь)
                CreateNoWindow = true // скрытие окна под редирект
            });
            //WaitForExit();

            //последовательный вывод процесса работы вместо конечного результата
            process.BeginOutputReadLine();
            process.OutputDataReceived += (sender, e) => { result_txt.Text += e.Data + Environment.NewLine; }; // эквивалент \n
            //process.OutputDataReceived += (sender, e) => { result_lbl.Text += e.Data + Environment.NewLine; }; // эквивалент \n

            //result_lbl.Text += process.StandardOutput.ReadToEnd(); //просто вывод конечного результата
        }

        private void cmd_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter && !isEnterPressed)
            {
                e.SuppressKeyPress = true; //подавление звука клавиши нажатия
                cmd_btn_Click(cmd_btn, null);
                isEnterPressed = true;
            }
        }

        private void pwShell_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter && !isEnterPressed)
            {
                e.SuppressKeyPress = true; //подавление звука клавиши нажатия
                pwShell_btn_Click(pwShell_btn, null);
                isEnterPressed = true;
            }
        }

        private void cmd_txt_KeyUp(object sender, KeyEventArgs e)
        {
            isEnterPressed = false;
        }

        private void pwShell_txt_KeyUp(object sender, KeyEventArgs e)
        {
            isEnterPressed = false;
        }

        private void historyDownload_btn_Click(object sender, EventArgs e)
        {
            string path = "C:\\Users\\slice\\Desktop";

            //FileStream file = new FileStream();

        }
    }
}
