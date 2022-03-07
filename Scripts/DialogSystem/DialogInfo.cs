using System;
using UnityEngine;

namespace House312B.DialogSystem
{
    [Serializable]
    public class DialogInfo
    {
        [field: SerializeField] public string Text { get; private set; }
        [field: SerializeField] public Transform Point { get; private set; }
    }
}