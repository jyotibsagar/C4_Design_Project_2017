using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using ApplicationNavigation.Helpers;

namespace ApplicationNavigation.View
{
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
           
            Lbl_CharacterName.Content = "Player: " + GameController.Player.CharacterName;
            Player_hp.Content = " HP: " + GameController.Player.currentHealthPoints;
            Player_dmg.Content = " Dmg: " + GameController.Player.baseDamage;

            if (GameController.Player.CharacterName.Equals("Warrior"))
            {

                //Img_Character.Source = (ImageSource)new ImageSourceConverter().ConvertFromString("warrior.png");
                BitmapImage b = new BitmapImage();
                b.BeginInit();
                b.UriSource = new Uri("c:\\images\\warrior.png");
                b.EndInit();

                // ... Assign Source.
                Img_Character.Source = b;
                

            }

            if (GameController.Player.CharacterName.Equals("Mage"))
            {

                //Img_Character.Source = (ImageSource)new ImageSourceConverter().ConvertFromString("warrior.png");
                BitmapImage b = new BitmapImage();
                b.BeginInit();
                b.UriSource = new Uri("c:\\images\\mage.png");
                b.EndInit();

                // ... Assign Source.
                Img_Character.Source = b;


            }

            if (GameController.Player.CharacterName.Equals("Thief"))
            {

                //Img_Character.Source = (ImageSource)new ImageSourceConverter().ConvertFromString("warrior.png");
                BitmapImage b = new BitmapImage();
                b.BeginInit();
                b.UriSource = new Uri("c:\\images\\thief.png");
                b.EndInit();

                // ... Assign Source.
                Img_Character.Source = b;


            }

            // Non Player Character 
            Npc_hp.Content = " HP: " + GameController.Enemy.currentHealthPoints;
            BitmapImage b1 = new BitmapImage();
            b1.BeginInit();
            b1.UriSource = new Uri("c:\\images\\npc.jpg");
            b1.EndInit();

            // ... Assign Source.
            Img_NPC.Source = b1;

            Npc_hp.Content = " HP: " + GameController.Enemy.currentHealthPoints;
            Npc_dmg.Content = " Dmg: " + GameController.Enemy.baseDamage;


        }

        private void Button_NormalAttack_Click(object sender, RoutedEventArgs e)
        {
            
            GameController.Player.Attack(GameController.Enemy);
            Lbl_CharacterName.Content = "Player: " + GameController.Player.CharacterName;
            Player_hp.Content = " HP: " + GameController.Player.currentHealthPoints;
            Player_dmg.Content = " Dmg: " + GameController.Player.baseDamage;
            Npc_hp.Content = " HP: " + GameController.Enemy.currentHealthPoints;
            Npc_dmg.Content = " Dmg: " + GameController.Enemy.baseDamage;

            GameController.Enemy.Attack(GameController.Player);
            Lbl_CharacterName.Content = "Player: " + GameController.Player.CharacterName;
            Player_hp.Content = " HP: " + GameController.Player.currentHealthPoints;
            Player_dmg.Content = " Dmg: " + GameController.Player.baseDamage;
            Npc_hp.Content = " HP: " + GameController.Enemy.currentHealthPoints;
            Npc_dmg.Content = " Dmg: " + GameController.Enemy.baseDamage;

            if(GameController.Player.currentHealthPoints<=0 || GameController.Enemy.currentHealthPoints <= 0)
            {
                this.NavigationService.Navigate(new Page2());
            }






        }

        private void Button_SpecialAttack_Click(object sender, RoutedEventArgs e)
        {
            String attackType;

            if (GameController.Player.CharacterName.Equals("Warrior"))
            {
                attackType = "Berserk";
                GameController.Fight(attackType);
            }
            if (GameController.Player.CharacterName.Equals("Mage"))
            {
                attackType = "Fireball";
                GameController.Fight(attackType);
            }

            if (GameController.Player.CharacterName.Equals("Thief"))
            {
                attackType = "Backstab";
                GameController.Fight(attackType);
            }

            Lbl_CharacterName.Content = "Player: " + GameController.Player.CharacterName;
            Player_hp.Content = " HP: " + GameController.Player.currentHealthPoints;
            Player_dmg.Content = " Dmg: " + GameController.Player.baseDamage;
            
            Npc_hp.Content = " HP: " + GameController.Enemy.currentHealthPoints;
            Npc_dmg.Content = " Dmg: " + GameController.Enemy.baseDamage;
            GameController.Enemy.Attack(GameController.Player);
            Lbl_CharacterName.Content = "Player: " + GameController.Player.CharacterName;
            Player_hp.Content = " HP: " + GameController.Player.currentHealthPoints;
            Player_dmg.Content = " Dmg: " + GameController.Player.baseDamage;
            Npc_hp.Content = " HP: " + GameController.Enemy.currentHealthPoints;
            Npc_dmg.Content = " Dmg: " + GameController.Enemy.baseDamage;

            if (GameController.Player.currentHealthPoints <= 0 || GameController.Enemy.currentHealthPoints <= 0)
            {
                this.NavigationService.Navigate(new Page2());
            }

        }
    }
}
