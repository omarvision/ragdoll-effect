using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ragdoll : MonoBehaviour
{
    private Rigidbody[] RigBones;

    private void Start()
    {
        RigBones = this.gameObject.GetComponentsInChildren<Rigidbody>();
        TurnRagdollOff();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            TurnRagdollOn();
        }
    }
    private void TurnRagdollOff()
    {
        foreach (Rigidbody rb in RigBones)
        {
            rb.isKinematic = true;
        }
    }
    private void TurnRagdollOn()
    {
        foreach (Rigidbody rb in RigBones)
        {
            rb.isKinematic = false;
        }
    }
}