using UnityEngine;
using House312B.Core;
using Sirenix.OdinInspector;
using System.Collections.Generic;
using Trell;

namespace House312B.Interaction
{
    public class ActionsInfo : SerializedMonoBehaviour
    {
        [SerializeField] private List<IAction> _actions;
        [SerializeField] private List<IChecker> _checkers;

        public bool TryDoActions()
        {
            foreach (var checer in _checkers)
            {
                if (checer.Check() == false)
                {
                    return false;
                }
            }
            foreach (var action in _actions)
            {
                action.Do();
            }
            return true;
        }
    }
}