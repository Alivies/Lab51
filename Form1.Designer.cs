namespace Lab5
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.PlotView = new OxyPlot.WindowsForms.PlotView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ButtonCalculate = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonClear = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AccuracyBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.EndBBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.StartABox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.FunctionBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.AnswerRectangle = new System.Windows.Forms.Label();
            this.AnswerTrapeze = new System.Windows.Forms.Label();
            this.AnswerParabola = new System.Windows.Forms.Label();
            this.AccuracySearchBox = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlotView
            // 
            this.PlotView.ForeColor = System.Drawing.Color.Maroon;
            this.PlotView.Location = new System.Drawing.Point(241, -6);
            this.PlotView.Margin = new System.Windows.Forms.Padding(2);
            this.PlotView.Name = "PlotView";
            this.PlotView.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.PlotView.Size = new System.Drawing.Size(356, 327);
            this.PlotView.TabIndex = 0;
            this.PlotView.Text = "plotView1";
            this.PlotView.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.PlotView.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.PlotView.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ButtonCalculate,
            this.ButtonClear});
            this.menuStrip1.Location = new System.Drawing.Point(0, 342);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 30;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ButtonCalculate
            // 
            this.ButtonCalculate.BackColor = System.Drawing.Color.LightGray;
            this.ButtonCalculate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonCalculate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ButtonCalculate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonCalculate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonCalculate.Name = "ButtonCalculate";
            this.ButtonCalculate.ShowShortcutKeys = false;
            this.ButtonCalculate.Size = new System.Drawing.Size(80, 20);
            this.ButtonCalculate.Text = "Вычислить";
            this.ButtonCalculate.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.ButtonCalculate.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ButtonClear
            // 
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(71, 20);
            this.ButtonClear.Text = "Очистить";
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Найти значение определенного интеграла:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(11, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Лабораторная работа 5";
            // 
            // AccuracyBox
            // 
            this.AccuracyBox.Location = new System.Drawing.Point(51, 143);
            this.AccuracyBox.Margin = new System.Windows.Forms.Padding(2);
            this.AccuracyBox.Name = "AccuracyBox";
            this.AccuracyBox.Size = new System.Drawing.Size(103, 20);
            this.AccuracyBox.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 142);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 21);
            this.label6.TabIndex = 39;
            this.label6.Text = "N:";
            // 
            // EndBBox
            // 
            this.EndBBox.Location = new System.Drawing.Point(51, 119);
            this.EndBBox.Margin = new System.Windows.Forms.Padding(2);
            this.EndBBox.Name = "EndBBox";
            this.EndBBox.Size = new System.Drawing.Size(103, 20);
            this.EndBBox.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 113);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 21);
            this.label5.TabIndex = 37;
            this.label5.Text = "b:";
            // 
            // StartABox
            // 
            this.StartABox.Location = new System.Drawing.Point(51, 95);
            this.StartABox.Margin = new System.Windows.Forms.Padding(2);
            this.StartABox.Name = "StartABox";
            this.StartABox.Size = new System.Drawing.Size(103, 20);
            this.StartABox.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 91);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 21);
            this.label4.TabIndex = 35;
            this.label4.Text = "a:";
            // 
            // FunctionBox
            // 
            this.FunctionBox.Location = new System.Drawing.Point(51, 71);
            this.FunctionBox.Margin = new System.Windows.Forms.Padding(2);
            this.FunctionBox.Name = "FunctionBox";
            this.FunctionBox.Size = new System.Drawing.Size(176, 20);
            this.FunctionBox.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 21);
            this.label3.TabIndex = 33;
            this.label3.Text = "f(x):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(9, 210);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "Результат:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 231);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 91);
            this.label8.TabIndex = 42;
            this.label8.Text = "Методы:\r\n\r\nпрямоугольников =\r\n\r\nтрапеций =\r\n\r\nпарабол  =";
            // 
            // AnswerRectangle
            // 
            this.AnswerRectangle.AutoSize = true;
            this.AnswerRectangle.Location = new System.Drawing.Point(114, 256);
            this.AnswerRectangle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AnswerRectangle.Name = "AnswerRectangle";
            this.AnswerRectangle.Size = new System.Drawing.Size(0, 13);
            this.AnswerRectangle.TabIndex = 43;
            // 
            // AnswerTrapeze
            // 
            this.AnswerTrapeze.AutoSize = true;
            this.AnswerTrapeze.Location = new System.Drawing.Point(114, 280);
            this.AnswerTrapeze.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AnswerTrapeze.Name = "AnswerTrapeze";
            this.AnswerTrapeze.Size = new System.Drawing.Size(0, 13);
            this.AnswerTrapeze.TabIndex = 44;
            // 
            // AnswerParabola
            // 
            this.AnswerParabola.AutoSize = true;
            this.AnswerParabola.Location = new System.Drawing.Point(116, 308);
            this.AnswerParabola.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AnswerParabola.Name = "AnswerParabola";
            this.AnswerParabola.Size = new System.Drawing.Size(0, 13);
            this.AnswerParabola.TabIndex = 45;
            // 
            // AccuracySearchBox
            // 
            this.AccuracySearchBox.AutoSize = true;
            this.AccuracySearchBox.Location = new System.Drawing.Point(23, 177);
            this.AccuracySearchBox.Name = "AccuracySearchBox";
            this.AccuracySearchBox.Size = new System.Drawing.Size(15, 14);
            this.AccuracySearchBox.TabIndex = 46;
            this.AccuracySearchBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.AccuracySearchBox);
            this.Controls.Add(this.AnswerParabola);
            this.Controls.Add(this.AnswerTrapeze);
            this.Controls.Add(this.AnswerRectangle);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AccuracyBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.EndBBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.StartABox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FunctionBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.PlotView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OxyPlot.WindowsForms.PlotView PlotView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ButtonCalculate;
        private System.Windows.Forms.ToolStripMenuItem ButtonClear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AccuracyBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox EndBBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox StartABox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox FunctionBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label AnswerRectangle;
        private System.Windows.Forms.Label AnswerTrapeze;
        private System.Windows.Forms.Label AnswerParabola;
        private System.Windows.Forms.CheckBox AccuracySearchBox;
    }
}
