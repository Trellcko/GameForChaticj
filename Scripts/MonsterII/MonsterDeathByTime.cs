using System.Collections;
using UnityEngine;

namespace Trell.ShadowHouse.II
{
	public class MonsterDeathByTime : MonoBehaviour
	{
		[SerializeField] private MonsterDeath _monsterDeath;

		[SerializeField] private float _deathTime;

        private void Awake()
        {
			StartCoroutine(DeathCorun());
        }

        private IEnumerator DeathCorun()
		{
			yield return new WaitForSeconds(_deathTime);
			_monsterDeath.Die();
		}
    }
}