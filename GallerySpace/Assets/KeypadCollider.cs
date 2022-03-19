using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeypadCollider : MonoBehaviour
{

    public GameObject PlayerToBeTeleported;
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
