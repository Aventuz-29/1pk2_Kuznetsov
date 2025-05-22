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

namespace Task_38_04;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
/// Создайте окно для ввода информации о студенте (отдельно фамилия, имя , отчество, группа, пол – перечисление,
///дата рождения(календарь))
///При нажатии на кнопку «сохранить» данные о студенте сохраняются во внутренний список связанный с ListBox
///При закрытии приложения данные сериализируются в файл
public partial class MainWindow : Window
{
    private Library _library = new();
    public MainWindow()
    {
        
        InitializeComponent();
        PaulComboBox.SelectedIndex = 1;
        StudentssListBox.ItemsSource = _library.Studentss;
    }

    private void ClearButton_Click(object sender, RoutedEventArgs e)
    {
        Clear();
    }

    private void SaveButton_Click(object sender, RoutedEventArgs e)
    {
        if (YearDatePicker.SelectedDate == null)
        {
            MessageBox.Show("Пожалуйста, выберите дату рождения");
            return;
        }
        Student student = new Student(
            surnameTextBox.Text,
            NameTextBox.Text,
            PatronymicTextBox.Text,
            GroupTextBox.Text,
            (Paul)PaulComboBox.SelectedIndex,
            YearDatePicker.SelectedDate.Value);
        _library.AddStudent(student);
        StudentssListBox.Items.Refresh();
        Clear();
    }
    private void Clear()
    {
        surnameTextBox.Clear();
        NameTextBox.Clear();
        PatronymicTextBox.Clear();
        GroupTextBox.Clear();
        YearDatePicker.SelectedDate = null;
    }

    private void Window_Loaded(object sender, RoutedEventArgs e)
    {
        _library.Load();
        StudentssListBox.ItemsSource = _library.Studentss;
    }

    private void Window_Closed(object sender, EventArgs e)
    {
        _library.Save();
    }
}