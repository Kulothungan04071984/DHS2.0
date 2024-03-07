namespace VPGNewOne
{
    partial class DHS_2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DHS_2));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.mnuVPG = new System.Windows.Forms.MenuStrip();
            this.logFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbVPG = new System.Windows.Forms.PictureBox();
            this.grpVPG = new System.Windows.Forms.GroupBox();
            this.aggeVPG = new System.Windows.Forms.AGauge();
            this.mtbGauge = new MetroFramework.Controls.MetroTabControl();
            this.mtpChart = new MetroFramework.Controls.MetroTabPage();
            this.chtVPG = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.mtpLinegraph = new MetroFramework.Controls.MetroTabPage();
            this.chtGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblTemp = new System.Windows.Forms.Label();
            this.pnlCel = new System.Windows.Forms.Panel();
            this.lblCel = new System.Windows.Forms.Label();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.mtrtbWeight = new MetroFramework.Controls.MetroTabControl();
            this.mtrtpLoad = new MetroFramework.Controls.MetroTabPage();
            this.pnlWeight = new System.Windows.Forms.Panel();
            this.lblKg = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.mtrtbFilters = new MetroFramework.Controls.MetroTabControl();
            this.mtrtpWeightformat = new MetroFramework.Controls.MetroTabPage();
            this.mtrtpFilters = new MetroFramework.Controls.MetroTabPage();
            this.mtrtpCom = new MetroFramework.Controls.MetroTabPage();
            this.mtrtpWeightstatus = new MetroFramework.Controls.MetroTabPage();
            this.mtrtpCali = new MetroFramework.Controls.MetroTabPage();
            this.mtrtpViewall = new MetroFramework.Controls.MetroTabPage();
            this.mtrtpGraph = new MetroFramework.Controls.MetroTabPage();
            this.btnIpConnect = new System.Windows.Forms.Button();
            this.timerDHS = new System.Windows.Forms.Timer(this.components);
            this.mnuVPG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVPG)).BeginInit();
            this.grpVPG.SuspendLayout();
            this.mtbGauge.SuspendLayout();
            this.mtpChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtVPG)).BeginInit();
            this.mtpLinegraph.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtGraph)).BeginInit();
            this.pnlCel.SuspendLayout();
            this.mtrtbWeight.SuspendLayout();
            this.mtrtpLoad.SuspendLayout();
            this.pnlWeight.SuspendLayout();
            this.mtrtbFilters.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuVPG
            // 
            this.mnuVPG.BackColor = System.Drawing.Color.SkyBlue;
            this.mnuVPG.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logFileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mnuVPG.Location = new System.Drawing.Point(0, 0);
            this.mnuVPG.Name = "mnuVPG";
            this.mnuVPG.Size = new System.Drawing.Size(1244, 24);
            this.mnuVPG.TabIndex = 0;
            this.mnuVPG.Text = "menuStrip1";
            // 
            // logFileToolStripMenuItem
            // 
            this.logFileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("logFileToolStripMenuItem.Image")));
            this.logFileToolStripMenuItem.Name = "logFileToolStripMenuItem";
            this.logFileToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.logFileToolStripMenuItem.Text = "Log File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editToolStripMenuItem.Image")));
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripMenuItem.Image")));
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // pbVPG
            // 
            this.pbVPG.Image = ((System.Drawing.Image)(resources.GetObject("pbVPG.Image")));
            this.pbVPG.Location = new System.Drawing.Point(3, 28);
            this.pbVPG.Name = "pbVPG";
            this.pbVPG.Size = new System.Drawing.Size(130, 51);
            this.pbVPG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbVPG.TabIndex = 2;
            this.pbVPG.TabStop = false;
            // 
            // grpVPG
            // 
            this.grpVPG.BackColor = System.Drawing.Color.SkyBlue;
            this.grpVPG.Controls.Add(this.aggeVPG);
            this.grpVPG.Controls.Add(this.mtbGauge);
            this.grpVPG.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpVPG.Location = new System.Drawing.Point(37, 108);
            this.grpVPG.Name = "grpVPG";
            this.grpVPG.Size = new System.Drawing.Size(565, 561);
            this.grpVPG.TabIndex = 3;
            this.grpVPG.TabStop = false;
            this.grpVPG.Text = "Gauge";
            // 
            // aggeVPG
            // 
            this.aggeVPG.BackColor = System.Drawing.SystemColors.Control;
            this.aggeVPG.BaseArcColor = System.Drawing.Color.DodgerBlue;
            this.aggeVPG.BaseArcRadius = 80;
            this.aggeVPG.BaseArcStart = 135;
            this.aggeVPG.BaseArcSweep = 270;
            this.aggeVPG.BaseArcWidth = 2;
            this.aggeVPG.Center = new System.Drawing.Point(100, 100);
            this.aggeVPG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aggeVPG.Location = new System.Drawing.Point(173, 11);
            this.aggeVPG.MaxValue = 100F;
            this.aggeVPG.MinValue = 0F;
            this.aggeVPG.Name = "aggeVPG";
            this.aggeVPG.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Magenta;
            this.aggeVPG.NeedleColor2 = System.Drawing.Color.Gold;
            this.aggeVPG.NeedleRadius = 80;
            this.aggeVPG.NeedleType = System.Windows.Forms.NeedleType.Advance;
            this.aggeVPG.NeedleWidth = 2;
            this.aggeVPG.ScaleLinesInterColor = System.Drawing.Color.RosyBrown;
            this.aggeVPG.ScaleLinesInterInnerRadius = 73;
            this.aggeVPG.ScaleLinesInterOuterRadius = 80;
            this.aggeVPG.ScaleLinesInterWidth = 1;
            this.aggeVPG.ScaleLinesMajorColor = System.Drawing.Color.DarkGray;
            this.aggeVPG.ScaleLinesMajorInnerRadius = 70;
            this.aggeVPG.ScaleLinesMajorOuterRadius = 80;
            this.aggeVPG.ScaleLinesMajorStepValue = 50F;
            this.aggeVPG.ScaleLinesMajorWidth = 2;
            this.aggeVPG.ScaleLinesMinorColor = System.Drawing.Color.DodgerBlue;
            this.aggeVPG.ScaleLinesMinorInnerRadius = 75;
            this.aggeVPG.ScaleLinesMinorOuterRadius = 80;
            this.aggeVPG.ScaleLinesMinorTicks = 9;
            this.aggeVPG.ScaleLinesMinorWidth = 1;
            this.aggeVPG.ScaleNumbersColor = System.Drawing.Color.MidnightBlue;
            this.aggeVPG.ScaleNumbersFormat = null;
            this.aggeVPG.ScaleNumbersRadius = 95;
            this.aggeVPG.ScaleNumbersRotation = 0;
            this.aggeVPG.ScaleNumbersStartScaleLine = 0;
            this.aggeVPG.ScaleNumbersStepScaleLines = 1;
            this.aggeVPG.Size = new System.Drawing.Size(209, 180);
            this.aggeVPG.TabIndex = 1;
            this.aggeVPG.Text = "aGauge1";
            this.aggeVPG.Value = 0F;
            // 
            // mtbGauge
            // 
            this.mtbGauge.Controls.Add(this.mtpChart);
            this.mtbGauge.Controls.Add(this.mtpLinegraph);
            this.mtbGauge.Location = new System.Drawing.Point(6, 197);
            this.mtbGauge.Name = "mtbGauge";
            this.mtbGauge.SelectedIndex = 0;
            this.mtbGauge.Size = new System.Drawing.Size(553, 333);
            this.mtbGauge.TabIndex = 2;
            this.mtbGauge.UseCustomBackColor = true;
            this.mtbGauge.UseCustomForeColor = true;
            this.mtbGauge.UseSelectable = true;
            this.mtbGauge.UseStyleColors = true;
            // 
            // mtpChart
            // 
            this.mtpChart.Controls.Add(this.chtVPG);
            this.mtpChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtpChart.ForeColor = System.Drawing.Color.Black;
            this.mtpChart.HorizontalScrollbarBarColor = true;
            this.mtpChart.HorizontalScrollbarHighlightOnWheel = false;
            this.mtpChart.HorizontalScrollbarSize = 10;
            this.mtpChart.Location = new System.Drawing.Point(4, 38);
            this.mtpChart.Name = "mtpChart";
            this.mtpChart.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mtpChart.Size = new System.Drawing.Size(545, 291);
            this.mtpChart.TabIndex = 0;
            this.mtpChart.Text = "Chart";
            this.mtpChart.VerticalScrollbarBarColor = true;
            this.mtpChart.VerticalScrollbarHighlightOnWheel = false;
            this.mtpChart.VerticalScrollbarSize = 10;
            // 
            // chtVPG
            // 
            this.chtVPG.BackColor = System.Drawing.Color.SkyBlue;
            this.chtVPG.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.HorizontalCenter;
            chartArea1.Name = "ChartArea1";
            this.chtVPG.ChartAreas.Add(chartArea1);
            this.chtVPG.Cursor = System.Windows.Forms.Cursors.Default;
            legend1.Name = "Legend1";
            this.chtVPG.Legends.Add(legend1);
            this.chtVPG.Location = new System.Drawing.Point(-1, 3);
            this.chtVPG.Name = "chtVPG";
            this.chtVPG.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chtVPG.Series.Add(series1);
            this.chtVPG.Size = new System.Drawing.Size(546, 263);
            this.chtVPG.TabIndex = 2;
            this.chtVPG.Text = "chart1";
            // 
            // mtpLinegraph
            // 
            this.mtpLinegraph.Controls.Add(this.chtGraph);
            this.mtpLinegraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtpLinegraph.HorizontalScrollbarBarColor = true;
            this.mtpLinegraph.HorizontalScrollbarHighlightOnWheel = false;
            this.mtpLinegraph.HorizontalScrollbarSize = 10;
            this.mtpLinegraph.Location = new System.Drawing.Point(4, 38);
            this.mtpLinegraph.Name = "mtpLinegraph";
            this.mtpLinegraph.Size = new System.Drawing.Size(545, 291);
            this.mtpLinegraph.TabIndex = 1;
            this.mtpLinegraph.Text = "Graph";
            this.mtpLinegraph.VerticalScrollbarBarColor = true;
            this.mtpLinegraph.VerticalScrollbarHighlightOnWheel = false;
            this.mtpLinegraph.VerticalScrollbarSize = 10;
            // 
            // chtGraph
            // 
            this.chtGraph.BackColor = System.Drawing.Color.SkyBlue;
            this.chtGraph.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.HorizontalCenter;
            chartArea2.Name = "ChartArea1";
            this.chtGraph.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chtGraph.Legends.Add(legend2);
            this.chtGraph.Location = new System.Drawing.Point(3, 12);
            this.chtGraph.Name = "chtGraph";
            this.chtGraph.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chtGraph.Series.Add(series2);
            this.chtGraph.Size = new System.Drawing.Size(535, 262);
            this.chtGraph.TabIndex = 2;
            this.chtGraph.Text = "chart1";
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.BackColor = System.Drawing.Color.SkyBlue;
            this.lblTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemp.Location = new System.Drawing.Point(1021, 41);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(111, 20);
            this.lblTemp.TabIndex = 4;
            this.lblTemp.Text = "Temperature";
            // 
            // pnlCel
            // 
            this.pnlCel.BackColor = System.Drawing.Color.SkyBlue;
            this.pnlCel.Controls.Add(this.lblCel);
            this.pnlCel.Controls.Add(this.txtTemp);
            this.pnlCel.Location = new System.Drawing.Point(1138, 41);
            this.pnlCel.Name = "pnlCel";
            this.pnlCel.Size = new System.Drawing.Size(94, 20);
            this.pnlCel.TabIndex = 5;
            // 
            // lblCel
            // 
            this.lblCel.AutoSize = true;
            this.lblCel.BackColor = System.Drawing.Color.SkyBlue;
            this.lblCel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCel.Location = new System.Drawing.Point(69, 3);
            this.lblCel.Name = "lblCel";
            this.lblCel.Size = new System.Drawing.Size(22, 16);
            this.lblCel.TabIndex = 6;
            this.lblCel.Text = "°C";
            // 
            // txtTemp
            // 
            this.txtTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTemp.Location = new System.Drawing.Point(3, 0);
            this.txtTemp.Multiline = true;
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(60, 20);
            this.txtTemp.TabIndex = 6;
            // 
            // mtrtbWeight
            // 
            this.mtrtbWeight.Controls.Add(this.mtrtpLoad);
            this.mtrtbWeight.Controls.Add(this.mtrtpWeightstatus);
            this.mtrtbWeight.Controls.Add(this.mtrtpCali);
            this.mtrtbWeight.Controls.Add(this.mtrtpViewall);
            this.mtrtbWeight.Controls.Add(this.mtrtpGraph);
            this.mtrtbWeight.FontWeight = MetroFramework.MetroTabControlWeight.Regular;
            this.mtrtbWeight.Location = new System.Drawing.Point(623, 108);
            this.mtrtbWeight.Name = "mtrtbWeight";
            this.mtrtbWeight.SelectedIndex = 4;
            this.mtrtbWeight.Size = new System.Drawing.Size(621, 594);
            this.mtrtbWeight.TabIndex = 6;
            this.mtrtbWeight.UseSelectable = true;
            // 
            // mtrtpLoad
            // 
            this.mtrtpLoad.Controls.Add(this.pnlWeight);
            this.mtrtpLoad.Controls.Add(this.lblWeight);
            this.mtrtpLoad.Controls.Add(this.mtrtbFilters);
            this.mtrtpLoad.HorizontalScrollbarBarColor = true;
            this.mtrtpLoad.HorizontalScrollbarHighlightOnWheel = false;
            this.mtrtpLoad.HorizontalScrollbarSize = 10;
            this.mtrtpLoad.Location = new System.Drawing.Point(4, 38);
            this.mtrtpLoad.Name = "mtrtpLoad";
            this.mtrtpLoad.Size = new System.Drawing.Size(613, 552);
            this.mtrtpLoad.TabIndex = 1;
            this.mtrtpLoad.Text = "LoadCell Setup";
            this.mtrtpLoad.VerticalScrollbarBarColor = true;
            this.mtrtpLoad.VerticalScrollbarHighlightOnWheel = false;
            this.mtrtpLoad.VerticalScrollbarSize = 10;
            // 
            // pnlWeight
            // 
            this.pnlWeight.BackColor = System.Drawing.Color.SkyBlue;
            this.pnlWeight.Controls.Add(this.lblKg);
            this.pnlWeight.Controls.Add(this.txtWeight);
            this.pnlWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlWeight.Location = new System.Drawing.Point(203, 11);
            this.pnlWeight.Name = "pnlWeight";
            this.pnlWeight.Size = new System.Drawing.Size(95, 20);
            this.pnlWeight.TabIndex = 4;
            // 
            // lblKg
            // 
            this.lblKg.AutoSize = true;
            this.lblKg.BackColor = System.Drawing.Color.SkyBlue;
            this.lblKg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKg.Location = new System.Drawing.Point(64, 1);
            this.lblKg.Name = "lblKg";
            this.lblKg.Size = new System.Drawing.Size(25, 16);
            this.lblKg.TabIndex = 5;
            this.lblKg.Text = "Kg";
            // 
            // txtWeight
            // 
            this.txtWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeight.Location = new System.Drawing.Point(0, 0);
            this.txtWeight.Multiline = true;
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(62, 20);
            this.txtWeight.TabIndex = 5;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.BackColor = System.Drawing.Color.SkyBlue;
            this.lblWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.Location = new System.Drawing.Point(132, 11);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(65, 20);
            this.lblWeight.TabIndex = 3;
            this.lblWeight.Text = "Weight";
            // 
            // mtrtbFilters
            // 
            this.mtrtbFilters.Controls.Add(this.mtrtpWeightformat);
            this.mtrtbFilters.Controls.Add(this.mtrtpFilters);
            this.mtrtbFilters.Controls.Add(this.mtrtpCom);
            this.mtrtbFilters.Location = new System.Drawing.Point(3, 39);
            this.mtrtbFilters.Name = "mtrtbFilters";
            this.mtrtbFilters.SelectedIndex = 2;
            this.mtrtbFilters.Size = new System.Drawing.Size(589, 466);
            this.mtrtbFilters.TabIndex = 2;
            this.mtrtbFilters.UseSelectable = true;
            // 
            // mtrtpWeightformat
            // 
            this.mtrtpWeightformat.HorizontalScrollbarBarColor = true;
            this.mtrtpWeightformat.HorizontalScrollbarHighlightOnWheel = false;
            this.mtrtpWeightformat.HorizontalScrollbarSize = 10;
            this.mtrtpWeightformat.Location = new System.Drawing.Point(4, 38);
            this.mtrtpWeightformat.Name = "mtrtpWeightformat";
            this.mtrtpWeightformat.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mtrtpWeightformat.Size = new System.Drawing.Size(581, 424);
            this.mtrtpWeightformat.TabIndex = 0;
            this.mtrtpWeightformat.Text = "Weight Format/Zero/Tare/Motion";
            this.mtrtpWeightformat.VerticalScrollbarBarColor = true;
            this.mtrtpWeightformat.VerticalScrollbarHighlightOnWheel = false;
            this.mtrtpWeightformat.VerticalScrollbarSize = 10;
            // 
            // mtrtpFilters
            // 
            this.mtrtpFilters.HorizontalScrollbarBarColor = true;
            this.mtrtpFilters.HorizontalScrollbarHighlightOnWheel = false;
            this.mtrtpFilters.HorizontalScrollbarSize = 10;
            this.mtrtpFilters.Location = new System.Drawing.Point(4, 38);
            this.mtrtpFilters.Name = "mtrtpFilters";
            this.mtrtpFilters.Size = new System.Drawing.Size(581, 424);
            this.mtrtpFilters.TabIndex = 1;
            this.mtrtpFilters.Text = "Filters/Peak/Grab/Setpoints";
            this.mtrtpFilters.VerticalScrollbarBarColor = true;
            this.mtrtpFilters.VerticalScrollbarHighlightOnWheel = false;
            this.mtrtpFilters.VerticalScrollbarSize = 10;
            // 
            // mtrtpCom
            // 
            this.mtrtpCom.HorizontalScrollbarBarColor = true;
            this.mtrtpCom.HorizontalScrollbarHighlightOnWheel = false;
            this.mtrtpCom.HorizontalScrollbarSize = 10;
            this.mtrtpCom.Location = new System.Drawing.Point(4, 38);
            this.mtrtpCom.Name = "mtrtpCom";
            this.mtrtpCom.Size = new System.Drawing.Size(581, 424);
            this.mtrtpCom.TabIndex = 2;
            this.mtrtpCom.Text = "Com Ports";
            this.mtrtpCom.VerticalScrollbarBarColor = true;
            this.mtrtpCom.VerticalScrollbarHighlightOnWheel = false;
            this.mtrtpCom.VerticalScrollbarSize = 10;
            // 
            // mtrtpWeightstatus
            // 
            this.mtrtpWeightstatus.HorizontalScrollbarBarColor = true;
            this.mtrtpWeightstatus.HorizontalScrollbarHighlightOnWheel = false;
            this.mtrtpWeightstatus.HorizontalScrollbarSize = 10;
            this.mtrtpWeightstatus.Location = new System.Drawing.Point(4, 38);
            this.mtrtpWeightstatus.Name = "mtrtpWeightstatus";
            this.mtrtpWeightstatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mtrtpWeightstatus.Size = new System.Drawing.Size(613, 552);
            this.mtrtpWeightstatus.TabIndex = 0;
            this.mtrtpWeightstatus.Text = "Weighing Display & Status";
            this.mtrtpWeightstatus.VerticalScrollbarBarColor = true;
            this.mtrtpWeightstatus.VerticalScrollbarHighlightOnWheel = false;
            this.mtrtpWeightstatus.VerticalScrollbarSize = 10;
            // 
            // mtrtpCali
            // 
            this.mtrtpCali.HorizontalScrollbarBarColor = true;
            this.mtrtpCali.HorizontalScrollbarHighlightOnWheel = false;
            this.mtrtpCali.HorizontalScrollbarSize = 10;
            this.mtrtpCali.Location = new System.Drawing.Point(4, 38);
            this.mtrtpCali.Name = "mtrtpCali";
            this.mtrtpCali.Size = new System.Drawing.Size(613, 552);
            this.mtrtpCali.TabIndex = 2;
            this.mtrtpCali.Text = "Calibration";
            this.mtrtpCali.VerticalScrollbarBarColor = true;
            this.mtrtpCali.VerticalScrollbarHighlightOnWheel = false;
            this.mtrtpCali.VerticalScrollbarSize = 10;
            // 
            // mtrtpViewall
            // 
            this.mtrtpViewall.HorizontalScrollbarBarColor = true;
            this.mtrtpViewall.HorizontalScrollbarHighlightOnWheel = false;
            this.mtrtpViewall.HorizontalScrollbarSize = 10;
            this.mtrtpViewall.Location = new System.Drawing.Point(4, 38);
            this.mtrtpViewall.Name = "mtrtpViewall";
            this.mtrtpViewall.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mtrtpViewall.Size = new System.Drawing.Size(613, 552);
            this.mtrtpViewall.TabIndex = 3;
            this.mtrtpViewall.Text = "View All";
            this.mtrtpViewall.VerticalScrollbarBarColor = true;
            this.mtrtpViewall.VerticalScrollbarHighlightOnWheel = false;
            this.mtrtpViewall.VerticalScrollbarSize = 10;
            // 
            // mtrtpGraph
            // 
            this.mtrtpGraph.HorizontalScrollbarBarColor = true;
            this.mtrtpGraph.HorizontalScrollbarHighlightOnWheel = false;
            this.mtrtpGraph.HorizontalScrollbarSize = 10;
            this.mtrtpGraph.Location = new System.Drawing.Point(4, 38);
            this.mtrtpGraph.Name = "mtrtpGraph";
            this.mtrtpGraph.Size = new System.Drawing.Size(613, 552);
            this.mtrtpGraph.TabIndex = 4;
            this.mtrtpGraph.Text = "Graph";
            this.mtrtpGraph.VerticalScrollbarBarColor = true;
            this.mtrtpGraph.VerticalScrollbarHighlightOnWheel = false;
            this.mtrtpGraph.VerticalScrollbarSize = 10;
            // 
            // btnIpConnect
            // 
            this.btnIpConnect.BackColor = System.Drawing.Color.SkyBlue;
            this.btnIpConnect.Location = new System.Drawing.Point(627, 57);
            this.btnIpConnect.Name = "btnIpConnect";
            this.btnIpConnect.Size = new System.Drawing.Size(168, 41);
            this.btnIpConnect.TabIndex = 7;
            this.btnIpConnect.Text = "IP CONNECT";
            this.btnIpConnect.UseVisualStyleBackColor = false;
            this.btnIpConnect.Click += new System.EventHandler(this.btnIpConnect_Click);
            // 
            // timerDHS
            // 
            this.timerDHS.Tick += new System.EventHandler(this.timerDHS_Tick);
            // 
            // DHS_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 648);
            this.Controls.Add(this.btnIpConnect);
            this.Controls.Add(this.mtrtbWeight);
            this.Controls.Add(this.pnlCel);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.grpVPG);
            this.Controls.Add(this.pbVPG);
            this.Controls.Add(this.mnuVPG);
            this.MainMenuStrip = this.mnuVPG;
            this.Name = "DHS_2";
            this.Text = "VPG";
            this.Load += new System.EventHandler(this.DHS_2_Load);
            this.mnuVPG.ResumeLayout(false);
            this.mnuVPG.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVPG)).EndInit();
            this.grpVPG.ResumeLayout(false);
            this.mtbGauge.ResumeLayout(false);
            this.mtpChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chtVPG)).EndInit();
            this.mtpLinegraph.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chtGraph)).EndInit();
            this.pnlCel.ResumeLayout(false);
            this.pnlCel.PerformLayout();
            this.mtrtbWeight.ResumeLayout(false);
            this.mtrtpLoad.ResumeLayout(false);
            this.mtrtpLoad.PerformLayout();
            this.pnlWeight.ResumeLayout(false);
            this.pnlWeight.PerformLayout();
            this.mtrtbFilters.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuVPG;
        private System.Windows.Forms.ToolStripMenuItem logFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbVPG;
        private System.Windows.Forms.GroupBox grpVPG;
        private MetroFramework.Controls.MetroTabControl mtbGauge;
        private MetroFramework.Controls.MetroTabPage mtpChart;
        private MetroFramework.Controls.MetroTabPage mtpLinegraph;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtVPG;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtGraph;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Panel pnlCel;
        private System.Windows.Forms.Label lblCel;
        private System.Windows.Forms.TextBox txtTemp;
        private MetroFramework.Controls.MetroTabControl mtrtbWeight;
        private MetroFramework.Controls.MetroTabPage mtrtpWeightstatus;
        private MetroFramework.Controls.MetroTabPage mtrtpLoad;
        private MetroFramework.Controls.MetroTabPage mtrtpCali;
        private MetroFramework.Controls.MetroTabPage mtrtpViewall;
        private MetroFramework.Controls.MetroTabPage mtrtpGraph;
        private MetroFramework.Controls.MetroTabControl mtrtbFilters;
        private MetroFramework.Controls.MetroTabPage mtrtpWeightformat;
        private MetroFramework.Controls.MetroTabPage mtrtpFilters;
        private MetroFramework.Controls.MetroTabPage mtrtpCom;
        private System.Windows.Forms.Panel pnlWeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label lblKg;
        private System.Windows.Forms.Button btnIpConnect;
        private System.Windows.Forms.AGauge aggeVPG;
        private System.Windows.Forms.Timer timerDHS;
    }
}

