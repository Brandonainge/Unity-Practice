using UnityEngine;
using UnityEngine.Events;

public class ReleaseBehavior : MonoBehaviour
{
    public UnityEvent releaseEvent;

    private void exit()
    {
        releaseEvent.Invoke();
    }
}