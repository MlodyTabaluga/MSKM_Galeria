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

                        new Photo {Image = "./Images/chorwacja1.jpg", Caption = "Chorwacja" },
                        new Photo {Image = "./Images/chorwacja2.jpg", Caption = "Zdjecie 1" },
                        new Photo {Image = "./Images/wwa.jpg", Caption = "Zdjecie 1" },
                        new Photo {Image = "./Images/wwa2.jpg", Caption = "Zdjecie 1" }
                    }

                },
                new Album
                {
                    Name = "Imprezy",
                    Photos = new ObservableCollection<Photo>
                    {

                        new Photo {Image = "./Images/impreza1.jpg", Caption = "Zdjecie 1" },
                        new Photo {Image = "./Images/impreza2.jpg", Caption = "Zdjecie 1" },
                        new Photo {Image = "./Images/impreza3.jpg", Caption = "Zdjecie 1" },
                        new Photo {Image = "./Images/impreza4.jpg", Caption = "Zdjecie 1" }
                    }

                },

                new Album
                {
                    Name = "Szkola",
                    Photos = new ObservableCollection<Photo>
                    {

                        new Photo {Image = "./Images/szkola1.jpg", Caption = "Zdjecie 1" },
                        new Photo {Image = "./Images/szkola2.jpg", Caption = "Zdjecie 1" },
                        new Photo {Image = "./Images/szkola3.jpg", Caption = "Zdjecie 1" },
                        new Photo {Image = "./Images/szkola4.jpg", Caption = "Zdjecie 1" }
                    }

                },
            };
            albumslistBox.Items = Albums; 
            albumsListBox.SelectionCHanged += AlbumsLIstBox_SelectionChanged;



        }

        private void AlbumsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (albumsListBox.SelectedItems != null)
            {
                Albums selectedAlbum = (Album)albumsListBox.SelectedItem;
                photosLIstView.ItemsSource = selectedAlbum.Photos;
            }
        }


        private void photosListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Photo photo = (Photo)photosListView.SelectedItem;
            Details details = new Details(photo);
            Details.ShowDialog();

        }



    }
}


        
    




    

    
