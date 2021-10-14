using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    public float Health = 100f;
    public float jumph;
    public float jumpForce;
    private Vector3 jump;
    private Rigidbody rigg;

    private void Start() 
    {
        jump = new Vector3(0f, jumph, 0f);
        rigg = GetComponent<Rigidbody>();      
    }

    private void Update() 
    {
        if(rigg.velocity.y == 0)
            {
                if(Input.GetKeyDown(KeyCode.Space))
                {
                    rigg.AddForce(jump * jumpForce, ForceMode.Impulse);
                }
            }
    }
    public Vector2 InputVector { get; private set; }

    public Vector3 MousePosition { get; private set; }
    // Update is called once per frame
    void FixedUpdate()
    {
        var h = Input.GetAxis("Horizontal");    
        var v = Input.GetAxis("Vertical");
        InputVector = new Vector2(h, v);
        MousePosition = Input.mousePosition;
    }
}