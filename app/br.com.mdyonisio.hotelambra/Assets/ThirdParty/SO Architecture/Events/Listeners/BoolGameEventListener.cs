using UnityEngine;

namespace ScriptableObjectArchitecture
{
    [AddComponentMenu(SOArchitecture_Utility.EVENT_LISTENER_SUBMENU + "bool Event Listener")]
    public sealed class BoolGameEventListener : BaseGameEventListener<bool, BoolGameEvent, BoolUnityEvent>
    {
        public bool invertParameter;

        protected override void RaiseResponse(bool value)
        {
            if (invertParameter)
            {
                base.RaiseResponse(!value);
            }
            else
            {
                base.RaiseResponse(value);
            }
        }

    }
}