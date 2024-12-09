using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw
{
    public class Presenter
    {
        private Model model;
        private IView view;

        public Presenter(Model m, IView v)
        {

            this.model = m;
            this.view = v;
        }



        public bool CheckWinner(Bitmap symbol)
        {
            foreach (var combination in model.winningCombinations)
            {
                if (model.buttons[combination[0]].Image == symbol &&
                    model.buttons[combination[1]].Image == symbol &&
                    model.buttons[combination[2]].Image == symbol)
                {
                    return true;
                }

            }


            return false;
        }
        public bool CheckDraw()
        {
            foreach (bool move in model.moves)
            {
                if (!move) return false; // Если есть хотя бы одна незаполненная клетка, это не ничья
            }
            return true; // Если все клетки заполнены и нет победителя — ничья
        }

        public void ResetGame()
        {
            foreach (var button in model.buttons)
            {
                button.Image = null;
                button.Enabled = true;
            }

            // Очистка состояния игры
            model.moves = new bool[model.buttons.Length];
            model.compMove = false;



            // Если компьютер начинает, сразу делаем ход
            if (model.compMove)
            {
                MakeComputerMove();
            }


        }


        public void MakePlayerMove(int index)
        {
            if (model.moves[index]) return;

            model.moves[index] = true;
            view.UpdateButton(index, model.imgX);

            if (CheckWinner(model.imgX))
            {
                view.ShowMessage("Игрок X победил!");
                ResetGame();
                return;
            }

            if (CheckDraw())
            {
                view.ShowMessage("Ничья!");
                ResetGame();
                return;
            }

            model.compMove = false;
            MakeComputerMove();

        }




        public void MakeComputerMove()
        {
            bool hasEmptyAreas = false;

            int randomIndex;


            if (view.EasyLevelSelected()) // Легкий уровень
            {
                foreach (bool move in model.moves)
                {
                    if (!move)
                    {
                        hasEmptyAreas = true;
                        break;
                    }
                }

                if (hasEmptyAreas)
                {

                    do
                    {
                        randomIndex = model.random.Next(0, model.buttons.Length);
                    }
                    while (model.moves[randomIndex]);

                    model.moves[randomIndex] = true;
                    model.buttons[randomIndex].Image = model.imgO;
                    model.buttons[randomIndex].Enabled = false;

                }
            }
            else if (!view.EasyLevelSelected())
            {

                // Сложный уровень - более умная логика (например, блокировка выигрыша)
                if (!MakeSmartMove()) // Если не удалось заблокировать или победить, делаем случайный ход
                {
                    do
                    {
                        randomIndex = model.random.Next(0, model.buttons.Length);
                    } while (model.moves[randomIndex]);

                    model.moves[randomIndex] = true;
                    model.buttons[randomIndex].Image = model.imgO;
                    model.buttons[randomIndex].Enabled = false;
                }

            }

            if (CheckWinner(model.imgO))
            {
                MessageBox.Show("Игрок O победил!");
                ResetGame();
                return;
            }

            if (CheckDraw())
            {
                MessageBox.Show("Ничья!");
                ResetGame();
                return;
            }


            model.compMove = false; //передать ход игроку
        }


        private bool MakeSmartMove()
        {
            // Логика для сложного уровня (например, блокируем возможную победу игрока или пытаемся выиграть)
            foreach (var combination in model.winningCombinations)
            {
                int[] line = new int[] { combination[0], combination[1], combination[2] };
                int emptySpot = -1;

                int xCount = 0, oCount = 0;
                foreach (int index in line)
                {
                    if (model.buttons[index].Image == model.imgX) xCount++;
                    else if (model.buttons[index].Image == model.imgO) oCount++;
                    else emptySpot = index; // Найдено пустое место
                }

                // Если есть два X и пустая ячейка, блокируем
                if (xCount == 2 && emptySpot != -1)
                {
                    model.moves[emptySpot] = true;
                    model.buttons[emptySpot].Image = model.imgO;
                    model.buttons[emptySpot].Enabled = false;
                    return true;
                }

                // Если есть два O и пустая ячейка, пытаемся выиграть
                if (oCount == 2 && emptySpot != -1)
                {
                    model.moves[emptySpot] = true;
                    model.buttons[emptySpot].Image = model.imgO;
                    model.buttons[emptySpot].Enabled = false;
                    return true;
                }
            }
            return false; // Если не нашли, делаем случайный ход
        }


    }
}

