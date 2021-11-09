using System;
using System.DirectoryServices.AccountManagement;

namespace LazyVMAdmin
{
    /// <summary>
    /// Class managing Microsoft Active directory interaction
    /// </summary>
    public partial class ActiveDirectory
    {
        /// <summary>
        /// Constructor for Active Directory class
        /// </summary>
        public ActiveDirectory() {}

        /// <summary>
        /// Function that will use security context in order to validate credentials supplied by user
        /// </summary>
        /// <param name="domain">String that define the Active Directory user domain</param>
        /// <param name="username">String that define the Active Directory user name</param>
        /// <param name="password">String that define the Active Directory user password and will be secure into SecureString later</param>
        /// <returns>Return bool that define if user/password are valid in Active Directory</returns>
        public Boolean ValidateUser(string domain, string username, string password)
        {
            try
            {
                PrincipalContext pc = new PrincipalContext(ContextType.Domain, domain);
                // validate the credentials
                return pc.ValidateCredentials(username, password);
            }
            catch (Exception)
            { 
                return false;
            }
        }
    }
}
