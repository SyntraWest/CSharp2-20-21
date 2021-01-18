using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatesVoorbeeld
{
    class Loopwedstrijd
    {
        public string Deelnemer { get; }

        public event EventHandler Gestart;

        public event EventHandler Gefinisht;

        public event EventHandler Opgegeven;


        public Loopwedstrijd(string naam)
        {
            Deelnemer = naam;
        }

        public void Start()
        {
            // starten met iets

            Gestart?.Invoke(this, EventArgs.Empty);
        }


        public void Finish()
        {
            Gefinisht?.Invoke(this, EventArgs.Empty);
        }

        public void GeefOp()
        {
            Opgegeven?.Invoke(this, EventArgs.Empty);
        }

    }
}
