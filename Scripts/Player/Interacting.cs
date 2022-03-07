using House312B.Interaction;
using Trell;
using UnityEngine;

namespace House312B.Player
{
    [RequireComponent(typeof(Collider2D))]
    public class Interacting : MonoBehaviour
    {
        private Interactable _interactable;
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.TryGetComponent(out _interactable))
            {
                _interactable.EnableInteraction();
            }
        }

        private void OnTriggerExit2D(Collider2D collision)
        {
            if(_interactable != null)
            {
                _interactable.DisableInteraction();
                _interactable = null;
                print("exit");
            }
        }
    }
}