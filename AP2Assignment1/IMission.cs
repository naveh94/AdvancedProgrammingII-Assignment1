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
    /// A delegate that represents an unary function that recieve a real value and returns a real value.
    /// </summary>
    /// <param name="value">The value on which the function will be calculated on.</param>
    /// <returns>The result of the calculation.</returns>
    public delegate double Mission(double value);

    /// <summary>
    /// Represents a calculateable mission.
    /// </summary>
    public interface IMission
    {
        event EventHandler<double> OnCalculate;  // An Event of when a mission is activated

        String Name { get; }
        String Type { get; }

        double Calculate(double value);
    }
}
