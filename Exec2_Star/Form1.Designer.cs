namespace Exec2_Star
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.txtInput = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.leftTriangle = new System.Windows.Forms.Button();
			this.rightTriangle = new System.Windows.Forms.Button();
			this.isoscelesTriangle = new System.Windows.Forms.Button();
			this.txtAnswer = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(12, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(366, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "請輸入層數 (1-10)，並且選擇你想要的三角形類型!";
			// 
			// txtInput
			// 
			this.txtInput.Location = new System.Drawing.Point(78, 88);
			this.txtInput.Name = "txtInput";
			this.txtInput.Size = new System.Drawing.Size(100, 22);
			this.txtInput.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.Location = new System.Drawing.Point(12, 89);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(45, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "行數:";
			// 
			// leftTriangle
			// 
			this.leftTriangle.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.leftTriangle.Location = new System.Drawing.Point(231, 80);
			this.leftTriangle.Name = "leftTriangle";
			this.leftTriangle.Size = new System.Drawing.Size(99, 39);
			this.leftTriangle.TabIndex = 3;
			this.leftTriangle.Tag = "0";
			this.leftTriangle.Text = "靠左";
			this.leftTriangle.UseVisualStyleBackColor = true;
			this.leftTriangle.Click += new System.EventHandler(this.leftTriangle_Click);
			// 
			// rightTriangle
			// 
			this.rightTriangle.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.rightTriangle.Location = new System.Drawing.Point(336, 80);
			this.rightTriangle.Name = "rightTriangle";
			this.rightTriangle.Size = new System.Drawing.Size(99, 39);
			this.rightTriangle.TabIndex = 3;
			this.rightTriangle.Tag = "1";
			this.rightTriangle.Text = "靠右";
			this.rightTriangle.UseVisualStyleBackColor = true;
			this.rightTriangle.Click += new System.EventHandler(this.rightTriangle_Click);
			// 
			// isoscelesTriangle
			// 
			this.isoscelesTriangle.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.isoscelesTriangle.Location = new System.Drawing.Point(441, 80);
			this.isoscelesTriangle.Name = "isoscelesTriangle";
			this.isoscelesTriangle.Size = new System.Drawing.Size(99, 39);
			this.isoscelesTriangle.TabIndex = 3;
			this.isoscelesTriangle.Tag = "2";
			this.isoscelesTriangle.Text = "等腰";
			this.isoscelesTriangle.UseVisualStyleBackColor = true;
			this.isoscelesTriangle.Click += new System.EventHandler(this.isoscelesTriangle_Click);
			// 
			// txtAnswer
			// 
			this.txtAnswer.Location = new System.Drawing.Point(21, 144);
			this.txtAnswer.Multiline = true;
			this.txtAnswer.Name = "txtAnswer";
			this.txtAnswer.Size = new System.Drawing.Size(518, 277);
			this.txtAnswer.TabIndex = 4;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(560, 450);
			this.Controls.Add(this.txtAnswer);
			this.Controls.Add(this.isoscelesTriangle);
			this.Controls.Add(this.rightTriangle);
			this.Controls.Add(this.leftTriangle);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtInput);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "做出你的三角形!";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtInput;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button leftTriangle;
		private System.Windows.Forms.Button rightTriangle;
		private System.Windows.Forms.Button isoscelesTriangle;
		private System.Windows.Forms.TextBox txtAnswer;
	}
}

