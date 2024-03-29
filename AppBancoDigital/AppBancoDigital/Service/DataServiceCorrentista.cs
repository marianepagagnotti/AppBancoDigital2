﻿using AppBancoDigital.Model;
using AppBancoDigital.Service;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppBancoDigital.Service
{
    public class DataServiceCorrentista : DataService
    {

        /*public static async Task<List<Correntista>> GetPessoasAsync()
        {
            string json = await DataService.GetDataFromService("/correntista");

            List<Correntista> arr_correntistas = JsonConvert.DeserializeObject<List<Correntista>>(json);

            return arr_correntistas;
        }*/

        public static async Task<Correntista> Cadastrar(Correntista c)
        {
            var json_a_enviar = JsonConvert.SerializeObject(c);
            string json = await DataService.PostDataToService(json_a_enviar, "/correntista/save");

            // Verifica se retorna um json, caso contrário retorna null.
            if (json == "false")
                return null;

            Correntista correntista = JsonConvert.DeserializeObject<Correntista>(json);

            return correntista;
        }

        public static async Task<Correntista> Login(Correntista c)
        {
            var json_to_send = JsonConvert.SerializeObject(c);

            Console.WriteLine("_______________________________ A ENVIAR");
            Console.WriteLine(json_to_send);
            Console.WriteLine("_______________________________");



            string json = await DataService.PostDataToService(json_to_send, "/correntista/entrar");

            return JsonConvert.DeserializeObject<Correntista>(json);
        }
        public static async Task<List<Correntista>> DeleteAsync(int id)
        {
            var json_a_enviar = JsonConvert.SerializeObject(id);

            string json = await DataService.PostDataToService(json_a_enviar, "/correntista/delete");

            List<Correntista> arr_correntistas = JsonConvert.DeserializeObject<List<Correntista>>(json);

            return arr_correntistas;
        }

    }
}
