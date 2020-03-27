using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DisplayAmmo : MonoBehaviour
{
    Weapon w;
    int ammo;
    public Text weaponType;
    public Text ammoType;
    WeaponSystem p;
    

   
    void Start()
    {
        p = GameObject.FindGameObjectWithTag("Player").GetComponent<WeaponSystem>();
        
    }
    void Update()
    {
        weaponType.text = "Weapon: "+p.currentWeapon.name;
        ammoType.text = p.currentAmmoType.ToString() + ": " + p.currentWeaponAmmo;
    }
}
