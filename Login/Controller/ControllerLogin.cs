using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Login.Data;
using Microsoft.VisualBasic;

namespace Login.Controller
{
    public class ControllerLogin : Model.ModelData
    {
        public string? name { get; set; }
        public string? password { get; set; }
        public string? Acessname { get; set; }

        public string? Acesspassword { get; set; }

        bool cond;


        public bool ActionController()
        {

            foreach (var item in _DataBase)
            {
                if (name == item.userNome && password == item.userPassword)
                {
                    cond = true;
                    Acessname = item.userNome;
                    Acesspassword = item.userPassword;
                }


            }

            return cond;

        }


    }

}