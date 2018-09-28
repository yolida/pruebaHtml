using System;
using System.Windows;

namespace FEI
{
    public partial class Declarante : Window
    {
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            DialogResult = true;
        }

        private void Window_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            int compare = e.Key.CompareTo(System.Windows.Input.Key.Escape);
            if (compare == 0)
            {
                Close();
            }
        }
    }
}
