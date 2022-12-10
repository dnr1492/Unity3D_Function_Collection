using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ARSunView : ARView
{
    [SerializeField] Button btnBack;

    protected override void Awake()
    {
        Debug.Log(mainScene);  //ȣ�� �� Null
        base.Awake();
        Debug.Log(mainScene);  //ȣ�� �� OK

        if (btnBack != null) btnBack.onClick.AddListener(() =>
        {
            ChanageToMainScene();
        });
    }

    /// <summary>
    /// Main������ ��ȯ (Unload)
    /// </summary>
    private void ChanageToMainScene()
    {
        mainScene.GetComponentInChildren<Canvas>(true).gameObject.SetActive(true);

        SceneManager.UnloadSceneAsync("ARScene");
    }
}
