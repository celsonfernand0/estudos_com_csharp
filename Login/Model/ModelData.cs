using System;
using Login.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Login.Model
{
    public class ModelData
    {
        public List<DataBase> _DataBase = new List<DataBase>(){
            new DataBase(){
            userNome ="Celson Fernando",
            userPassword ="8850"
            },
            new DataBase(){
                userNome="Manuel Carlos",
                userPassword="0014"
            },
            new DataBase(){
                userNome ="Anderez Martinez",
                userPassword = "Andrez "
            }


        };


    }
}