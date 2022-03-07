using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeypadCollider : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject PlayerToBeTeleported;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            PlayerToBeTeleported = collision.gameObject;
        }
    }
    private void OnTriggerExit(Collider collision)
    {
       PlayerToBeTeleported = null;
    }
}
