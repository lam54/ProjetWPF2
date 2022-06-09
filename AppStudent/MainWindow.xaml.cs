using AppStudent.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel; 

namespace AppStudent
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml                                                                                                                                                                                             
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // Instanciation de business, le WindowBusiness est devenu l'instance de ManWindowBusiness    
            Business.MainWindowBusiness windowBusiness = new Business.MainWindowBusiness();
            // Affectation windowBusiness à DataContext
            this.DataContext = windowBusiness; 
        }

        private void btnAjout_Click(object sender, RoutedEventArgs e)
        {
            Views.MyUserControl2.UserControl1 UserEtudiant = new Views.MyUserControl2.UserControl1(); ; // Instancier l'objet pour le créer dans la mémoire
            GrContent.Children.Add(UserEtudiant);

            // Affectation de la liste à la DataGrid pour l'affichage.
            //  dgEtudiant.ItemsSource = lstEtudiant; // IdemsSource: un systàme pour recevoir une liste
        }

        private void btnAbs_Click(object sender, RoutedEventArgs e) 

        {
             Views.MyUserControl2.UserControl2 UserAbsence=new Views.MyUserControl2.UserControl2(); // Instancier l'objet pour le créer dans la mémoire
            GrContent.Children.Add(UserAbsence);  //Nous avons rajouté l'objet aux éléments de GrContent. 



        }

       
    }

    }
