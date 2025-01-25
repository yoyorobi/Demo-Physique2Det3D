using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectionSuperposition : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D autre){
        print(autre.gameObject.name);
    }

}
