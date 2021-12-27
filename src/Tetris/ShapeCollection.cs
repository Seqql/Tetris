using System.Collections.Generic;
using System.Windows.Media;

namespace Tetris
{

    //More than 2 Shapes form a SapeCollection equal to a form in tetris
    class ShapeCollection
    {   
        public Brush color { get; }

        /// <summary>
        /// Saved as following 
        /// 
        /// "11-11" is equal to a 2x2 block
        /// "10-10-11" is equal to a L
        /// 
        /// 1 = is a block
        /// 0 = not a block
        /// - = next row
        /// </summary>
        public string form { get; }
        public List<Shape> singleShapes { get; set; }
        /// <summary>
        /// The rotate point as index in List
        /// </summary>
        public int centerPoint { get; }
        public bool isRotateAble { get; }
        public int rotateAngle { get; set; }

        public ShapeCollection(SolidColorBrush color, string form, bool isRotateAble)
        {
            this.color = color;
            this.form = form;
            this.singleShapes = new List<Shape>();
            this.isRotateAble = isRotateAble;
            this.centerPoint = -1;
            this.rotateAngle = 0;
        }

        public ShapeCollection(SolidColorBrush color, string form, int centerPoint)
        {
            this.color = color;
            this.form = form;
            this.singleShapes = new List<Shape>();
            this.isRotateAble = true;
            this.centerPoint = centerPoint;
            this.rotateAngle = 0;
        }
    }
}
