//Ziyatdinov Kamil 220 group "Geometrical figures 4" 30.04.2022

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Geom_fig_3
{
    public partial class frmMain : Form
    {
        static private Pen pen = new Pen(Color.Black, 1);

        public frmMain()
        {
            InitializeComponent();
        }

        private void cmbFigures_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbFigures.SelectedItem)
            {
                case "Segment":
                case "Rectangle":
                case "Circle":
                    mtbCoords1.Visible = true;
                    mtbCoords2.Visible = true;
                    mtbCoords3.Visible = false;
                    break;

                case "Triangle":
                    mtbCoords1.Visible = true;
                    mtbCoords2.Visible = true;
                    mtbCoords3.Visible = true;
                    break;

                default:
                    mtbCoords1.Visible = false;
                    mtbCoords2.Visible = false;
                    mtbCoords3.Visible = false;
                    break;
            }
        }

        private void btnAddFigure_Click(object sender, EventArgs e)
        {
            if (ValidInput())
            {
                Point[] points = GetPoints();

                switch (cmbFigures.SelectedItem)
                {
                    case "Segment":
                        Figures.Add(new Segment(points[0], points[1], 
                            pen.Width, pen.Color));                       
                        break;
                                                                                
                    case "Rectangle":
                        if (points[0].Y > points[1].Y || 
                            points[0].X > points[1].X)
                        {
                            MessageBox.Show("\'Y\' and \'X\' " +
                                "of first point must be less that " +
                                "of second point!", "Error!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                                                                                                                                                                               
                        Figures.Add(new Rectangle(points[0], points[1], 
                            pen.Width, pen.Color));                       
                       break;
                                                                                        
                    case "Circle":
                        if (points[0].Y != points[1].Y)
                        {
                            MessageBox.Show("\'Y\' two points must be same!", "Error!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        Figures.Add(new Circle(points[0], points[1], 
                            pen.Width, pen.Color));
                        break;

                    case "Triangle":
                        Figures.Add(new Triangle(points[0], points[1], points[2], 
                            pen.Width, pen.Color));
                        break;

                    default:
                        MessageBox.Show("This figure not found!","Error!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }

                Graphics paper = pnlDrawPad.CreateGraphics();
                Figures.Draw(paper);

                NullingInput();
            }
            else
            {
                MessageBox.Show("Invalid input parameters!", "Error!", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            mtbCoords1.Visible = false;
            mtbCoords2.Visible = false;
            mtbCoords3.Visible = false;
        }

        private void NullingInput()
        {
            mtbCoords1.Text = "";
            mtbCoords2.Text = "";
            mtbCoords3.Text = "";
        }

        private Point[] GetPoints()
        {
            Point[] points = new Point[3];
            string[] point1 = mtbCoords1.Text.Split(":");
            string[] point2 = mtbCoords2.Text.Split(":");

            points[0] = new Point(GetValue(point1[0]), GetValue(point1[1]));
            points[1] = new Point(GetValue(point2[0]), GetValue(point2[1]));

            if (cmbFigures.SelectedItem != "Triangle")
            { 
                return points;
            }
            else
            {
                string[] point3 = mtbCoords3.Text.Split(":");

                points[2] = new Point(GetValue(point3[0]), GetValue(point3[1]));

                return points;
            }
        }

        private bool ValidInput()
        {
            string[] point1 = mtbCoords1.Text.Split(":");
            string[] point2 = mtbCoords2.Text.Split(":");
            string[] point3 = mtbCoords3.Text.Split(":");

            if (cmbFigures.SelectedItem != "Triangle")
                return (ValueCheck(point1[0]) && ValueCheck(point1[1])
                    && ValueCheck(point2[0]) && ValueCheck(point2[1]));
            else
                return (ValueCheck(point1[0]) && ValueCheck(point1[1])
                    && ValueCheck(point2[0]) && ValueCheck(point2[1])
                    && ValueCheck(point3[0]) && ValueCheck(point3[1]));
        }

        private bool ValueCheck(string value)
        {
            return value.Trim() != "" && !value.Trim().Contains(' ');
        }

        private int GetValue(string value)
        {
            return int.Parse(value.Trim());
        }

        private void txbXY_TextChanged(object sender, EventArgs e)
        {

        }

        private void mtbCoords1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();

            save.Filter = "txt files (*.txt)|*.txt";
            save.FilterIndex = 2;
            save.RestoreDirectory = true;

            if (save.ShowDialog() == DialogResult.OK)
            {
                Figures.Save(save.FileName);
                MessageBox.Show("File saved", "Success!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog load = new OpenFileDialog();

            load.Filter = "txt files (*.txt)|*.txt";

            if (load.ShowDialog() == DialogResult.OK)
            {
                try
                {                    
                    Figures.Load(load.FileName);

                    Graphics paper = pnlDrawPad.CreateGraphics();
                    Figures.Draw(paper);

                    MessageBox.Show("File loaded", "Success!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Incorrect file!", "Error!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void mtbCoords3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Red;
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Blue;
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Green;
        }

        private void btnYellow_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Yellow;
        }

        private void btnBlack_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Black;
        }
        private void btnBrown_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Brown;
        }

        private void btnOrange_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Orange;
        }

        private void btnAqua_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Aqua;
        }

        private void btnPurple_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Purple;
        }

        private void btnGray_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Gray;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            pen.Width = trbLineWidth.Value;
        }

        private void pnlToolBox_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlToolBox_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Graphics paper = pnlDrawPad.CreateGraphics();
            paper.Clear(Color.White);
            Figures.Clear();
        }

        private void pnlDrawPad_Paint(object sender, PaintEventArgs e)
        {
            Graphics paper = pnlDrawPad.CreateGraphics();
            Figures.Draw(paper);
        }
    }
}

