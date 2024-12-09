using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace hw
{
    public class Model
    {
       public Bitmap imgX;

        public Bitmap imgO;

        public  Random random = new Random();

        public bool[] moves;

        public Button[] buttons;

        public bool compMove = false;

        public readonly int[][] winningCombinations = new int[][]
{
    new int[] { 0, 1, 2 }, // Горизонтальные
    new int[] { 3, 4, 5 },
    new int[] { 6, 7, 8 },
    new int[] { 0, 3, 6 }, // Вертикальные
    new int[] { 1, 4, 7 },
    new int[] { 2, 5, 8 },
    new int[] { 0, 4, 8 }, // Диагональные
    new int[] { 2, 4, 6 }
};

        public Model()
        {
            imgX = new Bitmap("x.jpg");
            imgO = new Bitmap("o.jpg");
        }
    }

    }

