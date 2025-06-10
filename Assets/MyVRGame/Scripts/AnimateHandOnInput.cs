using UnityEngine;
using UnityEngine.InputSystem;

namespace MyVRGame
{
    public class AnimateHandOnInput : MonoBehaviour
    {
        #region Variables
        //����
        private Animator animator;

        //��ǲ
        public InputActionProperty pinchAnimationAction;
        public InputActionProperty gripAnimationAction;
        #endregion

        #region Unity Event Method
        private void Start()
        {
            animator = this.GetComponent<Animator>();
        }
        private void Update()
        {
            //��ǲ�� ó��
            float triggerValue = pinchAnimationAction.action.ReadValue<float>();
            float gripValue = pinchAnimationAction.action.ReadValue<float>();

            //�ִϸ��̼�
            Debug.Log(triggerValue);
            animator.SetFloat("Trigger",triggerValue);
            animator.SetFloat("Grip", gripValue);
        }
        #endregion

        #region Custom Method

        #endregion
    }

}
