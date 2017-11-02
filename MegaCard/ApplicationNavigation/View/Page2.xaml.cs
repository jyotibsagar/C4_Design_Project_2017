using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using ApplicationNavigation.Helpers;

namespace ApplicationNavigation.View
{
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();

            if(GameController.Enemy.currentHealthPoints <= 0)
            {
                Lbl_Result.Content = " GAME OVER. Player Wins";
            }
            if (GameController.Player.currentHealthPoints <= 0)
            {
                Lbl_Result.Content = " GAME OVER. Non Player Wins";
            }


        }


    }
}
