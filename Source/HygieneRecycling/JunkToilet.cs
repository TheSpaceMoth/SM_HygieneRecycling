using DubsBadHygiene;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verse;
using Verse.Sound;

namespace HygieneRecycling
{
    public class Building_JunkToilet : Building_BaseToilet
    {
        public new float waterUsed = 20.0f;

        public override void SpawnSetup(Map map, bool respawningAfterLoad)
        {
            base.SpawnSetup(map, respawningAfterLoad);
        }
        
        public override bool TryUseFlush()
        {
            this.floater = true;
            if (this.pipe == null)
                return true;
            if (this.pipe.pipeNet.PushSewage(this.flushSize))
            {
                this.floater = false;
                DubDef.ToiletFlush.PlayOneShot((SoundInfo)(Thing)this);
            }
            return this.pipe.pipeNet.PullWater(this.waterUsed, out ContaminationLevel _);
        }
    }
}
