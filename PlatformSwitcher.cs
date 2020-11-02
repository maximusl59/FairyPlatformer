using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSwitcher : MonoBehaviour
{
    public AbilityController ac;

    public bool On = false;
    public float Interval;

    void Start()
    {
        StartCoroutine(Pulse());
    }

    void Update()
    {
       
    }

    IEnumerator Pulse()
    {
        yield return new WaitForSeconds(Interval);
        ac.SwitchPlatforms();
        StartCoroutine(Pulse());
    }

}
