using TMPro;
using UnityEngine;

namespace House312B.Utils
{
    [ExecuteInEditMode]
    [RequireComponent(typeof(TextMeshProUGUI))]
    public class TextFontFixer : MonoBehaviour
    {
        private void Start()
        {
            GetComponent<TextMeshProUGUI>().font.material.mainTexture.filterMode = FilterMode.Point;
        }


    }
}