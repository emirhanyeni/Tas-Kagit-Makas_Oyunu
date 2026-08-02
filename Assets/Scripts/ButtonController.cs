using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour 
{
    [SerializeField] private Image image;
    private ElementController _contoller;

    public void PopuLate(ElementController controller)
    {
        _contoller = controller;
        image.sprite = controller.MySprite;
    }

    public void OnClick()
    {
        if (GameManager.Instance == null)
        {
            Debug.LogWarning("ButtonController.OnClick: GameManager.Instance null");
            return;
        }

        if (_contoller == null)
        {
            Debug.LogWarning("ButtonController.OnClick: button için controller atanmadı");
            return;
        }

        GameManager.Instance.SelectElement(_contoller);
        GameManager.Instance.RandomEnemy();
        GameManager.Instance.Battle();
    }
}