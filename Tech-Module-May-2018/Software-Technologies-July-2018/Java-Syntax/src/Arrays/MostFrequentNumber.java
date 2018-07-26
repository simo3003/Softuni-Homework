package Arrays;

import java.util.*;

public class MostFrequentNumber {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String[] input = scanner.nextLine().split(" ");

        int[] numbs = new int[input.length];
        for (int i = 0; i < input.length; i++) {
            numbs[i] = Integer.parseInt(input[i]);
        }

        Map<Integer, Integer> numCount = new LinkedHashMap<>();

        for (int num : numbs) {
            if (numCount.containsKey(num)) {
                int count = numCount.get(num) + 1;
                numCount.put(num, count);
            } else {
                numCount.put(num, 1);
            }
        }

        int max = Collections.max(numCount.values());

        for (Map.Entry<Integer, Integer> KvP : numCount.entrySet()) {
            if (KvP.getValue() == max) {
                System.out.println(KvP.getKey());
                break;
            }
        }
    }
}
