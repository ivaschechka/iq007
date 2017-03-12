﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace iq007.View
{
    /// <summary>
    /// Логика взаимодействия для ListPupilsPage.xaml
    /// </summary>
    public partial class ListPupilsPage : Page
    {
        ApplicationContext db;
        public ListPupilsPage()
        {
            InitializeComponent();
            db=new ApplicationContext();
            db.Pupils.Load();
            DataContext=db.Pupils.Local.ToBindingList();
        }

        private void Pupillist_Loaded(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
