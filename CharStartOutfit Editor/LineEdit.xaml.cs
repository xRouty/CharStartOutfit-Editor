using MahApps.Metro.Controls;
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
using System.Windows.Shapes;

/// This file is part of Mihawk / InsaneHawk.

/// CharStartOutfit Editor is free software: you can redistribute it and/or modify
/// it under the terms of the GNU General Public License as published by
/// the Free Software Foundation, either version 3 of the License, or
/// (at your option) any later version.

/// CharStartOutfit Editor is distributed in the hope that it will be useful,
/// but WITHOUT ANY WARRANTY; without even the implied warranty of
/// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
/// GNU General Public License for more details.

/// You should have received a copy of the GNU General Public License
/// along with CharStartOutfit Editor.  If not, see <http://www.gnu.org/licenses/>.

namespace CharStartOutfit_Editor
{
    /// <summary>
    /// Interaction logic for LineEdit.xaml
    /// </summary>
    public partial class LineEdit : MetroWindow
    {
        int ItemID = 0;
        int ItemDisplayID = 0;
        int EquipementID = 0;

        public LineEdit(int a, int b, int c)
        {
            ItemID = a;
            ItemDisplayID = b;
            EquipementID = c;
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MetroWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ItemID = Convert.ToInt32(ItemID_Box.Text);
            ItemDisplayID = Convert.ToInt32(ItemDisplayID_Box.Text);
            EquipementID = Convert.ToInt32(EquipementID_Box.Text);
        }

        public int returnItemID()
        {
            return ItemID;
        }

        public int returnItemDisplayID()
        {
            return ItemDisplayID;
        }

        public int returnEquipementID()
        {
            return EquipementID;
        }

        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            ItemID_Box.Text = ItemID.ToString();
            ItemDisplayID_Box.Text = ItemDisplayID.ToString();
            EquipementID_Box.Text = EquipementID.ToString();
        }
    }
}
