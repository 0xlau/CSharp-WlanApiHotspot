namespace CSharpWlanApi
{
	partial class WinMain
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

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox_SSID = new System.Windows.Forms.TextBox();
			this.textBox_PassWord = new System.Windows.Forms.TextBox();
			this.button_Start = new System.Windows.Forms.Button();
			this.button_Stop = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(60, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "SSID";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(60, 70);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 12);
			this.label2.TabIndex = 0;
			this.label2.Text = "PassWord";
			// 
			// textBox_SSID
			// 
			this.textBox_SSID.Location = new System.Drawing.Point(119, 32);
			this.textBox_SSID.Name = "textBox_SSID";
			this.textBox_SSID.Size = new System.Drawing.Size(123, 21);
			this.textBox_SSID.TabIndex = 1;
			// 
			// textBox_PassWord
			// 
			this.textBox_PassWord.Location = new System.Drawing.Point(119, 67);
			this.textBox_PassWord.Name = "textBox_PassWord";
			this.textBox_PassWord.PasswordChar = '*';
			this.textBox_PassWord.Size = new System.Drawing.Size(123, 21);
			this.textBox_PassWord.TabIndex = 1;
			// 
			// button_Start
			// 
			this.button_Start.Location = new System.Drawing.Point(38, 115);
			this.button_Start.Name = "button_Start";
			this.button_Start.Size = new System.Drawing.Size(75, 23);
			this.button_Start.TabIndex = 2;
			this.button_Start.Text = "Start";
			this.button_Start.UseVisualStyleBackColor = true;
			this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
			// 
			// button_Stop
			// 
			this.button_Stop.Location = new System.Drawing.Point(188, 115);
			this.button_Stop.Name = "button_Stop";
			this.button_Stop.Size = new System.Drawing.Size(75, 23);
			this.button_Stop.TabIndex = 2;
			this.button_Stop.Text = "Stop";
			this.button_Stop.UseVisualStyleBackColor = true;
			this.button_Stop.Click += new System.EventHandler(this.button_Stop_Click);
			// 
			// WinMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(309, 163);
			this.Controls.Add(this.button_Stop);
			this.Controls.Add(this.button_Start);
			this.Controls.Add(this.textBox_PassWord);
			this.Controls.Add(this.textBox_SSID);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "WinMain";
			this.Text = "WlanApi-Hotspot";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox_SSID;
		private System.Windows.Forms.TextBox textBox_PassWord;
		private System.Windows.Forms.Button button_Start;
		private System.Windows.Forms.Button button_Stop;
	}
}

