using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MTDClasses
{
    /// <summary>
    /// Represents a generic Train for MTD
    /// </summary>
    public abstract class Train
    {
        private List<Domino> dominos;
        private int engValue;

        public Train()
        {
            dominos = new List<Domino>();
        }

        public Train(int engValue)
        {

        }

        /// <summary>
        /// returns count of the train list
        /// </summary>
        public int Count
        {
            get
            {
                return dominos.Count;
            }
        }

        /// <summary>
        /// The first domino value that must be played on a train
        /// </summary>
        public int EngineValue
        {
            get
            {
                if (//domino is not a double throw exception)

                        if (//domino is a double return that domino)
            }
        }

        public bool IsEmpty
        {
            get
            {
                if (dominos.Count == 0)
                {
                    return true;
                }
                else
                    return false;
            }
        }

        public Domino LastDomino
        {
            //return the last domino played
        }

        /// <summary>
        /// Side2 of the last domino in the train.  It's the value of the next domino that can be played.
        /// </summary>
        public int PlayableValue
        {

        }

        public void Add(Domino d)
        {
            dominos.Add(d);
        }

        public Domino this[int index]
        {
            get
            {
                if (index < 0 || index > dominos.Count)
                {
                    throw new ArgumentOutOfRangeException("index");
                }
                return dominos[index];
            }
            set { dominos[index] = value; }
        }

        /// <summary>
        /// Determines whether a hand can play a specific domino on this train and if the domino must be flipped.
        /// Because the rules for playing are different for Mexican and Player trains, this method is abstract.
        /// </summary>
        public abstract bool IsPlayable(Hand h, Domino d, out bool mustFlip);

        /// <summary>
        /// A helper method that determines whether a specific domino can be played on this train.
        /// It can be called in the Mexican and Player train class implementations of the abstract method
        /// </summary>
        protected bool IsPlayable(Domino d, out bool mustFlip)
        {

        }

        // assumes the domino has already been removed from the hand
        public void Play(Hand h, Domino d)
        {

        }

        public override string ToString()
        {
            if (this.IsEmpty)
            {
                return "Empty BoneYard";
            }
            string output = "";
            foreach (Domino d in dominos)
            {
                output += d.ToString() + "\n";
            }
            return output;
        }
        
    }
}