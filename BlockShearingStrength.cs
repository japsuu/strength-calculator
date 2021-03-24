#pragma warning disable IDE0011
#pragma warning disable IDE0045

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strength_Calculator
{
    class BlockShearingStrength
    {
        public static string formula = "";
        public static float Calculate(int plateMaterial, int beamMaterial, int screwCount, float e1, float e2, float p1, float p2, int beamType, int pT, int d0, int shearing)
        {
            float pFy = 0;
            float pFu = 0;
            float pAnt = 0;
            float pAnv = 0;

            float bFy = 0;
            float bFu = 0;
            float bAnt = 0;
            float bAnv = 0;
            float bT = 0;

            float nver = 2;
            float nhor = 0;

            if (screwCount == 2)
                nhor = 1;
            else if (screwCount == 4)
                nhor = 2;

            switch (plateMaterial)
            {
                case 235:
                    {
                        pFy = 235;
                        pFu = 360;
                        break;
                    }
                case 355:
                    {
                        pFy = 355;
                        pFu = 510;
                        break;
                    }
                default:
                    break;
            }

            pAnt = ((nver - 1) * p2 - 2 * d0 / 2) * pT;
            pAnv = ((nhor - 1) * p1 + e1 - (nhor - 1) * d0 - d0 / 2) * pT;

            float plateStrength = PlateStrength(pFy, pFu, pAnv, pAnt) * shearing;

            formula += $"\nAnt= (({nver} - 1) * {p2} - 2 * {d0} / 2) * {pT}";
            formula += $"\nAnv= (({nhor} - 1) * {p1} + {e1} - ({nhor} - 1) * {d0} - {d0} / 2) * {pT}";


            switch (beamMaterial)
            {
                case 235:
                    {
                        bFy = 235;
                        bFu = 360;
                        break;
                    }
                case 355:
                    {
                        bFy = 355;
                        bFu = 510;
                        break;
                    }
                default:
                    break;
            }

            switch (beamType)
            {
                case 1:
                    {
                        bT = 8;
                        break;
                    }
                case 2:
                    {
                        bT = 9.5f;
                        break;
                    }
                case 3:
                    {
                        bT = 15.5f;
                        break;
                    }
                case 4:
                    {
                        bT = 27;
                        break;
                    }
                default:
                    break;
            }

            bAnt = ((nver - 1) * p2 - 2 * d0 / 2) * bT;
            bAnv = ((nhor - 1) * p1 + e1 - (nhor - 1) * d0 - d0 / 2) * bT;

            float beamStrength = BeamStrength(bFy, bFu, bAnv, bAnt);

            formula += $"\nAnt= (({nver} - 1) * {p2} - 2 * {d0} / 2) * {bT}";
            formula += $"\nAnv= (({nhor} - 1) * {p1} + {e1} - ({nhor} - 1) * {d0} - {d0} / 2) * {bT}";



            return Math.Min(plateStrength, beamStrength);
        }

        public static float PlateStrength(float fy, float fu, float anv, float ant)
        {
            formula = $"Plate: ({fu} * {ant} / {1.25f}) + ((1 / Math.Sqrt(3)) * {fy} * {anv} / 1)";
            return (fu * ant / 1.25f) + (float)((1 / Math.Sqrt(3)) * fy * anv / 1);
        }

        public static float BeamStrength(float fy, float fu, float anv, float ant)
        {
            formula += $"\nBeam: ({fu} * {ant} / 1.25f) + ((1 / Math.Sqrt(3)) * {fy} * {anv} / 1)";
            return (fu * ant / 1.25f) + (float)((1 / Math.Sqrt(3)) * fy * anv / 1);
        }
    }
}
