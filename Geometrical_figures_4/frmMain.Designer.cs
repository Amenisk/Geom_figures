//Ziyatdinov Kamil 220 group "Geometrical figures 4" 30.05.2022

namespace Geom_fig_3
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbFigures = new System.Windows.Forms.ComboBox();
            this.mtbCoords2 = new System.Windows.Forms.MaskedTextBox();
            this.mtbCoords1 = new System.Windows.Forms.MaskedTextBox();
            this.mtbCoords3 = new System.Windows.Forms.MaskedTextBox();
            this.btnAddFigure = new System.Windows.Forms.Button();
            this.txbXY = new System.Windows.Forms.TextBox();
            this.pnlDrawPad = new System.Windows.Forms.Panel();
            this.pnlToolBox = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.pnlCoordinates = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.pnlColors = new System.Windows.Forms.Panel();
            this.txbColors = new System.Windows.Forms.TextBox();
            this.btnBlack = new System.Windows.Forms.Button();
            this.btnYellow = new System.Windows.Forms.Button();
            this.btnGreen = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.btnRed = new System.Windows.Forms.Button();
            this.pnlLineWidth = new System.Windows.Forms.Panel();
            this.trbLineWidth = new System.Windows.Forms.TrackBar();
            this.txbLineWidth = new System.Windows.Forms.TextBox();
            this.btnBrown = new System.Windows.Forms.Button();
            this.btnOrange = new System.Windows.Forms.Button();
            this.btnAqua = new System.Windows.Forms.Button();
            this.btnPurple = new System.Windows.Forms.Button();
            this.btnGray = new System.Windows.Forms.Button();
            this.pnlToolBox.SuspendLayout();
            this.pnlCoordinates.SuspendLayout();
            this.pnlColors.SuspendLayout();
            this.pnlLineWidth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbLineWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbFigures
            // 
            this.cmbFigures.FormattingEnabled = true;
            this.cmbFigures.Items.AddRange(new object[] {
            "Segment",
            "Rectangle",
            "Triangle",
            "Circle"});
            this.cmbFigures.Location = new System.Drawing.Point(12, 32);
            this.cmbFigures.Name = "cmbFigures";
            this.cmbFigures.Size = new System.Drawing.Size(121, 23);
            this.cmbFigures.TabIndex = 0;
            this.cmbFigures.Text = "Figures";
            this.cmbFigures.SelectedIndexChanged += new System.EventHandler(this.cmbFigures_SelectedIndexChanged);
            // 
            // mtbCoords2
            // 
            this.mtbCoords2.Location = new System.Drawing.Point(13, 54);
            this.mtbCoords2.Mask = "0000:0000";
            this.mtbCoords2.Name = "mtbCoords2";
            this.mtbCoords2.Size = new System.Drawing.Size(63, 23);
            this.mtbCoords2.TabIndex = 1;
            // 
            // mtbCoords1
            // 
            this.mtbCoords1.Location = new System.Drawing.Point(13, 25);
            this.mtbCoords1.Mask = "0000:0000";
            this.mtbCoords1.Name = "mtbCoords1";
            this.mtbCoords1.Size = new System.Drawing.Size(63, 23);
            this.mtbCoords1.TabIndex = 2;
            this.mtbCoords1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbCoords1_MaskInputRejected);
            // 
            // mtbCoords3
            // 
            this.mtbCoords3.Location = new System.Drawing.Point(13, 83);
            this.mtbCoords3.Mask = "0000:0000";
            this.mtbCoords3.Name = "mtbCoords3";
            this.mtbCoords3.Size = new System.Drawing.Size(63, 23);
            this.mtbCoords3.TabIndex = 3;
            this.mtbCoords3.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbCoords3_MaskInputRejected);
            // 
            // btnAddFigure
            // 
            this.btnAddFigure.Location = new System.Drawing.Point(3, 360);
            this.btnAddFigure.Name = "btnAddFigure";
            this.btnAddFigure.Size = new System.Drawing.Size(75, 23);
            this.btnAddFigure.TabIndex = 5;
            this.btnAddFigure.Text = "Draw";
            this.btnAddFigure.UseVisualStyleBackColor = true;
            this.btnAddFigure.Click += new System.EventHandler(this.btnAddFigure_Click);
            // 
            // txbXY
            // 
            this.txbXY.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txbXY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbXY.Location = new System.Drawing.Point(13, 3);
            this.txbXY.Name = "txbXY";
            this.txbXY.ReadOnly = true;
            this.txbXY.Size = new System.Drawing.Size(99, 16);
            this.txbXY.TabIndex = 6;
            this.txbXY.Text = "Coordinates (X:Y)";
            this.txbXY.TextChanged += new System.EventHandler(this.txbXY_TextChanged);
            // 
            // pnlDrawPad
            // 
            this.pnlDrawPad.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlDrawPad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDrawPad.Location = new System.Drawing.Point(164, 0);
            this.pnlDrawPad.Name = "pnlDrawPad";
            this.pnlDrawPad.Size = new System.Drawing.Size(636, 450);
            this.pnlDrawPad.TabIndex = 9;
            this.pnlDrawPad.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDrawPad_Paint);
            // 
            // pnlToolBox
            // 
            this.pnlToolBox.Controls.Add(this.btnClear);
            this.pnlToolBox.Controls.Add(this.pnlCoordinates);
            this.pnlToolBox.Controls.Add(this.btnSave);
            this.pnlToolBox.Controls.Add(this.btnAddFigure);
            this.pnlToolBox.Controls.Add(this.btnLoad);
            this.pnlToolBox.Controls.Add(this.cmbFigures);
            this.pnlToolBox.Controls.Add(this.pnlColors);
            this.pnlToolBox.Controls.Add(this.pnlLineWidth);
            this.pnlToolBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlToolBox.Location = new System.Drawing.Point(0, 0);
            this.pnlToolBox.Name = "pnlToolBox";
            this.pnlToolBox.Size = new System.Drawing.Size(164, 450);
            this.pnlToolBox.TabIndex = 10;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(89, 360);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // pnlCoordinates
            // 
            this.pnlCoordinates.Controls.Add(this.txbXY);
            this.pnlCoordinates.Controls.Add(this.mtbCoords1);
            this.pnlCoordinates.Controls.Add(this.mtbCoords2);
            this.pnlCoordinates.Controls.Add(this.mtbCoords3);
            this.pnlCoordinates.Location = new System.Drawing.Point(0, 233);
            this.pnlCoordinates.Name = "pnlCoordinates";
            this.pnlCoordinates.Size = new System.Drawing.Size(164, 121);
            this.pnlCoordinates.TabIndex = 10;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(3, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(84, 3);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 8;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // pnlColors
            // 
            this.pnlColors.Controls.Add(this.btnGray);
            this.pnlColors.Controls.Add(this.btnPurple);
            this.pnlColors.Controls.Add(this.btnAqua);
            this.pnlColors.Controls.Add(this.btnOrange);
            this.pnlColors.Controls.Add(this.btnBrown);
            this.pnlColors.Controls.Add(this.txbColors);
            this.pnlColors.Controls.Add(this.btnBlack);
            this.pnlColors.Controls.Add(this.btnYellow);
            this.pnlColors.Controls.Add(this.btnGreen);
            this.pnlColors.Controls.Add(this.btnBlue);
            this.pnlColors.Controls.Add(this.btnRed);
            this.pnlColors.Location = new System.Drawing.Point(0, 61);
            this.pnlColors.Name = "pnlColors";
            this.pnlColors.Size = new System.Drawing.Size(164, 91);
            this.pnlColors.TabIndex = 9;
            // 
            // txbColors
            // 
            this.txbColors.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txbColors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbColors.Location = new System.Drawing.Point(3, 3);
            this.txbColors.Name = "txbColors";
            this.txbColors.ReadOnly = true;
            this.txbColors.Size = new System.Drawing.Size(99, 16);
            this.txbColors.TabIndex = 7;
            this.txbColors.Text = "Line color";
            // 
            // btnBlack
            // 
            this.btnBlack.BackColor = System.Drawing.Color.Black;
            this.btnBlack.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnBlack.FlatAppearance.BorderSize = 0;
            this.btnBlack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlack.Location = new System.Drawing.Point(130, 25);
            this.btnBlack.Name = "btnBlack";
            this.btnBlack.Size = new System.Drawing.Size(25, 25);
            this.btnBlack.TabIndex = 3;
            this.btnBlack.UseVisualStyleBackColor = false;
            this.btnBlack.Click += new System.EventHandler(this.btnBlack_Click);
            // 
            // btnYellow
            // 
            this.btnYellow.BackColor = System.Drawing.Color.Yellow;
            this.btnYellow.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnYellow.FlatAppearance.BorderSize = 0;
            this.btnYellow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYellow.Location = new System.Drawing.Point(96, 25);
            this.btnYellow.Name = "btnYellow";
            this.btnYellow.Size = new System.Drawing.Size(25, 25);
            this.btnYellow.TabIndex = 4;
            this.btnYellow.UseVisualStyleBackColor = false;
            this.btnYellow.Click += new System.EventHandler(this.btnYellow_Click);
            // 
            // btnGreen
            // 
            this.btnGreen.BackColor = System.Drawing.Color.Green;
            this.btnGreen.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnGreen.FlatAppearance.BorderSize = 0;
            this.btnGreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGreen.Location = new System.Drawing.Point(65, 25);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(25, 25);
            this.btnGreen.TabIndex = 2;
            this.btnGreen.UseVisualStyleBackColor = false;
            this.btnGreen.Click += new System.EventHandler(this.btnGreen_Click);
            // 
            // btnBlue
            // 
            this.btnBlue.BackColor = System.Drawing.Color.Blue;
            this.btnBlue.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnBlue.FlatAppearance.BorderSize = 0;
            this.btnBlue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlue.Location = new System.Drawing.Point(34, 25);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(25, 25);
            this.btnBlue.TabIndex = 1;
            this.btnBlue.UseVisualStyleBackColor = false;
            this.btnBlue.Click += new System.EventHandler(this.btnBlue_Click);
            // 
            // btnRed
            // 
            this.btnRed.BackColor = System.Drawing.Color.Red;
            this.btnRed.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnRed.FlatAppearance.BorderSize = 0;
            this.btnRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRed.Location = new System.Drawing.Point(3, 25);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(25, 25);
            this.btnRed.TabIndex = 0;
            this.btnRed.UseVisualStyleBackColor = false;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // pnlLineWidth
            // 
            this.pnlLineWidth.Controls.Add(this.trbLineWidth);
            this.pnlLineWidth.Controls.Add(this.txbLineWidth);
            this.pnlLineWidth.Location = new System.Drawing.Point(0, 155);
            this.pnlLineWidth.Name = "pnlLineWidth";
            this.pnlLineWidth.Size = new System.Drawing.Size(164, 72);
            this.pnlLineWidth.TabIndex = 0;
            // 
            // trbLineWidth
            // 
            this.trbLineWidth.Location = new System.Drawing.Point(3, 23);
            this.trbLineWidth.Name = "trbLineWidth";
            this.trbLineWidth.Size = new System.Drawing.Size(155, 45);
            this.trbLineWidth.TabIndex = 9;
            this.trbLineWidth.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // txbLineWidth
            // 
            this.txbLineWidth.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txbLineWidth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbLineWidth.Location = new System.Drawing.Point(3, 3);
            this.txbLineWidth.Name = "txbLineWidth";
            this.txbLineWidth.ReadOnly = true;
            this.txbLineWidth.Size = new System.Drawing.Size(99, 16);
            this.txbLineWidth.TabIndex = 8;
            this.txbLineWidth.Text = "Line width";
            // 
            // btnBrown
            // 
            this.btnBrown.BackColor = System.Drawing.Color.Brown;
            this.btnBrown.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnBrown.FlatAppearance.BorderSize = 0;
            this.btnBrown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrown.Location = new System.Drawing.Point(3, 56);
            this.btnBrown.Name = "btnBrown";
            this.btnBrown.Size = new System.Drawing.Size(25, 25);
            this.btnBrown.TabIndex = 8;
            this.btnBrown.UseVisualStyleBackColor = false;
            this.btnBrown.Click += new System.EventHandler(this.btnBrown_Click);
            // 
            // btnOrange
            // 
            this.btnOrange.BackColor = System.Drawing.Color.Orange;
            this.btnOrange.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnOrange.FlatAppearance.BorderSize = 0;
            this.btnOrange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrange.Location = new System.Drawing.Point(34, 56);
            this.btnOrange.Name = "btnOrange";
            this.btnOrange.Size = new System.Drawing.Size(25, 25);
            this.btnOrange.TabIndex = 9;
            this.btnOrange.UseVisualStyleBackColor = false;
            this.btnOrange.Click += new System.EventHandler(this.btnOrange_Click);
            // 
            // btnAqua
            // 
            this.btnAqua.BackColor = System.Drawing.Color.Aqua;
            this.btnAqua.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnAqua.FlatAppearance.BorderSize = 0;
            this.btnAqua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAqua.Location = new System.Drawing.Point(65, 56);
            this.btnAqua.Name = "btnAqua";
            this.btnAqua.Size = new System.Drawing.Size(25, 25);
            this.btnAqua.TabIndex = 10;
            this.btnAqua.UseVisualStyleBackColor = false;
            this.btnAqua.Click += new System.EventHandler(this.btnAqua_Click);
            // 
            // btnPurple
            // 
            this.btnPurple.BackColor = System.Drawing.Color.Purple;
            this.btnPurple.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnPurple.FlatAppearance.BorderSize = 0;
            this.btnPurple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPurple.Location = new System.Drawing.Point(96, 56);
            this.btnPurple.Name = "btnPurple";
            this.btnPurple.Size = new System.Drawing.Size(25, 25);
            this.btnPurple.TabIndex = 11;
            this.btnPurple.UseVisualStyleBackColor = false;
            this.btnPurple.Click += new System.EventHandler(this.btnPurple_Click);
            // 
            // btnGray
            // 
            this.btnGray.BackColor = System.Drawing.Color.Gray;
            this.btnGray.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnGray.FlatAppearance.BorderSize = 0;
            this.btnGray.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGray.Location = new System.Drawing.Point(130, 56);
            this.btnGray.Name = "btnGray";
            this.btnGray.Size = new System.Drawing.Size(25, 25);
            this.btnGray.TabIndex = 12;
            this.btnGray.UseVisualStyleBackColor = false;
            this.btnGray.Click += new System.EventHandler(this.btnGray_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlDrawPad);
            this.Controls.Add(this.pnlToolBox);
            this.Name = "frmMain";
            this.Text = "Graphics editor";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlToolBox.ResumeLayout(false);
            this.pnlCoordinates.ResumeLayout(false);
            this.pnlCoordinates.PerformLayout();
            this.pnlColors.ResumeLayout(false);
            this.pnlColors.PerformLayout();
            this.pnlLineWidth.ResumeLayout(false);
            this.pnlLineWidth.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbLineWidth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbFigures;
        private System.Windows.Forms.MaskedTextBox mtbCoords2;
        private System.Windows.Forms.MaskedTextBox mtbCoords1;
        private System.Windows.Forms.MaskedTextBox mtbCoords3;
        private System.Windows.Forms.Button btnAddFigure;
        private System.Windows.Forms.TextBox txbXY;
        private System.Windows.Forms.Panel pnlDrawPad;
        private System.Windows.Forms.Panel pnlToolBox;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnBlack;
        private System.Windows.Forms.Panel pnlColors;
        private System.Windows.Forms.Button btnYellow;
        private System.Windows.Forms.Button btnGreen;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.TextBox txbColors;
        private System.Windows.Forms.Panel pnlLineWidth;
        private System.Windows.Forms.TrackBar trbLineWidth;
        private System.Windows.Forms.TextBox txbLineWidth;
        private System.Windows.Forms.Panel pnlCoordinates;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnGray;
        private System.Windows.Forms.Button btnPurple;
        private System.Windows.Forms.Button btnAqua;
        private System.Windows.Forms.Button btnOrange;
        private System.Windows.Forms.Button btnBrown;
    }
}
