
using Microsoft.OData.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProductsApp
{
    public static class ExtensionMethods
    {
        public static void SafeSaveChange(this Func<DataServiceResponse> func, HttpStatusCode expectedCode, Type entityType = null)
        {
            var response = func.Invoke();
            string errorMessage = string.Empty;

            foreach (OperationResponse item in response)
            {
                #region The insert operation's Savechange() need to check response's entity type and entity id
                if (entityType != null && item.StatusCode == (int)HttpStatusCode.Created)
                {
                    try
                    {
                        ChangeOperationResponse changeOperationResponse = item as ChangeOperationResponse;
                        if (changeOperationResponse == null)
                        {
                            errorMessage += $"[Check item's entity id Error] : Cannot convert the response to ChangeOperationResponse type. \n";
                            continue;
                        }

                        EntityDescriptor entityDescriptor = changeOperationResponse.Descriptor as EntityDescriptor;
                        if (entityDescriptor == null)
                        {
                            errorMessage += $"[Check item's entity id Error] : Cannot convert the response to EntityDescriptor type. \n";
                            continue;
                        }

                        var responseEntity = entityDescriptor.Entity;
                        if (responseEntity == null)
                        {
                            errorMessage += $"[Check item's entity id Error] : Cannot get the response entity. \n";
                            continue;
                        }

                        var responseEntityType = responseEntity.GetType();
                        if (responseEntityType == entityType)
                        {
                            PropertyInfo propertyInfo = responseEntityType.GetProperty("Id");
                            if (propertyInfo == null)
                            {
                                errorMessage += $"[Check item's entity id Error] : Cannot get the Id property in the response entity. \n";
                                continue;
                            }

                            int value = (int)propertyInfo.GetValue(responseEntity, null);
                            if (value == 0)
                            {
                                errorMessage += $"[Check item's entity id Error] : Status code is {item.StatusCode}, expected code is {expectedCode}, error message: {errorMessage}. \n";
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        throw new Exception($"[SaveChange] Unexpected error during check entity's id, error: {e}");
                    }
                }
                #endregion

                #region Savechange() need check response's status code and error message
                if (item.StatusCode != (int)expectedCode || item.Error != null)
                {
                    var error = item.Error != null ? item.Error.ToString() : "No error message in response.";
                    errorMessage += $"[Check item's status code Error] : Status code is {item.StatusCode}, expected code is {expectedCode}, error message: {errorMessage}. \n";
                }
                #endregion
            }

            if (!string.IsNullOrEmpty(errorMessage))
            {
                throw new Exception($"[SaveChange] Failed. \n Error: {errorMessage}");
            }
        }
    }
}
