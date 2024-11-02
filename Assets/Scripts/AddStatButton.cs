using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    public bool isConditionMet;
    private Button button;

    void Start()
    {
        button = GetComponent<Button>();
        isConditionMet = false; 
        UpdateButtonState();
    }

    void UpdateButtonState()
    {
        button.interactable = isConditionMet;
    }

    // ������ ���������� ������� � Update()
    void Update()
    {
        // ������ � �������� 1 �� GameVariable
        isConditionMet = GameVariable.cardActive1; 

        UpdateButtonState();
    }
}