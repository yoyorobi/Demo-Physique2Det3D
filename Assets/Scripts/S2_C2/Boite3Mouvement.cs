using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boite3Mouvement : MonoBehaviour
{

    private float positionX;
    private float positionY;
    private float positionZ;

    [SerializeField] private float vitesse=3;

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
        positionX = positionX +  vitesse * Time.deltaTime;
        transform.position = new Vector3(positionX, positionY, positionZ);
    }
}
