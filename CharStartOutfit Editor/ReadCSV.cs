using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharStartOutfit_Editor
{
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

        public CharStartOutfitEntry[] sauvegarde = new CharStartOutfitEntry[200];

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

        #region get/set de notre sauvegarde

        // GET

        public int getUniqueIndex(int race, int classe, int sexe)
        {
            int valueOfReturn = 0;

            for (int i = 0; i < Length; i++)
            {
                if (sauvegarde[i].RaceID == race && sauvegarde[i].ClassID == classe && sauvegarde[i].SexeID == sexe)
                {
                    valueOfReturn = sauvegarde[i].UniqueIndex;
                }
            }

            return valueOfReturn;
        }

        public int getRaceID(int race, int classe, int sexe)
        {
            int valueOfReturn = 0;

            for (int i = 0; i < Length; i++)
            {
                if (sauvegarde[i].RaceID == race && sauvegarde[i].ClassID == classe && sauvegarde[i].SexeID == sexe)
                {
                    valueOfReturn = sauvegarde[i].RaceID;
                }
            }

            return valueOfReturn;
        }

        public int getClasseID(int race, int classe, int sexe)
        {
            int valueOfReturn = 0;

            for (int i = 0; i < Length; i++)
            {
                if (sauvegarde[i].RaceID == race && sauvegarde[i].ClassID == classe && sauvegarde[i].SexeID == sexe)
                {
                    valueOfReturn = sauvegarde[i].ClassID;
                }
            }

            return valueOfReturn;
        }

        public int getSexeID(int race, int classe, int sexe)
        {
            int valueOfReturn = 0;

            for (int i = 0; i < Length; i++)
            {
                if (sauvegarde[i].RaceID == race && sauvegarde[i].ClassID == classe && sauvegarde[i].SexeID == sexe)
                {
                    valueOfReturn = sauvegarde[i].SexeID;
                }
            }

            return valueOfReturn;
        }

        public int getItemID(int race, int classe, int sexe, int numObj) // 0 à 23
        {
            int valueOfReturn = 0;

            for (int i = 0; i < Length; i++)
            {
                if (sauvegarde[i].RaceID == race && sauvegarde[i].ClassID == classe && sauvegarde[i].SexeID == sexe)
                {
                    valueOfReturn = sauvegarde[i].ItemID[numObj];
                }
            }

            return valueOfReturn;
        }

        public int getItemDisplayID(int race, int classe, int sexe, int numObj) // 0 à 23
        {
            int valueOfReturn = 0;

            for (int i = 0; i < Length; i++)
            {
                if (sauvegarde[i].RaceID == race && sauvegarde[i].ClassID == classe && sauvegarde[i].SexeID == sexe)
                {
                    valueOfReturn = sauvegarde[i].ItemDisplayID[numObj];
                }
            }

            return valueOfReturn;
        }

        public int getEquipementID(int race, int classe, int sexe, int numObj) // 0 à 23
        {
            int valueOfReturn = 0;

            for (int i = 0; i < Length; i++)
            {
                if (sauvegarde[i].RaceID == race && sauvegarde[i].ClassID == classe && sauvegarde[i].SexeID == sexe)
                {
                    valueOfReturn = sauvegarde[i].EquipementID[numObj];
                }
            }

            return valueOfReturn;
        }

        // SET

        public void setUniqueIndex(int race, int classe, int sexe, int value)
        {
            for (int i = 0; i < Length; i++)
            {
                if (sauvegarde[i].RaceID == race && sauvegarde[i].ClassID == classe && sauvegarde[i].SexeID == sexe)
                {
                    sauvegarde[i].UniqueIndex = value;
                }
            }
        }

        public void setRaceID(int race, int classe, int sexe, int value)
        {
            for (int i = 0; i < Length; i++)
            {
                if (sauvegarde[i].RaceID == race && sauvegarde[i].ClassID == classe && sauvegarde[i].SexeID == sexe)
                {
                    sauvegarde[i].RaceID = value;
                }
            }
        }

        public void setClasseID(int race, int classe, int sexe, int value)
        {
            for (int i = 0; i < Length; i++)
            {
                if (sauvegarde[i].RaceID == race && sauvegarde[i].ClassID == classe && sauvegarde[i].SexeID == sexe)
                {
                    sauvegarde[i].ClassID = value;
                }
            }
        }

        public void setSexeID(int race, int classe, int sexe, int value)
        {
            for (int i = 0; i < Length; i++)
            {
                if (sauvegarde[i].RaceID == race && sauvegarde[i].ClassID == classe && sauvegarde[i].SexeID == sexe)
                {
                    sauvegarde[i].SexeID = value;
                }
            }
        }

        public void setItemID(int race, int classe, int sexe, int numObj, int value) // 0 à 23
        {
            for (int i = 0; i < Length; i++)
            {
                if (sauvegarde[i].RaceID == race && sauvegarde[i].ClassID == classe && sauvegarde[i].SexeID == sexe)
                {
                    sauvegarde[i].ItemID[numObj] = value;
                }
            }
        }

        public void setItemDisplayID(int race, int classe, int sexe, int numObj, int value) // 0 à 23
        {
            for (int i = 0; i < Length; i++)
            {
                if (sauvegarde[i].RaceID == race && sauvegarde[i].ClassID == classe && sauvegarde[i].SexeID == sexe)
                {
                    sauvegarde[i].ItemDisplayID[numObj] = value;
                }
            }
        }

        public void setEquipementID(int race, int classe, int sexe, int numObj, int value) // 0 à 23
        {
            for (int i = 0; i < Length; i++)
            {
                if (sauvegarde[i].RaceID == race && sauvegarde[i].ClassID == classe && sauvegarde[i].SexeID == sexe)
                {
                    sauvegarde[i].EquipementID[numObj] = value;
                }
            }
        }

        #endregion

        #region Fonctions de recherche des ItemsID, DisplaysID, EquipementsID

        public string searchRaceClassSexe_ItemsID(int race, int classe, int sexe)
        {
            string valueOfReturn = "";

            for(int i = 0; i < Length; i++)
            {
                if (sauvegarde[i].RaceID == race && sauvegarde[i].ClassID == classe && sauvegarde[i].SexeID == sexe)
                {
                    for (int j = 0; j < 24; j++)
                        valueOfReturn += sauvegarde[i].ItemID[j] + ",";
                }
            }

            return valueOfReturn;
        }

        public string searchRaceClassSexe_ItemsDisplaysID(int race, int classe, int sexe)
        {
            string valueOfReturn = "";

            for (int i = 0; i < Length; i++)
            {
                if (sauvegarde[i].RaceID == race && sauvegarde[i].ClassID == classe && sauvegarde[i].SexeID == sexe)
                {
                    for (int j = 0; j < 24; j++)
                        valueOfReturn += sauvegarde[i].ItemDisplayID[j] + ",";
                }
            }

            return valueOfReturn;
        }

        public string searchRaceClassSexe_EquipementsID(int race, int classe, int sexe)
        {
            string valueOfReturn = "";

            for (int i = 0; i < Length; i++)
            {
                if (sauvegarde[i].RaceID == race && sauvegarde[i].ClassID == classe && sauvegarde[i].SexeID == sexe)
                {
                    for (int j = 0; j < 24; j++)
                        valueOfReturn += sauvegarde[i].EquipementID[j] + ",";
                }
            }

            return valueOfReturn;
        }

        #endregion

        int i = 0;

        public string[] Read()
        {
            while (!reader.EndOfStream)
            {
                string[] Values = reader.ReadLine().Split(',');

                sauvegarde[i] = new CharStartOutfitEntry { };

                UniqueID.Add(Convert.ToInt32(Values[0])); // 1
                sauvegarde[i].UniqueIndex = Convert.ToInt32(Values[0]);

                Race.Add(Convert.ToInt32(Values[1])); // 2
                sauvegarde[i].RaceID = Convert.ToInt32(Values[1]);

                Classe.Add(Convert.ToInt32(Values[2])); // 3
                sauvegarde[i].ClassID = Convert.ToInt32(Values[2]);

                Sexe.Add(Convert.ToInt32(Values[3])); // 4
                sauvegarde[i].SexeID = Convert.ToInt32(Values[3]);

                for (int j = 5; j != 29; j++) // 6 à 29
                {
                    ItemID.Add(Convert.ToInt32(Values[j]));
                    sauvegarde[i].ItemID[j - 5] = Convert.ToInt32(Values[j]);
                }

                for (int j = 29; j != 53; j++) // 30 à 53
                {
                    ItemDisplayID.Add(Convert.ToInt32(Values[j]));
                    sauvegarde[i].ItemDisplayID[j - 29] = Convert.ToInt32(Values[j]);
                }
                   
                for (int j = 53; j != 77; j++) // 54 à 77
                {
                    EquipementID.Add(Convert.ToInt32(Values[j]));
                    sauvegarde[i].EquipementID[j - 53] = Convert.ToInt32(Values[j]);
                }

                i++;
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
}
