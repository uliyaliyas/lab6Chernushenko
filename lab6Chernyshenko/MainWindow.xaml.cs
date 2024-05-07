using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace lab6Chernyshenko
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
            public MainWindow()
            {
                InitializeComponent();
            }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                int year = int.Parse(Year.Text);
                int month = int.Parse(Month.Text);
                int day = int.Parse(Day.Text);
                int totalDays = 0;
                int DaysInYear(int year)
                {
                    if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
                    {
                        return 366;
                    }
                    else
                    {
                        return 365;
                    }
                }
                int DaysInMonth(int month, int year)
                {
                    switch (month)
                    {
                        case 1:
                        case 3:
                        case 5:
                        case 7:
                        case 8:
                        case 10:
                        case 12:
                            return 31;
                        case 2:
                            if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
                            {
                                return 29;
                            }
                            else
                            {
                                return 28;
                            }
                        default:
                            return 30;
                    }
                }               
                    for (int i = 1; i < year; i++)
                    {
                        totalDays += DaysInYear(i);
                    }
                    for (int i = 1; i < month; i++)
                    {
                        totalDays += DaysInMonth(i, year);
                    }
                    totalDays += day - 1;
                    int dayOfWeek = (totalDays + 1) % 7 + 1;
                    Result.Text = $"День недели: {dayOfWeek}";  
            }
            catch
            {
                MessageBox.Show("Проверьте правильность введенных данных");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int year = int.Parse(Year.Text);
                int month = int.Parse(Month.Text);
                int day = int.Parse(Day.Text);
                int totalDays = 0;

                if (month < 1 || month > 12)
                {
                    throw new ArgumentException("Неверный месяц.");
                }
                if (day < 1 || day > 31)
                {
                    throw new ArgumentException("Неверный день.");
                }

                int DaysInYear(int year)
                {
                    if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
                    {
                        return 366;
                    }
                    else
                    {
                        return 365;
                    }
                }
                int DaysInMonth(int month, int year)
                {
                    switch (month)
                    {
                        case 1:
                        case 3:
                        case 5:
                        case 7:
                        case 8:
                        case 10:
                        case 12:
                            return 31;
                        case 2:
                            if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
                            {
                                return 29;
                            }
                            else
                            {
                                return 28;
                            }
                        default:
                            return 30;
                    }
                }
                for (int i = 1; i < year; i++)
                {
                    totalDays += DaysInYear(i);
                }
                for (int i = 1; i < month; i++)
                {
                    totalDays += DaysInMonth(i, year);
                }
                totalDays += day - 1;
                int dayOfWeek = (totalDays + 1) % 7 + 1;
                Result.Text = $"День недели: {dayOfWeek}";
            }
            catch(Exception ex) 
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                int year = int.Parse(Year.Text);
                int month = int.Parse(Month.Text);
                int day = int.Parse(Day.Text);
                int totalDays = 0;

                if (month < 1 || month > 12)
                {
                    throw new ArgumentException("Неверный месяц.");
                }
                if (day < 1 || day > 31)
                {
                    throw new ArgumentException("Неверный день.");
                }

                int DaysInYear(int year)
                {
                    if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
                    {
                        return 366;
                    }
                    else
                    {
                        return 365;
                    }
                }
                int DaysInMonth(int month, int year)
                {
                    switch (month)
                    {
                        case 1:
                        case 3:
                        case 5:
                        case 7:
                        case 8:
                        case 10:
                        case 12:
                            return 31;
                        case 2:
                            if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
                            {
                                return 29;
                            }
                            else
                            {
                                return 28;
                            }
                        default:
                            return 30;
                    }
                }
                for (int i = 1; i < year; i++)
                {
                    totalDays += DaysInYear(i);
                }
                for (int i = 1; i < month; i++)
                {
                    totalDays += DaysInMonth(i, year);
                }
                totalDays += day - 1;
                int dayOfWeek = (totalDays + 1) % 7 + 1;
                Result.Text = $"День недели: {dayOfWeek}";
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            try
            {
                int year = int.Parse(Year.Text);
                int month = int.Parse(Month.Text);
                int day = int.Parse(Day.Text);
                int totalDays = 0;

                if (month < 1 || month > 12)
                {
                    throw new ArgumentException("Неверный месяц.");
                }
                if (day < 1 || day > 31)
                {
                    throw new ArgumentException("Неверный день.");
                }

                int DaysInYear(int year)
                {
                    if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
                    {
                        return 366;
                    }
                    else
                    {
                        return 365;
                    }
                }
                int DaysInMonth(int month, int year)
                {
                    switch (month)
                    {
                        case 1:
                        case 3:
                        case 5:
                        case 7:
                        case 8:
                        case 10:
                        case 12:
                            return 31;
                        case 2:
                            if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
                            {
                                return 29;
                            }
                            else
                            {
                                return 28;
                            }
                        default:
                            return 30;
                    }
                }
                for (int i = 1; i < year; i++)
                {
                    totalDays += DaysInYear(i);
                }
                for (int i = 1; i < month; i++)
                {
                    totalDays += DaysInMonth(i, year);
                }
                totalDays += day - 1;
                int dayOfWeek = (totalDays + 1) % 7 + 1;
                Result.Text = $"День недели: {dayOfWeek}";
            }
            catch(dayWeekEx ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }
    }
}
