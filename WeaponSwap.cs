using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwap : MonoBehaviour
{
    public GameObject[] Weapons;
    public int weaponselected;
    public int previousWeap;

    // Start is called before the first frame update
    void Start()
    {
        weaponselected = 0;
        Weapons[weaponselected].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetAxis("Mouse ScrollWheel") < 0f)
        {
            WeaponUp();
        }
        else if (Input.GetAxis("Mouse ScrollWheel") > 0f)
        {
            WeaponDown();
        }

        if (weaponselected >= Weapons.Length)
        {
            weaponselected = Weapons.Length;
        }

        if (weaponselected <= 0)
        {
            weaponselected = 0;
        }

        if (weaponselected != previousWeap)
        {
            Weapons[weaponselected].SetActive(true);
            Weapons[previousWeap].SetActive(false);
        }
        else
        {
            Weapons[weaponselected].SetActive(true);
        }
    }

    void WeaponUp()
    {
        previousWeap = weaponselected;
        weaponselected += 1;
    }

    void WeaponDown()
    {
        previousWeap = weaponselected;
        weaponselected -= 1;
    }
}
