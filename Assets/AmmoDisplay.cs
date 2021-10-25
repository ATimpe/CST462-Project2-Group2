using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoDisplay : MonoBehaviour
{
    public int ammo;
    public bool is_firing;
    public Text ammo_display;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ammo_display.text = ammo.ToString();
        if (Input.GetMouseButtonDown(0) && !is_firing && ammo > 0)
        {
            is_firing = true;
            ammo--;
            is_firing = false;
        }
    }
}
