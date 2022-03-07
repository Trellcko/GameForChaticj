using System;
using UnityEngine;

namespace Trell.ShadowHouse.II
{
	public class Monster : MonoBehaviour
	{
		[SerializeField] private MonsterDeath _death;

		public void SubscribeToDeath(Action action)
        {
			_death.Died += action;
        }
		public void UnSubscribeToDeath(Action action)
		{
			_death.Died -= action;
		}
	}
}