using System;
using Extensibility;
using EnvDTE;
using EnvDTE80;
using Microsoft.VisualStudio.CommandBars;
using Microsoft.VisualStudio; 
using System.Resources;
using System.Reflection;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace oBuddy
{
	/// <summary>The object for implementing an Add-in.</summary>
	/// <seealso class='IDTExtensibility2' />
	public class Connect : IDTExtensibility2, IDTCommandTarget
	{
		/// <summary>Implements the constructor for the Add-in object. Place your initialization code within this method.</summary>
		public Connect()
		{
		}

		/// <summary>Implements the OnConnection method of the IDTExtensibility2 interface. Receives notification that the Add-in is being loaded.</summary>
		/// <param term='application'>Root object of the host application.</param>
		/// <param term='connectMode'>Describes how the Add-in is being loaded.</param>
		/// <param term='addInInst'>Object representing this Add-in.</param>
		/// <seealso class='IDTExtensibility2' />
		public void OnConnection(object application, ext_ConnectMode connectMode, object addInInst, ref Array custom)
		{
			_applicationObject = (DTE2)application;
			_addInInstance = (AddIn)addInInst;
			if(connectMode == ext_ConnectMode.ext_cm_UISetup)
			{
				object []contextGUIDS = new object[] { };
				Commands2 commands = (Commands2)_applicationObject.Commands;
				string toolsMenuName = "Tools";

				//Place the command on the tools menu.
				//Find the MenuBar command bar, which is the top-level command bar holding all the main menu items:
				Microsoft.VisualStudio.CommandBars.CommandBar menuBarCommandBar = ((Microsoft.VisualStudio.CommandBars.CommandBars)_applicationObject.CommandBars)["MenuBar"];

				//Find the Tools command bar on the MenuBar command bar:
				CommandBarControl toolsControl = menuBarCommandBar.Controls[toolsMenuName];
				CommandBarPopup toolsPopup = (CommandBarPopup)toolsControl;

				//This try/catch block can be duplicated if you wish to add multiple commands to be handled by your Add-in,
				//  just make sure you also update the QueryStatus/Exec method to include the new command names.
				try
				{
					//Add a command to the Commands collection:
					Command command = commands.AddNamedCommand2(_addInInstance, "oBuddy", "oBuddy", "Executes the command for oBuddy", true, 59, ref contextGUIDS, (int)vsCommandStatus.vsCommandStatusSupported+(int)vsCommandStatus.vsCommandStatusEnabled, (int)vsCommandStyle.vsCommandStylePictAndText, vsCommandControlType.vsCommandControlTypeButton);

					//Add a control for the command to the tools menu:
					if((command != null) && (toolsPopup != null))
					{
						command.AddControl(toolsPopup.CommandBar, 1);
					}
				}
				catch(System.ArgumentException)
				{
					//If we are here, then the exception is probably because a command with that name
					//  already exists. If so there is no need to recreate the command and we can 
                    //  safely ignore the exception.
				}
			}
		}

		/// <summary>Implements the OnDisconnection method of the IDTExtensibility2 interface. Receives notification that the Add-in is being unloaded.</summary>
		/// <param term='disconnectMode'>Describes how the Add-in is being unloaded.</param>
		/// <param term='custom'>Array of parameters that are host application specific.</param>
		/// <seealso class='IDTExtensibility2' />
		public void OnDisconnection(ext_DisconnectMode disconnectMode, ref Array custom)
		{
		}

		/// <summary>Implements the OnAddInsUpdate method of the IDTExtensibility2 interface. Receives notification when the collection of Add-ins has changed.</summary>
		/// <param term='custom'>Array of parameters that are host application specific.</param>
		/// <seealso class='IDTExtensibility2' />		
		public void OnAddInsUpdate(ref Array custom)
		{
		}

		/// <summary>Implements the OnStartupComplete method of the IDTExtensibility2 interface. Receives notification that the host application has completed loading.</summary>
		/// <param term='custom'>Array of parameters that are host application specific.</param>
		/// <seealso class='IDTExtensibility2' />
		public void OnStartupComplete(ref Array custom)
		{
		}

		/// <summary>Implements the OnBeginShutdown method of the IDTExtensibility2 interface. Receives notification that the host application is being unloaded.</summary>
		/// <param term='custom'>Array of parameters that are host application specific.</param>
		/// <seealso class='IDTExtensibility2' />
		public void OnBeginShutdown(ref Array custom)
		{
		}
		
		/// <summary>Implements the QueryStatus method of the IDTCommandTarget interface. This is called when the command's availability is updated</summary>
		/// <param term='commandName'>The name of the command to determine state for.</param>
		/// <param term='neededText'>Text that is needed for the command.</param>
		/// <param term='status'>The state of the command in the user interface.</param>
		/// <param term='commandText'>Text requested by the neededText parameter.</param>
		/// <seealso class='Exec' />
		public void QueryStatus(string commandName, vsCommandStatusTextWanted neededText, ref vsCommandStatus status, ref object commandText)
		{
			if(neededText == vsCommandStatusTextWanted.vsCommandStatusTextWantedNone)
			{
				if(commandName == "oBuddy.Connect.oBuddy")
				{
					status = (vsCommandStatus)vsCommandStatus.vsCommandStatusSupported|vsCommandStatus.vsCommandStatusEnabled;
					return;
				}
			}
		}

		/// <summary>Implements the Exec method of the IDTCommandTarget interface. This is called when the command is invoked.</summary>
		/// <param term='commandName'>The name of the command to execute.</param>
		/// <param term='executeOption'>Describes how the command should be run.</param>
		/// <param term='varIn'>Parameters passed from the caller to the command handler.</param>
		/// <param term='varOut'>Parameters passed from the command handler to the caller.</param>
		/// <param term='handled'>Informs the caller if the command was handled or not.</param>
		/// <seealso class='Exec' />
		public void Exec(string commandName, vsCommandExecOption executeOption, ref object varIn, ref object varOut, ref bool handled)
		{
			handled = false;
			if(executeOption == vsCommandExecOption.vsCommandExecOptionDoDefault)
			{
                if(commandName == "oBuddy.Connect.oBuddy")
				{
                    DTE2 dte = _applicationObject;
                    SolutionBuild sb = dte.Solution.SolutionBuild;
                    SolutionConfiguration sc = sb.ActiveConfiguration;
                    
                    // Add-in code.
                    // Create a reference to the Output window.
                    // Create a tool window reference for the Output window and window pane.
                    OutputWindow ow = _applicationObject.ToolWindows.OutputWindow;
                    OutputWindowPane owP;
                    // Create a reference to the pane contents.
                    TextDocument owPTxtDoc;
                    EditPoint2 strtPt;
                    
                    // Select the Build pane in the Output window.
                    owP = ow.OutputWindowPanes.Item("Build");
                    //System.Windows.Forms.MessageBox.Show();
                    owP.Activate();
                    owPTxtDoc = owP.TextDocument;
                    try
                    {
                        sb.Build();
                    }
                    catch (Exception e)
                    {
                        System.Windows.Forms.MessageBox.Show("Project not loaded !! :" + e.Message);
                        handled = true;
                        return;
                    }
                    strtPt = (EditPoint2)owPTxtDoc.StartPoint.CreateEditPoint();
                    // Put some text in the pane.
                    //owP.OutputString("Testing 123.");

                    // Retrieve the text contents of the pane.
                    //System.Windows.Forms.MessageBox.Show("Startpoint: " +owPTxtDoc.StartPoint.DisplayColumn);
                    System.Windows.Forms.MessageBox.Show("processing...");
                    
                    StringWriter buildText = new StringWriter();
                    buildText.WriteLine(strtPt.GetText(owPTxtDoc.EndPoint));
                    string buildOutput = buildText.ToString();

                    System.Windows.Forms.MessageBox.Show(" output : "+buildOutput);

                    string path = dte.ActiveWindow.Document.Path;
                    string tags = dte.ActiveWindow.Document.Language;
                    //string query = "Can not render view in TinyWeb framework";
                    string moreOption = "0";
                    string info = "";
                    //string stackTrace = Environment.StackTrace;
                    string version = Environment.Version.ToString();
                    string OS = Environment.OSVersion.VersionString;
                    string filename = dte.ActiveWindow.Document.Name;

                    //Application.Run(new Form1(msg,tags,filename,moreOption,info,version,OS));

                    char[] delimiters = new char[] { '\r', '\n', ' ', '\0' };
                    char[] stringDelim = new char[] { ',', '.', '-' };
                    string[] lines = buildOutput.Split('\n');
                    string config = new string(new char[] { '\0' });
                    string project = new string(new char[] { '\0' });
                    string fileName = new string(new char[] { '\0' });


                    for (int i = 0; i < lines.Length; i++)
                    {
                        lines[i].Trim(delimiters);

                        if (lines[i].Length > 1)
                        {
                            //System.Windows.Forms.MessageBox.Show(lines[i]);
                            if (lines[i].Contains("------"))
                            {
                                int pos = lines[i].IndexOf("Project: ");
                                project = lines[i].Substring(pos + 9).Split(stringDelim)[0];
                                config = lines[i].Substring(lines[i].IndexOf("Configuration: ") + 15).Split(stringDelim)[0];
                            }
                            else if (lines[i].Contains("==========") || lines[i].Contains("Compile complete"))
                            {
                                continue;
                            }
                            else
                            {
                                char[] stDelim = new char[] { '(', ')' };
                                string[] args = lines[i].Split(stDelim);
                                fileName = lines[i].Substring(0, lines[i].IndexOf('('));
                                string line = lines[i].Substring(lines[i].IndexOf('(') + 1, (lines[i].IndexOf(',') - lines[i].IndexOf('(') - 1));
                                string column = lines[i].Substring(lines[i].IndexOf(',') + 1, (lines[i].IndexOf(')') - lines[i].IndexOf(',') - 1));
                                string rest = lines[i].Substring(lines[i].IndexOf(')') + 2);
                                string error = rest.Substring(0, rest.IndexOf(':'));
                                string fix = rest.Substring(rest.IndexOf(':'));
                                System.Windows.Forms.MessageBox.Show("Filename : " + fileName + "\nline: " + line + "\ncolumn:"
                                    + column + "\nerror:" + error + "\nFix:" + fix);

                                //Application.Run(new Form1(error, tags, filename, moreOption, info, version, OS));
                                Form1 fm1 = new Form1(error, tags, filename, moreOption, info, version, OS);
                                fm1.Show();
                            }
                        }
                    }
                    handled = true;
					return;
				}
			}
		}
		private DTE2 _applicationObject;
		private AddIn _addInInstance;
	}
}