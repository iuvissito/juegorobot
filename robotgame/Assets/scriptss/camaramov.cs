using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camaramov : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Transform playerPosition;

    [SerializeField] float smoothVelocity = 0.3F;
    [SerializeField] Vector3 camaraVelocity = Vector3.zero;
    [SerializeField] float offsetY;
    void Update()
    {
        //Con esta línea, nuestro objeto tendrá la misma posición que el jugador
      

        //Útil para juegos de plataforma
        //Con este código, la cámara seguirá al jugador, pero alejado algo en el eje Z
    
        //Con este código, conseguimos que siga al objeto pero con suavidad
        //La velocidad de suavizado, cuanto menor sea más brusco será el movimiento
        Vector3 targetPosition = new Vector3(playerPosition.position.x, playerPosition.position.y + offsetY, transform.position.z);
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref camaraVelocity, smoothVelocity);
        


        // Update is called once per frame

    }
}
