using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UberEnemy : MonoBehaviour
{
	Renderer m_Renderer;
  public GameObject Shot1Prefab;
  public GameObject Shot2Prefab;
  public GameObject Shot3Prefab;
  public GameObject Shot4Prefab;
	public Transform Firepoint1;
    public Transform Firepoint2;
	public Transform Firepoint3;
	public Transform Firepoint4;
  
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
			GameObject shot1 = Instantiate(Shot1Prefab, Firepoint1.position, Firepoint1.rotation);
	Rigidbody2D rb2d = shot1.GetComponent<Rigidbody2D>();
	rb2d.AddForce (Firepoint1.up * Bulletforce, ForceMode2D.Impulse);

	GameObject shot2 = Instantiate(Shot2Prefab, Firepoint2.position, Firepoint2.rotation);
	Rigidbody2D rb2d2 = shot2.GetComponent<Rigidbody2D>();
	rb2d2.AddForce (Firepoint2.up * Bulletforce, ForceMode2D.Impulse);

	GameObject shot3 = Instantiate(Shot3Prefab, Firepoint3.position, Firepoint3.rotation);
	Rigidbody2D rb2d3 = shot3.GetComponent<Rigidbody2D>();
	rb2d3.AddForce (Firepoint3.up * Bulletforce, ForceMode2D.Impulse);

	GameObject shot4 = Instantiate(Shot4Prefab, Firepoint4.position, Firepoint4.rotation);
	Rigidbody2D rb2d4 = shot4.GetComponent<Rigidbody2D>();
	rb2d4.AddForce (Firepoint4.up * Bulletforce, ForceMode2D.Impulse);

	nextFire = Time.time + fireRate;

	}
	}
}
