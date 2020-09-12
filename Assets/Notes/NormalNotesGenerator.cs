using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class NormalNotesGenerator : MonoBehaviour
{

    public GameObject normalNotesPrefab;
    float span = 0.3f;
    float delta = 0;
    float[] normalNotes = { 7.1f, 3.6f, 0.0f, -3.6f, -7.1f };
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(normalNotesPrefab) as GameObject;
            float px = normalNotes[Random.Range(0,5)];
            go.transform.position = new Vector3(px, 7, 0);
        }
    }
}
