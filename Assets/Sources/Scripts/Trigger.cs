using UnityEngine;
using UnityEngine.Events;

public class Trigger : MonoBehaviour 
{
	[SerializeField] private UnityEvent OnTrigger = null;
	//[SerializeField] private GameObject m_Object;

	void OnTriggerEnter(Collider other)
	{

		if(other.GetComponent<FirstPersonController>() == true)
		{
			OnTrigger.Invoke();
			//Destroy(m_Object, 10f);
		}
	}
}
