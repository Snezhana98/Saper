using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace Saper
{
    class MainClass
    {
        Grid grid;
        List<Viewbox> listBombs;
        List<Point> listCoordBomb;
        
        public MainClass(Grid gr)
        {
            grid = gr;
            OnGridBomb();
            onGridNumbers();
        }
        //💣
        void OnGridBomb()
        {
            for (int i = 1; i <= 8; i++)
            {
                ColumnDefinition colDef = new ColumnDefinition();
                grid.ColumnDefinitions.Add(colDef);
                RowDefinition rowDef = new RowDefinition();
                grid.RowDefinitions.Add(rowDef);
            }
            grid.ShowGridLines = true;

            Random random = new Random();
            listBombs = new List<Viewbox>(10);
            listCoordBomb = new List<Point>(10);

            for (int i = 0; i < 10; i++)
            {
                int randomBombCol = random.Next(0, 7);
                int randomBombRow = random.Next(0, 7);

                listCoordBomb.Add(new Point(randomBombCol, randomBombRow));

                TextBlock Bomb = new TextBlock();
                Bomb.Text = "💣";
                Viewbox viewbox = new Viewbox();
                viewbox.Child = Bomb;
                listBombs.Add(viewbox);
                grid.Children.Add(viewbox);

                Grid.SetColumn(viewbox, randomBombCol);
                Grid.SetRow(viewbox, randomBombRow);
            }
        }

            //void onGridNumbers()
            //{
            //for (int i = 0; i < listCoordBomb.Count; i++)
            //{

            //}
            //}

            //if (listCoordBomb[i + 1].X != listCoordBomb[i].X && listCoordBomb[i + 1].Y != listCoordBomb[i].Y)
            //{
            //    Grid.SetColumn(viewbox, randomBombCol);
            //    Grid.SetRow(viewbox, randomBombRow);
            //}
            //else return;








     
    }
}
