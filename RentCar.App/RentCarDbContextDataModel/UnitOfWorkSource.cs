using DevExpress.Mvvm;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.DataModel.DesignTime;
using DevExpress.Mvvm.DataModel.EF6;
using RentCar.DataModel.Context;
using System;
using System.Collections;
using System.Linq;

namespace RentCar.App.RentCarDbContextDataModel {

    /// <summary>
    /// Provides methods to obtain the relevant IUnitOfWorkFactory.
    /// </summary>
    public static class UnitOfWorkSource {

		/// <summary>
        /// Returns the IUnitOfWorkFactory implementation.
        /// </summary>
        public static IUnitOfWorkFactory<IRentCarDbContextUnitOfWork> GetUnitOfWorkFactory() {
            return new DbUnitOfWorkFactory<IRentCarDbContextUnitOfWork>(() => new RentCarDbContextUnitOfWork(() => new RentCarDbContext()));
        }
    }
}