using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FallingRock : MonoBehaviour
{
	[SerializeField] private UnityEvent OnTrigger = null;

	void OnTriggerEnter(Collider col)
	{

		if (col.CompareTag("FallingRock") == true)
		{
			OnTrigger.Invoke();
			Destroy(gameObject);
			Destroy(col.gameObject, 10f);
		}
	}
}
