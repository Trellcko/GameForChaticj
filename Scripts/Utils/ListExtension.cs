using UnityEngine;
using System.Collections.Generic;

namespace Trell
{
	public static class ListExtension
	{
		public static void Shuffle<T> (this List<T> array)
        {
			int length = array.Count;
			while(length > 1)
            {
				int random = Random.Range(0, length--);
				T data = array[length];
				array[length] = array[random];
				array[random] = data;
            }
        }
	}
}