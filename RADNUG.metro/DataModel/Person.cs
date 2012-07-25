using RADNUG.metro.Common;

namespace RADNUG.metro.DataModel
{
    public class Person : BindableBase
    {
        #region Properties
        private string firstName = string.Empty;
        public string FirstName
        {
            get { return firstName; }
            set { this.SetProperty(ref firstName, value); }
        }

        private string lastName = string.Empty;
        public string LastName
        {
            get { return lastName; }
            set { this.SetProperty(ref lastName, value); }
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