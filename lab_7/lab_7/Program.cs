using System;
using System.Windows.Forms;

namespace lab_7
{
	static class Program
	{
		static Form1 mainForm;

		/// <summary>
		/// Главная точка входа для приложения.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.ThreadException += OnException;
			Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			mainForm = new Form1();

			Application.Run(mainForm);
		}

		private static void OnException(object sender, System.Threading.ThreadExceptionEventArgs e)
		{
			mainForm.Reset();
			MessageBox.Show(e.Exception.Message);
		}
	}
}
