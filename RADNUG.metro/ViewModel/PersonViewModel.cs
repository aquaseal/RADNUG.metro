using GalaSoft.MvvmLight;

namespace RADNUG.metro.ViewModel
{

    public class PersonViewModel : ViewModelBase
    {
        //TODO: update code snippets to use [CallMemberName] instead of the hardcoded string


        /// <summary>
        /// The <see cref="FirstName" /> property's name.
        /// </summary>
        public const string FirstNamePropertyName = "FirstName";

        private string firstName = string.Empty;

        /// <summary>
        /// Sets and gets the FirstName property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                if (firstName == value)
                {
                    return;
                }

                RaisePropertyChanging(FirstNamePropertyName);
                firstName = value;
                RaisePropertyChanged(FirstNamePropertyName);
            }
        }

        public PersonViewModel()
        {
        }

    }
}