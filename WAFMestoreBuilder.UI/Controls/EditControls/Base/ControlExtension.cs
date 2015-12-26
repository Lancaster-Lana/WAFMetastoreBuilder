
using System;
using System.Windows.Forms;

namespace WAFMetastoreBuilder.UI
{
	public static class ControlExtension
	{
		public static void AddOnChangeHandlerToInputControls(this Control ctrl)
		{
			//if (ctrl.IsDataLoaded)
			foreach (Control subctrl in ctrl.Controls)
			{
				if (subctrl is TextBox)
					subctrl.TextChanged += InputControls_OnChange;
				if (subctrl is CheckBox)
					((CheckBox)subctrl).CheckedChanged += InputControls_OnChange;
				else if (subctrl is RadioButton)
					((RadioButton)subctrl).CheckedChanged += InputControls_OnChange;
				else if (subctrl is ListControl)
				{
					((ListControl)subctrl).SelectedValueChanged += InputControls_OnChange;
					subctrl.TextChanged += InputControls_OnChange;
					// if (subctrl is ComboBox)
					//	((ComboBox) subctrl).SelectedIndexChanged += InputControls_OnChange;
				}
				else
				{
					if (subctrl.Controls.Count > 0)
						subctrl.AddOnChangeHandlerToInputControls();
				}
			}
		}

		private static void InputControls_OnChange(object sender, EventArgs e)
		{
			// Do something to indicate the form is dirty like:
			var ctrl = (Control)sender;
			var parent = ctrl.Parent;

			//get parent editable control - BaseWAFCtrl surface
			do
			{
				if (parent is BaseWAFCtrl)
					break;
				parent = parent.Parent;
			}
			while (parent != null);

			if (parent != null)
			{
				((BaseWAFCtrl)parent).IsDirty = true;
			}
		}
	}
}