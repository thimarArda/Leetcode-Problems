public class RandomizedSet {
    private Dictionary<int, int> map; 
    private List<int> list;           
    private Random random;

    public RandomizedSet() {
        map = new Dictionary<int, int>();
        list = new List<int>();
        random = new Random();
    }

    public bool Insert(int val) {
        if (map.ContainsKey(val)) {
            return false;
        }

        map[val] = list.Count;
        list.Add(val);
        return true;
    }

    public bool Remove(int val) {
        if (!map.ContainsKey(val)) {
            return false;
        }

        int index = map[val];
        int last = list[list.Count - 1];

        list[index] = last;
        map[last] = index;

        list.RemoveAt(list.Count - 1);
        map.Remove(val);

        return true;
    }

    public int GetRandom() {
        int index = random.Next(list.Count);
        return list[index];
    }
}
