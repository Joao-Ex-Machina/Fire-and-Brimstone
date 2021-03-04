using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDH : MonoBehaviour
{
  public GameObject ShotAPrefab;
  public GameObject ShotBPrefab;
	public Transform FirepointA;
    public Transform FirepointB;
	public float fireRate;
	public float Bulletforce;
	float nextFire;

	// Use this for initialization
	void Start () {
	
		nextFire = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		CheckIfTimeToFire ();
	}

	void CheckIfTimeToFire()
	{
		if (Time.time > nextFire) {
			GameObject shot1 =Instantiate (ShotAPrefab, transform.position, Quaternion.identity);
			Rigidbody2D rb2d = shot1.GetComponent<Rigidbody2D>();
	rb2d.AddForce (FirepointA.up * Bulletforce, ForceMode2D.Impulse);
    	GameObject shot2 =Instantiate (ShotBPrefab, transform.position, Quaternion.identity);
			Rigidbody2D rb2d2 = shot2.GetComponent<Rigidbody2D>();
	rb2d2.AddForce (FirepointB.up * Bulletforce, ForceMode2D.Impulse);
			nextFire = Time.time + fireRate;
		}
		
	}
}
