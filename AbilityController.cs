using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityController : MonoBehaviour
{
    bool lightWorld = true;

    public GameObject lw;
    public GameObject lightObjects;
    public GameObject darkObjects;

    public Animator Anim;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            SwitchPlatforms();
        }
    }

    public void SwitchPlatforms()
    {
        if (lightWorld == true)
        {
            lw.gameObject.SetActive(false);
            lightObjects.gameObject.SetActive(false);
            darkObjects.gameObject.SetActive(true);
            Anim.SetBool("light?", false);
        }
        else
        {
            lw.gameObject.SetActive(true);
            lightObjects.gameObject.SetActive(true);
            darkObjects.gameObject.SetActive(false);
            Anim.SetBool("light?", true);
        }

        lightWorld = !lightWorld;

    }
}
