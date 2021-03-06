﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Verse;

namespace Corruption.Domination
{
    public struct AllianceWarEffort : IExposable
    {
        public AllianceWarEffort(PoliticalAlliance alliance)
        {
            this.alliance = alliance;
            this.isWeary = false;
            this.WarWeariness = 0f;
            this.totalCasualties = 0;
        }

        public PoliticalAlliance alliance;

        public float WarWeariness;

        public bool isWeary;

        public int totalCasualties;
        
        public void ExposeData()
        {
            Scribe_Values.Look<bool>(ref this.isWeary, "isWeary");
            Scribe_Values.Look<float>(ref this.WarWeariness, "WarWeariness");
            Scribe_Values.Look<bool>(ref this.isWeary, "isWeary");
            Scribe_Values.Look<int>(ref this.totalCasualties, "totalCasualties");
            Scribe_References.Look<PoliticalAlliance>(ref this.alliance, "alliance");
        }
    }
}
