namespace Pr4_WinForm
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.task1 = new System.Windows.Forms.TabPage();
			this.task2 = new System.Windows.Forms.TabPage();
			this.n_label = new System.Windows.Forms.Label();
			this.m_label = new System.Windows.Forms.Label();
			this.n_box = new System.Windows.Forms.TextBox();
			this.m_box = new System.Windows.Forms.TextBox();
			this.accerman_label = new System.Windows.Forms.Label();
			this.accerman_box = new System.Windows.Forms.TextBox();
			this.calculate_button = new System.Windows.Forms.Button();
			this.n2_label = new System.Windows.Forms.Label();
			this.n2_box = new System.Windows.Forms.TextBox();
			this.rezult_box = new System.Windows.Forms.RichTextBox();
			this.tabControl1.SuspendLayout();
			this.task1.SuspendLayout();
			this.task2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.task1);
			this.tabControl1.Controls.Add(this.task2);
			this.tabControl1.Location = new System.Drawing.Point(12, 12);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(473, 167);
			this.tabControl1.TabIndex = 0;
			// 
			// task1
			// 
			this.task1.Controls.Add(this.calculate_button);
			this.task1.Controls.Add(this.accerman_box);
			this.task1.Controls.Add(this.accerman_label);
			this.task1.Controls.Add(this.m_box);
			this.task1.Controls.Add(this.n_box);
			this.task1.Controls.Add(this.m_label);
			this.task1.Controls.Add(this.n_label);
			this.task1.Location = new System.Drawing.Point(4, 25);
			this.task1.Name = "task1";
			this.task1.Padding = new System.Windows.Forms.Padding(3);
			this.task1.Size = new System.Drawing.Size(465, 138);
			this.task1.TabIndex = 0;
			this.task1.Text = "Задание 1";
			this.task1.UseVisualStyleBackColor = true;
			// 
			// task2
			// 
			this.task2.Controls.Add(this.rezult_box);
			this.task2.Controls.Add(this.n2_box);
			this.task2.Controls.Add(this.n2_label);
			this.task2.Location = new System.Drawing.Point(4, 25);
			this.task2.Name = "task2";
			this.task2.Padding = new System.Windows.Forms.Padding(3);
			this.task2.Size = new System.Drawing.Size(465, 138);
			this.task2.TabIndex = 1;
			this.task2.Text = "Задание 2";
			this.task2.UseVisualStyleBackColor = true;
			// 
			// n_label
			// 
			this.n_label.AutoSize = true;
			this.n_label.Location = new System.Drawing.Point(6, 12);
			this.n_label.Name = "n_label";
			this.n_label.Size = new System.Drawing.Size(93, 17);
			this.n_label.TabIndex = 0;
			this.n_label.Text = "Значение n: ";
			// 
			// m_label
			// 
			this.m_label.AutoSize = true;
			this.m_label.Location = new System.Drawing.Point(6, 41);
			this.m_label.Name = "m_label";
			this.m_label.Size = new System.Drawing.Size(96, 17);
			this.m_label.TabIndex = 1;
			this.m_label.Text = "Значение m: ";
			// 
			// n_box
			// 
			this.n_box.Location = new System.Drawing.Point(105, 12);
			this.n_box.Name = "n_box";
			this.n_box.Size = new System.Drawing.Size(100, 22);
			this.n_box.TabIndex = 2;
			this.n_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.n_box_KeyPress);
			// 
			// m_box
			// 
			this.m_box.Location = new System.Drawing.Point(105, 41);
			this.m_box.Name = "m_box";
			this.m_box.Size = new System.Drawing.Size(100, 22);
			this.m_box.TabIndex = 3;
			this.m_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.n_box_KeyPress);
			// 
			// accerman_label
			// 
			this.accerman_label.AutoSize = true;
			this.accerman_label.Location = new System.Drawing.Point(3, 66);
			this.accerman_label.Name = "accerman_label";
			this.accerman_label.Size = new System.Drawing.Size(218, 17);
			this.accerman_label.TabIndex = 4;
			this.accerman_label.Text = "Значение функции Аккермана: ";
			// 
			// accerman_box
			// 
			this.accerman_box.Enabled = false;
			this.accerman_box.Location = new System.Drawing.Point(227, 66);
			this.accerman_box.Name = "accerman_box";
			this.accerman_box.Size = new System.Drawing.Size(100, 22);
			this.accerman_box.TabIndex = 5;
			// 
			// calculate_button
			// 
			this.calculate_button.Location = new System.Drawing.Point(6, 86);
			this.calculate_button.Name = "calculate_button";
			this.calculate_button.Size = new System.Drawing.Size(106, 35);
			this.calculate_button.TabIndex = 6;
			this.calculate_button.Text = "Рассчитать";
			this.calculate_button.UseVisualStyleBackColor = true;
			this.calculate_button.Click += new System.EventHandler(this.calculate_button_Click);
			// 
			// n2_label
			// 
			this.n2_label.AutoSize = true;
			this.n2_label.Location = new System.Drawing.Point(6, 3);
			this.n2_label.Name = "n2_label";
			this.n2_label.Size = new System.Drawing.Size(93, 17);
			this.n2_label.TabIndex = 0;
			this.n2_label.Text = "Значение n: ";
			// 
			// n2_box
			// 
			this.n2_box.Location = new System.Drawing.Point(95, 3);
			this.n2_box.Name = "n2_box";
			this.n2_box.Size = new System.Drawing.Size(100, 22);
			this.n2_box.TabIndex = 1;
			this.n2_box.TextChanged += new System.EventHandler(this.n2_box_TextChanged);
			this.n2_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.n_box_KeyPress);
			// 
			// rezult_box
			// 
			this.rezult_box.Location = new System.Drawing.Point(201, 3);
			this.rezult_box.Name = "rezult_box";
			this.rezult_box.Size = new System.Drawing.Size(258, 129);
			this.rezult_box.TabIndex = 2;
			this.rezult_box.Text = "";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(497, 187);
			this.Controls.Add(this.tabControl1);
			this.Name = "Form1";
			this.Text = "Практика 4";
			this.tabControl1.ResumeLayout(false);
			this.task1.ResumeLayout(false);
			this.task1.PerformLayout();
			this.task2.ResumeLayout(false);
			this.task2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage task1;
		private System.Windows.Forms.TabPage task2;
		private System.Windows.Forms.Button calculate_button;
		private System.Windows.Forms.TextBox accerman_box;
		private System.Windows.Forms.Label accerman_label;
		private System.Windows.Forms.TextBox m_box;
		private System.Windows.Forms.TextBox n_box;
		private System.Windows.Forms.Label m_label;
		private System.Windows.Forms.Label n_label;
		private System.Windows.Forms.RichTextBox rezult_box;
		private System.Windows.Forms.TextBox n2_box;
		private System.Windows.Forms.Label n2_label;
	}
}

