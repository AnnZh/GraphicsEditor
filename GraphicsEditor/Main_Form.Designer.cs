namespace GraphicsEditor
{
    partial class Main_Form
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
            this.Triangle = new System.Windows.Forms.Button();
            this.Ellipse = new System.Windows.Forms.Button();
            this.Segment = new System.Windows.Forms.Button();
            this.Circle = new System.Windows.Forms.Button();
            this.Rectangle = new System.Windows.Forms.Button();
            this.Trapeze = new System.Windows.Forms.Button();
            this.R_set = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // Triangle
            // 
            this.Triangle.Location = new System.Drawing.Point(1422, 94);
            this.Triangle.Name = "Triangle";
            this.Triangle.Size = new System.Drawing.Size(215, 63);
            this.Triangle.TabIndex = 0;
            this.Triangle.Text = "Треугольник";
            this.Triangle.UseVisualStyleBackColor = true;
            this.Triangle.Click += new System.EventHandler(this.Triangle_Click);
            // 
            // Ellipse
            // 
            this.Ellipse.Location = new System.Drawing.Point(1422, 189);
            this.Ellipse.Name = "Ellipse";
            this.Ellipse.Size = new System.Drawing.Size(215, 69);
            this.Ellipse.TabIndex = 1;
            this.Ellipse.Text = "Эллипс";
            this.Ellipse.UseVisualStyleBackColor = true;
            this.Ellipse.Click += new System.EventHandler(this.Ellipse_Click);
            // 
            // Segment
            // 
            this.Segment.Location = new System.Drawing.Point(1422, 297);
            this.Segment.Name = "Segment";
            this.Segment.Size = new System.Drawing.Size(215, 69);
            this.Segment.TabIndex = 2;
            this.Segment.Text = "Сектор";
            this.Segment.UseVisualStyleBackColor = true;
            this.Segment.Click += new System.EventHandler(this.LineSegment_Click);
            // 
            // Circle
            // 
            this.Circle.Location = new System.Drawing.Point(1422, 406);
            this.Circle.Name = "Circle";
            this.Circle.Size = new System.Drawing.Size(215, 69);
            this.Circle.TabIndex = 3;
            this.Circle.Text = "Круг";
            this.Circle.UseVisualStyleBackColor = true;
            this.Circle.Click += new System.EventHandler(this.Circle_Click);
            // 
            // Rectangle
            // 
            this.Rectangle.Location = new System.Drawing.Point(1422, 516);
            this.Rectangle.Name = "Rectangle";
            this.Rectangle.Size = new System.Drawing.Size(215, 69);
            this.Rectangle.TabIndex = 4;
            this.Rectangle.Text = "Прямоугольник";
            this.Rectangle.UseVisualStyleBackColor = true;
            this.Rectangle.Click += new System.EventHandler(this.Rectangle_Click);
            // 
            // Trapeze
            // 
            this.Trapeze.Location = new System.Drawing.Point(1422, 629);
            this.Trapeze.Name = "Trapeze";
            this.Trapeze.Size = new System.Drawing.Size(215, 69);
            this.Trapeze.TabIndex = 5;
            this.Trapeze.Text = "Трапеция";
            this.Trapeze.UseVisualStyleBackColor = true;
            this.Trapeze.Click += new System.EventHandler(this.Trapeze_Click);
            // 
            // R_set
            // 
            this.R_set.Location = new System.Drawing.Point(1345, 760);
            this.R_set.Name = "R_set";
            this.R_set.Size = new System.Drawing.Size(292, 69);
            this.R_set.TabIndex = 6;
            this.R_set.Text = "Сброс";
            this.R_set.UseVisualStyleBackColor = true;
            this.R_set.Click += new System.EventHandler(this.R_set_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(75, 84);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 32);
            this.numericUpDown1.TabIndex = 7;
            this.numericUpDown1.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(75, 142);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 32);
            this.numericUpDown2.TabIndex = 8;
            this.numericUpDown2.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1417, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Фигуры:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 29);
            this.label3.TabIndex = 11;
            this.label3.Text = "Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 29);
            this.label4.TabIndex = 12;
            this.label4.Text = "Координаты:";
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1716, 862);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.R_set);
            this.Controls.Add(this.Trapeze);
            this.Controls.Add(this.Rectangle);
            this.Controls.Add(this.Circle);
            this.Controls.Add(this.Segment);
            this.Controls.Add(this.Ellipse);
            this.Controls.Add(this.Triangle);
            this.Name = "Main_Form";
            this.Text = "ООП Лаб2 Журок Анна гр.651002";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Main_Form_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Triangle;
        private System.Windows.Forms.Button Ellipse;
        private System.Windows.Forms.Button Segment;
        private System.Windows.Forms.Button Circle;
        private System.Windows.Forms.Button Rectangle;
        private System.Windows.Forms.Button Trapeze;
        private System.Windows.Forms.Button R_set;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

