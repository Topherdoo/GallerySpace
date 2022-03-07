using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionHandler : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] LayerMask layerMask;
    [SerializeField] AudioClip ammoPickup;
   // [SerializeField] TextMeshProUGUI e;
    [SerializeField] float interactionRange;
    void Start()
    {
    }


    // Update is called once per frame
    void Update()
    {
        RaycastInteractor();
    }
    void RaycastInteractor()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        Physics.Raycast(ray, out hit, 100);
        //e.enabled = false;
        if (Physics.Raycast(ray, out hit, interactionRange, layerMask))
        {
            var button = hit.transform.gameObject;
            //e.enabled = true;
            if (Input.GetKeyDown(KeyCode.E))
            {
                switch (button.name)
                {
                    case "1":
                        button.GetComponentInParent<KeypadTeleporter>().Add1();
                        break;
                    case "2":
                        button.GetComponentInParent<KeypadTeleporter>().Add2();
                        break;
                    case "3":
                        button.GetComponentInParent<KeypadTeleporter>().Add3();
                        break;
                    case "4":
                        button.GetComponentInParent<KeypadTeleporter>().Add4();
                        break;
                    case "5":
                        button.GetComponentInParent<KeypadTeleporter>().Add5();
                        break;
                    case "6":
                        button.GetComponentInParent<KeypadTeleporter>().Add6();
                        break;
                    case "7":
                        button.GetComponentInParent<KeypadTeleporter>().Add7();
                        break;
                    case "8":
                        button.GetComponentInParent<KeypadTeleporter>().Add8();
                        break;
                    case "9":
                        button.GetComponentInParent<KeypadTeleporter>().Add9();
                        break;
                    case "0":
                        button.GetComponentInParent<KeypadTeleporter>().Add0();
                        break;
                    case "Confirm":
                        button.GetComponentInParent<KeypadTeleporter>().Confirm();
                        break;
                    case "Delete":
                        button.GetComponentInParent<KeypadTeleporter>().Delete();
                        break;
                }
            }
        }
    }
}
