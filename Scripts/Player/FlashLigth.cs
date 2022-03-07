using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

namespace Trell.ShadowHouse.Player
{
	public class FlashLigth : MonoBehaviour
	{
		[SerializeField] private SpriteMask _spriteMask;
		[SerializeField] private Light2D _ligth;
		[SerializeField] private float _battery = 100f;

		public bool IsWork => _spriteMask.enabled;

		public bool TryTurnOn()
		{
			if (_battery > 0)
			{
				_spriteMask.enabled = true;
				_ligth.enabled = true;
				return true;
			}
			return false;
		}
		public void TurnOff()
        {
			_spriteMask.enabled = false;
			_ligth.enabled = false;
		}
	}
}