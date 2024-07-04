namespace MathQuizGame
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            timeLabel = new Label();
            label1 = new Label();
            plusLeftLabel = new Label();
            plusRightLabel = new Label();
            label3 = new Label();
            label4 = new Label();
            sum = new NumericUpDown();
            label2 = new Label();
            label5 = new Label();
            label6 = new Label();
            difference = new NumericUpDown();
            product = new NumericUpDown();
            quotient = new NumericUpDown();
            label7 = new Label();
            minusRightLabel = new Label();
            timesRightLabel = new Label();
            dividedRightLabel = new Label();
            minusLeftLabel = new Label();
            timesLeftLabel = new Label();
            dividedLeftLabel = new Label();
            label11 = new Label();
            label8 = new Label();
            label14 = new Label();
            startButton = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)sum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)difference).BeginInit();
            ((System.ComponentModel.ISupportInitialize)product).BeginInit();
            ((System.ComponentModel.ISupportInitialize)quotient).BeginInit();
            SuspendLayout();
            // 
            // timeLabel
            // 
            timeLabel.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            timeLabel.Location = new Point(172, 33);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(200, 38);
            timeLabel.TabIndex = 0;
            timeLabel.Text = " ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(172, -2);
            label1.Name = "label1";
            label1.Size = new Size(130, 35);
            label1.TabIndex = 1;
            label1.Text = "Time Left";
            // 
            // plusLeftLabel
            // 
            plusLeftLabel.Font = new Font("Segoe UI Historic", 18F);
            plusLeftLabel.Location = new Point(53, 75);
            plusLeftLabel.Name = "plusLeftLabel";
            plusLeftLabel.Size = new Size(60, 50);
            plusLeftLabel.TabIndex = 2;
            plusLeftLabel.Text = "?";
            plusLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // plusRightLabel
            // 
            plusRightLabel.Font = new Font("Segoe UI Historic", 18F);
            plusRightLabel.Location = new Point(191, 75);
            plusRightLabel.Name = "plusRightLabel";
            plusRightLabel.Size = new Size(60, 50);
            plusRightLabel.TabIndex = 3;
            plusRightLabel.Text = "?";
            plusRightLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI Historic", 18F);
            label3.Location = new Point(119, 75);
            label3.Name = "label3";
            label3.Size = new Size(60, 50);
            label3.TabIndex = 4;
            label3.Text = "+";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI Historic", 18F);
            label4.Location = new Point(251, 75);
            label4.Name = "label4";
            label4.Size = new Size(60, 50);
            label4.TabIndex = 5;
            label4.Text = "=";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // sum
            // 
            sum.Font = new Font("Segoe UI Historic", 18F);
            sum.Location = new Point(308, 74);
            sum.Name = "sum";
            sum.Size = new Size(144, 55);
            sum.TabIndex = 1;
            sum.Click += answer_enter;
            sum.Enter += answer_enter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Historic", 18F);
            label2.Location = new Point(251, 146);
            label2.Name = "label2";
            label2.Size = new Size(60, 50);
            label2.TabIndex = 7;
            label2.Text = "=";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI Historic", 18F);
            label5.Location = new Point(251, 210);
            label5.Name = "label5";
            label5.Size = new Size(60, 50);
            label5.TabIndex = 8;
            label5.Text = "=";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI Historic", 18F);
            label6.Location = new Point(251, 278);
            label6.Name = "label6";
            label6.Size = new Size(60, 50);
            label6.TabIndex = 9;
            label6.Text = "=";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // difference
            // 
            difference.Font = new Font("Segoe UI Historic", 18F);
            difference.Location = new Point(308, 145);
            difference.Name = "difference";
            difference.Size = new Size(144, 55);
            difference.TabIndex = 2;
            difference.Click += answer_enter;
            difference.Enter += answer_enter;
            // 
            // product
            // 
            product.Font = new Font("Segoe UI Historic", 18F);
            product.Location = new Point(308, 210);
            product.Name = "product";
            product.Size = new Size(144, 55);
            product.TabIndex = 3;
            product.Click += answer_enter;
            product.Enter += answer_enter;
            // 
            // quotient
            // 
            quotient.Font = new Font("Segoe UI Historic", 18F);
            quotient.Location = new Point(308, 277);
            quotient.Name = "quotient";
            quotient.Size = new Size(144, 55);
            quotient.TabIndex = 4;
            quotient.Click += answer_enter;
            quotient.Enter += answer_enter;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI Historic", 18F);
            label7.Location = new Point(185, 145);
            label7.Name = "label7";
            label7.Size = new Size(60, 50);
            label7.TabIndex = 13;
            label7.Text = "?";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // minusRightLabel
            // 
            minusRightLabel.Font = new Font("Segoe UI Historic", 18F);
            minusRightLabel.Location = new Point(191, 145);
            minusRightLabel.Name = "minusRightLabel";
            minusRightLabel.Size = new Size(60, 50);
            minusRightLabel.TabIndex = 14;
            minusRightLabel.Text = "?";
            minusRightLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timesRightLabel
            // 
            timesRightLabel.Font = new Font("Segoe UI Historic", 18F);
            timesRightLabel.Location = new Point(191, 210);
            timesRightLabel.Name = "timesRightLabel";
            timesRightLabel.Size = new Size(60, 50);
            timesRightLabel.TabIndex = 14;
            timesRightLabel.Text = "?";
            timesRightLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dividedRightLabel
            // 
            dividedRightLabel.Font = new Font("Segoe UI Historic", 18F);
            dividedRightLabel.Location = new Point(191, 277);
            dividedRightLabel.Name = "dividedRightLabel";
            dividedRightLabel.Size = new Size(60, 50);
            dividedRightLabel.TabIndex = 15;
            dividedRightLabel.Text = "?";
            dividedRightLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // minusLeftLabel
            // 
            minusLeftLabel.Font = new Font("Segoe UI Historic", 18F);
            minusLeftLabel.Location = new Point(53, 145);
            minusLeftLabel.Name = "minusLeftLabel";
            minusLeftLabel.Size = new Size(60, 50);
            minusLeftLabel.TabIndex = 16;
            minusLeftLabel.Text = "?";
            minusLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timesLeftLabel
            // 
            timesLeftLabel.Font = new Font("Segoe UI Historic", 18F);
            timesLeftLabel.Location = new Point(53, 210);
            timesLeftLabel.Name = "timesLeftLabel";
            timesLeftLabel.Size = new Size(60, 50);
            timesLeftLabel.TabIndex = 17;
            timesLeftLabel.Text = "?";
            timesLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dividedLeftLabel
            // 
            dividedLeftLabel.Font = new Font("Segoe UI Historic", 18F);
            dividedLeftLabel.Location = new Point(53, 277);
            dividedLeftLabel.Name = "dividedLeftLabel";
            dividedLeftLabel.Size = new Size(60, 50);
            dividedLeftLabel.TabIndex = 18;
            dividedLeftLabel.Text = "?";
            dividedLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.Font = new Font("Segoe UI Historic", 18F);
            label11.Location = new Point(125, 145);
            label11.Name = "label11";
            label11.Size = new Size(60, 50);
            label11.TabIndex = 19;
            label11.Text = "-";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI Historic", 18F);
            label8.Location = new Point(125, 210);
            label8.Name = "label8";
            label8.Size = new Size(60, 50);
            label8.TabIndex = 20;
            label8.Text = "×";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            label14.Font = new Font("Segoe UI Historic", 18F);
            label14.Location = new Point(125, 277);
            label14.Name = "label14";
            label14.Size = new Size(60, 50);
            label14.TabIndex = 21;
            label14.Text = "÷";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // startButton
            // 
            startButton.AutoSize = true;
            startButton.BackColor = SystemColors.ButtonHighlight;
            startButton.FlatStyle = FlatStyle.System;
            startButton.Font = new Font("Segoe UI Historic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            startButton.Location = new Point(119, 357);
            startButton.Margin = new Padding(50, 0, 50, 0);
            startButton.Name = "startButton";
            startButton.Size = new Size(221, 54);
            startButton.TabIndex = 0;
            startButton.Text = " Start the quiz";
            startButton.UseVisualStyleBackColor = false;
            startButton.Click += startButton_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(491, 440);
            Controls.Add(startButton);
            Controls.Add(label14);
            Controls.Add(label8);
            Controls.Add(label11);
            Controls.Add(dividedLeftLabel);
            Controls.Add(timesLeftLabel);
            Controls.Add(minusLeftLabel);
            Controls.Add(dividedRightLabel);
            Controls.Add(timesRightLabel);
            Controls.Add(minusRightLabel);
            Controls.Add(label7);
            Controls.Add(quotient);
            Controls.Add(product);
            Controls.Add(difference);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(sum);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(plusRightLabel);
            Controls.Add(plusLeftLabel);
            Controls.Add(label1);
            Controls.Add(timeLabel);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "Math Quiz";
            ((System.ComponentModel.ISupportInitialize)sum).EndInit();
            ((System.ComponentModel.ISupportInitialize)difference).EndInit();
            ((System.ComponentModel.ISupportInitialize)product).EndInit();
            ((System.ComponentModel.ISupportInitialize)quotient).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label timeLabel;
        private Label label1;
        private Label plusLeftLabel;
        private Label plusRightLabel;
        private Label label3;
        private Label label4;
        private NumericUpDown sum;
        private Label label2;
        private Label label5;
        private Label label6;
        private NumericUpDown difference;
        private NumericUpDown product;
        private NumericUpDown quotient;
        private Label label7;
        private Label minusRightLabel;
        private Label timesRightLabel;
        private Label dividedRightLabel;
        private Label minusLeftLabel;
        private Label timesLeftLabel;
        private Label dividedLeftLabel;
        private Label label11;
        private Label label8;
        private Label label14;
        private Button startButton;
        private System.Windows.Forms.Timer timer1;
    }
}
