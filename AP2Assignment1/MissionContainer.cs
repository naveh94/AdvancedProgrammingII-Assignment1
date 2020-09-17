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
    /// class <c>FunctionsContainer</c> represets a dictionary with <c>string</c> keys and <c>Mission</c> values.
    /// Provide methods for adding and getting values through bracket indexing, and for getting a list of the function names.
    /// </summary>
    public class FunctionsContainer
    {
        private Dictionary<string, Mission> functions;
        
        /// <summary>
        /// Initialize a new instance of <c>FunctionsContainer</c>.
        /// </summary>
        public FunctionsContainer()
        {
            functions = new Dictionary<string, Mission>();
        }

        /// <summary>
        /// Get or set a <c>Mission</c> associated with given <c>string index</c>.
        /// </summary>
        /// <param name="index">A <c>string</c> representing a key for the value for get or set.</param>
        /// <returns>
        /// A <c>Mission</c> associated with given <c>index</c>. 
        /// If specific <c>index</c> is not found, will add <c>index</c> associated with the default <c>var => var</c> function.
        /// </returns>
        public Mission this [ string index ]
        {
            get
            {
                if (!functions.ContainsKey(index))
                {
                    functions.Add(index, val => val);
                }
                return functions[index];
            }
            
            set
            {
                functions[index] = value;
            }
        }

        /// <summary>
        /// A method that return a <c>List</c> of <c>string</c>s representing the names of all the functions in the container.
        /// </summary>
        /// <returns>Returns a <c>List</c> of <c>string</c>s.</returns>
        public List<string> getAllMissions()
        {
            List<string> missionNames = new List<string>();
            foreach (string name in functions.Keys)
            {
                missionNames.Add(name);
            }
            return missionNames;
        }
    }
}
