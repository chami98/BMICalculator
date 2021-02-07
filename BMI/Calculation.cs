using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI
{
    class Calculation
    {
        public double calculateBmi(double weight, double height)
        {
            double bmi = (weight) / (height * height);
            return bmi;
        }

        public string bmiState(double bmi)
        {
            String bmiState = "";

            if (bmi>30)
            {
                bmiState = "Obese";
            }
            else if (bmi>25 && 30>bmi)
            {
                bmiState = "Over Weight";
            }
            else if (bmi>18.5 && 25>bmi)
            {
                bmiState = "Normal";
            }
            else if (bmi<18.5)
            {
                bmiState = "Under Weight";
            }
            return bmiState;
        }

        public string bmiCondition(string bmiState)
        {
            String bmiCondition = "";
            if (bmiState == "Normal")
            {
                bmiCondition = "Your condition is normal";
            }
            else
            {
                bmiCondition = "Be aware of your condition";
            }
            return bmiCondition;
        }
    }
}
