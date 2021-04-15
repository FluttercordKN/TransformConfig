
namespace TransformConfig
{
	partial class MainForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.tbSourceConfigFile = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.tbTransformConfigFile = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.tbResultConfigFile = new System.Windows.Forms.TextBox();
			this.btnExecute = new System.Windows.Forms.Button();
			this.btnBrowseSource = new System.Windows.Forms.Button();
			this.btnBrowseTransform = new System.Windows.Forms.Button();
			this.btnBrowseResult = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(-276, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "label1";
			// 
			// tbSourceConfigFile
			// 
			this.tbSourceConfigFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbSourceConfigFile.Location = new System.Drawing.Point(117, 12);
			this.tbSourceConfigFile.Name = "tbSourceConfigFile";
			this.tbSourceConfigFile.Size = new System.Drawing.Size(374, 23);
			this.tbSourceConfigFile.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 15);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(99, 15);
			this.label2.TabIndex = 2;
			this.label2.Text = "Source config file";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 44);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(79, 15);
			this.label3.TabIndex = 3;
			this.label3.Text = "Transform file";
			// 
			// tbTransformConfigFile
			// 
			this.tbTransformConfigFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbTransformConfigFile.Location = new System.Drawing.Point(117, 41);
			this.tbTransformConfigFile.Name = "tbTransformConfigFile";
			this.tbTransformConfigFile.Size = new System.Drawing.Size(374, 23);
			this.tbTransformConfigFile.TabIndex = 2;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 73);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(95, 15);
			this.label4.TabIndex = 5;
			this.label4.Text = "Result config file";
			// 
			// tbResultConfigFile
			// 
			this.tbResultConfigFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbResultConfigFile.Location = new System.Drawing.Point(117, 70);
			this.tbResultConfigFile.Name = "tbResultConfigFile";
			this.tbResultConfigFile.Size = new System.Drawing.Size(374, 23);
			this.tbResultConfigFile.TabIndex = 4;
			// 
			// btnExecute
			// 
			this.btnExecute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExecute.Location = new System.Drawing.Point(497, 98);
			this.btnExecute.Name = "btnExecute";
			this.btnExecute.Size = new System.Drawing.Size(75, 23);
			this.btnExecute.TabIndex = 6;
			this.btnExecute.Text = "Execute";
			this.btnExecute.UseVisualStyleBackColor = true;
			this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
			// 
			// btnBrowseSource
			// 
			this.btnBrowseSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBrowseSource.Location = new System.Drawing.Point(497, 12);
			this.btnBrowseSource.Name = "btnBrowseSource";
			this.btnBrowseSource.Size = new System.Drawing.Size(75, 23);
			this.btnBrowseSource.TabIndex = 1;
			this.btnBrowseSource.Text = "Browse…";
			this.btnBrowseSource.UseVisualStyleBackColor = true;
			this.btnBrowseSource.Click += new System.EventHandler(this.btnBrowseSource_Click);
			// 
			// btnBrowseTransform
			// 
			this.btnBrowseTransform.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBrowseTransform.Location = new System.Drawing.Point(497, 41);
			this.btnBrowseTransform.Name = "btnBrowseTransform";
			this.btnBrowseTransform.Size = new System.Drawing.Size(75, 23);
			this.btnBrowseTransform.TabIndex = 3;
			this.btnBrowseTransform.Text = "Browse…";
			this.btnBrowseTransform.UseVisualStyleBackColor = true;
			this.btnBrowseTransform.Click += new System.EventHandler(this.btnBrowseTransform_Click);
			// 
			// btnBrowseResult
			// 
			this.btnBrowseResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBrowseResult.Location = new System.Drawing.Point(497, 69);
			this.btnBrowseResult.Name = "btnBrowseResult";
			this.btnBrowseResult.Size = new System.Drawing.Size(75, 23);
			this.btnBrowseResult.TabIndex = 5;
			this.btnBrowseResult.Text = "Browse…";
			this.btnBrowseResult.UseVisualStyleBackColor = true;
			this.btnBrowseResult.Click += new System.EventHandler(this.btnBrowseResult_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 133);
			this.Controls.Add(this.btnBrowseResult);
			this.Controls.Add(this.btnBrowseTransform);
			this.Controls.Add(this.btnBrowseSource);
			this.Controls.Add(this.btnExecute);
			this.Controls.Add(this.tbResultConfigFile);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.tbTransformConfigFile);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbSourceConfigFile);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(600, 172);
			this.Name = "MainForm";
			this.Text = "Transform config";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbSourceConfigFile;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbTransformConfigFile;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tbResultConfigFile;
		private System.Windows.Forms.Button btnExecute;
		private System.Windows.Forms.Button btnBrowseSource;
		private System.Windows.Forms.Button btnBrowseTransform;
		private System.Windows.Forms.Button btnBrowseResult;
	}
}

