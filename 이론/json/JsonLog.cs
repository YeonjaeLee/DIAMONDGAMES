using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LitJson;
using Data;
using System.Text;

public class JsonLog : MonoBehaviour {
    public static JsonLog instance;
    private List<PlayerProfile> FriendList;

    PlayerProfile plcoin;
    //string coin;

    public static JsonGet jsget
    {
        get
        {
            return instance.jsonget;
        }
    }

    public JsonGet jsonget = new JsonGet();

    void Awake()
    {
        instance = this;
    }

    public void Log()
    {
        //var friendList = NetworkManager.instance.GetRoomUser();
        Debug.Log(UserInfoManager.instance.userProfile.ToString());
        Debug.Log("@@@@@@@@@@@@@@@@@@@@@json/csjsonlog");
        long coin = jsget.jsonCoin;
        string nick = jsget.Nickname;
        //long coin = UserInfoManager.Point.Coin;
        //Debug.LogFormat("Profile.cs Coin:{0}", coin);
        //coin = plcoin.Coin.ToString();
        Debug.Log("@@@@@@@@@@@@@@@@@@@@@coin: " + coin);
        Debug.Log("@@@@@@@@@@@@@@@@@@@@@nick: " + nick);

        //(cs)userpoint.Coin -> NetworkManager->profile.update(jdata["user_profile"]);

        /*
         * WriterConfiguration.cs (https://gist.github.com/whoo24/5506804)
         * 
        JsonWriter writer = new JsonWriter(json);
        writer.PrettyPrint = true;  // 한줄로 JsonText를 생성하지않고 사람이 읽기 쉽게 출력
        writer.IndentValue = 2;     // 들여쓰기

        JsonMapper.ToJson(obj, writer);
        */
    }
    public void UpdateFriendList(JsonData jData)
    {
        if (instance.FriendList == null)
        {
            instance.FriendList = new List<PlayerProfile>();
        }
        instance.FriendList.Clear();

        foreach (JsonData e in jData)
        {
            PlayerProfile f = new PlayerProfile(e);
            instance.FriendList.Add(f);
        }

        Debug.Log("@@@@@@@@@@@@@@@@@@@@@json/csjsonlog");
        //NetworkManager.OnLoginResult(jData);
        Debug.Log(JsonUtility.ToJson(jData, prettyPrint: true));
        Debug.Log(jData["nickname"].ToString());
    }
}
