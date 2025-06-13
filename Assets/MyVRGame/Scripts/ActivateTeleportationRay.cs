using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

namespace MyVRGame
{
    public class ActivateTeleportationRay : MonoBehaviour
    {
        #region Variables
        public GameObject leftTeleportation;
        public GameObject rightTeleportation;

        //��Ƽ�� ��ǲ��
        public InputActionProperty leftActivate;
        public InputActionProperty rightActivate;
        #endregion

        #region Unity Event Method
        private void Update()
        {
            //��ǲ�� �о����
            float leftValue = leftActivate.action.ReadValue<float>();
            float rightValue = rightActivate.action.ReadValue<float>();

            //��ǲ���� ������ Ȱ��ȭ ��Ų��
            leftTeleportation.SetActive(leftValue > 0.1f);
            rightTeleportation.SetActive(rightValue > 0.1f);
        }
        #endregion

        #region Custom Method

        #endregion
    }

}
