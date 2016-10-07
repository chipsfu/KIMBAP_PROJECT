using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Threading;
using System.IO;

namespace KimBap
{
    public partial class Option : Form
    {
        string strCnn = ConfigurationManager.ConnectionStrings["KIMBAP"].ConnectionString;

        public Option()
        {
            InitializeComponent();

            //strUID = uID;
            setPosition();
            registevent();
            setDataControl();
            dtp_Option.Format = DateTimePickerFormat.Custom;
            dtp_Option.CustomFormat = "hh:mm tt";
            dtp_Option.ShowUpDown = true;
        }

        private void setPosition()
        {
            //this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

            this.Location = new Point(0, 0);
            gbOptionMain.Left = (this.Width - gbOptionMain.Width) / 2;
            gbOptionMain.Top = 20;
        }

        private void registevent()
        {
            rdEnglish.CheckedChanged += new EventHandler(rdEnglish_CheckedChanged);
            rdKorea.CheckedChanged += new EventHandler(rdKorea_CheckedChanged);
            //btnOK.Click += new EventHandler(btnOK_Click);
            //btnClose.Click += new EventHandler(btnCloseClick);
        }

        private class cboSelect
        {
            public string Name { get; set; }
            public string Value { get; set; }
        }

        private void setDataControl()
        {
            BindingList<cboSelect> _cboGMT = new BindingList<cboSelect>();
            BindingList<cboSelect> _cboSite = new BindingList<cboSelect>();
            BindingList<cboSelect> _cboTimeReload = new BindingList<cboSelect>();
            BindingList<cboSelect> _comTimeOutPut = new BindingList<cboSelect>();

            //Set data Combobox Site
            _cboSite.Add(new cboSelect { Name = "www.oddsportal.com", Value = "oddsportal" });
            _cboSite.Add(new cboSelect { Name = "www.marathonbet.com", Value = "marathon" });
            cboSite.DataSource = _cboSite;
            cboSite.DisplayMember = "Name";
            cboSite.ValueMember = "Value";
            cboSite.SelectedIndex = 0;

            //Set data cbo GMT
            _cboGMT.Add(new cboSelect { Name = "GMT+7", Value = "7" });
            _cboGMT.Add(new cboSelect { Name = "GMT+8", Value = "8" });
            _cboGMT.Add(new cboSelect { Name = "GMT+9", Value = "9" });
            cboGMT.DataSource = _cboGMT;
            cboGMT.DisplayMember = "Name";
            cboGMT.ValueMember = "Value";
            cboGMT.SelectedIndex = 0;

            //Set data Time reload
            for (var i = 2; i <= 10; i++)
            {
                _cboTimeReload.Add(new cboSelect { Name = i.ToString() + " Mins", Value = i.ToString() });
            }
            cboTimeReload.DataSource = _cboTimeReload;
            cboTimeReload.DisplayMember = "Name";
            cboTimeReload.ValueMember = "Value";
            cboTimeReload.SelectedIndex = 0;
        }

        private void rdKorea_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rdEnglish_CheckedChanged(object sender, EventArgs e)
        {

        }

