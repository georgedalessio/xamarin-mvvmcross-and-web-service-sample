﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using XamMvvmAndWebServices.Models;

namespace XamMvvmAndWebServices.Models
{
    public static partial class EmployeeCollection
    {
        /// <summary>
        /// Deserialize the object
        /// </summary>
        public static IList<Employee> DeserializeJson(JToken inputObject)
        {
            IList<Employee> deserializedObject = new List<Employee>();
            foreach (JToken iListValue in ((JArray)inputObject))
            {
                Employee employee = new Employee();
                employee.DeserializeJson(iListValue);
                deserializedObject.Add(employee);
            }
            return deserializedObject;
        }
    }
}
