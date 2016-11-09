﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Rest;
using XamMvvmAndWebServices;
using XamMvvmAndWebServices.Models;

namespace XamMvvmAndWebServices
{
    public static partial class CustomersExtensions
    {
        /// <param name='operations'>
        /// Reference to the XamMvvmAndWebServices.ICustomers.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        public static Customer DeleteCustomer(this ICustomers operations, int id)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ICustomers)s).DeleteCustomerAsync(id);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the XamMvvmAndWebServices.ICustomers.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<Customer> DeleteCustomerAsync(this ICustomers operations, int id, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<XamMvvmAndWebServices.Models.Customer> result = await operations.DeleteCustomerWithOperationResponseAsync(id, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the XamMvvmAndWebServices.ICustomers.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        public static Customer GetCustomer(this ICustomers operations, int id)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ICustomers)s).GetCustomerAsync(id);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the XamMvvmAndWebServices.ICustomers.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<Customer> GetCustomerAsync(this ICustomers operations, int id, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<XamMvvmAndWebServices.Models.Customer> result = await operations.GetCustomerWithOperationResponseAsync(id, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the XamMvvmAndWebServices.ICustomers.
        /// </param>
        public static IList<Customer> GetCustomers(this ICustomers operations)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ICustomers)s).GetCustomersAsync();
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the XamMvvmAndWebServices.ICustomers.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<IList<Customer>> GetCustomersAsync(this ICustomers operations, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<System.Collections.Generic.IList<XamMvvmAndWebServices.Models.Customer>> result = await operations.GetCustomersWithOperationResponseAsync(cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the XamMvvmAndWebServices.ICustomers.
        /// </param>
        /// <param name='customer'>
        /// Required.
        /// </param>
        public static Customer PostCustomer(this ICustomers operations, Customer customer)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ICustomers)s).PostCustomerAsync(customer);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the XamMvvmAndWebServices.ICustomers.
        /// </param>
        /// <param name='customer'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<Customer> PostCustomerAsync(this ICustomers operations, Customer customer, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<XamMvvmAndWebServices.Models.Customer> result = await operations.PostCustomerWithOperationResponseAsync(customer, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the XamMvvmAndWebServices.ICustomers.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        /// <param name='customer'>
        /// Required.
        /// </param>
        public static object PutCustomer(this ICustomers operations, int id, Customer customer)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ICustomers)s).PutCustomerAsync(id, customer);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the XamMvvmAndWebServices.ICustomers.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        /// <param name='customer'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<object> PutCustomerAsync(this ICustomers operations, int id, Customer customer, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<object> result = await operations.PutCustomerWithOperationResponseAsync(id, customer, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
    }
}
