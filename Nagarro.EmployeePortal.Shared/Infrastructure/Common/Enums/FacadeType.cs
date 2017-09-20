using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nagarro.EmployeePortal.Shared
{
    /// <summary>
    /// The Facade Types
    /// </summary>
    public enum FacadeType
    {
       
        /// <summary>
        /// Notice Facade
        /// </summary>
        [QualifiedTypeName("Nagarro.EmployeePortal.BusinessFacades.dll", "Nagarro.EmployeePortal.BusinessFacades.SampleFacade")]
        SampleFacade = 0

      
    }
}
