using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FormulaSystem.Data;

namespace FormulaSystem
{
    public static class FormulaCalculator
    {
        private static GlobalConstantsSO _globalConstantsSO;

        static FormulaCalculator()
        {
            _globalConstantsSO = Resources.Load("GlobalConstantsSO") as GlobalConstantsSO;
        }

        public static float CalculateStartHeight(float mass, float v1, float fullEnergy)
        {
            float result = 0;
            float potentialEnergy = fullEnergy - mass * Mathf.Pow(v1, 2) / 2;
            result = potentialEnergy / (mass * _globalConstantsSO.g);

            return result;
        }
    }
}