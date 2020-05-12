using System.Windows.Forms;
using WindowsFormsApp1.Controls;

namespace WindowsFormsApp1
{
	public partial class LogControl : UserControl
	{
		#region Data

		private LogControler _logControler;

		#endregion

		#region .ctor

		/// <summary> Создать контрол лога. </summary>
		/// <param name="log"> LogControler, который привязывается к логу </param>
		public LogControl(LogControler log)
		{
			InitializeComponent();
			Dock = DockStyle.Fill;

			_logControler = log;

			_logControler.AddMessageInLog += OnAddMessageInLog;

		}

		#endregion

		#region Methods

		/// <summary> Добавление текста в Лог. </summary>
		private void OnAddMessageInLog(object sender, string text)
		{
			_txtLog.AppendText(text);
		}

		#endregion

	}
}

