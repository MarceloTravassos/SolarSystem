using UnityEngine;

namespace SolarSystem
{
    public class LookAtTarget : MonoBehaviour
    {
        static public Transform target;
        private void Start()
        {
            if (target != null) return;
            
            target = gameObject.transform;
            Debug.Log("Target não especificado no LookAtTarget, padronizando para o próprio objeto.");
        }

        private void Update()
        {
            if (target)
            {
                transform.LookAt(target);
            }
        }
    }
}
