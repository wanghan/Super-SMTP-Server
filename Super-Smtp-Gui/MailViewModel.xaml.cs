﻿using System;
using System.Collections.Generic;
using System.Linq;
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
using System.Net.Mail;

namespace SuperSmtpGui.SMTP
{
    /// <summary>
    /// Interaction logic for MailViewModel.xaml
    /// </summary>
    public partial class MailViewModel : UserControl
    {
        public MailViewModel()
        {
            InitializeComponent();
        }

        private void UserControl_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            new MailMessageWindow(new MailMessageViewModel((MailMessage)this.DataContext)).Show();
        }
    }
}
