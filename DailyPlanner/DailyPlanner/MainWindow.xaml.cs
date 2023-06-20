﻿using DailyPlanner.DAL;
using DailyPlanner.DAL.EF.Interfaces;
using DailyPlanner.DAL.EF.Models;
using Ninject;
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

namespace DailyPlanner
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            var dailyPlannerService = new DailyPlannerService(KernelManager.Kernel.Get<UnitOfWork>());
            this.DataContext = dailyPlannerService.PlannerUOW.Users.GetById(1);
            InitializeComponent();
        }
    }
}
