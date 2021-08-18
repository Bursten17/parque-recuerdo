using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using morcom_api.Application.Contracts.Response.IdentityService;
using MoreLinq;

namespace morcom_api.Application.Utils
{
    public static class General
    {
        public static string GetNameWithCurrentDate(string name)
        {
            // return (name + "_" + DateTime.Now.Day + "_" + Date);
            return ($"{name}_{DateTime.Now.Date.ToString("MM/dd/yyyy")}_{DateTime.Now.Hour}-{DateTime.Now.Minute}-{DateTime.Now.Second}");
        }

        public static string GetLogoDirectory(String httpSchema, String host)
        {
            var rutaLogo = $@"{httpSchema}://{host}/images/logo-poseidon-1.jpg";
            return rutaLogo;
        }

        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        public static decimal GetNumberTwoDecimal(decimal number)
        {
            var format = ".00";
            var numberTruncate = Math.Truncate(number * 100) / 100;
            var numberFormat = numberTruncate.ToString(format);
            var result = Convert.ToDecimal(numberFormat);
            return result;
        }

        public static void GetModules(List<UserModuleResponse> listModules, List<UserRoleOperation> rolOperation)
        {
            //REFACTORIZAR
            // agrupamiento de:
            // - Modulos con solo operaciones
            // - Modulos con submodulos y operaciones por cada uno
            var groupModules = rolOperation.GroupBy(x => x.s_name_parent).Select(g => g.ToList()).ToList();

            foreach (var itemGroupModules in groupModules)
            {
                // si el nombre parent del registro no es nulo
                // ejecuto un distinc para identificar los modulos 
                // que contienen submodulos.
                // de los contario si el nombre parent es nulo
                // identifico los modulos
                var filterGroup = itemGroupModules.FirstOrDefault().s_name_parent != null
                                ? itemGroupModules.DistinctBy(x => x.s_name_parent).ToList()
                                : itemGroupModules.DistinctBy(x => x.n_id_module).ToList();

                foreach (var itemFilterGroup in filterGroup)
                {
                    //instancio la clase(UserModuleResponse) que me permite agregar un 
                    // objectModule a mi lista listModulo
                    UserModuleResponse objectModule = new UserModuleResponse();
                    objectModule.n_id_module = string.IsNullOrEmpty(itemFilterGroup.s_name_parent) ? itemFilterGroup.n_id_module : itemFilterGroup.n_parent;
                    objectModule.s_name_modulo = string.IsNullOrEmpty(itemFilterGroup.s_name_parent) ? itemFilterGroup.s_name_modulo : itemFilterGroup.s_name_parent;

                    if (itemGroupModules.FirstOrDefault().s_name_parent != null)
                    {
                        List<UserModuleResponse> listSubmodule = new List<UserModuleResponse>();
                        // submodulos
                        foreach (var itemSubmodule in rolOperation.Where(x => x.s_name_parent != null
                                                                                         && x.n_parent == itemFilterGroup.n_parent)
                                                                                  .DistinctBy(z => z.n_id_module).ToList())
                        {
                            UserModuleResponse objectSubModule = new UserModuleResponse();
                            objectSubModule.n_id_module = itemSubmodule.n_id_module;
                            objectSubModule.s_name_modulo = itemSubmodule.s_name_modulo;
                            objectSubModule.s_to = itemSubmodule.s_to;
                            objectSubModule.s_icon = itemSubmodule.s_icon;

                            List<UserOperation> operaciones = new List<UserOperation>();
                            foreach (var itemOperation in rolOperation.Where(x => x.n_id_module == itemSubmodule.n_id_module).ToList())
                            {
                                UserOperation userOperation = new UserOperation();

                                userOperation.n_id_operation = itemOperation.n_id_operation;
                                userOperation.s_name_operation = itemOperation.s_name_operation;
                                userOperation.n_state_operation = itemOperation.n_state_operation;
                                userOperation.n_state_rol_operation = itemOperation.n_state_rol_operation;
                                operaciones.Add(userOperation);
                            }
                            objectSubModule.a_operation = operaciones;
                            listSubmodule.Add(objectSubModule);
                        }

                        objectModule.a_submodule = listSubmodule;
                    }
                    else
                    {
                        //operaciones por modulo
                        List<UserOperation> listadoOperaciones = new List<UserOperation>();
                        foreach (var itemOperation in rolOperation.Where(x => x.s_name_parent == null && x.n_id_module == itemFilterGroup.n_id_module).ToList())
                        {
                            UserOperation operaciones = new UserOperation();
                            operaciones.n_id_operation = itemOperation.n_id_operation;
                            operaciones.s_name_operation = itemOperation.s_name_operation;
                            operaciones.n_state_operation = itemOperation.n_state_operation;
                            operaciones.n_state_rol_operation = itemOperation.n_state_rol_operation;
                            listadoOperaciones.Add(operaciones);
                        }
                        objectModule.s_to = itemFilterGroup.s_to;
                        objectModule.s_icon = itemFilterGroup.s_icon;
                        objectModule.a_operation = listadoOperaciones;
                    }
                    listModules.Add(objectModule);
                }
            }
        }
    }
}