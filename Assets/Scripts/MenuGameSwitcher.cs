using UnityEngine;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    public RectTransform targetPosition;
    [SerializeField] private Toggle btn;
    public float duration = 1f;

    public bool isMenuVisible = false;

    private Vector2 startPos;

    private void Start()
    {
        startPos = transform.position;
    }

    public void ToggleMenu()
    {
        btn.interactable = false;
        if (LeanTween.isTweening(gameObject))
        {
            // Якщо анімація ще не завершена, не виконувати новий виклик
            return;
        }

        if (isMenuVisible)
        {
            // Викликайте цю функцію для закриття меню
            MoveObjectSmoothly(targetPosition.position, startPos);
        }
        else
        {
            // Викликайте цю функцію для відкриття меню
            MoveObjectSmoothly(startPos, targetPosition.position);
        }

        isMenuVisible = !isMenuVisible;
    }

    private void MoveObjectSmoothly(Vector3 startPos, Vector3 targetPos)
    {
        // Використовуйте LeanTween для гладкого переміщення
        LeanTween.move(gameObject, targetPos, duration)
            .setEase(LeanTweenType.easeInOutQuad)
            .setOnComplete(() =>
            {
                // Коли анімація завершена, викликати подальші дії тут
                btn.interactable = true;
                Debug.Log("Анімація завершена");
            });
    }
}
