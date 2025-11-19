using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPM10
{
    public abstract class Zoo
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; } 
        public double Weight { get; set; }

        public abstract string Animals { get; }
        public abstract void UpdateAnimals(int id,string name, int age, double weight);

        public override string ToString()
        {
            return $"{Animals}:{ID} {Name}, возраст: {Age}, вес: {Weight}.";
        }
    }

    public class Mammals : Zoo
    {
        public override string Animals
        {
            get { return "Mлекопитающее"; }
        }

        public override void UpdateAnimals(int id, string name, int age, double weight)
        {
            ID = id;
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

        public override void UpdateAnimals(int id, string name, int age, double weight)
        {
            ID = id;
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

        public override void UpdateAnimals(int id, string name, int age, double weight)
        {
            ID = id;
            Name = name;
            Age = age;
            Weight = weight;
        }

    }

}
    

