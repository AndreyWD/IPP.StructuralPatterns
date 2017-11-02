﻿namespace CompositeAppliance
{
    using System.Collections.Generic;

    public class Group : Party
    {
        public string Name { get; set; }
        public List<Party> Members { get; set; }

        #region CONSTRUCTORS

        public Group()
        {
            Members = new List<Party>();
        }

        #endregion

        public int Gold
        {
            get {
                int totalGold = 0;
                foreach (var member in Members)
                {
                    totalGold += member.Gold;
                }

                return totalGold;
            }
            set {
                var eachSplit = value / Members.Count;
                var leftOver = value % Members.Count;
                foreach (var member in Members)
                {
                    member.Gold += eachSplit + leftOver;
                    leftOver = 0;
                }
            }
        }

        public void Stats()
        {
            foreach (var member in Members)
            {
                member.Stats();
            }
        }
    }
}