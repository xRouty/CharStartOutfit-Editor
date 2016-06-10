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
using MahApps.Metro.Controls;
using System.IO;

namespace CharStartOutfit_Editor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : MetroWindow
    {
        public ReadCSV CharStartOutfitCSV = new ReadCSV("CharStartOutfit.dbc.csv");

        int Race = 0;
        int Classe = 0;
        int Sexe = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            // Nothing here..
        }

        #region ComboBox - Séléction de la classe pour chaque race/sexe (Remplissage)

        #region HUMAIN

        #region HOMME

        private void H_h_class_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem Choix = H_h_class.SelectedItem as ComboBoxItem;

            H_h_data.Items.Clear();
            H_h_data.Items.Refresh();

            int Race = 1;
            int Sexe = 0;

            if ((string)Choix.Content == "Guerrier")
            {
                Classe = 1;
            }
            else if ((string)Choix.Content == "Paladin")
            {
                Classe = 2;
            }
            else if ((string)Choix.Content == "Chasseur")
            {
                Classe = 3;
            }
            else if ((string)Choix.Content == "Voleur")
            {
                Classe = 4;
            }
            else if ((string)Choix.Content == "Prêtre")
            {
                Classe = 5;
            }
            else if ((string)Choix.Content == "Chevalier de la mort")
            {
                Classe = 6;
            }
            else if ((string)Choix.Content == "Chaman")
            {
                Classe = 7;
            }
            else if ((string)Choix.Content == "Mage")
            {
                Classe = 8;
            }
            else if ((string)Choix.Content == "Démoniste")
            {
                Classe = 9;
            }
            else if ((string)Choix.Content == "Druide")
            {
                Classe = 10;
            }

            try
            {
                string ItemsID = CharStartOutfitCSV.searchRaceClassSexe_ItemsID(Race, Classe, Sexe);
                string ItemsDisplayID = CharStartOutfitCSV.searchRaceClassSexe_ItemsDisplaysID(Race, Classe, Sexe);
                string EquipementsID = CharStartOutfitCSV.searchRaceClassSexe_EquipementsID(Race, Classe, Sexe);

                string[] result1 = ItemsID.Split(',');
                string[] result2 = ItemsDisplayID.Split(',');
                string[] result3 = EquipementsID.Split(',');

                for (int i = 0; i < 24; i++)
                {
                    var data = new DataGrid
                    {
                        ItemID = Convert.ToInt32(result1[i]),
                        ItemDisplayID = Convert.ToInt32(result2[i]),
                        EquipementID = Convert.ToInt32(result3[i])
                    };

                    H_h_data.Items.Add(data);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Impossible de trouver cette classe pour la race cible.");
            }
        }

        #endregion

        #region FEMME

        private void H_f_class_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem Choix = H_f_class.SelectedItem as ComboBoxItem;

            H_f_data.Items.Clear();
            H_f_data.Items.Refresh();

            int Race = 1;
            int Sexe = 1;

            if ((string)Choix.Content == "Guerrier")
            {
                Classe = 1;
            }
            else if ((string)Choix.Content == "Paladin")
            {
                Classe = 2;
            }
            else if ((string)Choix.Content == "Chasseur")
            {
                Classe = 3;
            }
            else if ((string)Choix.Content == "Voleur")
            {
                Classe = 4;
            }
            else if ((string)Choix.Content == "Prêtre")
            {
                Classe = 5;
            }
            else if ((string)Choix.Content == "Chevalier de la mort")
            {
                Classe = 6;
            }
            else if ((string)Choix.Content == "Chaman")
            {
                Classe = 7;
            }
            else if ((string)Choix.Content == "Mage")
            {
                Classe = 8;
            }
            else if ((string)Choix.Content == "Démoniste")
            {
                Classe = 9;
            }
            else if ((string)Choix.Content == "Druide")
            {
                Classe = 10;
            }

            try
            {
                string ItemsID = CharStartOutfitCSV.searchRaceClassSexe_ItemsID(Race, Classe, Sexe);
                string ItemsDisplayID = CharStartOutfitCSV.searchRaceClassSexe_ItemsDisplaysID(Race, Classe, Sexe);
                string EquipementsID = CharStartOutfitCSV.searchRaceClassSexe_EquipementsID(Race, Classe, Sexe);

                string[] result1 = ItemsID.Split(',');
                string[] result2 = ItemsDisplayID.Split(',');
                string[] result3 = EquipementsID.Split(',');

                for (int i = 0; i < 24; i++)
                {
                    var data = new DataGrid
                    {
                        ItemID = Convert.ToInt32(result1[i]),
                        ItemDisplayID = Convert.ToInt32(result2[i]),
                        EquipementID = Convert.ToInt32(result3[i])
                    };

                    H_f_data.Items.Add(data);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Impossible de trouver cette classe pour la race cible.");
            }
        }

        #endregion

        #endregion

        #region NAIN

        #region HOMME

        private void N_h_class_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem Choix = N_h_class.SelectedItem as ComboBoxItem;

            N_h_data.Items.Clear();
            N_h_data.Items.Refresh();

            int Race = 2;
            int Sexe = 0;

            if ((string)Choix.Content == "Guerrier")
            {
                Classe = 1;
            }
            else if ((string)Choix.Content == "Paladin")
            {
                Classe = 2;
            }
            else if ((string)Choix.Content == "Chasseur")
            {
                Classe = 3;
            }
            else if ((string)Choix.Content == "Voleur")
            {
                Classe = 4;
            }
            else if ((string)Choix.Content == "Prêtre")
            {
                Classe = 5;
            }
            else if ((string)Choix.Content == "Chevalier de la mort")
            {
                Classe = 6;
            }
            else if ((string)Choix.Content == "Chaman")
            {
                Classe = 7;
            }
            else if ((string)Choix.Content == "Mage")
            {
                Classe = 8;
            }
            else if ((string)Choix.Content == "Démoniste")
            {
                Classe = 9;
            }
            else if ((string)Choix.Content == "Druide")
            {
                Classe = 10;
            }

            try
            {
                string ItemsID = CharStartOutfitCSV.searchRaceClassSexe_ItemsID(Race, Classe, Sexe);
                string ItemsDisplayID = CharStartOutfitCSV.searchRaceClassSexe_ItemsDisplaysID(Race, Classe, Sexe);
                string EquipementsID = CharStartOutfitCSV.searchRaceClassSexe_EquipementsID(Race, Classe, Sexe);

                string[] result1 = ItemsID.Split(',');
                string[] result2 = ItemsDisplayID.Split(',');
                string[] result3 = EquipementsID.Split(',');

                for (int i = 0; i < 24; i++)
                {
                    var data = new DataGrid
                    {
                        ItemID = Convert.ToInt32(result1[i]),
                        ItemDisplayID = Convert.ToInt32(result2[i]),
                        EquipementID = Convert.ToInt32(result3[i])
                    };

                    N_h_data.Items.Add(data);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Impossible de trouver cette classe pour la race cible.");
            }
        }

        #endregion

        #region FEMME

        private void N_f_class_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem Choix = N_f_class.SelectedItem as ComboBoxItem;

            N_f_data.Items.Clear();
            N_f_data.Items.Refresh();

            int Race = 2;
            int Sexe = 1;

            if ((string)Choix.Content == "Guerrier")
            {
                Classe = 1;
            }
            else if ((string)Choix.Content == "Paladin")
            {
                Classe = 2;
            }
            else if ((string)Choix.Content == "Chasseur")
            {
                Classe = 3;
            }
            else if ((string)Choix.Content == "Voleur")
            {
                Classe = 4;
            }
            else if ((string)Choix.Content == "Prêtre")
            {
                Classe = 5;
            }
            else if ((string)Choix.Content == "Chevalier de la mort")
            {
                Classe = 6;
            }
            else if ((string)Choix.Content == "Chaman")
            {
                Classe = 7;
            }
            else if ((string)Choix.Content == "Mage")
            {
                Classe = 8;
            }
            else if ((string)Choix.Content == "Démoniste")
            {
                Classe = 9;
            }
            else if ((string)Choix.Content == "Druide")
            {
                Classe = 10;
            }

            try
            {
                string ItemsID = CharStartOutfitCSV.searchRaceClassSexe_ItemsID(Race, Classe, Sexe);
                string ItemsDisplayID = CharStartOutfitCSV.searchRaceClassSexe_ItemsDisplaysID(Race, Classe, Sexe);
                string EquipementsID = CharStartOutfitCSV.searchRaceClassSexe_EquipementsID(Race, Classe, Sexe);

                string[] result1 = ItemsID.Split(',');
                string[] result2 = ItemsDisplayID.Split(',');
                string[] result3 = EquipementsID.Split(',');

                for (int i = 0; i < 24; i++)
                {
                    var data = new DataGrid
                    {
                        ItemID = Convert.ToInt32(result1[i]),
                        ItemDisplayID = Convert.ToInt32(result2[i]),
                        EquipementID = Convert.ToInt32(result3[i])
                    };

                    N_f_data.Items.Add(data);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Impossible de trouver cette classe pour la race cible.");
            }
        }

        #endregion

        #endregion

        #region ELFE DE LA NUIT

        #region HOMME

        private void EN_h_class_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem Choix = EN_h_class.SelectedItem as ComboBoxItem;

            EN_h_data.Items.Clear();
            EN_h_data.Items.Refresh();

            int Race = 3;
            int Sexe = 0;

            if ((string)Choix.Content == "Guerrier")
            {
                Classe = 1;
            }
            else if ((string)Choix.Content == "Paladin")
            {
                Classe = 2;
            }
            else if ((string)Choix.Content == "Chasseur")
            {
                Classe = 3;
            }
            else if ((string)Choix.Content == "Voleur")
            {
                Classe = 4;
            }
            else if ((string)Choix.Content == "Prêtre")
            {
                Classe = 5;
            }
            else if ((string)Choix.Content == "Chevalier de la mort")
            {
                Classe = 6;
            }
            else if ((string)Choix.Content == "Chaman")
            {
                Classe = 7;
            }
            else if ((string)Choix.Content == "Mage")
            {
                Classe = 8;
            }
            else if ((string)Choix.Content == "Démoniste")
            {
                Classe = 9;
            }
            else if ((string)Choix.Content == "Druide")
            {
                Classe = 10;
            }

            try
            {
                string ItemsID = CharStartOutfitCSV.searchRaceClassSexe_ItemsID(Race, Classe, Sexe);
                string ItemsDisplayID = CharStartOutfitCSV.searchRaceClassSexe_ItemsDisplaysID(Race, Classe, Sexe);
                string EquipementsID = CharStartOutfitCSV.searchRaceClassSexe_EquipementsID(Race, Classe, Sexe);

                string[] result1 = ItemsID.Split(',');
                string[] result2 = ItemsDisplayID.Split(',');
                string[] result3 = EquipementsID.Split(',');

                for (int i = 0; i < 24; i++)
                {
                    var data = new DataGrid
                    {
                        ItemID = Convert.ToInt32(result1[i]),
                        ItemDisplayID = Convert.ToInt32(result2[i]),
                        EquipementID = Convert.ToInt32(result3[i])
                    };

                    EN_h_data.Items.Add(data);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Impossible de trouver cette classe pour la race cible.");
            }
        }

        #endregion

        #region FEMME

        private void EN_f_class_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem Choix = EN_f_class.SelectedItem as ComboBoxItem;

            EN_f_data.Items.Clear();
            EN_f_data.Items.Refresh();

            int Race = 3;
            int Sexe = 1;

            if ((string)Choix.Content == "Guerrier")
            {
                Classe = 1;
            }
            else if ((string)Choix.Content == "Paladin")
            {
                Classe = 2;
            }
            else if ((string)Choix.Content == "Chasseur")
            {
                Classe = 3;
            }
            else if ((string)Choix.Content == "Voleur")
            {
                Classe = 4;
            }
            else if ((string)Choix.Content == "Prêtre")
            {
                Classe = 5;
            }
            else if ((string)Choix.Content == "Chevalier de la mort")
            {
                Classe = 6;
            }
            else if ((string)Choix.Content == "Chaman")
            {
                Classe = 7;
            }
            else if ((string)Choix.Content == "Mage")
            {
                Classe = 8;
            }
            else if ((string)Choix.Content == "Démoniste")
            {
                Classe = 9;
            }
            else if ((string)Choix.Content == "Druide")
            {
                Classe = 10;
            }

            try
            {
                string ItemsID = CharStartOutfitCSV.searchRaceClassSexe_ItemsID(Race, Classe, Sexe);
                string ItemsDisplayID = CharStartOutfitCSV.searchRaceClassSexe_ItemsDisplaysID(Race, Classe, Sexe);
                string EquipementsID = CharStartOutfitCSV.searchRaceClassSexe_EquipementsID(Race, Classe, Sexe);

                string[] result1 = ItemsID.Split(',');
                string[] result2 = ItemsDisplayID.Split(',');
                string[] result3 = EquipementsID.Split(',');

                for (int i = 0; i < 24; i++)
                {
                    var data = new DataGrid
                    {
                        ItemID = Convert.ToInt32(result1[i]),
                        ItemDisplayID = Convert.ToInt32(result2[i]),
                        EquipementID = Convert.ToInt32(result3[i])
                    };

                    EN_f_data.Items.Add(data);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Impossible de trouver cette classe pour la race cible.");
            }
        }

        #endregion

        #endregion

        #region MORT-VIVANT

        #region HOMME

        private void M_h_class_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem Choix = M_h_class.SelectedItem as ComboBoxItem;

            M_h_data.Items.Clear();
            M_h_data.Items.Refresh();

            int Race = 4;
            int Sexe = 0;

            if ((string)Choix.Content == "Guerrier")
            {
                Classe = 1;
            }
            else if ((string)Choix.Content == "Paladin")
            {
                Classe = 2;
            }
            else if ((string)Choix.Content == "Chasseur")
            {
                Classe = 3;
            }
            else if ((string)Choix.Content == "Voleur")
            {
                Classe = 4;
            }
            else if ((string)Choix.Content == "Prêtre")
            {
                Classe = 5;
            }
            else if ((string)Choix.Content == "Chevalier de la mort")
            {
                Classe = 6;
            }
            else if ((string)Choix.Content == "Chaman")
            {
                Classe = 7;
            }
            else if ((string)Choix.Content == "Mage")
            {
                Classe = 8;
            }
            else if ((string)Choix.Content == "Démoniste")
            {
                Classe = 9;
            }
            else if ((string)Choix.Content == "Druide")
            {
                Classe = 10;
            }

            try
            {
                string ItemsID = CharStartOutfitCSV.searchRaceClassSexe_ItemsID(Race, Classe, Sexe);
                string ItemsDisplayID = CharStartOutfitCSV.searchRaceClassSexe_ItemsDisplaysID(Race, Classe, Sexe);
                string EquipementsID = CharStartOutfitCSV.searchRaceClassSexe_EquipementsID(Race, Classe, Sexe);

                string[] result1 = ItemsID.Split(',');
                string[] result2 = ItemsDisplayID.Split(',');
                string[] result3 = EquipementsID.Split(',');

                for (int i = 0; i < 24; i++)
                {
                    var data = new DataGrid
                    {
                        ItemID = Convert.ToInt32(result1[i]),
                        ItemDisplayID = Convert.ToInt32(result2[i]),
                        EquipementID = Convert.ToInt32(result3[i])
                    };

                    M_h_data.Items.Add(data);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Impossible de trouver cette classe pour la race cible.");
            }
        }

        #endregion

        #region FEMME

        private void M_f_class_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem Choix = M_f_class.SelectedItem as ComboBoxItem;

            M_f_data.Items.Clear();
            M_f_data.Items.Refresh();

            int Race = 4;
            int Sexe = 1;

            if ((string)Choix.Content == "Guerrier")
            {
                Classe = 1;
            }
            else if ((string)Choix.Content == "Paladin")
            {
                Classe = 2;
            }
            else if ((string)Choix.Content == "Chasseur")
            {
                Classe = 3;
            }
            else if ((string)Choix.Content == "Voleur")
            {
                Classe = 4;
            }
            else if ((string)Choix.Content == "Prêtre")
            {
                Classe = 5;
            }
            else if ((string)Choix.Content == "Chevalier de la mort")
            {
                Classe = 6;
            }
            else if ((string)Choix.Content == "Chaman")
            {
                Classe = 7;
            }
            else if ((string)Choix.Content == "Mage")
            {
                Classe = 8;
            }
            else if ((string)Choix.Content == "Démoniste")
            {
                Classe = 9;
            }
            else if ((string)Choix.Content == "Druide")
            {
                Classe = 10;
            }

            try
            {
                string ItemsID = CharStartOutfitCSV.searchRaceClassSexe_ItemsID(Race, Classe, Sexe);
                string ItemsDisplayID = CharStartOutfitCSV.searchRaceClassSexe_ItemsDisplaysID(Race, Classe, Sexe);
                string EquipementsID = CharStartOutfitCSV.searchRaceClassSexe_EquipementsID(Race, Classe, Sexe);

                string[] result1 = ItemsID.Split(',');
                string[] result2 = ItemsDisplayID.Split(',');
                string[] result3 = EquipementsID.Split(',');

                for (int i = 0; i < 24; i++)
                {
                    var data = new DataGrid
                    {
                        ItemID = Convert.ToInt32(result1[i]),
                        ItemDisplayID = Convert.ToInt32(result2[i]),
                        EquipementID = Convert.ToInt32(result3[i])
                    };

                    M_f_data.Items.Add(data);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Impossible de trouver cette classe pour la race cible.");
            }
        }

        #endregion

        #endregion

        #region TAUREN

        #region HOMME

        private void TA_h_class_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem Choix = TA_h_class.SelectedItem as ComboBoxItem;

            TA_h_data.Items.Clear();
            TA_h_data.Items.Refresh();

            int Race = 5;
            int Sexe = 0;

            if ((string)Choix.Content == "Guerrier")
            {
                Classe = 1;
            }
            else if ((string)Choix.Content == "Paladin")
            {
                Classe = 2;
            }
            else if ((string)Choix.Content == "Chasseur")
            {
                Classe = 3;
            }
            else if ((string)Choix.Content == "Voleur")
            {
                Classe = 4;
            }
            else if ((string)Choix.Content == "Prêtre")
            {
                Classe = 5;
            }
            else if ((string)Choix.Content == "Chevalier de la mort")
            {
                Classe = 6;
            }
            else if ((string)Choix.Content == "Chaman")
            {
                Classe = 7;
            }
            else if ((string)Choix.Content == "Mage")
            {
                Classe = 8;
            }
            else if ((string)Choix.Content == "Démoniste")
            {
                Classe = 9;
            }
            else if ((string)Choix.Content == "Druide")
            {
                Classe = 10;
            }

            try
            {
                string ItemsID = CharStartOutfitCSV.searchRaceClassSexe_ItemsID(Race, Classe, Sexe);
                string ItemsDisplayID = CharStartOutfitCSV.searchRaceClassSexe_ItemsDisplaysID(Race, Classe, Sexe);
                string EquipementsID = CharStartOutfitCSV.searchRaceClassSexe_EquipementsID(Race, Classe, Sexe);

                string[] result1 = ItemsID.Split(',');
                string[] result2 = ItemsDisplayID.Split(',');
                string[] result3 = EquipementsID.Split(',');

                for (int i = 0; i < 24; i++)
                {
                    var data = new DataGrid
                    {
                        ItemID = Convert.ToInt32(result1[i]),
                        ItemDisplayID = Convert.ToInt32(result2[i]),
                        EquipementID = Convert.ToInt32(result3[i])
                    };

                    TA_h_data.Items.Add(data);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Impossible de trouver cette classe pour la race cible.");
            }
        }

        #endregion

        #region FEMME

        private void TA_f_class_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem Choix = TA_f_class.SelectedItem as ComboBoxItem;

            TA_f_data.Items.Clear();
            TA_f_data.Items.Refresh();

            int Race = 5;
            int Sexe = 1;

            if ((string)Choix.Content == "Guerrier")
            {
                Classe = 1;
            }
            else if ((string)Choix.Content == "Paladin")
            {
                Classe = 2;
            }
            else if ((string)Choix.Content == "Chasseur")
            {
                Classe = 3;
            }
            else if ((string)Choix.Content == "Voleur")
            {
                Classe = 4;
            }
            else if ((string)Choix.Content == "Prêtre")
            {
                Classe = 5;
            }
            else if ((string)Choix.Content == "Chevalier de la mort")
            {
                Classe = 6;
            }
            else if ((string)Choix.Content == "Chaman")
            {
                Classe = 7;
            }
            else if ((string)Choix.Content == "Mage")
            {
                Classe = 8;
            }
            else if ((string)Choix.Content == "Démoniste")
            {
                Classe = 9;
            }
            else if ((string)Choix.Content == "Druide")
            {
                Classe = 10;
            }

            try
            {
                string ItemsID = CharStartOutfitCSV.searchRaceClassSexe_ItemsID(Race, Classe, Sexe);
                string ItemsDisplayID = CharStartOutfitCSV.searchRaceClassSexe_ItemsDisplaysID(Race, Classe, Sexe);
                string EquipementsID = CharStartOutfitCSV.searchRaceClassSexe_EquipementsID(Race, Classe, Sexe);

                string[] result1 = ItemsID.Split(',');
                string[] result2 = ItemsDisplayID.Split(',');
                string[] result3 = EquipementsID.Split(',');

                for (int i = 0; i < 24; i++)
                {
                    var data = new DataGrid
                    {
                        ItemID = Convert.ToInt32(result1[i]),
                        ItemDisplayID = Convert.ToInt32(result2[i]),
                        EquipementID = Convert.ToInt32(result3[i])
                    };

                    TA_f_data.Items.Add(data);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Impossible de trouver cette classe pour la race cible.");
            }
        }

        #endregion

        #endregion

        #region GNOME

        #region HOMME

        private void G_h_class_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem Choix = G_h_class.SelectedItem as ComboBoxItem;

            G_h_data.Items.Clear();
            G_h_data.Items.Refresh();

            int Race = 6;
            int Sexe = 0;

            if ((string)Choix.Content == "Guerrier")
            {
                Classe = 1;
            }
            else if ((string)Choix.Content == "Paladin")
            {
                Classe = 2;
            }
            else if ((string)Choix.Content == "Chasseur")
            {
                Classe = 3;
            }
            else if ((string)Choix.Content == "Voleur")
            {
                Classe = 4;
            }
            else if ((string)Choix.Content == "Prêtre")
            {
                Classe = 5;
            }
            else if ((string)Choix.Content == "Chevalier de la mort")
            {
                Classe = 6;
            }
            else if ((string)Choix.Content == "Chaman")
            {
                Classe = 7;
            }
            else if ((string)Choix.Content == "Mage")
            {
                Classe = 8;
            }
            else if ((string)Choix.Content == "Démoniste")
            {
                Classe = 9;
            }
            else if ((string)Choix.Content == "Druide")
            {
                Classe = 10;
            }

            try
            {
                string ItemsID = CharStartOutfitCSV.searchRaceClassSexe_ItemsID(Race, Classe, Sexe);
                string ItemsDisplayID = CharStartOutfitCSV.searchRaceClassSexe_ItemsDisplaysID(Race, Classe, Sexe);
                string EquipementsID = CharStartOutfitCSV.searchRaceClassSexe_EquipementsID(Race, Classe, Sexe);

                string[] result1 = ItemsID.Split(',');
                string[] result2 = ItemsDisplayID.Split(',');
                string[] result3 = EquipementsID.Split(',');

                for (int i = 0; i < 24; i++)
                {
                    var data = new DataGrid
                    {
                        ItemID = Convert.ToInt32(result1[i]),
                        ItemDisplayID = Convert.ToInt32(result2[i]),
                        EquipementID = Convert.ToInt32(result3[i])
                    };

                    G_h_data.Items.Add(data);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Impossible de trouver cette classe pour la race cible.");
            }
        }

        #endregion

        #region FEMME

        private void G_f_class_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem Choix = G_f_class.SelectedItem as ComboBoxItem;

            G_f_data.Items.Clear();
            G_f_data.Items.Refresh();

            int Race = 6;
            int Sexe = 1;

            if ((string)Choix.Content == "Guerrier")
            {
                Classe = 1;
            }
            else if ((string)Choix.Content == "Paladin")
            {
                Classe = 2;
            }
            else if ((string)Choix.Content == "Chasseur")
            {
                Classe = 3;
            }
            else if ((string)Choix.Content == "Voleur")
            {
                Classe = 4;
            }
            else if ((string)Choix.Content == "Prêtre")
            {
                Classe = 5;
            }
            else if ((string)Choix.Content == "Chevalier de la mort")
            {
                Classe = 6;
            }
            else if ((string)Choix.Content == "Chaman")
            {
                Classe = 7;
            }
            else if ((string)Choix.Content == "Mage")
            {
                Classe = 8;
            }
            else if ((string)Choix.Content == "Démoniste")
            {
                Classe = 9;
            }
            else if ((string)Choix.Content == "Druide")
            {
                Classe = 10;
            }

            try
            {
                string ItemsID = CharStartOutfitCSV.searchRaceClassSexe_ItemsID(Race, Classe, Sexe);
                string ItemsDisplayID = CharStartOutfitCSV.searchRaceClassSexe_ItemsDisplaysID(Race, Classe, Sexe);
                string EquipementsID = CharStartOutfitCSV.searchRaceClassSexe_EquipementsID(Race, Classe, Sexe);

                string[] result1 = ItemsID.Split(',');
                string[] result2 = ItemsDisplayID.Split(',');
                string[] result3 = EquipementsID.Split(',');

                for (int i = 0; i < 24; i++)
                {
                    var data = new DataGrid
                    {
                        ItemID = Convert.ToInt32(result1[i]),
                        ItemDisplayID = Convert.ToInt32(result2[i]),
                        EquipementID = Convert.ToInt32(result3[i])
                    };

                    G_f_data.Items.Add(data);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Impossible de trouver cette classe pour la race cible.");
            }
        }

        #endregion

        #endregion

        #region TROLL

        #region HOMME

        private void TR_h_class_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem Choix = TR_h_class.SelectedItem as ComboBoxItem;

            TR_h_data.Items.Clear();
            TR_h_data.Items.Refresh();

            int Race = 7;
            int Sexe = 0;

            if ((string)Choix.Content == "Guerrier")
            {
                Classe = 1;
            }
            else if ((string)Choix.Content == "Paladin")
            {
                Classe = 2;
            }
            else if ((string)Choix.Content == "Chasseur")
            {
                Classe = 3;
            }
            else if ((string)Choix.Content == "Voleur")
            {
                Classe = 4;
            }
            else if ((string)Choix.Content == "Prêtre")
            {
                Classe = 5;
            }
            else if ((string)Choix.Content == "Chevalier de la mort")
            {
                Classe = 6;
            }
            else if ((string)Choix.Content == "Chaman")
            {
                Classe = 7;
            }
            else if ((string)Choix.Content == "Mage")
            {
                Classe = 8;
            }
            else if ((string)Choix.Content == "Démoniste")
            {
                Classe = 9;
            }
            else if ((string)Choix.Content == "Druide")
            {
                Classe = 10;
            }

            try
            {
                string ItemsID = CharStartOutfitCSV.searchRaceClassSexe_ItemsID(Race, Classe, Sexe);
                string ItemsDisplayID = CharStartOutfitCSV.searchRaceClassSexe_ItemsDisplaysID(Race, Classe, Sexe);
                string EquipementsID = CharStartOutfitCSV.searchRaceClassSexe_EquipementsID(Race, Classe, Sexe);

                string[] result1 = ItemsID.Split(',');
                string[] result2 = ItemsDisplayID.Split(',');
                string[] result3 = EquipementsID.Split(',');

                for (int i = 0; i < 24; i++)
                {
                    var data = new DataGrid
                    {
                        ItemID = Convert.ToInt32(result1[i]),
                        ItemDisplayID = Convert.ToInt32(result2[i]),
                        EquipementID = Convert.ToInt32(result3[i])
                    };

                    TR_h_data.Items.Add(data);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Impossible de trouver cette classe pour la race cible.");
            }
        }

        #endregion

        #region FEMME

        private void TR_f_class_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem Choix = TR_f_class.SelectedItem as ComboBoxItem;

            TR_f_data.Items.Clear();
            TR_f_data.Items.Refresh();

            int Race = 7;
            int Sexe = 1;

            if ((string)Choix.Content == "Guerrier")
            {
                Classe = 1;
            }
            else if ((string)Choix.Content == "Paladin")
            {
                Classe = 2;
            }
            else if ((string)Choix.Content == "Chasseur")
            {
                Classe = 3;
            }
            else if ((string)Choix.Content == "Voleur")
            {
                Classe = 4;
            }
            else if ((string)Choix.Content == "Prêtre")
            {
                Classe = 5;
            }
            else if ((string)Choix.Content == "Chevalier de la mort")
            {
                Classe = 6;
            }
            else if ((string)Choix.Content == "Chaman")
            {
                Classe = 7;
            }
            else if ((string)Choix.Content == "Mage")
            {
                Classe = 8;
            }
            else if ((string)Choix.Content == "Démoniste")
            {
                Classe = 9;
            }
            else if ((string)Choix.Content == "Druide")
            {
                Classe = 10;
            }

            try
            {
                string ItemsID = CharStartOutfitCSV.searchRaceClassSexe_ItemsID(Race, Classe, Sexe);
                string ItemsDisplayID = CharStartOutfitCSV.searchRaceClassSexe_ItemsDisplaysID(Race, Classe, Sexe);
                string EquipementsID = CharStartOutfitCSV.searchRaceClassSexe_EquipementsID(Race, Classe, Sexe);

                string[] result1 = ItemsID.Split(',');
                string[] result2 = ItemsDisplayID.Split(',');
                string[] result3 = EquipementsID.Split(',');

                for (int i = 0; i < 24; i++)
                {
                    var data = new DataGrid
                    {
                        ItemID = Convert.ToInt32(result1[i]),
                        ItemDisplayID = Convert.ToInt32(result2[i]),
                        EquipementID = Convert.ToInt32(result3[i])
                    };

                    TR_f_data.Items.Add(data);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Impossible de trouver cette classe pour la race cible.");
            }
        }

        #endregion

        #endregion

        #region ELFE DE SANG

        #region HOMME

        private void ES_h_class_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem Choix = ES_h_class.SelectedItem as ComboBoxItem;

            ES_h_data.Items.Clear();
            ES_h_data.Items.Refresh();

            int Race = 8;
            int Sexe = 0;

            if ((string)Choix.Content == "Guerrier")
            {
                Classe = 1;
            }
            else if ((string)Choix.Content == "Paladin")
            {
                Classe = 2;
            }
            else if ((string)Choix.Content == "Chasseur")
            {
                Classe = 3;
            }
            else if ((string)Choix.Content == "Voleur")
            {
                Classe = 4;
            }
            else if ((string)Choix.Content == "Prêtre")
            {
                Classe = 5;
            }
            else if ((string)Choix.Content == "Chevalier de la mort")
            {
                Classe = 6;
            }
            else if ((string)Choix.Content == "Chaman")
            {
                Classe = 7;
            }
            else if ((string)Choix.Content == "Mage")
            {
                Classe = 8;
            }
            else if ((string)Choix.Content == "Démoniste")
            {
                Classe = 9;
            }
            else if ((string)Choix.Content == "Druide")
            {
                Classe = 10;
            }

            try
            {
                string ItemsID = CharStartOutfitCSV.searchRaceClassSexe_ItemsID(Race, Classe, Sexe);
                string ItemsDisplayID = CharStartOutfitCSV.searchRaceClassSexe_ItemsDisplaysID(Race, Classe, Sexe);
                string EquipementsID = CharStartOutfitCSV.searchRaceClassSexe_EquipementsID(Race, Classe, Sexe);

                string[] result1 = ItemsID.Split(',');
                string[] result2 = ItemsDisplayID.Split(',');
                string[] result3 = EquipementsID.Split(',');

                for (int i = 0; i < 24; i++)
                {
                    var data = new DataGrid
                    {
                        ItemID = Convert.ToInt32(result1[i]),
                        ItemDisplayID = Convert.ToInt32(result2[i]),
                        EquipementID = Convert.ToInt32(result3[i])
                    };

                    ES_h_data.Items.Add(data);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Impossible de trouver cette classe pour la race cible.");
            }
        }

        #endregion

        #region FEMME

        private void ES_f_class_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem Choix = ES_f_class.SelectedItem as ComboBoxItem;

            ES_f_data.Items.Clear();
            ES_f_data.Items.Refresh();

            int Race = 8;
            int Sexe = 1;

            if ((string)Choix.Content == "Guerrier")
            {
                Classe = 1;
            }
            else if ((string)Choix.Content == "Paladin")
            {
                Classe = 2;
            }
            else if ((string)Choix.Content == "Chasseur")
            {
                Classe = 3;
            }
            else if ((string)Choix.Content == "Voleur")
            {
                Classe = 4;
            }
            else if ((string)Choix.Content == "Prêtre")
            {
                Classe = 5;
            }
            else if ((string)Choix.Content == "Chevalier de la mort")
            {
                Classe = 6;
            }
            else if ((string)Choix.Content == "Chaman")
            {
                Classe = 7;
            }
            else if ((string)Choix.Content == "Mage")
            {
                Classe = 8;
            }
            else if ((string)Choix.Content == "Démoniste")
            {
                Classe = 9;
            }
            else if ((string)Choix.Content == "Druide")
            {
                Classe = 10;
            }

            try
            {
                string ItemsID = CharStartOutfitCSV.searchRaceClassSexe_ItemsID(Race, Classe, Sexe);
                string ItemsDisplayID = CharStartOutfitCSV.searchRaceClassSexe_ItemsDisplaysID(Race, Classe, Sexe);
                string EquipementsID = CharStartOutfitCSV.searchRaceClassSexe_EquipementsID(Race, Classe, Sexe);

                string[] result1 = ItemsID.Split(',');
                string[] result2 = ItemsDisplayID.Split(',');
                string[] result3 = EquipementsID.Split(',');

                for (int i = 0; i < 24; i++)
                {
                    var data = new DataGrid
                    {
                        ItemID = Convert.ToInt32(result1[i]),
                        ItemDisplayID = Convert.ToInt32(result2[i]),
                        EquipementID = Convert.ToInt32(result3[i])
                    };

                    ES_f_data.Items.Add(data);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Impossible de trouver cette classe pour la race cible.");
            }
        }

        #endregion

        #endregion

        #region DRAENEI

        #region HOMME

        private void D_h_class_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem Choix = D_h_class.SelectedItem as ComboBoxItem;

            D_h_data.Items.Clear();
            D_h_data.Items.Refresh();

            int Race = 10;
            int Sexe = 0;

            if ((string)Choix.Content == "Guerrier")
            {
                Classe = 1;
            }
            else if ((string)Choix.Content == "Paladin")
            {
                Classe = 2;
            }
            else if ((string)Choix.Content == "Chasseur")
            {
                Classe = 3;
            }
            else if ((string)Choix.Content == "Voleur")
            {
                Classe = 4;
            }
            else if ((string)Choix.Content == "Prêtre")
            {
                Classe = 5;
            }
            else if ((string)Choix.Content == "Chevalier de la mort")
            {
                Classe = 6;
            }
            else if ((string)Choix.Content == "Chaman")
            {
                Classe = 7;
            }
            else if ((string)Choix.Content == "Mage")
            {
                Classe = 8;
            }
            else if ((string)Choix.Content == "Démoniste")
            {
                Classe = 9;
            }
            else if ((string)Choix.Content == "Druide")
            {
                Classe = 10;
            }

            try
            {
                string ItemsID = CharStartOutfitCSV.searchRaceClassSexe_ItemsID(Race, Classe, Sexe);
                string ItemsDisplayID = CharStartOutfitCSV.searchRaceClassSexe_ItemsDisplaysID(Race, Classe, Sexe);
                string EquipementsID = CharStartOutfitCSV.searchRaceClassSexe_EquipementsID(Race, Classe, Sexe);

                string[] result1 = ItemsID.Split(',');
                string[] result2 = ItemsDisplayID.Split(',');
                string[] result3 = EquipementsID.Split(',');

                for (int i = 0; i < 24; i++)
                {
                    var data = new DataGrid
                    {
                        ItemID = Convert.ToInt32(result1[i]),
                        ItemDisplayID = Convert.ToInt32(result2[i]),
                        EquipementID = Convert.ToInt32(result3[i])
                    };

                    D_h_data.Items.Add(data);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Impossible de trouver cette classe pour la race cible.");
            }
        }

        #endregion

        #region FEMME

        private void D_f_class_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem Choix = D_f_class.SelectedItem as ComboBoxItem;

            D_f_data.Items.Clear();
            D_f_data.Items.Refresh();

            int Race = 10;
            int Sexe = 1;

            if ((string)Choix.Content == "Guerrier")
            {
                Classe = 1;
            }
            else if ((string)Choix.Content == "Paladin")
            {
                Classe = 2;
            }
            else if ((string)Choix.Content == "Chasseur")
            {
                Classe = 3;
            }
            else if ((string)Choix.Content == "Voleur")
            {
                Classe = 4;
            }
            else if ((string)Choix.Content == "Prêtre")
            {
                Classe = 5;
            }
            else if ((string)Choix.Content == "Chevalier de la mort")
            {
                Classe = 6;
            }
            else if ((string)Choix.Content == "Chaman")
            {
                Classe = 7;
            }
            else if ((string)Choix.Content == "Mage")
            {
                Classe = 8;
            }
            else if ((string)Choix.Content == "Démoniste")
            {
                Classe = 9;
            }
            else if ((string)Choix.Content == "Druide")
            {
                Classe = 10;
            }

            try
            {
                string ItemsID = CharStartOutfitCSV.searchRaceClassSexe_ItemsID(Race, Classe, Sexe);
                string ItemsDisplayID = CharStartOutfitCSV.searchRaceClassSexe_ItemsDisplaysID(Race, Classe, Sexe);
                string EquipementsID = CharStartOutfitCSV.searchRaceClassSexe_EquipementsID(Race, Classe, Sexe);

                string[] result1 = ItemsID.Split(',');
                string[] result2 = ItemsDisplayID.Split(',');
                string[] result3 = EquipementsID.Split(',');

                for (int i = 0; i < 24; i++)
                {
                    var data = new DataGrid
                    {
                        ItemID = Convert.ToInt32(result1[i]),
                        ItemDisplayID = Convert.ToInt32(result2[i]),
                        EquipementID = Convert.ToInt32(result3[i])
                    };

                    D_f_data.Items.Add(data);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Impossible de trouver cette classe pour la race cible.");
            }
        }

        #endregion

        #endregion

        #region ORC

        #region HOMME

        private void O_h_class_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem Choix = O_h_class.SelectedItem as ComboBoxItem;

            O_h_data.Items.Clear();
            O_h_data.Items.Refresh();

            int Race = 11;
            int Sexe = 0;

            if ((string)Choix.Content == "Guerrier")
            {
                Classe = 1;
            }
            else if ((string)Choix.Content == "Paladin")
            {
                Classe = 2;
            }
            else if ((string)Choix.Content == "Chasseur")
            {
                Classe = 3;
            }
            else if ((string)Choix.Content == "Voleur")
            {
                Classe = 4;
            }
            else if ((string)Choix.Content == "Prêtre")
            {
                Classe = 5;
            }
            else if ((string)Choix.Content == "Chevalier de la mort")
            {
                Classe = 6;
            }
            else if ((string)Choix.Content == "Chaman")
            {
                Classe = 7;
            }
            else if ((string)Choix.Content == "Mage")
            {
                Classe = 8;
            }
            else if ((string)Choix.Content == "Démoniste")
            {
                Classe = 9;
            }
            else if ((string)Choix.Content == "Druide")
            {
                Classe = 10;
            }

            try
            {
                string ItemsID = CharStartOutfitCSV.searchRaceClassSexe_ItemsID(Race, Classe, Sexe);
                string ItemsDisplayID = CharStartOutfitCSV.searchRaceClassSexe_ItemsDisplaysID(Race, Classe, Sexe);
                string EquipementsID = CharStartOutfitCSV.searchRaceClassSexe_EquipementsID(Race, Classe, Sexe);

                string[] result1 = ItemsID.Split(',');
                string[] result2 = ItemsDisplayID.Split(',');
                string[] result3 = EquipementsID.Split(',');

                for (int i = 0; i < 24; i++)
                {
                    var data = new DataGrid
                    {
                        ItemID = Convert.ToInt32(result1[i]),
                        ItemDisplayID = Convert.ToInt32(result2[i]),
                        EquipementID = Convert.ToInt32(result3[i])
                    };

                    O_h_data.Items.Add(data);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Impossible de trouver cette classe pour la race cible.");
            }
        }

        #endregion

        #region FEMME

        private void O_f_class_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem Choix = O_f_class.SelectedItem as ComboBoxItem;

            O_f_data.Items.Clear();
            O_f_data.Items.Refresh();

            int Race = 11;
            int Sexe = 1;

            if ((string)Choix.Content == "Guerrier")
            {
                Classe = 1;
            }
            else if ((string)Choix.Content == "Paladin")
            {
                Classe = 2;
            }
            else if ((string)Choix.Content == "Chasseur")
            {
                Classe = 3;
            }
            else if ((string)Choix.Content == "Voleur")
            {
                Classe = 4;
            }
            else if ((string)Choix.Content == "Prêtre")
            {
                Classe = 5;
            }
            else if ((string)Choix.Content == "Chevalier de la mort")
            {
                Classe = 6;
            }
            else if ((string)Choix.Content == "Chaman")
            {
                Classe = 7;
            }
            else if ((string)Choix.Content == "Mage")
            {
                Classe = 8;
            }
            else if ((string)Choix.Content == "Démoniste")
            {
                Classe = 9;
            }
            else if ((string)Choix.Content == "Druide")
            {
                Classe = 10;
            }

            try
            {
                string ItemsID = CharStartOutfitCSV.searchRaceClassSexe_ItemsID(Race, Classe, Sexe);
                string ItemsDisplayID = CharStartOutfitCSV.searchRaceClassSexe_ItemsDisplaysID(Race, Classe, Sexe);
                string EquipementsID = CharStartOutfitCSV.searchRaceClassSexe_EquipementsID(Race, Classe, Sexe);

                string[] result1 = ItemsID.Split(',');
                string[] result2 = ItemsDisplayID.Split(',');
                string[] result3 = EquipementsID.Split(',');

                for (int i = 0; i < 24; i++)
                {
                    var data = new DataGrid
                    {
                        ItemID = Convert.ToInt32(result1[i]),
                        ItemDisplayID = Convert.ToInt32(result2[i]),
                        EquipementID = Convert.ToInt32(result3[i])
                    };

                    O_f_data.Items.Add(data);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Impossible de trouver cette classe pour la race cible.");
            }
        }

        #endregion

        #endregion

        #endregion

        #region Modification des éléments par race/classe/sexe

        #region HUMAIN

        #region HOMME

        private void H_h_data_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            ComboBoxItem Choix = H_h_class.SelectedItem as ComboBoxItem;
            int Index = H_h_data.SelectedIndex;

            int Race = 1;
            int Sexe = 0;

            if (H_h_class.SelectedItem == null)
            {
                MessageBox.Show("Veuillez choisir une classe.");
            }
            else
            {
                if ((string)Choix.Content == "Guerrier")
                {
                    Classe = 1;
                }
                else if ((string)Choix.Content == "Paladin")
                {
                    Classe = 2;
                }
                else if ((string)Choix.Content == "Chasseur")
                {
                    Classe = 3;
                }
                else if ((string)Choix.Content == "Voleur")
                {
                    Classe = 4;
                }
                else if ((string)Choix.Content == "Prêtre")
                {
                    Classe = 5;
                }
                else if ((string)Choix.Content == "Chevalier de la mort")
                {
                    Classe = 6;
                }
                else if ((string)Choix.Content == "Chaman")
                {
                    Classe = 7;
                }
                else if ((string)Choix.Content == "Mage")
                {
                    Classe = 8;
                }
                else if ((string)Choix.Content == "Démoniste")
                {
                    Classe = 9;
                }
                else if ((string)Choix.Content == "Druide")
                {
                    Classe = 10;
                }

                int ItemID = CharStartOutfitCSV.getItemID(Race, Classe, Sexe, Index);
                int DisplayID = CharStartOutfitCSV.getItemDisplayID(Race, Classe, Sexe, Index);
                int EquipementID = CharStartOutfitCSV.getEquipementID(Race, Classe, Sexe, Index);

                MessageBox.Show("ItemID : " + ItemID
                    + "\nItemDisplayID : " + DisplayID
                    + "\nEquipementID : " + EquipementID);
            }
        }

        #endregion

        #region FEMME

        private void H_f_data_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            ComboBoxItem Choix = H_f_class.SelectedItem as ComboBoxItem;
            int Index = H_f_data.SelectedIndex;

            int Race = 1;
            int Sexe = 1;

            if (H_f_class.SelectedItem == null)
            {
                MessageBox.Show("Veuillez choisir une classe.");
            }
            else
            {
                if ((string)Choix.Content == "Guerrier")
                {
                    Classe = 1;
                }
                else if ((string)Choix.Content == "Paladin")
                {
                    Classe = 2;
                }
                else if ((string)Choix.Content == "Chasseur")
                {
                    Classe = 3;
                }
                else if ((string)Choix.Content == "Voleur")
                {
                    Classe = 4;
                }
                else if ((string)Choix.Content == "Prêtre")
                {
                    Classe = 5;
                }
                else if ((string)Choix.Content == "Chevalier de la mort")
                {
                    Classe = 6;
                }
                else if ((string)Choix.Content == "Chaman")
                {
                    Classe = 7;
                }
                else if ((string)Choix.Content == "Mage")
                {
                    Classe = 8;
                }
                else if ((string)Choix.Content == "Démoniste")
                {
                    Classe = 9;
                }
                else if ((string)Choix.Content == "Druide")
                {
                    Classe = 10;
                }

                int ItemID = CharStartOutfitCSV.getItemID(Race, Classe, Sexe, Index);
                int DisplayID = CharStartOutfitCSV.getItemDisplayID(Race, Classe, Sexe, Index);
                int EquipementID = CharStartOutfitCSV.getEquipementID(Race, Classe, Sexe, Index);

                MessageBox.Show("ItemID : " + ItemID
                    + "\nItemDisplayID : " + DisplayID
                    + "\nEquipementID : " + EquipementID);
            }
        }

        #endregion

        #endregion

        #region NAIN

        #region HOMME

        private void N_h_data_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            ComboBoxItem Choix = N_h_class.SelectedItem as ComboBoxItem;
            int Index = N_h_data.SelectedIndex;

            int Race = 2;
            int Sexe = 0;

            if (N_h_class.SelectedItem == null)
            {
                MessageBox.Show("Veuillez choisir une classe.");
            }
            else
            {
                if ((string)Choix.Content == "Guerrier")
                {
                    Classe = 1;
                }
                else if ((string)Choix.Content == "Paladin")
                {
                    Classe = 2;
                }
                else if ((string)Choix.Content == "Chasseur")
                {
                    Classe = 3;
                }
                else if ((string)Choix.Content == "Voleur")
                {
                    Classe = 4;
                }
                else if ((string)Choix.Content == "Prêtre")
                {
                    Classe = 5;
                }
                else if ((string)Choix.Content == "Chevalier de la mort")
                {
                    Classe = 6;
                }
                else if ((string)Choix.Content == "Chaman")
                {
                    Classe = 7;
                }
                else if ((string)Choix.Content == "Mage")
                {
                    Classe = 8;
                }
                else if ((string)Choix.Content == "Démoniste")
                {
                    Classe = 9;
                }
                else if ((string)Choix.Content == "Druide")
                {
                    Classe = 10;
                }

                int ItemID = CharStartOutfitCSV.getItemID(Race, Classe, Sexe, Index);
                int DisplayID = CharStartOutfitCSV.getItemDisplayID(Race, Classe, Sexe, Index);
                int EquipementID = CharStartOutfitCSV.getEquipementID(Race, Classe, Sexe, Index);

                MessageBox.Show("ItemID : " + ItemID
                    + "\nItemDisplayID : " + DisplayID
                    + "\nEquipementID : " + EquipementID);
            }
        }

        #endregion

        #region FEMME

        private void N_f_data_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            ComboBoxItem Choix = N_f_class.SelectedItem as ComboBoxItem;
            int Index = N_f_data.SelectedIndex;

            int Race = 2;
            int Sexe = 1;

            if (N_f_class.SelectedItem == null)
            {
                MessageBox.Show("Veuillez choisir une classe.");
            }
            else
            {
                if ((string)Choix.Content == "Guerrier")
                {
                    Classe = 1;
                }
                else if ((string)Choix.Content == "Paladin")
                {
                    Classe = 2;
                }
                else if ((string)Choix.Content == "Chasseur")
                {
                    Classe = 3;
                }
                else if ((string)Choix.Content == "Voleur")
                {
                    Classe = 4;
                }
                else if ((string)Choix.Content == "Prêtre")
                {
                    Classe = 5;
                }
                else if ((string)Choix.Content == "Chevalier de la mort")
                {
                    Classe = 6;
                }
                else if ((string)Choix.Content == "Chaman")
                {
                    Classe = 7;
                }
                else if ((string)Choix.Content == "Mage")
                {
                    Classe = 8;
                }
                else if ((string)Choix.Content == "Démoniste")
                {
                    Classe = 9;
                }
                else if ((string)Choix.Content == "Druide")
                {
                    Classe = 10;
                }

                int ItemID = CharStartOutfitCSV.getItemID(Race, Classe, Sexe, Index);
                int DisplayID = CharStartOutfitCSV.getItemDisplayID(Race, Classe, Sexe, Index);
                int EquipementID = CharStartOutfitCSV.getEquipementID(Race, Classe, Sexe, Index);

                MessageBox.Show("ItemID : " + ItemID
                    + "\nItemDisplayID : " + DisplayID
                    + "\nEquipementID : " + EquipementID);
            }
        }

        #endregion

        #endregion

        #region ELFE DE LA NUIT

        #region HOMME

        private void EN_h_data_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            ComboBoxItem Choix = EN_h_class.SelectedItem as ComboBoxItem;
            int Index = EN_h_data.SelectedIndex;

            int Race = 3;
            int Sexe = 0;

            if (EN_h_class.SelectedItem == null)
            {
                MessageBox.Show("Veuillez choisir une classe.");
            }
            else
            {
                if ((string)Choix.Content == "Guerrier")
                {
                    Classe = 1;
                }
                else if ((string)Choix.Content == "Paladin")
                {
                    Classe = 2;
                }
                else if ((string)Choix.Content == "Chasseur")
                {
                    Classe = 3;
                }
                else if ((string)Choix.Content == "Voleur")
                {
                    Classe = 4;
                }
                else if ((string)Choix.Content == "Prêtre")
                {
                    Classe = 5;
                }
                else if ((string)Choix.Content == "Chevalier de la mort")
                {
                    Classe = 6;
                }
                else if ((string)Choix.Content == "Chaman")
                {
                    Classe = 7;
                }
                else if ((string)Choix.Content == "Mage")
                {
                    Classe = 8;
                }
                else if ((string)Choix.Content == "Démoniste")
                {
                    Classe = 9;
                }
                else if ((string)Choix.Content == "Druide")
                {
                    Classe = 10;
                }

                int ItemID = CharStartOutfitCSV.getItemID(Race, Classe, Sexe, Index);
                int DisplayID = CharStartOutfitCSV.getItemDisplayID(Race, Classe, Sexe, Index);
                int EquipementID = CharStartOutfitCSV.getEquipementID(Race, Classe, Sexe, Index);

                MessageBox.Show("ItemID : " + ItemID
                    + "\nItemDisplayID : " + DisplayID
                    + "\nEquipementID : " + EquipementID);
            }
        }

        #endregion

        #region FEMME

        private void EN_f_data_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            ComboBoxItem Choix = EN_f_class.SelectedItem as ComboBoxItem;
            int Index = EN_f_data.SelectedIndex;

            int Race = 3;
            int Sexe = 1;

            if (EN_f_class.SelectedItem == null)
            {
                MessageBox.Show("Veuillez choisir une classe.");
            }
            else
            {
                if ((string)Choix.Content == "Guerrier")
                {
                    Classe = 1;
                }
                else if ((string)Choix.Content == "Paladin")
                {
                    Classe = 2;
                }
                else if ((string)Choix.Content == "Chasseur")
                {
                    Classe = 3;
                }
                else if ((string)Choix.Content == "Voleur")
                {
                    Classe = 4;
                }
                else if ((string)Choix.Content == "Prêtre")
                {
                    Classe = 5;
                }
                else if ((string)Choix.Content == "Chevalier de la mort")
                {
                    Classe = 6;
                }
                else if ((string)Choix.Content == "Chaman")
                {
                    Classe = 7;
                }
                else if ((string)Choix.Content == "Mage")
                {
                    Classe = 8;
                }
                else if ((string)Choix.Content == "Démoniste")
                {
                    Classe = 9;
                }
                else if ((string)Choix.Content == "Druide")
                {
                    Classe = 10;
                }

                int ItemID = CharStartOutfitCSV.getItemID(Race, Classe, Sexe, Index);
                int DisplayID = CharStartOutfitCSV.getItemDisplayID(Race, Classe, Sexe, Index);
                int EquipementID = CharStartOutfitCSV.getEquipementID(Race, Classe, Sexe, Index);

                MessageBox.Show("ItemID : " + ItemID
                    + "\nItemDisplayID : " + DisplayID
                    + "\nEquipementID : " + EquipementID);
            }
        }

        #endregion

        #endregion

        #region MORT-VIVANT

        #region HOMME

        private void M_h_data_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            ComboBoxItem Choix = M_h_class.SelectedItem as ComboBoxItem;
            int Index = M_h_data.SelectedIndex;

            int Race = 4;
            int Sexe = 0;

            if (M_h_class.SelectedItem == null)
            {
                MessageBox.Show("Veuillez choisir une classe.");
            }
            else
            {
                if ((string)Choix.Content == "Guerrier")
                {
                    Classe = 1;
                }
                else if ((string)Choix.Content == "Paladin")
                {
                    Classe = 2;
                }
                else if ((string)Choix.Content == "Chasseur")
                {
                    Classe = 3;
                }
                else if ((string)Choix.Content == "Voleur")
                {
                    Classe = 4;
                }
                else if ((string)Choix.Content == "Prêtre")
                {
                    Classe = 5;
                }
                else if ((string)Choix.Content == "Chevalier de la mort")
                {
                    Classe = 6;
                }
                else if ((string)Choix.Content == "Chaman")
                {
                    Classe = 7;
                }
                else if ((string)Choix.Content == "Mage")
                {
                    Classe = 8;
                }
                else if ((string)Choix.Content == "Démoniste")
                {
                    Classe = 9;
                }
                else if ((string)Choix.Content == "Druide")
                {
                    Classe = 10;
                }

                int ItemID = CharStartOutfitCSV.getItemID(Race, Classe, Sexe, Index);
                int DisplayID = CharStartOutfitCSV.getItemDisplayID(Race, Classe, Sexe, Index);
                int EquipementID = CharStartOutfitCSV.getEquipementID(Race, Classe, Sexe, Index);

                MessageBox.Show("ItemID : " + ItemID
                    + "\nItemDisplayID : " + DisplayID
                    + "\nEquipementID : " + EquipementID);
            }
        }

        #endregion

        #region FEMME

        private void M_f_data_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            ComboBoxItem Choix = M_f_class.SelectedItem as ComboBoxItem;
            int Index = M_f_data.SelectedIndex;

            int Race = 4;
            int Sexe = 1;

            if (M_f_class.SelectedItem == null)
            {
                MessageBox.Show("Veuillez choisir une classe.");
            }
            else
            {
                if ((string)Choix.Content == "Guerrier")
                {
                    Classe = 1;
                }
                else if ((string)Choix.Content == "Paladin")
                {
                    Classe = 2;
                }
                else if ((string)Choix.Content == "Chasseur")
                {
                    Classe = 3;
                }
                else if ((string)Choix.Content == "Voleur")
                {
                    Classe = 4;
                }
                else if ((string)Choix.Content == "Prêtre")
                {
                    Classe = 5;
                }
                else if ((string)Choix.Content == "Chevalier de la mort")
                {
                    Classe = 6;
                }
                else if ((string)Choix.Content == "Chaman")
                {
                    Classe = 7;
                }
                else if ((string)Choix.Content == "Mage")
                {
                    Classe = 8;
                }
                else if ((string)Choix.Content == "Démoniste")
                {
                    Classe = 9;
                }
                else if ((string)Choix.Content == "Druide")
                {
                    Classe = 10;
                }

                int ItemID = CharStartOutfitCSV.getItemID(Race, Classe, Sexe, Index);
                int DisplayID = CharStartOutfitCSV.getItemDisplayID(Race, Classe, Sexe, Index);
                int EquipementID = CharStartOutfitCSV.getEquipementID(Race, Classe, Sexe, Index);

                MessageBox.Show("ItemID : " + ItemID
                    + "\nItemDisplayID : " + DisplayID
                    + "\nEquipementID : " + EquipementID);
            }
        }

        #endregion

        #endregion

        #region TAUREN

        #region HOMME

        private void TA_h_data_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            ComboBoxItem Choix = TA_h_class.SelectedItem as ComboBoxItem;
            int Index = TA_h_data.SelectedIndex;

            int Race = 5;
            int Sexe = 0;

            if (TA_h_class.SelectedItem == null)
            {
                MessageBox.Show("Veuillez choisir une classe.");
            }
            else
            {
                if ((string)Choix.Content == "Guerrier")
                {
                    Classe = 1;
                }
                else if ((string)Choix.Content == "Paladin")
                {
                    Classe = 2;
                }
                else if ((string)Choix.Content == "Chasseur")
                {
                    Classe = 3;
                }
                else if ((string)Choix.Content == "Voleur")
                {
                    Classe = 4;
                }
                else if ((string)Choix.Content == "Prêtre")
                {
                    Classe = 5;
                }
                else if ((string)Choix.Content == "Chevalier de la mort")
                {
                    Classe = 6;
                }
                else if ((string)Choix.Content == "Chaman")
                {
                    Classe = 7;
                }
                else if ((string)Choix.Content == "Mage")
                {
                    Classe = 8;
                }
                else if ((string)Choix.Content == "Démoniste")
                {
                    Classe = 9;
                }
                else if ((string)Choix.Content == "Druide")
                {
                    Classe = 10;
                }

                int ItemID = CharStartOutfitCSV.getItemID(Race, Classe, Sexe, Index);
                int DisplayID = CharStartOutfitCSV.getItemDisplayID(Race, Classe, Sexe, Index);
                int EquipementID = CharStartOutfitCSV.getEquipementID(Race, Classe, Sexe, Index);

                MessageBox.Show("ItemID : " + ItemID
                    + "\nItemDisplayID : " + DisplayID
                    + "\nEquipementID : " + EquipementID);
            }
        }

        #endregion

        #region FEMME

        private void TA_f_data_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            ComboBoxItem Choix = TA_f_class.SelectedItem as ComboBoxItem;
            int Index = TA_f_data.SelectedIndex;

            int Race = 5;
            int Sexe = 1;

            if (TA_f_class.SelectedItem == null)
            {
                MessageBox.Show("Veuillez choisir une classe.");
            }
            else
            {
                if ((string)Choix.Content == "Guerrier")
                {
                    Classe = 1;
                }
                else if ((string)Choix.Content == "Paladin")
                {
                    Classe = 2;
                }
                else if ((string)Choix.Content == "Chasseur")
                {
                    Classe = 3;
                }
                else if ((string)Choix.Content == "Voleur")
                {
                    Classe = 4;
                }
                else if ((string)Choix.Content == "Prêtre")
                {
                    Classe = 5;
                }
                else if ((string)Choix.Content == "Chevalier de la mort")
                {
                    Classe = 6;
                }
                else if ((string)Choix.Content == "Chaman")
                {
                    Classe = 7;
                }
                else if ((string)Choix.Content == "Mage")
                {
                    Classe = 8;
                }
                else if ((string)Choix.Content == "Démoniste")
                {
                    Classe = 9;
                }
                else if ((string)Choix.Content == "Druide")
                {
                    Classe = 10;
                }

                int ItemID = CharStartOutfitCSV.getItemID(Race, Classe, Sexe, Index);
                int DisplayID = CharStartOutfitCSV.getItemDisplayID(Race, Classe, Sexe, Index);
                int EquipementID = CharStartOutfitCSV.getEquipementID(Race, Classe, Sexe, Index);

                MessageBox.Show("ItemID : " + ItemID
                    + "\nItemDisplayID : " + DisplayID
                    + "\nEquipementID : " + EquipementID);
            }
        }

        #endregion

        #endregion

        #region GNOME

        #region HOMME

        private void G_h_data_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            ComboBoxItem Choix = G_h_class.SelectedItem as ComboBoxItem;
            int Index = G_h_data.SelectedIndex;

            int Race = 6;
            int Sexe = 0;

            if (G_h_class.SelectedItem == null)
            {
                MessageBox.Show("Veuillez choisir une classe.");
            }
            else
            {
                if ((string)Choix.Content == "Guerrier")
                {
                    Classe = 1;
                }
                else if ((string)Choix.Content == "Paladin")
                {
                    Classe = 2;
                }
                else if ((string)Choix.Content == "Chasseur")
                {
                    Classe = 3;
                }
                else if ((string)Choix.Content == "Voleur")
                {
                    Classe = 4;
                }
                else if ((string)Choix.Content == "Prêtre")
                {
                    Classe = 5;
                }
                else if ((string)Choix.Content == "Chevalier de la mort")
                {
                    Classe = 6;
                }
                else if ((string)Choix.Content == "Chaman")
                {
                    Classe = 7;
                }
                else if ((string)Choix.Content == "Mage")
                {
                    Classe = 8;
                }
                else if ((string)Choix.Content == "Démoniste")
                {
                    Classe = 9;
                }
                else if ((string)Choix.Content == "Druide")
                {
                    Classe = 10;
                }

                int ItemID = CharStartOutfitCSV.getItemID(Race, Classe, Sexe, Index);
                int DisplayID = CharStartOutfitCSV.getItemDisplayID(Race, Classe, Sexe, Index);
                int EquipementID = CharStartOutfitCSV.getEquipementID(Race, Classe, Sexe, Index);

                MessageBox.Show("ItemID : " + ItemID
                    + "\nItemDisplayID : " + DisplayID
                    + "\nEquipementID : " + EquipementID);
            }
        }

        #endregion

        #region FEMME

        private void G_f_data_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            ComboBoxItem Choix = G_f_class.SelectedItem as ComboBoxItem;
            int Index = G_f_data.SelectedIndex;

            int Race = 6;
            int Sexe = 1;

            if (G_f_class.SelectedItem == null)
            {
                MessageBox.Show("Veuillez choisir une classe.");
            }
            else
            {
                if ((string)Choix.Content == "Guerrier")
                {
                    Classe = 1;
                }
                else if ((string)Choix.Content == "Paladin")
                {
                    Classe = 2;
                }
                else if ((string)Choix.Content == "Chasseur")
                {
                    Classe = 3;
                }
                else if ((string)Choix.Content == "Voleur")
                {
                    Classe = 4;
                }
                else if ((string)Choix.Content == "Prêtre")
                {
                    Classe = 5;
                }
                else if ((string)Choix.Content == "Chevalier de la mort")
                {
                    Classe = 6;
                }
                else if ((string)Choix.Content == "Chaman")
                {
                    Classe = 7;
                }
                else if ((string)Choix.Content == "Mage")
                {
                    Classe = 8;
                }
                else if ((string)Choix.Content == "Démoniste")
                {
                    Classe = 9;
                }
                else if ((string)Choix.Content == "Druide")
                {
                    Classe = 10;
                }

                int ItemID = CharStartOutfitCSV.getItemID(Race, Classe, Sexe, Index);
                int DisplayID = CharStartOutfitCSV.getItemDisplayID(Race, Classe, Sexe, Index);
                int EquipementID = CharStartOutfitCSV.getEquipementID(Race, Classe, Sexe, Index);

                MessageBox.Show("ItemID : " + ItemID
                    + "\nItemDisplayID : " + DisplayID
                    + "\nEquipementID : " + EquipementID);
            }
        }

        #endregion

        #endregion

        #region TROLL

        #region HOMME

        private void TR_h_data_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            ComboBoxItem Choix = TR_h_class.SelectedItem as ComboBoxItem;
            int Index = TR_h_data.SelectedIndex;

            int Race = 7;
            int Sexe = 0;

            if (TR_h_class.SelectedItem == null)
            {
                MessageBox.Show("Veuillez choisir une classe.");
            }
            else
            {
                if ((string)Choix.Content == "Guerrier")
                {
                    Classe = 1;
                }
                else if ((string)Choix.Content == "Paladin")
                {
                    Classe = 2;
                }
                else if ((string)Choix.Content == "Chasseur")
                {
                    Classe = 3;
                }
                else if ((string)Choix.Content == "Voleur")
                {
                    Classe = 4;
                }
                else if ((string)Choix.Content == "Prêtre")
                {
                    Classe = 5;
                }
                else if ((string)Choix.Content == "Chevalier de la mort")
                {
                    Classe = 6;
                }
                else if ((string)Choix.Content == "Chaman")
                {
                    Classe = 7;
                }
                else if ((string)Choix.Content == "Mage")
                {
                    Classe = 8;
                }
                else if ((string)Choix.Content == "Démoniste")
                {
                    Classe = 9;
                }
                else if ((string)Choix.Content == "Druide")
                {
                    Classe = 10;
                }

                int ItemID = CharStartOutfitCSV.getItemID(Race, Classe, Sexe, Index);
                int DisplayID = CharStartOutfitCSV.getItemDisplayID(Race, Classe, Sexe, Index);
                int EquipementID = CharStartOutfitCSV.getEquipementID(Race, Classe, Sexe, Index);

                MessageBox.Show("ItemID : " + ItemID
                    + "\nItemDisplayID : " + DisplayID
                    + "\nEquipementID : " + EquipementID);
            }
        }

        #endregion

        #region FEMME

        private void TR_f_data_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            ComboBoxItem Choix = TR_f_class.SelectedItem as ComboBoxItem;
            int Index = TR_f_data.SelectedIndex;

            int Race = 7;
            int Sexe = 1;

            if (TR_f_class.SelectedItem == null)
            {
                MessageBox.Show("Veuillez choisir une classe.");
            }
            else
            {
                if ((string)Choix.Content == "Guerrier")
                {
                    Classe = 1;
                }
                else if ((string)Choix.Content == "Paladin")
                {
                    Classe = 2;
                }
                else if ((string)Choix.Content == "Chasseur")
                {
                    Classe = 3;
                }
                else if ((string)Choix.Content == "Voleur")
                {
                    Classe = 4;
                }
                else if ((string)Choix.Content == "Prêtre")
                {
                    Classe = 5;
                }
                else if ((string)Choix.Content == "Chevalier de la mort")
                {
                    Classe = 6;
                }
                else if ((string)Choix.Content == "Chaman")
                {
                    Classe = 7;
                }
                else if ((string)Choix.Content == "Mage")
                {
                    Classe = 8;
                }
                else if ((string)Choix.Content == "Démoniste")
                {
                    Classe = 9;
                }
                else if ((string)Choix.Content == "Druide")
                {
                    Classe = 10;
                }

                int ItemID = CharStartOutfitCSV.getItemID(Race, Classe, Sexe, Index);
                int DisplayID = CharStartOutfitCSV.getItemDisplayID(Race, Classe, Sexe, Index);
                int EquipementID = CharStartOutfitCSV.getEquipementID(Race, Classe, Sexe, Index);

                MessageBox.Show("ItemID : " + ItemID
                    + "\nItemDisplayID : " + DisplayID
                    + "\nEquipementID : " + EquipementID);
            }
        }

        #endregion

        #endregion

        #region ELFE DE SANG

        #region HOMME

        private void ES_h_data_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            ComboBoxItem Choix = ES_h_class.SelectedItem as ComboBoxItem;
            int Index = ES_h_data.SelectedIndex;

            int Race = 8;
            int Sexe = 0;

            if (ES_h_class.SelectedItem == null)
            {
                MessageBox.Show("Veuillez choisir une classe.");
            }
            else
            {
                if ((string)Choix.Content == "Guerrier")
                {
                    Classe = 1;
                }
                else if ((string)Choix.Content == "Paladin")
                {
                    Classe = 2;
                }
                else if ((string)Choix.Content == "Chasseur")
                {
                    Classe = 3;
                }
                else if ((string)Choix.Content == "Voleur")
                {
                    Classe = 4;
                }
                else if ((string)Choix.Content == "Prêtre")
                {
                    Classe = 5;
                }
                else if ((string)Choix.Content == "Chevalier de la mort")
                {
                    Classe = 6;
                }
                else if ((string)Choix.Content == "Chaman")
                {
                    Classe = 7;
                }
                else if ((string)Choix.Content == "Mage")
                {
                    Classe = 8;
                }
                else if ((string)Choix.Content == "Démoniste")
                {
                    Classe = 9;
                }
                else if ((string)Choix.Content == "Druide")
                {
                    Classe = 10;
                }

                int ItemID = CharStartOutfitCSV.getItemID(Race, Classe, Sexe, Index);
                int DisplayID = CharStartOutfitCSV.getItemDisplayID(Race, Classe, Sexe, Index);
                int EquipementID = CharStartOutfitCSV.getEquipementID(Race, Classe, Sexe, Index);

                MessageBox.Show("ItemID : " + ItemID
                    + "\nItemDisplayID : " + DisplayID
                    + "\nEquipementID : " + EquipementID);
            }
        }

        #endregion

        #region FEMME

        private void ES_f_data_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            ComboBoxItem Choix = ES_f_class.SelectedItem as ComboBoxItem;
            int Index = ES_f_data.SelectedIndex;

            int Race = 8;
            int Sexe = 1;

            if (ES_f_class.SelectedItem == null)
            {
                MessageBox.Show("Veuillez choisir une classe.");
            }
            else
            {
                if ((string)Choix.Content == "Guerrier")
                {
                    Classe = 1;
                }
                else if ((string)Choix.Content == "Paladin")
                {
                    Classe = 2;
                }
                else if ((string)Choix.Content == "Chasseur")
                {
                    Classe = 3;
                }
                else if ((string)Choix.Content == "Voleur")
                {
                    Classe = 4;
                }
                else if ((string)Choix.Content == "Prêtre")
                {
                    Classe = 5;
                }
                else if ((string)Choix.Content == "Chevalier de la mort")
                {
                    Classe = 6;
                }
                else if ((string)Choix.Content == "Chaman")
                {
                    Classe = 7;
                }
                else if ((string)Choix.Content == "Mage")
                {
                    Classe = 8;
                }
                else if ((string)Choix.Content == "Démoniste")
                {
                    Classe = 9;
                }
                else if ((string)Choix.Content == "Druide")
                {
                    Classe = 10;
                }

                int ItemID = CharStartOutfitCSV.getItemID(Race, Classe, Sexe, Index);
                int DisplayID = CharStartOutfitCSV.getItemDisplayID(Race, Classe, Sexe, Index);
                int EquipementID = CharStartOutfitCSV.getEquipementID(Race, Classe, Sexe, Index);

                MessageBox.Show("ItemID : " + ItemID
                    + "\nItemDisplayID : " + DisplayID
                    + "\nEquipementID : " + EquipementID);
            }
        }

        #endregion

        #endregion

        #region DRAENEI

        #region HOMME

        private void D_h_data_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            ComboBoxItem Choix = D_h_class.SelectedItem as ComboBoxItem;
            int Index = D_h_data.SelectedIndex;

            int Race = 10;
            int Sexe = 0;

            if (D_h_class.SelectedItem == null)
            {
                MessageBox.Show("Veuillez choisir une classe.");
            }
            else
            {
                if ((string)Choix.Content == "Guerrier")
                {
                    Classe = 1;
                }
                else if ((string)Choix.Content == "Paladin")
                {
                    Classe = 2;
                }
                else if ((string)Choix.Content == "Chasseur")
                {
                    Classe = 3;
                }
                else if ((string)Choix.Content == "Voleur")
                {
                    Classe = 4;
                }
                else if ((string)Choix.Content == "Prêtre")
                {
                    Classe = 5;
                }
                else if ((string)Choix.Content == "Chevalier de la mort")
                {
                    Classe = 6;
                }
                else if ((string)Choix.Content == "Chaman")
                {
                    Classe = 7;
                }
                else if ((string)Choix.Content == "Mage")
                {
                    Classe = 8;
                }
                else if ((string)Choix.Content == "Démoniste")
                {
                    Classe = 9;
                }
                else if ((string)Choix.Content == "Druide")
                {
                    Classe = 10;
                }

                int ItemID = CharStartOutfitCSV.getItemID(Race, Classe, Sexe, Index);
                int DisplayID = CharStartOutfitCSV.getItemDisplayID(Race, Classe, Sexe, Index);
                int EquipementID = CharStartOutfitCSV.getEquipementID(Race, Classe, Sexe, Index);

                MessageBox.Show("ItemID : " + ItemID
                    + "\nItemDisplayID : " + DisplayID
                    + "\nEquipementID : " + EquipementID);
            }
        }

        #endregion

        #region FEMME

        private void D_f_data_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            ComboBoxItem Choix = D_f_class.SelectedItem as ComboBoxItem;
            int Index = D_f_data.SelectedIndex;

            int Race = 10;
            int Sexe = 1;

            if (D_f_class.SelectedItem == null)
            {
                MessageBox.Show("Veuillez choisir une classe.");
            }
            else
            {
                if ((string)Choix.Content == "Guerrier")
                {
                    Classe = 1;
                }
                else if ((string)Choix.Content == "Paladin")
                {
                    Classe = 2;
                }
                else if ((string)Choix.Content == "Chasseur")
                {
                    Classe = 3;
                }
                else if ((string)Choix.Content == "Voleur")
                {
                    Classe = 4;
                }
                else if ((string)Choix.Content == "Prêtre")
                {
                    Classe = 5;
                }
                else if ((string)Choix.Content == "Chevalier de la mort")
                {
                    Classe = 6;
                }
                else if ((string)Choix.Content == "Chaman")
                {
                    Classe = 7;
                }
                else if ((string)Choix.Content == "Mage")
                {
                    Classe = 8;
                }
                else if ((string)Choix.Content == "Démoniste")
                {
                    Classe = 9;
                }
                else if ((string)Choix.Content == "Druide")
                {
                    Classe = 10;
                }

                int ItemID = CharStartOutfitCSV.getItemID(Race, Classe, Sexe, Index);
                int DisplayID = CharStartOutfitCSV.getItemDisplayID(Race, Classe, Sexe, Index);
                int EquipementID = CharStartOutfitCSV.getEquipementID(Race, Classe, Sexe, Index);

                MessageBox.Show("ItemID : " + ItemID
                    + "\nItemDisplayID : " + DisplayID
                    + "\nEquipementID : " + EquipementID);
            }
        }

        #endregion

        #endregion

        #region ORC

        #region HOMME

        private void O_h_data_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            ComboBoxItem Choix = O_h_class.SelectedItem as ComboBoxItem;
            int Index = O_h_data.SelectedIndex;

            int Race = 11;
            int Sexe = 0;

            if (O_h_class.SelectedItem == null)
            {
                MessageBox.Show("Veuillez choisir une classe.");
            }
            else
            {
                if ((string)Choix.Content == "Guerrier")
                {
                    Classe = 1;
                }
                else if ((string)Choix.Content == "Paladin")
                {
                    Classe = 2;
                }
                else if ((string)Choix.Content == "Chasseur")
                {
                    Classe = 3;
                }
                else if ((string)Choix.Content == "Voleur")
                {
                    Classe = 4;
                }
                else if ((string)Choix.Content == "Prêtre")
                {
                    Classe = 5;
                }
                else if ((string)Choix.Content == "Chevalier de la mort")
                {
                    Classe = 6;
                }
                else if ((string)Choix.Content == "Chaman")
                {
                    Classe = 7;
                }
                else if ((string)Choix.Content == "Mage")
                {
                    Classe = 8;
                }
                else if ((string)Choix.Content == "Démoniste")
                {
                    Classe = 9;
                }
                else if ((string)Choix.Content == "Druide")
                {
                    Classe = 10;
                }

                int ItemID = CharStartOutfitCSV.getItemID(Race, Classe, Sexe, Index);
                int DisplayID = CharStartOutfitCSV.getItemDisplayID(Race, Classe, Sexe, Index);
                int EquipementID = CharStartOutfitCSV.getEquipementID(Race, Classe, Sexe, Index);

                MessageBox.Show("ItemID : " + ItemID
                    + "\nItemDisplayID : " + DisplayID
                    + "\nEquipementID : " + EquipementID);
            }
        }

        #endregion

        #region FEMME

        private void O_f_data_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            ComboBoxItem Choix = O_f_class.SelectedItem as ComboBoxItem;
            int Index = O_f_data.SelectedIndex;

            int Race = 11;
            int Sexe = 1;

            if (O_f_class.SelectedItem == null)
            {
                MessageBox.Show("Veuillez choisir une classe.");
            }
            else
            {
                if ((string)Choix.Content == "Guerrier")
                {
                    Classe = 1;
                }
                else if ((string)Choix.Content == "Paladin")
                {
                    Classe = 2;
                }
                else if ((string)Choix.Content == "Chasseur")
                {
                    Classe = 3;
                }
                else if ((string)Choix.Content == "Voleur")
                {
                    Classe = 4;
                }
                else if ((string)Choix.Content == "Prêtre")
                {
                    Classe = 5;
                }
                else if ((string)Choix.Content == "Chevalier de la mort")
                {
                    Classe = 6;
                }
                else if ((string)Choix.Content == "Chaman")
                {
                    Classe = 7;
                }
                else if ((string)Choix.Content == "Mage")
                {
                    Classe = 8;
                }
                else if ((string)Choix.Content == "Démoniste")
                {
                    Classe = 9;
                }
                else if ((string)Choix.Content == "Druide")
                {
                    Classe = 10;
                }

                int ItemID = CharStartOutfitCSV.getItemID(Race, Classe, Sexe, Index);
                int DisplayID = CharStartOutfitCSV.getItemDisplayID(Race, Classe, Sexe, Index);
                int EquipementID = CharStartOutfitCSV.getEquipementID(Race, Classe, Sexe, Index);

                MessageBox.Show("ItemID : " + ItemID
                    + "\nItemDisplayID : " + DisplayID
                    + "\nEquipementID : " + EquipementID);
            }
        }

        #endregion

        #endregion

        #endregion
    }
}
