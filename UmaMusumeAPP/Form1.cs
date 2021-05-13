using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using AppLibrary;

namespace UmaMusumeAPP
{
    public partial class Form1 : Form
    {
        ValueData mode1Vd1;
        ValueData mode1Vd2;
        ValueData mode1Vd3;

        ValueData mode2Vd1;
        ValueData mode2Vd2;
        ValueData mode2Vd3;
        ValueData mode2Vd4;
        ValueData mode2Vd5;
        ValueData mode2Vd6;
        ValueData mode2Vd7;

        public int TABC = 50;
        public int TAALLAmax = 25;
        public int TAALLAmin = 20;
        public int TBCmax = 45;
        public int TBCmin = 40;

        //ValueData mode3Vd1;
        //ValueData mode3Vd2;
        //ValueData mode3Vd3;
        //ValueData mode3Vd4;
        //ValueData mode3Vd5;
        //ValueData mode3Vd6;
        //ValueData mode3Vd7;
        //ValueData mode3Vd8;
        //ValueData mode3Vd9;
        //ValueData mode3Vd10;
        //ValueData mode3Vd11;
        //ValueData mode3Vd12;
        //ValueData mode3Vd13;
        //ValueData mode3Vd14;
        //ValueData mode3Vd15;

        public Form1()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            //this.UpdateStyles();

            //this.SetStyle(ControlStyles.ResizeRedraw, true);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ModesLoad();
        }

        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        CreateParams paras = base.CreateParams;
        //        paras.ExStyle |= 0x02000000;
        //        return paras;
        //    }
        //}

        private void ModesLoad()
        {
            this.comboBox_Modes.Items.Add("1世代");
            this.comboBox_Modes.Items.Add("2世代");
            //this.comboBox_Modes.Items.Add("3世代"); 
            //this.comboBox_Modes.Items.Add("4世代");
            this.comboBox_Modes.SelectedIndex = 0;

            this.comboBox_Data.DataSource = new MainLoad().sources;

            if (comboBox_Modes.SelectedIndex == 0)
            {
                if (this.comboBox_Data.SelectedValue != null)
                {
                    foreach (Control c in this.Mode1Panel.Controls)
                    {
                        if (c is ComboBox)
                        {
                            Source source = new MainLoad().sourceList.Find(delegate (Source s) { return s.Source_name == (string)this.comboBox_Data.SelectedValue; });
                            (c as ComboBox).DataSource = source.listA;
                            (c as ComboBox).DisplayMember = "umaname";
                            (c as ComboBox).SelectedIndex = -1;
                        }
                    }
                }
                this.ModeScrollBar_Load(this.ModeScreen1, 672, 503);
            }
            if (comboBox_Modes.SelectedIndex == 1)
            {
                if (this.comboBox_Data.SelectedValue != null)
                {
                    foreach (Control c in this.Mode2Panel.Controls)
                    {
                        if (c is ComboBox)
                        {
                            Source source = new MainLoad().sourceList.Find(delegate (Source s) { return s.Source_name == (string)this.comboBox_Data.SelectedValue; });
                            (c as ComboBox).DataSource = source.listA;
                            (c as ComboBox).DisplayMember = "umaname";
                            (c as ComboBox).SelectedIndex = -1;
                        }
                    }
                }
                this.ModeScrollBar_Load(this.ModeScreen2, 857, 650);
            }
            if (this.comboBox_Modes.SelectedIndex == 2)
            {
                if (this.comboBox_Data.SelectedValue != null)
                {
                    foreach (Control c in this.Mode2Panel.Controls)
                    {
                        if (c is ComboBox)
                        {
                            Source source = new MainLoad().sourceList.Find(delegate (Source s) { return s.Source_name == (string)this.comboBox_Data.SelectedValue; });
                            (c as ComboBox).DataSource = source.listA;
                            (c as ComboBox).DisplayMember = "umaname";
                            (c as ComboBox).SelectedIndex = -1;
                        }
                    }
                }
                this.ModeScrollBar_Load(this.ModeScreen3, 1465, 1000);
            }
            this.setPictureBackGround();
        }

        private void comboBox_Modes_SelectedIndexChanged(object sender, EventArgs e)
        { 
            if (this.comboBox_Modes.SelectedIndex == 0)
            {
                this.ResetModeScreen();
                this.ModeScreen1.Visible = true;
                this.Mode1AnchorSetC();
                if (this.comboBox_Data.SelectedValue != null)
                {
                    foreach (Control c in this.Mode1Panel.Controls)
                    {
                        if (c is ComboBox)
                        {
                            Source source = new MainLoad().sourceList.Find(delegate (Source s) { return s.Source_name == (string)this.comboBox_Data.SelectedValue; });
                            (c as ComboBox).DataSource = source.listA;
                            (c as ComboBox).DisplayMember = "umaname";
                            (c as ComboBox).SelectedIndex = -1;
                        }
                    }
                }
                this.ModeScrollBar_Load(this.ModeScreen1, 672, 503);
            }
            if (this.comboBox_Modes.SelectedIndex == 1)
            {
                this.ResetModeScreen();
                this.ModeScreen2.Visible = true;
                this.Mode2AnchorSetC();
                if (this.comboBox_Data.SelectedValue != null)
                {
                    foreach (Control c in this.Mode2Panel.Controls)
                    {
                        if (c is ComboBox)
                        {
                            Source source = new MainLoad().sourceList.Find(delegate (Source s) { return s.Source_name == (string)this.comboBox_Data.SelectedValue; });
                            (c as ComboBox).DataSource = source.listA;
                            (c as ComboBox).DisplayMember = "umaname";
                            (c as ComboBox).SelectedIndex = -1;
                        }
                    }
                }
                this.ModeScrollBar_Load(this.ModeScreen2, 857, 650);
            }
            if (this.comboBox_Modes.SelectedIndex == 2)
            {
                this.ResetModeScreen();
                this.ModeScreen3.Visible = true;
                this.Mode3AnchorSetC();
                if (this.comboBox_Data.SelectedValue != null)
                {
                    foreach (Control c in this.Mode3Panel.Controls)
                    {
                        if (c is ComboBox)
                        {
                            Source source = new MainLoad().sourceList.Find(delegate (Source s) { return s.Source_name == (string)this.comboBox_Data.SelectedValue; });
                            (c as ComboBox).DataSource = source.listA;
                            (c as ComboBox).DisplayMember = "umaname";
                            (c as ComboBox).SelectedIndex = -1;
                        }
                    }
                }
                this.ModeScrollBar_Load(this.ModeScreen3, 1465, 1000);
            }
            if (this.comboBox_Modes.SelectedIndex == 3)
            {
                this.ResetModeScreen();
                this.ModeScreen4.Visible = true;
            }
        }

