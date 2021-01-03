using EventObjects;
using UnityEngine;
using UnityEngine.Events;

public class DialogueEventListener : MonoBehaviour
{
    public DialogueEvent Event;
    public UnityEvent Response;

    public BoolWithEvent Condition;

    private void OnEnable() => Event.RegisterListener(this);

    private void OnDisable() => Event.UnregisterListener(this);

    public void OnEventRaised()
    {
        if (Condition != null && !Condition.Value)
        {
            return;
        }
        Response.Invoke();
    }
}
