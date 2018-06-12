using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SystemMonitor
{
	public class DataBar : System.Windows.Forms.UserControl
    {
		private System.ComponentModel.Container components = null;
		int _value;
		Color _colorBar;

		#region Constructor/Dispose
		public DataBar()
		{
			InitializeComponent();
			BackColor = Color.Silver;

			_value = 0;
			_colorBar = Color.DarkBlue;
		}

		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}
		#endregion

		#region Component Designer generated code
		private void InitializeComponent()
		{
			this.Name = "DataBar";
			this.Size = new System.Drawing.Size(128, 16);
		}
		#endregion

		#region "Properties"
		[Description("Gets or sets the current Bar Color in chart"), Category("Appearance")]
		public Color BarColor
		{
			get { return _colorBar; }
			set { _colorBar = value; }
		}

		[Description("Gets or sets the current value in data bar"), Category("Behavior")]
		public int Value
		{
			get { return _value; }
			set
			{
				_value = value;
				Invalidate();
			}
		}
		#endregion


		#region Drawing
		protected override void OnPaint(PaintEventArgs e)
		{
			Rectangle rt = this.ClientRectangle;
			e.Graphics.FillRectangle(new SolidBrush(_colorBar), 0, 0, rt.Width*_value/100, rt.Height);
				
			base.OnPaint(e);
		}
		#endregion

	}
}
