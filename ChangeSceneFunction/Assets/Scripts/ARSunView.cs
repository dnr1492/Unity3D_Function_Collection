using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ARSunView : ARView
{
    [SerializeField] Button btnBack;

    protected override void Awake()
    {
        Debug.Log(mainScene);  //호출 전 Null
        base.Awake();
        Debug.Log(mainScene);  //호출 후 OK

        if (btnBack != null) btnBack.onClick.AddListener(() =>
        {
            ChanageToMainScene();
        });
    }

    /// <summary>
    /// Main씬으로 전환 (Unload)
    /// </summary>
    private void ChanageToMainScene()
    {
        mainScene.GetComponentInChildren<Canvas>(true).gameObject.SetActive(true);

        SceneManager.UnloadSceneAsync("ARScene");
    }
}
