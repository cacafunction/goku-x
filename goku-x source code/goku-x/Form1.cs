using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sxlib;
using sxlib.Specialized;
using System.Threading;
using System.IO;


namespace goku_x
{
    public partial class gokux : Form
    {
        public SxLibWinForms sxlib;
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        
        public gokux()
        {
            InitializeComponent();
        }

        private void Sxlib_AttachEvent(SxLibBase.SynAttachEvents Event, object Param)
        {

            statusLabel.Text = "Injection: " + Event.ToString().Replace("_", " ").ToLower().First().ToString().ToUpper() + Event.ToString().Replace("_", " ").ToLower().Substring(1) + ".";
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            this.sxlib = SxLib.InitializeWinForms(this, Directory.GetCurrentDirectory());
            sxlib.AttachEvent += Sxlib_AttachEvent;
            sxlib.LoadEvent += Sxlib_LoadEvent;
            
        }

        private void Sxlib_LoadEvent(SxLibBase.SynLoadEvents Event, object Param)
        {
            statusLabel.Text = " " + Event.ToString().Replace("_", " ").ToLower().First().ToString().ToUpper() + Event.ToString().Replace("_", " ").ToLower().Substring(1) + ".";
            if (Event == SxLibBase.SynLoadEvents.READY)
            {
                sxlib.ScriptHub();
            }
        }





        private void button3_Click(object sender, EventArgs e)
        {
            sxlib.Attach();
        }

        private void executeButton_Click(object sender, EventArgs e)
        {
            sxlib.Execute(richTextBoxScript.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBoxScript.Text = string.Empty;
        }
    }
}
