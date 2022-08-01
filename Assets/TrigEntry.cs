using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrigEntry : MonoBehaviour
{
    public float min;
    public float max;
    public float timeOver;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger Entered");
        var bw = GameObject.Find("Camera").GetComponent<BWEffect>();


       bw.intensity = Mathf.Lerp(min, max, Time.deltaTime * timeOver);
    }
}
