﻿using System;
using System.Windows;

namespace NPCGenerator.Windows
{
    public partial class InputDialog
    {
        public InputDialog(string info)
        {
            InitializeComponent();
            lvlInfoText.Content = info;
            txtInput.Text = string.Empty;
        }

        private void btnDialogOk_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void Window_ContentRendered(object sender, EventArgs e)
        {
            txtInput.SelectAll();
            txtInput.Focus();
        }

        public string Input => txtInput.Text;
    }
}