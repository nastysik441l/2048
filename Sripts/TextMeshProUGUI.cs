using UnityEngine;
using TMPro;

public class MyScript : MonoBehaviour
{
    public TextMeshProUGUI textMeshProUGUI;

    void Start()
    {
        // Установка текста через скрипт
        textMeshProUGUI.text = "Пример текста";
    }
}
