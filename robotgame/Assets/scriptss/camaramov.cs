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
        //Con esta l�nea, nuestro objeto tendr� la misma posici�n que el jugador
      

        //�til para juegos de plataforma
        //Con este c�digo, la c�mara seguir� al jugador, pero alejado algo en el eje Z
    
        //Con este c�digo, conseguimos que siga al objeto pero con suavidad
        //La velocidad de suavizado, cuanto menor sea m�s brusco ser� el movimiento
        Vector3 targetPosition = new Vector3(playerPosition.position.x, playerPosition.position.y + offsetY, transform.position.z);
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref camaraVelocity, smoothVelocity);
        


        // Update is called once per frame

    }
}
