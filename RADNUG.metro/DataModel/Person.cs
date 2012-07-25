using RADNUG.metro.Common;

namespace RADNUG.metro.DataModel
{
    public class Person : BindableBase
    {
        #region Properties
        private string firstName = string.Empty;
        public string FirstName
        {
            get { return this.firstName; }
            set { this.SetProperty(ref firstName, value); }
        }
        #endregion  // Properties

        #region Constructors
        public Person(string firstName)
        {
            this.firstName = firstName;
        }
        #endregion  // Constructors

    }
}