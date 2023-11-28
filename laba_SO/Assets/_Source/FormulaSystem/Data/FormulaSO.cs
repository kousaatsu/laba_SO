using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewFormulaSO", menuName = "SO/New Formula View Config")]
public class FormulaSO : ScriptableObject
{
    [field: SerializeField, TextArea] public string Formula { get; private set; }
}