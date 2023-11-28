using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace FormulaSystem.Data
{
    [CreateAssetMenu(fileName = "NewGlobalConstantsSO", menuName = "SO/New Global Constant Config")]
    public class GlobalConstantsSO : ScriptableObject
    {
        [field: SerializeField, Tooltip("Gravity")] public float g { get; private set; }
        [field: SerializeField, Tooltip("Gravitational constant")] public float G { get; private set; }
    }
}