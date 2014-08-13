using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using XNAContentCompiler.Building;
using XNAContentCompiler.Creation;

namespace XNAContentCompiler
{
    public partial class ContentCompilerForm : Form
    {
		// fields

	    private readonly XnaContentProject xnaContentProject;
        private readonly ProjectBuilder projectBuilder;

		// constructors

        public ContentCompilerForm()
        {
	        InitializeComponent();

			projectBuilder = new ProjectBuilder();
	        projectBuilder.Error += (sender, e) => LogMessage(e.Message, false);

			xnaContentProject = new XnaContentProject();
			xnaContentProject.ContentItems = new BindingList<XnaContentItem>();

	        dataGridView.AutoGenerateColumns = false;
			dataGridView.DataSource = xnaContentProject.ContentItems;
		}

		// events

		private void Exit(object sender, EventArgs e)
		{
			Close();
		}

		// content items

        private void AddContentItem(object sender, EventArgs e)
        {
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				foreach (var path in openFileDialog.FileNames)
				{
					xnaContentProject.ContentItems.Add(new XnaContentItem(path));
				}
			}
        }

		private void AddContentFolder(object sender, EventArgs e)
		{
			if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
			{
				foreach (var path in Directory.GetFiles(folderBrowserDialog.SelectedPath))
				{
					xnaContentProject.ContentItems.Add(new XnaContentItem(path));
				}
			}
		}

	    private void RemoveContentItem(object sender, EventArgs e)
	    {
		    if (MessageBox.Show("Are you sure you want to remove the selected items?", "Remove Item", 
				MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
		    {
				// get all the items to remove before removing
			    XnaContentItem[] selected = dataGridView.SelectedRows
					.Cast<DataGridViewRow>()
					.Select(x => x.DataBoundItem)
					.Cast<XnaContentItem>()
					.ToArray();
				// and remove them
				foreach (XnaContentItem item in selected)
			    {
					xnaContentProject.ContentItems.Remove(item);
			    }
		    }
	    }

		private void GridSelectionChanged(object sender, EventArgs e)
		{
			propertyGrid.SelectedObjects = dataGridView.SelectedRows.Cast<DataGridViewRow>().Select(x => x.DataBoundItem).ToArray();
		}

		// content project

	    private async void CompileProject(object sender, EventArgs e)
	    {
		    // disable the UI
		    mainInterfacePanel.Enabled = false;
		    // start the logging...
		    logWindow.Clear();
		    LogMessage("Starting build...", true);
			statusProgressBar.Visible = true;

		    if (xnaContentProject.ContentItems.Count > 0)
		    {
			    // do the work
			    try
			    {
				    bool success = await Task.Run(() => projectBuilder.Build(xnaContentProject));
				    LogMessage(success ? "Build completed successfully." : "Build failed.", true);
			    }
			    catch (Exception ex)
			    {
					LogMessage("Build failed.", true);
					LogMessage(ex.ToString(), false);
			    }
		    }
		    else
		    {
			    LogMessage("Nothing to build.", true);
		    }

		    // finish up
		    mainInterfacePanel.Enabled = true;
			statusProgressBar.Visible = false;
		}

	    private void EditProjectSettings(object sender, EventArgs e)
		{
			propertyGrid.SelectedObject = xnaContentProject;
		}

		private void HelpAbout(object sender, EventArgs e)
		{

		}

		// logging to the log window

	    private void LogMessage(string message, bool statusMessage)
	    {
		    if (InvokeRequired)
		    {
				Invoke(new LogMessageDelegate(LogMessage), message, statusMessage);
		    }
		    else
		    {
			    if (statusMessage)
				    statusTextLabel.Text = message;
			   logWindow.AppendText(Environment.NewLine + message);
		    }
	    }
		delegate void LogMessageDelegate(string message, bool statusMessage);
    }
}