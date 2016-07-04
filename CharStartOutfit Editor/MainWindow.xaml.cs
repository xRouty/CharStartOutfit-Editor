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
using MahApps.Metro.Controls.Dialogs;

/// This file is part of Mihawk - WoW-Emu.

/// WE-Editor is free software: you can redistribute it and/or modify
/// it under the terms of the GNU General Public License as published by
/// the Free Software Foundation, either version 3 of the License, or
/// (at your option) any later version.

/// WE-Editor is distributed in the hope that it will be useful,
/// but WITHOUT ANY WARRANTY; without even the implied warranty of
/// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
/// GNU General Public License for more details.

/// You should have received a copy of the GNU General Public License
/// along with WE-Editor.  If not, see <http://www.gnu.org/licenses/>.

namespace CharStartOutfit_Editor
{
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

        #region Refresh du DataGrid

        private void refreshRaceClasseSexe(int Race, int Classe, int Sexe)
        {
            // HUMAIN

            if (Race == 1)
            {
                if (Sexe == 0)
                {
                    H_h_data.Items.Clear();

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

                    H_h_data.Items.Refresh();
                }
                else if (Sexe == 1)
                {
                    H_f_data.Items.Clear();

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

                    H_f_data.Items.Refresh();
                }
            }

            // NAIN

            else if (Race == 2)
            {
                if (Sexe == 0)
                {
                    N_h_data.Items.Clear();

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

                    N_h_data.Items.Refresh();
                }
                else if (Sexe == 1)
                {
                    N_f_data.Items.Clear();

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

                    N_f_data.Items.Refresh();
                }
            }

            // ELFE DE LA NUIT

            else if (Race == 3)
            {
                if (Sexe == 0)
                {
                    EN_h_data.Items.Clear();

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

                    EN_h_data.Items.Refresh();
                }
                else if (Sexe == 1)
                {
                    EN_f_data.Items.Clear();

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

                    EN_f_data.Items.Refresh();
                }
            }

            // MORT-VIVANT

            else if (Race == 4)
            {
                if (Sexe == 0)
                {
                    M_h_data.Items.Clear();

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

                    M_h_data.Items.Refresh();
                }
                else if (Sexe == 1)
                {
                    M_f_data.Items.Clear();

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

                    M_f_data.Items.Refresh();
                }
            }

            // TAUREN

            else if (Race == 5)
            {
                if (Sexe == 0)
                {
                    TA_h_data.Items.Clear();

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

                    TA_h_data.Items.Refresh();
                }
                else if (Sexe == 1)
                {
                    TA_f_data.Items.Clear();

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

                    TA_f_data.Items.Refresh();
                }
            }

            // GNOME

            else if (Race == 6)
            {
                if (Sexe == 0)
                {
                    G_h_data.Items.Clear();

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

                    G_h_data.Items.Refresh();
                }
                else if (Sexe == 1)
                {
                    G_f_data.Items.Clear();

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

                    G_f_data.Items.Refresh();
                }
            }

            // TROLL

            else if (Race == 7)
            {
                if (Sexe == 0)
                {
                    TR_h_data.Items.Clear();

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

                    TR_h_data.Items.Refresh();
                }
                else if (Sexe == 1)
                {
                    TR_f_data.Items.Clear();

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

                    TR_f_data.Items.Refresh();
                }
            }

            // ELFE DE SANG

            else if (Race == 8)
            {
                if (Sexe == 0)
                {
                    ES_h_data.Items.Clear();

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

                    ES_h_data.Items.Refresh();
                }
                else if (Sexe == 1)
                {
                    ES_f_data.Items.Clear();

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

                    ES_f_data.Items.Refresh();
                }
            }
            
            // DRAENEI

            else if (Race == 10)
            {
                if (Sexe == 0)
                {
                    D_h_data.Items.Clear();

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

                    D_h_data.Items.Refresh();
                }
                else if (Sexe == 1)
                {
                    D_f_data.Items.Clear();

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

                    D_f_data.Items.Refresh();
                }
            }

            // ORC

            else if (Race == 11)
            {
                if (Sexe == 0)
                {
                    O_h_data.Items.Clear();

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

                    O_h_data.Items.Refresh();
                }
                else if (Sexe == 1)
                {
                    O_f_data.Items.Clear();

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

                    O_f_data.Items.Refresh();
                }
            }
        }

        #endregion

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

