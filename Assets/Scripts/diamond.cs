using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class diamond : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
	{
		playerentry playerentry= other.GetComponent<playerentry>();
		if(playerentry!= null)
		{
			playerentry.DiamondCollected();
			gameObject.SetActive(false);
		}
	}
}
