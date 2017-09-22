using LitJson;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class JsonGet
    {
        public long jsonCoin { get; private set; }
        public string Nickname = null;

        public JsonGet()
        {
            jsonCoin = 0;
        }
        public JsonGet(string nickname)
        {
            this.Nickname = nickname;
        }

        public JsonGet(JsonData jData)
        {
            Update(jData);
        }

        public void Update(JsonData jData)
        {
            jsonCoin = long.Parse(jData["coin"].ToString());
            Nickname = jData["nickname"].ToString();

            Debug.Log("@@@@@@@@@@@@@@JsonGet@@@@@@@@@@@@@@");
            //if (Profile.instance != null)
            //{
            //    Profile.instance.UpdatePoint();
            //}
        }
        
    }
    
}
