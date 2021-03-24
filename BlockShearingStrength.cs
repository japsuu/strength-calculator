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
            float bFy = 0;
            float bFu = 0;
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

            //levyn Ant & Anv laskeminen:
            float pAnt = ((nver - 1) * p2 - 2 * d0 / 2) * pT;
            float pAnv = ((nhor - 1) * p1 + e1 - (nhor - 1) * d0 - d0 / 2) * pT * 2;

            //palkin Ant & Anv laskeminen:
            float bAnt = ((nver - 1) * p2 - 2 * d0 / 2) * bT;
            float bAnv = ((nhor - 1) * p1 + e1 - (nhor - 1) * d0 - d0 / 2) * bT * 2;

            float plateStrength = PlateStrength(pFy, pFu, pAnv, pAnt) * shearing;

            //formula += $"\nAnt= (({nver} - 1) * {p2} - 2 * {d0} / 2) * {pT} = {((nver - 1) * p2 - 2 * d0 / 2) * pT}";
            //formula += $"\nAnv= (({nhor} - 1) * {p1} + {e1} - ({nhor} - 1) * {d0} - {d0} / 2) * {pT} * 2 = {((nhor - 1) * p1 + e1 - (nhor - 1) * d0 - d0 / 2) * pT * 2}";


            float beamStrength = BeamStrength(bFy, bFu, bAnv, bAnt);

            //formula += $"\nAnt= (({nver} - 1) * {p2} - 2 * {d0} / 2) * {bT} = {((nver - 1) * p2 - 2 * d0 / 2) * bT}";
            //formula += $"\nAnv= (({nhor} - 1) * {p1} + {e1} - ({nhor} - 1) * {d0} - {d0} / 2) * {bT} * 2 = {((nhor - 1) * p1 + e1 - (nhor - 1) * d0 - d0 / 2) * bT * 2}";


            return Math.Min(plateStrength, beamStrength);
        }

        public static float PlateStrength(float fy, float fu, float anv, float ant)
        {
            formula = $"Levy: ({fu} * {ant} / {1.25f}) + ((1 / sqrt(3)) * {fy} * {anv} / 1) = {(fu * ant / 1.25f) + (float)((1 / Math.Sqrt(3)) * fy * anv / 1)} N";
            return (fu * ant / 1.25f) + (float)((1 / Math.Sqrt(3)) * fy * anv / 1);
        }

        public static float BeamStrength(float fy, float fu, float anv, float ant)
        {
            formula += $"\nPalkki: ({fu} * {ant} / 1.25f) + ((1 / sqrt(3)) * {fy} * {anv} / 1) = {(fu * ant / 1.25f) + (float)((1 / Math.Sqrt(3)) * fy * anv / 1)} N";
            return (fu * ant / 1.25f) + (float)((1 / Math.Sqrt(3)) * fy * anv / 1);
        }
    }
}
