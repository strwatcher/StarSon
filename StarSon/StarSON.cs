namespace StarSON;

public class StarSON
{
    public string Serialize(object obj)
    {
        string res = String.Empty;
        if (obj is int || obj is long || obj is short || obj is char ||
            obj is float || obj is double || obj is decimal)
        {
            return obj.ToString();
        }

        if (obj is String) return $"\"{obj}\"";

        if (obj is List<object> list)
        {
            res += "[";
            foreach (var element in list)
            { 
                res += Serialize(element) + ",";
            }

            return res.Substring(0, res.Length - 1) + "]";
        }

        if (obj is Dictionary<string, object> dict)
        {
            res += "{";
            foreach (var pair in dict)
            {
                res += $"{pair.Key}:{Serialize(pair.Value)},";
            }
            
            return res.Substring(0, res.Length - 1) + "}";
        }

        return "";
    }

    public object Deserialize(string json)
    {
        return "";
    }
}