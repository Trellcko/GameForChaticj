using UnityEngine;

namespace Trell.ShadowHouse.Core
{
	public interface IMonsterBehaviour
	{
		bool IsActive { get; }
		void Active();
		void DeActive();
	}
}