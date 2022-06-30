using UnityEngine;

[CreateAssetMenu]

public class Vector3Data : ScriptableObject
{
    public void Start()
    {
        Vector3 pos = transform.position;
        pos = new Vector3(12, 2, 24);

        Transform tran = transform;
        tran.position = new Vector3(12, 2, 24);
    }
}
