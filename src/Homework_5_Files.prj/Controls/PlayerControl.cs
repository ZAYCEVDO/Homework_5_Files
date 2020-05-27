using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp1.Controls;

using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace WindowsFormsApp1
{
	/// <summary> Контрол видеопроигрывателя. </summary>
	public partial class PlayerControl : UserControl
	{
		#region Data

		private LogControler _logControler;
		private PlayerControler _playerControler;
		private ProjectSettings _projectSettings;

		#endregion

		#region .ctor

		/// <summary> Создает контрол видеопроигрывателя. </summary>
		public PlayerControl(
			LogControler logControler,
			PlayerControler playerControler,
			ProjectSettings projectSettings)
		{
			InitializeComponent();

			Dock = DockStyle.Fill;

			_logControler = logControler;
			_playerControler = playerControler;
			_projectSettings = projectSettings;

			_playerControler.ChangeImage += OnChangeImage;

			_playerControler.ChangeFrame += OnChangeFrame;

			_opnFileDialog.Filter = "Image|*.png; *.jpg|Video|*.mp4; *.avi;";
		}

		private void OnChangeFrame(object sender, Mat image)
		{
			using(var img = new Mat())
			{
				Cv2.Resize(image, img, new OpenCvSharp.Size(_picVideo.Width, _picVideo.Height), 0, 0, InterpolationFlags.Cubic);
				//_picVideo.ImageIpl = image;
				//_picVideo.Refresh();
				_picVideo.Image = BitmapConverter.ToBitmap(img);
				_picVideo.Refresh();
			}
		}

		#endregion

		#region Handler

		/// <summary> Вызывается при необходимости изменить картинку на панели. </summary>
		private void OnChangeImage(object sender, string path) => _picVideo.Image = Image.FromFile(path);

		/// <summary> Вызывается по нажатию на кнопку открыть файл. </summary>
		private void OnOpenFileClick(object sender, EventArgs e)
		{
			if(_opnFileDialog.ShowDialog() == DialogResult.Cancel) return;

			if(_opnFileDialog.FilterIndex == (int)FilterType.Image)
			{
				_playerControler.OpenImage(_opnFileDialog.FileName);
			}
			else if(_opnFileDialog.FilterIndex == (int)FilterType.Video)
			{
				_playerControler.OpenVideo(_opnFileDialog.FileName);
			}

		}

		/// <summary>Вызывается при нажатии открыть папку. </summary>
		private void OnOpenFolderClick(object sender, EventArgs e)
		{
			if(_opnFolderDialog.ShowDialog() == DialogResult.Cancel) return;

			_playerControler.OpenFolderWithImages(_opnFolderDialog.SelectedPath);
		}

		/// <summary> Вызывается при нажатие на кнопку следующая картинка. </summary>
		private void OnNextClick(object sender, EventArgs e) => _playerControler.NextImage();

		/// <summary> Вызывается при нажатие на кнопку предыдущая картинка. </summary>
		private void OnPreviousClick(object sender, EventArgs e) => _playerControler.PreviousImage();

		/// <summary> Вызывается при нажатие на кнопку start. </summary>
		private void OnStartClick(object sender, EventArgs e) => _playerControler.PlayVideo();

		/// <summary> Вызывается при нажатие на кнопку pause. </summary>
		private void OnPauseClick(object sender, EventArgs e) => _playerControler.PauseVideo();

		/// <summary> Вызывается при нажатие на кнопку stop. </summary>
		private void OnStopClick(object sender, EventArgs e) => _playerControler.StopVideo();
		#endregion
	}
}
