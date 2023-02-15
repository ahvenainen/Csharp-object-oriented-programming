using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceExercise
{

    public class InsuranceManager
    {

        private List<Insurance> insurances = new List<Insurance>();

        internal void AddInsurance(string animal, string name, bool isNeutered)
        {
            insurances.Add(new Insurance(animal, name, isNeutered, GetFee(animal, isNeutered)));
        }

        internal double GetFee(string species, bool isNeutererd)
        {
            //• Leikattu koira maksaa 50 €
            //• Leikkaamaton koira maksaa 80 €
            //• Leikattu kissa maksaa 40 €
            //• Leikkaamaton kissa maksaa 60 €
            //• Lintu tai matelija ei maksa mitään
            if (species == "koira" && isNeutererd == true)
            {
                return 50;
            }
            else if (species == "koira" && isNeutererd == false)
            {
                return 80;
            }
            else if (species == "kissa" && isNeutererd == true)
            {
                return 40;
            }
            else if (species == "kissa" && isNeutererd == false)
            {
                return 60;
            }
            else
                return 0;
        }

        internal void PrintInsurances()
        {
            foreach(Insurance i in insurances) 
            {
                Console.WriteLine(i);
            }
        }
        internal void FindInsurances(string species, bool isNeutered)
        {
            foreach(Insurance x in insurances) 
            {
                if (x.Species == species && x.Neutered == isNeutered)
                {
                    Console.WriteLine(species + ": "+ x.name + ", vakuutusmaksu " + GetFee(species, isNeutered) + "€");
                }
            }
        }
    }
}
