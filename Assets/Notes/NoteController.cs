using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteController : MonoBehaviour
{
    float noteSpeed = -0.03f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.Translate(0, noteSpeed, 0);

        if (transform.position.y < -6.0f) 
        {
            Destroy(gameObject);
        }
    }
}
