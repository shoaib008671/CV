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



namespace CV
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        public MainWindow()
        {
            InitializeComponent();
            this.PreviewKeyDown += new KeyEventHandler(HandleEsc);
             viewdata();
        }

        private void profbtn_Click(object sender, RoutedEventArgs e)
        {
            
            tab.SelectedIndex = 1;

        }

       

        private void skillbtn_Click(object sender, RoutedEventArgs e)
        {
            tab.SelectedIndex = 2;

        }

        private void Projbn_Click(object sender, RoutedEventArgs e)
        {
            tab.SelectedIndex = 3;

        }

        private void expbtn_Click(object sender, RoutedEventArgs e)
        {
            tab.SelectedIndex = 4;

        }

        private void edubn_Click(object sender, RoutedEventArgs e)
        {
            tab.SelectedIndex = 5;

        }

        private void hobbbtn_Click(object sender, RoutedEventArgs e)
        {
            tab.SelectedIndex = 6;

        }

        private void langbtn_Click(object sender, RoutedEventArgs e)
        {
            tab.SelectedIndex = 7;

        }

        private void tab_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void HandleEsc(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Escape && tab.SelectedIndex==0)
            {
                this.Close();
            }
            else
            {
                tab.SelectedIndex = 0;
            }

        }

        public void viewdata()
        {
            NAME.Content = "Muhammad Shoaib";
            FNAME.Content = "Muhammad Ubaid Ullah";
            DB.Content = "2nd    AUG, 1993";
            CNIC.Content = "38402-2710621-9";
            Dom.Content = "Sargodha(Punjab)";
            Rel.Content = "Islam";
            Mstatus.Content = "Single";
            Addr.Content = "House# 60 Q-Block Johar Town Lahore ";

            shoesell.Content = "HTML, CSS, PHP, WAMP Server";
            shoesell2.Content = "Semester Project, (University Of Sargodha), 2013";
            ProdS.Content = "C#, .NET, MS Access Server";
            ProdS2.Content = "Semester Project, (University Of Sargodha), 2014";
            Iden.Content = "C#, XAML, WPF, Artificial Intelligence";
            Iden2.Content = "Final Year Project, (University Of Sargodha), 2015";
            Echo.Content = "C#, XAML, WPF, Window Form Integration";
            Echo2.Content = "Open Source Project Registered at GNU";

                  
        }



       
        
    }
}
