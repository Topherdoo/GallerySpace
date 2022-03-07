using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KeypadTeleporter : MonoBehaviour
{
    // Start is called before the first frame update
     string code = "";
    [SerializeField] TextMeshPro codeDisplay;
    [SerializeField] KeypadCollider keypadCollider;

    [Header("Room waypoints")]
    [SerializeField]Transform[] waypointTransforms;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        codeDisplay.text = code;
        if (code.Length > 4)
        {
            code = "";
        }
    }
    void Teleport()
    {
        switch (code)
        {
            case ("1"):
                if (keypadCollider.PlayerToBeTeleported)
                {
                    keypadCollider.PlayerToBeTeleported.transform.position = waypointTransforms[0].transform.position;
                }
                break;
            case ("2"):
                if (keypadCollider.PlayerToBeTeleported)
                {
                    keypadCollider.PlayerToBeTeleported.transform.position = waypointTransforms[1].transform.position;
                }
                break;
            default:
                code = "";
                break;
        }
    }

    #region ENTER KEYPAD NUMBER FUNCTIONS REGION
    public void Add1()
    {
        code += "1";
    }
    public void Add2()
    {
        code += "2";
    }
    public void Add3()
    {
        code += "3";
    }
    public void Add4()
    {
        code += "4";
    }
    public void Add5()
    {
        code += "5";
    }
    public void Add6()
    {
        code += "6";
    }
    public void Add7()
    {
        code += "7";
    }
    public void Add8()
    {
        code += "8";
    }
    public void Add9()
    {
        code += "9";
    }
    public void Add0()
    {
        code += "0";
    }
    public void Delete()
    {
        code = "";
    }
    public void Confirm()
    {
        print("confirm");
        Teleport();
    }
    #endregion 

}
