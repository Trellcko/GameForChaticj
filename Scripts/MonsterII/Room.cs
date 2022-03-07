using UnityEngine;

namespace Trell.ShadowHouse.GamePlay
{
	public class Room : MonoBehaviour
	{
		[SerializeField] private Transform _startPoint;
		[SerializeField] private Transform _endPoint;

		public Vector2 Start => _startPoint.position;

		public Vector2 End => _endPoint.position;

		public Vector2 GetRandomPosition()
        {
			Vector2 result;
			result.x = Random.Range(Start.x, End.x);
			result.y = Random.Range(Start.y, End.y);
			
			return result;
        }
	}
}