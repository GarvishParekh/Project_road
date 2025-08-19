using UnityEngine;

[CreateAssetMenu (fileName = "Input data", menuName = "Scriptable/Input data")]
public class InputData : ScriptableObject
{
    public InputType inputType;
    public float horizontalInputs = 0;
}
