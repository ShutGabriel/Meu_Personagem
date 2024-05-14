using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float _velocidade;
    [SerializeField] Rigidbody2D _rb;
    [SerializeField] float _velocidade1;
    [SerializeField] float _moveX;
    [SerializeField] float _moveY;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        _moveX = Input.GetAxisRaw("Horizontal");
        _moveY = Input.GetAxisRaw("Vertical");
        _rb.velocity = new Vector2(_moveX, _moveY);
    }
}
