using UnityEngine;
using UnityEditor;
public class Trandition : MonoBehaviour
{
    [MenuItem("PBTB/Gen_Trandition")]
    static void createDBT()
    {
        var bb = new PBlendTreeBuilder("Assets/Pan/FlatExpansion/Trandition");
        bb.rootDBT(() => {
            bb.add1D("1", "MODE", () =>{
                bb.addMotion(0, "State0");
                bb.addMotion(1, "Trandition01");
                bb.addMotion(2, "State1");
                bb.addMotion(3, "Trandition10");
            });
            bb.add1D("1", "T0Fin", () =>{
                bb.add1D(0f, "T1Fin", () => {
                    bb.add1D(0f, "SWITCH", () => {
                        bb.add1D(0f, "MODE", () => {
                            bb.addMotion(0f, "MODE0");
                            bb.addMotion(1f, "MODE1");
                            bb.addMotion(2f, "MODE3");
                            bb.addMotion(3f, "MODE3");
                        });
                        bb.add1D(1f, "MODE", () => {
                            bb.addMotion(0f, "MODE1");
                            bb.addMotion(1f, "MODE1");
                            bb.addMotion(2f, "MODE2");
                            bb.addMotion(3f, "MODE3");
                        });
                    });
                    bb.addMotion(1f, "MODE0");
                });
                bb.addMotion(1f, "MODE2");
            });
        });
        bb.animatorMake();
    }
}