                LineEdit NewForm = new LineEdit(ItemID, DisplayID, EquipementID);
                NewForm.ShowDialog();

                int NewItemID = NewForm.returnItemID();
                int NewItemDisplayID = NewForm.returnItemDisplayID();
                int NewEquipementID = NewForm.returnEquipementID();

                if (ItemID != NewItemID || DisplayID != NewItemDisplayID || EquipementID != NewEquipementID)
                {
                    CharStartOutfitCSV.setItemID(Race, Classe, Sexe, Index, NewItemID);
                    CharStartOutfitCSV.setItemDisplayID(Race, Classe, Sexe, Index, NewItemDisplayID);
                    CharStartOutfitCSV.setEquipementID(Race, Classe, Sexe, Index, NewEquipementID);

                    refreshRaceClasseSexe(Race, Classe, Sexe);
                }
                else
                {
                    // TO COMPLETE HERE
                    MessageBox.Show("ItemID : " + ItemID
                        + "\nItemDisplayID : " + DisplayID
                        + "\nEquipementID : " + EquipementID);
                }
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

        #region Export du CSV

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                exportCSV();
                MessageBox.Show("Sauvegarde effectuée avec succès !");
            }
            catch(Exception)
            {
                MessageBox.Show("Un problème a été rencontré lors de la sauvegarde.");
            }
        }

        private void exportCSV()
        {
            Race = 1;
            Classe = 1;

            using (StreamWriter sw = new StreamWriter(@"CSV/CharStartOutfit_sortie.dbc.csv"))
            {
                sw.WriteLine("long,byte,byte,byte,byte,long,long,long,long,long,long,long,long,long,long,long,long,long,long,long,long,long,long,long,long,long,long,long,long,long,long,long,long,long,long,long,long,long,long,long,long,long,long,long,long,long,long,long,long,long,long,long,long,long,long,long,long,long,long,long,long,long,long,long,long,long,long,long,long,long,long,long,long,long,long,long,long,");

                for (int i = 0; i < CharStartOutfitCSV.Length; i++)
                {
                    // HOMME
                    Sexe = 0;

                    int UniqueID = CharStartOutfitCSV.getUniqueIndex(Race, Classe, Sexe);
                    string ItemsID = CharStartOutfitCSV.searchRaceClassSexe_ItemsID(Race, Classe, Sexe);
                    string ItemsDisplayID = CharStartOutfitCSV.searchRaceClassSexe_ItemsDisplaysID(Race, Classe, Sexe);
                    string EquipementsID = CharStartOutfitCSV.searchRaceClassSexe_EquipementsID(Race, Classe, Sexe);

                    if (ItemsID == null || ItemsID == "") { }
                    else
                        sw.WriteLine(UniqueID + "," + Race + "," + Classe + "," + Sexe + ",0," + ItemsID + ItemsDisplayID + EquipementsID);

                    // FEMME
                    Sexe = 1;

                    UniqueID = CharStartOutfitCSV.getUniqueIndex(Race, Classe, Sexe);
                    ItemsID = CharStartOutfitCSV.searchRaceClassSexe_ItemsID(Race, Classe, Sexe);
                    ItemsDisplayID = CharStartOutfitCSV.searchRaceClassSexe_ItemsDisplaysID(Race, Classe, Sexe);
                    EquipementsID = CharStartOutfitCSV.searchRaceClassSexe_EquipementsID(Race, Classe, Sexe);

                    if (ItemsID == null || ItemsID == "") { }
                    else
                        sw.WriteLine(UniqueID + "," + Race + "," + Classe + "," + Sexe + ",0," + ItemsID + ItemsDisplayID + EquipementsID);

                    Classe += 1;
                    if (Classe > 11)
                    {
                        Classe = 1;
                        Race += 1;
                    }
                }
            }
        }

        #endregion

        // Besoin d'aide ?

        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var mySettings = new MetroDialogSettings()
            {
                AffirmativeButtonText = "Ok",
                AnimateShow = true,
                AnimateHide = true
            };

            var result = await this.ShowMessageAsync("Informations",
                "Créé par : Mihawk (InsaneHawk)\nLicense : GNU\nVersion : 1.2.0.0\n\nUn problème ? Une question ?\nN'hésitez pas à me contacter sur skype : natsume.kun",
                MessageDialogStyle.Affirmative, mySettings);
        }
    }
}
