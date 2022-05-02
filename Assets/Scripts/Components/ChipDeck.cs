using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PokerBattleField
{
    public class ChipDeck : MonoBehaviour
    {
        [SerializeField]
        private int _1ChipCount = 1000;

        [SerializeField]
        private int _5ChipCount = 200;

        [SerializeField]
        private int _10ChipCount = 100;

        [SerializeField]
        private int _50ChipCount = 20;

        [SerializeField]
        private int _100ChipCount = 12;

        [SerializeField]
        private int _500ChipCount = 6;
    }
}
