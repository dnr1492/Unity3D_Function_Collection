using UnityEngine;
using UnityEngine.UI;

public class ScrollController : MonoBehaviour
{
    [SerializeField] ScrollRect scrollRect;  //��ũ��
    [SerializeField] Button btnLock;  //��� ��ư
    [SerializeField] Image imgLock;  //��� ȭ�� �̹���

    private void Awake()
    {
        //��ũ�� ��� �Ǵ� ��� ����
        if (btnLock != null) btnLock.onClick.AddListener(() => {
            if (imgLock.gameObject.activeSelf) ScrollUnlLock();
            else ScrollLock();
        });
    }

    private void Start()
    {
        imgLock.gameObject.SetActive(false);
    }

    /// <summary>
    /// ��ũ�� ���
    /// </summary>
    private void ScrollLock()
    {
        if (scrollRect == null) return;
        scrollRect.vertical = false;
        if (imgLock == null) return;
        imgLock.gameObject.SetActive(true);
    }

    /// <summary>
    /// ��ũ�� ��� ����
    /// </summary>
    private void ScrollUnlLock()
    {
        if (scrollRect == null) return;
        scrollRect.vertical = true;
        if (imgLock == null) return;
        imgLock.gameObject.SetActive(false);
    }
}