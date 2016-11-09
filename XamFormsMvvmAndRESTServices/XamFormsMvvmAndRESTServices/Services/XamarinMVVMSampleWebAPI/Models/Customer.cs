﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Rest;
using Newtonsoft.Json.Linq;
using XamMvvmAndWebServices.Models;

namespace XamMvvmAndWebServices.Models
{
    public partial class Customer
    {
        private string _address;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string Address
        {
            get { return this._address; }
            set { this._address = value; }
        }
        
        private string _city;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string City
        {
            get { return this._city; }
            set { this._city = value; }
        }
        
        private string _customerName;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string CustomerName
        {
            get { return this._customerName; }
            set { this._customerName = value; }
        }
        
        private DateTimeOffset? _dateJoined;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public DateTimeOffset? DateJoined
        {
            get { return this._dateJoined; }
            set { this._dateJoined = value; }
        }
        
        private Employee _employee;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public Employee Employee
        {
            get { return this._employee; }
            set { this._employee = value; }
        }
        
        private int? _employeeId;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public int? EmployeeId
        {
            get { return this._employeeId; }
            set { this._employeeId = value; }
        }
        
        private int? _id;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public int? Id
        {
            get { return this._id; }
            set { this._id = value; }
        }
        
        private IList<Order> _orders;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public IList<Order> Orders
        {
            get { return this._orders; }
            set { this._orders = value; }
        }
        
        private string _telNumber;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string TelNumber
        {
            get { return this._telNumber; }
            set { this._telNumber = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the Customer class.
        /// </summary>
        public Customer()
        {
            this.Orders = new LazyList<Order>();
        }
        
        /// <summary>
        /// Deserialize the object
        /// </summary>
        public virtual void DeserializeJson(JToken inputObject)
        {
            if (inputObject != null && inputObject.Type != JTokenType.Null)
            {
                JToken addressValue = inputObject["Address"];
                if (addressValue != null && addressValue.Type != JTokenType.Null)
                {
                    this.Address = ((string)addressValue);
                }
                JToken cityValue = inputObject["City"];
                if (cityValue != null && cityValue.Type != JTokenType.Null)
                {
                    this.City = ((string)cityValue);
                }
                JToken customerNameValue = inputObject["CustomerName"];
                if (customerNameValue != null && customerNameValue.Type != JTokenType.Null)
                {
                    this.CustomerName = ((string)customerNameValue);
                }
                JToken dateJoinedValue = inputObject["DateJoined"];
                if (dateJoinedValue != null && dateJoinedValue.Type != JTokenType.Null)
                {
                    this.DateJoined = ((DateTimeOffset)dateJoinedValue);
                }
                JToken employeeValue = inputObject["Employee"];
                if (employeeValue != null && employeeValue.Type != JTokenType.Null)
                {
                    Employee employee = new Employee();
                    employee.DeserializeJson(employeeValue);
                    this.Employee = employee;
                }
                JToken employeeIdValue = inputObject["EmployeeId"];
                if (employeeIdValue != null && employeeIdValue.Type != JTokenType.Null)
                {
                    this.EmployeeId = ((int)employeeIdValue);
                }
                JToken idValue = inputObject["Id"];
                if (idValue != null && idValue.Type != JTokenType.Null)
                {
                    this.Id = ((int)idValue);
                }
                JToken ordersSequence = ((JToken)inputObject["Orders"]);
                if (ordersSequence != null && ordersSequence.Type != JTokenType.Null)
                {
                    foreach (JToken ordersValue in ((JArray)ordersSequence))
                    {
                        Order order = new Order();
                        order.DeserializeJson(ordersValue);
                        this.Orders.Add(order);
                    }
                }
                JToken telNumberValue = inputObject["TelNumber"];
                if (telNumberValue != null && telNumberValue.Type != JTokenType.Null)
                {
                    this.TelNumber = ((string)telNumberValue);
                }
            }
        }
        
        /// <summary>
        /// Serialize the object
        /// </summary>
        /// <returns>
        /// Returns the json model for the type Customer
        /// </returns>
        public virtual JToken SerializeJson(JToken outputObject)
        {
            if (outputObject == null)
            {
                outputObject = new JObject();
            }
            if (this.Address != null)
            {
                outputObject["Address"] = this.Address;
            }
            if (this.City != null)
            {
                outputObject["City"] = this.City;
            }
            if (this.CustomerName != null)
            {
                outputObject["CustomerName"] = this.CustomerName;
            }
            if (this.DateJoined != null)
            {
                outputObject["DateJoined"] = this.DateJoined.Value;
            }
            if (this.Employee != null)
            {
                outputObject["Employee"] = this.Employee.SerializeJson(null);
            }
            if (this.EmployeeId != null)
            {
                outputObject["EmployeeId"] = this.EmployeeId.Value;
            }
            if (this.Id != null)
            {
                outputObject["Id"] = this.Id.Value;
            }
            JArray ordersSequence = null;
            if (this.Orders != null)
            {
                if (this.Orders is ILazyCollection<Order> == false || ((ILazyCollection<Order>)this.Orders).IsInitialized)
                {
                    ordersSequence = new JArray();
                    outputObject["Orders"] = ordersSequence;
                    foreach (Order ordersItem in this.Orders)
                    {
                        if (ordersItem != null)
                        {
                            ordersSequence.Add(ordersItem.SerializeJson(null));
                        }
                    }
                }
            }
            if (this.TelNumber != null)
            {
                outputObject["TelNumber"] = this.TelNumber;
            }
            return outputObject;
        }
    }
}
