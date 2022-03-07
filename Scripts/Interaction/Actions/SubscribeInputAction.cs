using UnityEngine;
using House312B.Core;
using Trell.ShadowHouse.Core;
using Sirenix.OdinInspector;
using System.Collections.Generic;

namespace House312B.Interaction
{
    public class SubscribeInputAction : SerializedMonoBehaviour, IAction
    {
        [SerializeField] private List<IInputSubscriber> _subscribers;

        public void Do()
        {
            foreach(var subscriber in _subscribers)
            {
                subscriber.Subscribe();
            }
        }
    }
}