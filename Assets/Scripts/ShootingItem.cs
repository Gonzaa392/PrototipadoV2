using UnityEngine;

public class ShootingItem : MonoBehaviour
{
    // Start is called before the first frame update
	public float speed;

	private void Update()
	{
		transform.Translate(transform.right * transform.localScale.x * speed * Time.deltaTime);
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if(collision.tag == "Player")
			return;

		if (collision.GetComponent<ShootingAction>())
			collision.GetComponent<ShootingAction>().Action();

		Destroy(gameObject);
	}


}
