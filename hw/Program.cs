namespace hw
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // Инициализация модели и презентера
            Model model = new Model();
            Presenter presenter = new Presenter(model, null);  // Передача модели и презентера

            ApplicationConfiguration.Initialize();
            Application.Run(new View(model, presenter));  // Передача модели и презентера в конструктор
        }
    }
}
