using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Ankieta_Preferencji;

public partial class MainWindow : Window
{
   
    public MainWindow()
    {
        InitializeComponent();
        
        
    }
    
    private void SubmitButton_Click(object? sender, RoutedEventArgs e)
    {
        var comboBoxValue = (my_ComboBox.SelectedItem as ComboBoxItem)?.Content?.ToString() ?? "No selection";
        var textBoxValue = TextBox.Text;

        infoLabel.Content = $"{textBoxValue} i jego zainteresowanie to {comboBoxValue}";
    }
}