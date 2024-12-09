namespace hw
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // ������������� ������ � ����������
            Model model = new Model();
            Presenter presenter = new Presenter(model, null);  // �������� ������ � ����������

            ApplicationConfiguration.Initialize();
            Application.Run(new View(model, presenter));  // �������� ������ � ���������� � �����������
        }
    }
}
