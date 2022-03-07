using System.Collections.Generic;
using Trell.ShadowHouse.II;
using UnityEngine;

namespace Trell.ShadowHouse.GamePlay
{
	public class MonsterSpawner : MonoBehaviour
	{
		[SerializeField] private List<Monster> _monsters;

		public Monster Spawn(Vector2 position)
        {
			return Instantiate(_monsters[Random.Range(0, _monsters.Count)], position, Quaternion.identity);
        }
	}
}