using System;
using System.IO;
using System.Windows.Forms;

namespace SmartDataLogger
{
    public partial class MainForm : Form
    {
        private string logFilePath = "data_log.csv";
        
        private ListBox listBoxLogs;
        private TextBox txtDataInput;
        private Button btnLogData;

        public MainForm()
        {
            InitializeLogger();
            InitializeControls();
        }

        private void InitializeLogger()
        {
            if (!File.Exists(logFilePath))
            {
                File.WriteAllText(logFilePath, "Timestamp, Data\n");
            }
        }

        private void LogData(string data)
        {
            string logEntry = $"{DateTime.Now}, {data}\n";
            File.AppendAllText(logFilePath, logEntry);
            listBoxLogs.Items.Add(logEntry);
        }

        private void btnLogData_Click(object sender, EventArgs e)
        {
            string inputData = txtDataInput.Text.Trim();
            if (!string.IsNullOrWhiteSpace(inputData))
            {
                LogData(inputData);
                txtDataInput.Clear();
            }
        }

        private void InitializeControls()
        {
            this.Text = "Smart Data Logger";
            this.Size = new System.Drawing.Size(450, 350);
            this.StartPosition = FormStartPosition.CenterScreen;

            listBoxLogs = new ListBox()
            {
                Location = new System.Drawing.Point(20, 100),
                Size = new System.Drawing.Size(400, 200)
            };
            Controls.Add(listBoxLogs);

            txtDataInput = new TextBox()
            {
                Location = new System.Drawing.Point(20, 20),
                Size = new System.Drawing.Size(200, 20)
            };
            Controls.Add(txtDataInput);

            btnLogData = new Button()
            {
                Location = new System.Drawing.Point(240, 20),
                Size = new System.Drawing.Size(75, 30),
                Text = "Log Data"
            };
            btnLogData.Click += btnLogData_Click;
            Controls.Add(btnLogData);
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
