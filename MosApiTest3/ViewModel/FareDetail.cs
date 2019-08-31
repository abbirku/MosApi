using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MosApiTest3.ViewModel
{
    public class FareDetail
    {
        public string SrNo { get; set; }
        public double AdultBaseFare { get; set; }
        public double ChildBaseFare { get; set; }
        public double InfantBaseFare { get; set; }
        public double AdultTax { get; set; }
        public double ChildTax { get; set; }
        public double InfantTax { get; set; }
        public double AdultFuelCharges { get; set; }
        public double ChildFuelCharges { get; set; }
        public double InfantFuelCharges { get; set; }
        public double AdultPassengerServiceFee { get; set; }
        public double ChildPassengerServiceFee { get; set; }
        public double InfantPassengerServiceFee { get; set; }
        public double AdultTransactionFee { get; set; }
        public double ChildTransactionFee { get; set; }
        public double InfantTransactionFee { get; set; }
        public double AdultServiceCharges { get; set; }
        public double ChildServiceCharges { get; set; }
        public double InfantServiceCharges { get; set; }
        public double AdultAirportTax { get; set; }
        public double ChildAirportTax { get; set; }
        public double InfantAirportTax { get; set; }
        public double AdultAirportDevelopmentFee { get; set; }
        public double AdultCuteFee { get; set; }
        public double AdultConvenienceFee { get; set; }
        public double AdultSkyCafeMeals { get; set; }
        public double ChildAirportDevelopmentFee { get; set; }
        public double ChildCuteFee { get; set; }
        public double ChildConvenienceFee { get; set; }
        public double ChildSkyCafeMeals { get; set; }
        public double InfantAirportDevelopmentFee { get; set; }
        public double InfantCuteFee { get; set; }
        public double InfantConvenienceFee { get; set; }
        public double InfantSkyCafeMeals { get; set; }
        public double TotalAmount { get; set; }
        public double TotalFlightCommissionAmount { get; set; }
        public double TDSAmount { get; set; }
        public double ServiceTax { get; set; }
        public double ServiceCharge { get; set; }
        public double IsFixedInventory { get; set; }
        public double AdultCGST { get; set; }
        public double ChildCGST { get; set; }
        public double InfantCGST { get; set; }
        public double AdultSGST { get; set; }
        public double ChildSGST { get; set; }
        public double InfantSGST { get; set; }
        public double AdultIGST { get; set; }
        public double ChildIGST { get; set; }
        public double InfantIGST { get; set; }
        public string Baggage { get; set; }
        public double ServiceTaxOnComm { get; set; }
        public double NetAmount { get; set; }
    }
}