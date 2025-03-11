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
        if (my_ComboBox.SelectedIndex == 0)
        {
            comboBoxValue = "Nie wybrano zainteresowania";
        }
        else
        {
            comboBoxValue =  (string)((ComboBoxItem)my_ComboBox.SelectedItem).Content;
        }
        var textBoxValue = TextBox.Text;

        if (string.IsNullOrWhiteSpace(TextBox.Text) || TextBox.Text == "Wpisz swoje imię")
        {
            textBoxValue = "Musisz wprowadzić swoje imię!";
        }
        else
        {
            textBoxValue =  TextBox.Text;
        }
        
        infoLabel.Content = $"Imie: {textBoxValue}\n zainteresowanie: {comboBoxValue}\n";
    }
    private void SubmitButton_Click2(object? sender, RoutedEventArgs e)
    {
        var wynik = 0;
        
        var checkBoxValue1 = myCheckBox1.IsChecked == true ? wynik+=1 : 0;
        var checkBoxValue2 = myCheckBox2.IsChecked == true ? wynik+=1 : 0;
        var checkBoxValue3 = myCheckBox3.IsChecked == true ? wynik+=1 : 0;
        
        infoLabel2.Content = $"ilosc odpowiedzi na tak: {wynik}";
    }
}