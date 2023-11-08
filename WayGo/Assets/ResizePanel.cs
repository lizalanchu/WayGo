using UnityEngine;
using UnityEngine.UI;

public class PanelSwitcher : MonoBehaviour
{
    public GameObject openPanel; // Панель, которую вы хотите открыть
    public GameObject closePanel; // Панель, которую вы хотите закрыть

    void Start()
    {
        // Устанавливаем начальное состояние панелей
        openPanel.SetActive(false); // Панель, которую вы хотите открыть, начинается скрытой
        closePanel.SetActive(true); // Панель, которую вы хотите закрыть, начинается открытой
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Проверяем, было ли совершено нажатие мыши
        {
            // Проверяем, было ли нажатие на панель, которую вы хотите закрыть
            RectTransform closePanelRect = closePanel.GetComponent<RectTransform>();
            Vector2 localMousePosition = closePanelRect.InverseTransformPoint(Input.mousePosition);

            if (closePanelRect.rect.Contains(localMousePosition))
            {
                // Закрываем панель, которую вы хотите закрыть
                closePanel.SetActive(false);
                // Открываем панель, которую вы хотите открыть
                openPanel.SetActive(true);
            }
        }
    }
}

