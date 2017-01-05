using System;
namespace TellDontAsk
{
	public class Paint
	{
		public Paint()
		{
		}

		public Square DrawASquare(int height, int width)
		{
			return new Square(height, width);
		}

		// Violates "Tell Don't Ask"
		/* public Square DrawASquare(int height, int width)
		{
			var square = new Square(height, width);

			if (square.height != square.Width)
				throw new Exception("A square needs height equals width");

			return square;
		}*/
	}
}
