using System;
using System.Collections;
using System.Collections.Generic;
using Trell.ShadowHouse.II;
using UnityEngine;

namespace Trell.ShadowHouse.GamePlay
{
	public class SpawnerByTime : MonoBehaviour
	{
		[SerializeField] private PlayerEvents _playerEvents;
		[SerializeField] private MonsterSpawner _monsterSpawner;
		[SerializeField] private List<Transform> _spawnPoints;

		[SerializeField] private float _reducedTime = 1f;

		[field: SerializeField] public float Time { get; private set; }

		private List<Transform> _occupiedPoints = new List<Transform>();
		private Dictionary<Monster, Action> _monstersDeathHandler = new Dictionary<Monster, Action>();

		private void Awake()
		{
			StartCoroutine(SpawnCorun());
		}

		private void OnEnable()
		{
            _playerEvents.BringTheCoin += UpdateSpawner;
			foreach (var monsterDeathHandler in _monstersDeathHandler)
			{
				monsterDeathHandler.Key.SubscribeToDeath(monsterDeathHandler.Value);
			}
		}

        private void UpdateSpawner()
        {
			Time -= _reducedTime;
        }

        private void OnDisable()
		{

			_playerEvents.BringTheCoin += UpdateSpawner;
			foreach (var monsterDeathHandler in _monstersDeathHandler)
			{
				monsterDeathHandler.Key.UnSubscribeToDeath(monsterDeathHandler.Value);
			}
		}


		private IEnumerator SpawnCorun()
		{
			while (true)
			{
				yield return new WaitForSeconds(Time + UnityEngine.Random.Range(0, 5));

				if (_occupiedPoints.Count < _spawnPoints.Count)
				{
					var spawnPoint = _spawnPoints[UnityEngine.Random.Range(0, _spawnPoints.Count)];
					var monster = _monsterSpawner.Spawn(spawnPoint.position);
					_occupiedPoints.Add(spawnPoint);
					
					Action deathHandler = () => 
					{ 
						_occupiedPoints.Remove(spawnPoint);
						_monstersDeathHandler.Remove(monster); 
					};
					monster.SubscribeToDeath(deathHandler);
					_monstersDeathHandler.Add(monster, deathHandler);
				}
			}
		}
		private void OnDeahtHandler()
		{

		}
	}
}