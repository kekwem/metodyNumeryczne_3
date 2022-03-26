
namespace sieczne
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
            this.punktA = new System.Windows.Forms.TextBox();
            this.punktB = new System.Windows.Forms.TextBox();
            this.epsilon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.zmienna1 = new System.Windows.Forms.TextBox();
            this.zmienna2 = new System.Windows.Forms.TextBox();
            this.zmienna3 = new System.Windows.Forms.TextBox();
            this.button = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // punktA
            // 
            this.punktA.Location = new System.Drawing.Point(117, 62);
            this.punktA.Name = "punktA";
            this.punktA.Size = new System.Drawing.Size(100, 22);
            this.punktA.TabIndex = 0;
            // 
            // punktB
            // 
            this.punktB.Location = new System.Drawing.Point(275, 62);
            this.punktB.Name = "punktB";
            this.punktB.Size = new System.Drawing.Size(100, 22);
            this.punktB.TabIndex = 1;
            // 
            // epsilon
            // 
            this.epsilon.Location = new System.Drawing.Point(674, 62);
            this.epsilon.Name = "epsilon";
            this.epsilon.Size = new System.Drawing.Size(100, 22);
            this.epsilon.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Punkt A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Punkt B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(671, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Epsilon";
            // 
            // zmienna1
            // 
            this.zmienna1.Location = new System.Drawing.Point(117, 136);
            this.zmienna1.Name = "zmienna1";
            this.zmienna1.Size = new System.Drawing.Size(100, 22);
            this.zmienna1.TabIndex = 6;
            // 
            // zmienna2
            // 
            this.zmienna2.Location = new System.Drawing.Point(275, 136);
            this.zmienna2.Name = "zmienna2";
            this.zmienna2.Size = new System.Drawing.Size(100, 22);
            this.zmienna2.TabIndex = 7;
            // 
            // zmienna3
            // 
            this.zmienna3.Location = new System.Drawing.Point(450, 136);
            this.zmienna3.Name = "zmienna3";
            this.zmienna3.Size = new System.Drawing.Size(100, 22);
            this.zmienna3.TabIndex = 8;
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(664, 247);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(75, 23);
            this.button.TabIndex = 9;
            this.button.Text = "Button";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 187);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(630, 244);
            this.listBox1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button);
            this.Controls.Add(this.zmienna3);
            this.Controls.Add(this.zmienna2);
            this.Controls.Add(this.zmienna1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.epsilon);
            this.Controls.Add(this.punktB);
            this.Controls.Add(this.punktA);
            this.Name = "Form1";
            this.Text = "Sieczne";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox punktA;
        private System.Windows.Forms.TextBox punktB;
        private System.Windows.Forms.TextBox epsilon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox zmienna1;
        private System.Windows.Forms.TextBox zmienna2;
        private System.Windows.Forms.TextBox zmienna3;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.ListBox listBox1;
    }
}

