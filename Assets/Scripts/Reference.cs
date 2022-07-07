using UnityEngine;
using UnityEngine.UI;

namespace Labirint
{
    public sealed class Reference
    {
        private Button _restartButton;
        private Text _endLevelLabel;
 
        public Button RestartButton
        {
            get
            {
                if (_restartButton == null)
                {
                    var canvas = GameObject.Find("Canvas");
                    var gameObject = Resources.Load<Button>("UI/RestartButton");
                    _restartButton = Object.Instantiate(gameObject, new Vector3(Screen.width/2, Screen.height/4, 0), Quaternion.identity, canvas.transform);
                }
                return _restartButton;
            }
        }

        public Text EndLevellabel
        {
            get
            {
                if (_endLevelLabel == null)
                {
                    var canvas = GameObject.Find("Canvas");
                    var gameObject = Resources.Load<Text>("UI/EndLevelLabel");
                    _endLevelLabel = Object.Instantiate(gameObject, new Vector3(Screen.width/2, Screen.height/2, 0), Quaternion.identity, canvas.transform);
                }
                return _endLevelLabel;
            }
        }
    }

}
