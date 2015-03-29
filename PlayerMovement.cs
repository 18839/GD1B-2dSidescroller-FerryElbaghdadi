using UnityEngine;
using System.Collections;

public class PlayerMovement : Lives {

	public GameManager gameManager;

	public float speed;
	public float jumpHeight;

	public bool grounded;
	bool facingRight = true;

	public AudioSource jumpSFX;
	public AudioSource collectableSFX;

	public GameObject bullet;

	Animator anim;

	void Awake ()
	{
		anim = GetComponent<Animator> ();
		grounded = false;
	}


	void FixedUpdate () 
	{
		Move ();
		Jump ();
		Shoot ();
	}

	void Move ()
	{
		float x = Input.GetAxis ("Horizontal");
		Vector2 movement = new Vector2 (x, 0f);
		transform.Translate (movement * speed * Time.deltaTime);
	
		anim.SetFloat ("Speed", Mathf.Abs (x));

		if (x > 0 && !facingRight) {
			Flip ();
		} else if (x < 0 && facingRight) {
			Flip ();
		}
	}

	void Flip ()
	{
		facingRight = !facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}

	void Jump () 
	{
		if (grounded && Input.GetKey(KeyCode.Space))
		{
			jumpSFX.Play();
				anim.SetInteger ("AnimationState", 2);
				//transform.position += Vector3.up * jumpHeight * Time.deltaTime;
			GetComponent<Rigidbody2D>().velocity = new Vector2 (0f,jumpHeight);
				grounded = false;
		}
	}

	void Shoot()
	{
		if (Input.GetKeyDown (KeyCode.F)) 
		{
			//Instantiate(bullet);
			//bullet.GetComponent<Rigidbody2D>().velocity = new Vector2 (5, 0f);
			//Debug.Log ("F knop!");
		}
	}

	void OnCollisionEnter2D (Collision2D hit)
	{
		grounded = true;
		anim.SetInteger ("AnimationState", 0);
	}


	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.transform.tag == "Pickups") 
		{
			collectableSFX.Play ();
			gameManager.AddCollectable();
			Destroy(other.gameObject);
		}
}
}
