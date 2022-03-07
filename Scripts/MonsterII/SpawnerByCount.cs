using System;
using System.Collections.Generic;
using Trell.ShadowHouse.II;
using UnityEngine;

namespace Trell.ShadowHouse.GamePlay
{
	public class SpawnerByCount : MonoBehaviour
	{
		[field: SerializeField] public int MaxCountMonsters;
    
        [SerializeField] private List<Transform> _spawnPoints;

        [SerializeField] private MonsterSpawner _monsterSpawner;
        [SerializeField] private PlayerEvents _playerEvents;
        [Space]
        [SerializeField] private int _countToUpdate = 2;

        private int _currentCount = 0;

        private readonly Dictionary<Monster, Action> _monstersDeathHandler = new Dictionary<Monster, Action>();
        private Action _deathHandler;

        private void Awake()
        {
            for(; _monstersDeathHandler.Count < MaxCountMonsters;)
            {
                Spawn();
            }
        }

        private void OnEnable()
        {
            _playerEvents.BringTheCoin += UpdateSpawner;
            foreach(var monsterDeathHandler in _monstersDeathHandler)
            {
                monsterDeathHandler.Key.SubscribeToDeath(monsterDeathHandler.Value);
            }
        }

        private void UpdateSpawner()
        {
            if(++_currentCount%_countToUpdate == 0)
            {
                MaxCountMonsters++;
                Spawn();
            }
        }

        private void OnDisable()
        {
            foreach (var monsterDeathHandler in _monstersDeathHandler)
            {
                monsterDeathHandler.Key.UnSubscribeToDeath(monsterDeathHandler.Value);
            }
        }

        public void Spawn()
        {
            if (_monstersDeathHandler.Count < MaxCountMonsters)
            {
                var spawnPoint = _spawnPoints[UnityEngine.Random.Range(0, _spawnPoints.Count)];
                var monster = _monsterSpawner.Spawn(spawnPoint.position);
                Action deathHandler = () => { DeahtHandler(monster); };
                monster.SubscribeToDeath(deathHandler);

                _monstersDeathHandler.Add(monster, deathHandler);
            }
        }

        private void DeahtHandler(Monster monster)
        {
            _monstersDeathHandler.Remove(monster);
            Spawn();
        }
    }
} 