using System;
using System.Collections.Generic;
using System.Text;

namespace DndApp.Models
{
    public class RollGenerator
    {
        // d4, d6, d8, d10, d12, d20, d100
        //die = max number sides

        Random random = new Random();
        int rollResult;

        public int D20 { get; set; } = 20;
        public int D12 { get; set; } = 12;
        public int D10 { get; set; } = 10;
        public int D8 { get; set; } = 8;
        public int D6 { get; set; } = 6;
        public int D4 { get; set; } = 4;
        public int D3 { get; set; } = 3;
        public int D2 { get; set; } = 2;
        public int D100 { get; set; } = 100;


        //d2-d20, d100 || multiple dice of same side
        //MaxValue, numberOfDice = UI
        public int RollGen(int MaxValue,int numberOfDice)
        {
            for (int i = 1; i <= numberOfDice; i++)
            {
                if (numberOfDice == 1)
                {
                    rollResult = random.Next(1, MaxValue + 1);
                }
                if (numberOfDice > 1)
                {
                    int temp = random.Next(1, MaxValue + 1);
                    rollResult += temp;
                }
            }
            return rollResult;
        }

        //traditionally 1d3 caluclated by roll d6 / 2 result Round up
        //the above has resulted in countless debates
        //my solution to debate:
        public int OneDThree()
        {
            rollResult = random.Next(1, 4);
            return rollResult;
        }

        //Traditional approach to rolling 1d2
        //1d2 calculated by rolling n sided die/ if roll is even, result = 2, if roll is odd, result = 1
        //Alternatively if roll > n sides/2, roll == 2
        public int OneDTwo()
        {
            int MaxValue = 10;
            rollResult = random.Next(MaxValue);
            if (rollResult > (MaxValue / 2))
            {
                rollResult = 2;
            }
            else if (rollResult % 2 == 1)
            {
                rollResult = 1;
            }
            else if (rollResult % 2 == 0) //accounts for 0
            {
                rollResult = 2;
            }
            return rollResult;
        }
        

        //Percentile dice or d100 traditionally rolled using two 10-sided die numbered 0-9,
        //one die representing the tens place and the other die representing the ones place
        //if both die == 0, the roll == 100
        public int D100RollGen()
        {  
            int tensPlace = 9;
            int onesPlace = 9;
            tensPlace = random.Next(tensPlace); 
            onesPlace = random.Next(onesPlace);
            if (tensPlace == 0 && onesPlace == 0)
            {
                rollResult = 100;
            }
            else if (tensPlace == 0 && onesPlace != 0)
            {
                rollResult = onesPlace;
            }
            else
            {
                rollResult = tensPlace * 10 + onesPlace;
            }
            return rollResult;
        } 
    }
}
