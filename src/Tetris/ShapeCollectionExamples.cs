using System.Collections.Generic;
using System.Windows.Media;

namespace Tetris
{
    static class ShapeCollectionExamples
    {
        internal static ShapeCollection L = new ShapeCollection(Brushes.Yellow, "10-10-11", 4);
        internal static ShapeCollection LInverse = new ShapeCollection(Brushes.PaleGreen, "01-01-11", 4);
        internal static ShapeCollection Block = new ShapeCollection(Brushes.Violet, "11-11", false);
        internal static ShapeCollection Stick_3 = new ShapeCollection(Brushes.Red, "1-1-1", 1);
        internal static ShapeCollection Stick_4 = new ShapeCollection(Brushes.Plum, "1-1-1-1", 1);
        internal static ShapeCollection Lightning = new ShapeCollection(Brushes.Blue, "011-110", 4);
        internal static ShapeCollection LightningInverse = new ShapeCollection(Brushes.Orange, "110-011", 4);
        internal static ShapeCollection Corner = new ShapeCollection(Brushes.PeachPuff, "10-11", 2);
        internal static ShapeCollection CornerInverse = new ShapeCollection(Brushes.AliceBlue, "01-11", 2);
        internal static ShapeCollection SmallT = new ShapeCollection(Brushes.ForestGreen, "010-111", 1);
        internal static ShapeCollection Point = new ShapeCollection(Brushes.Azure, "1", false);
    }
}
