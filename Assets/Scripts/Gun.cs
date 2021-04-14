using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Gun : MonoBehaviour
{
	public GameObject Weapon1;
	public GameObject Weapon2;
	public Image Gun1;
	public Image Gun2;
	public int MaxWeapon = 2;
	private int ScrolInt;
	public GameObject bullet1; 
	public GameObject bullet2; 
	public Transform shotPoint1; 
	public Transform shotPoint2; 
	private float timeBtwShorts1;
	private float timeBtwShorts2;
	public float startTimeBtwShorts1; 
	public float startTimeBtwShorts2;
	private Vector3 difference;

	private void FixedUpdate()
	{
		if (ScrolInt == 0)
		{
			Weapon1.SetActive(true);
			Gun1.enabled = true;
			Gun2.enabled = false;
			Weapon2.SetActive(false);
			
			if (timeBtwShorts1 <= 0)
			{
				if (Input.GetMouseButton(0))
				{
					Instantiate(bullet1, shotPoint1.position, shotPoint1.rotation);
					timeBtwShorts1 = startTimeBtwShorts1;
				}
			}
			else
			{
				timeBtwShorts1 -= Time.deltaTime;
			}
		}

		if (ScrolInt == 1)
		{
			Weapon1.SetActive(false);
			Gun2.enabled = true;
			Gun1.enabled = false;
			Weapon2.SetActive(true);

			if (timeBtwShorts2 <= 0)
			{
				if (Input.GetMouseButton(0))
				{
					Instantiate(bullet2, shotPoint2.position, shotPoint2.rotation);
					timeBtwShorts2 = startTimeBtwShorts2;
				}
			}
			else
			{
				timeBtwShorts2 -= Time.deltaTime;
			}
		}

		if (ScrolInt <= 0)
		{
			ScrolInt = 0;
		}
		if (ScrolInt >= MaxWeapon)
		{
			ScrolInt = MaxWeapon;
		}
		if (Input.GetAxis("Mouse ScrollWheel") > 0f)
		{
			ScrolInt += 1;
		}
		if (Input.GetAxis("Mouse ScrollWheel") < 0f)
		{
			ScrolInt -= 1;
		}
	}
}
