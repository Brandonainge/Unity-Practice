using UnityEngine;
using UnityEngine.Events;

public class OnMouseOverBehavior : MonoBehaviour
{
    public UnityEvent overEvent, dragEvent, exitEvent;
  

    private void Over()
    {
        overEvent.Invoke();
    }
  
    private void Drag()
    {
        dragEvent.Invoke();
    }

    private void exit()
    {
        exitEvent.Invoke();
    }
}