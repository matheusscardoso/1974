using System;

namespace BaltaStore.Domain.StoreContext
{
    public class Customer
    {

        #region Propriedades
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public decimal Salary { get; set; }
        #endregion


        #region Metodos
        public void Register() { }
        #endregion

        #region Eventos
        public void AoRegistrar() { }
        #endregion
    }

    public interface IPerson
    {
        string Name { get; set; }
        DateTime BirthDate { get; set; }


        void OnRegister();

    }

    interface IEmployee
    {
        decimal Salary { get; set; }
    }

    public class CustomerComInterface : IPerson, IEmployee
    {
        public decimal Salary
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public string Name
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public DateTime BirthDate
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        void IPerson.OnRegister()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}