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
using ClassLibrary1;

namespace WpfApp5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            queenColorComboBox.Items.Add("Чёрный");
            queenColorComboBox.Items.Add("Белый");

            rookColorComboBox.Items.Add("Чёрный");
            rookColorComboBox.Items.Add("Белый");

            bishopColorComboBox.Items.Add("Чёрный");
            bishopColorComboBox.Items.Add("Белый");
        }

        private void queenMakeMoveButton_Click(object sender, RoutedEventArgs e)
        {
            string color;

            if (queenColorComboBox.SelectedItem == null)
            {
                MessageBox.Show("Укажите цвет ферзя");
                return;
            }
            else
            {
                color = queenColorComboBox.SelectedItem.ToString();
            }
            char currentColumn = queenCurrentColumnTextBox.Text[0];
            int currentRow = int.Parse(queenCurrentRowTextBox.Text);
            char newColumn = queenNewColumnTextBox.Text[0];
            int newRow = int.Parse(queenNewRowTextBox.Text);

            Queen queen = new Queen(color, currentColumn, currentRow);

            try
            {
                queen.MakeMove(newColumn, newRow);

                queenNewColumnTextBox.Text = "";
                queenNewRowTextBox.Text = "";
                queenCurrentColumnTextBox.Text = queen.Column.ToString();
                queenCurrentRowTextBox.Text = queen.Row.ToString();
            }
            catch (Exception exc) 
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void rookMakeMoveButton_Click(object sender, RoutedEventArgs e)
        {
            string color;

            if (rookColorComboBox.SelectedItem == null)
            {
                MessageBox.Show("Укажите цвет ферзя");
                return;
            }
            else
            {
                color = rookColorComboBox.SelectedItem.ToString();
            }

            char currentColumn = rookCurrentColumnTextBox.Text[0];
            int currentRow = int.Parse(rookCurrentRowTextBox.Text);
            char newColumn = rookNewColumnTextBox.Text[0];
            int newRow = int.Parse(rookNewRowTextBox.Text);

            Rook rook = new Rook(color, currentColumn, currentRow);

            try
            {
                rook.MakeMove(newColumn, newRow);

                rookNewColumnTextBox.Text = "";
                rookNewRowTextBox.Text = "";
                rookCurrentColumnTextBox.Text = rook.Column.ToString();
                rookCurrentRowTextBox.Text = rook.Row.ToString();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void bishopMakeMoveButton_Click(object sender, RoutedEventArgs e)
        {
            string color;

            if (bishopColorComboBox.SelectedItem == null)
            {
                MessageBox.Show("Укажите цвет ферзя");
                return;
            }
            else
            {
                color = bishopColorComboBox.SelectedItem.ToString();
            }

            char currentColumn = bishopCurrentColumnTextBox.Text[0];
            int currentRow = int.Parse(bishopCurrentRowTextBox.Text);
            char newColumn = bishopNewColumnTextBox.Text[0];
            int newRow = int.Parse(bishopNewRowTextBox.Text);

            Bishop bishop = new Bishop(color, currentColumn, currentRow);


            try
            {
                bishop.MakeMove(newColumn, newRow);

                bishopNewColumnTextBox.Text = "";
                bishopNewRowTextBox.Text = "";
                bishopCurrentColumnTextBox.Text = bishop.Column.ToString();
                bishopCurrentRowTextBox.Text = bishop.Row.ToString();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}