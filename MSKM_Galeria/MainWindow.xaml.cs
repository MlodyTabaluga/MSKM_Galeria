﻿using System.Collections.ObjectModel;
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

                        new Photo {Image = "./Images/esa1.jpg", Caption = "Zdjecie 1" },
                        new Photo {Image = "./Images/esa1.jpg", Caption = "Zdjecie 1" },
                        new Photo {Image = "./Images/esa1.jpg", Caption = "Zdjecie 1" }
                    }

                }




            }
        }

    }
}