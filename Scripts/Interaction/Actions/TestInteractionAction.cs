using House312B.Core;
using UnityEngine;
using UnityEngine.InputSystem;

namespace House312B.Interaction.Actions
{
    public class TestInteractionAction : MonoBehaviour, IAction
    {
        public void Do()
        {
            Debug.Log("Test Interaction");
        }
    }
}