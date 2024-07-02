namespace SeriesDeFourier
{
    partial class Form1
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
            this.plotView1 = new OxyPlot.WindowsForms.PlotView();
            this.plotView2 = new OxyPlot.WindowsForms.PlotView();
            this.button1 = new System.Windows.Forms.Button();
            this.nterminosText = new System.Windows.Forms.TextBox();
            this.periodoText = new System.Windows.Forms.TextBox();
            this.nPointsText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.seleccionFuncion = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // plotView1
            // 
            this.plotView1.Location = new System.Drawing.Point(0, 0);
            this.plotView1.Name = "plotView1";
            this.plotView1.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotView1.Size = new System.Drawing.Size(75, 23);
            this.plotView1.TabIndex = 0;
            this.plotView1.Text = "plotView1";
            this.plotView1.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotView1.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotView1.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // plotView2
            // 
            this.plotView2.Location = new System.Drawing.Point(12, 115);
            this.plotView2.Name = "plotView2";
            this.plotView2.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotView2.Size = new System.Drawing.Size(420, 323);
            this.plotView2.TabIndex = 1;
            this.plotView2.Text = "plotView2";
            this.plotView2.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotView2.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotView2.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            this.plotView2.Click += new System.EventHandler(this.plotView2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(357, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nterminosText
            // 
            this.nterminosText.Location = new System.Drawing.Point(208, 7);
            this.nterminosText.Name = "nterminosText";
            this.nterminosText.Size = new System.Drawing.Size(133, 20);
            this.nterminosText.TabIndex = 3;
            this.nterminosText.Text = "100";
            // 
            // periodoText
            // 
            this.periodoText.Location = new System.Drawing.Point(208, 31);
            this.periodoText.Name = "periodoText";
            this.periodoText.Size = new System.Drawing.Size(133, 20);
            this.periodoText.TabIndex = 4;
            this.periodoText.Text = "4";
            // 
            // nPointsText
            // 
            this.nPointsText.Location = new System.Drawing.Point(207, 57);
            this.nPointsText.Name = "nPointsText";
            this.nPointsText.Size = new System.Drawing.Size(134, 20);
            this.nPointsText.TabIndex = 5;
            this.nPointsText.Text = "100";
            this.nPointsText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "N - Terminos SF";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Periodo (Este valor se multiplica por PI)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Puntos de la Funcion";
            // 
            // AText
            // 
            this.AText.Location = new System.Drawing.Point(208, 83);
            this.AText.Name = "AText";
            this.AText.Size = new System.Drawing.Size(133, 20);
            this.AText.TabIndex = 9;
            this.AText.Text = "2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Factor A de multiplicación";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // seleccionFuncion
            // 
            this.seleccionFuncion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.seleccionFuncion.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.seleccionFuncion.FormattingEnabled = true;
            this.seleccionFuncion.Items.AddRange(new object[] {
            "1",
            "2"});
            this.seleccionFuncion.Location = new System.Drawing.Point(347, 78);
            this.seleccionFuncion.Name = "seleccionFuncion";
            this.seleccionFuncion.Size = new System.Drawing.Size(102, 21);
            this.seleccionFuncion.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(377, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Funcion";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(461, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.seleccionFuncion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nPointsText);
            this.Controls.Add(this.periodoText);
            this.Controls.Add(this.nterminosText);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.plotView2);
            this.Controls.Add(this.plotView1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Series de Fourier";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OxyPlot.WindowsForms.PlotView plotView1;
        private OxyPlot.WindowsForms.PlotView plotView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox nterminosText;
        private System.Windows.Forms.TextBox periodoText;
        private System.Windows.Forms.TextBox nPointsText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox seleccionFuncion;
        private System.Windows.Forms.Label label5;
    }
}