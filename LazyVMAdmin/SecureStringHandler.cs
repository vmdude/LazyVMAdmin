using System;
using System.Security;

namespace LazyVMAdmin
{
    /// <summary>
    /// Class for handling Secure String type
    /// Used for storing password in a secure way
    /// </summary>
    public partial class SecureStringHandler
    {
        /// <summary>
        /// Constructor for Secure String handling class
        /// </summary>
        public SecureStringHandler() { }

        /// <summary>
        /// String to SecureString
        /// Allow convertion of string input into SecureString output
        /// </summary>
        /// <remarks>
        /// See <a href="http://msdn.microsoft.com/en-us/library/7y8s44by.aspx">http://msdn.microsoft.com/en-us/library/7y8s44by.aspx</a>
        /// </remarks>
        /// <param name="str2convert">String that will be converted into SecureString type</param>
        /// <returns>String converted into SecureString type</returns>
        public SecureString String2SecureString(string str2convert)
        {
            string initString = str2convert;
            SecureString PwdSecString = new SecureString();

            foreach (char ch in initString)
                PwdSecString.AppendChar(ch);

            return PwdSecString;
        }
    }
}
