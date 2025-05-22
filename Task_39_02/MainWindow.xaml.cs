using Microsoft.Win32;
using System.Collections.ObjectModel;
using System.IO;
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

namespace Task_39_02;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
/// Создайте приложение – список покупок. Использовать ListBox. В качестве источника данных использовать не List а
///ObservableCollection
///Функции:
///• Ввод продуктов
///• Сохранение списка продуктов в текстовый файл
///• Использовать стандартные диалоговые окна
public partial class MainWindow : Window
{
    private ObservableCollection<string> shoppingItems = new ObservableCollection<string>();
    public MainWindow()
    {
        InitializeComponent();
        ShoppingListBox.ItemsSource = shoppingItems;
    }

    private void SaveButton_Click(object sender, RoutedEventArgs e)
    {
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
        saveFileDialog.DefaultExt = ".txt";

        if (saveFileDialog.ShowDialog() == true)
        {
            try
            {
                File.WriteAllLines(saveFileDialog.FileName, shoppingItems);
                MessageBox.Show("Список успешно сохранен!", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении файла: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }

    private void addButton_Click(object sender, RoutedEventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(ProdTextBox.Text))
        {
            shoppingItems.Add(ProdTextBox.Text);
            ProdTextBox.Clear();
        }
    }

    private void openButton_Click(object sender, RoutedEventArgs e)
    {
        OpenFileDialog openFileDialog = new OpenFileDialog()
        {
            Title = "Открыть",
            Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*",
            InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
        };

        if (openFileDialog.ShowDialog() == true)
        {
            try
            {
                string content = File.ReadAllText(openFileDialog.FileName);
                ProdTextBox.Text = content;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Невозможно открыть файл",
                    "Ошибка",
                    MessageBoxButton.YesNoCancel,
                    MessageBoxImage.Exclamation);
            }
        }
    }
}