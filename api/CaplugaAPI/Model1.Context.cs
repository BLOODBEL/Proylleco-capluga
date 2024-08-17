﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CaplugaAPI
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class CAPLUGAEntities : DbContext
    {
        public CAPLUGAEntities()
            : base("name=CAPLUGAEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Addresses> Addresses { get; set; }
        public virtual DbSet<AppointmentScheduling> AppointmentScheduling { get; set; }
        public virtual DbSet<Cart> Cart { get; set; }
        public virtual DbSet<Detail> Detail { get; set; }
        public virtual DbSet<DetailCurse> DetailCurse { get; set; }
        public virtual DbSet<ErrorLogs> ErrorLogs { get; set; }
        public virtual DbSet<MasterPurchase> MasterPurchase { get; set; }
        public virtual DbSet<MasterPurchaseCurse> MasterPurchaseCurse { get; set; }
        public virtual DbSet<MedicalCourses> MedicalCourses { get; set; }
        public virtual DbSet<MedicalImplements> MedicalImplements { get; set; }
        public virtual DbSet<Registeredcourses> Registeredcourses { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<ScheduleAppointment> ScheduleAppointment { get; set; }
        public virtual DbSet<Users> Users { get; set; }
    
        public virtual int ApprovePaymentDetails(Nullable<long> masterPurchaseID)
        {
            var masterPurchaseIDParameter = masterPurchaseID.HasValue ?
                new ObjectParameter("MasterPurchaseID", masterPurchaseID) :
                new ObjectParameter("MasterPurchaseID", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ApprovePaymentDetails", masterPurchaseIDParameter);
        }
    
        public virtual int ApprovePaymentTuition(Nullable<long> masterPurchaseCurseID)
        {
            var masterPurchaseCurseIDParameter = masterPurchaseCurseID.HasValue ?
                new ObjectParameter("MasterPurchaseCurseID", masterPurchaseCurseID) :
                new ObjectParameter("MasterPurchaseCurseID", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ApprovePaymentTuition", masterPurchaseCurseIDParameter);
        }
    
        public virtual int InsertAppointment(Nullable<long> userID, Nullable<long> addressID, string name, string description, Nullable<long> scheduleID)
        {
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("UserID", userID) :
                new ObjectParameter("UserID", typeof(long));
    
            var addressIDParameter = addressID.HasValue ?
                new ObjectParameter("AddressID", addressID) :
                new ObjectParameter("AddressID", typeof(long));
    
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var descriptionParameter = description != null ?
                new ObjectParameter("Description", description) :
                new ObjectParameter("Description", typeof(string));
    
            var scheduleIDParameter = scheduleID.HasValue ?
                new ObjectParameter("ScheduleID", scheduleID) :
                new ObjectParameter("ScheduleID", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertAppointment", userIDParameter, addressIDParameter, nameParameter, descriptionParameter, scheduleIDParameter);
        }
    
        public virtual int InsertRol(string roleName)
        {
            var roleNameParameter = roleName != null ?
                new ObjectParameter("RoleName", roleName) :
                new ObjectParameter("RoleName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertRol", roleNameParameter);
        }
    
        public virtual int InsertScheduleAppointment(string dname, Nullable<System.DateTime> dateandTime)
        {
            var dnameParameter = dname != null ?
                new ObjectParameter("Dname", dname) :
                new ObjectParameter("Dname", typeof(string));
    
            var dateandTimeParameter = dateandTime.HasValue ?
                new ObjectParameter("DateandTime", dateandTime) :
                new ObjectParameter("DateandTime", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertScheduleAppointment", dnameParameter, dateandTimeParameter);
        }
    
        public virtual int PayCart(Nullable<long> userID)
        {
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("UserID", userID) :
                new ObjectParameter("UserID", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PayCart", userIDParameter);
        }
    
        public virtual int tuition(Nullable<long> userID)
        {
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("UserID", userID) :
                new ObjectParameter("UserID", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("tuition", userIDParameter);
        }
    
        public virtual int UpdateAppointment(Nullable<long> appointmentID, Nullable<long> userID, Nullable<long> addressID, string name, string description, Nullable<long> scheduleID)
        {
            var appointmentIDParameter = appointmentID.HasValue ?
                new ObjectParameter("AppointmentID", appointmentID) :
                new ObjectParameter("AppointmentID", typeof(long));
    
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("UserID", userID) :
                new ObjectParameter("UserID", typeof(long));
    
            var addressIDParameter = addressID.HasValue ?
                new ObjectParameter("AddressID", addressID) :
                new ObjectParameter("AddressID", typeof(long));
    
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var descriptionParameter = description != null ?
                new ObjectParameter("Description", description) :
                new ObjectParameter("Description", typeof(string));
    
            var scheduleIDParameter = scheduleID.HasValue ?
                new ObjectParameter("ScheduleID", scheduleID) :
                new ObjectParameter("ScheduleID", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateAppointment", appointmentIDParameter, userIDParameter, addressIDParameter, nameParameter, descriptionParameter, scheduleIDParameter);
        }
    
        public virtual int UpdateRol(Nullable<long> rolesID, string roleName)
        {
            var rolesIDParameter = rolesID.HasValue ?
                new ObjectParameter("RolesID", rolesID) :
                new ObjectParameter("RolesID", typeof(long));
    
            var roleNameParameter = roleName != null ?
                new ObjectParameter("RoleName", roleName) :
                new ObjectParameter("RoleName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateRol", rolesIDParameter, roleNameParameter);
        }
    
        public virtual int UpdateScheduleAppointment(Nullable<long> scheduleID, string dName, Nullable<System.DateTime> dateandTime)
        {
            var scheduleIDParameter = scheduleID.HasValue ?
                new ObjectParameter("ScheduleID", scheduleID) :
                new ObjectParameter("ScheduleID", typeof(long));
    
            var dNameParameter = dName != null ?
                new ObjectParameter("DName", dName) :
                new ObjectParameter("DName", typeof(string));
    
            var dateandTimeParameter = dateandTime.HasValue ?
                new ObjectParameter("DateandTime", dateandTime) :
                new ObjectParameter("DateandTime", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateScheduleAppointment", scheduleIDParameter, dNameParameter, dateandTimeParameter);
        }
    }
}
