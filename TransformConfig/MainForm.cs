using Microsoft.Web.XmlTransform;

using System;
using System.IO;
using System.Windows.Forms;

namespace TransformConfig
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private bool BrowseFile(out string file)
		{
			using var dialog = new OpenFileDialog { Filter = "Config files (CONFIG)|*.config" };
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				file = dialog.FileName;
				return true;
			}
			else
			{
				file = string.Empty;
				return false;
			}
		}

		private void btnBrowseSource_Click(object sender, EventArgs e)
		{
			if (BrowseFile(out var file))
				tbSourceConfigFile.Text = file;
		}

		private void btnBrowseTransform_Click(object sender, EventArgs e)
		{
			if (BrowseFile(out var file))
				tbTransformConfigFile.Text = file;
		}

		private void btnBrowseResult_Click(object sender, EventArgs e)
		{
			using var dialog = new SaveFileDialog { AddExtension = true, DefaultExt = "config", Filter = "Config files(CONFIG) | *.config" };
			if (dialog.ShowDialog() == DialogResult.OK)
				tbResultConfigFile.Text = dialog.FileName;
		}

		private void btnExecute_Click(object sender, EventArgs e)
		{
			var sourceFile = tbSourceConfigFile.Text;
			if (string.IsNullOrEmpty(sourceFile))
			{
				MessageBox.Show("Source file path is empty.");
				return;
			}
			if (!File.Exists(sourceFile))
			{
				MessageBox.Show("Source file do not exist.");
				return;
			}

			var transformFile = tbTransformConfigFile.Text;
			if (string.IsNullOrEmpty(transformFile))
			{
				MessageBox.Show("Transform file path is empty.");
				return;
			}
			if (!File.Exists(transformFile))
			{
				MessageBox.Show("Transform file do not exist.");
				return;
			}

			var resultFile = tbResultConfigFile.Text;
			if (string.IsNullOrEmpty(resultFile))
			{
				MessageBox.Show("Result file path is not specified.");
				return;
			}

			using var doc = new XmlTransformableDocument();
			doc.Load(sourceFile);
			using var tranform = new XmlTransformation(transformFile);
			if (tranform.Apply(doc))
			{
				doc.Save(resultFile);
				MessageBox.Show("OK!");
			}
			else
			{
				MessageBox.Show("Could not apply transform.");
			}
		}
	}
}
