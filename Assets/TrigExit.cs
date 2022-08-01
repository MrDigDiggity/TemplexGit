using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrigExit : MonoBehaviour
{
    public float min;
    public float max;
    public float timeOver;
    public float tParam = 0;
    public float speed;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger Entered");
        var bw = GameObject.Find("Camera").GetComponent<BWEffect>();

        if (tParam > 0)
        {
            tParam += Time.deltaTime * speed; //This will increment tParam based on Time.deltaTime multiplied by a speed multiplier
            bw.intensity = Mathf.Lerp(0, 1, -tParam);
        }


        // bw.intensity = Mathf.Lerp(min, max, Time.deltaTime * timeOver);
    }
}

