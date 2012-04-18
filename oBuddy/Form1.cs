using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace oBuddy
{
    public partial class Form1 : Form
    {
        BuildServiceReference.bugData requestObj;
        SearchResultForm resultWindow;
        string error ;
        string tags;
        string filename;
        string moreOptions;
        string info;
        string version;
        string os;

        public Form1()
        {
            InitializeComponent();
            resultWindow = new SearchResultForm();
        }
        public Form1(string Error, string Tags, string Filename, string MoreOption, string Info, string Version, string Os)
        {
            InitializeComponent();
            resultWindow = new SearchResultForm();
            error = Error;
            tags = Tags;
            filename = Filename;
            moreOptions = MoreOption;
            info = Info;
            version = Version;
            os = Os;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void objInitialize()
        {
            textBox1.Text = error;
            textBox2.Text = tags;
            textBox3.Text = filename;
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = moreOptions;
            textBox7.Text = info;
            textBox8.Text = "";
            textBox8.Multiline = true;
            textBox8.AllowDrop = true;
            textBox9.Text = version;
            textBox10.Text = os;
        }

        private void populate(BuildServiceReference.bugData robj)
        {
            robj.UserId = Environment.UserName;
            robj.Filename = textBox3.Text;
            robj.NameSpace = textBox4.Text;
            robj.Guid = textBox5.Text;
            robj.MoreOptions = 0;
            robj.OutputText = Environment.CommandLine;
            robj.SoftwareInfo = textBox7.Text;
            robj.Version = textBox9.Text;
            robj.Vendor = Environment.UserDomainName;
            robj.StackTrace = textBox8.Text;
            robj.OperatingSystem = textBox10.Text;
            robj.ErrorMessage = textBox1.Text;
            robj.Tags = new string[] { tags };
            robj.BugId = "";
        }

        public void changeQuestion()
        {
            requestObj.MoreOptions++;
            button1_Click(null,null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BuildServiceReference.IService1 obj = new BuildServiceReference.Service1Client();
            //try
            {
                BuildServiceReference.responseInfo resultObj = obj.GetAnswer(requestObj);
                requestObj.BugId = resultObj.BugId;
                resultWindow.populate(resultObj);
                DialogResult dres= resultWindow.ShowDialog();
                if (dres == DialogResult.Retry)
                    changeQuestion();
                else
                    this.Close();
            }
            //catch (Exception ex) { System.Console.WriteLine(ex.Message); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            requestObj = new BuildServiceReference.bugData();
            objInitialize();
            populate(requestObj);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
