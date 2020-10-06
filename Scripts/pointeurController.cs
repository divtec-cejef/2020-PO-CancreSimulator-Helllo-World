using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System;

/**
* Gestion du viseur
*/
public class pointeurController : MonoBehaviour
{
    // Vitesse de déplacement du curseur
    private float moveSpeed = 20;

    Vector2 i_movement;

    void Update()
    {
        //dans la zone du tableau
            Move();
    }

    //Fait bouger le viseur
    void Move()
    {
        Vector2 movement = new Vector2(i_movement.x, i_movement.y) * moveSpeed * Time.deltaTime;      
        transform.Translate(movement);
    }

    /// <summary>
    /// Déplace le joueur
    /// </summary>
    /// <param name="value">Valeur du joystick</param>
    void OnMove(InputValue value)
    {
        i_movement = value.Get<Vector2>();  
    }
    
    
}
