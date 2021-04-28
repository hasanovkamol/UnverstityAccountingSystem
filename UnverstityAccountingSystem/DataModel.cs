using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace UnverstityAccountingSystem
{
    public class DataModel : INotifyPropertyChanged
    {
        private bool m_HasChanges;
        [NotMapped]
        public bool HasChanges
        {
            get { return m_HasChanges; }
            set
            {
                if (m_HasChanges != value)
                {
                    m_HasChanges = value;
                    OnPropertyChanged(nameof(HasChanges));
                }
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

        protected virtual TValue GetValue<TValue>(string propertyName, TValue property)
        {
            return property;
        }

        protected virtual TValue SetValue<TValue>(string propertyName, ref TValue propertyRef, TValue value)
        {
            if (!object.Equals(propertyRef, value))
            {
                propertyRef = value;
                OnPropertyChanged(propertyName);

                HasChanges = true;
            }
            return propertyRef;
        }
        public virtual void ApplyChanges()
        {
            GloblMain.dbo.SaveChanges();
            HasChanges = false;
        }
    }
}
