using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceExercise
{
    public class Insurance
    {
        private string species;
        public string name;
        private bool neutered;
        private double fee;
        public Insurance(string animal, string name, bool isNeutered, double payment)
        {
            this.Species = animal;
            this.name = name;
            this.Neutered = isNeutered;
            this.fee = payment;
        }

        public string Species { get => species; set => species = value; }
        public bool Neutered { get => neutered; set => neutered = value; }

        public string GetNeuteredInfo()
        {
            if (Neutered)
            {
                return "leikattu";
            }
            else
            {
                return "leikkaamaton";
            }
        }
        public override string? ToString()
        {
            return this.Species + ": " + this.name + ", " + this.GetNeuteredInfo();
        }
    }
}


