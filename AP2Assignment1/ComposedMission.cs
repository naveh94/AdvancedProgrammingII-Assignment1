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
    /// class <c>ComposedMission</c> implementing the <c>IMission</c> interface,
    /// represents a mission that can contains a serie of several functions.
    /// provide methods for adding missions and for calculating accumulated missions in sequence.
    /// does not provide method for removing missions.
    /// </summary>
    public class ComposedMission : IMission
    {
        private List<Mission> functions;
        public string Name { get; private set; }
        public string Type { get; private set; }
        public event EventHandler<double> OnCalculate;

        /// <summary>
        /// Initialize a new instance of the <c>ComposedMission</c> class with given <c>name</c>, and no missions.
        /// </summary>
        /// <param name="name">The name that will be given for the <c>ComposedMission</c>.</param>
        /*Since the use example on Program.cs didn't use an ending method, 
         *I decided to make this class without the builder design patter.*/
        public ComposedMission(string name)
        {
            Name = name;
            Type = "Composed";
            functions = new List<Mission>();
        }
        
        /// <summary>
        /// Add a mission to the end of the <c>ComposedMission</c>.
        /// </summary>
        /// <param name="function">The mission that will be added to the <c>ComposedMission</c>.</param>
        /// <returns>Returns the <c>ComposedMission</c> in order to mimic the Builder Design Pattern.</returns>
        public ComposedMission Add(Mission function)
        {
            functions.Add(function);
            return this;
        }

        /// <summary>
        /// Calculate the <c>ComposedMission</c>, invoking all of the added missions sequentially
        /// with the given <c>value</c>.
        /// </summary>
        /// <param name="value">The value on which the <c>ComposedMission</c> will be calculated on.</param>
        /// <returns>Returns the result of the calculation.</returns>
        public double Calculate(double value)
        {
            double result = value;
            foreach (Mission function in functions) // Will skip if no functions were added to the mission.
            {
                result = function.Invoke(result);
            }
            if (OnCalculate != null)
            {
                OnCalculate.Invoke(this,result);
            }
            return result;
        }
    }
}
