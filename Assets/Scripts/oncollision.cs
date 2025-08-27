using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class oncollision : MonoBehaviour
{
	
	[SerializeField] AudioSource deathsound;
    private void Update()
	{
		if(transform.position.y>20.5f)
		{
			Die();
		}
		if(transform.position.y<-64.5f)
		{
			Die();
		}
	}

     private void OnCollisionEnter(Collision collision)
	 {
		 if(collision.gameObject.CompareTag("Enemy Body"))
		 {
			 GetComponent<MeshRenderer>().enabled=false;
		     GetComponent<Rigidbody>().isKinematic= true;
		     GetComponent<Playermovement>().enabled= false;
		     GetComponent<move>().enabled=false;
			 Die();
		 }
	 }
	 void Die()
	 {
		 
		 Invoke(nameof(ReloadLevel), 1.3f);
		 deathsound.Play();
	 }
	 
	 void ReloadLevel()
	 {
		 SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	 }
}
