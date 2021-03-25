#pragma warning disable IDE0011
#pragma warning disable IDE0045

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strength_Calculator
{
    class CuttingStrength
    {
        public static string formula = "";
        public static float Calculate(int _fullThread, int _screwClass, int _screwSize, int _shreading, int _screwAmount)
        {
            float av = 0;
            float fub = 0;
            float A = 0;
            float result = 0;

            //set the av value
            switch (_screwClass)
            {
                case 800:
                    {
                        if (_fullThread == 1)
                            av = 0.6f;
                        else
                            av = 0.6f;
                        break;
                    }
                case 1000:
                    {
                        if (_fullThread == 1)
                            av = 0.5f;
                        else
                            av = 0.6f;
                        break;
                    }
                default:
                    break;
            }

            //set fub
            fub = _screwClass;

            //set A
            switch (_screwSize)
            {
                case 12:
                    {
                        if (_fullThread == 1)
                            A = 84.3f;
                        else
                            A = 113f;
                        break;
                    }
                case 16:
                    {
                        if (_fullThread == 1)
                            A = 157f;
                        else
                            A = 201f;
                        break;
                    }
                case 20:
                    {
                        if (_fullThread == 1)
                            A = 245f;
                        else
                            A = 314f;
                        break;
                    }
                case 22:
                    {
                        if (_fullThread == 1)
                            A = 303f;
                        else
                            A = 380f;
                        break;
                    }
                case 24:
                    {
                        if (_fullThread == 1)
                            A = 353f;
                        else
                            A = 452f;
                        break;
                    }
                case 27:
                    {
                        if (_fullThread == 1)
                            A = 459f;
                        else
                            A = 573f;
                        break;
                    }
                case 30:
                    {
                        if (_fullThread == 1)
                            A = 561f;
                        else
                            A = 707f;
                        break;
                    }
                case 36:
                    {
                        if (_fullThread == 1)
                            A = 817f;
                        else
                            A = 1018f;
                        break;
                    }
                default:
                    break;
            }

            //do the final calculations
            result = (av * fub * A / 1.25f);
            result *= _screwAmount;
            result *= _shreading;

            //assign the formula "njauuuuuuuuuuuuu"
            formula = $"({av} * {fub} * {A} / 1.25) * {_screwAmount} * {_shreading} = {result}";

            return result;
        }
    }
}
