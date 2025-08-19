using System.Collections;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    [Header ("<b>Scriptables")]
    [SerializeField] private InputData inputData;

    private void Awake()
    {
        inputData.horizontalInputs = 0;
    }

    private void Start()
    {
        switch (inputData.inputType)
        {
            case InputType.KEYBOARD:
                StartCoroutine(nameof(ReadKeyboardInputs));
                break;
        }
    }

    public void B_HandleButton(float value)
    {
        inputData.horizontalInputs = value;
    }

    private IEnumerator ReadKeyboardInputs()
    {
        while (true)
        {
            inputData.horizontalInputs = Input.GetAxisRaw("Horizontal");
            yield return null;  
        }
    }
}

