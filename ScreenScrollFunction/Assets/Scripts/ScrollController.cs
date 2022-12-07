using UnityEngine;
using UnityEngine.UI;

public class ScrollController : MonoBehaviour
{
    [SerializeField] ScrollRect scrollRect;  //스크롤
    [SerializeField] Button btnLock;  //잠금 버튼
    [SerializeField] Image imgLock;  //잠금 화면 이미지

    private void Awake()
    {
        //스크롤 잠금 또는 잠금 해제
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
    /// 스크롤 잠금
    /// </summary>
    private void ScrollLock()
    {
        if (scrollRect == null) return;
        scrollRect.vertical = false;
        if (imgLock == null) return;
        imgLock.gameObject.SetActive(true);
    }

    /// <summary>
    /// 스크롤 잠금 해제
    /// </summary>
    private void ScrollUnlLock()
    {
        if (scrollRect == null) return;
        scrollRect.vertical = true;
        if (imgLock == null) return;
        imgLock.gameObject.SetActive(false);
    }
}