using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carDriverPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    private carDriver carDriver;

    private void Awake()
    {
        carDriver = GetComponent<carDriver>();

    }

    private void Update()
    {
        float forwardAmount = Input.GetAxisRaw("Vertical");
        float turnAmount = Input.GetAxisRaw("Horizontal");
        carDriver.SetInputs(forwardAmount, turnAmount);
    }
}
