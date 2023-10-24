﻿using AppBancoDigital.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppBancoDigital.Service
{
    public class DataServiceChavePix
    {
        public static async Task<object> Adicionar(ChavePix ChaveModel)
        {
            string json = JsonConvert.SerializeObject(ChaveModel);

            string response = await DataService.PostDataToService(json, "/conta/pix/adicionar");

            var obj = JsonConvert.DeserializeObject(response);

            ChavePix chavePix = obj as ChavePix;

            return obj as ChavePix;

        }

        public static async Task<List<ChavePix>> listar(int id_conta)
        {
            var json_a_enviar = JsonConvert.SerializeObject(id_conta);

            string json = await DataService.PostDataToService(json_a_enviar, "/conta/pix/listar");

            List<ChavePix> arr_chave = JsonConvert.DeserializeObject<List<ChavePix>>(json);

            return arr_chave;
        }

    }
}
