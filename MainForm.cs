using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OSGeo.GDAL;


namespace BuildOverviews
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_Build_Click(object sender, EventArgs e)
        {
            int numofOverviews = 0;
            if (!int.TryParse(tb_numofOverviews.Text, out numofOverviews) ||
                numofOverviews <= 0 || numofOverviews > 9)
            {
                MessageBox.Show("OV级别只能输入1-9的数字");
                return;
            }
            string inputPath = tb_inputPath.Text;
            var inputTifs = Directory.EnumerateFiles(inputPath, "*.tif").ToList();
            
            int[] ovAll = { 2, 4, 8, 16, 32, 64, 128, 256, 512 };

            int[] ov = new int[numofOverviews];
            for (int i = 0; i < numofOverviews; i++)
            {
                ov[i] = ovAll[i];
            }
            List<string> errors = new List<string>();


            BuildOverviews.GdalConfiguration.ConfigureGdal();
            BuildOverviews.GdalConfiguration.ConfigureOgr();

            //Gdal.AllRegister();
            for (int j = 0; j < inputTifs.Count; j++)
            {
               try
                {
                    var ds = Gdal.Open(inputTifs[j], Access.GA_Update);
                    ds.BuildOverviews("average", ov);
                }
                catch (Exception exception)
                {
                    errors.Add(inputTifs[j] + "\r\n" + exception);
                }
            }
            if (errors.Count == 0)
            {
                MessageBox.Show("计算OverView成功！");
            }
            else
            {
                MessageBox.Show("发生错误，详见错误日志。");
                File.AppendAllLines(inputPath + "\\" + "errors.log", errors, Encoding.Default);
            }
        }

        private void tb_inputPath_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
            else
                e.Effect = DragDropEffects.None;
        }

        private void tb_inputPath_DragDrop(object sender, DragEventArgs e)
        {
            var te = sender as TextBox;
            te.Text = ((Array) e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
        }
    }
}
