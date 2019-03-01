using System;
namespace ProgressBarInConsole
{
	public class ProgressBar
	{
		public int X;
		public int Y;
		public int Progress; //1-100

		public ProgressBar(int x,int y)
		{
			X = x;
			Y = y;
		}

		public void Draw()
		{
			Console.SetCursorPosition(X, Y);
			Console.Write("<[");

			for (int i = 0; i < Progress / 5; i++)
			{
				for (int k = 1; k > 0; k--)
				{
					Console.Write('=');
				}
			}

			Console.SetCursorPosition(22 + X, Y);
			Console.Write("]> {0}%",Progress);
		}
	}
}
