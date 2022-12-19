
namespace _1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.n_textBox = new System.Windows.Forms.TextBox();
            this.stl_textBox = new System.Windows.Forms.TextBox();
            this.skl_textBox = new System.Windows.Forms.TextBox();
            this.res_Button = new System.Windows.Forms.Button();
            this.res_textBox = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mas_textBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(38, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите размерность массива (n*n):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(38, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введите номер столбца:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(479, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(268, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Введите значение скаляра:";
            // 
            // n_textBox
            // 
            this.n_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.n_textBox.Location = new System.Drawing.Point(430, 31);
            this.n_textBox.Name = "n_textBox";
            this.n_textBox.Size = new System.Drawing.Size(411, 30);
            this.n_textBox.TabIndex = 3;
            // 
            // stl_textBox
            // 
            this.stl_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stl_textBox.Location = new System.Drawing.Point(307, 212);
            this.stl_textBox.Name = "stl_textBox";
            this.stl_textBox.Size = new System.Drawing.Size(118, 30);
            this.stl_textBox.TabIndex = 4;
            // 
            // skl_textBox
            // 
            this.skl_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.skl_textBox.Location = new System.Drawing.Point(787, 214);
            this.skl_textBox.Name = "skl_textBox";
            this.skl_textBox.Size = new System.Drawing.Size(118, 30);
            this.skl_textBox.TabIndex = 5;
            // 
            // res_Button
            // 
            this.res_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.res_Button.Location = new System.Drawing.Point(381, 273);
            this.res_Button.Name = "res_Button";
            this.res_Button.Size = new System.Drawing.Size(159, 37);
            this.res_Button.TabIndex = 6;
            this.res_Button.Text = "Вывести";
            this.res_Button.UseVisualStyleBackColor = true;
            this.res_Button.Click += new System.EventHandler(this.res_Button_Click);
            // 
            // res_textBox
            // 
            this.res_textBox.Location = new System.Drawing.Point(43, 339);
            this.res_textBox.Name = "res_textBox";
            this.res_textBox.Size = new System.Drawing.Size(862, 185);
            this.res_textBox.TabIndex = 7;
            this.res_textBox.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(38, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Введите массив (n*n):";
            // 
            // mas_textBox
            // 
            this.mas_textBox.Location = new System.Drawing.Point(280, 82);
            this.mas_textBox.Name = "mas_textBox";
            this.mas_textBox.Size = new System.Drawing.Size(625, 107);
            this.mas_textBox.TabIndex = 9;
            this.mas_textBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 576);
            this.Controls.Add(this.mas_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.res_textBox);
            this.Controls.Add(this.res_Button);
            this.Controls.Add(this.skl_textBox);
            this.Controls.Add(this.stl_textBox);
            this.Controls.Add(this.n_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Классы";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox n_textBox;
        private System.Windows.Forms.TextBox stl_textBox;
        private System.Windows.Forms.TextBox skl_textBox;
        private System.Windows.Forms.Button res_Button;
        private System.Windows.Forms.RichTextBox res_textBox;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.RichTextBox mas_textBox;
    }
}

