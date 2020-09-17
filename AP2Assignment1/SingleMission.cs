using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Name: Naveh Marchoom
 * ID: 312275746
 * Group: 89-211-06
 */
namespace Excercise_1
{
    /// <summary>
    /// class <c>SingleMission</c> implementing the <c>IMission</c> interface,
    /// represents a mission that contains a single real function.
    /// Provides a method for calculating set function with given value.
    /// </summary>
    public class SingleMission : IMission
    {
        public Mission Function { get; }
        public string Name { get; }
        public string Type { get; }
        public event EventHandler<double> OnCalculate;

        /// <summary>
        /// Initialize a new instance of <c>SingleMission</c> with given name and mission.
        /// </summary>
        /// <param name="function">An unary function, which recieve a <c>double</c> and return a <c>double</c>.</param>
        /// <param name="name">A string representing the mission's name.</param>
        public SingleMission(Mission function, string name)
        {
            Name = name;
            Function = function;
            Type = "Single";
        }

        /// <summary>
        /// Calculate the <c>SingleMission</c> invoking the set mission with given <c>value</c>.
        /// </summary>
        /// <param name="value">A <c>double</c> which will be used as input for the calculation.</param>
        /// <returns>A <c>double</c> which represents the result of the calculation.</returns>
        public double Calculate(double value)
        {
            double result = Function.Invoke(value);
            if (OnCalculate != null)
            {
                OnCalculate.Invoke(this, result);
            }
            return result;
        }
    }
}
