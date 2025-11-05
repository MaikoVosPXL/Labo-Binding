using System.ComponentModel;

namespace ActorsApplication.Data
{
    public class Actor : INotifyPropertyChanged
    {
        private string _lastName = "";
        private string _firstName = "";

        public string LastName { get => _lastName; 
            set 
            {
                _lastName = value;
                RaisePropertyChanged(nameof(LastName));
                RaisePropertyChanged(nameof(FullName));
            } }

        public string FirstName { get => _firstName; 
            set
            {
                _firstName = value;
                RaisePropertyChanged(nameof(FirstName));
                RaisePropertyChanged(nameof(FullName));
            }
        }
        public string FullName { get
            {
                return FirstName + " " + LastName;
            }
        }


        public string ProfilePicture { get; set; } = "";
        public int BirthYear { get; set; } = 1950;

        public string ShortBio { get; set; } = "";

        public event PropertyChangedEventHandler? PropertyChanged;

        private void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
