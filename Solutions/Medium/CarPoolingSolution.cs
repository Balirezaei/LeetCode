namespace Solutions.Medium
{
    public class CarPoolingSolution
    {
        public bool CarPooling(int[][] trips, int capacity)
        {
            if (CheckCondition(trips, capacity))
            {
                var capacityPerPoint = new int[1000];
                for (int i = 0; i < trips.Length; i++)
                {
                    for (int j = trips[i][1]; j < trips[i][2]; j++)
                    {
                        capacityPerPoint[j] = (capacityPerPoint[j]) + trips[i][0];
                        if (capacityPerPoint[j] > capacity)
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
            return false;
        }
        private bool CheckCondition(int[][] trips, int capacity)
        {
            if (trips.Length > 1000 || trips.Length < 1)
            {
                return false;
            }
            for (int i = 0; i < trips.Length; i++)
            {
                if (trips[i].Length != 3)
                {
                    return false;
                }
                if (trips[i][0] < 1 || trips[i][0] > 100)
                    return false;
                var fromi = trips[i][1];
                var toi = trips[i][2];
                if (fromi < 0 || toi > 1000 || (fromi > toi))
                {
                    return false;
                }
            }
            if (capacity > 100000 || capacity < 1)
            {
                return false;
            }
            return true;
        }
    }
}