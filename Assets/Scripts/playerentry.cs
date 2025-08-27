using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
public class playerentry : MonoBehaviour
{
	[SerializeField] AudioSource collectionSound;
    public int NumberOfDiamonds{get; private set;}
	
	public UnityEvent<playerentry> OnDiamondCollected;
	public void DiamondCollected()
	{
		NumberOfDiamonds++;
		OnDiamondCollected.Invoke(this);
		collectionSound.Play();
	}
}
