using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class ShootingAction : MonoBehaviour
{
    // Start is called before the first frame update
	public UnityEvent action;

	public void Action()
	{
		action?.Invoke();
	}

}
