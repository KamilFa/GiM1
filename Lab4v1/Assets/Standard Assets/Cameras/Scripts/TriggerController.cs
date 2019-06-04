using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerController : MonoBehaviour
{
    public GameObject LightG;
    void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Collider>().CompareTag("Player"))
        {
            LightG.GetComponent<Light>().color = Color.red;
            AudioSource sound = other.GetComponent<AudioSource>();
            sound.Play();
        }
    }
}