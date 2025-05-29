using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _speed = 10;
    [SerializeField] Rigidbody2D _rb;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        if(h != 0 || v != 0)
        {
            Vector2 dir = new Vector2(h, v); // <- creo un vettore direzione

            float length = dir.magnitude; // <- calcolo la sua lunghezza

            if(length > 1)
            {
                dir /= length; // <- normalizzo il vettore se la lunghezza è > di 1
            }

            _rb.MovePosition(_rb.position + dir * (_speed * Time.deltaTime)); // <- eseguo il movimento tramite Rigidbody2D
        }
    }
}
