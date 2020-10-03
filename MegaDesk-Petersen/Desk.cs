using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Petersen
{
    class Desk
    {
        public int deskWidth { get; set; }
        public int deskDepth { get; set; }
        public int numDrawers { get; set; }
        public string surfaceMaterial { get; set; }

        public Desk(int deskWidth, int deskDepth, int numDrawers, string surfaceMaterial)
        {
            this.deskWidth = deskWidth;
            this.deskDepth = deskDepth;
            this.numDrawers = numDrawers;
            this.surfaceMaterial = surfaceMaterial;
        }

    }

    public enum SurfaceMaterials:int
    {
        Pine = 1,
        Oak = 2,
        Maple = 3,
        Rosewood = 4
    }

}
