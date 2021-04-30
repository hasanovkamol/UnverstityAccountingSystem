using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace UnverstityAccountingSystem
{
    public class DataModel : INotifyPropertyChanged
    {
       
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
            }
            return propertyRef;
        }
        public virtual void ApplyChanges()
        {
            GloblMain.dbo.SaveChanges();
        }
    }
}
