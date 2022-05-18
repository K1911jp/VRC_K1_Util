
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;
namespace K1911jp {
    public class K1_DebugCube : UdonSharpBehaviour {
        [SerializeField] private GameObject objModel;
        public override void Interact() {
            Debug.Log("Hello VRChat World");
            objModel.SetActive(!objModel.activeSelf);
        }
    }
}