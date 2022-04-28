using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitObj : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) {
        Debug.Log("Something Hits Me");
        GetComponent<MeshRenderer>().material.color = Color.red;
    }
}
