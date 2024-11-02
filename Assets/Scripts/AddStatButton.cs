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

    // Пример обновления условия в Update()
    void Update()
    {
        // Доступ к карточке 1 из GameVariable
        isConditionMet = GameVariable.cardActive1; 

        UpdateButtonState();
    }
}