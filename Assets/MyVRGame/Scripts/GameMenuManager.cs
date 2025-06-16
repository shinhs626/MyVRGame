using UnityEngine;
using UnityEngine.InputSystem;

namespace MyVRGame
{
    public class GameMenuManager : MonoBehaviour
    {
        #region Varibles
        public GameObject gameMenu;
        public InputActionProperty gameMenuButton;
        #endregion

        #region Unity Event Method
        private void Update()
        {
            if (gameMenuButton.action.WasPressedThisFrame())
            {
                gameMenu.SetActive(true);
                Debug.Log("==========�޴� ��ư�� ���ȴ�");
            }
        }
        #endregion

        #region Custom Method

        #endregion
    }

}
