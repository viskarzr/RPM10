using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPM10
{
    public abstract class Zoo
    {
        public string Name { get; set; }
        public int Age { get; set; } // сделать ограничение по возрасту и весу
        public double Weight { get; set; }

        public abstract string Animals { get; }
        public abstract void UpdateAnimals(string name, int age, double weight);

        public override string ToString()
        {
            return $"{Animals}: {Name}, возраст: {Age}, вес: {Weight}.";
        }
    }

    public class Mammals : Zoo
    {
        public override string Animals
        {
            get { return "Mлекопитающее"; }
        }

        public override void UpdateAnimals(string name, int age, double weight)
        {
            Name = name;
            Age = age;
            Weight = weight;
        }

    }

    public class Artiodactyls : Zoo
    {
        public override string Animals
        {
            get { return "Парнокопытное"; }
        }

        public override void UpdateAnimals(string name, int age, double weight)
        {
            Name = name;
            Age = age;
            Weight = weight;
        }
    }

    public class Birds:Zoo
    {
        public override string Animals
        {
            get { return "Птица"; }
        }

        public override void UpdateAnimals(string name, int age, double weight)
        {
            Name = name;
            Age = age;
            Weight = weight;
        }

    }

}
    

