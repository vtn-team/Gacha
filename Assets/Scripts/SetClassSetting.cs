using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

class SetClassSetting : MonoBehaviour
{
    [SerializeField] NotionSetting _setting;

    public void Set()
    {
        SettingReferer.Instance.Setting = _setting;
        SceneManager.LoadScene(1);
    }
}
