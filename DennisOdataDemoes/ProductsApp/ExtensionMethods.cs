
using Microsoft.OData.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ProductsApp
{
    public static class ExtensionMethods
    {
        public static void SafeSaveChange(this Func<DataServiceResponse> func, HttpStatusCode expectedCode)
        {
            var response = func.Invoke();
            foreach (OperationResponse item in response)
            {
                if (item.StatusCode != (int)expectedCode)
                {
                    string errorMessage = item.Error != null ? item.Error.ToString() : "No error message in response.";
                    throw new Exception($"[SaveChange] Failed. Status code is {item.StatusCode}, expected code is {expectedCode}, reason: {errorMessage}");
                }
                if (item.Error != null)
                {
                    throw new Exception($"[SaveChange] Error.Status code is {item.StatusCode}, expected code is {expectedCode}, reason: {item.Error.ToString()}");
                }
            }
        }
    }
}
