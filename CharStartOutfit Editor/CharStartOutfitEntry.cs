using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharStartOutfit_Editor
{
    public class CharStartOutfitEntry
    {
        public int UniqueIndex;
        public int RaceID;
        public int ClassID;
        public int SexeID;
        public int Unk0;
        public int[] ItemID = new int[24];
        public int[] ItemDisplayID = new int[24];
        public int[] EquipementID = new int[24];
        public int Unk1;
    }
}
