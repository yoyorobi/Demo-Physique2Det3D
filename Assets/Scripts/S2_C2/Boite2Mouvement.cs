using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boite2Mouvement : MonoBehaviour
{

    private float positionX;
    private float positionY;
    private float positionZ;

    void Start()
    {
        positionX = transform.position.x;
        positionY = transform.position.y;
        positionZ = transform.position.z;
    }


    void Update() {
         BougerObjet();
    }


    public void BougerObjet()
    {
        positionX = positionX * Time.deltaTime;
        transform.position = new Vector3(positionX, positionY, positionZ);
    }
}
