using UnityEngine;

namespace Base
{
    public class BaseView<TController, TProperties> : MonoBehaviour, IBaseView<TController, TProperties>
    {
        public TController Controller => GetComponent<TController>();
    
        public TProperties Properties => GetComponent<TProperties>();
    }
}