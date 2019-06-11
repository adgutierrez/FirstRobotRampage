using System;
using UnityEngine;

public class ProjectileShooter : MonoBehaviour
{
	public GameObject ProjectilePrefab;
	public Transform ProjectileSpawn;

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.F))
		{
			Fire();
		}
	}

	void Fire()
	{
		// Create the Projectile from the Projectile Prefab
		var Projectile = (GameObject)Instantiate(
			ProjectilePrefab,
			ProjectileSpawn.position,
			ProjectileSpawn.rotation);

		// Add velocity to the Projectile
		Projectile.GetComponent<Rigidbody>().velocity = Projectile.transform.forward * 10;

		// Destroy the Projectile after 3 seconds
		Destroy(Projectile, 2.0f);        
	}
}