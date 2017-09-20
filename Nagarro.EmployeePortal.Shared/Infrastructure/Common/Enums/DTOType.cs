namespace Nagarro.EmployeePortal.Shared
{
    /// <summary>
    /// Data Transfer Objects
    /// </summary>
    public enum DTOType
    {

        /// <summary>
        /// Undefined DTO (Default)
        /// </summary>
        Undefined = 0,


        [QualifiedTypeName("Nagarro.EmployeePortal.DTOModel.dll", "Nagarro.EmployeePortal.DTOModel.SampleDTO")]
        SampleDTO = 1

    }
}
