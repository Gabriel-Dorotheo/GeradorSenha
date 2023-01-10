namespace GeradorDeSenha
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
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.tb2 = new System.Windows.Forms.TextBox();
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.label2 = new System.Windows.Forms.Label();
			this.tb3 = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.tb1 = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.tb1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(11, 94);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(143, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tamanho Da Senha";
			// 
			// button1
			// 
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.Location = new System.Drawing.Point(12, 198);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(230, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "Gerar senha";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// tb2
			// 
			this.tb2.Location = new System.Drawing.Point(14, 153);
			this.tb2.Multiline = true;
			this.tb2.Name = "tb2";
			this.tb2.ReadOnly = true;
			this.tb2.Size = new System.Drawing.Size(228, 39);
			this.tb2.TabIndex = 3;
			this.tb2.TextChanged += new System.EventHandler(this.tb2_TextChanged);
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.Text = "notifyIcon1";
			this.notifyIcon1.Visible = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label2.Location = new System.Drawing.Point(11, 20);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(226, 32);
			this.label2.TabIndex = 4;
			this.label2.Text = "Gerador de senhas";
			// 
			// tb3
			// 
			this.tb3.Location = new System.Drawing.Point(266, 12);
			this.tb3.Multiline = true;
			this.tb3.Name = "tb3";
			this.tb3.ReadOnly = true;
			this.tb3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tb3.Size = new System.Drawing.Size(229, 180);
			this.tb3.TabIndex = 5;
			this.tb3.TextChanged += new System.EventHandler(this.tb3_TextChanged);
			// 
			// button2
			// 
			this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button2.Location = new System.Drawing.Point(267, 198);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(228, 23);
			this.button2.TabIndex = 6;
			this.button2.Text = "Limpar dados";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// tb1
			// 
			this.tb1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.tb1.Location = new System.Drawing.Point(168, 92);
			this.tb1.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
			this.tb1.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
			this.tb1.Name = "tb1";
			this.tb1.Size = new System.Drawing.Size(74, 27);
			this.tb1.TabIndex = 7;
			this.tb1.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(507, 235);
			this.Controls.Add(this.tb1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.tb3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tb2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Gerador de Senha";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.tb1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label label1;
		private Button button1;
		private TextBox tb2;
		private NotifyIcon notifyIcon1;
		private Label label2;
		private TextBox tb3;
		private Button button2;
		private NumericUpDown tb1;
	}
}