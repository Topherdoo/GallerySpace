using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    GameObject spawn;
    private void OnEnable()
    {
        spawn = GameObject.FindGameObjectWithTag("Spawn");
        transform.position = spawn.transform.position;
    }
}
