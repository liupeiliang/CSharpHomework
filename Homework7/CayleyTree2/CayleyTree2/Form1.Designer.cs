namespace CayleyTree2
{
	partial class Form1
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox angle1;
		private System.Windows.Forms.TextBox angle2;
		private System.Windows.Forms.Label angleLabel;
		private System.Windows.Forms.Label tree1Label;
		private System.Windows.Forms.Label tree2Label;
		private System.Windows.Forms.Label lengthLabel;
		private System.Windows.Forms.TextBox len1;
		private System.Windows.Forms.TextBox len2;
		private System.Windows.Forms.Label parameterLabel;
		private System.Windows.Forms.TextBox parameterK;
		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.angle1 = new System.Windows.Forms.TextBox();
			this.angle2 = new System.Windows.Forms.TextBox();
			this.angleLabel = new System.Windows.Forms.Label();
			this.tree1Label = new System.Windows.Forms.Label();
			this.tree2Label = new System.Windows.Forms.Label();
			this.lengthLabel = new System.Windows.Forms.Label();
			this.len1 = new System.Windows.Forms.TextBox();
			this.len2 = new System.Windows.Forms.TextBox();
			this.parameterLabel = new System.Windows.Forms.Label();
			this.parameterK = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(441, 183);
			this.button1.Size = new System.Drawing.Size(110, 23);
			this.button1.TabIndex = 0;
			this.button1.Name = "button1";
			this.button1.Text = "Start!";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// angle1
			// 
			this.angle1.Location = new System.Drawing.Point(90, 73);
			this.angle1.Size = new System.Drawing.Size(155, 25);
			this.angle1.TabIndex = 1;
			this.angle1.Name = "angle1";
			this.angle1.Text = "35";
			// 
			// angleLabel
			// 
			this.angleLabel.AutoSize = true;
			this.angleLabel.Size = new System.Drawing.Size(47, 15);
			this.angleLabel.Location = new System.Drawing.Point(12, 83);
			this.angleLabel.TabIndex = 2;
			this.angleLabel.Text = "Angle";
			this.angleLabel.Name = "angleLabel";
			// 
			// tree1Label
			// 
			this.tree1Label.AutoSize = true;
			this.tree1Label.Size = new System.Drawing.Size(47, 15);
			this.tree1Label.Location = new System.Drawing.Point(111, 37);
			this.tree1Label.TabIndex = 3;
			this.tree1Label.Text = "Tree1";
			this.tree1Label.Name = "tree1Label";
			// 
			// tree2Label
			// 
			this.tree2Label.AutoSize = true;
			this.tree2Label.Size = new System.Drawing.Size(47, 15);
			this.tree2Label.Location = new System.Drawing.Point(276, 37);
			this.tree2Label.TabIndex = 4;
			this.tree2Label.Text = "Tree2";
			this.tree2Label.Name = "tree2Label";
			// 
			// angle2
			// 
			this.angle2.Location = new System.Drawing.Point(250, 73);
			this.angle2.Size = new System.Drawing.Size(155, 25);
			this.angle2.TabIndex = 5;
			this.angle2.Name = "angle2";
			this.angle2.Text = "30";
			// 
			// lengthLabel
			// 
			this.lengthLabel.AutoSize = true;
			this.lengthLabel.Size = new System.Drawing.Size(55, 15);
			this.lengthLabel.Location = new System.Drawing.Point(12, 135);
			this.lengthLabel.TabIndex = 6;
			this.lengthLabel.Name = "lengthLabel";
			this.lengthLabel.Text = "Length";
			// 
			// len1
			// 

			this.len1.Location = new System.Drawing.Point(90, 135);
			this.len1.Size = new System.Drawing.Size(155, 25);
			this.len1.Name = "len1";
			this.len1.Text = "0.6";
			this.len1.TabIndex = 7;
			// 
			// len2
			// 
			this.len2.Location = new System.Drawing.Point(250, 134);
			this.len2.Size = new System.Drawing.Size(155, 25);
			this.len2.Name = "len2";
			this.len2.Text = "0.7";
			this.len2.TabIndex = 8;
			// 
			// parameterLabel
			// 
			this.parameterLabel.AutoSize = true;
			this.parameterLabel.Size = new System.Drawing.Size(71, 15);
			this.parameterLabel.Location = new System.Drawing.Point(12, 195);
			this.parameterLabel.TabIndex = 9;
			this.parameterLabel.Name = "parameterLabel";
			this.parameterLabel.Text = "Distance";
			// 
			// parameterK
			// 
			this.parameterK.Size = new System.Drawing.Size(155, 25);
			this.parameterK.Location = new System.Drawing.Point(250, 184);
			this.parameterK.TabIndex = 10;
			this.parameterK.Name = "parameterK";
			this.parameterK.Text = "1.2";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

			this.Controls.Add(this.len2);
			this.Controls.Add(this.len1);
			this.Controls.Add(this.parameterK);
			this.Controls.Add(this.parameterLabel);
			this.Controls.Add(this.angleLabel);
			this.Controls.Add(this.angle1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.lengthLabel);
			this.Controls.Add(this.angle2);
			this.Controls.Add(this.tree2Label);
			this.Controls.Add(this.tree1Label);

			this.Text = "Form1";
			this.Name = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		#endregion
	}
}

