using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float speed = 100f;
    public float pref;

    public void Awake()
    {

        pref = PlayerPrefs.GetFloat("RotationSPEED");
        Debug.Log(pref);
        speed = pref;
    }

    private void Update()
    {
        transform.Rotate(0f, 0f, speed*Time.deltaTime);
    }

    public void speedUp()
    {
        speed += 100f;
    }

    public void speedDown()
    {
        speed -= 100f;
    }
}
