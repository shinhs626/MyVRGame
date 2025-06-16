using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

namespace MyVRGame
{
    public class XrGrabInteractableTwoAttach : XRGrabInteractable
    {
        #region Variables
        public Transform leftAttachTransform;
        public Transform rightAttachTransform;
        #endregion

        #region Unity Event Method
        protected override void OnSelectEntered(SelectEnterEventArgs args)
        {
            //Attack Point ¼ÂÆÃ
            if (args.interactorObject.transform.CompareTag("LeftHand"))
            {
                attachTransform = leftAttachTransform;
            }
            else if (args.interactorObject.transform.CompareTag("RightHand"))
            {
                attachTransform = rightAttachTransform;
            }

                base.OnSelectEntered(args);
        }
        #endregion
    }

}
