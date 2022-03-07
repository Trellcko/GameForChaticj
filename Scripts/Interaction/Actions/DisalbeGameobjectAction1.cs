using UnityEngine;
using House312B.Core;

namespace House312B.Interaction
{
    public class DisableGameobjectAction : MonoBehaviour, IAction 
    {
        [SerializeField] private GameObject _gameObject;

        public void Do()
        {
            _gameObject.SetActive(false);
        }
    }

}