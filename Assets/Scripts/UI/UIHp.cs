using System;
using UnityEngine;
using UnityEngine.UI;

namespace Labirint
{
    public class UIHp 
    {
        public void UpdateUIHp()
        {
            GameObject _player = GameObject.FindGameObjectWithTag("Player");
            GameObject _goHpBar = GameObject.Find("HpBar");
            var systemHp = _player.GetComponent<SystemHp>();
            var _hpBar = _goHpBar.GetComponent<Image>();
            try
            {
                _hpBar.fillAmount = systemHp.Hp / systemHp.MaxHp;
            }
            catch (Exception exc)
            {
                Debug.Log(exc);
            }
        }
    }

}
