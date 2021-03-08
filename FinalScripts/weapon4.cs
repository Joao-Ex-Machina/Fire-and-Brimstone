using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon4 : MonoBehaviour
{
public Transform Firepoint1;
	public GameObject Shot1Prefab;
	public float Bulletforce;
    public static int Ammo;
	
	void Start () {
		Ammo = 10;
	}
	// Update is called once per frame
	void Update () {
        if (Ammo != 0){
		if (Input.GetButtonDown("Fire2"))
		{
			Shoot();
		}
        }
	}

	void Shoot ()
	{
		GameObject shot1 = Instantiate(Shot1Prefab, Firepoint1.position, Firepoint1.rotation);
	Rigidbody2D rb2d = shot1.GetComponent<Rigidbody2D>();
	rb2d.AddForce (Firepoint1.up * Bulletforce, ForceMode2D.Impulse);
    Ammo = Ammo-1;
	}
}

