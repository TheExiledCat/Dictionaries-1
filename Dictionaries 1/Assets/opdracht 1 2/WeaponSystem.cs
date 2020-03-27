using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class WeaponSystem : MonoBehaviour
{
    
    Dictionary<string, int> Ammo = new Dictionary<string, int>();
    int weaponIndex;
    [SerializeField]
    Weapon[] weapons;
    public Weapon currentWeapon;
    public int currentWeaponAmmo;
    public string currentAmmoType;
    // Start is called before the first frame update
    void Start()
    {
        
        Ammo.Add("Rifle", 10);
        Ammo.Add("Rocket", 5);
        Ammo.Add("Pistol", 20);
        currentWeaponAmmo = Ammo[weapons[weaponIndex].ammotype];
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q) && weaponIndex > 0)//iterator for weapon Q and E to cycle
        {
            weaponIndex--;
        }else if(Input.GetKeyDown(KeyCode.Q) && weaponIndex <= 0)
        {
            weaponIndex = weapons.Length - 1;
        }
        if (Input.GetKeyDown(KeyCode.E)&&weaponIndex<weapons.Length-1)
        {
            weaponIndex++;
        }else if(Input.GetKeyDown(KeyCode.E) && weaponIndex >= weapons.Length-1)
        {
            weaponIndex = 0;
        }
        if (Input.GetKeyDown(KeyCode.Space)&&Ammo[weapons[weaponIndex].ammotype]!=0) Shoot();
        print(weaponIndex);
        currentWeapon = weapons[weaponIndex];
        currentWeaponAmmo = Ammo[weapons[weaponIndex].ammotype];
        currentAmmoType = currentWeapon.ammotype;
    }
   public void Shoot()
    {
        Ammo[weapons[weaponIndex].ammotype]--;
        
       
    }
}