        private void comboBox_Data_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBox_Modes.SelectedIndex == 0)
            {
                if (this.comboBox_Data.SelectedValue != null)
                {
                    foreach (Control c in this.Mode1Panel.Controls)
                    {
                        if (c is ComboBox)
                        {
                            Source source = new MainLoad().sourceList.Find(delegate (Source s) { return s.Source_name == (string)this.comboBox_Data.SelectedValue; });
                            (c as ComboBox).DataSource = source.listA;
                            (c as ComboBox).DisplayMember = "umaname";
                            (c as ComboBox).SelectedIndex = -1;
                        }
                    }
                }
            }
            if (this.comboBox_Modes.SelectedIndex == 1)
            {
                if (this.comboBox_Data.SelectedValue != null)
                {
                    foreach (Control c in this.Mode2Panel.Controls)
                    {
                        if (c is ComboBox)
                        {
                            Source source = new MainLoad().sourceList.Find(delegate (Source s) { return s.Source_name == (string)this.comboBox_Data.SelectedValue; });
                            (c as ComboBox).DataSource = source.listA;
                            (c as ComboBox).DisplayMember = "umaname";
                            (c as ComboBox).SelectedIndex = -1;
                        }
                    }
                }
            }
            if (this.comboBox_Modes.SelectedIndex == 2)
            {
                if (this.comboBox_Data.SelectedValue != null)
                {
                    foreach (Control c in this.Mode3Panel.Controls)
                    {
                        if (c is ComboBox)
                        {
                            Source source = new MainLoad().sourceList.Find(delegate (Source s) { return s.Source_name == (string)this.comboBox_Data.SelectedValue; });
                            (c as ComboBox).DataSource = source.listA;
                            (c as ComboBox).DisplayMember = "umaname";
                            (c as ComboBox).SelectedIndex = -1;
                        }
                    }
                }
            }
            if (this.comboBox_Modes.SelectedIndex == 3)
            {
            }
        }

        private void ResetModeScreen()
        {
            this.ModeScreen1.Visible = false;
            this.ModeScreen2.Visible = false;
            this.ModeScreen3.Visible = false;
            this.ModeScreen4.Visible = false;
        }


        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (comboBox_Modes.SelectedIndex == 0)
            {
                this.ModeScrollBar_Load(this.ModeScreen1, 672, 503);
            }
            if (comboBox_Modes.SelectedIndex == 1)
            {
                this.ModeScrollBar_Load(this.ModeScreen2, 857, 650);
            }
            if (this.comboBox_Modes.SelectedIndex == 2)
            {
                this.ModeScrollBar_Load(this.ModeScreen3, 1465, 1000);
            }

            if (this.comboBox_Modes.SelectedIndex == 0 && (this.Size.Width > 672 || this.Size.Height > 503))
            {
                if (this.ModeScreen2.Size.Width > 672)
                {
                    Mode1AnchorSetB();
                }
                if (this.ModeScreen2.Size.Height > 503)
                {
                    Mode1AnchorSetC();
                }
            }
            else
            {
                Mode1AnchorSetA();
            }

            if (this.comboBox_Modes.SelectedIndex == 1 && (this.ModeScreen2.Size.Width > 857 || this.ModeScreen2.Size.Height > 662))
            {
                if (this.ModeScreen2.Size.Width > 857)
                {
                    Mode2AnchorSetB();
                }
                if (this.ModeScreen2.Size.Height > 584)
                {
                    Mode2AnchorSetC();
                }
            }
            else
            {
                Mode2AnchorSetA();
            }

            if (this.comboBox_Modes.SelectedIndex == 2 && (this.ModeScreen3.Size.Width > 1000 || this.ModeScreen3.Size.Height > 600))
            {
                if (this.ModeScreen3.Size.Width > 1000)
                {
                    Mode3AnchorSetB();
                }
                if (this.ModeScreen3.Size.Height > 600)
                {
                    Mode3AnchorSetC();
                }
            }
            else
            {
                Mode3AnchorSetA();
            }
        }

        private class ChangeFormSizeInfo
        {
            public int mode;
            public string type;

            public int x;
            public int y;
            public int ax;
            public int ay;
            public int aay;
            public int b1x;
            public int b2x;
            public int by;
            public int bby;
            public int c1x;
            public int c2x;
            public int c3x;
            public int c4x;
            public int cy;
            public int ccy;
        }

        private void Mode1AnchorSetA()
        {
            int ax = 290;
            int ay = 30;
            int aay = 130;
            int b1x = 76;
            int b2x = 513;
            int by = 338;
            int bby = 438;
            this.Mode1PictureBox1.Location = new Point(ax, ay);
            this.Mode1PictureBox2.Location = new Point(b1x, by);
            this.Mode1PictureBox3.Location = new Point(b2x, by);

            this.Mode1ComboBox1.Location = new Point(ax, aay);
            this.Mode1ComboBox2.Location = new Point(b1x, bby);
            this.Mode1ComboBox3.Location = new Point(b2x, bby);

            this.Mode1Value1a.Location = new Point(ax + 88, ay);
            this.Mode1Value2a.Location = new Point(b1x + 88, by);
            this.Mode1Value3a.Location = new Point(b2x + 88, by);

            this.Mode1Box1Value1.Location = new Point(ax + 88, ay + 25);
            this.Mode1Box1Value2.Location = new Point(ax + 88, ay + 55);
            this.Mode1Box2Value1.Location = new Point(b1x + 88, by + 25);
            this.Mode1Box2Value2.Location = new Point(b1x + 88, by + 55);
            this.Mode1Box3Value1.Location = new Point(b2x + 88, by + 25);
            this.Mode1Box3Value2.Location = new Point(b2x + 88, by + 55);

            this.Clear1A.Location = new Point(ax - 31, aay);
            this.Clear1B.Location = new Point(b1x - 31, bby);
            this.Clear1C.Location = new Point(b2x - 31, bby);
        }
        private void Mode1AnchorSetB()
        {
            ChangeFormSizeInfo cfsi = new ChangeFormSizeInfo();
            cfsi.mode = 1;
            cfsi.type = "B";

            cfsi.x = this.ModeScreen1.Size.Width;
            cfsi.y = this.ModeScreen1.Size.Height;

            cfsi.ay = this.Mode1PictureBox1.Location.Y;
            cfsi.aay = this.Mode1ComboBox1.Location.Y;

            cfsi.by = this.Mode1PictureBox2.Location.Y;
            cfsi.bby = this.Mode1ComboBox2.Location.Y;

            if (!this.BackgroundCalculateWorker2.IsBusy)
            {
                this.BackgroundCalculateWorker2.RunWorkerAsync(cfsi);
            }
            
        }
        private void Mode1AnchorSetC()
        {
            ChangeFormSizeInfo cfsi = new ChangeFormSizeInfo();
            cfsi.mode = 1;
            cfsi.type = "C";

            cfsi.x = this.ModeScreen2.Size.Width;
            cfsi.y = this.ModeScreen2.Size.Height;

            if (!this.BackgroundCalculateWorker3.IsBusy)
            {
                this.BackgroundCalculateWorker3.RunWorkerAsync(cfsi);
            }
        }
        private void Mode2AnchorSetA()
        {
            int ax = 388;
            int ay = 40;
            int aay = 139;
            int b1x = 178;
            int b2x = 595;
            int by = 227;
            int bby = 326;
            int c1x = 66;
            int c2x = 285;
            int c3x = 486;
            int c4x = 705;
            int cy = 414;
            int ccy = 514;
            this.Mode2PictureBox1.Location = new Point(ax, ay);
            this.Mode2PictureBox2.Location = new Point(b1x, by);
            this.Mode2PictureBox3.Location = new Point(b2x, by);
            this.Mode2PictureBox4.Location = new Point(c1x, cy);
            this.Mode2PictureBox5.Location = new Point(c2x, cy);
            this.Mode2PictureBox6.Location = new Point(c3x, cy);
            this.Mode2PictureBox7.Location = new Point(c4x, cy);

            this.Mode2ComboBox1.Location = new Point(ax, aay);
            this.Mode2ComboBox2.Location = new Point(b1x, bby);
            this.Mode2ComboBox3.Location = new Point(b2x, bby);
            this.Mode2ComboBox4.Location = new Point(c1x, ccy);
            this.Mode2ComboBox5.Location = new Point(c2x, ccy);
            this.Mode2ComboBox6.Location = new Point(c3x, ccy);
            this.Mode2ComboBox7.Location = new Point(c4x, ccy);

            this.Mode2Value1a.Location = new Point(ax + 88, ay);
            this.Mode2Value2a.Location = new Point(b1x + 88, by);
            this.Mode2Value3a.Location = new Point(b2x + 88, by);
            this.Mode2Value4a.Location = new Point(c1x + 88, cy);
            this.Mode2Value5a.Location = new Point(c2x + 88, cy);
            this.Mode2Value6a.Location = new Point(c3x + 88, cy);
            this.Mode2Value7a.Location = new Point(c4x + 88, cy);

            this.Mode2Box1Value1.Location = new Point(ax + 88, ay + 25);
            this.Mode2Box2Value1.Location = new Point(b1x + 88, by + 25);
            this.Mode2Box3Value1.Location = new Point(b2x + 88, by + 25);
            this.Mode2Box4Value1.Location = new Point(c1x + 88, cy + 25);
            this.Mode2Box5Value1.Location = new Point(c2x + 88, cy + 25);
            this.Mode2Box6Value1.Location = new Point(c3x + 88, cy + 25);
            this.Mode2Box7Value1.Location = new Point(c4x + 88, cy + 25);

            this.Mode2Box1Value2.Location = new Point(ax + 88, ay + 55);
            this.Mode2Box2Value2.Location = new Point(b1x + 88, by + 55);
            this.Mode2Box3Value2.Location = new Point(b2x + 88, by + 55);
            this.Mode2Box4Value2.Location = new Point(c1x + 88, cy + 55);
            this.Mode2Box5Value2.Location = new Point(c2x + 88, cy + 55);
            this.Mode2Box6Value2.Location = new Point(c3x + 88, cy + 55);
            this.Mode2Box7Value2.Location = new Point(c4x + 88, cy + 55);

            this.Mode2Box1Value3.Location = new Point(ax - (Mode2Box1Value3.Size.Width + 5), ay + 25);
            this.Mode2Box2Value3.Location = new Point(b1x - (Mode2Box2Value3.Size.Width + 5), by + 25);
            this.Mode2Box3Value3.Location = new Point(b2x - (Mode2Box3Value3.Size.Width + 5), by + 25);
            this.Mode2Box4Value3.Location = new Point(c1x - (Mode2Box4Value3.Size.Width + 5), cy + 25);
            this.Mode2Box5Value3.Location = new Point(c2x - (Mode2Box5Value3.Size.Width + 5), cy + 25);
            this.Mode2Box6Value3.Location = new Point(c3x - (Mode2Box6Value3.Size.Width + 5), cy + 25);
            this.Mode2Box7Value3.Location = new Point(c4x - (Mode2Box7Value3.Size.Width + 5), cy + 25);

            this.Mode2Box1Value4.Location = new Point(ax - (Mode2Box1Value4.Size.Width + 5), ay + 55);
            this.Mode2Box2Value4.Location = new Point(b1x - (Mode2Box2Value4.Size.Width + 5), by + 55);
            this.Mode2Box3Value4.Location = new Point(b2x - (Mode2Box3Value4.Size.Width + 5), by + 55);
            this.Mode2Box4Value4.Location = new Point(c1x - (Mode2Box4Value4.Size.Width + 5), cy + 55);
            this.Mode2Box5Value4.Location = new Point(c2x - (Mode2Box5Value4.Size.Width + 5), cy + 55);
            this.Mode2Box6Value4.Location = new Point(c3x - (Mode2Box6Value4.Size.Width + 5), cy + 55);
            this.Mode2Box7Value4.Location = new Point(c4x - (Mode2Box7Value4.Size.Width + 5), cy + 55);

            this.Mode2Box1Value5.Location = new Point(ax + 44 - (Mode2Box1Value3.Size.Width), ay + 131);
            this.Mode2Box1Value6.Location = new Point(ax + 43, ay + 131);

            this.Clear2A.Location = new Point(ax - 31, aay);
            this.Clear2B.Location = new Point(b1x - 31, bby);
            this.Clear2C.Location = new Point(b2x - 31, bby);
            this.Clear2D.Location = new Point(c1x - 31, ccy);
            this.Clear2E.Location = new Point(c2x - 31, ccy);
            this.Clear2F.Location = new Point(c3x - 31, ccy);
            this.Clear2G.Location = new Point(c4x - 31, ccy);
        }
        private void Mode2AnchorSetB()
        {
            ChangeFormSizeInfo cfsi = new ChangeFormSizeInfo();
            cfsi.mode = 2;
            cfsi.type = "B";

            cfsi.x = this.ModeScreen2.Size.Width;
            cfsi.y = this.ModeScreen2.Size.Height;

            cfsi.ay = this.Mode2PictureBox1.Location.Y;
            cfsi.aay = this.Mode2ComboBox1.Location.Y;

            cfsi.by = this.Mode2PictureBox2.Location.Y;
            cfsi.bby = this.Mode2ComboBox2.Location.Y;

            cfsi.cy = this.Mode2PictureBox4.Location.Y;
            cfsi.ccy = this.Mode2ComboBox4.Location.Y;

            if (!this.BackgroundCalculateWorker2.IsBusy)
            {
                this.BackgroundCalculateWorker2.RunWorkerAsync(cfsi);
            }
        }
        private void Mode2AnchorSetC()
        {
            ChangeFormSizeInfo cfsi = new ChangeFormSizeInfo();
            cfsi.mode = 2;
            cfsi.type = "C";

            cfsi.x = this.ModeScreen2.Size.Width;
            cfsi.y = this.ModeScreen2.Size.Height;

            if (!this.BackgroundCalculateWorker3.IsBusy)
            {
                this.BackgroundCalculateWorker3.RunWorkerAsync(cfsi);
            }
        }
        private void Mode3AnchorSetA()
        {
            int ax = 675;
            int ay = 27;
            int aay = 141;
            int b1x = 395;
            int b2x = 951;
            int by = 261;
            int bby = 375;
            int c1x = 246;
            int c2x = 538;
            int c3x = 806;
            int c4x = 1098;
            int cy = 495;
            int ccy = 609;
            int d1x = 78;
            int d2x = 266;
            int d3x = 411;
            int d4x = 599;
            int d5x = 740;
            int d6x = 928;
            int d7x = 1074;
            int d8x = 1262;
            int dy = 754;
            int ddy = 868;
            this.Mode3PictureBox1.Location = new Point(ax, ay);
            this.Mode3PictureBox2.Location = new Point(b1x, by);
            this.Mode3PictureBox3.Location = new Point(b2x, by);
            this.Mode3PictureBox4.Location = new Point(c1x, cy);
            this.Mode3PictureBox5.Location = new Point(c2x, cy);
            this.Mode3PictureBox6.Location = new Point(c3x, cy);
            this.Mode3PictureBox7.Location = new Point(c4x, cy);
            this.Mode3PictureBox8.Location = new Point(d1x, dy);
            this.Mode3PictureBox9.Location = new Point(d2x, dy);
            this.Mode3PictureBox10.Location = new Point(d3x, dy);
            this.Mode3PictureBox11.Location = new Point(d4x, dy);
            this.Mode3PictureBox12.Location = new Point(d5x, dy);
            this.Mode3PictureBox13.Location = new Point(d6x, dy);
            this.Mode3PictureBox14.Location = new Point(d7x, dy);
            this.Mode3PictureBox15.Location = new Point(d8x, dy);

            this.Mode3ComboBox1.Location = new Point(ax, aay);
            this.Mode3ComboBox2.Location = new Point(b1x, bby);
            this.Mode3ComboBox3.Location = new Point(b2x, bby);
            this.Mode3ComboBox4.Location = new Point(c1x, ccy);
            this.Mode3ComboBox5.Location = new Point(c2x, ccy);
            this.Mode3ComboBox6.Location = new Point(c3x, ccy);
            this.Mode3ComboBox7.Location = new Point(c4x, ccy);
            this.Mode3ComboBox8.Location = new Point(d1x, ddy);
            this.Mode3ComboBox9.Location = new Point(d2x, ddy);
            this.Mode3ComboBox10.Location = new Point(d3x, ddy);
            this.Mode3ComboBox11.Location = new Point(d4x, ddy);
            this.Mode3ComboBox12.Location = new Point(d5x, ddy);
            this.Mode3ComboBox13.Location = new Point(d6x, ddy);
            this.Mode3ComboBox14.Location = new Point(d7x, ddy);
            this.Mode3ComboBox15.Location = new Point(d8x, ddy);
        }
        private void Mode3AnchorSetB()
        {
            int x = this.ModeScreen3.Size.Width;
            int y = this.ModeScreen3.Size.Height;
            int ax = (int)(x - 108) / 2;
            int ay = this.Mode3PictureBox1.Location.Y;
            int aay = this.Mode3ComboBox1.Location.Y;
            int b1x = (int)(x / 3) - (108 / 2);
            int b2x = (int)((x / 3) * 2) - (108 / 2);
            int by = this.Mode3PictureBox2.Location.Y;
            int bby = this.Mode3ComboBox2.Location.Y;
            int c1x = (int)(x / 5) - (108 / 2);
            int c2x = (int)((x / 5) * 2) - (108 / 2);
            int c3x = (int)((x / 5) * 3) - (108 / 2);
            int c4x = (int)((x / 5) * 4) - (108 / 2);
            int cy = this.Mode3PictureBox4.Location.Y;
            int ccy = this.Mode3ComboBox4.Location.Y;
            int d1x = (int)(x / 9) - (108 / 2);
            int d2x = (int)((x / 9) * 2) - (108 / 2);
            int d3x = (int)((x / 9) * 3) - (108 / 2);
            int d4x = (int)((x / 9) * 4) - (108 / 2);
            int d5x = (int)((x / 9) * 5) - (108 / 2);
            int d6x = (int)((x / 9) * 6) - (108 / 2);
            int d7x = (int)((x / 9) * 7) - (108 / 2);
            int d8x = (int)((x / 9) * 8) - (108 / 2);
            int dy = this.Mode3PictureBox8.Location.Y;
            int ddy = this.Mode3ComboBox8.Location.Y;
            this.Mode3PictureBox1.Location = new Point(ax, ay);
            this.Mode3PictureBox2.Location = new Point(b1x, by);
            this.Mode3PictureBox3.Location = new Point(b2x, by);
            this.Mode3PictureBox4.Location = new Point(c1x, cy);
            this.Mode3PictureBox5.Location = new Point(c2x, cy);
            this.Mode3PictureBox6.Location = new Point(c3x, cy);
            this.Mode3PictureBox7.Location = new Point(c4x, cy);
            this.Mode3PictureBox8.Location = new Point(d1x, dy);
            this.Mode3PictureBox9.Location = new Point(d2x, dy);
            this.Mode3PictureBox10.Location = new Point(d3x, dy);
            this.Mode3PictureBox11.Location = new Point(d4x, dy);
            this.Mode3PictureBox12.Location = new Point(d5x, dy);
            this.Mode3PictureBox13.Location = new Point(d6x, dy);
            this.Mode3PictureBox14.Location = new Point(d7x, dy);
            this.Mode3PictureBox15.Location = new Point(d8x, dy);

            this.Mode3ComboBox1.Location = new Point(ax, aay);
            this.Mode3ComboBox2.Location = new Point(b1x, bby);
            this.Mode3ComboBox3.Location = new Point(b2x, bby);
            this.Mode3ComboBox4.Location = new Point(c1x, ccy);
            this.Mode3ComboBox5.Location = new Point(c2x, ccy);
            this.Mode3ComboBox6.Location = new Point(c3x, ccy);
            this.Mode3ComboBox7.Location = new Point(c4x, ccy);
            this.Mode3ComboBox8.Location = new Point(d1x, ddy);
            this.Mode3ComboBox9.Location = new Point(d2x, ddy);
            this.Mode3ComboBox10.Location = new Point(d3x, ddy);
            this.Mode3ComboBox11.Location = new Point(d4x, ddy);
            this.Mode3ComboBox12.Location = new Point(d5x, ddy);
            this.Mode3ComboBox13.Location = new Point(d6x, ddy);
            this.Mode3ComboBox14.Location = new Point(d7x, ddy);
            this.Mode3ComboBox15.Location = new Point(d8x, ddy);
        }
        private void Mode3AnchorSetC()
        {
            int x = this.ModeScreen3.Size.Width;
            int y = this.ModeScreen3.Size.Height;
            int ax = (int)(x - 108) / 2;
            int ay = 27 + ((y - 900) / 14);
            int aay = 141 + ((y - 900) / 15);
            int b1x = (int)(x / 3) - (108 / 2);
            int b2x = (int)((x / 3) * 2) - (108 / 2);
            int by = 261 + ((y - 900) / 14);
            int bby = 375 + ((y - 900) / 15);
            int c1x = (int)(x / 5) - (108 / 2);
            int c2x = (int)((x / 5) * 2) - (108 / 2);
            int c3x = (int)((x / 5) * 3) - (108 / 2);
            int c4x = (int)((x / 5) * 4) - (108 / 2);
            int cy = 495 + ((y - 900) / 14);
            int ccy = 609 + ((y - 900) / 15);
            int d1x = (int)(x / 9) - (108 / 2);
            int d2x = (int)((x / 9) * 2) - (108 / 2);
            int d3x = (int)((x / 9) * 3) - (108 / 2);
            int d4x = (int)((x / 9) * 4) - (108 / 2);
            int d5x = (int)((x / 9) * 5) - (108 / 2);
            int d6x = (int)((x / 9) * 6) - (108 / 2);
            int d7x = (int)((x / 9) * 7) - (108 / 2);
            int d8x = (int)((x / 9) * 8) - (108 / 2);
            int dy = 754 + ((y - 900) / 14);
            int ddy = 868 + ((y - 900) / 15);
            this.Mode3PictureBox1.Location = new Point(ax, ay);
            this.Mode3PictureBox2.Location = new Point(b1x, by);
            this.Mode3PictureBox3.Location = new Point(b2x, by);
            this.Mode3PictureBox4.Location = new Point(c1x, cy);
            this.Mode3PictureBox5.Location = new Point(c2x, cy);
            this.Mode3PictureBox6.Location = new Point(c3x, cy);
            this.Mode3PictureBox7.Location = new Point(c4x, cy);
            this.Mode3PictureBox8.Location = new Point(d1x, dy);
            this.Mode3PictureBox9.Location = new Point(d2x, dy);
            this.Mode3PictureBox10.Location = new Point(d3x, dy);
            this.Mode3PictureBox11.Location = new Point(d4x, dy);
            this.Mode3PictureBox12.Location = new Point(d5x, dy);
            this.Mode3PictureBox13.Location = new Point(d6x, dy);
            this.Mode3PictureBox14.Location = new Point(d7x, dy);
            this.Mode3PictureBox15.Location = new Point(d8x, dy);

            this.Mode3ComboBox1.Location = new Point(ax, aay);
            this.Mode3ComboBox2.Location = new Point(b1x, bby);
            this.Mode3ComboBox3.Location = new Point(b2x, bby);
            this.Mode3ComboBox4.Location = new Point(c1x, ccy);
            this.Mode3ComboBox5.Location = new Point(c2x, ccy);
            this.Mode3ComboBox6.Location = new Point(c3x, ccy);
            this.Mode3ComboBox7.Location = new Point(c4x, ccy);
            this.Mode3ComboBox8.Location = new Point(d1x, ddy);
            this.Mode3ComboBox9.Location = new Point(d2x, ddy);
            this.Mode3ComboBox10.Location = new Point(d3x, ddy);
            this.Mode3ComboBox11.Location = new Point(d4x, ddy);
            this.Mode3ComboBox12.Location = new Point(d5x, ddy);
            this.Mode3ComboBox13.Location = new Point(d6x, ddy);
            this.Mode3ComboBox14.Location = new Point(d7x, ddy);
            this.Mode3ComboBox15.Location = new Point(d8x, ddy);
        }

        private void backgroundCalculatrWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            ChangeFormSizeInfo info = new ChangeFormSizeInfo();
            if (e.Argument != null)
            {
                info = (ChangeFormSizeInfo)e.Argument;
            }
            if (info.mode == 1)
            {
                info.ax = (int)(info.x - 108) / 2;
                info.b1x = (int)(info.x / 5) - (108 / 2);
                info.b2x = (int)((info.x / 5) * 4) - (108 / 2);
            }
            if (info.mode == 2)
            {
                info.ax = (int)(info.x - 108) / 2;
                info.b1x = (int)(info.x / 3) - (108 / 2);
                info.b2x = (int)((info.x / 3) * 2) - (108 / 2);
                info.c1x = (int)(info.x / 5) - (108 / 2);
                info.c2x = (int)((info.x / 5) * 2) - (108 / 2);
                info.c3x = (int)((info.x / 5) * 3) - (108 / 2);
                info.c4x = (int)((info.x / 5) * 4) - (108 / 2);
            }
            e.Result = info;
        }

        private void BackgroundCalculateWorker3_DoWork(object sender, DoWorkEventArgs e)
        {
            ChangeFormSizeInfo info = new ChangeFormSizeInfo();
            if (e.Argument != null)
            {
                info = (ChangeFormSizeInfo)e.Argument;
            }
            if (info.mode == 1)
            {
                info.ax = (int)(info.x - 108) / 2;
                info.ay = 30 + ((info.y - 503) / 3);
                info.aay = 130 + ((info.y - 503) / 3);
                info.b1x = (int)(info.x / 5) - (108 / 2);
                info.b2x = (int)((info.x / 5) * 4) - (108 / 2);
                info.by = 338 + ((info.y - 503) / 3);
                info.bby = 438 + ((info.y - 503) / 3);
            }
            if (info.mode == 2)
            {
                info.ax = (int)(info.x - 108) / 2;
                info.ay = 40 + ((info.y - 500) / 4);
                info.aay = 139 + ((info.y - 500) / 4);
                info.b1x = (int)(info.x / 3) - (108 / 2);
                info.b2x = (int)((info.x / 3) * 2) - (108 / 2);
                info.by = 227 + ((info.y - 500) / 4);
                info.bby = 326 + ((info.y - 500) / 4);
                info.c1x = (int)(info.x / 5) - (108 / 2);
                info.c2x = (int)((info.x / 5) * 2) - (108 / 2);
                info.c3x = (int)((info.x / 5) * 3) - (108 / 2);
                info.c4x = (int)((info.x / 5) * 4) - (108 / 2);
                info.cy = 414 + ((info.y - 500) / 4);
                info.ccy = 514 + ((info.y - 500) / 4);
            }
            e.Result = info;
        }

        private void BackgroundCalculatrWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Result != null)
            {
                ChangeFormSizeInfo cfsi = (ChangeFormSizeInfo)e.Result;
                if (cfsi.mode == 1)
                {
                    int ax = cfsi.ax;
                    int ay = cfsi.ay;
                    int aay = cfsi.aay;
                    int b1x = cfsi.b1x;
                    int b2x = cfsi.b2x;
                    int by = cfsi.by;
                    int bby = cfsi.bby;

                    this.Mode1PictureBox1.Location = new Point(ax, ay);
                    this.Mode1PictureBox2.Location = new Point(b1x, by);
                    this.Mode1PictureBox3.Location = new Point(b2x, by);

                    this.Mode1ComboBox1.Location = new Point(ax, aay);
                    this.Mode1ComboBox2.Location = new Point(b1x, bby);
                    this.Mode1ComboBox3.Location = new Point(b2x, bby);

                    this.Mode1Value1a.Location = new Point(ax + 88, ay);
                    this.Mode1Value2a.Location = new Point(b1x + 88, by);
                    this.Mode1Value3a.Location = new Point(b2x + 88, by);

                    this.Mode1Box1Value1.Location = new Point(ax + 88, ay + 25);
                    this.Mode1Box1Value2.Location = new Point(ax + 88, ay + 55);
                    this.Mode1Box2Value1.Location = new Point(b1x + 88, by + 25);
                    this.Mode1Box2Value2.Location = new Point(b1x + 88, by + 55);
                    this.Mode1Box3Value1.Location = new Point(b2x + 88, by + 25);
                    this.Mode1Box3Value2.Location = new Point(b2x + 88, by + 55);

                    this.Clear1A.Location = new Point(ax - 31, aay);
                    this.Clear1B.Location = new Point(b1x - 31, bby);
                    this.Clear1C.Location = new Point(b2x - 31, bby);
                }
                if (cfsi.mode == 2)
                {
                    int ax = cfsi.ax;
                    int ay = cfsi.ay;
                    int aay = cfsi.aay;
                    int b1x = cfsi.b1x;
                    int b2x = cfsi.b2x;
                    int by = cfsi.by;
                    int bby = cfsi.bby;
                    int c1x = cfsi.c1x;
                    int c2x = cfsi.c2x;
                    int c3x = cfsi.c3x;
                    int c4x = cfsi.c4x;
                    int cy = cfsi.cy;
                    int ccy = cfsi.ccy;

                    this.Mode2PictureBox1.Location = new Point(ax, ay);
                    this.Mode2PictureBox2.Location = new Point(b1x, by);
                    this.Mode2PictureBox3.Location = new Point(b2x, by);
                    this.Mode2PictureBox4.Location = new Point(c1x, cy);
                    this.Mode2PictureBox5.Location = new Point(c2x, cy);
                    this.Mode2PictureBox6.Location = new Point(c3x, cy);
                    this.Mode2PictureBox7.Location = new Point(c4x, cy);

                    this.Mode2ComboBox1.Location = new Point(ax, aay);
                    this.Mode2ComboBox2.Location = new Point(b1x, bby);
                    this.Mode2ComboBox3.Location = new Point(b2x, bby);
                    this.Mode2ComboBox4.Location = new Point(c1x, ccy);
                    this.Mode2ComboBox5.Location = new Point(c2x, ccy);
                    this.Mode2ComboBox6.Location = new Point(c3x, ccy);
                    this.Mode2ComboBox7.Location = new Point(c4x, ccy);

                    this.Mode2Value1a.Location = new Point(ax + 88, ay);
                    this.Mode2Value2a.Location = new Point(b1x + 88, by);
                    this.Mode2Value3a.Location = new Point(b2x + 88, by);
                    this.Mode2Value4a.Location = new Point(c1x + 88, cy);
                    this.Mode2Value5a.Location = new Point(c2x + 88, cy);
                    this.Mode2Value6a.Location = new Point(c3x + 88, cy);
                    this.Mode2Value7a.Location = new Point(c4x + 88, cy);

                    this.Mode2Box1Value1.Location = new Point(ax + 88, ay + 25);
                    this.Mode2Box2Value1.Location = new Point(b1x + 88, by + 25);
                    this.Mode2Box3Value1.Location = new Point(b2x + 88, by + 25);
                    this.Mode2Box4Value1.Location = new Point(c1x + 88, cy + 25);
                    this.Mode2Box5Value1.Location = new Point(c2x + 88, cy + 25);
                    this.Mode2Box6Value1.Location = new Point(c3x + 88, cy + 25);
                    this.Mode2Box7Value1.Location = new Point(c4x + 88, cy + 25);

                    this.Mode2Box1Value2.Location = new Point(ax + 88, ay + 55);
                    this.Mode2Box2Value2.Location = new Point(b1x + 88, by + 55);
                    this.Mode2Box3Value2.Location = new Point(b2x + 88, by + 55);
                    this.Mode2Box4Value2.Location = new Point(c1x + 88, cy + 55);
                    this.Mode2Box5Value2.Location = new Point(c2x + 88, cy + 55);
                    this.Mode2Box6Value2.Location = new Point(c3x + 88, cy + 55);
                    this.Mode2Box7Value2.Location = new Point(c4x + 88, cy + 55);

                    this.Mode2Box1Value3.Location = new Point(ax - (Mode2Box1Value3.Size.Width + 5), ay + 25);
                    this.Mode2Box2Value3.Location = new Point(b1x - (Mode2Box2Value3.Size.Width + 5), by + 25);
                    this.Mode2Box3Value3.Location = new Point(b2x - (Mode2Box3Value3.Size.Width + 5), by + 25);
                    this.Mode2Box4Value3.Location = new Point(c1x - (Mode2Box4Value3.Size.Width + 5), cy + 25);
                    this.Mode2Box5Value3.Location = new Point(c2x - (Mode2Box5Value3.Size.Width + 5), cy + 25);
                    this.Mode2Box6Value3.Location = new Point(c3x - (Mode2Box6Value3.Size.Width + 5), cy + 25);
                    this.Mode2Box7Value3.Location = new Point(c4x - (Mode2Box7Value3.Size.Width + 5), cy + 25);

                    this.Mode2Box1Value4.Location = new Point(ax - (Mode2Box1Value4.Size.Width + 5), ay + 55);
                    this.Mode2Box2Value4.Location = new Point(b1x - (Mode2Box2Value4.Size.Width + 5), by + 55);
                    this.Mode2Box3Value4.Location = new Point(b2x - (Mode2Box3Value4.Size.Width + 5), by + 55);
                    this.Mode2Box4Value4.Location = new Point(c1x - (Mode2Box4Value4.Size.Width + 5), cy + 55);
                    this.Mode2Box5Value4.Location = new Point(c2x - (Mode2Box5Value4.Size.Width + 5), cy + 55);
                    this.Mode2Box6Value4.Location = new Point(c3x - (Mode2Box6Value4.Size.Width + 5), cy + 55);
                    this.Mode2Box7Value4.Location = new Point(c4x - (Mode2Box7Value4.Size.Width + 5), cy + 55);

                    this.Mode2Box1Value5.Location = new Point(ax + 44 - (Mode2Box1Value3.Size.Width), ay + 123);
                    this.Mode2Box1Value6.Location = new Point(ax + 43, ay + 123);

                    this.Clear2A.Location = new Point(ax - 31, aay);
                    this.Clear2B.Location = new Point(b1x - 31, bby);
                    this.Clear2C.Location = new Point(b2x - 31, bby);
                    this.Clear2D.Location = new Point(c1x - 31, ccy);
                    this.Clear2E.Location = new Point(c2x - 31, ccy);
                    this.Clear2F.Location = new Point(c3x - 31, ccy);
                    this.Clear2G.Location = new Point(c4x - 31, ccy);
                }
            }
        }

        private void BackgroundCalculateWorker3_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Result != null)
            {
                ChangeFormSizeInfo cfsi = (ChangeFormSizeInfo)e.Result;
                if (cfsi.mode == 1)
                {
                    int ax = cfsi.ax;
                    int ay = cfsi.ay;
                    int aay = cfsi.aay;
                    int b1x = cfsi.b1x;
                    int b2x = cfsi.b2x;
                    int by = cfsi.by;
                    int bby = cfsi.bby;

                    this.Mode1PictureBox1.Location = new Point(ax, ay);
                    this.Mode1PictureBox2.Location = new Point(b1x, by);
                    this.Mode1PictureBox3.Location = new Point(b2x, by);

                    this.Mode1ComboBox1.Location = new Point(ax, aay);
                    this.Mode1ComboBox2.Location = new Point(b1x, bby);
                    this.Mode1ComboBox3.Location = new Point(b2x, bby);

                    this.Mode1Value1a.Location = new Point(ax + 88, ay);
                    this.Mode1Value2a.Location = new Point(b1x + 88, by);
                    this.Mode1Value3a.Location = new Point(b2x + 88, by);

                    this.Mode1Box1Value1.Location = new Point(ax + 88, ay + 25);
                    this.Mode1Box1Value2.Location = new Point(ax + 88, ay + 55);
                    this.Mode1Box2Value1.Location = new Point(b1x + 88, by + 25);
                    this.Mode1Box2Value2.Location = new Point(b1x + 88, by + 55);
                    this.Mode1Box3Value1.Location = new Point(b2x + 88, by + 25);
                    this.Mode1Box3Value2.Location = new Point(b2x + 88, by + 55);

                    this.Clear1A.Location = new Point(ax - 31, aay);
                    this.Clear1B.Location = new Point(b1x - 31, bby);
                    this.Clear1C.Location = new Point(b2x - 31, bby);
                }
                if (cfsi.mode == 2)
                {
                    int ax = cfsi.ax;
                    int ay = cfsi.ay;
                    int aay = cfsi.aay;
                    int b1x = cfsi.b1x;
                    int b2x = cfsi.b2x;
                    int by = cfsi.by;
                    int bby = cfsi.bby;
                    int c1x = cfsi.c1x;
                    int c2x = cfsi.c2x;
                    int c3x = cfsi.c3x;
                    int c4x = cfsi.c4x;
                    int cy = cfsi.cy;
                    int ccy = cfsi.ccy;

                    this.Mode2PictureBox1.Location = new Point(ax, ay);
                    this.Mode2PictureBox2.Location = new Point(b1x, by);
                    this.Mode2PictureBox3.Location = new Point(b2x, by);
                    this.Mode2PictureBox4.Location = new Point(c1x, cy);
                    this.Mode2PictureBox5.Location = new Point(c2x, cy);
                    this.Mode2PictureBox6.Location = new Point(c3x, cy);
                    this.Mode2PictureBox7.Location = new Point(c4x, cy);

                    this.Mode2ComboBox1.Location = new Point(ax, aay);
                    this.Mode2ComboBox2.Location = new Point(b1x, bby);
                    this.Mode2ComboBox3.Location = new Point(b2x, bby);
                    this.Mode2ComboBox4.Location = new Point(c1x, ccy);
                    this.Mode2ComboBox5.Location = new Point(c2x, ccy);
                    this.Mode2ComboBox6.Location = new Point(c3x, ccy);
                    this.Mode2ComboBox7.Location = new Point(c4x, ccy);

                    this.Mode2Value1a.Location = new Point(ax + 88, ay);
                    this.Mode2Value2a.Location = new Point(b1x + 88, by);
                    this.Mode2Value3a.Location = new Point(b2x + 88, by);
                    this.Mode2Value4a.Location = new Point(c1x + 88, cy);
                    this.Mode2Value5a.Location = new Point(c2x + 88, cy);
                    this.Mode2Value6a.Location = new Point(c3x + 88, cy);
                    this.Mode2Value7a.Location = new Point(c4x + 88, cy);

                    this.Mode2Box1Value1.Location = new Point(ax + 88, ay + 25);
                    this.Mode2Box2Value1.Location = new Point(b1x + 88, by + 25);
                    this.Mode2Box3Value1.Location = new Point(b2x + 88, by + 25);
                    this.Mode2Box4Value1.Location = new Point(c1x + 88, cy + 25);
                    this.Mode2Box5Value1.Location = new Point(c2x + 88, cy + 25);
                    this.Mode2Box6Value1.Location = new Point(c3x + 88, cy + 25);
                    this.Mode2Box7Value1.Location = new Point(c4x + 88, cy + 25);

                    this.Mode2Box1Value2.Location = new Point(ax + 88, ay + 55);
                    this.Mode2Box2Value2.Location = new Point(b1x + 88, by + 55);
                    this.Mode2Box3Value2.Location = new Point(b2x + 88, by + 55);
                    this.Mode2Box4Value2.Location = new Point(c1x + 88, cy + 55);
                    this.Mode2Box5Value2.Location = new Point(c2x + 88, cy + 55);
                    this.Mode2Box6Value2.Location = new Point(c3x + 88, cy + 55);
                    this.Mode2Box7Value2.Location = new Point(c4x + 88, cy + 55);

                    this.Mode2Box1Value3.Location = new Point(ax - (Mode2Box1Value3.Size.Width + 5), ay + 25);
                    this.Mode2Box2Value3.Location = new Point(b1x - (Mode2Box2Value3.Size.Width + 5), by + 25);
                    this.Mode2Box3Value3.Location = new Point(b2x - (Mode2Box3Value3.Size.Width + 5), by + 25);
                    this.Mode2Box4Value3.Location = new Point(c1x - (Mode2Box4Value3.Size.Width + 5), cy + 25);
                    this.Mode2Box5Value3.Location = new Point(c2x - (Mode2Box5Value3.Size.Width + 5), cy + 25);
                    this.Mode2Box6Value3.Location = new Point(c3x - (Mode2Box6Value3.Size.Width + 5), cy + 25);
                    this.Mode2Box7Value3.Location = new Point(c4x - (Mode2Box7Value3.Size.Width + 5), cy + 25);

                    this.Mode2Box1Value4.Location = new Point(ax - (Mode2Box1Value4.Size.Width + 5), ay + 55);
                    this.Mode2Box2Value4.Location = new Point(b1x - (Mode2Box2Value4.Size.Width + 5), by + 55);
                    this.Mode2Box3Value4.Location = new Point(b2x - (Mode2Box3Value4.Size.Width + 5), by + 55);
                    this.Mode2Box4Value4.Location = new Point(c1x - (Mode2Box4Value4.Size.Width + 5), cy + 55);
                    this.Mode2Box5Value4.Location = new Point(c2x - (Mode2Box5Value4.Size.Width + 5), cy + 55);
                    this.Mode2Box6Value4.Location = new Point(c3x - (Mode2Box6Value4.Size.Width + 5), cy + 55);
                    this.Mode2Box7Value4.Location = new Point(c4x - (Mode2Box7Value4.Size.Width + 5), cy + 55);

                    this.Mode2Box1Value5.Location = new Point(ax + 44 - (Mode2Box1Value3.Size.Width), ay + 131);
                    this.Mode2Box1Value6.Location = new Point(ax + 43, ay + 131);

                    this.Clear2A.Location = new Point(ax - 31, aay);
                    this.Clear2B.Location = new Point(b1x - 31, bby);
                    this.Clear2C.Location = new Point(b2x - 31, bby);
                    this.Clear2D.Location = new Point(c1x - 31, ccy);
                    this.Clear2E.Location = new Point(c2x - 31, ccy);
                    this.Clear2F.Location = new Point(c3x - 31, ccy);
                    this.Clear2G.Location = new Point(c4x - 31, ccy);
                }
            }
        }

        private void Form1_MaximumSizeChanged(object sender, EventArgs e)
        {
            if (this.comboBox_Modes.SelectedIndex == 0)
            {
                this.Mode1AnchorSetC();
                this.ModeScrollBar_Load(this.ModeScreen1, 672, 503);
            }
            if (this.comboBox_Modes.SelectedIndex == 1)
            {
                this.Mode2AnchorSetC();
                this.ModeScrollBar_Load(this.ModeScreen2, 857, 584);
            }
            if (this.comboBox_Modes.SelectedIndex == 2)
            {
                this.Mode3AnchorSetC();
                this.ModeScrollBar_Load(this.ModeScreen3, 1465, 1000);
            }
        }

        private void ModeVScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            if (this.comboBox_Modes.SelectedIndex == 0)
            {
                foreach (Control c in this.ModeScreen1.Controls)
                {
                    c.Location = new Point(c.Location.X, -ModeVScrollBar.Value);
                    c.Size = new Size(c.Size.Width, c.Size.Height + ModeVScrollBar.Value);
                }
            }
            if (this.comboBox_Modes.SelectedIndex == 1)
            {
                foreach (Control c in this.ModeScreen2.Controls)
                {
                    c.Location = new Point(c.Location.X, - ModeVScrollBar.Value);
                    c.Size = new Size(c.Size.Width, c.Size.Height + ModeVScrollBar.Value);
                }
            }
            if (this.comboBox_Modes.SelectedIndex == 2)
            {
                foreach (Control c in this.ModeScreen3.Controls)
                {
                    c.Location = new Point(c.Location.X, -ModeVScrollBar.Value);
                    c.Size = new Size(c.Size.Width, c.Size.Height + ModeVScrollBar.Value);
                }
            }
        }

        private void ModeHScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            if (this.comboBox_Modes.SelectedIndex == 0)
            {
                foreach (Control c in this.ModeScreen1.Controls)
                {
                    c.Location = new Point(-ModeHScrollBar.Value, c.Location.Y);
                    c.Size = new Size(c.Size.Width + ModeHScrollBar.Value, c.Size.Height);
                }
            }
            if (this.comboBox_Modes.SelectedIndex == 1)
            {
                foreach (Control c in this.ModeScreen2.Controls)
                {
                    c.Location = new Point(- ModeHScrollBar.Value, c.Location.Y);
                    c.Size = new Size(c.Size.Width + ModeHScrollBar.Value, c.Size.Height);
                }
            }
            if (this.comboBox_Modes.SelectedIndex == 2)
            {
                foreach (Control c in this.ModeScreen3.Controls)
                {
                    c.Location = new Point(-ModeHScrollBar.Value, c.Location.Y);
                    c.Size = new Size(c.Size.Width + ModeHScrollBar.Value, c.Size.Height);
                }
            }
        }

        private void ModeScrollBar_Load(Panel gb, int dx, int dy)
        {
            if (dy - gb.Height > 0)
            {
                this.ModeVScrollBar.Maximum = dy - gb.Height;
            }
            else
            {
                this.ModeVScrollBar.Maximum = 0;
            }
            if (dx - gb.Width > 0)
            {
                this.ModeHScrollBar.Maximum = dx - gb.Width;
            }
            else
            {
                this.ModeHScrollBar.Maximum = 0;
            }
        }

        private void ModeScreen1_Enter(object sender, EventArgs e)
        {
            //this.ModeScreen1.BackColor = Color.FromArgb(60, 255, 0, 0);
        }

        private void ModeScreen2_Enter(object sender, EventArgs e)
        {
            //this.ModeScreen2.BackColor = Color.FromArgb(60, 255, 0, 0);
        }

        private void Mode1Panel_Enter(object sender, EventArgs e)
        {
            //this.Mode1Panel.BackColor = Color.Transparent;
        }

        private void Mode2Panel_Enter(object sender, EventArgs e)
        {
            //this.Mode2Panel.BackColor = Color.FromArgb(0, 255, 0, 0);
        }

        private void ModeScreen3_Enter(object sender, EventArgs e)
        {

        }

        private void ModeScreen4_Enter(object sender, EventArgs e)
        {

        }

        private void LoadButton1_Click(object sender, EventArgs e)
        {

        }

        private void SetButton1_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        //Mode1
        private void Mode1ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (this.Mode1ComboBox1.SelectedIndex != -1)
            {
                mode1Vd1 = ((SubData)this.Mode1ComboBox1.SelectedValue).Umavalue;
                this.setImageToBox(((SubData)this.Mode1ComboBox1.SelectedValue).Umaname, this.Mode1PictureBox1);
            }
            if (mode1Vd2 != null && mode1Vd3 != null)
            {
                this.SetMode1Values();
            }
        }

        private void Mode1ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.Mode1ComboBox2.SelectedIndex != -1)
            {
                mode1Vd2 = ((SubData)this.Mode1ComboBox2.SelectedValue).Umavalue;
                this.setImageToBox(((SubData)this.Mode1ComboBox2.SelectedValue).Umaname, this.Mode1PictureBox2);
            }
            if (mode1Vd1 != null && mode1Vd3 != null)
            {
                this.SetMode1Values();
            }
        }

        private void Mode1ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.Mode1ComboBox3.SelectedIndex != -1)
            {
                mode1Vd3 = ((SubData)this.Mode1ComboBox3.SelectedValue).Umavalue;
                this.setImageToBox(((SubData)this.Mode1ComboBox3.SelectedValue).Umaname, this.Mode1PictureBox3);
            }
            if (mode1Vd1 != null && mode1Vd2 != null)
            {
                this.SetMode1Values();
            }
        }

        private void SetMode1Values()
        {
            int valueAB;
            int valueAC;
            int valueBC;
            int a = mode1Vd1.id;
            int b = mode1Vd2.id;
            int c = mode1Vd3.id;
            if (b > a)
            {
                valueAB = mode1Vd1.valueList[b - a];
            }
            else
            {
                valueAB = mode1Vd2.valueList[a - b];
            }
            if (c > a)
            {
                valueAC = mode1Vd1.valueList[c - a];
            }
            else
            {
                valueAC = mode1Vd3.valueList[a - c];
            }
            if (c > b)
            {
                valueBC = mode1Vd2.valueList[c - b];
            }
            else
            {
                valueBC = mode1Vd3.valueList[b - c];
            }
            this.Mode1Box1Value1.Text = "1与2=" + valueAB.ToString();
            this.Mode1Box1Value2.Text = "1与3=" + valueAC.ToString();
            this.Mode1Box2Value1.Text = "2与1=" + valueAB.ToString();
            this.Mode1Box2Value2.Text = "2与3=" + valueBC.ToString();
            this.Mode1Box3Value1.Text = "3与1=" + valueAC.ToString();
            this.Mode1Box3Value2.Text = "3与2=" + valueBC.ToString();

            this.label1.Text = ((float)(valueAB + valueAC)).ToString();
            this.label2.Text = ((float)((valueAB + valueAC)) / 2).ToString();
            this.label3.Text = ((float)(valueAB + valueAC)).ToString();
            this.label12.Text = ((float)(valueAB + valueAC)).ToString();
            this.label13.Text = ((float)(valueBC)).ToString();
        }

        //Mode2
        private void Mode2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.Mode2ComboBox1.SelectedIndex != -1)
            {
                mode2Vd1 = ((SubData)this.Mode2ComboBox1.SelectedValue).Umavalue;
                this.setImageToBox(((SubData)this.Mode2ComboBox1.SelectedValue).Umaname, this.Mode2PictureBox1);
            }
            if (mode2Vd2 != null && mode2Vd3 != null)
            {
                this.SetMode2Values();
            }
        }

        private void Mode2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.Mode2ComboBox2.SelectedIndex != -1)
            {
                mode2Vd2 = ((SubData)this.Mode2ComboBox2.SelectedValue).Umavalue;
                this.setImageToBox(((SubData)this.Mode2ComboBox2.SelectedValue).Umaname, this.Mode2PictureBox2);
            }
            if (mode2Vd1 != null && mode2Vd3 != null && mode2Vd4 != null && mode2Vd5 != null)
            {
                this.SetMode2Values();
            }
        }

        private void Mode2ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.Mode2ComboBox3.SelectedIndex != -1)
            {
                mode2Vd3 = ((SubData)this.Mode2ComboBox3.SelectedValue).Umavalue;
                this.setImageToBox(((SubData)this.Mode2ComboBox3.SelectedValue).Umaname, this.Mode2PictureBox3);
            }
            if (mode2Vd1 != null && mode2Vd2 != null && mode2Vd6 != null && mode2Vd7 != null)
            {
                this.SetMode2Values();
            }
        }

        private void Mode2ComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.Mode2ComboBox4.SelectedIndex != -1)
            {
                mode2Vd4 = ((SubData)this.Mode2ComboBox4.SelectedValue).Umavalue;
                this.setImageToBox(((SubData)this.Mode2ComboBox4.SelectedValue).Umaname, this.Mode2PictureBox4);
            }
            if (mode2Vd2 != null && mode2Vd5 != null)
            {
                this.SetMode2Values();
            }
        }

        private void Mode2ComboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.Mode2ComboBox5.SelectedIndex != -1)
            {
                mode2Vd5 = ((SubData)this.Mode2ComboBox5.SelectedValue).Umavalue;
                this.setImageToBox(((SubData)this.Mode2ComboBox5.SelectedValue).Umaname, this.Mode2PictureBox5);
            }
            if (mode2Vd2 != null && mode2Vd4 != null)
            {
                this.SetMode2Values();
            }
        }

        private void Mode2ComboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.Mode2ComboBox6.SelectedIndex != -1)
            {
                mode2Vd6 = ((SubData)this.Mode2ComboBox6.SelectedValue).Umavalue;
                this.setImageToBox(((SubData)this.Mode2ComboBox6.SelectedValue).Umaname, this.Mode2PictureBox6);
            }
            if (mode2Vd3 != null && mode2Vd7 != null)
            {
                this.SetMode2Values();
            }
        }

        private void Mode2ComboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.Mode2ComboBox7.SelectedIndex != -1)
            {
                mode2Vd7 = ((SubData)this.Mode2ComboBox7.SelectedValue).Umavalue;
                this.setImageToBox(((SubData)this.Mode2ComboBox7.SelectedValue).Umaname, this.Mode2PictureBox7);
            }
            if (mode2Vd3 != null && mode2Vd6 != null)
            {
                this.SetMode2Values();
            }
        }

        private void SetMode2Values()
        {
            int valueAB;
            int valueAC;
            int valueAD;
            int valueAE;
            int valueAF;
            int valueAG;

            int valueBC;

            int valueBD;
            int valueBE;
            int valueDE;

            int valueCF;
            int valueCG;
            int valueFG;
            
            int a = mode2Vd1.id;
            int b = mode2Vd2.id;
            int c = mode2Vd3.id;
            int d = mode2Vd4.id;
            int e = mode2Vd5.id;
            int f = mode2Vd6.id;
            int g = mode2Vd7.id;

            if (b > a)
            {
                valueAB = mode2Vd1.valueList[b - a];
            }
            else
            {
                valueAB = mode2Vd2.valueList[a - b];
            }
            if (c > a)
            {
                valueAC = mode2Vd1.valueList[c - a];
            }
            else
            {
                valueAC = mode2Vd3.valueList[a - c];
            }
            if (d > a)
            {
                valueAD = mode2Vd1.valueList[d - a];
            }
            else
            {
                valueAD = mode2Vd4.valueList[a - d];
            }
            if (e > a)
            {
                valueAE = mode2Vd1.valueList[e - a];
            }
            else
            {
                valueAE = mode2Vd5.valueList[a - e];
            }
            if (f > a)
            {
                valueAF = mode2Vd1.valueList[f - a];
            }
            else
            {
                valueAF = mode2Vd6.valueList[a - f];
            }
            if (g > a)
            {
                valueAG = mode2Vd1.valueList[g - a];
            }
            else
            {
                valueAG = mode2Vd7.valueList[a - g];
            }


            if (c > b)
            {
                valueBC = mode2Vd2.valueList[c - b];
            }
            else
            {
                valueBC = mode2Vd3.valueList[b - c];
            }


            if (d > b)
            {
                valueBD = mode2Vd2.valueList[d - b];
            }
            else
            {
                valueBD = mode2Vd4.valueList[b - d];
            }
            if (e > b)
            {
                valueBE = mode2Vd2.valueList[e - b];
            }
            else
            {
                valueBE = mode2Vd5.valueList[b - e];
            }
            if (e > d)
            {
                valueDE = mode2Vd4.valueList[e - d];
            }
            else
            {
                valueDE = mode2Vd5.valueList[d - e];
            }


            if (f > c)
            {
                valueCF = mode2Vd3.valueList[f - c];
            }
            else
            {
                valueCF = mode2Vd6.valueList[c - f];
            }
            if (g > c)
            {
                valueCG = mode2Vd3.valueList[g - c];
            }
            else
            {
                valueCG = mode2Vd7.valueList[c - g];
            }
            if (g > f)
            {
                valueFG = mode2Vd6.valueList[g - f];
            }
            else
            {
                valueFG = mode2Vd7.valueList[f - g];
            }

            this.Mode2Box1Value5.Text = "1与2=" + valueAB.ToString();
            this.Mode2Box1Value6.Text = "1与3=" + valueAC.ToString();
            this.Mode2Box1Value2.Text = "1与7=" + valueAG.ToString();
            this.Mode2Box1Value1.Text = "1与6=" + valueAF.ToString();
            this.Mode2Box1Value3.Text = "1与4=" + valueAD.ToString();
            this.Mode2Box1Value4.Text = "1与5=" + valueAE.ToString();

            this.Mode2Box2Value1.Text = "2与1=" + valueAB.ToString();
            this.Mode2Box2Value2.Text = "2与3=" + valueBC.ToString();
            this.Mode2Box2Value3.Text = "2与4=" + valueBD.ToString();
            this.Mode2Box2Value4.Text = "2与5=" + valueBE.ToString();

            this.Mode2Box3Value3.Text = "3与1=" + valueAC.ToString();
            this.Mode2Box3Value4.Text = "3与2=" + valueBC.ToString();
            this.Mode2Box3Value2.Text = "3与7=" + valueCG.ToString();
            this.Mode2Box3Value1.Text = "3与6=" + valueCF.ToString();

            this.Mode2Box4Value1.Text = "4与2=" + valueBD.ToString();
            this.Mode2Box4Value2.Text = "4与5=" + valueDE.ToString();
            this.Mode2Box4Value3.Text = "4与1=" + valueAD.ToString();

            this.Mode2Box5Value3.Text = "5与2=" + valueBE.ToString();
            this.Mode2Box5Value4.Text = "5与4=" + valueDE.ToString();
            this.Mode2Box5Value1.Text = "5与1=" + valueAE.ToString();

            this.Mode2Box6Value1.Text = "6与3=" + valueCF.ToString();
            this.Mode2Box6Value2.Text = "6与7=" + valueFG.ToString();
            this.Mode2Box6Value3.Text = "6与1=" + valueAF.ToString();

            this.Mode2Box7Value3.Text = "7与3=" + valueCG.ToString();
            this.Mode2Box7Value4.Text = "7与6=" + valueFG.ToString();
            this.Mode2Box7Value1.Text = "7与1=" + valueAG.ToString();

            this.label1.Text = ((float)(valueAB + valueAC + valueBD + valueBE + valueCF + valueCG)).ToString();
            this.label2.Text = ((float)((valueAB + valueAC + valueAD + valueAE + valueAF + valueAG)) / 6).ToString();
            this.label3.Text = ((float)(valueAB + valueAC)).ToString();
            this.label8.Text = ((float)(valueBD + valueBE)).ToString();
            this.label10.Text = ((float)(valueCF + valueCG)).ToString();
            this.label12.Text = ((float)(valueAB + valueAC + valueAD + valueAE + valueAF + valueAG)).ToString();
            this.label13.Text = ((float)(valueBC)).ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Mode1Value2a_Click(object sender, EventArgs e)
        {

        }

        private void CalculateButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private class Position2
        {
            public int A = 0;
            public int B = 0;
            public int C = 0;
            public int D = 0;
            public int E = 0;
            public int F = 0;
            public int G = 0;

            public string getPosition(int pos)
            {
                if (pos== 0)
                {
                    return "A";
                }
                if (pos== 1)
                {
                    return "B";
                }
                if (pos== 2)
                {
                    return "C";
                }
                if (pos== 3)
                {
                    return "D";
                }
                if (pos== 4)
                {
                    return "E";
                }
                if (pos== 5)
                {
                    return "F";
                }
                if (pos== 6)
                {
                    return "G";
                }
                return "Null";
            }
            public List<int> getList()
            {
                List<int> l =  new List<int> { 0,0,0,0,0,0,0};
                if (A != 0)
                {
                    l[0] = A;
                }
                if (B != 0)
                {
                    l[1] = B;
                }
                if (C != 0)
                {
                    l[2] = C;
                }
                if (D != 0)
                {
                    l[3] = D;
                }
                if (E != 0)
                {
                    l[4] = E;
                }
                if (F != 0)
                {
                    l[5] = F;
                }
                if (G != 0)
                {
                    l[6] = G;
                }
                return l;
            }
            public int getABC(List<SubData> data)
            {
                if (A != 0 && B != 0 && C != 0)
                {
                    int ab;
                    int ac;
                    if (A > B)
                    {
                        ab = data.Find(delegate (SubData sd) { return sd.value.id == B; }).value.valueList[A - B];
                    }
                    else
                    {
                        ab = data.Find(delegate (SubData sd) { return sd.value.id == A; }).value.valueList[B - A];
                    }
                    if (A > C)
                    {
                        ac = data.Find(delegate (SubData sd) { return sd.value.id == C; }).value.valueList[A - C];
                    }
                    else
                    {
                        ac = data.Find(delegate (SubData sd) { return sd.value.id == A; }).value.valueList[C - A];
                    }
                    return ab + ac;
                }
                return 0;
            }
            public int getBDE(List<SubData> data)
            {
                if (B != 0 && D != 0 && E != 0)
                {
                    int bd;
                    int be;
                    if (B > D)
                    {
                        bd = data.Find(delegate (SubData sd) { return sd.value.id == D; }).value.valueList[B - D];
                    }
                    else
                    {
                        bd = data.Find(delegate (SubData sd) { return sd.value.id == B; }).value.valueList[D - B];
                    }
                    if (B > E)
                    {
                        be = data.Find(delegate (SubData sd) { return sd.value.id == E; }).value.valueList[B - E];
                    }
                    else
                    {
                        be = data.Find(delegate (SubData sd) { return sd.value.id == B; }).value.valueList[E - B];
                    }
                    return bd + be;
                }
                return 0;
            }
            public int getCFG(List<SubData> data)
            {
                if (C != 0 && F != 0 && G != 0)
                {
                    int cf;
                    int cg;
                    if (C > F)
                    {
                        cf = data.Find(delegate (SubData sd) { return sd.value.id == F; }).value.valueList[C - F];
                    }
                    else
                    {
                        cf = data.Find(delegate (SubData sd) { return sd.value.id == C; }).value.valueList[F - C];
                    }
                    if (C > G)
                    {
                        cg = data.Find(delegate (SubData sd) { return sd.value.id == G; }).value.valueList[C - G];
                    }
                    else
                    {
                        cg = data.Find(delegate (SubData sd) { return sd.value.id == C; }).value.valueList[G - C];
                    }
                    return cf + cg;
                }
                return 0;
            }
            public float getAALLA(List<SubData> data)
            {
                if (A != 0 && B != 0 && C != 0 && D != 0 && E != 0 && F != 0 && G != 0)
                {
                    int ab;
                    int ac;
                    int ad;
                    int ae;
                    int af;
                    int ag;
                    if (A > B)
                    {
                        ab = data.Find(delegate (SubData sd) { return sd.value.id == B; }).value.valueList[A - B];
                    }
                    else
                    {
                        ab = data.Find(delegate (SubData sd) { return sd.value.id == A; }).value.valueList[B - A];
                    }
                    if (A > C)
                    {
                        ac = data.Find(delegate (SubData sd) { return sd.value.id == C; }).value.valueList[A - C];
                    }
                    else
                    {
                        ac = data.Find(delegate (SubData sd) { return sd.value.id == A; }).value.valueList[C - A];
                    }
                    if (A > D)
                    {
                        ad = data.Find(delegate (SubData sd) { return sd.value.id == D; }).value.valueList[A - D];
                    }
                    else
                    {
                        ad = data.Find(delegate (SubData sd) { return sd.value.id == A; }).value.valueList[D - A];
                    }
                    if (A > E)
                    {
                        ae = data.Find(delegate (SubData sd) { return sd.value.id == E; }).value.valueList[A - E];
                    }
                    else
                    {
                        ae = data.Find(delegate (SubData sd) { return sd.value.id == A; }).value.valueList[E - A];
                    }
                    if (A > F)
                    {
                        af = data.Find(delegate (SubData sd) { return sd.value.id == F; }).value.valueList[A - F];
                    }
                    else
                    {
                        af = data.Find(delegate (SubData sd) { return sd.value.id == A; }).value.valueList[F - A];
                    }
                    if (A > G)
                    {
                        ag = data.Find(delegate (SubData sd) { return sd.value.id == G; }).value.valueList[A - G];
                    }
                    else
                    {
                        ag = data.Find(delegate (SubData sd) { return sd.value.id == A; }).value.valueList[G - A];
                    }
                    return ((float)(ab + ac + ad + ae + af + ag)) / 6;
                }
                return 0;
            }
            public int getALL(List<SubData> data)
            {
                return this.getABC(data) + this.getBDE(data) + this.getCFG(data);
            }
            public int getAALL(List<SubData> data)
            {
                if (A != 0 && B != 0 && C != 0 && D != 0 && E != 0 && F != 0 && G != 0)
                {
                    int ab;
                    int ac;
                    int ad;
                    int ae;
                    int af;
                    int ag;
                    if (A > B)
                    {
                        ab = data.Find(delegate (SubData sd) { return sd.value.id == B; }).value.valueList[A - B];
                    }
                    else
                    {
                        ab = data.Find(delegate (SubData sd) { return sd.value.id == A; }).value.valueList[B - A];
                    }
                    if (A > C)
                    {
                        ac = data.Find(delegate (SubData sd) { return sd.value.id == C; }).value.valueList[A - C];
                    }
                    else
                    {
                        ac = data.Find(delegate (SubData sd) { return sd.value.id == A; }).value.valueList[C - A];
                    }
                    if (A > D)
                    {
                        ad = data.Find(delegate (SubData sd) { return sd.value.id == D; }).value.valueList[A - D];
                    }
                    else
                    {
                        ad = data.Find(delegate (SubData sd) { return sd.value.id == A; }).value.valueList[D - A];
                    }
                    if (A > E)
                    {
                        ae = data.Find(delegate (SubData sd) { return sd.value.id == E; }).value.valueList[A - E];
                    }
                    else
                    {
                        ae = data.Find(delegate (SubData sd) { return sd.value.id == A; }).value.valueList[E - A];
                    }
                    if (A > F)
                    {
                        af = data.Find(delegate (SubData sd) { return sd.value.id == F; }).value.valueList[A - F];
                    }
                    else
                    {
                        af = data.Find(delegate (SubData sd) { return sd.value.id == A; }).value.valueList[F - A];
                    }
                    if (A > G)
                    {
                        ag = data.Find(delegate (SubData sd) { return sd.value.id == G; }).value.valueList[A - G];
                    }
                    else
                    {
                        ag = data.Find(delegate (SubData sd) { return sd.value.id == A; }).value.valueList[G - A];
                    }
                    return (ab + ac + ad + ae + af + ag);
                }
                return 0;
            }
            public int getBC(List<SubData> data)
            {
                if (B != 0 && C != 0)
                {
                    int bc;
                    if (C > B)
                    {
                        bc = data.Find(delegate (SubData sd) { return sd.value.id == B; }).value.valueList[C - B];
                    }
                    else
                    {
                        bc = data.Find(delegate (SubData sd) { return sd.value.id == C; }).value.valueList[B - C];
                    }
                    return bc;
                }
                return 0;
            }

            public bool CheckEqual(Position2 pos)
            {
                List<int> DE = new List<int> { D, E};
                List<int> FG = new List<int> { F, G};
                if (pos.A == A)
                {
                    if (pos.B == B && pos.C == C)
                    {
                        if ((DE.Contains(pos.D) && DE.Contains(pos.E)) && (FG.Contains(pos.F) && FG.Contains(pos.G)))
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else if (pos.B == C && pos.C == B)
                    {
                        if ((DE.Contains(pos.F) && DE.Contains(pos.G)) && (FG.Contains(pos.D) && FG.Contains(pos.E)))
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                        
                }
                else
                {
                    return false;
                }
            }
        }

        private class Thresholds
        {
            public int ABC = 0;
            public int BDE = 0;
            public int CFG = 0;
            public int AALL = 0;
            public float AALLA = 0;
            public int ALL = 0;
        }

        private class ArgData
        {
            public List<ComboBox> none = new List<ComboBox>();
            public List<SubData> data = new List<SubData>();
            public List<SubData> dataA = new List<SubData>();
            public List<SubData> dataB = new List<SubData>();
            public List<SubData> dataC = new List<SubData>();
            public List<SubData> dataD = new List<SubData>();
            public List<SubData> dataE = new List<SubData>();
            public List<SubData> dataF = new List<SubData>();
            public List<SubData> dataG = new List<SubData>();
            public Dictionary<Position2, Thresholds> record = new Dictionary<Position2, Thresholds>();
        }

        private Dictionary<string, List<string>> plans = new Dictionary<string, List<string>>();

        private Dictionary<string, List<int>> plansID = new Dictionary<string, List<int>>();

        private Dictionary<Position2, Thresholds> recordMode2 = new Dictionary<Position2, Thresholds>();

        private void CalculateButton2_Click(object sender, EventArgs e)
        {
            List<ComboBox> none = new List<ComboBox>();
            List<ComboBox> cbs = new List<ComboBox>();
            if (comboBox_Modes.SelectedIndex == 0)
            {
                foreach (Control cb in this.Mode1Panel.Controls)
                {
                    if ((cb is ComboBox))
                    {
                        if ((cb as ComboBox).SelectedIndex == -1)
                        {
                            none.Add((ComboBox)cb);
                        }
                        else
                        {
                            cbs.Add((cb as ComboBox));
                        }
                    }
                }
            }
            if (comboBox_Modes.SelectedIndex == 1)
            {
                foreach (Control cb in this.Mode2Panel.Controls)
                {
                    if ((cb is ComboBox))
                    {
                        if ((cb as ComboBox).SelectedIndex == -1)
                        {
                            none.Add((ComboBox)cb);
                        }
                        else
                        {
                            cbs.Add((cb as ComboBox));
                        }
                    }
                }
            }
            if (this.comboBox_Modes.SelectedIndex == 2)
            {
                foreach (Control cb in this.Mode3Panel.Controls)
                {
                    if ((cb is ComboBox))
                    {
                        if ((cb as ComboBox).SelectedIndex == -1)
                        {
                            none.Add((ComboBox)cb);
                        }
                        else
                        {
                            cbs.Add((cb as ComboBox));
                        }
                    }
                }
            }

            if (none.Count > 4 && this.radioMode1.Checked)
            {
                if (MessageBox.Show("检测到当前为模式一并且补算空位大于4，补算后大概率卡死，是否继续？", "确认信息", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                {
                    return;
                }
            }
            if (none.Count > 3 && this.radioMode2.Checked)
            {
                if (MessageBox.Show("检测到当前为模式二并且补算空位大于3，补算后大概率卡死，如需补算3位以上5位以下时，建议使用模式一，是否继续？", "确认信息", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                {
                    return;
                }
                /*else
                {
                    if (none.Count > 4)
                    {
                        if (MessageBox.Show("检测到当前空位大于4！请至少填三位马娘再点补算！点击‘是’将自动填充合适的马娘于空位", "确认信息", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.OK)
                        {
                            return;
                        }
                    }

                    this.AutoInput(none, cbs);
                    return;

                }*/
            }
            if (!CheckForm2BeAble() && this.radioMode1.Checked)
            {
                if (MessageBox.Show("检测到当前为模式一并且阈值中存在不形成区间的最小值与最大值，请进行调整后再补算", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                {
                    return;
                }
            }
            if (none.Count < 1)
            {
                return;
            }

            List<SubData> data = new MainLoad().sourceList.Find(delegate (Source s) { return s.Source_name == (string)this.comboBox_Data.SelectedValue; }).listA;

            if (comboBox_Modes.SelectedIndex == 0)
            {
                if (none.Count == 1)
                {
                    Dictionary<int, int> record = new Dictionary<int, int>();
                    List<ComboBox> list = new List<ComboBox>();
                    foreach (ComboBox ct in cbs)
                    {
                        foreach (ComboBox cr in cbs)
                        {
                            if (!list.Contains(cr))
                            {
                                int b = ((SubData)ct.SelectedValue).value.id;
                                int c = ((SubData)cr.SelectedValue).value.id;
                                if (b != c)
                                {
                                    for (int i = 1; i <= data.Count; i++)
                                    {
                                        if (i != b && i != c)
                                        {
                                            int ib = 0;
                                            int ic = 0;
                                            int bc = 0;
                                            if (i > b)
                                            {
                                                ib = data.Find(delegate (SubData sd) { return sd.value.id == b; }).value.valueList[i - b];
                                            }
                                            else
                                            {
                                                ib = data.Find(delegate (SubData sd) { return sd.value.id == i; }).value.valueList[b - i];
                                            }
                                            if (i > c)
                                            {
                                                ic = data.Find(delegate (SubData sd) { return sd.value.id == c; }).value.valueList[i - c];
                                            }
                                            else
                                            {
                                                ic = data.Find(delegate (SubData sd) { return sd.value.id == i; }).value.valueList[c - i];
                                            }
                                            if (b > c)
                                            {
                                                bc = data.Find(delegate (SubData sd) { return sd.value.id == c; }).value.valueList[b - c];
                                            }
                                            else
                                            {
                                                bc = data.Find(delegate (SubData sd) { return sd.value.id == b; }).value.valueList[c - b];
                                            }
                                            if (ct.Tag == (object)"1A")
                                            {
                                                record.Add(i, ib + bc);
                                            }
                                            else
                                            {
                                                if (cr.Tag == (object)"1A")
                                                {
                                                    record.Add(i, ic + bc);
                                                }
                                                else
                                                {
                                                    record.Add(i, ib + ic);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        list.Add(ct);
                    }
                    plans.Clear();
                    List<int> ids = new List<int>();
                    foreach (KeyValuePair<int, int> max in record)
                    {
                        if (max.Value == record.Values.Max())
                        {
                            ids.Add(max.Key);
                            List<string> names = new List<string>();
                            names.Add(data.Find(delegate (SubData sd) { return sd.value.id == max.Key; }).Umaname);
                            plans.Add("Plan" + (plans.Count + 1).ToString(), names);
                        }
                    }
                    this.OtherPlan.DataSource = plans.Keys.ToList();
                    this.OtherPlanInfo.DataSource = plans[(string)this.OtherPlan.SelectedValue];
                    foreach (ComboBox cb in none)
                    {
                        cb.SelectedIndex = ids[0] - 1;
                    }
                    return;
                }

                if (none.Count == 2)
                {
                    Dictionary<Position2, int> record = new Dictionary<Position2, int>();
                    List<SubData> list = new List<SubData>();
                    foreach (ComboBox cr in cbs)
                    {
                        int c = ((SubData)cr.SelectedValue).value.id;
                        foreach (SubData sd1 in data)
                        {
                            int s1 = sd1.value.id;
                            foreach (SubData sd2 in data)
                            {
                                if (!list.Contains(sd2))
                                {
                                    int s2 = sd2.value.id;
                                    if (s1 != s2 && s1 != c && s2 != c)
                                    {
                                        int cs1 = 0;
                                        int cs2 = 0;
                                        int s1s2 = 0;
                                        if (s1 > c)
                                        {
                                            cs1 = data.Find(delegate (SubData sd) { return sd.value.id == c; }).value.valueList[s1 - c];
                                        }
                                        else
                                        {
                                            cs1 = sd1.value.valueList[c - s1];
                                        }
                                        if (s2 > c)
                                        {
                                            cs2 = data.Find(delegate (SubData sd) { return sd.value.id == c; }).value.valueList[s2 - c];
                                        }
                                        else
                                        {
                                            cs2 = sd2.value.valueList[c - s2];
                                        }
                                        if (s2 > s1)
                                        {
                                            s1s2 = sd1.value.valueList[s2 - s1];
                                        }
                                        else
                                        {
                                            s1s2 = sd2.value.valueList[s1 - s2];
                                        }
                                        if (cr.Tag == (object)"1A")
                                        {
                                            Position2 pos = new Position2();
                                            pos.B = s1;
                                            pos.C = s2;
                                            if (!record.ContainsKey(pos))
                                            {
                                                record.Add(pos, cs1 + cs2);
                                            }
                                        }
                                        else
                                        {
                                            Position2 pos = new Position2();
                                            pos.A = s1;
                                            pos.B = s2;
                                            if (!record.ContainsKey(pos))
                                            {
                                                record.Add(pos, cs1 + s1s2);
                                            }
                                            Position2 pos2 = new Position2();
                                            pos2.A = s2;
                                            pos2.B = s1;
                                            if (!record.ContainsKey(pos2))
                                            {
                                                record.Add(pos2, cs2 + s1s2);
                                            }
                                        }
                                    }
                                }
                            }
                            list.Add(sd1);
                        }
                    }
                    plans.Clear();
                    List<Position2> ids = new List<Position2>();

                    foreach (KeyValuePair<Position2, int> max in record)
                    {
                        if (max.Value == record.Values.Max())
                        {
                            ids.Add(max.Key);
                            List<string> names = new List<string>();
                            foreach (int num in max.Key.getList())
                            {
                                if (num != 0)
                                {
                                    names.Add(data.Find(delegate (SubData sd) { return sd.value.id == num; }).Umaname);
                                }
                            }
                            plans.Add("Plan" + (plans.Count + 1).ToString(), names);
                        }
                    }
                    this.OtherPlan.DataSource = plans.Keys.ToList();
                    this.OtherPlanInfo.DataSource = plans[(string)this.OtherPlan.SelectedValue];
                    if (cbs.First().Tag == (object)"1A")
                    {
                        List<int> li = ids[0].getList();
                        li.RemoveAll(delegate (int n) { return n == 0; });
                        for (int i = 0; i < none.Count; i++)
                        {
                            none[i].SelectedIndex = li[i] - 1;
                        }
                    }
                    else
                    {
                        for (int i = 0; i < none.Count; i++)
                        {
                            if (none[i].Tag == (object)"1A")
                            {
                                none[i].SelectedIndex = ids[0].A - 1;
                            }
                            if (none[i].Tag == (object)"1B")
                            {
                                none[i].SelectedIndex = ids[0].B - 1;
                            }
                            if (none[i].Tag == (object)"1C")
                            {
                                none[i].SelectedIndex = ids[0].B - 1;
                            }
                        }
                    }
                    return;
                }

            }
            if (this.comboBox_Modes.SelectedIndex == 1)
            {
                List<SubData> dataA = new List<SubData>();
                List<SubData> dataB = new List<SubData>();
                List<SubData> dataC = new List<SubData>();
                List<SubData> dataD = new List<SubData>();
                List<SubData> dataE = new List<SubData>();
                List<SubData> dataF = new List<SubData>();
                List<SubData> dataG = new List<SubData>();
                if (cbs.Exists(delegate (ComboBox cb) { return cb.Tag == (object)"2A"; }))
                {
                    dataA.Clear();
                    dataA.Add((SubData)cbs.Find(delegate (ComboBox cb) { return cb.Tag == (object)"2A"; }).SelectedValue);
                }
                else
                {
                    dataA = data;
                }
                if (cbs.Exists(delegate (ComboBox cb) { return cb.Tag == (object)"2B"; }))
                {
                    dataB.Clear();
                    dataB.Add((SubData)cbs.Find(delegate (ComboBox cb) { return cb.Tag == (object)"2B"; }).SelectedValue);
                }
                else
                {
                    dataB = data;
                }
                if (cbs.Exists(delegate (ComboBox cb) { return cb.Tag == (object)"2C"; }))
                {
                    dataC.Clear();
                    dataC.Add((SubData)cbs.Find(delegate (ComboBox cb) { return cb.Tag == (object)"2C"; }).SelectedValue);
                }
                else
                {
                    dataC = data;
                }
                if (cbs.Exists(delegate (ComboBox cb) { return cb.Tag == (object)"2D"; }))
                {
                    dataD.Clear();
                    dataD.Add((SubData)cbs.Find(delegate (ComboBox cb) { return cb.Tag == (object)"2D"; }).SelectedValue);
                }
                else
                {
                    dataD = data;
                }
                if (cbs.Exists(delegate (ComboBox cb) { return cb.Tag == (object)"2E"; }))
                {
                    dataE.Clear();
                    dataE.Add((SubData)cbs.Find(delegate (ComboBox cb) { return cb.Tag == (object)"2E"; }).SelectedValue);
                }
                else
                {
                    dataE = data;
                }
                if (cbs.Exists(delegate (ComboBox cb) { return cb.Tag == (object)"2F"; }))
                {
                    dataF.Clear();
                    dataF.Add((SubData)cbs.Find(delegate (ComboBox cb) { return cb.Tag == (object)"2F"; }).SelectedValue);
                }
                else
                {
                    dataF = data;
                }
                if (cbs.Exists(delegate (ComboBox cb) { return cb.Tag == (object)"2G"; }))
                {
                    dataG.Clear();
                    dataG.Add((SubData)cbs.Find(delegate (ComboBox cb) { return cb.Tag == (object)"2G"; }).SelectedValue);
                }
                else
                {
                    dataG = data;
                }

                ArgData dataArg = new ArgData();
                dataArg.none = none;
                dataArg.data = data;
                dataArg.dataA = dataA;
                dataArg.dataB = dataB;
                dataArg.dataC = dataC;
                dataArg.dataD = dataD;
                dataArg.dataE = dataE;
                dataArg.dataF = dataF;
                dataArg.dataG = dataG;

                this.CancelButton1.Enabled = true;
                this.recordMode2.Clear();
                this.progressBar1.Maximum = dataA.Count * dataB.Count * dataC.Count * dataD.Count * dataE.Count * dataF.Count * dataG.Count;
                this.BackGroundCalculateWorker1.RunWorkerAsync(dataArg);
                this.CalculateButton2.Enabled = false;

            }
            if (this.comboBox_Modes.SelectedIndex == 2)
            {

            }
        }

        private void AutoInput(List<ComboBox> none, List<ComboBox> cbs)
        {
            /*foreach (ComboBox n in none)
            {
                if (n.Tag != (object)"2A")
                {
                    if (n.Tag == (object)"2B" || n.Tag == (object)"2D" || n.Tag == (object)"2E")
                    {
                        for (int m = 0; m < cbs.Count; m++)
                        {
                            if (cbs[m].Tag != (object)"2A")
                            {
                                if ((cbs[m].Tag == (object)"2C" || cbs[m].Tag == (object)"2F" || cbs[m].Tag == (object)"2G"))
                                {
                                    if (m - 1 < 0)
                                    {
                                        if (cbs[m].SelectedIndex != cbs[m+1].SelectedIndex && cbs[m].SelectedIndex != cbs[m + 2].SelectedIndex)
                                        {
                                            n.SelectedIndex = cbs[m].SelectedIndex;
                                            return;
                                        }
                                        else
                                        {

                                        }
                                    }
                                    if (m + 1 > 2)
                                    {
                                        if (cbs[m].SelectedIndex != cbs[m - 1].SelectedIndex && cbs[m].SelectedIndex != cbs[m - 2].SelectedIndex)
                                        {
                                            n.SelectedIndex = cbs[m].SelectedIndex;
                                            return;
                                        }
                                        else
                                        {

                                        }
                                    }
                                    
                                }
                            }
                        }
                    }
                }
            }*/

        }

        private void Clear1A_Click(object sender, EventArgs e)
        {
            this.Mode1ComboBox1.SelectedIndex = -1;
        }

        private void Clear1B_Click(object sender, EventArgs e)
        {
            this.Mode1ComboBox2.SelectedIndex = -1;
        }

        private void Clear1C_Click(object sender, EventArgs e)
        {
            this.Mode1ComboBox3.SelectedIndex = -1;
        }

        private void Clear2A_Click(object sender, EventArgs e)
        {
            this.Mode2ComboBox1.SelectedIndex = -1;
        }

        private void Clear2B_Click(object sender, EventArgs e)
        {
            this.Mode2ComboBox2.SelectedIndex = -1;
        }

        private void Clear2C_Click(object sender, EventArgs e)
        {
            this.Mode2ComboBox3.SelectedIndex = -1;
        }

        private void Clear2D_Click(object sender, EventArgs e)
        {
            this.Mode2ComboBox4.SelectedIndex = -1;
        }

        private void Clear2E_Click(object sender, EventArgs e)
        {
            this.Mode2ComboBox5.SelectedIndex = -1;
        }

        private void Clear2F_Click(object sender, EventArgs e)
        {
            this.Mode2ComboBox6.SelectedIndex = -1;
        }

        private void Clear2G_Click(object sender, EventArgs e)
        {
            this.Mode2ComboBox7.SelectedIndex = -1;
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }


        private class RecordDataLists
        {
            public List<Position2> ids = new List<Position2>();
            public List<int> maxABC = new List<int>();
            public List<int> maxBDE = new List<int>();
            public List<int> maxCFG = new List<int>();
            public List<float> maxAALLA = new List<float>();
            public Dictionary<Position2, Thresholds> record = new Dictionary<Position2, Thresholds>();
            public List<ComboBox> none = new List<ComboBox>();
            public List<SubData> data = new List<SubData>();
            public int TnumABC = 50;
            public int TnumAALLAmin = 20;
            public int TnumAALLAmax = 25;
            public int TnumBorCmin = 40;
            public int TnumBorCmax = 45;
        }

        private void BackGroundCalculateWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bgWorker = sender as BackgroundWorker;
            ArgData data = new ArgData();
            if (e.Argument != null)
            {
                data = (ArgData)e.Argument;
            }

            List<SubData> dataA = data.dataA;
            List<SubData> dataB = data.dataB;
            List<SubData> dataC = data.dataC;
            List<SubData> dataD = data.dataD;
            List<SubData> dataE = data.dataE;
            List<SubData> dataF = data.dataF;
            List<SubData> dataG = data.dataG;

            Dictionary<Position2, Thresholds> record = new Dictionary<Position2, Thresholds>();

            int process = 0;

            foreach (SubData sdA in dataA)
            {
                foreach (SubData sdB in dataB)
                {
                    foreach (SubData sdD in dataD)
                    {
                        foreach (SubData sdE in dataE)
                        {
                            int av = sdA.value.id;
                            int bv = sdB.value.id;
                            int dv = sdD.value.id;
                            int ev = sdE.value.id;
                            if (av != bv && av != dv && av != ev && bv != dv && bv != ev && dv != ev)
                            {
                                foreach (SubData sdC in dataC)
                                {
                                    foreach (SubData sdF in dataF)
                                    {
                                        foreach (SubData sdG in dataG)
                                        {
                                            int cv = sdC.value.id;
                                            int fv = sdF.value.id;
                                            int gv = sdG.value.id;
                                            List<int> cfg = new List<int> { cv, fv, gv };
                                            if ((av != cv && av != fv && av != gv && bv != cv && cv != fv && cv != gv && fv != gv) && !(cfg.Contains(bv) && cfg.Contains(dv) && cfg.Contains(ev)))
                                            {
                                                Position2 pos = new Position2();
                                                pos.A = av;
                                                pos.B = bv;
                                                pos.C = cv;
                                                pos.D = dv;
                                                pos.E = ev;
                                                pos.F = fv;
                                                pos.G = gv;
                                                Thresholds thold = new Thresholds();
                                                thold.ABC = pos.getABC(data.data);
                                                thold.BDE = pos.getBDE(data.data);
                                                thold.CFG = pos.getCFG(data.data);
                                                thold.AALL = pos.getAALL(data.data);
                                                thold.AALLA = pos.getAALLA(data.data);
                                                thold.ALL = pos.getALL(data.data);
                                                record.Add(pos, thold);
                                            }
                                            process++;
                                            bgWorker.ReportProgress(process);
                                            if (bgWorker.CancellationPending == true)
                                            {
                                                e.Cancel = true;
                                                e.Result = null;
                                                return;
                                            }
                                        }
                                    }
                                }
                            }
                            else
                            {
                                process  = process + (dataC.Count * dataF.Count * dataG.Count);
                                bgWorker.ReportProgress(process);
                                if (bgWorker.CancellationPending == true)
                                {
                                    e.Cancel = true;
                                    e.Result = null;
                                    return;
                                }
                            }
                        }
                    }
                }
            }
            data.record = record;
            e.Result = data;
        }

        private void BackGroundCalculateWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.progressBar1.Value = e.ProgressPercentage;     
            
        }

        private void BackGroundCalculateWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                this.CancelButton1.Enabled = false;
                List<ComboBox> none = new List<ComboBox>();
                List<SubData> data = new List<SubData>();
                Dictionary<Position2, Thresholds> record = new Dictionary<Position2, Thresholds>();

                if (e.Result != null)
                {
                    record = ((ArgData)e.Result).record;
                    none = ((ArgData)e.Result).none;
                    data = ((ArgData)e.Result).data;
                }

                if (record.Count >= 1 && data.Count >= 1 && none.Count >= 1)
                {
                    if (this.radioMode1.Checked)
                    {
                        RecordDataLists rdl = new RecordDataLists();
                        rdl.record = record;
                        rdl.none = none;
                        rdl.data = data;
                        rdl.TnumABC = this.TABC;
                        rdl.TnumAALLAmax = this.TAALLAmax;
                        rdl.TnumAALLAmin = this.TAALLAmin;
                        rdl.TnumBorCmax = this.TBCmax;
                        rdl.TnumBorCmin = this.TBCmin;
                        this.CancelButton1.Enabled = true;
                        this.progressBar1.Maximum = record.Count;
                        this.BackgroundCalculateWorker4.RunWorkerAsync(rdl);
                    }
                    if (this.radioMode2.Checked)
                    {
                        RecordDataLists rdl = new RecordDataLists();
                        rdl.record = record;
                        rdl.none = none;
                        rdl.data = data;
                        this.CancelButton1.Enabled = true;
                        this.progressBar1.Maximum = record.Count * 2;
                        this.BackgroundCalculateWorker5.RunWorkerAsync(rdl);
                    }
                }
            }
            else
            {
                this.progressBar1.Value = 0;
                this.progressBar1.Maximum = 0;
                this.CalculateButton2.Enabled = true;
                this.CancelButton1.Enabled = false;
            }
        }




        private void BackgroundCalculateWorker4_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bgWorker = sender as BackgroundWorker;
            int process = 0;
            RecordDataLists rdl = new RecordDataLists();
            Dictionary<Position2, Thresholds> record = new Dictionary<Position2, Thresholds>();
            if (e.Argument != null)
            {
                rdl = (RecordDataLists)e.Argument;
                record = rdl.record;
            }
            List<Position2> ids = new List<Position2>();
            List<int> maxABC = new List<int>();
            List<int> maxBDE = new List<int>();
            List<int> maxCFG = new List<int>();
            List<int> maxALL = new List<int>();
            List<float> maxAALLA = new List<float>();
            List<Position2> maxs = new List<Position2>();
            foreach (KeyValuePair<Position2, Thresholds> max in record)
            {
                if (max.Value.ABC >= rdl.TnumABC)
                {
                    int sum = max.Value.BDE + max.Value.CFG;
                    if (max.Value.AALLA >= rdl.TnumAALLAmin && max.Value.AALLA < rdl.TnumAALLAmax)
                    {
                        if (sum >= (rdl.TnumBorCmax + rdl.TnumBorCmin))
                        {
                            if ((max.Value.BDE >= rdl.TnumBorCmin && max.Value.CFG >= rdl.TnumBorCmax) || (max.Value.BDE >= rdl.TnumBorCmax && max.Value.CFG >= rdl.TnumBorCmin))
                            {
                                if (checkBox4.Checked)
                                {
                                    if (!ids.Exists(delegate (Position2 pos) { return pos.CheckEqual(max.Key); }))
                                    {
                                        ids.Add(max.Key);
                                    }
                                }
                                else
                                {
                                    ids.Add(max.Key);
                                }
                            }
                        }
                    }
                    else if (max.Value.AALLA >= rdl.TnumAALLAmax)
                    {
                        if (sum >= (rdl.TnumBorCmin * 2))
                        {
                            if (max.Value.BDE >= rdl.TnumBorCmin && max.Value.CFG >= rdl.TnumBorCmin)
                            {
                                if (this.checkBox4.Checked)
                                {
                                    if (!ids.Exists(delegate (Position2 pos) { return pos.CheckEqual(max.Key); }))
                                    {
                                        ids.Add(max.Key);
                                    }
                                }
                                else
                                {
                                    ids.Add(max.Key);
                                }
                            }
                        }
                    }
                }
                maxABC.Add(max.Value.ABC);
                maxBDE.Add(max.Value.BDE);
                maxCFG.Add(max.Value.CFG);
                maxAALLA.Add(max.Value.AALLA);
                process++;
                bgWorker.ReportProgress(process);
                if (bgWorker.CancellationPending == true)
                {
                    e.Cancel = true;
                    e.Result = null;
                    return;
                }
            }
            
            rdl.ids = ids;
            rdl.maxABC = maxABC;
            rdl.maxBDE = maxBDE;
            rdl.maxCFG = maxCFG;
            rdl.maxAALLA = maxAALLA;
            e.Result = rdl;
        }

        private void BackgroundCalculateWorker4_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.progressBar1.Value = e.ProgressPercentage;
        }

        private void BackgroundCalculateWorker4_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                RecordDataLists rdl = new RecordDataLists();
                List<Position2> ids = new List<Position2>();
                List<ComboBox> none = new List<ComboBox>();
                List<SubData> data = new List<SubData>();
                if (e.Result != null)
                {
                    rdl = (RecordDataLists)e.Result;
                }
                ids = rdl.ids;
                none = rdl.none;
                data = rdl.data;

                if (ids.Count < 1)
                {
                    this.CancelButton1.Enabled = true;
                    this.progressBar1.Maximum = rdl.record.Count;
                    this.BackgroundCalculateWorker6.RunWorkerAsync(rdl);
                }
                else
                {
                    if (this.radioButton1.Checked)
                    {
                        ids.Sort((a, b) => b.getALL(data) - a.getALL(data));
                    }
                    else if (this.radioButton2.Checked)
                    {
                        ids.Sort((a, b) => (int)b.getAALLA(data) - (int)a.getAALLA(data));
                    }
                    else if (this.radioButton3.Checked)
                    {
                        ids.Sort((a, b) => b.getABC(data) - a.getABC(data));
                    }
                    else if (this.radioButton4.Checked)
                    {
                        ids.Sort((a, b) => b.getBDE(data) - a.getBDE(data));
                    }
                    else if (this.radioButton5.Checked)
                    {
                        ids.Sort((a, b) => b.getCFG(data) - a.getCFG(data));
                    }
                    else if (this.radioButton6.Checked)
                    {
                        ids.Sort((a, b) => b.getAALL(data) - a.getAALL(data));
                    }
                    else if (this.radioButton7.Checked)
                    {
                        ids.Sort((a, b) => b.getBC(data) - a.getBC(data));
                    }

                    plans.Clear();
                    plansID.Clear();
                    IdsData id = new IdsData();
                    id.ids = ids;
                    id.data = data;
                    id.none = none;
                    this.CancelButton1.Enabled = true;
                    this.progressBar1.Maximum = ids.Count;
                    this.BackgroundCalculateWorker7.RunWorkerAsync(id);
                }
            }
            else
            {
                this.progressBar1.Value = 0;
                this.progressBar1.Maximum = 0;
                this.CalculateButton2.Enabled = true;
                this.CancelButton1.Enabled = false;
            }
        }




        private void BackgroundCalculateWorker5_DoWork(object sender, DoWorkEventArgs e)
        {

            BackgroundWorker bgWorker = sender as BackgroundWorker;
            int process = 0;
            RecordDataLists rdl = new RecordDataLists();
            Dictionary<Position2, Thresholds> record = new Dictionary<Position2, Thresholds>();
            List<Position2> ids = new List<Position2>();
            List<int> maxABC = new List<int>();
            List<int> maxBDE = new List<int>();
            List<int> maxCFG = new List<int>();
            List<float> maxAALLA = new List<float>();

            if (e.Argument != null)
            {
                rdl = (RecordDataLists)e.Argument;
                record = rdl.record;
            }
            foreach (KeyValuePair<Position2, Thresholds> max in record)
            {
                maxABC.Add(max.Value.ABC);
                maxBDE.Add(max.Value.BDE);
                maxCFG.Add(max.Value.CFG);
                maxAALLA.Add(max.Value.AALLA);
                process++;
                bgWorker.ReportProgress(process);
                if (bgWorker.CancellationPending == true)
                {
                    e.Cancel = true;
                    e.Result = null;
                    return;
                }
            }

            foreach (KeyValuePair<Position2, Thresholds> max in record)
            {
                float sumA = (float)maxABC.Sum() / maxABC.Count;
                float sumB = (float)maxBDE.Sum() / maxBDE.Count;
                float sumC = (float)maxCFG.Sum() / maxCFG.Count;
                float sumD = (float)maxAALLA.Sum() / maxAALLA.Count;
                if (max.Value.ABC >= sumA && max.Value.BDE >= sumB && max.Value.CFG >= sumC && max.Value.AALLA >= sumD)
                {
                    if (this.checkBox4.Checked)
                    {
                        if (!ids.Exists(delegate (Position2 pos) { return pos.CheckEqual(max.Key); }))
                        {
                            ids.Add(max.Key);
                        }
                    }
                    else
                    {
                        ids.Add(max.Key);
                    }
                }
                process++;
                bgWorker.ReportProgress(process);
                if (bgWorker.CancellationPending == true)
                {
                    e.Cancel = true;
                    e.Result = null;
                    return;
                }
            }
            rdl.ids = ids;
            e.Result = rdl;
        }

        private void BackgroundCalculateWorker5_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.progressBar1.Value = e.ProgressPercentage;
        }

        private void BackgroundCalculateWorker5_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                RecordDataLists rdl = new RecordDataLists();
                List<Position2> ids = new List<Position2>();
                List<ComboBox> none = new List<ComboBox>();
                List<SubData> data = new List<SubData>();
                if (e.Result != null)
                {
                    rdl = (RecordDataLists)e.Result;
                }
                ids = rdl.ids;
                none = rdl.none;
                data = rdl.data;

                if (this.radioButton1.Checked)
                {
                    ids.Sort((a, b) => b.getALL(data) - a.getALL(data));
                }
                else if (this.radioButton2.Checked)
                {
                    ids.Sort((a, b) => (int)b.getAALLA(data) - (int)a.getAALLA(data));
                }
                else if (this.radioButton3.Checked)
                {
                    ids.Sort((a, b) => b.getABC(data) - a.getABC(data));
                }
                else if (this.radioButton4.Checked)
                {
                    ids.Sort((a, b) => b.getBDE(data) - a.getBDE(data));
                }
                else if (this.radioButton5.Checked)
                {
                    ids.Sort((a, b) => b.getCFG(data) - a.getCFG(data));
                }
                else if (this.radioButton6.Checked)
                {
                    ids.Sort((a, b) => b.getAALL(data) - a.getAALL(data));
                }
                else if (this.radioButton7.Checked)
                {
                    ids.Sort((a, b) => b.getBC(data) - a.getBC(data));
                }

                plans.Clear();
                plansID.Clear();
                IdsData id = new IdsData();
                id.ids = ids;
                id.data = data;
                id.none = none;
                this.CancelButton1.Enabled = true;
                this.progressBar1.Maximum = ids.Count;
                this.BackgroundCalculateWorker7.RunWorkerAsync(id);
            }
            else
            {
                this.progressBar1.Value = 0;
                this.progressBar1.Maximum = 0;
                this.CalculateButton2.Enabled = true;
                this.CancelButton1.Enabled = false;
            }
        }




        private void BackgroundCalculateWorker6_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bgWorker = sender as BackgroundWorker;
            int process = 0;
            RecordDataLists rdl = new RecordDataLists();
            Dictionary<Position2, Thresholds> record = new Dictionary<Position2, Thresholds>();
            List<Position2> ids = new List<Position2>();
            List<float> maxAALLA = new List<float>();

            if (e.Argument != null)
            {
                rdl = (RecordDataLists)e.Argument;
                maxAALLA = rdl.maxAALLA;
                record = rdl.record;
            }

            foreach (KeyValuePair<Position2, Thresholds> max in record)
            {
                float sumA = (float)maxAALLA.Sum() / record.Count;
                if (max.Value.AALLA >= sumA)
                {
                    if (checkBox4.Checked)
                    {
                        if (!ids.Exists(delegate (Position2 pos) { return pos.CheckEqual(max.Key); }))
                        {
                            ids.Add(max.Key);
                        }
                    }
                    else
                    {
                        ids.Add(max.Key);
                    }
                }
                process++;
                bgWorker.ReportProgress(process);
                if (bgWorker.CancellationPending == true)
                {
                    e.Cancel = true;
                    e.Result = null;
                    return;
                }
            }
            rdl.ids = ids;
            e.Result = rdl;
        }

        private void BackgroundCalculateWorker6_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.progressBar1.Value = e.ProgressPercentage;
        }

        private void BackgroundCalculateWorker6_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                RecordDataLists rdl = new RecordDataLists();
                List<Position2> ids = new List<Position2>();
                List<ComboBox> none = new List<ComboBox>();
                List<SubData> data = new List<SubData>();
                if (e.Result != null)
                {
                    rdl = (RecordDataLists)e.Result;
                }
                ids = rdl.ids;
                none = rdl.none;
                data = rdl.data;

                if (this.radioButton1.Checked)
                {
                    ids.Sort((a, b) => b.getALL(data) - a.getALL(data));
                }
                else if (this.radioButton2.Checked)
                {
                    ids.Sort((a, b) => (int)b.getAALLA(data) - (int)a.getAALLA(data));
                }
                else if (this.radioButton3.Checked)
                {
                    ids.Sort((a, b) => b.getABC(data) - a.getABC(data));
                }
                else if (this.radioButton4.Checked)
                {
                    ids.Sort((a, b) => b.getBDE(data) - a.getBDE(data));
                }
                else if (this.radioButton5.Checked)
                {
                    ids.Sort((a, b) => b.getCFG(data) - a.getCFG(data));
                }
                else if (this.radioButton6.Checked)
                {
                    ids.Sort((a, b) => b.getAALL(data) - a.getAALL(data));
                }
                else if (this.radioButton7.Checked)
                {
                    ids.Sort((a, b) => b.getBC(data) - a.getBC(data));
                }

                plans.Clear();
                plansID.Clear();
                IdsData id = new IdsData();
                id.ids = ids;
                id.data = data;
                id.none = none;
                this.CancelButton1.Enabled = true;
                this.progressBar1.Maximum = ids.Count;
                this.BackgroundCalculateWorker7.RunWorkerAsync(id);
            }
            else
            {
                this.progressBar1.Value = 0;
                this.progressBar1.Maximum = 0;
                this.CalculateButton2.Enabled = true;
                this.CancelButton1.Enabled = false;
            }
        }



        private class IdsData
        {
            public List<Position2> ids = new List<Position2>();
            public List<SubData> data = new List<SubData>();
            public List<ComboBox> none = new List<ComboBox>();
            public Dictionary<string, List<string>> plans = new Dictionary<string, List<string>>();
            public Dictionary<string, List<int>> plansID = new Dictionary<string, List<int>>();
        }

        private void BackgroundCalculateWorker7_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bgWorker = sender as BackgroundWorker;
            int process = 0;
            IdsData id = new IdsData();
            List<Position2> ids = new List<Position2>();
            //List<Position2> ids2 = new List<Position2>();
            //List<Position2> ids3 = new List<Position2>();
            List<SubData> data = new List<SubData>();
            if (e.Argument != null)
            {
                id = (IdsData)e.Argument;
                ids = id.ids;
                data = id.data;
            }

            //foreach (Position2 pos in ids)
            //{
            //    if (ids2.Count < 1)
            //    {
            //        ids2.Add(pos);
            //        ids3 = ids2;
            //    }
            //    else
            //    {
            //        for (int i = 0; i < ids2.Count; i++)
            //        {
            //            if (!ids2[i].CheckEqual(pos))
            //            {
            //                ids3.Append(pos);
            //            }
            //            if (bgWorker.CancellationPending == true)
            //            {
            //                e.Cancel = true;
            //                e.Result = null;
            //                return;
            //            }
            //        }
            //        ids2 = ids3;
            //    }
            //    process++;
            //    bgWorker.ReportProgress(process);
            //    if (bgWorker.CancellationPending == true)
            //    {
            //        e.Cancel = true;
            //        e.Result = null;
            //        return;
            //    }
            //}

            //ids = ids2;

            for (int i = 0; i < ids.Count; i++)
            {
                List<string> names = new List<string>();
                for (int n = 0; n < ids[i].getList().Count; n++)
                {
                    if (ids[i].getList()[n] != 0)
                    {
                        names.Add(data.Find(delegate (SubData sd) { return sd.value.id == ids[i].getList()[n]; }).Umaname + "->" + ids[i].getPosition(n));
                    }
                }
                id.plans.Add("Plan" + (id.plans.Count + 1).ToString(), names);
                id.plansID.Add("Plan" + (id.plansID.Count + 1).ToString(), ids[i].getList());
                process++;
                bgWorker.ReportProgress(process);
                if (bgWorker.CancellationPending == true)
                {
                    e.Cancel = true;
                    e.Result = null;
                    return;
                }
            }
            e.Result = id;
        }

        private void BackgroundCalculateWorker7_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.progressBar1.Value = e.ProgressPercentage;
        }

        private void BackgroundCalculateWorker7_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                IdsData id = new IdsData();
                List<Position2> ids = new List<Position2>();
                List<ComboBox> none = new List<ComboBox>();
                if (e.Result != null)
                {
                    id = (IdsData)e.Result;
                    plans = id.plans;
                    plansID = id.plansID;
                    ids = id.ids;
                    none = id.none;
                }

                if (plans.Count >= 1)
                {
                    this.OtherPlan.DataSource = plans.Keys.ToList();
                    this.OtherPlanInfo.DataSource = plans[(string)this.OtherPlan.SelectedValue];
                }

                for (int i = 0; i < none.Count; i++)
                {
                    if (ids.Count >= 1)
                    {
                        if (none[i].Tag == (object)"2A")
                        {
                            none[i].SelectedIndex = ids[0].A - 1;
                        }
                        if (none[i].Tag == (object)"2B")
                        {
                            none[i].SelectedIndex = ids[0].B - 1;
                        }
                        if (none[i].Tag == (object)"2C")
                        {
                            none[i].SelectedIndex = ids[0].C - 1;
                        }
                        if (none[i].Tag == (object)"2D")
                        {
                            none[i].SelectedIndex = ids[0].D - 1;
                        }
                        if (none[i].Tag == (object)"2E")
                        {
                            none[i].SelectedIndex = ids[0].E - 1;
                        }
                        if (none[i].Tag == (object)"2F")
                        {
                            none[i].SelectedIndex = ids[0].F - 1;
                        }
                        if (none[i].Tag == (object)"2G")
                        {
                            none[i].SelectedIndex = ids[0].G - 1;
                        }
                    }
                }
                FlushMemory();
                this.CalculateButton2.Enabled = true;
                this.CancelButton1.Enabled = false;
            }
            else
            {
                this.progressBar1.Value = 0;
                this.progressBar1.Maximum = 0;
                this.CalculateButton2.Enabled = true;
                this.CancelButton1.Enabled = false;
            }
        }




        private void CancelButton1_Click(object sender, EventArgs e)
        {
            if (this.BackGroundCalculateWorker1.IsBusy)
            {
                this.BackGroundCalculateWorker1.CancelAsync();
            }
            if (this.BackgroundCalculateWorker4.IsBusy)
            {
                this.BackgroundCalculateWorker4.CancelAsync();
            }
            if (this.BackgroundCalculateWorker5.IsBusy)
            {
                this.BackgroundCalculateWorker5.CancelAsync();
            }
            if (this.BackgroundCalculateWorker6.IsBusy)
            {
                this.BackgroundCalculateWorker6.CancelAsync();
            }
            if (this.BackgroundCalculateWorker7.IsBusy)
            {
                this.BackgroundCalculateWorker7.CancelAsync();
            }
        }

        private void OtherPlan_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.OtherPlanInfo.DataSource = plans[(string)this.OtherPlan.SelectedValue];

            if (this.comboBox_Modes.SelectedIndex == 1)
            {
                List<int> list = plansID[(string)this.OtherPlan.SelectedValue];

                this.Mode2ComboBox1.SelectedIndex = list[0] - 1;
                this.Mode2ComboBox2.SelectedIndex = list[1] - 1;
                this.Mode2ComboBox3.SelectedIndex = list[2] - 1;
                this.Mode2ComboBox4.SelectedIndex = list[3] - 1;
                this.Mode2ComboBox5.SelectedIndex = list[4] - 1;
                this.Mode2ComboBox6.SelectedIndex = list[5] - 1;
                this.Mode2ComboBox7.SelectedIndex = list[6] - 1;
            }

        }

        private void NextPlanButton_Click(object sender, EventArgs e)
        {
            if (this.comboBox_Modes.SelectedIndex == 1)
            {
                if (this.OtherPlan.SelectedIndex < (this.OtherPlan.Items.Count - 1))
                {
                    this.OtherPlan.SelectedIndex++;

                    List<int> list = plansID[(string)this.OtherPlan.SelectedValue];

                    this.Mode2ComboBox1.SelectedIndex = list[0] - 1;
                    this.Mode2ComboBox2.SelectedIndex = list[1] - 1;
                    this.Mode2ComboBox3.SelectedIndex = list[2] - 1;
                    this.Mode2ComboBox4.SelectedIndex = list[3] - 1;
                    this.Mode2ComboBox5.SelectedIndex = list[4] - 1;
                    this.Mode2ComboBox6.SelectedIndex = list[5] - 1;
                    this.Mode2ComboBox7.SelectedIndex = list[6] - 1;
                }
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void setImageToBox(string name, PictureBox pic)
        {
            string namefix = name + ".png";
            int id = this.ImageList1.Images.IndexOfKey(namefix);
            if (id > -1)
            {
                pic.Image = this.ImageList1.Images[id];
            }
        }

        private void Mode1Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void setGroupBoxText()
        {
            //this.GroupBox1
        }

        private void setPictureBackGround()
        {
            this.ModeScreen1.BackColor = System.Drawing.Color.FromArgb(55, 0, 0, 170);
            this.ModeScreen2.BackColor = System.Drawing.Color.FromArgb(55, 0, 0, 170);
            this.GroupBox1.BackColor = System.Drawing.Color.FromArgb(70, 0, 0, 150);
            this.GroupBox2.BackColor = System.Drawing.Color.FromArgb(80, 0, 0, 150);
            this.GroupBox3.BackColor = System.Drawing.Color.FromArgb(70, 0, 0, 150);
            this.GroupBox4.BackColor = System.Drawing.Color.FromArgb(70, 0, 0, 220);
            this.GroupBox5.BackColor = System.Drawing.Color.FromArgb(70, 0, 0, 220);
            this.Mode1Panel.BackColor = System.Drawing.Color.Transparent;
            this.Mode2Panel.BackColor = System.Drawing.Color.Transparent;

            Random random = new Random();
            int r = random.Next(1, 7);
            string bg = "bg" + r;
            
            this.BackGroundPanel.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(bg);
            this.BackGroundPanel.BackgroundImageLayout = ImageLayout.Stretch;

            //string path = System.Environment.CurrentDirectory + "\\02.png";
            //Bitmap bm = new Bitmap(path);

            //Bitmap bit01 = new Bitmap(Properties.Resources.bg1);
            //Properties.Resources.bg1.Dispose();
            //this.BackGroundPanel.BackgroundImage = bit01;
            //this.BackGroundPanel.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private static void FlushMemory()
        {
            GarbageCollect();

            if (Environment.OSVersion.Platform == PlatformID.Win32NT)
            {
                SetProcessWorkingSetSize(System.Diagnostics.Process.GetCurrentProcess().Handle, 1, 1);
            }
        }
        private static void GarbageCollect()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }
        [DllImport("kernel32.dll")]
        private static extern bool SetProcessWorkingSetSize(IntPtr process, int minSize, int maxSize);

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void LastPlanButton_Click(object sender, EventArgs e)
        {
            if (this.comboBox_Modes.SelectedIndex == 1)
            {
                if (this.OtherPlan.SelectedIndex > 0)
                {
                    this.OtherPlan.SelectedIndex--;

                    List<int> list = plansID[(string)this.OtherPlan.SelectedValue];

                    this.Mode2ComboBox1.SelectedIndex = list[0] - 1;
                    this.Mode2ComboBox2.SelectedIndex = list[1] - 1;
                    this.Mode2ComboBox3.SelectedIndex = list[2] - 1;
                    this.Mode2ComboBox4.SelectedIndex = list[3] - 1;
                    this.Mode2ComboBox5.SelectedIndex = list[4] - 1;
                    this.Mode2ComboBox6.SelectedIndex = list[5] - 1;
                    this.Mode2ComboBox7.SelectedIndex = list[6] - 1;
                }
            }
        }

        

        public void Form2SetUp(Form2 form2)
        {
            form2.parent = this;

            form2.textBox1.Text = this.TABC.ToString();
            form2.textBox2.Text = this.TAALLAmax.ToString();
            form2.textBox3.Text = this.TAALLAmin.ToString();
            form2.textBox4.Text = this.TBCmax.ToString();
            form2.textBox5.Text = this.TBCmin.ToString();
        }

        public bool CheckForm2BeAble()
        {
            if (this.TAALLAmax > this.TAALLAmin && this.TBCmax > this.TBCmin)
            {
                return true;
            }
            return false;
        }

        private void buttonLibsT_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            Form2SetUp(form2);

            form2.Show();
        }
    }
}
