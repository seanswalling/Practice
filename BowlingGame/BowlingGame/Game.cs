using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGame
{
    class Game
    {
        private int[] Rolls = new int[21];
        private int CurrentRoll = 0;
        public void Roll(int pins)
        {
            Rolls[CurrentRoll++] = pins;
        }

        public int Score()
        {
            int Score = 0;
            int FrameIndex = 0;
            for (int Frame = 0; Frame < 10; Frame++)
            {
                if (IsStrike(FrameIndex)) //Strike
                {
                    Score += 10 + StrikeBonus(FrameIndex);
                    FrameIndex++;
                }
                else if (IsSpare(FrameIndex))
                {
                    Score += 10 + SpareBonus(FrameIndex);
                    FrameIndex += 2;
                }
                else
                {
                    Score += SumOfBallsInFrame(FrameIndex);
                    FrameIndex += 2;
                }
            }
            return Score;
        }

        private int SumOfBallsInFrame(int frameIndex)
        {
            return Rolls[frameIndex] + Rolls[frameIndex + 1];
        }

        private int SpareBonus(int frameIndex)
        {
            return Rolls[frameIndex + 2];
        }

        private int StrikeBonus(int frameIndex)
        {
            return Rolls[frameIndex + 1] + Rolls[frameIndex + 2];
        }
        private Boolean IsSpare(int frameIndex)
        {
            return Rolls[frameIndex] + Rolls[frameIndex + 1] == 10;
        }

        private Boolean IsStrike(int frameIndex)
        {
            return Rolls[frameIndex] == 10;
        }
    }
}
