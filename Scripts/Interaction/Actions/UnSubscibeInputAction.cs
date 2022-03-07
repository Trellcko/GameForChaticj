using UnityEngine;
using House312B.Core;
using House312B.Player;
using System.Collections.Generic;
using Trell.ShadowHouse.Core;
using Sirenix.OdinInspector;

namespace House312B.Interaction
{
    public class UnSubscibeInputAction : SerializedMonoBehaviour, IAction
    {
        [SerializeField] private List<IInputSubscriber> _subscribers;
        

        public void Do()
        {
            foreach(var subscriber in _subscribers)
            {
                subscriber.UnSubscribe();
            }
        }
    }
}