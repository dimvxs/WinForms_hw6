using System.Windows.Forms;

namespace hw
{
    public partial class View : Form, IView
    {

        private Model model;
        private Presenter presenter;

        public View(Model m, Presenter p)
        {
            InitializeComponent();
            this.model = m ?? throw new ArgumentNullException(nameof(m), "Model is null.");
            this.presenter = p ?? throw new ArgumentNullException(nameof(p), "Presenter is null.");
            model.buttons = new Button[] { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
            model.moves = new bool[] { false, false, false, false, false, false, false, false, false };
        }


       
        public bool EasyLevelSelected()
        {
            return radioButton1.Checked;
        }

        public void ShowMessage(string msg)
        {
            MessageBox.Show(msg);
        }

        public void UpdateButton(int index, Bitmap img)
        {
            if (img == null)
            {
                model.buttons[index].Image = null; // Убираем изображение с кнопки
                model.buttons[index].Enabled = true; // Включаем кнопку
            }
            else
            {
                model.buttons[index].Image = img; // Устанавливаем изображение
                model.buttons[index].Enabled = false; // Отключаем кнопку
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {

            Button clicked = sender as Button;


            if (clicked == null) { return; }





            if (!model.compMove) // Ход игрока
            {
                Button clickedButton = (Button)sender;

                int index = Array.IndexOf(model.buttons, clickedButton);

                if (presenter == null)
                {
                    throw new InvalidOperationException("Presenter is not initialized.");
                }

            
                    presenter.MakePlayerMove(index);
                

                if (!presenter.CheckWinner(model.imgX) && !presenter.CheckDraw())
                {
                    model.compMove = true; // Передача хода компьютеру

                    presenter.MakeComputerMove();
                }
            }


        }

        private void button10_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < model.buttons.Length; i++)
            {
                model.buttons[i].Enabled = true;
            }
            presenter.ResetGame();

        }

    }
}
