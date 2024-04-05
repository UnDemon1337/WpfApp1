using System.Windows;


namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public static bool task(string Task1, string Task2, string Task3, string Task4)
        {
            /*1. Разработайте приложение (консольное или графическое – на ваше усмотрение),
             * которое будет запрашивать баллы за каждое выполненное студентом задание,
             * суммировать баллы и выводить результат (сумма набранных баллов и оценка по 5-тибалльной шкале.*/
            if (!string.IsNullOrEmpty(Task1) && !string.IsNullOrEmpty(Task2) && !string.IsNullOrEmpty(Task3) && !string.IsNullOrEmpty(Task4))
            {
                int proverka;
                int score;
                bool task1proverka = int.TryParse(Task1, out proverka);
                bool task2proverka = int.TryParse(Task2, out proverka);
                bool task3proverka = int.TryParse(Task3, out proverka);
                bool task4proverka = int.TryParse(Task4, out proverka);
                if (task1proverka && task2proverka && task3proverka && task4proverka)
                {
                    if (int.Parse(Task1) > 10)
                    {
                        MessageBox.Show("Максимальный балл за первое задание 10");
                        return false;
                    }
                    else if (int.Parse(Task1) > 10)
                    {
                        MessageBox.Show("Максимальный балл за первое задание 50");
                        return false;
                    }
                    else if (int.Parse(Task1) > 10)
                    {
                        MessageBox.Show("Максимальный балл за первое задание 30");
                        return false;
                    }
                    else if (int.Parse(Task1) > 10)
                    {
                        MessageBox.Show("Максимальный балл за первое задание 10");
                        return false;
                    }
                    score = int.Parse(Task1) + int.Parse(Task2) + int.Parse(Task3) + int.Parse(Task4);
                    if (score <= 100 && score > 70) { Score.Text = "Оценка «5»"; return true; }
                    else if (score < 70 && score >= 40) { Score.Text = "Оценка «4»"; return true; }
                    else if (score < 40 && score >= 20) { Score.Text = "Оценка «3»"; return true; }
                    else if (score <= 20 && score >= 0) { Score.Text = "Оценка «2»"; return true; }
                    else { return false; }
                }
                else
                {
                    MessageBox.Show("Введите целое число");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Заолните все значения");
                return false;
            }
        }
       private void Button_Click(object sender, RoutedEventArgs e)
       {
            task(Task1.Text, Task2.Text, Task3.Text, Task4.Text);
        }
    }
}
