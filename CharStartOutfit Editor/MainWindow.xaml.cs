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
        int[,,] save = new int[200,200,200];

        private ReadCSV CharStartOutfitCSV = new ReadCSV("CharStartOutfit.dbc.csv");

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i != 23; i++ )
            {
                var data = new DataGrid { ItemID = CharStartOutfitCSV.ItemID[i],
                    ItemDisplayID = CharStartOutfitCSV.ItemDisplayID[i],
                    EquipementID = CharStartOutfitCSV.EquipementID[i]
                };

                H_h_data.Items.Add(data);
                save[i, 0, 0] = data.ItemID;
                save[i, 0, 1] = data.ItemDisplayID;
                save[i, 0, 2] = data.EquipementID;
            }

            for (int i = 24; i != 47; i++) // +1 car il y a un -1 à banaliser
            {
                var data = new DataGrid
                {
                    ItemID = CharStartOutfitCSV.ItemID[i],
                    ItemDisplayID = CharStartOutfitCSV.ItemDisplayID[i],
                    EquipementID = CharStartOutfitCSV.EquipementID[i]
                };

                H_f_data.Items.Add(data);
                save[i-24, 1, 0] = data.ItemID;
                save[i-24, 1, 1] = data.ItemDisplayID;
                save[i-24, 1, 2] = data.EquipementID;
            }
        }

        // Parser CSV, ne pas toucher
        public class ReadCSV
        {
            private List<int> _uniqueID;
            private List<int> _race;
            private List<int> _classe;
            private List<int> _sexe;
            private List<int> _ItemID;
            private List<int> _ItemDisplayID;
            private List<int> _EquipementID;

            public ReadCSV(string _nameCSV)
            {
                reader = new StreamReader(File.OpenRead(@"CSV/" + _nameCSV));
                _uniqueID = new List<int>();
                _race = new List<int>();
                _classe = new List<int>();
                _sexe = new List<int>();
                _ItemID = new List<int>();
                _ItemDisplayID = new List<int>();
                _EquipementID = new List<int>();
                Read();
            }

            public string[] Read()
            {
                while (!reader.EndOfStream)
                {
                    string[] Values = reader.ReadLine().Split(',');
                    UniqueID.Add(Convert.ToInt32(Values[0])); // 1
                    Race.Add(Convert.ToInt32(Values[1])); // 2
                    Classe.Add(Convert.ToInt32(Values[2])); // 3
                    Sexe.Add(Convert.ToInt32(Values[3])); // 4
                    for (int i = 5; i != 29; i++) // 6 à 29
                        ItemID.Add(Convert.ToInt32(Values[i]));
                    for (int i = 29; i != 53; i++) // 30 à 53
                        ItemDisplayID.Add(Convert.ToInt32(Values[i]));
                    for (int i = 53; i != 77; i++) // 54 à 77
                        EquipementID.Add(Convert.ToInt32(Values[i]));
                    Length++;
                }
                return null;
            }

            public List<int> UniqueID
            {
                get { return _uniqueID; }
                set { _uniqueID = value; }
            }

            public List<int> Race
            {
                get { return _race; }
                set { _race = value; }
            }

            public List<int> Classe
            {
                get { return _classe; }
                set { _classe = value; }
            }

            public List<int> Sexe
            {
                get { return _sexe; }
                set { _sexe = value; }
            }

            public List<int> ItemID
            {
                get { return _ItemID; }
                set { _ItemID = value; }
            }

            public List<int> ItemDisplayID
            {
                get { return _ItemDisplayID; }
                set { _ItemDisplayID = value; }
            }

            public List<int> EquipementID
            {
                get { return _EquipementID; }
                set { _EquipementID = value; }
            }

            public int Length { get; set; }

            private StreamReader reader;
        }

        private void H_h_data_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show(H_h_data.SelectedIndex.ToString());
            MessageBox.Show("ItemID : " + save[H_h_data.SelectedIndex, 0, 0]
                + "\nItemDisplayID : " + save[H_h_data.SelectedIndex, 0, 1]
                + "\nEquipementID : " + save[H_h_data.SelectedIndex, 0, 2]);
        }

        private void H_f_data_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show(H_f_data.SelectedIndex.ToString());
            MessageBox.Show("ItemID : " + save[H_f_data.SelectedIndex, 1, 0]
                + "\nItemDisplayID : " + save[H_f_data.SelectedIndex, 1, 1]
                + "\nEquipementID : " + save[H_f_data.SelectedIndex, 1, 2]);
        }
    }
}
