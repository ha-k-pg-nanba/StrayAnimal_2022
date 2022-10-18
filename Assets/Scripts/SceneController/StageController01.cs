using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageController01 : MonoBehaviour
{
    public void OnClickStageButton01()
    {
        SceneManager.LoadScene("Stage01");
    }
}
