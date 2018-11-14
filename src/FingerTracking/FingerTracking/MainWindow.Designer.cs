namespace FingerTracking
{
    partial class MainWindow
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
            this.trackingImage = new System.Windows.Forms.PictureBox();
            this.colorButton = new System.Windows.Forms.Button();
            this.depthButton = new System.Windows.Forms.Button();
            this.thetaTrackBar = new System.Windows.Forms.TrackBar();
            this.kTrackBar = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.thetaTextBox = new System.Windows.Forms.TextBox();
            this.kTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fingersTextBox1 = new System.Windows.Forms.TextBox();
            this.NearSpaceTextBox = new System.Windows.Forms.TextBox();
            this.NearSpaceTrackBar = new System.Windows.Forms.TrackBar();
            this.AbsoluteCheckBox = new System.Windows.Forms.CheckBox();
            this.colorImage = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.smoothTextBox = new System.Windows.Forms.TextBox();
            this.smoothTrackBar = new System.Windows.Forms.TrackBar();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.checkSameMargins = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textMarginBot = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textMarginTop = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textMarginRight = new System.Windows.Forms.TextBox();
            this.textMarginLeft = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fingersTextBox2 = new System.Windows.Forms.TextBox();
            this.depthImage = new System.Windows.Forms.PictureBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.boxReductionTextBox = new System.Windows.Forms.TextBox();
            this.boxReductionTrackBar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackingImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thetaTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NearSpaceTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorImage)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.smoothTrackBar)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depthImage)).BeginInit();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boxReductionTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // trackingImage
            // 
            this.trackingImage.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.trackingImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.trackingImage.Location = new System.Drawing.Point(502, 60);
            this.trackingImage.Margin = new System.Windows.Forms.Padding(4);
            this.trackingImage.Name = "trackingImage";
            this.trackingImage.Size = new System.Drawing.Size(800, 600);
            this.trackingImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.trackingImage.TabIndex = 0;
            this.trackingImage.TabStop = false;
            // 
            // colorButton
            // 
            this.colorButton.AutoSize = true;
            this.colorButton.Location = new System.Drawing.Point(801, 677);
            this.colorButton.Margin = new System.Windows.Forms.Padding(4);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(100, 28);
            this.colorButton.TabIndex = 1;
            this.colorButton.Text = "Color";
            this.colorButton.UseVisualStyleBackColor = true;
            this.colorButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // depthButton
            // 
            this.depthButton.Location = new System.Drawing.Point(940, 677);
            this.depthButton.Margin = new System.Windows.Forms.Padding(4);
            this.depthButton.Name = "depthButton";
            this.depthButton.Size = new System.Drawing.Size(100, 28);
            this.depthButton.TabIndex = 2;
            this.depthButton.Text = "Depth";
            this.depthButton.UseVisualStyleBackColor = true;
            this.depthButton.Click += new System.EventHandler(this.depthButton_Click);
            // 
            // thetaTrackBar
            // 
            this.thetaTrackBar.Location = new System.Drawing.Point(7, 22);
            this.thetaTrackBar.Margin = new System.Windows.Forms.Padding(4);
            this.thetaTrackBar.Maximum = 50;
            this.thetaTrackBar.Minimum = 10;
            this.thetaTrackBar.Name = "thetaTrackBar";
            this.thetaTrackBar.Size = new System.Drawing.Size(131, 56);
            this.thetaTrackBar.TabIndex = 3;
            this.thetaTrackBar.Value = 35;
            this.thetaTrackBar.Scroll += new System.EventHandler(this.thetaTrackBar_Scroll);
            // 
            // kTrackBar
            // 
            this.kTrackBar.Location = new System.Drawing.Point(7, 22);
            this.kTrackBar.Margin = new System.Windows.Forms.Padding(4);
            this.kTrackBar.Maximum = 80;
            this.kTrackBar.Minimum = 2;
            this.kTrackBar.Name = "kTrackBar";
            this.kTrackBar.Size = new System.Drawing.Size(131, 56);
            this.kTrackBar.TabIndex = 4;
            this.kTrackBar.Value = 15;
            this.kTrackBar.Scroll += new System.EventHandler(this.kTrackBar_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(685, 683);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Image mode";
            // 
            // thetaTextBox
            // 
            this.thetaTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.thetaTextBox.Location = new System.Drawing.Point(146, 22);
            this.thetaTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.thetaTextBox.Name = "thetaTextBox";
            this.thetaTextBox.ReadOnly = true;
            this.thetaTextBox.Size = new System.Drawing.Size(55, 22);
            this.thetaTextBox.TabIndex = 8;
            this.thetaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // kTextBox
            // 
            this.kTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.kTextBox.Location = new System.Drawing.Point(146, 22);
            this.kTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.kTextBox.Name = "kTextBox";
            this.kTextBox.ReadOnly = true;
            this.kTextBox.Size = new System.Drawing.Size(55, 22);
            this.kTextBox.TabIndex = 9;
            this.kTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Hand 1 Fingers";
            // 
            // fingersTextBox1
            // 
            this.fingersTextBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.fingersTextBox1.Location = new System.Drawing.Point(142, 22);
            this.fingersTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.fingersTextBox1.Name = "fingersTextBox1";
            this.fingersTextBox1.ReadOnly = true;
            this.fingersTextBox1.Size = new System.Drawing.Size(55, 22);
            this.fingersTextBox1.TabIndex = 11;
            this.fingersTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NearSpaceTextBox
            // 
            this.NearSpaceTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.NearSpaceTextBox.Location = new System.Drawing.Point(146, 22);
            this.NearSpaceTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.NearSpaceTextBox.Name = "NearSpaceTextBox";
            this.NearSpaceTextBox.ReadOnly = true;
            this.NearSpaceTextBox.Size = new System.Drawing.Size(55, 22);
            this.NearSpaceTextBox.TabIndex = 13;
            this.NearSpaceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NearSpaceTrackBar
            // 
            this.NearSpaceTrackBar.Location = new System.Drawing.Point(7, 22);
            this.NearSpaceTrackBar.Margin = new System.Windows.Forms.Padding(4);
            this.NearSpaceTrackBar.Maximum = 100;
            this.NearSpaceTrackBar.Name = "NearSpaceTrackBar";
            this.NearSpaceTrackBar.Size = new System.Drawing.Size(131, 56);
            this.NearSpaceTrackBar.TabIndex = 14;
            this.NearSpaceTrackBar.Value = 10;
            this.NearSpaceTrackBar.Scroll += new System.EventHandler(this.NearSpaceTrackBar_Scroll);
            // 
            // AbsoluteCheckBox
            // 
            this.AbsoluteCheckBox.AutoSize = true;
            this.AbsoluteCheckBox.Location = new System.Drawing.Point(67, 77);
            this.AbsoluteCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.AbsoluteCheckBox.Name = "AbsoluteCheckBox";
            this.AbsoluteCheckBox.Size = new System.Drawing.Size(85, 21);
            this.AbsoluteCheckBox.TabIndex = 15;
            this.AbsoluteCheckBox.Text = "Absolute";
            this.AbsoluteCheckBox.UseVisualStyleBackColor = true;
            // 
            // colorImage
            // 
            this.colorImage.BackColor = System.Drawing.SystemColors.ControlText;
            this.colorImage.Location = new System.Drawing.Point(13, 60);
            this.colorImage.Margin = new System.Windows.Forms.Padding(4);
            this.colorImage.Name = "colorImage";
            this.colorImage.Size = new System.Drawing.Size(220, 165);
            this.colorImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.colorImage.TabIndex = 16;
            this.colorImage.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(477, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(364, 32);
            this.label6.TabIndex = 17;
            this.label6.Text = "Fingertracking Test Panel";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.thetaTrackBar);
            this.groupBox1.Controls.Add(this.thetaTextBox);
            this.groupBox1.Location = new System.Drawing.Point(13, 27);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 86);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Theta";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox8);
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.groupBox7);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Location = new System.Drawing.Point(12, 232);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(468, 428);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parameters";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.smoothTextBox);
            this.groupBox6.Controls.Add(this.smoothTrackBar);
            this.groupBox6.Location = new System.Drawing.Point(244, 211);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(211, 86);
            this.groupBox6.TabIndex = 20;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Smooth";
            // 
            // smoothTextBox
            // 
            this.smoothTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.smoothTextBox.Location = new System.Drawing.Point(146, 22);
            this.smoothTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.smoothTextBox.Name = "smoothTextBox";
            this.smoothTextBox.ReadOnly = true;
            this.smoothTextBox.Size = new System.Drawing.Size(55, 22);
            this.smoothTextBox.TabIndex = 9;
            this.smoothTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // smoothTrackBar
            // 
            this.smoothTrackBar.Location = new System.Drawing.Point(7, 22);
            this.smoothTrackBar.Margin = new System.Windows.Forms.Padding(4);
            this.smoothTrackBar.Maximum = 5;
            this.smoothTrackBar.Name = "smoothTrackBar";
            this.smoothTrackBar.Size = new System.Drawing.Size(131, 56);
            this.smoothTrackBar.TabIndex = 4;
            this.smoothTrackBar.Scroll += new System.EventHandler(this.Smooth_Scroll);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.checkSameMargins);
            this.groupBox7.Controls.Add(this.label8);
            this.groupBox7.Controls.Add(this.textMarginBot);
            this.groupBox7.Controls.Add(this.label7);
            this.groupBox7.Controls.Add(this.textMarginTop);
            this.groupBox7.Controls.Add(this.label2);
            this.groupBox7.Controls.Add(this.textMarginRight);
            this.groupBox7.Controls.Add(this.textMarginLeft);
            this.groupBox7.Controls.Add(this.label5);
            this.groupBox7.Location = new System.Drawing.Point(244, 27);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(211, 178);
            this.groupBox7.TabIndex = 21;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Margins";
            // 
            // checkSameMargins
            // 
            this.checkSameMargins.AutoSize = true;
            this.checkSameMargins.Location = new System.Drawing.Point(46, 143);
            this.checkSameMargins.Name = "checkSameMargins";
            this.checkSameMargins.Size = new System.Drawing.Size(120, 21);
            this.checkSameMargins.TabIndex = 18;
            this.checkSameMargins.Text = "Same Margins";
            this.checkSameMargins.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 113);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Margin Bot";
            // 
            // textMarginBot
            // 
            this.textMarginBot.Location = new System.Drawing.Point(142, 113);
            this.textMarginBot.Margin = new System.Windows.Forms.Padding(4);
            this.textMarginBot.Name = "textMarginBot";
            this.textMarginBot.Size = new System.Drawing.Size(55, 22);
            this.textMarginBot.TabIndex = 16;
            this.textMarginBot.TextChanged += new System.EventHandler(this.marginsChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 82);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Margin Top";
            // 
            // textMarginTop
            // 
            this.textMarginTop.Location = new System.Drawing.Point(142, 82);
            this.textMarginTop.Margin = new System.Windows.Forms.Padding(4);
            this.textMarginTop.Name = "textMarginTop";
            this.textMarginTop.Size = new System.Drawing.Size(55, 22);
            this.textMarginTop.TabIndex = 14;
            this.textMarginTop.TextChanged += new System.EventHandler(this.marginsChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Margin Right";
            // 
            // textMarginRight
            // 
            this.textMarginRight.Location = new System.Drawing.Point(142, 52);
            this.textMarginRight.Margin = new System.Windows.Forms.Padding(4);
            this.textMarginRight.Name = "textMarginRight";
            this.textMarginRight.Size = new System.Drawing.Size(55, 22);
            this.textMarginRight.TabIndex = 12;
            this.textMarginRight.TextChanged += new System.EventHandler(this.marginsChanged);
            // 
            // textMarginLeft
            // 
            this.textMarginLeft.Location = new System.Drawing.Point(142, 22);
            this.textMarginLeft.Margin = new System.Windows.Forms.Padding(4);
            this.textMarginLeft.Name = "textMarginLeft";
            this.textMarginLeft.Size = new System.Drawing.Size(55, 22);
            this.textMarginLeft.TabIndex = 11;
            this.textMarginLeft.TextChanged += new System.EventHandler(this.marginsChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 22);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Margin Left";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.AbsoluteCheckBox);
            this.groupBox5.Controls.Add(this.NearSpaceTrackBar);
            this.groupBox5.Controls.Add(this.NearSpaceTextBox);
            this.groupBox5.Location = new System.Drawing.Point(13, 211);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(211, 105);
            this.groupBox5.TabIndex = 20;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Near Space";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.kTextBox);
            this.groupBox3.Controls.Add(this.kTrackBar);
            this.groupBox3.Location = new System.Drawing.Point(13, 119);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(211, 86);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "K";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.fingersTextBox2);
            this.groupBox4.Controls.Add(this.fingersTextBox1);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(13, 322);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(211, 86);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Info";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Hand 2 Fingers";
            // 
            // fingersTextBox2
            // 
            this.fingersTextBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.fingersTextBox2.Location = new System.Drawing.Point(142, 52);
            this.fingersTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.fingersTextBox2.Name = "fingersTextBox2";
            this.fingersTextBox2.ReadOnly = true;
            this.fingersTextBox2.Size = new System.Drawing.Size(55, 22);
            this.fingersTextBox2.TabIndex = 12;
            this.fingersTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // depthImage
            // 
            this.depthImage.BackColor = System.Drawing.SystemColors.ControlText;
            this.depthImage.Location = new System.Drawing.Point(260, 60);
            this.depthImage.Margin = new System.Windows.Forms.Padding(4);
            this.depthImage.Name = "depthImage";
            this.depthImage.Size = new System.Drawing.Size(220, 165);
            this.depthImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.depthImage.TabIndex = 20;
            this.depthImage.TabStop = false;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.boxReductionTextBox);
            this.groupBox8.Controls.Add(this.boxReductionTrackBar);
            this.groupBox8.Location = new System.Drawing.Point(244, 322);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(211, 86);
            this.groupBox8.TabIndex = 21;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Container Box Reduction";
            // 
            // boxReductionTextBox
            // 
            this.boxReductionTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.boxReductionTextBox.Location = new System.Drawing.Point(146, 22);
            this.boxReductionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.boxReductionTextBox.Name = "boxReductionTextBox";
            this.boxReductionTextBox.ReadOnly = true;
            this.boxReductionTextBox.Size = new System.Drawing.Size(55, 22);
            this.boxReductionTextBox.TabIndex = 9;
            this.boxReductionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // boxReductionTrackBar
            // 
            this.boxReductionTrackBar.Location = new System.Drawing.Point(7, 22);
            this.boxReductionTrackBar.Margin = new System.Windows.Forms.Padding(4);
            this.boxReductionTrackBar.Maximum = 99;
            this.boxReductionTrackBar.Name = "boxReductionTrackBar";
            this.boxReductionTrackBar.Size = new System.Drawing.Size(131, 56);
            this.boxReductionTrackBar.TabIndex = 4;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 721);
            this.Controls.Add(this.depthImage);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.colorImage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.depthButton);
            this.Controls.Add(this.colorButton);
            this.Controls.Add(this.trackingImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainWindow";
            this.Text = "Fingertracking Test Panel";
            ((System.ComponentModel.ISupportInitialize)(this.trackingImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thetaTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NearSpaceTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorImage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.smoothTrackBar)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depthImage)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boxReductionTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button colorButton;
        private System.Windows.Forms.Button depthButton;
        private System.Windows.Forms.TrackBar thetaTrackBar;
        private System.Windows.Forms.TrackBar kTrackBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox thetaTextBox;
        private System.Windows.Forms.TextBox kTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fingersTextBox1;
        private System.Windows.Forms.TextBox NearSpaceTextBox;
        private System.Windows.Forms.TrackBar NearSpaceTrackBar;
        private System.Windows.Forms.CheckBox AbsoluteCheckBox;
        private System.Windows.Forms.PictureBox colorImage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox trackingImage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fingersTextBox2;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textMarginBot;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textMarginTop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textMarginRight;
        private System.Windows.Forms.TextBox textMarginLeft;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox depthImage;
        private System.Windows.Forms.CheckBox checkSameMargins;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox smoothTextBox;
        private System.Windows.Forms.TrackBar smoothTrackBar;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox boxReductionTextBox;
        private System.Windows.Forms.TrackBar boxReductionTrackBar;
    }
}

