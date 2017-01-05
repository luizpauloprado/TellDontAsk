using System;

namespace TellDontAsk
{
	public class Square
	{
		public int Height { get; private set; }
		public int Width { get; private set; }

		public Square(int height, int width)
		{
			Height = height;
			Width = width;

			Validate();
		}

		public void Validate()
		{
			if (Height != Width)
				throw new Exception("A square needs height equals width");
		}
	}
}
