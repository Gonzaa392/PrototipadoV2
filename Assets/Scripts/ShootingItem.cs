using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingItem : MonoBehaviour
{
    // Start is called before the first frame update
	public float speed;

	private void OnTriggerEnter(Collider2D.collision)
	{
		if(collision.tag == "Player")
			return;
			
	}


}