        string Lang;
        string Site;
        string GMT;
        string TimeOutPut;
        string TimeReload;
        string path = @"I:\SoureCode\NewAPP Oddsportal\KIMBAP_SC\KimBapProject\";
        System.Diagnostics.Process Process = null;
        private void btnOK_Click(object sender, EventArgs e)
        {
            //this.SetDesktopLocation(20, 20);
            //bool isSave = SaveOption();
            Lang = (rdEnglish.Checked == true) ? "E" : "K";
            Site = cboSite.SelectedValue.ToString();
            GMT = cboGMT.SelectedValue.ToString();
            TimeOutPut = dtp_Option.Text;
            TimeReload = cboTimeReload.SelectedValue.ToString();

            if (SaveOption())
            {
                Process = System.Diagnostics.Process.Start(path + @"KimBap_Schedule\KimBap_Schedule\bin\Debug\KimBap_Schedule.exe");
                Process = System.Diagnostics.Process.Start(path + @"KimBap_Result\KimBap_Result\bin\Debug\KimBap_Result.exe");
                Process = System.Diagnostics.Process.Start(path + @"KimBap_Oddsportal\KimBap_Oddsportal\bin\Debug\KimBap_Oddsportal.exe");
                Process = System.Diagnostics.Process.Start(path + @"KimBap_HandiOU\KimBap_HandiOU\bin\Debug\KimBap_HandiOU.exe");
                Process = System.Diagnostics.Process.Start(path + @"KimBap_Oddsportal_T\bin\Debug\KimBap_Oddsportal_T.exe");
                Process = System.Diagnostics.Process.Start(path + @"KimBap_HandiOU_T\bin\Debug\KimBap_HandiOU_T.exe");

                //Process = System.Diagnostics.Process.Start(@"E:\Project\KimBapProject\KimBap_Schedule\KimBap_Schedule\bin\Debug\KimBap_Schedule.exe");
                //Process = System.Diagnostics.Process.Start(@"E:\Project\KimBapProject\KimBap_Result\KimBap_Result\bin\Debug\KimBap_Result.exe");
                //Process = System.Diagnostics.Process.Start(@"E:\Project\KimBapProject\KimBap_Oddsportal\KimBap_Oddsportal\bin\Debug\KimBap_Oddsportal.exe");
                //Process = System.Diagnostics.Process.Start(@"E:\Project\KimBapProject\KimBap_HandiOU\KimBap_HandiOU\bin\Debug\KimBap_HandiOU.exe");
                //Process = System.Diagnostics.Process.Start(@"E:\Project\KimBapProject\KimBap_HandiOU_T\bin\Debug\KimBap_HandiOU_T.exe");
                //Process = System.Diagnostics.Process.Start(@"E:\Project\KimBapProject\KimBap_Oddsportal_T\bin\Debug\KimBap_Oddsportal_T.exe");

                //Process = System.Diagnostics.Process.Start(Directory.GetCurrentDirectory() + @"\Schedule\KimBap_Schedule.exe");
                //Process = System.Diagnostics.Process.Start(Directory.GetCurrentDirectory() + @"\Result\KimBap_Result.exe");
                //Process = System.Diagnostics.Process.Start(Directory.GetCurrentDirectory() + @"\Odds\KimBap_Oddsportal.exe");
                //Process = System.Diagnostics.Process.Start(Directory.GetCurrentDirectory() + @"\HandiOU\KimBap_HandiOU.exe");
                //Process = System.Diagnostics.Process.Start(Directory.GetCurrentDirectory() + @"\Odds_T\KimBap_Oddsportal_T.exe");
                //Process = System.Diagnostics.Process.Start(Directory.GetCurrentDirectory() + @"\HandiOU_T\KimBap_HandiOU_T.exe");

                eventRecheck();
            }

        }
        public string returnListOP()
        {
            return cboTimeReload.SelectedValue.ToString();
        }
        private bool SaveOption()
        {
            int Row = 0;
            
            SqlConnection con = new SqlConnection(strCnn);
            con.Open();
            string Query = "UPDATE dbo.[KimBapMemberList]" +
                           " SET [uOp_SvOdd] = @SvOdd, [uOp_Lang] = @Lang, [uOp_GMT] = @GMT, [uOp_TimeReload] = @TimeReload, [uOp_TimeOutput] = @TimeOutPut";
                           //" WHERE uID = @uID";
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.Parameters.AddWithValue("@SvOdd", Site);
            cmd.Parameters.AddWithValue("@Lang", Lang);
            cmd.Parameters.AddWithValue("@GMT", GMT);
            cmd.Parameters.AddWithValue("@TimeReload", TimeReload);
            cmd.Parameters.AddWithValue("@TimeOutPut", TimeOutPut);
            //cmd.Parameters.AddWithValue("@MachineName", Environment.MachineName);
            //cmd.Parameters.AddWithValue("@uID", strUID);

            try
            {
                Row = cmd.ExecuteNonQuery();
                cmd.Cancel();
                con.Close();
            }
            catch
            { MessageBox.Show(Query); }

            if(Row == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnCloseClick(object sender, EventArgs e)
        {
            eventClose();
        }

        private void Option_FormClosed(object sender, FormClosedEventArgs e)
        {
            eventClose();
        }

        private void eventRecheck()
        {
            System.Windows.Forms.Timer timerRecheck = new System.Windows.Forms.Timer();
            timerRecheck.Interval = ( 5 * 60 * 1000);//3 min
            timerRecheck.Tick += TimerRecheck_Tick;
            timerRecheck.Start();
        }

        private void TimerRecheck_Tick(object sender, EventArgs e)
        {
            Process[] allPro = Process.GetProcesses();
            foreach (var process in Process.GetProcesses())
            {
                //if (process.ProcessName == "KimBap_Schedule" && process.Responding == false)
                //{
                //    process.Kill();
                //    Process = System.Diagnostics.Process.Start(Directory.GetCurrentDirectory() + @"\Schedule\KimBap_Schedule.exe");
                //}
                //if (process.ProcessName == "KimBap_Result" && process.Responding == false)
                //{
                //    process.Kill();
                //    Process = System.Diagnostics.Process.Start(Directory.GetCurrentDirectory() + @"\Result\KimBap_Result.exe");
                //}
                //if (process.ProcessName == "KimBap_Oddsportal" && process.Responding == false)
                //{
                //    process.Kill();
                //    Process = System.Diagnostics.Process.Start(Directory.GetCurrentDirectory() + @"\Odds\KimBap_Oddsportal.exe");
                //}
                //if (process.ProcessName == "KimBap_HandiOU" && process.Responding == false)
                //{
                //    process.Kill();
                //    Process = System.Diagnostics.Process.Start(Directory.GetCurrentDirectory() + @"\HandiOU\KimBap_HandiOU.exe");
                //}
                //if (process.ProcessName == "KimBap_Oddsportal_T" && process.Responding == false)
                //{
                //    process.Kill();
                //    Process = System.Diagnostics.Process.Start(Directory.GetCurrentDirectory() + @"\Odds_T\KimBap_Oddsportal_T.exe");
                //}
                //if (process.ProcessName == "KimBap_HandiOU_T" && process.Responding == false)
                //{
                //    process.Kill();
                //    Process = System.Diagnostics.Process.Start(Directory.GetCurrentDirectory() + @"\HandiOU_T\KimBap_HandiOU_T.exe");
                //}


                if (process.ProcessName == "KimBap_Schedule" && process.Responding == false)
                {
                    process.Kill();
                    Process = System.Diagnostics.Process.Start(path + @"\KimBap_Schedule\KimBap_Schedule\bin\Debug\KimBap_Schedule.exe");
                }
                if (process.ProcessName == "KimBap_Result" && process.Responding == false)
                {
                    process.Kill();
                    Process = System.Diagnostics.Process.Start(path + @"\KimBap_Result\KimBap_Result\bin\Debug\KimBap_Result.exe");
                }
                if (process.ProcessName == "KimBap_Oddsportal" && process.Responding == false)
                {
                    process.Kill();
                    Process = System.Diagnostics.Process.Start(path + @"\KimBap_Oddsportal\KimBap_Oddsportal\bin\Debug\KimBap_Oddsportal.exe");
                }
                if (process.ProcessName == "KimBap_HandiOU" && process.Responding == false)
                {
                    process.Kill();
                    Process = System.Diagnostics.Process.Start(path + @"\KimBap_HandiOU\KimBap_HandiOU\bin\Debug\KimBap_HandiOU.exe");
                }
                if (process.ProcessName == "KimBap_Oddsportal_T" && process.Responding == false)
                {
                    process.Kill();
                    Process = System.Diagnostics.Process.Start(path + @"\\KimBap_Oddsportal_T\bin\Debug\KimBap_Oddsportal_T.exe");
                }
                if (process.ProcessName == "KimBap_HandiOU_T" && process.Responding == false)
                {
                    process.Kill();
                    Process = System.Diagnostics.Process.Start(path + @"\KimBap_HandiOU_T\bin\Debug\KimBap_HandiOU_T.exe");
                }


            }
        }

        private void eventClose()
        {
            try
            {
                Process[] allPro = Process.GetProcesses();
                foreach (var process in Process.GetProcesses())
                {
                    if (process.ProcessName == "KimBap_Schedule" || process.ProcessName == "KimBap_Result" || process.ProcessName == "KimBap_Oddsportal" || process.ProcessName == "KimBap_HandiOU" || process.ProcessName == "KimBap_Oddsportal_T" || process.ProcessName == "KimBap_HandiOU_T")
                    {
                        process.Kill();
                    }
                }

                foreach (var pro in Process.GetProcessesByName("KimBap"))
                {
                    pro.Kill();
                }

                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Option_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Timer timerDelete = new System.Windows.Forms.Timer();
            timerDelete.Interval = 1000;//ticks every 1 second
            timerDelete.Tick += new EventHandler(timerDelete_Tick);
            timerDelete.Start();
        }

        private void timerDelete_Tick(object sender, EventArgs e)
        {
            string time = DateTime.Now.ToString("HH:mm:ss");
            DateTime dt = DateTime.Now.Date.AddDays(-1);
            if (time == ConfigurationManager.AppSettings["TimeDelFile"].ToString())
            {
                //Delete data where gStartTime <= yesterday
                //SqlConnection con = new SqlConnection(strCnn);
                //con.Open();
                //string Query = "delete from KimBapGSoccerList where gStartTime <= @date";
                //SqlCommand cmd = new SqlCommand(Query, con);
                //cmd.Parameters.AddWithValue("@date", dt);
                //cmd.ExecuteNonQuery();
                //delete file Odds file
                try
                {
                    string dirName = ConfigurationManager.AppSettings["Export"];
                    string[] files = Directory.GetFiles(dirName + "Odds");
                    foreach (string file in files)
                    {
                        FileInfo fi = new FileInfo(file);
                        if (fi.LastWriteTime < dt)
                            fi.Delete();
                    }
                    //delete file Odds file
                    string[] filesTimeChange = Directory.GetFiles(dirName + "TimeChange");
                    foreach (string file in filesTimeChange)
                    {
                        FileInfo fi = new FileInfo(file);
                        if (fi.LastWriteTime < dt)
                            fi.Delete();
                    }
                    //Delete result file
                    string[] filesRs = Directory.GetFiles(dirName + "Result");
                    foreach (string file in filesRs)
                    {
                        FileInfo fi = new FileInfo(file);
                        if (fi.LastWriteTime < dt)
                            fi.Delete();
                    }
                }
                catch { }
            }
        }
    }
}
