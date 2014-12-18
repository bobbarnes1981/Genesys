namespace GenesysGUI
{
    partial class FormExperiment
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
            this.labelPath = new System.Windows.Forms.Label();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.groupBoxGrid = new System.Windows.Forms.GroupBox();
            this.numericUpDownLimit = new System.Windows.Forms.NumericUpDown();
            this.labelLimit = new System.Windows.Forms.Label();
            this.groupBoxBreeding = new System.Windows.Forms.GroupBox();
            this.labelBreeders = new System.Windows.Forms.Label();
            this.numericUpDownBreeders = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMutation = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCrossover = new System.Windows.Forms.NumericUpDown();
            this.labelMutation = new System.Windows.Forms.Label();
            this.labelCrossover = new System.Windows.Forms.Label();
            this.groupBoxRun = new System.Windows.Forms.GroupBox();
            this.numericUpDownPopulation = new System.Windows.Forms.NumericUpDown();
            this.labelPopulation = new System.Windows.Forms.Label();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonRun = new System.Windows.Forms.Button();
            this.numericUpDownGenerations = new System.Windows.Forms.NumericUpDown();
            this.labelGenerations = new System.Windows.Forms.Label();
            this.statusStripExperiment = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBarRun = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabelGenerations = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBoxGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLimit)).BeginInit();
            this.groupBoxBreeding.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBreeders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMutation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCrossover)).BeginInit();
            this.groupBoxRun.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPopulation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGenerations)).BeginInit();
            this.statusStripExperiment.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Location = new System.Drawing.Point(6, 47);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(29, 13);
            this.labelPath.TabIndex = 0;
            this.labelPath.Text = "Path";
            // 
            // textBoxPath
            // 
            this.textBoxPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPath.Location = new System.Drawing.Point(76, 44);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.ReadOnly = true;
            this.textBoxPath.Size = new System.Drawing.Size(164, 20);
            this.textBoxPath.TabIndex = 1;
            // 
            // buttonLoad
            // 
            this.buttonLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLoad.Location = new System.Drawing.Point(246, 42);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(23, 23);
            this.buttonLoad.TabIndex = 2;
            this.buttonLoad.Text = "...";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // groupBoxGrid
            // 
            this.groupBoxGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxGrid.Controls.Add(this.numericUpDownLimit);
            this.groupBoxGrid.Controls.Add(this.labelLimit);
            this.groupBoxGrid.Controls.Add(this.textBoxPath);
            this.groupBoxGrid.Controls.Add(this.labelPath);
            this.groupBoxGrid.Controls.Add(this.buttonLoad);
            this.groupBoxGrid.Location = new System.Drawing.Point(12, 12);
            this.groupBoxGrid.Name = "groupBoxGrid";
            this.groupBoxGrid.Size = new System.Drawing.Size(278, 75);
            this.groupBoxGrid.TabIndex = 3;
            this.groupBoxGrid.TabStop = false;
            this.groupBoxGrid.Text = "Grid";
            // 
            // numericUpDownLimit
            // 
            this.numericUpDownLimit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownLimit.Location = new System.Drawing.Point(76, 19);
            this.numericUpDownLimit.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownLimit.Name = "numericUpDownLimit";
            this.numericUpDownLimit.Size = new System.Drawing.Size(193, 20);
            this.numericUpDownLimit.TabIndex = 4;
            this.numericUpDownLimit.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // labelLimit
            // 
            this.labelLimit.AutoSize = true;
            this.labelLimit.Location = new System.Drawing.Point(6, 21);
            this.labelLimit.Name = "labelLimit";
            this.labelLimit.Size = new System.Drawing.Size(28, 13);
            this.labelLimit.TabIndex = 3;
            this.labelLimit.Text = "Limit";
            // 
            // groupBoxBreeding
            // 
            this.groupBoxBreeding.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxBreeding.Controls.Add(this.labelBreeders);
            this.groupBoxBreeding.Controls.Add(this.numericUpDownBreeders);
            this.groupBoxBreeding.Controls.Add(this.numericUpDownMutation);
            this.groupBoxBreeding.Controls.Add(this.numericUpDownCrossover);
            this.groupBoxBreeding.Controls.Add(this.labelMutation);
            this.groupBoxBreeding.Controls.Add(this.labelCrossover);
            this.groupBoxBreeding.Location = new System.Drawing.Point(12, 93);
            this.groupBoxBreeding.Name = "groupBoxBreeding";
            this.groupBoxBreeding.Size = new System.Drawing.Size(278, 105);
            this.groupBoxBreeding.TabIndex = 4;
            this.groupBoxBreeding.TabStop = false;
            this.groupBoxBreeding.Text = "Breeding";
            // 
            // labelBreeders
            // 
            this.labelBreeders.AutoSize = true;
            this.labelBreeders.Location = new System.Drawing.Point(6, 74);
            this.labelBreeders.Name = "labelBreeders";
            this.labelBreeders.Size = new System.Drawing.Size(49, 13);
            this.labelBreeders.TabIndex = 6;
            this.labelBreeders.Text = "Breeders";
            // 
            // numericUpDownBreeders
            // 
            this.numericUpDownBreeders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownBreeders.DecimalPlaces = 3;
            this.numericUpDownBreeders.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDownBreeders.Location = new System.Drawing.Point(76, 72);
            this.numericUpDownBreeders.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDownBreeders.Name = "numericUpDownBreeders";
            this.numericUpDownBreeders.Size = new System.Drawing.Size(193, 20);
            this.numericUpDownBreeders.TabIndex = 5;
            this.numericUpDownBreeders.Value = new decimal(new int[] {
            10,
            0,
            0,
            196608});
            // 
            // numericUpDownMutation
            // 
            this.numericUpDownMutation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownMutation.DecimalPlaces = 3;
            this.numericUpDownMutation.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDownMutation.Location = new System.Drawing.Point(76, 45);
            this.numericUpDownMutation.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMutation.Name = "numericUpDownMutation";
            this.numericUpDownMutation.Size = new System.Drawing.Size(193, 20);
            this.numericUpDownMutation.TabIndex = 4;
            this.numericUpDownMutation.Value = new decimal(new int[] {
            50,
            0,
            0,
            196608});
            // 
            // numericUpDownCrossover
            // 
            this.numericUpDownCrossover.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownCrossover.Cursor = System.Windows.Forms.Cursors.Default;
            this.numericUpDownCrossover.DecimalPlaces = 3;
            this.numericUpDownCrossover.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDownCrossover.Location = new System.Drawing.Point(76, 19);
            this.numericUpDownCrossover.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCrossover.Name = "numericUpDownCrossover";
            this.numericUpDownCrossover.Size = new System.Drawing.Size(193, 20);
            this.numericUpDownCrossover.TabIndex = 3;
            this.numericUpDownCrossover.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // labelMutation
            // 
            this.labelMutation.AutoSize = true;
            this.labelMutation.Location = new System.Drawing.Point(6, 47);
            this.labelMutation.Name = "labelMutation";
            this.labelMutation.Size = new System.Drawing.Size(48, 13);
            this.labelMutation.TabIndex = 2;
            this.labelMutation.Text = "Mutation";
            // 
            // labelCrossover
            // 
            this.labelCrossover.AutoSize = true;
            this.labelCrossover.Location = new System.Drawing.Point(6, 21);
            this.labelCrossover.Name = "labelCrossover";
            this.labelCrossover.Size = new System.Drawing.Size(54, 13);
            this.labelCrossover.TabIndex = 0;
            this.labelCrossover.Text = "Crossover";
            // 
            // groupBoxRun
            // 
            this.groupBoxRun.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxRun.Controls.Add(this.numericUpDownPopulation);
            this.groupBoxRun.Controls.Add(this.labelPopulation);
            this.groupBoxRun.Controls.Add(this.buttonStop);
            this.groupBoxRun.Controls.Add(this.buttonRun);
            this.groupBoxRun.Controls.Add(this.numericUpDownGenerations);
            this.groupBoxRun.Controls.Add(this.labelGenerations);
            this.groupBoxRun.Location = new System.Drawing.Point(13, 205);
            this.groupBoxRun.Name = "groupBoxRun";
            this.groupBoxRun.Size = new System.Drawing.Size(277, 109);
            this.groupBoxRun.TabIndex = 5;
            this.groupBoxRun.TabStop = false;
            this.groupBoxRun.Text = "Run";
            // 
            // numericUpDownPopulation
            // 
            this.numericUpDownPopulation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownPopulation.Location = new System.Drawing.Point(75, 19);
            this.numericUpDownPopulation.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
            this.numericUpDownPopulation.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPopulation.Name = "numericUpDownPopulation";
            this.numericUpDownPopulation.Size = new System.Drawing.Size(193, 20);
            this.numericUpDownPopulation.TabIndex = 5;
            this.numericUpDownPopulation.Value = new decimal(new int[] {
            2048,
            0,
            0,
            0});
            // 
            // labelPopulation
            // 
            this.labelPopulation.AutoSize = true;
            this.labelPopulation.Location = new System.Drawing.Point(5, 21);
            this.labelPopulation.Name = "labelPopulation";
            this.labelPopulation.Size = new System.Drawing.Size(57, 13);
            this.labelPopulation.TabIndex = 4;
            this.labelPopulation.Text = "Population";
            // 
            // buttonStop
            // 
            this.buttonStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStop.Enabled = false;
            this.buttonStop.Location = new System.Drawing.Point(112, 71);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 3;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonRun
            // 
            this.buttonRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRun.Location = new System.Drawing.Point(193, 71);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(75, 23);
            this.buttonRun.TabIndex = 2;
            this.buttonRun.Text = "Run";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // numericUpDownGenerations
            // 
            this.numericUpDownGenerations.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownGenerations.Location = new System.Drawing.Point(75, 45);
            this.numericUpDownGenerations.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownGenerations.Name = "numericUpDownGenerations";
            this.numericUpDownGenerations.Size = new System.Drawing.Size(193, 20);
            this.numericUpDownGenerations.TabIndex = 1;
            this.numericUpDownGenerations.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelGenerations
            // 
            this.labelGenerations.AutoSize = true;
            this.labelGenerations.Location = new System.Drawing.Point(5, 47);
            this.labelGenerations.Name = "labelGenerations";
            this.labelGenerations.Size = new System.Drawing.Size(64, 13);
            this.labelGenerations.TabIndex = 0;
            this.labelGenerations.Text = "Generations";
            // 
            // statusStripExperiment
            // 
            this.statusStripExperiment.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelGenerations,
            this.toolStripStatusLabelStatus,
            this.toolStripProgressBarRun});
            this.statusStripExperiment.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.statusStripExperiment.Location = new System.Drawing.Point(0, 325);
            this.statusStripExperiment.Name = "statusStripExperiment";
            this.statusStripExperiment.Size = new System.Drawing.Size(306, 22);
            this.statusStripExperiment.TabIndex = 6;
            this.statusStripExperiment.Text = "statusStrip1";
            // 
            // toolStripStatusLabelStatus
            // 
            this.toolStripStatusLabelStatus.Name = "toolStripStatusLabelStatus";
            this.toolStripStatusLabelStatus.Size = new System.Drawing.Size(26, 17);
            this.toolStripStatusLabelStatus.Text = "Idle";
            // 
            // toolStripProgressBarRun
            // 
            this.toolStripProgressBarRun.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripProgressBarRun.Name = "toolStripProgressBarRun";
            this.toolStripProgressBarRun.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripStatusLabelGenerations
            // 
            this.toolStripStatusLabelGenerations.Name = "toolStripStatusLabelGenerations";
            this.toolStripStatusLabelGenerations.Size = new System.Drawing.Size(41, 17);
            this.toolStripStatusLabelGenerations.Text = "0/0 [0]";
            // 
            // FormExperiment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 347);
            this.Controls.Add(this.statusStripExperiment);
            this.Controls.Add(this.groupBoxRun);
            this.Controls.Add(this.groupBoxBreeding);
            this.Controls.Add(this.groupBoxGrid);
            this.Name = "FormExperiment";
            this.Text = "Experiment";
            this.groupBoxGrid.ResumeLayout(false);
            this.groupBoxGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLimit)).EndInit();
            this.groupBoxBreeding.ResumeLayout(false);
            this.groupBoxBreeding.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBreeders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMutation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCrossover)).EndInit();
            this.groupBoxRun.ResumeLayout(false);
            this.groupBoxRun.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPopulation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGenerations)).EndInit();
            this.statusStripExperiment.ResumeLayout(false);
            this.statusStripExperiment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.GroupBox groupBoxGrid;
        private System.Windows.Forms.NumericUpDown numericUpDownLimit;
        private System.Windows.Forms.Label labelLimit;
        private System.Windows.Forms.GroupBox groupBoxBreeding;
        private System.Windows.Forms.NumericUpDown numericUpDownCrossover;
        private System.Windows.Forms.Label labelMutation;
        private System.Windows.Forms.Label labelCrossover;
        private System.Windows.Forms.Label labelBreeders;
        private System.Windows.Forms.NumericUpDown numericUpDownBreeders;
        private System.Windows.Forms.NumericUpDown numericUpDownMutation;
        private System.Windows.Forms.GroupBox groupBoxRun;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.NumericUpDown numericUpDownGenerations;
        private System.Windows.Forms.Label labelGenerations;
        private System.Windows.Forms.NumericUpDown numericUpDownPopulation;
        private System.Windows.Forms.Label labelPopulation;
        private System.Windows.Forms.StatusStrip statusStripExperiment;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelStatus;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBarRun;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelGenerations;
    }
}