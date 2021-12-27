using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Tetris
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int _height;
        public int CustomHeight
        {
            get { return _height; }
            set
            {
                if (value != _height)
                {
                    _height = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomHeight"));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;

            init();
        }

        private int cellSize, columns = 10, rows;

        private int Score = 0;
        private int moveDownSpeed = 500; //Milliseconds; 
        private ShapeCollection currShape;
        private ShapeCollection nextShape;

        private void init()
        {
            setWindowAndGridHeight();

            //Create Rows and Cols for the Grid
            for (int i = 0; i < rows; i++)
            {
                RowDefinition newRow = new RowDefinition();

                newRow.MinHeight = (double)cellSize;
                newRow.MaxHeight = cellSize;

                TetrisGrid.RowDefinitions.Add(newRow);
            }
            for (int i = 0; i < columns; i++)
            {
                ColumnDefinition newCol = new ColumnDefinition();

                newCol.MaxWidth = cellSize;
                newCol.MinWidth = cellSize;

                TetrisGrid.ColumnDefinitions.Add(newCol);
            }


        }

        private void setWindowAndGridHeight()
        {
            TetrisGrid.MinHeight = 600;
            TetrisGrid.MinWidth = 400;

            CustomHeight = (int)SystemParameters.PrimaryScreenHeight;

            cellSize = (int)(TetrisGrid.Width / columns);
            TetrisGrid.Height = cellSize * (int)((CustomHeight - 150) / cellSize);

            rows = (int)(TetrisGrid.Height / cellSize);
        }


        private void MoveShapeDown()
        {
            int i = 0;
            while(i < 5)
            {
                foreach (Shape shape in currShape.singleShapes)
                {
                    TetrisGrid.Children.Remove(shape.TileInGrid);
                    shape.row++;
                    Grid.SetRow(shape.TileInGrid, shape.row);
                    Grid.SetColumn(shape.TileInGrid, shape.col);

                    //TetrisGrid.Children.Add(shape.TileInGrid);
                }
                i++;
                Thread.Sleep(moveDownSpeed);
            }
        }

        private void setNextShape()
        {
            nextShape = getRandomShape();

            setDefaultPosInGridForShape(ref nextShape);

            setShapeInGrid(nextShape, false);
        }


        private Rectangle createUIRect(Brush color, int size)
        {
            Rectangle rect = new Rectangle();

            rect.Width = size;
            rect.Height = size;

            rect.Fill = color;

            return rect;
        }

        private void changeRectColor(ref Rectangle rect, Brush color)
        {
            rect.Fill = color;
        }
        private void setDefaultPosInGridForShape(ref ShapeCollection shape)
        {
            int row = 0;
            int col = 0;


            foreach (char item in shape.form)
            {
                if (item == '-')
                {             
                    row++;    
                    col = 0;  
                    continue; 
                }             
                              
                if (item == '1')
                {
                    Shape newShape = new Shape(row, col);
                    shape.singleShapes.Add(newShape);
                }

                col++;
            }
        }

        private void setShapeInGrid(ShapeCollection shape, bool isTetrisGrid)
        {
            int offset = 0;
            if (isTetrisGrid)
            {
                int formWidth = shape.form.Split('-')[0].Length;
                offset = (int)(columns / 2) - (int)(formWidth / 2);
            }
            else
            {
                PreviewGrid.Children.Clear();
            }


            int rectSize = isTetrisGrid ? cellSize : 50;
            foreach (Shape item in shape.singleShapes)
            {
                
                item.TileInGrid = createUIRect(shape.color, rectSize);

                Grid.SetColumn(item.TileInGrid, offset + item.col);
                Grid.SetRow(item.TileInGrid, item.row);

                if (isTetrisGrid)
                    TetrisGrid.Children.Add(item.TileInGrid);
                else
                    PreviewGrid.Children.Add(item.TileInGrid);
            }
        }

        private void Btn_Start_Click(object sender, RoutedEventArgs e)
        {
            setNextShape();
            setCurrShape();

            Button el = (Button)e.Source;

            MoveShapeDown();

            el.Click -= Btn_Start_Click;
        }

        private void setCurrShape()
        {
            currShape = nextShape;
            setShapeInGrid(currShape, true);
            setNextShape();
        }

        private ShapeCollection getRandomShape()
        {
            Random r = new Random();
            int random = r.Next(11);
            ShapeCollection back = null;

            switch (random)
            {
                case 0:
                    back = ShapeCollectionExamples.L; break;
                case 1:
                    back = ShapeCollectionExamples.LInverse; break;
                case 2:
                    back = ShapeCollectionExamples.Block; break;
                case 3:
                    back = ShapeCollectionExamples.Stick_3; break;
                case 4:
                    back = ShapeCollectionExamples.Stick_4; break;
                case 5:
                    back = ShapeCollectionExamples.Lightning; break;
                case 6:
                    back = ShapeCollectionExamples.LightningInverse; break;
                case 7:
                    back = ShapeCollectionExamples.Corner; break;
                case 8:
                    back = ShapeCollectionExamples.CornerInverse; break;
                case 9:
                    back = ShapeCollectionExamples.SmallT; break;
                case 10:
                    back = ShapeCollectionExamples.Point; break;
                default:
                    break;
            }
            return back;
        }
    }
}
