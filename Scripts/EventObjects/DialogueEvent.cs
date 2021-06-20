using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using DREditor;

[CreateAssetMenu(menuName = "DREditor/Events/Dialogue Event", fileName = "New Dialogue Event")]
public class DialogueEvent : ScriptableObject
{
    private readonly List<DialogueEventListener> listeners = new List<DialogueEventListener>();

    public void Raise() => Enumerable.Reverse(listeners).ForEach(listener => listener.OnEventRaised());

    public void RegisterListener(DialogueEventListener listener) => listeners.Add(listener);

    public void UnregisterListener(DialogueEventListener listener) => listeners.Remove(listener);
}
