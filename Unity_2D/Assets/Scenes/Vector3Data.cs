using UnityEngine;
using System.Collections;

[CreateAssetMenu]

public class Vector3Data : ScriptableObject
{
    Vector2 pos;
    

    void Start()
    {
        pos = new Vector2 (5f, 6f);
        Debug.Log (pos.x);
        Debug.Log (pos.y);
    }


    void Update ()
    {

    }
}
