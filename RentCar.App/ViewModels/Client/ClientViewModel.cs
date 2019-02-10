using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using RentCar.App.RentCarDbContextDataModel;
using RentCar.App.Common;
using RentCar.DataModel.Entities;

namespace RentCar.App.ViewModels {

    /// <summary>
    /// Represents the single Client object view model.
    /// </summary>
    public partial class ClientViewModel : SingleObjectViewModel<Client, int, IRentCarDbContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of ClientViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static ClientViewModel Create(IUnitOfWorkFactory<IRentCarDbContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new ClientViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the ClientViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the ClientViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected ClientViewModel(IUnitOfWorkFactory<IRentCarDbContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Clients, x => x.Name) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of ClientPreferredContactMediums for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<ClientPreferredContactMedium> LookUpClientPreferredContactMediums {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (ClientViewModel x) => x.LookUpClientPreferredContactMediums,
                    getRepositoryFunc: x => x.ClientPreferredContactMediums);
            }
        }


        /// <summary>
        /// The view model for the ClientClientPreferredContactMediums detail collection.
        /// </summary>
        public CollectionViewModelBase<ClientPreferredContactMedium, ClientPreferredContactMedium, int, IRentCarDbContextUnitOfWork> ClientClientPreferredContactMediumsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (ClientViewModel x) => x.ClientClientPreferredContactMediumsDetails,
                    getRepositoryFunc: x => x.ClientPreferredContactMediums,
                    foreignKeyExpression: x => x.ClientId,
                    navigationExpression: x => x.Client);
            }
        }
    }
}
