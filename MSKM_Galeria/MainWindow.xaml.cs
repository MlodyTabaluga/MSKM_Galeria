using System.Collections.ObjectModel;
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

namespace MSKM_Galeria
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Album> Albums { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            Albums = new ObservableCollection<Album>
            {
                new Album
                {
                    Name = "Wycieczki",
                    Photos = new ObservableCollection<Photo>
                    {

                        new Photo {Image = "./Images/chorwacja1.jpg", Caption = "Chorwacja góry" },
                        new Photo {Image = "./Images/chorwacja2.jpg", Caption = "Chorwacja autobus" },
                        new Photo {Image = "./Images/wwa.jpg", Caption = "Warszawa Stadion" },
                        new Photo {Image = "./Images/wwa2.jpg", Caption = "Strefa Ruchu Warszawa" }
                    }

                },
                new Album
                {
                    Name = "Imprezy",
                    Photos = new ObservableCollection<Photo>
                    {

                        new Photo {Image = "./Images/impreza1.jpg", Caption = "18 belligol" },
                        new Photo {Image = "./Images/impreza2.jpg", Caption = "Łazienka Stara wieś" },
                        new Photo {Image = "./Images/impreza3.jpg", Caption = "Majówka u matiego" },
                        new Photo {Image = "./Images/impreza4.jpg", Caption = "18-nastka" }
                    }

                },

                new Album
                {
                    Name = "Szkola",
                    Photos = new ObservableCollection<Photo>
                    {

                        new Photo {Image = "./Images/szkola1.jpg", Caption = "Alek, Miłosz i Kacper" },
                        new Photo {Image = "./Images/szkola2.jpg", Caption = "Squad" },
                        new Photo {Image = "./Images/szkola3.jpg", Caption = "Zdjecię z diho" },
                        new Photo {Image = "./Images/szkola4.jpg", Caption = "MechanCraft" }
                    }

                },
            };

            albumsListBox.ItemsSource = Albums;
            albumsListBox.SelectionChanged += AlbumsListBox_SelectionChanged;



        }

        private void AlbumsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (albumsListBox.SelectedItems != null)
            {
                Album selectedAlbum = (Album)albumsListBox.SelectedItem;
                photosListView.ItemsSource = selectedAlbum.Photos;
            }
        }


        private void photosListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Photo photo = (Photo)photosListView.SelectedItem;
            Details details = new Details(photo);
            details.ShowDialog();

        }
    }
}


        
    




    

    
