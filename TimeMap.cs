public class TimeMap {
    public Dictionary<string, List<Tuple<string, int>>> map;
    //public int latestTimeStamp;
    public TimeMap(){
        this.map = new Dictionary<string, List<Tuple<string, int>>>();
    }
    
    public void Set(string key, string value, int timestamp) {
        if(!map.ContainsKey(key)) map[key] = new List<Tuple<string, int>>();
        map[key].Add(Tuple.Create(value, timestamp));
    }
    
    public string Get(string key, int timestamp) {
        if(!map.ContainsKey(key)) return "";
        var list = map[key];
        if(timestamp >= list[list.Count-1].Item2) return list[list.Count-1].Item1;
        int left = 0;
        int right = list.Count-1;
        string res = "";
        while(left < right){
            int mid = left + (right-left) / 2;
            if(list[mid].Item2 <= timestamp){
                res = list[mid].Item1;
                left = mid + 1;
            } else {
                right = mid - 1;
            }
        }
        return res;
    }
}