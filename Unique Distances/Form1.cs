using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;


namespace Unique_Distances
{
    public partial class Form1 : Form
    {
        static int _Size = 6;
        Point[,] Points = new Point[_Size, _Size];
        public Form1()
        {
            InitializeComponent();
            PopulatePoints();
            DoWork();
        }

        void PopulatePoints()
        {
            for (int i = 0; i < _Size; i++)
            {
                for (int j = 0; j < _Size; j++)
                {
                    var p = new Point(i, j);
                    Points[i, j] = p;
                }
            }
        }

        void DoWork()
        {
            foreach (var p1 in Points)
            {
                foreach (var p2 in Points)
                {
                    foreach (var p3 in Points)
                    {
                        foreach (var p4 in Points)
                        {
                            foreach (var p5 in Points)
                            {
                                foreach (var p6 in Points)
                                {
                                    var d12 = Point.Subtract(p2, p1).Length;
                                    var d13 = Point.Subtract(p3, p1).Length;
                                    if (d12 == d13)
                                        continue;
                                    var d14 = Point.Subtract(p4, p1).Length;
                                    if (d12 == d14 || d13 == d14)
                                        continue;
                                    var d15 = Point.Subtract(p5, p1).Length;
                                    if (d12 == d15 || d13 == d15 || d14 == d15)
                                        continue;
                                    var d16 = Point.Subtract(p6, p1).Length;
                                    if (d12 == d16 || d13 == d16 || d14 == d16 || d15 == d16)
                                        continue;

                                    var d23 = Point.Subtract(p3, p2).Length;
                                    if (d12 == d23 || d13 == d23 || d14 == d23 || d15 == d23 || d16 == d23)
                                        continue;
                                    var d24 = Point.Subtract(p4, p2).Length;
                                    if (d12 == d24 || d13 == d24 || d14 == d24 || d15 == d24 || d16 == d24 || d23 == d24)
                                        continue;
                                    var d25 = Point.Subtract(p5, p2).Length;
                                    if (d12 == d25 || d13 == d25 || d14 == d25 || d15 == d25 || d16 == d25 || d23 == d25 || d24 == d25)
                                        continue;
                                    var d26 = Point.Subtract(p6, p2).Length;
                                    if (d12 == d26 || d13 == d26 || d14 == d26 || d15 == d26 || d16 == d26 || d23 == d26 || d24 == d26 || d25 == d26)
                                        continue;


                                    var d34 = Point.Subtract(p4, p3).Length;
                                    if (d12 == d34 || d13 == d34 || d14 == d34 || d15 == d34 || d16 == d34 || d23 == d34 || d24 == d34 || d25 == d34 || d26 == d34)
                                        continue;
                                    var d35 = Point.Subtract(p5, p3).Length;
                                    if (d12 == d35 || d13 == d35 || d14 == d35 || d15 == d35 || d16 == d35 || d23 == d35 || d24 == d35 || d25 == d35 || d26 == d35 || d34 == d35)
                                        continue;
                                    var d36 = Point.Subtract(p6, p3).Length;
                                    if (d12 == d36 || d13 == d36 || d14 == d36 || d15 == d36 || d16 == d36 || d23 == d36 || d24 == d36 || d25 == d36 || d26 == d36 || d34 == d36 || d35 == d36)
                                        continue;


                                    var d45 = Point.Subtract(p5, p4).Length;
                                    if (d12 == d45 || d13 == d45 || d14 == d45 || d15 == d45 || d16 == d45 || d23 == d45 || d24 == d45 || d25 == d45 || d26 == d45 || d34 == d45 || d35 == d45 || d36 == d45)
                                        continue;
                                    var d46 = Point.Subtract(p6, p4).Length;
                                    if (d12 == d46 || d13 == d46 || d14 == d46 || d15 == d46 || d16 == d46 || d23 == d46 || d24 == d46 || d25 == d46 || d26 == d46 || d34 == d46 || d35 == d46 || d36 == d46 || d45 == d46)
                                        continue;

                                    var d56 = Point.Subtract(p6, p5).Length;
                                    if (d12 == d56 || d13 == d56 || d14 == d56 || d15 == d56 || d16 == d56 || d23 == d56 || d24 == d56 || d25 == d56 || d26 == d56 || d34 == d56 || d35 == d56 || d36 == d56 || d45 == d56 || d46 == d56)
                                        continue;

                                    dataGridView1.Rows.Add(p1.X, p1.Y, p2.X, p2.Y,p3.X, p3.Y,p4.X, p4.Y,p5.X, p5.Y,p6.X, p6.Y);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
