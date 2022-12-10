using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainView : MonoBehaviour
{
    [SerializeField] Button btnAR;

    protected virtual void Awake()
    {
        if (btnAR != null) btnAR.onClick.AddListener(() =>
        {
            ChangeToARScene();
        });
    }

    /// <summary>
    /// AR������ ��ȯ (Additive)
    /// </summary>
    private void ChangeToARScene()
    {
        MainScene mainScene = GetComponentInParent<MainScene>();
        mainScene.GetComponentInChildren<Canvas>().gameObject.SetActive(false);

        SceneManager.LoadSceneAsync("ARScene", LoadSceneMode.Additive);
    }
}
