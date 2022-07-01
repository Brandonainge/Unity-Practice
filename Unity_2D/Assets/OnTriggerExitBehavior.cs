using UnityEngine;
using UnityEngine.Events;

public class OnTriggerExitBehavior : MonoBehaviour
{
    public UnityEvent exitEvent;

    private void exit()
    {
        exitEvent.Invoke();
    }
}