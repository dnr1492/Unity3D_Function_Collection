using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ThumnailView : MonoBehaviour
{
    public Image thumnailImg;
    public Button screenBtn, resetBtn, saveBtn;

    private void Awake()
    {
        saveBtn.onClick.AddListener(() =>
        {
            Debug.LogFormat("ÀúÀå");
        });
        resetBtn.onClick.AddListener(() =>
        {
            thumnailImg.sprite = null;
        });
        screenBtn.onClick.AddListener(() =>
        {
            StartCoroutine(ScreenshotRoutine());
        });
    }

    /// <summary>
    /// ½ºÅ©¸°¼¦ Âï±â
    /// </summary>
    /// <returns></returns>
    private IEnumerator ScreenshotRoutine()
    {
        if (thumnailImg.sprite != null) yield break;
        yield return new WaitForEndOfFrame();
        Texture2D tex = ScreenCapture.CaptureScreenshotAsTexture();
        Sprite sp = Sprite.Create(tex, new Rect(0, 0, tex.width, tex.height), new Vector2(0.5f, 0.5f));
        thumnailImg.sprite = sp;
    }
}
