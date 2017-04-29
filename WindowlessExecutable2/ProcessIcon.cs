using System;
using System.Windows.Forms;
using WindowlessExecutable2.Properties;

namespace WindowlessExecutable2 {
	/// <summary>
	/// 
	/// </summary>
	class ProcessIcon : IDisposable {
		/// <summary>
		/// The NotifyIcon object.
		/// </summary>
		NotifyIcon ni;

		/// <summary>
		/// Initializes a new instance of the <see cref="ProcessIcon"/> class.
		/// </summary>
		public ProcessIcon() {
			// Instantiate the NotifyIcon object.
			ni = new NotifyIcon();
		}

		/// <summary>
		/// Displays the icon in the system tray.
		/// </summary>
		public void Display() {
			ni.Icon = Resources.WindowlessExecutable2;
			ni.Text = "Windowless Executable 2";
			ni.Visible = true;

			// Attach a context menu.
			ni.ContextMenuStrip = new ContextMenus().Create();
		}

		/// <summary>
		/// Releases unmanaged and - optionally - managed resources
		/// </summary>
		public void Dispose() {
			// When the application closes, this will remove the icon from the system tray immediately.
			ni.Dispose();
		}
	}
}