using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShortestPathDemo
{
    public partial class Form1 : Form
    {
        private static string filename=String.Empty;
        private static string str = String.Empty;//文本记录的数据
        private static int PointCounts = 0;//点数
        private static int[,] Metro = null;//  邻接矩阵
        private static Point[] point = null;
        private static List<Point> PL = null;

        private int[] distance; //用以每次查询存放数据
        private int[] prev; //用以存储前一个最近顶点的下标
        private ArrayList S; //S储存确定最短路径的顶点的下标
        private ArrayList U; //U中存储尚未确定路径的顶点的下标
        private bool[] Isfor;
        //基本画图
        private static Graphics graphics;
        private static Bitmap bitmap;
        private static Pen pen;
        //private static Font font;
       // private static Brush brush;
        public Form1()
        {
            InitializeComponent();
            //font = new Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular);
            //brush = new SolidBrush(Color.Blue);
            
        }

        private void Btu_OpenFile_Click(object sender, EventArgs e)
        {
            //打开一个文件选择框
            OpenFileDialog ofg=new OpenFileDialog();
            ofg.Filter = "TXTfile(*.txt)|*.txt|All files(*.*)|*.*"; //打开文件路径
            ofg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ofg.Multiselect = false;
            if (ofg.ShowDialog() == DialogResult.OK)
            {
                filename = ofg.FileName;
                Txt_FileName.Text = filename;
            }

        }

        private void Btu_Load_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(filename))
            {
                MessageBox.Show("请先选择文件");
                return;
            }
            FileStream fs = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string content = sr.ReadLine();
            if (!string.IsNullOrEmpty(content))
            {
                try
                {
                    if (content.Contains("PointCounts:"))
                    {
                        content = sr.ReadLine();
                        if (!string.IsNullOrEmpty(content))
                            PointCounts = Int32.Parse(content.Trim());
                        content = sr.ReadLine();
                        str = "点数：" + PointCounts;
                    }
                     if (content.Contains("Weight:"))
                    {
                        content = sr.ReadLine();
                        str = str + "\n" + "权重：" + "\n";
                        Metro = new int[PointCounts, PointCounts];
                        int k = 0;
                        string[] weight = new string[PointCounts];

                        while (!string.IsNullOrEmpty(content))
                        {
                            weight = content.Split(',');
                            for (int i = 0; i < PointCounts; i++)
                            {
                                str = str + weight[i] + "\t";
                                Metro[k, i] = int.Parse(weight[i]);
                            }
                            content = sr.ReadLine();
                            str = str + "\n";
                            k++;
                        }
                    }
                }
                catch (Exception)
                {
                    str = "文本内容有错，请检查！";
                }
            }
            fs.Close();
            sr.Close();
            richTextBox.Text = str;

            PL = new List<Point>();
            bitmap = new Bitmap(this.pictureBox1.Width, this.pictureBox1.Height);
            graphics = Graphics.FromImage(bitmap);
            AddPoint();
            AddLine();
        }


        private void AddPoint()
        {
            while (PL.Count<PointCounts)
            {
                Point p = Random_Point();
                if (!PL.Contains(p))
                {
                    PL.Add(p);
                    DrawPoint(p, "V" + PL.Count);
                }
            }
        }

        private void AddLine()
        {
            Brush_Line();
            this.pictureBox1.Image = bitmap;
            this.richTextBox.Text = str;
        }
     
     

        /// <summary>
        /// 画点
        /// </summary>
        /// <param name="p0">PointClass类的点</param>
        /// <param name="i">计数用的</param>
        private void DrawPoint(Point p0,string str)
        {
            pen = new Pen(Color.Red, 3);
            graphics.DrawEllipse(pen, p0.X, p0.Y, 1.5f, 1.5f);
            graphics.DrawString(str, new Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular), new SolidBrush(Color.Blue), p0.X, p0.Y);
            this.pictureBox1.Image = bitmap;
        }

        /// <summary>
        /// 依次传入 两个点 来画线
        /// 用来画裁剪后的线段
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        private void DrawLine(Point p1, Point p2)
        {
            pen = new Pen(Color.Black, 2);
            //PolylineClass plc = new PolylineClass(pointList.ToArray());
            //p1 = plc.m_p[plc.m_pointCounts - 1];
            graphics.DrawLine(pen, p1.X, p1.Y, p2.X, p2.Y);
           // this.pictureBox1.Image = bitmap;
        }


        /// <summary>
        /// 生成随机数，返回一个点
        /// </summary>
        /// <returns></returns>
        private Point Random_Point()
        {
            //暂时将宽度定义为 600  高度 500
            Random random = new Random();
            //int x = random.Next(this.panel_Tools.Width, this.pictureBox1.Width);
            //int y = random.Next(this.panel_Openfile.Height, this.pictureBox1.Height);
            int x = random.Next(this.panel_Tools.Width, 600);
            int y = random.Next(this.panel_Openfile.Height, 500);
            return new Point(x, y);
        }


            /// <summary>
        /// 将各个点根据权重连通
        /// </summary>
        private  void Brush_Line()
        {
            point = PL.ToArray();
            for (int k = 0; k < PointCounts - 1; k++)
            {
                for (int i = k + 1; i < PointCounts; i++)
                {
                    if (Metro[k, i] != 2048)
                    {
                        DrawLine(point[k], point[i]);
                        graphics.DrawString(Metro[k, i].ToString(), new Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular), new SolidBrush(Color.Red), (point[k].X + point[i].X) / 2, (point[k].Y + point[i].Y) / 2 );
                        str = str + "\n" + "点" + (k + 1) + "+点" + (i + 1) + "\t" + Metro[k, i];
                    }
                }
            }

        }

        private void Btu_ShortestPath_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(filename))
            {
                MessageBox.Show("请先选择文件");
                return;
            }
            init_ShortestPath();
            FindWay(0);
            display();
            this.richTextBox .Text= str;
            this.pictureBox1.Image = bitmap;
            
        }

        /// <summary>
        /// dijkstra算法的实现部分
        /// </summary>
        /// <param name="Start"></param>
        private void FindWay(int Start)
        {
            S.Add(Start);
            Isfor[Start] = true;
            //把下标装入U中
            for (int i = 0; i < PointCounts; i++)
            {
                if (i != Start)
                    U.Add(i);
            }

            for (int i = 0; i < PointCounts; i++)
            {
                distance[i] = Metro[Start, i];
                prev[i] = 0;
            }
            int Count = U.Count;
            while (Count > 0)
            {
                int min_index = (int)U[0]; //假设U中第一个数存储的是最小的数的下标
                foreach (int r in U)
                {
                    if (distance[r] < distance[min_index] && !Isfor[r])
                        min_index = r;
                }
                S.Add(min_index); //S加入这个最近的点
                Isfor[min_index] = true;
                U.Remove(min_index); //U中移除这个点；
                foreach (int r in U)
                {
                    //查找下一行邻接矩阵，如何距离和上一个起点的距离和与数组存储的相比比较小，就更改新的距离和起始点,再比对新的起点到各边的距离
                    if (distance[r] > distance[min_index] + Metro[min_index, r])
                    {
                        distance[r] = distance[min_index] + Metro[min_index, r];
                        prev[r] = min_index;
                    }
                    else
                    {
                        distance[r] = distance[r];
                    }
                }
                Count = U.Count;
            }
        }
        private void init_ShortestPath()
        {
            S=new ArrayList(PointCounts);
            U=new ArrayList(PointCounts);
            Isfor = new bool[ PointCounts];

            distance = new int[PointCounts];
            prev = new int[PointCounts];
        }

       
        /// <summary>
        /// 把生成数据显示出来
        /// </summary>
    
        private void display()
        {
            str += "\n";
            for (int i = 1; i < PointCounts; i++)
            {
                str = str + "V1到V"+ (i + 1)+"的最短路径为:V1" ;
                int prePoint = prev[i];
                string s = "";
                StringBuilder sb = new StringBuilder(10);
                while (prePoint > 0)
                {
                    s = (prePoint + 1) + s;
                    prePoint = prev[prePoint];
                }
                int j = 0;
                for ( j = 0; j < s.Length; j++)
                {
                    sb.Append("→V").Append(s[j]);
                    if (i == PointCounts-1)
                    {
                        if (j == 0)
                            graphics.DrawLine(new Pen(Color.Red, 3), point[0].X, point[0].Y, point[int.Parse(s.Substring(j,1))-1].X, point[int.Parse(s.Substring(j,1))-1].Y);
                        else if (j<s.Length)
                            graphics.DrawLine(new Pen(Color.Red, 3), point[int.Parse(s.Substring(j-1, 1))-1].X, point[int.Parse(s.Substring(j-1, 1))-1].Y, point[int.Parse(s.Substring(j , 1))-1].X, point[int.Parse(s.Substring(j , 1))-1].Y);
                        
                    }
                }
                if (i == PointCounts - 1 && j == s.Length )
                        graphics.DrawLine(new Pen(Color.Red, 3), point[int.Parse(s.Substring(j-1, 1)) - 1].X, point[int.Parse(s.Substring(j-1, 1)) - 1].Y, point[PointCounts - 1].X, point[PointCounts - 1].Y);
                str=str+sb;
                str = str + "→V" + (i + 1);
                str = str + ":" + distance[i] + "\n";
            }
        }
        
    }
}
