using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDH : MonoBehaviour
{
	Renderer m_Renderer;
  	public GameObject ShotAPrefab;
	public Transform FirepointA;
    public Transform FirepointB;
	public float fireRate;
	public float Bulletforce;
	float nextFire;

	// Use this for initialization
	void Start () {
	m_Renderer = GetComponent<Renderer>();
		nextFire = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		if (m_Renderer.isVisible)
        {
			
		CheckIfTimeToFire ();
	}
	}

	void CheckIfTimeToFire()
	{
		if (Time.time > nextFire) {
			GameObject shot1 = Instantiate (ShotAPrefab, transform.position, Quaternion.identity);
			Rigidbody2D rb2d = shot1.GetComponent<Rigidbody2D>();
	rb2d.AddForce (FirepointA.up * Bulletforce, ForceMode2D.Impulse);
    	GameObject shot2 = Instantiate (ShotAPrefab, transform.position, Quaternion.identity);
		Rigidbody2D rb2d2 = shot2.GetComponent<Rigidbody2D>();
	rb2d2.AddForce (FirepointB.up * Bulletforce, ForceMode2D.Impulse);

			nextFire = Time.time + fireRate;
		}
		
	}
}
