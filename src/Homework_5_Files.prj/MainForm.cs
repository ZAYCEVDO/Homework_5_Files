using System.Windows.Forms;
using WindowsFormsApp1.Controls;

namespace WindowsFormsApp1
{
	public partial class MainForm : Form
	{
		#region Data

		private LogControl _log;
		private SettingsControl _settings;
		private PlayerControl _player;

		private LogControler _logControler;
		private PlayerControler _playerControler;
		private ProjectSettings _projectSettings;

		#endregion

		#region .ctor
		public MainForm(LogControler logControler, PlayerControler playerControler, ProjectSettings projectSettings)
		{
			InitializeComponent();

			_projectSettings = projectSettings;
			_logControler = logControler;
			_playerControler = playerControler;

			_log = new LogControl(_logControler);
			_settings = new SettingsControl(_logControler, _projectSettings);
			_player = new PlayerControl(_logControler, _playerControler, _projectSettings);

			_pnlLog.Controls.Add(_log);
			_pnlSettings.Controls.Add(_settings);
			_pnlPlayer.Controls.Add(_player);
		}
		#endregion

	}
}
