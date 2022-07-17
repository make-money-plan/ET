//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;
using SimpleJSON;



namespace ET.Editor.UnitConfig
{

public sealed partial class UnitResConfig :  Bright.Config.EditorBeanBase 
{
    public UnitResConfig()
    {
            PrefabName = "";
    }

    public override void LoadJson(SimpleJSON.JSONObject _json)
    {
        { 
            var _fieldJson = _json["Id"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  Id = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["PrefabName"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsString) { throw new SerializationException(); }  PrefabName = _fieldJson;
            }
        }
        
    }

    public override void SaveJson(SimpleJSON.JSONObject _json)
    {
        {
            _json["Id"] = new JSONNumber(Id);
        }
        {

            if (PrefabName == null) { throw new System.ArgumentNullException(); }
            _json["PrefabName"] = new JSONString(PrefabName);
        }
    }

    public static UnitResConfig LoadJsonUnitResConfig(SimpleJSON.JSONNode _json)
    {
        UnitResConfig obj = new UnitConfig.UnitResConfig();
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonUnitResConfig(UnitResConfig _obj, SimpleJSON.JSONNode _json)
    {
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

    /// <summary>
    /// Id
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Prefab名
    /// </summary>
    public string PrefabName { get; set; }

}
}
