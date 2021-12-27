using System.Windows;

namespace Tetris
{
    /// <summary>
    /// Equal to a single tile in the grid
    /// </summary>
    class Shape
    {
        public int row { get; set; }
        public int col { get; set; }

        public UIElement TileInGrid { get; set; }

        public Shape(int row, int col)
        {
            this.row = row;
            this.col = col;
        }
    }
}
