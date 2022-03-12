using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul3_1302200012_2_
{
    internal class PosisiKarakterGame
    {
        //1302200012 % 3 == 2

        public enum State { Jongkok, Berdiri, Tengkurap, Terbang }
        public enum Trigger { TombolW, TombolS, TombolX }

        public State currentState = State.Berdiri;

        public class Transition
        {
            public State prevState, nextState;
            public Trigger trigger;

            public Transition(State prevState, State nextState, Trigger trigger)
            {
                this.prevState = prevState;
                this.nextState = nextState;
                this.trigger = trigger;
            }
        }

        Transition[] teabag =
        {
            new Transition(State.Jongkok, State.Tengkurap, Trigger.TombolS),
            new Transition(State.Tengkurap, State.Jongkok, Trigger.TombolW),

            new Transition(State.Jongkok, State.Berdiri, Trigger.TombolW),
            new Transition(State.Berdiri, State.Jongkok, Trigger.TombolS),

            new Transition(State.Berdiri, State.Terbang, Trigger.TombolW),
            new Transition(State.Terbang, State.Berdiri, Trigger.TombolS),

            new Transition(State.Terbang, State.Jongkok, Trigger.TombolX),
        };

        public State GetNextState(State prev, Trigger trigger)
        {
            State currentState = prev;

            for (int i = 0; i < teabag.Length; i++)
            {
                if (teabag[i].prevState == prev && teabag[i].trigger == trigger)
                {
                    currentState = teabag[i].nextState;
                }
            }

            return currentState;
        }

        public void activeTrigger(Trigger trigger)
        {
            State nextState = GetNextState(currentState, trigger);
            currentState = nextState;

            if (currentState == State.Terbang)
            {
                Console.WriteLine("Posisi Take Off");
            }
            else if (currentState == State.Jongkok)
            {
                Console.WriteLine("Posisi Landing");
            }

        }

    }
}
