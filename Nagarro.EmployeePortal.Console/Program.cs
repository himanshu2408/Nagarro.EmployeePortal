using Nagarro.EmployeePortal.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nagarro.EmployeePortal.ConsoleApp
{
    public class Program
    {
        static void Main(String[] args)
        {
            ISampleFacade sampleFacade = (ISampleFacade)FacadeFactory.Instance.Create(FacadeType.SampleFacade);
            ISampleDTO sampleDTO = (ISampleDTO)DTOFactory.Instance.Create(DTOType.SampleDTO);
            sampleDTO.SampleProperty = "Hi";
            OperationResult<ISampleDTO> result = sampleFacade.SampleMethod(sampleDTO);
            if(result.IsValid())
            {
                Console.WriteLine("Completed");
                Console.WriteLine(result.Data.SampleProperty);
            }
            else
            {
                Console.WriteLine("Failure");
            }
            Console.ReadLine();
        }
    }
}
