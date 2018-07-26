package Arrays;

import java.util.ArrayList;
import java.util.Scanner;

public class BombNumbers {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String[] input = scanner.nextLine().split(" ");

        ArrayList<Integer> numbs = new ArrayList<>();

        for (int i = 0; i < input.length; i++) {
            numbs.add(Integer.parseInt(input[i]));
        }

        String[] settings = scanner.nextLine().split(" ");

        int specialNum = Integer.parseInt(settings[0]);
        int bombPower = Integer.parseInt(settings[1]);

        for (int i = 0; i < numbs.size(); i++) {
            if (numbs.get(i) == specialNum) {

                if (i + bombPower > numbs.size()) {
                    numbs.subList(i - bombPower, numbs.size()).clear();
                } else if (i - bombPower < 0) {
                    numbs.subList(0, i + 1 + bombPower).clear();
                } else {
                    numbs.subList(i - bombPower, i + 1 + bombPower).clear();
                }
                i = 0;
            }
        }

        int sum = 0;

        for (int num : numbs) {
            sum += num;
        }

        System.out.println(sum);
    }
}
