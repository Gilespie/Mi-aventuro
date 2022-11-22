using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkWay : MonoBehaviour
{
	[SerializeField]
	private float Power = 4;

	void OnTriggerEnter(Collider col)
	{

		if (col.CompareTag("Player") == true)
		{
			col.GetComponent<FirstPersonController>().m_WalkSpeed -= Power;
			col.GetComponent<FirstPersonController>().m_RunSpeed -= Power;
			col.GetComponent<FirstPersonController>().m_JumpSpeed += 2;
		}
	}

	void OnTriggerExit(Collider col)
	{
		if (col.CompareTag("Player") == true)
		{
			col.GetComponent<FirstPersonController>().m_WalkSpeed += Power;
			col.GetComponent<FirstPersonController>().m_RunSpeed += Power;
			col.GetComponent<FirstPersonController>().m_JumpSpeed -= 2;
		}
	}
}
